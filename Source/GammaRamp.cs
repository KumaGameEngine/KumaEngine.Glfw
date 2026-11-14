using System;

namespace KumaEngine.Glfw.Source
{
    public struct GammaRamp
    {
        public ushort[] Red { get; set; }
        public ushort[] Green { get; set; }
        public ushort[] Blue { get; set; }

        public GammaRamp(ushort[] red, ushort[] green, ushort[] blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}