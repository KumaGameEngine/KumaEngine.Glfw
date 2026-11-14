using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumaEngine.Glfw.Source
{
    public struct WorkArea(int x, int y, int w, int h)
    {
        public int X { get; } = x;
        public int Y { get; } = y;
        public int Width { get; } = w;
        public int Height { get; } = h;
    }
}
