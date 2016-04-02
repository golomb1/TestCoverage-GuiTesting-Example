using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsATriangle
{
    public static class IsTriangle
    {
        public enum TriangleType
        {
            NotTriangle,
            ScaleneTriangle,
            IsoscelesTriangle,
            EquilateralTriangle,
            RightTriangles
        }
        public static TriangleType IsATiangle(int a, int b, int c)
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                if ((a == b) && (b == c))
                {
                    return TriangleType.EquilateralTriangle;
                }
                else if((a==b) || (b==c) || (a==c))
                {
                    return TriangleType.IsoscelesTriangle;
                }
                else if (a*a + b*b == c*c)
                {
                    return TriangleType.RightTriangles;
                }
                else
                {
                    return TriangleType.NotTriangle;
                }
            }
            else
            {
                return TriangleType.NotTriangle;
            }
        }
    }
}
