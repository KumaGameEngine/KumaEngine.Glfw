using KumaEngine.GLFW.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaEngine.Glfw.Source 
{
    public enum GLFWAction
    {
        Release = GLFWNative.GLFW_RELEASE,
        Press = GLFWNative.GLFW_PRESS,
        Repeat = GLFWNative.GLFW_REPEAT,
    }

    [Flags]
    public enum GLFWHat
    {
        Centered = GLFWNative.GLFW_HAT_CENTERED,
        Up = GLFWNative.GLFW_HAT_UP,
        Right = GLFWNative.GLFW_HAT_RIGHT,
        Down = GLFWNative.GLFW_HAT_DOWN,
        Left = GLFWNative.GLFW_HAT_LEFT,
        RightUp = GLFWNative.GLFW_HAT_RIGHT_UP,
        RightDown = GLFWNative.GLFW_HAT_RIGHT_DOWN,
        LeftUp = GLFWNative.GLFW_HAT_LEFT_UP,
        LeftDown = GLFWNative.GLFW_HAT_LEFT_DOWN,
    }

    public enum GLFWKey
    {
        Unknown = GLFWNative.GLFW_KEY_UNKNOWN,
        Space = GLFWNative.GLFW_KEY_SPACE,
        Apostrophe = GLFWNative.GLFW_KEY_APOSTROPHE,
        Comma = GLFWNative.GLFW_KEY_COMMA,
        Minus = GLFWNative.GLFW_KEY_MINUS,
        Period = GLFWNative.GLFW_KEY_PERIOD,
        Slash = GLFWNative.GLFW_KEY_SLASH,
        Num0 = GLFWNative.GLFW_KEY_0,
        Num1 = GLFWNative.GLFW_KEY_1,
        Num2 = GLFWNative.GLFW_KEY_2,
        Num3 = GLFWNative.GLFW_KEY_3,
        Num4 = GLFWNative.GLFW_KEY_4,
        Num5 = GLFWNative.GLFW_KEY_5,
        Num6 = GLFWNative.GLFW_KEY_6,
        Num7 = GLFWNative.GLFW_KEY_7,
        Num8 = GLFWNative.GLFW_KEY_8,
        Num9 = GLFWNative.GLFW_KEY_9,
        Semicolon = GLFWNative.GLFW_KEY_SEMICOLON,
        Equal = GLFWNative.GLFW_KEY_EQUAL,
        A = GLFWNative.GLFW_KEY_A,
        B = GLFWNative.GLFW_KEY_B,
        C = GLFWNative.GLFW_KEY_C,
        D = GLFWNative.GLFW_KEY_D,
        E = GLFWNative.GLFW_KEY_E,
        F = GLFWNative.GLFW_KEY_F,
        G = GLFWNative.GLFW_KEY_G,
        H = GLFWNative.GLFW_KEY_H,
        I = GLFWNative.GLFW_KEY_I,
        J = GLFWNative.GLFW_KEY_J,
        K = GLFWNative.GLFW_KEY_K,
        L = GLFWNative.GLFW_KEY_L,
        M = GLFWNative.GLFW_KEY_M,
        N = GLFWNative.GLFW_KEY_N,
        O = GLFWNative.GLFW_KEY_O,
        P = GLFWNative.GLFW_KEY_P,
        Q = GLFWNative.GLFW_KEY_Q,
        R = GLFWNative.GLFW_KEY_R,
        S = GLFWNative.GLFW_KEY_S,
        T = GLFWNative.GLFW_KEY_T,
        U = GLFWNative.GLFW_KEY_U,
        V = GLFWNative.GLFW_KEY_V,
        W = GLFWNative.GLFW_KEY_W,
        X = GLFWNative.GLFW_KEY_X,
        Y = GLFWNative.GLFW_KEY_Y,
        Z = GLFWNative.GLFW_KEY_Z,
        LeftBracket = GLFWNative.GLFW_KEY_LEFT_BRACKET,
        Backslash = GLFWNative.GLFW_KEY_BACKSLASH,
        RightBracket = GLFWNative.GLFW_KEY_RIGHT_BRACKET,
        GraveAccent = GLFWNative.GLFW_KEY_GRAVE_ACCENT,
        World1 = GLFWNative.GLFW_KEY_WORLD_1,
        World2 = GLFWNative.GLFW_KEY_WORLD_2,
        Escape = GLFWNative.GLFW_KEY_ESCAPE,
        Enter = GLFWNative.GLFW_KEY_ENTER,
        Tab = GLFWNative.GLFW_KEY_TAB,
        Backspace = GLFWNative.GLFW_KEY_BACKSPACE,
        Insert = GLFWNative.GLFW_KEY_INSERT,
        Delete = GLFWNative.GLFW_KEY_DELETE,
        Right = GLFWNative.GLFW_KEY_RIGHT,
        Left = GLFWNative.GLFW_KEY_LEFT,
        Down = GLFWNative.GLFW_KEY_DOWN,
        Up = GLFWNative.GLFW_KEY_UP,
        PageUp = GLFWNative.GLFW_KEY_PAGE_UP,
        PageDown = GLFWNative.GLFW_KEY_PAGE_DOWN,
        Home = GLFWNative.GLFW_KEY_HOME,
        End = GLFWNative.GLFW_KEY_END,
        CapsLock = GLFWNative.GLFW_KEY_CAPS_LOCK,
        ScrollLock = GLFWNative.GLFW_KEY_SCROLL_LOCK,
        NumLock = GLFWNative.GLFW_KEY_NUM_LOCK,
        PrintScreen = GLFWNative.GLFW_KEY_PRINT_SCREEN,
        Pause = GLFWNative.GLFW_KEY_PAUSE,
        F1 = GLFWNative.GLFW_KEY_F1,
        F2 = GLFWNative.GLFW_KEY_F2,
        F3 = GLFWNative.GLFW_KEY_F3,
        F4 = GLFWNative.GLFW_KEY_F4,
        F5 = GLFWNative.GLFW_KEY_F5,
        F6 = GLFWNative.GLFW_KEY_F6,
        F7 = GLFWNative.GLFW_KEY_F7,
        F8 = GLFWNative.GLFW_KEY_F8,
        F9 = GLFWNative.GLFW_KEY_F9,
        F10 = GLFWNative.GLFW_KEY_F10,
        F11 = GLFWNative.GLFW_KEY_F11,
        F12 = GLFWNative.GLFW_KEY_F12,
        F13 = GLFWNative.GLFW_KEY_F13,
        F14 = GLFWNative.GLFW_KEY_F14,
        F15 = GLFWNative.GLFW_KEY_F15,
        F16 = GLFWNative.GLFW_KEY_F16,
        F17 = GLFWNative.GLFW_KEY_F17,
        F18 = GLFWNative.GLFW_KEY_F18,
        F19 = GLFWNative.GLFW_KEY_F19,
        F20 = GLFWNative.GLFW_KEY_F20,
        F21 = GLFWNative.GLFW_KEY_F21,
        F22 = GLFWNative.GLFW_KEY_F22,
        F23 = GLFWNative.GLFW_KEY_F23,
        F24 = GLFWNative.GLFW_KEY_F24,
        F25 = GLFWNative.GLFW_KEY_F25,
        Keypad0 = GLFWNative.GLFW_KEY_KP_0,
        Keypad1 = GLFWNative.GLFW_KEY_KP_1,
        Keypad2 = GLFWNative.GLFW_KEY_KP_2,
        Keypad3 = GLFWNative.GLFW_KEY_KP_3,
        Keypad4 = GLFWNative.GLFW_KEY_KP_4,
        Keypad5 = GLFWNative.GLFW_KEY_KP_5,
        Keypad6 = GLFWNative.GLFW_KEY_KP_6,
        Keypad7 = GLFWNative.GLFW_KEY_KP_7,
        Keypad8 = GLFWNative.GLFW_KEY_KP_8,
        Keypad9 = GLFWNative.GLFW_KEY_KP_9,
        KeypadDecimal = GLFWNative.GLFW_KEY_KP_DECIMAL,
        KeypadDivide = GLFWNative.GLFW_KEY_KP_DIVIDE,
        KeypadMultiply = GLFWNative.GLFW_KEY_KP_MULTIPLY,
        KeypadSubtract = GLFWNative.GLFW_KEY_KP_SUBTRACT,
        KeypadAdd = GLFWNative.GLFW_KEY_KP_ADD,
        KeypadEnter = GLFWNative.GLFW_KEY_KP_ENTER,
        KeypadEqual = GLFWNative.GLFW_KEY_KP_EQUAL,
        LeftShift = GLFWNative.GLFW_KEY_LEFT_SHIFT,
        LeftControl = GLFWNative.GLFW_KEY_LEFT_CONTROL,
        LeftAlt = GLFWNative.GLFW_KEY_LEFT_ALT,
        LeftSuper = GLFWNative.GLFW_KEY_LEFT_SUPER,
        RightShift = GLFWNative.GLFW_KEY_RIGHT_SHIFT,
        RightControl = GLFWNative.GLFW_KEY_RIGHT_CONTROL,
        RightAlt = GLFWNative.GLFW_KEY_RIGHT_ALT,
        RightSuper = GLFWNative.GLFW_KEY_RIGHT_SUPER,
        Menu = GLFWNative.GLFW_KEY_MENU,
    }

    [Flags]
    public enum GLFWModifierKeys
    {
        Shift = GLFWNative.GLFW_MOD_SHIFT,
        Control = GLFWNative.GLFW_MOD_CONTROL,
        Alt = GLFWNative.GLFW_MOD_ALT,
        Super = GLFWNative.GLFW_MOD_SUPER,
        CapsLock = GLFWNative.GLFW_MOD_CAPS_LOCK,
        NumLock = GLFWNative.GLFW_MOD_NUM_LOCK,
    }

    public enum GLFWMouseButton
    {
        Button1 = GLFWNative.GLFW_MOUSE_BUTTON_1,
        Button2 = GLFWNative.GLFW_MOUSE_BUTTON_2,
        Button3 = GLFWNative.GLFW_MOUSE_BUTTON_3,
        Button4 = GLFWNative.GLFW_MOUSE_BUTTON_4,
        Button5 = GLFWNative.GLFW_MOUSE_BUTTON_5,
        Button6 = GLFWNative.GLFW_MOUSE_BUTTON_6,
        Button7 = GLFWNative.GLFW_MOUSE_BUTTON_7,
        Button8 = GLFWNative.GLFW_MOUSE_BUTTON_8,
        Left = GLFWNative.GLFW_MOUSE_BUTTON_LEFT,
        Right = GLFWNative.GLFW_MOUSE_BUTTON_RIGHT,
        Middle = GLFWNative.GLFW_MOUSE_BUTTON_MIDDLE,
    }

    public enum GLFWJoystick
    {
        Joystick1 = GLFWNative.GLFW_JOYSTICK_1,
        Joystick2 = GLFWNative.GLFW_JOYSTICK_2,
        Joystick3 = GLFWNative.GLFW_JOYSTICK_3,
        Joystick4 = GLFWNative.GLFW_JOYSTICK_4,
        Joystick5 = GLFWNative.GLFW_JOYSTICK_5,
        Joystick6 = GLFWNative.GLFW_JOYSTICK_6,
        Joystick7 = GLFWNative.GLFW_JOYSTICK_7,
        Joystick8 = GLFWNative.GLFW_JOYSTICK_8,
        Joystick9 = GLFWNative.GLFW_JOYSTICK_9,
        Joystick10 = GLFWNative.GLFW_JOYSTICK_10,
        Joystick11 = GLFWNative.GLFW_JOYSTICK_11,
        Joystick12 = GLFWNative.GLFW_JOYSTICK_12,
        Joystick13 = GLFWNative.GLFW_JOYSTICK_13,
        Joystick14 = GLFWNative.GLFW_JOYSTICK_14,
        Joystick15 = GLFWNative.GLFW_JOYSTICK_15,
        Joystick16 = GLFWNative.GLFW_JOYSTICK_16,
    }

    public enum GLFWGamepadButton
    {
        A = GLFWNative.GLFW_GAMEPAD_BUTTON_A,
        B = GLFWNative.GLFW_GAMEPAD_BUTTON_B,
        X = GLFWNative.GLFW_GAMEPAD_BUTTON_X,
        Y = GLFWNative.GLFW_GAMEPAD_BUTTON_Y,
        LeftBumper = GLFWNative.GLFW_GAMEPAD_BUTTON_LEFT_BUMPER,
        RightBumper = GLFWNative.GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER,
        Back = GLFWNative.GLFW_GAMEPAD_BUTTON_BACK,
        Start = GLFWNative.GLFW_GAMEPAD_BUTTON_START,
        Guide = GLFWNative.GLFW_GAMEPAD_BUTTON_GUIDE,
        LeftThumb = GLFWNative.GLFW_GAMEPAD_BUTTON_LEFT_THUMB,
        RightThumb = GLFWNative.GLFW_GAMEPAD_BUTTON_RIGHT_THUMB,
        DpadUp = GLFWNative.GLFW_GAMEPAD_BUTTON_DPAD_UP,
        DpadRight = GLFWNative.GLFW_GAMEPAD_BUTTON_DPAD_RIGHT,
        DpadDown = GLFWNative.GLFW_GAMEPAD_BUTTON_DPAD_DOWN,
        DpadLeft = GLFWNative.GLFW_GAMEPAD_BUTTON_DPAD_LEFT,
        Cross = GLFWNative.GLFW_GAMEPAD_BUTTON_CROSS,
        Circle = GLFWNative.GLFW_GAMEPAD_BUTTON_CIRCLE,
        Square = GLFWNative.GLFW_GAMEPAD_BUTTON_SQUARE,
        Triangle = GLFWNative.GLFW_GAMEPAD_BUTTON_TRIANGLE,
    }

    public enum GLFWGamepadAxis
    {
        LeftX = GLFWNative.GLFW_GAMEPAD_AXIS_LEFT_X,
        LeftY = GLFWNative.GLFW_GAMEPAD_AXIS_LEFT_Y,
        RightX = GLFWNative.GLFW_GAMEPAD_AXIS_RIGHT_X,
        RightY = GLFWNative.GLFW_GAMEPAD_AXIS_RIGHT_Y,
        LeftTrigger = GLFWNative.GLFW_GAMEPAD_AXIS_LEFT_TRIGGER,
        RightTrigger = GLFWNative.GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER,
    }

    public enum GLFWError
    {
        NoError = GLFWNative.GLFW_NO_ERROR,
        NotInitialized = GLFWNative.GLFW_NOT_INITIALIZED,
        NoCurrentContext = GLFWNative.GLFW_NO_CURRENT_CONTEXT,
        InvalidEnum = GLFWNative.GLFW_INVALID_ENUM,
        InvalidValue = GLFWNative.GLFW_INVALID_VALUE,
        OutOfMemory = GLFWNative.GLFW_OUT_OF_MEMORY,
        ApiUnavailable = GLFWNative.GLFW_API_UNAVAILABLE,
        VersionUnavailable = GLFWNative.GLFW_VERSION_UNAVAILABLE,
        PlatformError = GLFWNative.GLFW_PLATFORM_ERROR,
        FormatUnavailable = GLFWNative.GLFW_FORMAT_UNAVAILABLE,
        NoWindowContext = GLFWNative.GLFW_NO_WINDOW_CONTEXT,
        CursorUnavailable = GLFWNative.GLFW_CURSOR_UNAVAILABLE,
        FeatureUnavailable = GLFWNative.GLFW_FEATURE_UNAVAILABLE,
        FeatureUnimplemented = GLFWNative.GLFW_FEATURE_UNIMPLEMENTED,
        PlatformUnavailable = GLFWNative.GLFW_PLATFORM_UNAVAILABLE,
    }

    public enum GLFWWindowAttrib
    {
        Focused = GLFWNative.GLFW_FOCUSED,
        Iconified = GLFWNative.GLFW_ICONIFIED,
        Resizable = GLFWNative.GLFW_RESIZABLE,
        Visible = GLFWNative.GLFW_VISIBLE,
        Decorated = GLFWNative.GLFW_DECORATED,
        AutoIconify = GLFWNative.GLFW_AUTO_ICONIFY,
        Floating = GLFWNative.GLFW_FLOATING,
        Maximized = GLFWNative.GLFW_MAXIMIZED,
        CenterCursor = GLFWNative.GLFW_CENTER_CURSOR,
        TransparentFramebuffer = GLFWNative.GLFW_TRANSPARENT_FRAMEBUFFER,
        Hovered = GLFWNative.GLFW_HOVERED,
        FocusOnShow = GLFWNative.GLFW_FOCUS_ON_SHOW,
        MousePassthrough = GLFWNative.GLFW_MOUSE_PASSTHROUGH,
        PositionX = GLFWNative.GLFW_POSITION_X,
        PositionY = GLFWNative.GLFW_POSITION_Y,
        ScaleToMonitor = GLFWNative.GLFW_SCALE_TO_MONITOR,
        ScaleFramebuffer = GLFWNative.GLFW_SCALE_FRAMEBUFFER,
    }

    public enum GLFWFramebufferHint
    {
        RedBits = GLFWNative.GLFW_RED_BITS,
        GreenBits = GLFWNative.GLFW_GREEN_BITS,
        BlueBits = GLFWNative.GLFW_BLUE_BITS,
        AlphaBits = GLFWNative.GLFW_ALPHA_BITS,
        DepthBits = GLFWNative.GLFW_DEPTH_BITS,
        StencilBits = GLFWNative.GLFW_STENCIL_BITS,
        AccumRedBits = GLFWNative.GLFW_ACCUM_RED_BITS,
        AccumGreenBits = GLFWNative.GLFW_ACCUM_GREEN_BITS,
        AccumBlueBits = GLFWNative.GLFW_ACCUM_BLUE_BITS,
        AccumAlphaBits = GLFWNative.GLFW_ACCUM_ALPHA_BITS,
        AuxBuffers = GLFWNative.GLFW_AUX_BUFFERS,
        Stereo = GLFWNative.GLFW_STEREO,
        Samples = GLFWNative.GLFW_SAMPLES,
        SrgbCapable = GLFWNative.GLFW_SRGB_CAPABLE,
        RefreshRate = GLFWNative.GLFW_REFRESH_RATE,
        Doublebuffer = GLFWNative.GLFW_DOUBLEBUFFER,
    }

    public enum GLFWContextHint
    {
        ClientApi = GLFWNative.GLFW_CLIENT_API,
        ContextVersionMajor = GLFWNative.GLFW_CONTEXT_VERSION_MAJOR,
        ContextVersionMinor = GLFWNative.GLFW_CONTEXT_VERSION_MINOR,
        ContextRevision = GLFWNative.GLFW_CONTEXT_REVISION,
        ContextRobustness = GLFWNative.GLFW_CONTEXT_ROBUSTNESS,
        OpenGLForwardCompat = GLFWNative.GLFW_OPENGL_FORWARD_COMPAT,
        ContextDebug = GLFWNative.GLFW_CONTEXT_DEBUG,
        OpenGLDebugContext = GLFWNative.GLFW_OPENGL_DEBUG_CONTEXT,
        OpenGLProfile = GLFWNative.GLFW_OPENGL_PROFILE,
        ContextReleaseBehavior = GLFWNative.GLFW_CONTEXT_RELEASE_BEHAVIOR,
        ContextNoError = GLFWNative.GLFW_CONTEXT_NO_ERROR,
        ContextCreationApi = GLFWNative.GLFW_CONTEXT_CREATION_API,
    }

    public enum GLFWPlatformWindowHint
    {
        CocoaRetinaFramebuffer = GLFWNative.GLFW_COCOA_RETINA_FRAMEBUFFER,
        CocoaFrameName = GLFWNative.GLFW_COCOA_FRAME_NAME,
        CocoaGraphicsSwitching = GLFWNative.GLFW_COCOA_GRAPHICS_SWITCHING,
        X11ClassName = GLFWNative.GLFW_X11_CLASS_NAME,
        X11InstanceName = GLFWNative.GLFW_X11_INSTANCE_NAME,
        Win32KeyboardMenu = GLFWNative.GLFW_WIN32_KEYBOARD_MENU,
        Win32ShowDefault = GLFWNative.GLFW_WIN32_SHOWDEFAULT,
        WaylandAppId = GLFWNative.GLFW_WAYLAND_APP_ID,
    }

    public enum GLFWInitHint
    {
        JoystickHatButtons = GLFWNative.GLFW_JOYSTICK_HAT_BUTTONS,
        AnglePlatformType = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE,
        Platform = GLFWNative.GLFW_PLATFORM,
        CocoaChdirResources = GLFWNative.GLFW_COCOA_CHDIR_RESOURCES,
        CocoaMenubar = GLFWNative.GLFW_COCOA_MENUBAR,
        X11XcbVulkanSurface = GLFWNative.GLFW_X11_XCB_VULKAN_SURFACE,
        WaylandLibdecor = GLFWNative.GLFW_WAYLAND_LIBDECOR,
    }

    public enum GLFWClientApi
    {
        NoApi = GLFWNative.GLFW_NO_API,
        OpenGLApi = GLFWNative.GLFW_OPENGL_API,
        OpenGLESApi = GLFWNative.GLFW_OPENGL_ES_API,
    }

    public enum GLFWContextRobustness
    {
        NoRobustness = GLFWNative.GLFW_NO_ROBUSTNESS,
        NoResetNotification = GLFWNative.GLFW_NO_RESET_NOTIFICATION,
        LoseContextOnReset = GLFWNative.GLFW_LOSE_CONTEXT_ON_RESET,
    }

    public enum GLFWOpenGLProfile
    {
        AnyProfile = GLFWNative.GLFW_OPENGL_ANY_PROFILE,
        CoreProfile = GLFWNative.GLFW_OPENGL_CORE_PROFILE,
        CompatProfile = GLFWNative.GLFW_OPENGL_COMPAT_PROFILE,
    }

    public enum GLFWReleaseBehavior
    {
        Any = GLFWNative.GLFW_ANY_RELEASE_BEHAVIOR,
        Flush = GLFWNative.GLFW_RELEASE_BEHAVIOR_FLUSH,
        None = GLFWNative.GLFW_RELEASE_BEHAVIOR_NONE,
    }

    public enum GLFWContextCreationApi
    {
        Native = GLFWNative.GLFW_NATIVE_CONTEXT_API,
        EGL = GLFWNative.GLFW_EGL_CONTEXT_API,
        OSMesa = GLFWNative.GLFW_OSMESA_CONTEXT_API,
    }

    public enum GLFWAnglePlatformType
    {
        None = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE_NONE,
        OpenGL = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE_OPENGL,
        OpenGLES = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE_OPENGLES,
        D3D9 = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE_D3D9,
        D3D11 = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE_D3D11,
        Vulkan = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE_VULKAN,
        Metal = GLFWNative.GLFW_ANGLE_PLATFORM_TYPE_METAL,
    }

    public enum GLFWWaylandLibdecor
    {
        Prefer = GLFWNative.GLFW_WAYLAND_PREFER_LIBDECOR,
        Disable = GLFWNative.GLFW_WAYLAND_DISABLE_LIBDECOR,
    }

    public enum GLFWPlatform
    {
        Any = GLFWNative.GLFW_ANY_PLATFORM,
        Win32 = GLFWNative.GLFW_PLATFORM_WIN32,
        Cocoa = GLFWNative.GLFW_PLATFORM_COCOA,
        Wayland = GLFWNative.GLFW_PLATFORM_WAYLAND,
        X11 = GLFWNative.GLFW_PLATFORM_X11,
        Null = GLFWNative.GLFW_PLATFORM_NULL,
    }

    public enum GLFWInputMode
    {
        Cursor = GLFWNative.GLFW_CURSOR,
        StickyKeys = GLFWNative.GLFW_STICKY_KEYS,
        StickyMouseButtons = GLFWNative.GLFW_STICKY_MOUSE_BUTTONS,
        LockKeyMods = GLFWNative.GLFW_LOCK_KEY_MODS,
        RawMouseMotion = GLFWNative.GLFW_RAW_MOUSE_MOTION,
        UnlimitedMouseButtons = GLFWNative.GLFW_UNLIMITED_MOUSE_BUTTONS,
    }

    public enum GLFWCursorMode
    {
        Normal = GLFWNative.GLFW_CURSOR_NORMAL,
        Hidden = GLFWNative.GLFW_CURSOR_HIDDEN,
        Disabled = GLFWNative.GLFW_CURSOR_DISABLED,
        Captured = GLFWNative.GLFW_CURSOR_CAPTURED,
    }

    public enum GLFWCursorShape
    {
        Arrow = GLFWNative.GLFW_ARROW_CURSOR,
        IBeam = GLFWNative.GLFW_IBEAM_CURSOR,
        Crosshair = GLFWNative.GLFW_CROSSHAIR_CURSOR,
        PointingHand = GLFWNative.GLFW_POINTING_HAND_CURSOR,
        ResizeEW = GLFWNative.GLFW_RESIZE_EW_CURSOR,
        ResizeNS = GLFWNative.GLFW_RESIZE_NS_CURSOR,
        ResizeNWSE = GLFWNative.GLFW_RESIZE_NWSE_CURSOR,
        ResizeNESW = GLFWNative.GLFW_RESIZE_NESW_CURSOR,
        ResizeAll = GLFWNative.GLFW_RESIZE_ALL_CURSOR,
        NotAllowed = GLFWNative.GLFW_NOT_ALLOWED_CURSOR,
        HResize = GLFWNative.GLFW_HRESIZE_CURSOR,
        VResize = GLFWNative.GLFW_VRESIZE_CURSOR,
        Hand = GLFWNative.GLFW_HAND_CURSOR,
    }

    public enum GLFWConnectionEvent
    {
        Connected = GLFWNative.GLFW_CONNECTED,
        Disconnected = GLFWNative.GLFW_DISCONNECTED,
    }
}