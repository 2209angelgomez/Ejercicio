using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {

          //Mariana saca un credito poR 17000000 en el banco bbva, con una tasa
          //de interes del 2% mensual durante 1 año. Mariana debe camcelar el  credito dentro de los
          //primeros 5 dias de cada mes, por cada día transcorrudio se aumenta el interes
          //en un 0,02%. El programa debe pedir a Mariana la fecha de consignacion
          //y debe ser capaz de arrojar la cantidad a consignar.
          //Al cabo de los 12 meses se debe calcular el valor total a pagar.
          //*Tener en cuenta que Mariana de los 12 meses solo cancela tres cuotas puntuales, e resto de los
          //siempre su fecha de consignacion es superior a la actualmente pactada.

            var valor = 17000000;
            var valorInteres =1432061;
            var fecha = new DateTime(2018,8,30);
            var fechaPago = new DateTime(2018,9,30);
            var dias = fecha.Subtract(fechaPago).Days;
            var vaTotal = valorInteres * 0.002;

            Console.WriteLine("Ingrese la fecha de consignación (MM/dd/yyyy)");
            fechaPago = Convert.ToDateTime( Console.ReadLine());
            
            if (dias < 5)
            {
                Console.WriteLine($"Su valor a consignar es de  { valorInteres} " );
            }
            else 
            {
                Console.WriteLine($"Su valor a consignar es de  { vaTotal}  ");
            }

           

        }
    }
}
