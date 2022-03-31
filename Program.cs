using System;
using System.Collections.Generic;

namespace Colas_Simples_Estaticas
{
    class Program
    {
        public static int tamano, i = 0, f = -1, c = - 1;
        public static string elemento, otro = "", temporal = "";
        public static string[] estado = new string[2];
        public static void Main(string[] args)
        {
            string opcV = "";
            do
            {
                Console.Clear();
                int opc = 0;

                Console.WriteLine("Menú de opciones.");
                Console.WriteLine("1. Insertar nombres de estados.");
                Console.WriteLine("2. Eliminar nombres de estados.");
                Console.WriteLine("3. Mostrar nombres de los estados ingresados.");
                Console.WriteLine("4. Salir del programa.");

                Console.Write("Ingrese una opción: ");
                Console.Write("-> ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        insertarValores();
                        break;
                    case 2:
                        eliminarValores();
                        break;
                    case 3:
                        mostrarValores();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("La opción ingresada no existe, por favor inicie de nuevo");
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(1);
                        break;
                }

                Console.Clear();
                Console.WriteLine("¿Desea realizar otra acición en el menu?");
                Console.Write("-> ");
                opcV = Console.ReadLine();
            } while (opcV == "si");
        }

        public static void insertarValores()
        {
            Console.Clear();

            Console.WriteLine("********** INSERTANDO ESTADOS A LA COLA **********\n");

            string opc = " ";
            do
            {
                Console.WriteLine("Ingresa un nombre de estado:" + f);
                Console.Write("-> ");
                elemento = Console.ReadLine();

                if (f >= estado.Length - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nCola llena, no se agrego el nombre del estado de " + elemento);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Presione la tecla enter para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    f = f + 1;
                    estado[f] = elemento;
                }

                if (i == 0)
                {
                    i = 0;
                }

                Console.WriteLine("¿Desea ingresar otro estado? Si / No");
                Console.Write("-> ");
                opc = Console.ReadLine();
            } while (opc != "no");
        }

        public static void eliminarValores()
        {
            Console.Clear();

            Console.WriteLine("********** ELIMINANDO ESTADOS A LA COLA **********\n");
            string opc = "";
            do
            {
                Console.WriteLine("¿Desea eliminar un estado de la cola simple? Si / No");
                Console.Write("-> ");
                otro = Console.ReadLine();

                if (otro.Equals("si"))
                {
                    if (i == f)
                    {
                        temporal = estado[i];
                        Console.WriteLine(temporal + " ha sido eliminado");
                        estado[i] = null;
                        i = 0;
                        f = f - 1;
                    }
                    else
                    {
                        temporal = estado[i];
                        Console.WriteLine("\nEl estado de " + temporal + " ha sido eliminado\n");
                        estado[i] = null;
                        i = i + 1;
                    }
                }

                Console.WriteLine("¿Desea eliminar otro estado? Si / No");
                Console.Write("-> ");
                opc = Console.ReadLine();
            } while (opc != "no");
        }

        public static void mostrarValores()
        {
            Console.Clear();
            Console.WriteLine("********** MOSTRAR NOMBRES DE LA COLA **********");

            for (int j = 0; j <= f; j++)
            {
                Console.WriteLine(estado[j]);
            }

            Console.WriteLine("Presione la tecla <enter> para continuar.");
            Console.ReadKey();
        }
    }
}