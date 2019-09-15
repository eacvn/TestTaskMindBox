using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Сircle : IAreaable
    {
        public double R { get; }

        public Сircle(double r)
        {
            if (r <= 0)
                throw new ArgumentException(nameof(r));

            R = r;
        }

        public double CalcArea() => Math.PI * R * R;
    }
}
