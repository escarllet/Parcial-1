using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma_de_pago
{
    class Program
    {
        static void Main(string[] args)
        {
            int compra,pago;
            long tarjeta;
            Console.WriteLine("Cual es el monto total de su compra?");
            compra = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Como desea completar su compra?");
            Console.WriteLine("Escriba 1 para pagar con tarjeta de credito o debito");
            Console.WriteLine("Escriba 2 para pagar en efectivo");
            pago = Convert.ToInt32(Console.ReadLine());
            switch (pago)
            {
                case 1:
                    Console.WriteLine("Introduzca el numero de su tarjeta de credito");
                    tarjeta = Convert.ToInt64(Console.ReadLine());
                    if (tarjeta > 0)
                    {
                        Console.WriteLine("Pago realizado de manera exitosa");
                    }
                    break;
                case 2:
                    Console.WriteLine("Pago realizado de manera exitosa");
                    break;
                default:
                    Console.WriteLine("Seleccione un numero valido");
                    break;
            }
        }
    }
}
