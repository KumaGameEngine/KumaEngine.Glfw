$ErrorActionPreference = "Stop"

$IsWin = ($env:OS -like "*Windows*") -or $IsWindows

$RepoRoot        = $PSScriptRoot
$GlfwSrcDir      = Join-Path $RepoRoot "glfw"
$GlfwIncludeDir  = Join-Path $GlfwSrcDir "include"
$GlfwHeader      = Join-Path $GlfwIncludeDir "GLFW/glfw3.h"
$GeneratedOutput = Join-Path $RepoRoot "Source/Native/GLFWNative.cs"

# Native commands don't throw under $ErrorActionPreference, so check exit codes manually.
function Assert-LastExit {
    param ($What)
    if ($LASTEXITCODE -ne 0) { throw "$What failed with exit code $LASTEXITCODE" }
}

Write-Host "Generating C# bindings..." -ForegroundColor Cyan

# glfw3.h is a plain C header; GLFW_INCLUDE_NONE stops it from pulling in any GL headers.
ClangSharpPInvokeGenerator `
  -f $GlfwHeader `
  -I $GlfwIncludeDir `
  --language c `
  -D GLFW_INCLUDE_NONE `
  -n "KumaEngine.GLFW.Native" `
  -l "glfw" `
  -m "GLFWNative" `
  -o $GeneratedOutput `
  --generate macro-bindings `
  --generate helper-types
Assert-LastExit "ClangSharpPInvokeGenerator"

Write-Host "Bindings generated at: $GeneratedOutput" -ForegroundColor Green

function Build-GLFW {
    param (
        $TargetRID,
        $DestinationFileName,
        $CMakeArgs,
        $BuiltRelativePath
    )

    Write-Host "--> Building native target: $TargetRID..." -ForegroundColor Yellow

    $BuildDir          = Join-Path $GlfwSrcDir "build-$TargetRID"
    $DestinationFolder = Join-Path $RepoRoot "runtimes/$TargetRID/native"

    if (Test-Path $BuildDir) {
        Remove-Item -Path $BuildDir -Recurse -Force
    }

    $FinalCMakeArgs = @(
        "-DBUILD_SHARED_LIBS=ON",
        "-DGLFW_BUILD_EXAMPLES=OFF",
        "-DGLFW_BUILD_TESTS=OFF",
        "-DGLFW_BUILD_DOCS=OFF",
        "-DGLFW_INSTALL=OFF"
    ) + $CMakeArgs

    cmake -S $GlfwSrcDir -B $BuildDir @FinalCMakeArgs
    Assert-LastExit "cmake configure ($TargetRID)"

    cmake --build $BuildDir --config Release
    Assert-LastExit "cmake build ($TargetRID)"

    if (-not (Test-Path $DestinationFolder)) {
        New-Item -ItemType Directory -Path $DestinationFolder -Force | Out-Null
    }

    $BuiltBinaryPath = Join-Path $BuildDir $BuiltRelativePath
    $FinalBinaryPath = Join-Path $DestinationFolder $DestinationFileName

    Copy-Item -Path $BuiltBinaryPath -Destination $FinalBinaryPath -Force
    Write-Host "Binary packaged to: $FinalBinaryPath" -ForegroundColor Green
}

Write-Host "Building native GLFW binaries..." -ForegroundColor Cyan

if ($IsWin) {
    # MSVC names the output glfw3.dll; we rename to glfw.dll to match [DllImport("glfw")].
    Build-GLFW `
        -TargetRID "win-x64" `
        -DestinationFileName "glfw.dll" `
        -CMakeArgs @("-A", "x64") `
        -BuiltRelativePath "src/Release/glfw3.dll"

} elseif ($IsLinux) {
    Build-GLFW `
        -TargetRID "linux-x64" `
        -DestinationFileName "libglfw.so" `
        -CMakeArgs @("-DCMAKE_BUILD_TYPE=Release") `
        -BuiltRelativePath "src/libglfw.so"

    if (Get-Command "x86_64-w64-mingw32-gcc" -ErrorAction SilentlyContinue) {
        Build-GLFW `
            -TargetRID "win-x64" `
            -DestinationFileName "glfw.dll" `
            -CMakeArgs @(
                "-DCMAKE_BUILD_TYPE=Release",
                "-DCMAKE_SYSTEM_NAME=Windows",
                "-DCMAKE_C_COMPILER=x86_64-w64-mingw32-gcc",
                "-DCMAKE_CXX_COMPILER=x86_64-w64-mingw32-g++"
            ) `
            -BuiltRelativePath "src/glfw3.dll"
    } else {
        Write-Warning "MinGW compiler (x86_64-w64-mingw32-gcc) not found. Skipping Windows cross-compilation."
    }

} elseif ($IsMacOS) {
    $Arch = if ((uname -m) -eq "arm64") { "arm64" } else { "x86_64" }
    $Rid  = if ($Arch -eq "arm64") { "osx-arm64" } else { "osx-x64" }

    Build-GLFW `
        -TargetRID $Rid `
        -DestinationFileName "libglfw.dylib" `
        -CMakeArgs @("-DCMAKE_BUILD_TYPE=Release", "-DCMAKE_OSX_ARCHITECTURES=$Arch") `
        -BuiltRelativePath "src/libglfw.3.dylib"

} else {
    Write-Error "Unsupported operating system."
}