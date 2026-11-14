using KumaEngine.GLFW.Native;
using System;
using System.Numerics;
using System.Text;

namespace KumaEngine.Glfw.Source
{
    public unsafe struct Window(GLFWwindow* handle)
    {
        public static readonly Window NULL = new(null);

        public GLFWwindow* Handle { get; } = handle;

        public bool ShouldClose
        {
            get => GLFWNative.glfwWindowShouldClose(Handle) != 0;
            set => GLFWNative.glfwSetWindowShouldClose(Handle, value ? 1 : 0);
        }

        public string Title
        {
            get => new(GLFWNative.glfwGetWindowTitle(Handle));
            set
            {
                fixed (byte* titlePtr = Encoding.UTF8.GetBytes(value))
                    GLFWNative.glfwSetWindowTitle(Handle, (sbyte*)titlePtr);
            }
        }

        public Vector2 ContentScale
        {
            get
            {
                float x = 0, y = 0;
                GLFWNative.glfwGetWindowContentScale(Handle, &x, &y);
                return new(x, y);
            }
        }

        public Vector2 FramebufferSize
        {
            get
            {
                int w = 0, h = 0;
                GLFWNative.glfwGetFramebufferSize(Handle, &w, &h);
                return new(w, h);
            }
        }

        public Vector2 Position
        {
            get
            {
                int x = 0, y = 0;
                GLFWNative.glfwGetWindowPos(Handle, &x, &y);
                return new(x, y);
            }
            set => GLFWNative.glfwSetWindowPos(Handle, (int)value.X, (int)value.Y);
        }

        public Vector2 Size
        {
            get
            {
                int x = 0, y = 0;
                GLFWNative.glfwGetWindowSize(Handle, &x, &y);
                return new(x, y);
            }
            set => GLFWNative.glfwSetWindowSize(Handle, (int)value.X, (int)value.Y);
        }

        public Monitor Monitor => new(GLFWNative.glfwGetWindowMonitor(Handle));

        public float Opacity
        {
            get => GLFWNative.glfwGetWindowOpacity(Handle);
            set => GLFWNative.glfwSetWindowOpacity(Handle, value);
        }

        public void Destroy() => GLFWNative.glfwDestroyWindow(Handle);

        public void MakeContextCurrent() => GLFWNative.glfwMakeContextCurrent(Handle);

        public void SwapBuffers() => GLFWNative.glfwSwapBuffers(Handle);

        public void Show() => GLFWNative.glfwShowWindow(Handle);
        public void Hide() => GLFWNative.glfwHideWindow(Handle);
        public void Focus() => GLFWNative.glfwFocusWindow(Handle);
        public void Iconify() => GLFWNative.glfwIconifyWindow(Handle);
        public void Restore() => GLFWNative.glfwRestoreWindow(Handle);
        public void Maximize() => GLFWNative.glfwMaximizeWindow(Handle);

        public int GetAttribute(GLFWWindowAttrib attrib) => GLFWNative.glfwGetWindowAttrib(Handle, (int)attrib);
        public void SetAttribute(GLFWWindowAttrib attrib, int value) => GLFWNative.glfwSetWindowAttrib(Handle, (int)attrib, value);

        public GLFWAction GetKey(GLFWKey key) => (GLFWAction)GLFWNative.glfwGetKey(Handle, (int)key);
        public GLFWAction GetMouseButton(GLFWMouseButton button) => (GLFWAction)GLFWNative.glfwGetMouseButton(Handle, (int)button);

        public Vector2 CursorPos
        {
            get
            {
                double x = 0, y = 0;
                GLFWNative.glfwGetCursorPos(Handle, &x, &y);
                return new((float)x, (float)y);
            }
            set => GLFWNative.glfwSetCursorPos(Handle, value.X, value.Y);
        }

        public void SetInputMode(GLFWInputMode mode, int value) => GLFWNative.glfwSetInputMode(Handle, (int)mode, value);
        public void SetCursorMode(GLFWCursorMode mode) => GLFWNative.glfwSetInputMode(Handle, (int)GLFWInputMode.Cursor, (int)mode);
        public void SetCursor(Cursor cursor) => GLFWNative.glfwSetCursor(Handle, cursor.Handle);

        public void SetMonitor(Monitor mon, int x, int y, int w, int h, int refreshRate) =>
            GLFWNative.glfwSetWindowMonitor(Handle, mon.Handle, x, y, w, h, refreshRate);

        public void SetIcon(params GLFWimage[] icons)
        {
            fixed (GLFWimage* images = icons)
                GLFWNative.glfwSetWindowIcon(Handle, icons.Length, images);
        }

        public void SetKeyCallback(delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, int, int, void> callback)
            => GLFWNative.glfwSetKeyCallback(Handle, callback);

        public void SetFramebufferSizeCallback(delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, void> callback)
            => GLFWNative.glfwSetFramebufferSizeCallback(Handle, callback);

        public void SetCursorPosCallback(delegate* unmanaged[Cdecl]<GLFWwindow*, double, double, void> callback)
            => GLFWNative.glfwSetCursorPosCallback(Handle, callback);

        public void SetMouseButtonCallback(delegate* unmanaged[Cdecl]<GLFWwindow*, int, int, int, void> callback)
            => GLFWNative.glfwSetMouseButtonCallback(Handle, callback);

        public IntPtr GetNativeWindowHandle()
        {
            return Glfw.GetPlatform() switch
            {
                GLFWPlatform.Win32 => (IntPtr)GLFWNativePlatform.glfwGetWin32Window(Handle),
                GLFWPlatform.Cocoa => (IntPtr)GLFWNativePlatform.glfwGetCocoaWindow(Handle),
                GLFWPlatform.Wayland => (IntPtr)GLFWNativePlatform.glfwGetWaylandWindow(Handle),
                GLFWPlatform.X11 => (IntPtr)GLFWNativePlatform.glfwGetX11Window(Handle),
                _ => throw new Exception("Platform not supported")
            };
        }
    }
}