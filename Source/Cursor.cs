using KumaEngine.GLFW.Native;
using System;

namespace KumaEngine.Glfw.Source
{
    public unsafe struct Cursor : IDisposable
    {
        public static readonly Cursor NULL = new(null);

        public GLFWcursor* Handle { get; }

        public Cursor(GLFWcursor* handle)
        {
            Handle = handle;
        }

        public static Cursor CreateStandard(GLFWCursorShape shape)
        {
            return new Cursor(GLFWNative.glfwCreateStandardCursor((int)shape));
        }

        public static Cursor Create(GLFWimage image, int xhot, int yhot)
        {
            return new Cursor(GLFWNative.glfwCreateCursor(&image, xhot, yhot));
        }

        public void Dispose()
        {
            if (Handle != null)
            {
                GLFWNative.glfwDestroyCursor(Handle);
            }
        }
    }
}