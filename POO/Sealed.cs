using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Sealed
    {   
        /* Classes do tipo sealed não permitem herança */
        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 1.407033;
            }
        }

        //class SouFilho : SemFilho { }

        class Avo
        {   /* Métodos virtuais podem ser sobrescritos */
            public virtual bool HorarNomeFamilia()
            {
                return true;
            }
        }

        class Pai: Avo
        {
            public override bool HorarNomeFamilia()
            {
                return true;
            }
        }

        class FilhoRebelde: Pai
        {
            public override bool HorarNomeFamilia()
            {
                return false;
            }
        }

        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HorarNomeFamilia());
        }
    }
}
