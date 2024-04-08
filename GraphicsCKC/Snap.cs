using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsCKC
{
    public class Snap
    {
        public static Color color;
        public static int Toadodiemx1(int x1, int Grid)
        {
            int MaxPx1, MinPx1;
            for (int i = Grid; i <= 10000; i += Grid)
            {
                if (i - Grid < x1 && x1 < i)
                {
                    MaxPx1 = i;
                    MinPx1 = i - Grid;
                    int e = (MaxPx1 - MinPx1) / 2;
                    x1 = (x1 - MinPx1 > e) ? MaxPx1 : MinPx1;
                    break;

                }
            }
            return x1;
        }
        public static int Toadodiemy1(int y1, int Grid)
        {
            int MaxPy1, MinPy1;
            for (int i = Grid; i <= 10000; i += Grid)
            {
                if (i - Grid < y1 && y1 < i)
                {
                    MaxPy1 = i;
                    MinPy1 = i - Grid;
                    int e = (MaxPy1 - MinPy1) / 2;
                    y1 = (y1 - MinPy1 > e) ? MaxPy1 : MinPy1;
                    break;
                }
            }
            return y1;
        }
        public static int Toadodiemx2(int x2, int Grid)
        {
            int MaxPx2, MinPx2;
            for (int i = Grid; i <= 10000; i += Grid)
            {
                if (i - Grid < x2 && x2 < i)
                {
                    MaxPx2 = i;
                    MinPx2 = i - Grid;
                    int e = (MaxPx2 - MinPx2) / 2;
                    x2 = (x2 - MinPx2 > e) ? MaxPx2 : MinPx2;
                    break;
                }
            }
            return x2;
        }
        public static int Toadodiemy2(int y2, int Grid)
        {
            int MaxPy2, MinPy2;
            for (int i = Grid; i <= 10000; i += Grid)
            {
                if (i - Grid < y2 && y2 < i)
                {
                    MaxPy2 = i;
                    MinPy2 = i - Grid;
                    int e = (MaxPy2 - MinPy2) / 2;
                    y2 = (y2 - MinPy2 > e) ? MaxPy2 : MinPy2;
                    break;
                }
            }
            return y2;
        }
    }
}
