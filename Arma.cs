using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerS3_Tarea
{
    internal class Arma
    {
        string nombre;
        float daño;
        float velocidadDeAtaque;
        float precio;
        
        public Arma(string a,float b,float c,float d)
        {
            this.nombre = a;
            this.precio =b ;
            this.daño = c;
            this.velocidadDeAtaque = d;
        }
    }
    internal class Espada : Arma
    {
        public Espada(string nombre, float precio, float daño, float velocidadDeAtaque)
            : base(nombre, precio, daño, velocidadDeAtaque)
        {

        }
    }
    
    internal class Pistola : Arma
    {
        public Pistola(string nombre, float precio, float daño, float velocidadDeAtaque)
            : base(nombre, precio, daño, velocidadDeAtaque)
        {

        }
    }

    internal class Arco : Arma
    {
        public Arco(string nombre, float precio, float daño, float velocidadDeAtaque)
            : base(nombre, precio, daño, velocidadDeAtaque)
        {

        }
    }

}
