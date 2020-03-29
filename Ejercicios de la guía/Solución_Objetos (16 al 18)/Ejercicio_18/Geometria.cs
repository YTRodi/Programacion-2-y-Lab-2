using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        //Solo se puede asignar un valor a un campo readonly cuando se inicializa en la declaración.
        //ejemplo: readonly private int x = 10;
        readonly private int x;
        readonly private int y;

        public Punto(int paramX, int paramY)
        {
            this.x = paramX;
            this.y = paramY;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }

    class Rectangulo
    {
        private float area;
        private float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public Rectangulo(Punto paramVertice1, Punto paramVertice3)
        {
            this.vertice1 = paramVertice1;
            this.vertice3 = paramVertice3;
            area = 0;
            perimetro = 0;

            //Calcular con vertice 1 y 3? debido a que son de tipo Punto??? 
        }

        public float getArea()
        {
            this.area = (vertice1.GetX() * vertice3.GetY());//base del vertice 1 por altura del vertice 3
            //No seria vertice 1 * vertice 2?? base * altura?
            return this.area;
        }
        public float getPerimetro()
        {
            this.perimetro = ((vertice1.GetX() + vertice3.GetY())) * 2;
            return this.perimetro; 
        }

    }
}
