using KumaEngine.GLFW.Native;
using System;
using System.Numerics;

namespace KumaEngine.Glfw.Source
{
    public unsafe struct Monitor(GLFWmonitor* handle)
    {
        public static readonly Monitor NULL = new(null);

        public GLFWmonitor* Handle { get; } = handle;

        public string Name => new(GLFWNative.glfwGetMonitorName(Handle));

        public Vector2 Position
        {
            get
            {
                int x = 0, y = 0;
                GLFWNative.glfwGetMonitorPos(Handle, &x, &y);
                return new(x, y);
            }
        }

        public WorkArea WorkArea
        {
            get
            {
                int x = 0, y = 0, w = 0, h = 0;
                GLFWNative.glfwGetMonitorWorkarea(Handle, &x, &y, &w, &h);
                return new(x, y, w, h);
            }
        }

        public Vector2 PhysicalSize
        {
            get
            {
                int w = 0, h = 0;
                GLFWNative.glfwGetMonitorPhysicalSize(Handle, &w, &h);
                return new(w, h);
            }
        }

        public Vector2 ContentScale
        {
            get
            {
                float x = 0, y = 0;
                GLFWNative.glfwGetMonitorContentScale(Handle, &x, &y);
                return new(x, y);
            }
        }

        public VideoMode VideoMode
        {
            get
            {
                var mode = GLFWNative.glfwGetVideoMode(Handle);
                return new VideoMode(mode->width, mode->height, mode->redBits, mode->greenBits, mode->blueBits, mode->refreshRate);
            }
        }

        public VideoMode[] GetVideoModes()
        {
            int count = 0;
            var modes = GLFWNative.glfwGetVideoModes(Handle, &count);
            var result = new VideoMode[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = new VideoMode(modes[i].width, modes[i].height, modes[i].redBits, modes[i].greenBits, modes[i].blueBits, modes[i].refreshRate);
            }
            return result;
        }

        public void SetGamma(float gamma) => GLFWNative.glfwSetGamma(Handle, gamma);
    }
}