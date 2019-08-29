using Console.Class;
using DLL.Models;
using DLL.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        private static int GetMenu()
        {
            int res;
            System.Console.WriteLine("---------MENU----------");
            System.Console.WriteLine("1.Consultar lista de personas\n" +
                                      "2.Consultar personas por ID\n" +
                                      "3.Eliminar persona\n" +
                                      "4.Agregr persona\n" +
                                      "5.Actualizar persona\n\n" +
                                      "Ingrese el numero de la opcion:");

            res = int.Parse(System.Console.ReadLine());
            return res;
        }
        static void Main(string[] args)
        {
            try
            {
                string response;
                do
                {
                    System.Console.Clear();
                    int res = GetMenu();

                    IRepository datos = new ProxyRepository();
                    if (res == 1)
                    {
                        System.Console.Clear();
                        List<Persona> listaPersonas = datos.GetAll();

                        System.Console.WriteLine("---------LISTADO DE PERSONAS----------");
                        foreach (var item in listaPersonas)
                        {
                            System.Console.WriteLine("Id: " + item.Id + " " +
                                                     "Nombre: " + item.Nombre + " " +
                                                     "\nApellido: " + item.Apellido + " " +
                                                      "\nDireccion: " + item.Direccion + " " +
                                                      "\nEdad: " + item.Edad + "\n");
                        }
                    }
                    else if (res == 2)
                    {

                        List<Persona> listaPersonas = datos.GetAll();

                        System.Console.WriteLine("---------LISTADO DE PERSONAS----------");
                        foreach (var item in listaPersonas)
                        {
                            System.Console.WriteLine("Id: " + item.Id + " " +
                                                     "Nombre: " + item.Nombre + " " +
                                                     "\nApellido: " + item.Apellido + " " +
                                                      "\nDireccion: " + item.Direccion + " " +
                                                      "\nEdad: " + item.Edad + "\n");
                        }



                        System.Console.WriteLine("Ingrese un id:");
                        int IdPersona = int.Parse(System.Console.ReadLine());

                        Persona resgistro = datos.GetById(IdPersona);

                        if (resgistro != null)
                        {

                            System.Console.WriteLine("---------LISTADO DE PERSONAS----------");

                            System.Console.WriteLine("Nombre: " + resgistro.Nombre + " " +
                                                         "\nApellido: " + resgistro.Apellido + " " +
                                                          "\nDireccion: " + resgistro.Direccion + " " +
                                                          "\nEdad: " + resgistro.Edad + "\n");
                        }
                        else
                        {
                            System.Console.WriteLine("Ingrese un ID valido");
                        }
                    }
                    else if (res == 3)
                    {
                        System.Console.Clear();
                        List<Persona> listaPersonas = datos.GetAll();
                        System.Console.WriteLine("---------LISTADO DE PERSONAS----------");
                        foreach (var item in listaPersonas)
                        {
                            System.Console.WriteLine("ID: " + item.Id + " " +
                                                      "Nombre: " + item.Nombre + " " +
                                                     "\nApellido: " + item.Apellido + " " +
                                                      "\nDireccion: " + item.Direccion + " " +
                                                      "\nEdad: " + item.Edad + "\n\n");
                        }

                        System.Console.WriteLine("Ingrese el id a eliminar:");
                        int IdPersona = int.Parse(System.Console.ReadLine());

                        Persona resgistro = datos.GetById(IdPersona);

                        if (resgistro != null)
                        {
                            bool deleteRegistro = datos.PersonOperation(resgistro, Facade.Operacion.Delete);

                            if (!deleteRegistro)
                            {
                                System.Console.WriteLine("Fallo al Eliminar el Registro");
                            }
                            else
                            {

                                System.Console.Clear();
                                System.Console.WriteLine("Registro Eliminado");
                                List<Persona> listaPersonas2 = datos.GetAll();
                                System.Console.WriteLine("---------LISTADO DE PERSONAS----------");
                                foreach (var item in listaPersonas2)
                                {
                                    System.Console.WriteLine("ID: " + item.Id + " " +
                                                              "Nombre: " + item.Nombre + " " +
                                                             "\nApellido: " + item.Apellido + " " +
                                                              "\nDireccion: " + item.Direccion + " " +
                                                              "\nEdad: " + item.Edad + "\n\n");
                                }

                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Ingrese un ID Valido");
                        }
                    }
                    else if (res == 4)
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("------Registro de Datos-------");

                        System.Console.WriteLine("Ingrese el Nombre:");
                        string name = (System.Console.ReadLine());

                        System.Console.WriteLine("Ingrese el Apellido:");
                        string lastname = (System.Console.ReadLine());


                        System.Console.WriteLine("Ingrese la Direccion:");
                        string address = (System.Console.ReadLine());

                        System.Console.WriteLine("Ingrese la Edad:");
                        int age = int.Parse(System.Console.ReadLine());

                        Persona savePerson = new Persona()
                        {

                            Nombre = name,
                            Apellido = lastname,
                            Direccion = address,
                            Edad = age

                        };

                        var obj = SingletonRepository.Instancia.Repository.PersonOperation(savePerson, Facade.Operacion.Save);


                        if (!obj)
                        {
                            System.Console.WriteLine("Fallo al crear el Registro");
                        }
                        else
                        {

                            System.Console.Clear();
                            System.Console.WriteLine("Registro Creado");
                            List<Persona> listaPersonas2 = datos.GetAll();
                            System.Console.WriteLine("---------LISTADO DE PERSONAS----------");
                            foreach (var item in listaPersonas2)
                            {
                                System.Console.WriteLine("ID: " + item.Id + " " +
                                                          "Nombre: " + item.Nombre + " " +
                                                         "\nApellido: " + item.Apellido + " " +
                                                          "\nDireccion: " + item.Direccion + " " +
                                                          "\nEdad: " + item.Edad + "\n\n");
                            }

                        }
                    }
                    else if (res == 5)
                    {
                        System.Console.Clear();
                        List<Persona> listaPersonas = datos.GetAll();
                        System.Console.WriteLine("---------LISTADO DE PERSONAS----------");
                        foreach (var item in listaPersonas)
                        {
                            System.Console.WriteLine("ID: " + item.Id + " " +
                                                      "Nombre: " + item.Nombre + " " +
                                                     "\nApellido: " + item.Apellido + " " +
                                                      "\nDireccion: " + item.Direccion + " " +
                                                      "\nEdad: " + item.Edad + "\n\n");
                        }

                        System.Console.WriteLine("Ingrese el Id de la persona a Actulizar:");
                        int IdPersona = int.Parse(System.Console.ReadLine());

                        Persona resgistro = datos.GetById(IdPersona);

                        if (resgistro != null)
                        {
                            System.Console.WriteLine("---------Actualizacion de Persona----------");

                            System.Console.Write("Ingrese el Nombre:");
                            System.Console.WriteLine(resgistro.Nombre);
                            resgistro.Nombre = (System.Console.ReadLine());

                            System.Console.Write("Ingrese el Apellido:");
                            System.Console.WriteLine(resgistro.Apellido);
                            resgistro.Apellido = (System.Console.ReadLine());


                            System.Console.Write("Ingrese la Direccion:");
                            System.Console.WriteLine(resgistro.Direccion);
                            resgistro.Direccion = (System.Console.ReadLine());

                            System.Console.Write("Ingrese la Edad:");
                            System.Console.WriteLine(resgistro.Edad);
                            resgistro.Edad = int.Parse(System.Console.ReadLine());


                            bool obj = datos.PersonOperation(resgistro, Facade.Operacion.Update);


                            if (!obj)
                            {
                                System.Console.WriteLine("Fallo al actualizar el Registro");
                            }
                            else
                            {

                                System.Console.Clear();
                                System.Console.WriteLine("Registro Actualizado");
                                List<Persona> listaPersonas2 = datos.GetAll();
                                System.Console.WriteLine("---------LISTADO DE PERSONAS----------");
                                foreach (var item in listaPersonas2)
                                {
                                    System.Console.WriteLine("ID: " + item.Id + " " +
                                                              "Nombre: " + item.Nombre + " " +
                                                             "\nApellido: " + item.Apellido + " " +
                                                              "\nDireccion: " + item.Direccion + " " +
                                                              "\nEdad: " + item.Edad + "\n\n");
                                }
                            }

                        }
                    }
                    else
                    {
                        System.Console.WriteLine("Ingrese una Opcion Valida");

                        System.Console.ReadKey();
                    }

                    System.Console.WriteLine("¿Desea salir? (S/N)");
                    response = System.Console.ReadLine();

                } while (response == "n" || response == "N");
            }
            catch (Exception ex)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Error:"+ex);
                System.Console.ReadKey();
            }
        }
    }
}
