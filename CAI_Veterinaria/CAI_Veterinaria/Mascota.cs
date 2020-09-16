using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Veterinaria
{
    abstract class Mascota
    {
        protected string nombre;
        protected float peso;
        protected float temperatura;
        protected int edad;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                peso = value;
            }
        }
        
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                edad = value;
            }
        }

        public Mascota(string nombre, float peso, float temperatura, int edad)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.temperatura = temperatura;
            this.edad = edad;
        }
        public Adultez GetAdultez ()
        {
            return Adultez.AdultezPara(this);
        }
        public bool TieneObesidad()
        {
            return GetAdultez().TieneObesidad(this);
        }
        public abstract bool TieneFiebre();

    }
    class Perro : Mascota
    {
        public Perro (string nombre, float peso, float temperatura, int edad) : base (nombre, peso, temperatura, edad){}
        public override bool TieneFiebre()
        {
            return (this.temperatura >= 38);
        }

    }
    class Gato : Mascota
    {
        public Gato(string nombre, float peso, float temperatura, int edad) : base(nombre, peso, temperatura, edad) { }
        public override bool TieneFiebre()
        {
            return (this.temperatura >= 36);
        }

    }

}
