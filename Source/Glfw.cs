using KumaEngine.GLFW.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace KumaEngine.Glfw.Source
{
    public static unsafe class Glfw
    {
        public static bool Init() => GLFWNative.glfwInit() == GLFWNative.GLFW_TRUE;
        public static void Terminate() => GLFWNative.glfwTerminate();

        public static void SetInitHint(GLFWInitHint hint, int value) => GLFWNative.glfwInitHint((int)hint, value);
        public static void SetInitHint(GLFWInitHint hint, bool value) => SetInitHint(hint, value ? 1 : 0);

        public static void SetWindowHint(GLFWContextHint hint, int value) => GLFWNative.glfwWindowHint((int)hint, value);
        public static void SetWindowHint(GLFWContextHint hint, bool value) => SetWindowHint(hint, value ? 1 : 0);
        public static void SetWindowHint(GLFWWindowAttrib hint, bool value) => GLFWNative.glfwWindowHint((int)hint, value ? 1 : 0);
        public static void SetWindowHint(GLFWFramebufferHint hint, int value) => GLFWNative.glfwWindowHint((int)hint, value);

        public static GLFWPlatform GetPlatform() => (GLFWPlatform)GLFWNative.glfwGetPlatform();
        public static bool IsPlatformSupported(GLFWPlatform platform) =>
            GLFWNative.glfwPlatformSupported((int)platform) == GLFWNative.GLFW_TRUE;

        public static void SetWindowHint(GLFWContextHint hint, string value)
        {
            fixed (byte* valuePtr = Encoding.UTF8.GetBytes(value))
                GLFWNative.glfwWindowHintString((int)hint, (sbyte*)valuePtr);
        }

        public static void DefaultWindowHints() => GLFWNative.glfwDefaultWindowHints();

        public static Window CreateWindow(int width, int height, string title, Monitor monitor = default, Window share = default)
        {
            fixed (byte* titlePtr = Encoding.UTF8.GetBytes(title))
                return new(GLFWNative.glfwCreateWindow(width, height, (sbyte*)titlePtr, monitor.Handle, share.Handle));
        }

        public static Monitor GetPrimaryMonitor() => new(GLFWNative.glfwGetPrimaryMonitor());

        public static Monitor[] GetMonitors()
        {
            int num = 0;
            var mons = GLFWNative.glfwGetMonitors(&num);
            ReadOnlySpan<IntPtr> span = new(mons, num);

            List<Monitor> result = new();
            foreach (var item in span)
                result.Add(new((GLFWmonitor*)item));

            return result.ToArray();
        }

        public static void PollEvents() => GLFWNative.glfwPollEvents();
        public static void WaitEvents() => GLFWNative.glfwWaitEvents();
        public static void WaitEventsTimeout(double timeout) => GLFWNative.glfwWaitEventsTimeout(timeout);
        public static void PostEmptyEvent() => GLFWNative.glfwPostEmptyEvent();

        public static Window GetCurrentContext() => new(GLFWNative.glfwGetCurrentContext());
        public static void SwapInterval(int interval) => GLFWNative.glfwSwapInterval(interval);

        public static bool ExtensionSupported(string extension)
        {
            fixed (byte* ptr = Encoding.UTF8.GetBytes(extension))
                return GLFWNative.glfwExtensionSupported((sbyte*)ptr) != 0;
        }

        public static IntPtr GetProcAddress(string procname)
        {
            fixed (byte* ptr = Encoding.UTF8.GetBytes(procname))
                return (IntPtr)GLFWNative.glfwGetProcAddress((sbyte*)ptr);
        }

        public static unsafe void SetJoystickCallback(delegate* unmanaged[Cdecl]<int, int, void> callback) =>
            GLFWNative.glfwSetJoystickCallback(callback);

        public static double Time
        {
            get => GLFWNative.glfwGetTime();
            set => GLFWNative.glfwSetTime(value);
        }

        public static ulong TimerValue => GLFWNative.glfwGetTimerValue();
        public static ulong TimerFrequency => GLFWNative.glfwGetTimerFrequency();
    }
}