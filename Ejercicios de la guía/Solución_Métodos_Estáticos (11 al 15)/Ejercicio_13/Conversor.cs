using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(int auxDouble)
        {
            string retornoBinario = string.Empty;
            while(auxDouble > 0)
            {
                //los num pares van a dar siempre residuos en 0 - impares residuo 1
                retornoBinario = auxDouble % 2 + retornoBinario;
                auxDouble = auxDouble / 2;
            }
            return retornoBinario;
        }

        public static int BinarioDecimal(string auxStr)
        {
            int retornoDecimal = 0;
            for(int i= auxStr.Length - 1 , y = 0; i >= 0 ;i--,y++)
            {
                if(auxStr[i] == '0' || auxStr[i] == '1')
                {
                    retornoDecimal += (int)(int.Parse(auxStr[i].ToString()) * Math.Pow(2,y));
                    //no vale, copiadizimo de internettttttttttttt puerrrco
                }
            }
            return retornoDecimal;
        }
    }
}
