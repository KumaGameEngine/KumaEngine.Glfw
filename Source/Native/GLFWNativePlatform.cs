using KumaEngine.GLFW.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KumaEngine.GLFW.Native
{
    public static unsafe partial class GLFWNativePlatform
    {
        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetWin32Window(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetWGLContext(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetCocoaWindow(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetNSGLContext(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetX11Display();

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ulong glfwGetX11Window(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetGLXContext(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetGLXWindow(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetWaylandDisplay();

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetWaylandWindow(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetEGLDisplay();

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetEGLContext(GLFWwindow* window);

        [DllImport("glfw", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glfwGetEGLSurface(GLFWwindow* window);
    }
}
