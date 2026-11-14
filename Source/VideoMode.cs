namespace KumaEngine.Glfw.Source
{
    public readonly struct VideoMode
    {
        public int Width { get; }
        public int Height { get; }
        public int RedBits { get; }
        public int GreenBits { get; }
        public int BlueBits { get; }
        public int RefreshRate { get; }

        public VideoMode(int width, int height, int redBits, int greenBits, int blueBits, int refreshRate)
        {
            Width = width;
            Height = height;
            RedBits = redBits;
            GreenBits = greenBits;
            BlueBits = blueBits;
            RefreshRate = refreshRate;
        }
    }
}