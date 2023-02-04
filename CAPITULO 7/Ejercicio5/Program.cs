
using System.Collections;

Hashtable agenda = new Hashtable();
string nombre, telefono;

            while (true)
            {
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Buscar contacto");
                Console.WriteLine("3. Eliminar contacto");
                Console.WriteLine("4. Ver todos los contactos");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingrese el nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese el número telefónico: ");
                    telefono = Console.ReadLine();
                    agenda.Add(nombre, telefono);
                    Console.WriteLine("\nContacto agregado exitosamente\n");
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese el nombre del contacto que desea buscar: ");
                    nombre = Console.ReadLine();
                    if (agenda.ContainsKey(nombre))
                    {
                        Console.WriteLine("\nNombre: " + nombre);
                        Console.WriteLine("Número telefónico: " + agenda[nombre]);
                    }
                    else
                    {
                        Console.WriteLine("\nContacto no encontrado\n");
                    }
                }
                else if (opcion == 3)
                {
                    Console.Write("Ingrese el nombre del contacto que desea eliminar: ");
                    nombre = Console.ReadLine();
                    if (agenda.ContainsKey(nombre))
                    {
                        agenda.Remove(nombre);
                        Console.WriteLine("\nContacto eliminado exitosamente\n");
                    }
                    else
                    {
                        Console.WriteLine("\nContacto no encontrado\n");
                    }
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\nContactos: ");
                    foreach (DictionaryEntry contacto in agenda)
                    {
                        Console.WriteLine("Nombre: " + contacto.Key + ", Número telefónico: " + contacto.Value);
                    }
                    Console.WriteLine();
                }
                else if (opcion == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpción inválida\n");
                }
            }