using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Veterinaria
{
    class Veterinaria
    {

        public string Diagnosticar(Mascota mascota)
        {
            if (mascota.TieneObesidad() && mascota.TieneFiebre())
            {
                return "Es obeso y esta enfermo";
            }
            else if (mascota.TieneObesidad())
            {
                return "Es obeso";
            }
            
            else if (mascota.TieneFiebre())
            {
                return "Esta enfermo";
            }
                else
                {
                    return "No tiene nada";
                }
            }
        }
    }
