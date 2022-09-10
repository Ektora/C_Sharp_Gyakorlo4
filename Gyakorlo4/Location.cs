using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo4
{
    internal class Location
    {
        public int row, column;
        public double maxValue;

        public Location(int row, int column, double maxValue)
        {
            this.row = row;
            this.column = column;
            this.maxValue = maxValue;
        }

        public static Location locateLargest(double[,] a)
        {
            double maxValue = 0.0;
            int row=0, column=0;
            for(int i=0;i< a.GetLength(0); i++)
            {
                for(int j=0;j< a.GetLength(1); j++)
                {
                    if (maxValue < a[i,j])
                    {
                        row = i;
                        column = j;
                        maxValue = a[i, j];
                    }
                }
            }
            return new Location(row, column, maxValue);
        }
    }
}
