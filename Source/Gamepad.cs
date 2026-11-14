using KumaEngine.GLFW.Native;
using System;

namespace KumaEngine.Glfw.Source
{
    public readonly struct Gamepad(int id)
    {
        public int Id { get; } = id;

        public static readonly Gamepad Joystick1 = new(0);
        public static readonly Gamepad Joystick2 = new(1);
        public static readonly Gamepad Joystick3 = new(2);
        public static readonly Gamepad Joystick4 = new(3);

        public bool IsConnected => GLFWNative.glfwJoystickPresent(Id) != 0;

        public bool IsGamepad => GLFWNative.glfwJoystickIsGamepad(Id) != 0;

        public unsafe string Name
        {
            get
            {
                sbyte* namePtr = GLFWNative.glfwGetJoystickName(Id);
                return namePtr != null ? new string(namePtr) : string.Empty;
            }
        }

        public unsafe string GamepadName
        {
            get
            {
                sbyte* namePtr = GLFWNative.glfwGetGamepadName(Id);
                return namePtr != null ? new string(namePtr) : string.Empty;
            }
        }

        public unsafe float[] GetAxes()
        {
            int count = 0;
            float* axesPtr = GLFWNative.glfwGetJoystickAxes(Id, &count);
            
            if (axesPtr == null || count <= 0)
                return Array.Empty<float>();

            float[] axes = new float[count];
            for (int i = 0; i < count; i++)
            {
                axes[i] = axesPtr[i];
            }
            return axes;
        }

        public unsafe byte[] GetButtons()
        {
            int count = 0;
            byte* buttonsPtr = GLFWNative.glfwGetJoystickButtons(Id, &count);

            if (buttonsPtr == null || count <= 0)
                return Array.Empty<byte>();

            byte[] buttons = new byte[count];
            for (int i = 0; i < count; i++)
            {
                buttons[i] = buttonsPtr[i];
            }
            return buttons;
        }

        public unsafe bool TryGetState(out GLFWgamepadstate state)
        {
            state = default;
            fixed (GLFWgamepadstate* statePtr = &state)
            {
                return GLFWNative.glfwGetGamepadState(Id, statePtr) != 0;
            }
        }
    }
}