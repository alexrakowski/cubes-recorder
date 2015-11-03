using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarchingCubes
{
    static class ColorUtils
    {
        public static Microsoft.Xna.Framework.Color XNAColor(System.Drawing.Color color)
        {
            return new Microsoft.Xna.Framework.Color(color.R, color.G, color.B, color.A);
        }
        public static System.Drawing.Color DrawingColor(Microsoft.Xna.Framework.Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
