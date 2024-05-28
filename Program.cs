using System;


namespace Control_de_acceso
{
    internal class Program
    {
        static double CalcularTicket()
        {
            Console.Clear();
            int opcion;
            double valor = 0, monto = 0;
            Console.WriteLine(" 1- S/V      ");
            Console.WriteLine(" 2- Moto     ");
            Console.WriteLine(" 3- Auto     ");
            Console.WriteLine(" 4- Camioneta");
            Console.WriteLine(" 5- Bugy     ");
            Console.WriteLine(" 6- Vehiculo Nautico");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        monto = 100;
                    }
                    break;
                case 2:
                    {
                        monto = 800;
                    }
                    break;
                case 3:
                    {
                        monto = 1000;
                    }
                    break;
                case 4:
                    {
                        monto = 1500;
                    }
                    break;
                case 5:
                    {
                        monto = 5000;
                    }
                    break;
                case 6:
                    {
                        monto = 1200;
                    }
                    break;
            }
            Console.Clear();
            Console.WriteLine("     DIAS        ");
            Console.WriteLine(" 1 - 100%        ");
            Console.WriteLine(" 2 - 120%        ");
            Console.WriteLine(" 3 - 220%        ");
            Console.WriteLine(" 4 - 320%        ");
            Console.WriteLine(" 5 o Mas - 380%  ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    {
                        valor = monto;
                    }
                    break;
                case 2:
                    {
                        valor = monto * 1.2;
                    }
                    break;
                case 3:
                    {
                        valor = monto * 2.2;
                    }
                    break;
                case 4:
                    {
                        valor = monto * 3.2;
                    }
                    break;
                case 5:
                    {
                        valor = monto * 3.8;
                    }
                    break;
            }
            Console.WriteLine("Valor Ticket: {0:C2}", valor);
            Console.ReadKey();
            Console.Clear();
            return valor;
        }
        static double ImprimirRecaudacion(double acumulador)
        {
            return acumulador;
        }
        static int CantidadDeAccesos(int contador)
        {
            return contador;
        }
        static bool Verificar()
        {
            int a;
            Console.WriteLine("     1 - Tiene Ticket    ");
            Console.WriteLine("     2 - No Tiene Ticket ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Menu()
        {
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║       Elija opcion (5 para salir)      ║");
            Console.WriteLine("║     1- Verificar Acceso                ║");
            Console.WriteLine("║     2- Imprimir Recaudacion            ║");
            Console.WriteLine("║     3- Mostrar cantidad de accesos     ║");
            Console.WriteLine("║     4- Salir                           ║");
            Console.WriteLine("╚════════════════════════════════════════╝");
        }
        static void Main(string[] args)
        {
            int opcion, contador = 0;
            double acumulador = 0;
            do
            {
                Menu();
                opcion = Convert.ToInt32(Console.ReadLine());
                {
                    switch (opcion)
                    {
                        case 1:
                            
                                if (Verificar() == true)
                                {
                                    contador++;
                                }
                                else
                                {
                                    contador++;
                                    acumulador += CalcularTicket();
                                }
                            Console.Clear();
                            
                            break;
                        case 2:
                            
                            Console.WriteLine("Cantidad Recaudado: {0:C2}" , ImprimirRecaudacion(acumulador));
                            Console.ReadKey();
                            Console.Clear();
                            
                            break;
                        case 3:
                            
                            Console.WriteLine("Cantidad de Acceso: " + CantidadDeAccesos(contador));
                            Console.ReadKey();
                            Console.Clear();

                            break;                      
                    }
                }
            } while (opcion != 4);
        }
    }
}