using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            string codSys = @"C:\";
            string comentario;
            string contenido;
            string nombreAr;
            string opcion;
            string contenidoprueba;
            bool repetir = false;

            
            /*Lista Enlazada para crear Ramas*/
            contenido = "PruebasRamas";
            Console.ForegroundColor = ConsoleColor.White;
            Global.manejoAr.agregarVersion((new Repositorio("Principal", contenido)), "branch");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Global.nuevoPath + "\\" + "Se crea rama principal");
            Console.ForegroundColor = ConsoleColor.White;
            int i = 0;
            do
            {

                Console.WriteLine("C:\\");
                opcion = Console.ReadLine();
                if (opcion.Contains("create ver"))
                {
                    if (!Global.manejoAr.validarNodosRamas())
                    {
                        if (!Global.manejoAr.validarNodos())
                        {
                            /*Lista Enlazada para crear versiones*/
                            contenido = opcion.Substring(11);
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            comentario = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Global.manejoAr.agregarVersion((new Repositorio(comentario, contenido)), "ver");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine(Global.nuevoPath + "\\" + "Se crea nueva versión");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            
                            /*Lista Enlazada para crear versiones*/
                            contenido = opcion.Substring(11);
                            Console.Write(Global.nuevoPath + "\\" + "Ingrese un comentario para la versión\\");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            comentario = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Global.manejoAr.agregarVersion((new Repositorio(comentario, contenido)), "ver");
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine(Global.nuevoPath + "\\" + "Se crea nueva versión");
                            Console.ForegroundColor = ConsoleColor.White;
                        }


                    }
                    else
                    {
                        /*Lista Enlazada para crear Ramas*/
                        contenido = "PruebasRamas";
                        Console.Write(Global.nuevoPath + "\\" + "Ingrese un comentario para la Rama\\");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        comentario = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Global.manejoAr.agregarVersion((new Repositorio(comentario, contenido)), "branch");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(Global.nuevoPath + "\\" + "Se crea nueva Rama");
                        Console.ForegroundColor = ConsoleColor.White;


                    }
                }
                else
                {
                    if (opcion.Contains("create branch"))
                    {
                        contenido = opcion.Substring(13);
                        Console.ForegroundColor = ConsoleColor.White;
                        Global.manejoAr.agregarVersion((new Repositorio("Secundaria", contenido)), "branch");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(Global.nuevoPath + "\\" + "Se crea rama principal");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                }

                //Con este caso se imprime por consola la información de las Versiones, siguiendo las especificación del
                //requerimiento
                /*
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Global.manejoAr.recorreRamas(); //Llamada al método Recorrer, este recorre la lista enlazada
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Global.manejoAr.recorre(); //Llamada al método Recorrer, este recorre la lista enlazada
                Console.ForegroundColor = ConsoleColor.White;
                */
                Console.WriteLine("Desea continuar");
                op = Console.ReadLine();
            } while (op.Equals("si"));
            
            
                
            

            

            



        }
                    }
                
  

      
}