using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Generics_Lesson20
{
    internal class Sword : HeroBase
    {
        public double SwordLength { get; set; }

        public Sword()
        {

            SwordLength = CreateRandomDouble();
        }

    }
}
