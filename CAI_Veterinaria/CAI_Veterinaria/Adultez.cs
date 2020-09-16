using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Veterinaria
{
    abstract class Adultez
    {
        
        public static Adultez AdultezPara (Mascota mascota)
        {
            if (mascota.Edad <= 1)
            {
                return new Cachorro();
            }
            else
            {
                if (mascota.Edad >1 && mascota.Edad < 5)
                {
                    return new Adulto();
                }
                else
                {
                    return new Anciano();
                }
            }
        }
        public bool TieneObesidad(Mascota mascota)
        {
            return mascota.Peso > KgSobrepeso();
        }
        public abstract int KgSobrepeso();



    }
    class Cachorro : Adultez
    {
         public override int KgSobrepeso ()
        {
            return 5;
        }
    }
    class Adulto : Adultez 
    {
        public override int KgSobrepeso()
        {
            return 10;
        }
    }
    class Anciano : Adultez
    {
        public override int KgSobrepeso()
        {
            return 20;
        }
    }
}
