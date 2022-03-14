using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Generics_Lesson20
{
    internal class HeroesTable<T> where T : HeroBase
    {
        public T[] Heroes { get; set; }

        public T this[int index]
        {
            get
            {
                if (ActHeroesCount() == 0)
                    return null;
                else if (index <= Heroes.Length - 1)
                {
                    if (Heroes[index] == null)
                    {
                        for (int i = index - 1; i >= 0; i--)
                        {
                            if (Heroes[i] != null)
                                return Heroes[i];
                        }
                        return null;
                    }
                    else
                        return Heroes[index];
                }
                else
                {
                    int resIndex = index % Heroes.Length-1;//13%3=1
                    return Heroes[resIndex];
                }
            }
        }

        public HeroesTable(int size)
        {
            Heroes = new T[size];
        }

        public void SetHero(T hero, int index)
        {
            Heroes[index] = hero;
        }

        public void Delete(int index)
        {
            Heroes[index] = null;
        }

        public int ActHeroesCount()
        {
            int counter = 0;
            foreach (T k in Heroes)
            {
                if (k != null)
                    counter++;
            }
            return counter;
        }

        public T[] ActKnights()
        {
            T[] actHeroes = new T[ActHeroesCount()];
            int index = 0;
            foreach (T k in Heroes)
            {
                if (k != null)
                {
                    actHeroes[index] = k;
                    index++;
                }
            }
            return actHeroes;
        }

    }
}
