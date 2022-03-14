using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Generics_Lesson20
{
    internal class Knight : HeroBase
    {
        public double HP { get; set; }

        public Knight()
        {
            HP = CreateRandomDouble();
        }

    }
}
