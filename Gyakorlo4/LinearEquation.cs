using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo4
{
    internal class LinearEquation
    {
        private int a, b, c, d, e, f;
        public int A { get { return a; } }
        public int B { get { return b; } }
        public int C { get { return c; } }
        public int D { get { return d; } }
        public int E { get { return e; } }
        public int F { get { return f; } }

        public LinearEquation(int a, int b, int c, int d, int e, int f)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
        }

        public Boolean isSolvable()
        {
            if(A*D-B*C == 0)
                return false;
            return true;
        }

        private int getX()
        {
            return (E * D - B * F) / (A * D - B * C);
        }

        private int getY()
        {
            return (A * F - E * C) / (A * D - B * C);
        }

        public override string ToString()
        {
            int x, y;
            
            string eredmeny;
            if (isSolvable())
            {
                eredmeny = $"x értéke: {getX()}, y értéke: {getY()}";
                return eredmeny;
            }
            return "The equation has no solution";
        }
    }
}
