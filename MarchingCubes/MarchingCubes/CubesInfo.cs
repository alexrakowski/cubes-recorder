using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarchingCubes
{
    struct CubesInfo
    {
        public double IsoLevel;
        public int DimensionSize;

        public static CubesInfo Default
        {
            get
            {
                var info = new CubesInfo();
                info.IsoLevel = 0.2;
                info.DimensionSize = 10;

                return info;
            }
        }
    }
}
