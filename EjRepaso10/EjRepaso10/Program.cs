using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EjRepaso10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio X
            //Crear una aplicación que lea un carácter tecleado por el usuario e indique si se trata de
            //una vocal, una cifra numérica o una consonante.
            //Nota: Incluir todas las validaciones que considere necesarias(los caracteres especiales
            //no deben tenerse en cuenta).

            int numero;
            string valor;
            bool numerico = false;
  
            
            List<string> vocales = new List<string>();
            vocales.Add("a");
            vocales.Add("b");
            vocales.Add("c");
            vocales.Add("d");
            vocales.Add("e");

            Console.WriteLine("Ingrese una letra o numero");
            valor = Console.ReadLine();


            numerico = int.TryParse(valor, out numero);
            if (numerico)
            {
                Console.WriteLine("Usted ingresó un valor numérico");
            }
            
            else 
            {
                
                if (vocales.Contains(valor))
                {
                    Console.WriteLine("Usted ingresó una vocal");
                }
                else
                {
                    Console.WriteLine("Usted ingresó una consonante");
                }
            }


            Console.ReadKey();
        }
    }
}
