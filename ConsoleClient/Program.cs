using System;
using System.Data;

namespace ConsoleClient
{
    internal class Program
    {

        static ServiceReference1.WSClienteSoapClient service = new ServiceReference1.WSClienteSoapClient();

        static string[] Autor = { "CodAutor", "Apellidos", "Nombres", "Nacionalidad" };
        static string[] Libro = { "CodLibro", "Titulo", "Editorial" };
        static string[] Prestamo = { "CodAutor", "CodLibro", "FechaPrestamo" };
        public static void ListarT(int Tabla)
        {
            DataSet ds = new DataSet();
            Console.WriteLine("==============================================");
            switch (Tabla)
            {
                case 1:
                    ds = service.ListarAutor();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string fila = "";
                        for (int i = 0; i < Autor.Length; i++)
                        {
                            fila += row[i] + " | ";
                        }
                        Console.WriteLine(fila);
                    }
                    break;
                case 2:
                    ds = service.ListarLibro();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string fila = "";
                        for (int i = 0; i < Libro.Length; i++)
                        {
                            fila += row[i] + " | ";
                        }
                        Console.WriteLine(fila);
                    }
                    break;
                case 3:
                    ds = service.ListarPrestamo();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string fila = "";
                        for (int i = 0; i < Prestamo.Length; i++)
                        {
                            fila += row[i] + " | ";
                        }
                        Console.WriteLine(fila);
                    }
                    break;
                default:
                    break;
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("Cliente Consola Biblioteca");
            Console.WriteLine();
            Console.WriteLine("==============================================");
            bool flag = true;
            bool flagi = false;

            while (flag)
            {
                Console.WriteLine();
                Console.WriteLine("Bienvenido al mantenimiento de las tablas: ");
                Console.WriteLine("Autor[1]");
                Console.WriteLine("Libro[2]");
                Console.WriteLine("Prestamo[3]");
                Console.WriteLine();
                Console.Write("Ingrese una opcion: ");

                string tabla = Console.ReadLine();
                string opcs = "Listar[1]\nAgregar[2]\nActualizar[3]\nEliminar[4]";

                switch (tabla)
                {
                    case "1":
                        flagi = true;
                        while (flagi)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine();
                            Console.WriteLine("CRUD de Autor");
                            Console.WriteLine();
                            Console.WriteLine(opcs);
                            Console.WriteLine("==============================================");
                            Console.Write("Seleccione una opcion para la Tabla Autor: ");
                            int op = int.Parse(Console.ReadLine());
                            string[] nuevafilap = new string[Autor.Length];
                            string autorid = "";
                            switch (op)
                            {
                                case 1:
                                    ListarT(1);
                                    break;
                                case 2:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("==================AGREGAR=====================");
                                    Console.WriteLine("==============================================");
                                    for (int i = 0; i < Autor.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Autor[i] + ": ");
                                        nuevafilap[i] = Console.ReadLine();
                                    }
                                    service.AgregarAutor(nuevafilap[0], nuevafilap[1], nuevafilap[2], nuevafilap[3]);
                                    ListarT(1);
                                    break;
                                case 3:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ACTUALIZAR===================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese AutorID: ");
                                    autorid = Console.ReadLine();

                                    for (int i = 1; i < Autor.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Autor[i] + ": ");
                                        nuevafilap[i-1] = Console.ReadLine();
                                    }
                                    service.ActualizarAutor(autorid, nuevafilap[0], nuevafilap[1], nuevafilap[2]);
                                    ListarT(1);
                                    break;
                                case 4:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ELIMINAR=====================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese AutorID: ");
                                    autorid = Console.ReadLine();
                                    service.EliminarAutor(autorid);
                                    ListarT(1);
                                    break;
                                default:
                                    flagi = false;
                                    break;
                            }
                        }

                        break;
                    case "2":
                        flagi = true;
                        while (flagi)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine();
                            Console.WriteLine("CRUD de Libro");
                            Console.WriteLine();
                            Console.WriteLine(opcs);
                            Console.WriteLine("==============================================");
                            Console.Write("Seleccione una opcion para la Tabla Libro: ");
                            int op = int.Parse(Console.ReadLine());
                            string[] nuevafilap = new string[Libro.Length - 1];
                            string Libroid = "";
                            switch (op)
                            {
                                case 1:
                                    ListarT(2);
                                    break;
                                case 2:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("==================AGREGAR=====================");
                                    Console.WriteLine("==============================================");
                                    for (int i = 0; i < Libro.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Libro[i] + ": ");
                                        nuevafilap[i] = Console.ReadLine();
                                    }
                                    service.AgregarLibro(nuevafilap[0], nuevafilap[1], nuevafilap[2]);
                                    ListarT(2);
                                    break;
                                case 3:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ACTUALIZAR===================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese LibroID: ");
                                    Libroid = Console.ReadLine();

                                    for (int i = 1; i < Libro.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Libro[i] + ": ");
                                        nuevafilap[i-1] = Console.ReadLine();
                                    }
                                    service.ActualizarLibro(Libroid, nuevafilap[0], nuevafilap[1]);
                                    ListarT(2);
                                    break;
                                case 4:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ELIMINAR=====================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese LibroidID: ");
                                    Libroid = Console.ReadLine();
                                    service.EliminarLibro(Libroid);
                                    ListarT(2);
                                    break;
                                default:
                                    flagi = false;
                                    break;
                            }
                        }
                        break;
                    case "3":
                        flagi = true;
                        while (flagi)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine();
                            Console.WriteLine("CRUD de Prestamo");
                            Console.WriteLine();
                            Console.WriteLine(opcs);
                            Console.WriteLine("==============================================");
                            Console.Write("Seleccione una opcion para la Tabla Prestamo: ");
                            int op = int.Parse(Console.ReadLine());
                            string[] nuevafilap = new string[Prestamo.Length];
                            string Prestamoid = "";
                            switch (op)
                            {
                                case 1:
                                    ListarT(3);
                                    break;
                                case 2:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("==================AGREGAR=====================");
                                    Console.WriteLine("==============================================");
                                    for (int i = 0; i < Prestamo.Length; i++)
                                    {
                                        Console.Write("Ingrese " + Prestamo[i] + ": ");
                                        nuevafilap[i] = Console.ReadLine();
                                    }
                                    service.AgregarPrestamo(nuevafilap[0], nuevafilap[1], nuevafilap[2]);
                                    ListarT(3);
                                    break;
                                case 3:
                                     Console.WriteLine("==============================================");
                                     Console.WriteLine("======NO SE PUEDE ACTUALIZAR ESTA TABLA=======");
                                     Console.WriteLine("==============================================");
                                     break;
                                case 4:
                                    Console.WriteLine("==============================================");
                                    Console.WriteLine("=================ELIMINAR=====================");
                                    Console.WriteLine("==============================================");
                                    Console.Write("Ingrese IDAutor: ");
                                    Prestamoid = Console.ReadLine();
                                    Console.Write("Ingrese IDLibro: ");
                                    string idLibro = Console.ReadLine();
                                    Console.Write("Ingrese FechaPrestamo: ");
                                    string fechaprestamo = Console.ReadLine();
                                    service.EliminarPrestamo(Prestamoid, idLibro, fechaprestamo);
                                    ListarT(3);
                                    break;
                                default:
                                    flagi = false;
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine("==============================================");



                Console.WriteLine("==============================================");



                Console.WriteLine();

                //Autor
                //Libro
                //Prestamo


            }
            Console.ReadKey();
        }

    }
}