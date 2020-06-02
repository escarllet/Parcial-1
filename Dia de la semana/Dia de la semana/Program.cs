using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            string semana;
            Console.WriteLine("Introduzca el nombre de un dia de la semana (Primera letra en mayus.)");
            semana = Console.ReadLine();
            if (semana == "Sabado" || semana == "Domingo")
            {
                Console.WriteLine("Es fin de semana");
            }
            else if (semana == "Lunes" || semana == "Martes" || semana == "Miercoles" || semana == "Jueves" || semana == "Viernes")
            {
                Console.WriteLine("No es fin de semana");
            }
            else 
            {
                Console.WriteLine("Error: El dia de la semana no existe o esta mal  escrito");
            }
            Console.ReadKey();
        }
    }
}
