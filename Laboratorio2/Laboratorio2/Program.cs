using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio2
{
    internal class Program
    {

        static List<Categoria> categorias = new List<Categoria>
    {
        new Categoria { Id = 1, Nombre = "Productos de limpieza" },
        new Categoria { Id = 2, Nombre = "Cuidado personal" },
        new Categoria { Id = 3, Nombre = "Frutas y verduras" }
    };

        static List<Area> areas = new List<Area>
    {
        new Area { Id = 1, Nombre = "Carniceria" },
        new Area { Id = 2, Nombre = "Bebidas" }
    };

        static List<Producto> productos = new List<Producto>();

        static List<Usuario> usuarios = new List<Usuario>();

        static List<Producto> productosSeleccionados = new List<Producto>();

        static void Main(string[] args)
        {
            bool seguirComprando = true;
            string nombreCliente = "";


            // Agregar usuarios
            usuarios.Add(new Usuario { Id = 1, Nombre = "Admin", Edad = 25, Nivel = "Nivel1" });
            usuarios.Add(new Usuario { Id = 2, Nombre = "Vendedor", Edad = 30, Nivel = "Nivel2" });

            while (seguirComprando)
            {
                Console.WriteLine("===== Bienvenido a Supermercado El Baratillo =====");
                Console.WriteLine("1. Crear categoría");
                Console.WriteLine("2. Crear área");
                Console.WriteLine("3. Crear producto");
                Console.WriteLine("4. Realizar venta");
                Console.WriteLine("5. Mostrar productos seleccionados");
                Console.WriteLine("6. Salir");
                Console.WriteLine("===========================");
                Console.WriteLine("Ingrese una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1. Crear categoría");
                        break;

                    case 2:
                        Console.WriteLine("2. Crear área");
                        break;
                    case 3:
                        Console.WriteLine("3. Crear producto");
                        break;

                    case 4:
                        Console.WriteLine("4. Realizar venta");
                        break;
                    case 5:
                        Console.WriteLine("5. Mostrar productos seleccionados");
                        break;
                    case 6:
                        Console.WriteLine("6. Salir");
                        break;
                                                    
                    default:
                        Console.WriteLine("Numero incorrecto");
                        break;

                }
            }
        }
                           
        class Categoria
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        // Clase para representar un área
        class Area
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        // Clase para representar un producto
        class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Proveedor { get; set; }
            public DateTime FechaCaducidad { get; set; }
            public DateTime FechaEntrada { get; set; }
            public string Detalles { get; set; }
            public double Precio { get; set; }
            public int Unidades { get; set; }

            
            public void MostrarDetalles()
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Proveedor: {Proveedor}");
                Console.WriteLine($"Fecha de caducidad: {FechaCaducidad}");
                Console.WriteLine($"Fecha de entrada: {FechaEntrada}");
                Console.WriteLine($"Detalles: {Detalles}");
                Console.WriteLine($"Precio: {Precio}");
                Console.WriteLine($"Unidades: {Unidades}");
            }

           internal class Usuario
            {
                public int Id { get; set; }
                public string Nombre { get; set;}
                public string Edad { get; set; }
                public int nivel { get; set; }
                public string Proveedor { get; set; }
                
            }
            
               

            


        }



    }


}







     




