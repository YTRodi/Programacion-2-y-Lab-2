using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Rodi.Yago._2C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si la clase Grupo tuviera en su propiedad Tipo un tipo de acceso get, 
            //podria hacerse un switch en del grupo.Tipo en el ==

            //Si la el enumrado de TipoManada de la clase Grupo, fuera Mixta, Perro o Gato, podria validarse.
            Grupo grupoMixto = new Grupo("Mascotitas love",Grupo.TipoManada.Mixta);
            Grupo grupoPerros = new Grupo("Mascotitas Perros",Grupo.TipoManada.Única);//al no poner el tipo de grupo, se setea en Unica.
            Grupo grupoGatos = new Grupo("Mascotitas Gatos");

            Perro perro1 = new Perro("Yago", "Ñoño", 10, true);//esAlfa = true;
            Perro perro2 = new Perro("Camu", "Salchicha", 9, false);//no tiene que mostrar que es alfa
            Perro perro3 = new Perro("Maggie", "Shorshire");//edad = 0, no tiene que mostrar que es alfa

            Gato gato1 = new Gato("Neo", "Abisinio");
            Gato gato2 = new Gato("Queen", "Asiático");
            Gato gato3 = new Gato("Princesa", "Bombay");

            Perro perroClon1 = new Perro("Yago", "Ñoño", 10, true);//esAlfa = true;
            Gato gatoClon1 = new Gato("Neo", "Abisinio");

            //Console.WriteLine("--PERROS--");
            //Console.WriteLine(perro1.ToString());
            //Console.WriteLine(perro2.ToString());
            //Console.WriteLine(perro3.ToString());
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("--GATOS--");
            //Console.WriteLine(gato1.ToString());
            //Console.WriteLine(gato2.ToString());
            //Console.WriteLine(gato3.ToString());
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();

            //---------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------

            //Console.WriteLine("--GRUPO MIXTO--");
            //grupoMixto += perro1;
            //grupoMixto += perro2;
            //grupoMixto += perro3;
            //Console.WriteLine(grupoMixto);
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("--GRUPO MIXTO (Borro a Yago)--");
            //grupoMixto += perro1;
            //grupoMixto += perro2;
            //grupoMixto -= perro1;
            //Console.WriteLine(grupoMixto);
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("--GRUPO MIXTO (Agrego de nuevo a Yago)--");
            //grupoMixto += new Perro("Yago", "Ñoño", 10, true);
            //Console.WriteLine(grupoMixto);
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();


            //---------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------

            Console.WriteLine("--GRUPO PERROS--");
            grupoPerros += perro1;
            grupoPerros += perro2;
            grupoPerros += perro3;
            Console.WriteLine(grupoPerros);
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--GRUPO PERROS (Borro a Yago)--");
            grupoPerros += perro1;
            grupoPerros += perro2;
            grupoPerros -= perro1;
            Console.WriteLine(grupoPerros);
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("--GRUPO PERROS (Agrego de nuevo a Yago)--");
            grupoPerros += new Perro("Yago", "Ñoño", 10, true);
            //SI NO TENGO UN GET, NO PUEDO VERIFICAR SI ES PERRO O GATO...
            Console.WriteLine(grupoPerros);
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            //ESTO NO LO PIDE.
            Console.WriteLine("--GRUPO PERROS (Trato de agregar un gato)--");
            grupoPerros += gato1;//NO HAY FORMA DE VALIDAR.
            Console.WriteLine(grupoPerros);
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();


            //---------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------

            //Console.WriteLine("--GRUPO GATOS--");
            //grupoGatos += gato1;
            //grupoGatos += gato2;
            //grupoGatos += gato3;
            //Console.WriteLine(grupoGatos);
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("--GRUPO GATOS (Borro a Neo)--");
            //grupoGatos -= gato1;
            //Console.WriteLine(grupoGatos);
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();

            //Console.WriteLine("--GRUPO GATOS (Agrego de nuevo a Neo)--");
            //grupoGatos += new Gato("Neo", "Abisinio");
            ////SI NO TENGO UN GET, NO PUEDO VERIFICAR SI ES PERRO O GATO...
            //Console.WriteLine(grupoGatos);
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();

            ////ESTO NO LO PIDE.
            //Console.WriteLine("--GRUPO GATOS (Trato de agregar un Perro)--");
            //grupoGatos += perro1;//NO HAY FORMA DE VALIDAR.
            //Console.WriteLine(grupoGatos);
            //Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONTINUAR");
            //Console.Beep();
            //Console.ReadKey();
            //Console.Clear();


            //---------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------
            ////              PERROS
            //if (perro1 == perro2)
            //    Console.WriteLine("son iguales");
            //else
            //    Console.WriteLine("son distintos/falso");


            //if (perro1 != perro2)
            //    Console.WriteLine("son distintos/falso");
            //else
            //    Console.WriteLine("son iguales");


            //if (perro1 == perroClon1)
            //    Console.WriteLine("son iguales");
            //else
            //    Console.WriteLine("son distintos/falso");


            //if (perro1 != perroClon1)
            //    Console.WriteLine("son iguales");
            //else
            //    Console.WriteLine("son distintos/falso");





            ////               GATOS
            //if (gato1 == gato2)
            //    Console.WriteLine("Son iguales");
            //else
            //    Console.WriteLine("Son distintos/falso");


            //if (gato1 != gato2)
            //    Console.WriteLine("Son distintos/falso");
            //else
            //    Console.WriteLine("Son iguales");


            //if (gato1 == gatoClon1)
            //    Console.WriteLine("Son iguales");
            //else
            //    Console.WriteLine("Son distintos/falso");


            //if (gato1 != gatoClon1)
            //    Console.WriteLine("Son iguales");
            //else
            //    Console.WriteLine("Son distintos/falso");


            //---------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------
            



            Console.ReadKey();
        }
    }
}
