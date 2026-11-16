using System;

namespace TecnoPuntoInventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE CONTROL DE INVENTARIO - TECNOPUNTO ===");
            Console.WriteLine("Ingrese los datos de 3 productos.\n");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"\n--- Registro del Producto #{i} ---");

                string codigo = LeerCodigo();
                string nombre = LeerNombre();
                decimal precio = LeerPrecio();
                int cantidad = LeerCantidad();

                try
                {
                    Producto producto = new Producto(codigo, nombre, precio, cantidad);

                    Console.WriteLine("\nProducto registrado correctamente:");
                    producto.MostrarInfo();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    Console.WriteLine("Intente registrar el producto nuevamente.");
                    i--;
                }
            }

            Console.WriteLine("\nFin del programa.");
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }

        static string LeerCodigo()
        {
            while (true)
            {
                Console.Write("Ingrese el código: ");
                string codigo = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(codigo))
                {
                    return codigo;
                }

                Console.WriteLine("Error: El código no puede estar vacío.");
            }
        }

        static string LeerNombre()
        {
            while (true)
            {
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine() ?? "";

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    return nombre;
                }

                Console.WriteLine("Error: El nombre no puede estar vacío.");
            }
        }

        static decimal LeerPrecio()
        {
            while (true)
            {
                Console.Write("Ingrese el precio: ");

                if (decimal.TryParse(Console.ReadLine(), out decimal precio)
                    && precio > 0)
                {
                    return precio;
                }

                Console.WriteLine("Error: El precio debe ser mayor que cero.");
            }
        }

        static int LeerCantidad()
        {
            while (true)
            {
                Console.Write("Ingrese la cantidad: ");

                if (int.TryParse(Console.ReadLine(), out int cantidad)
                    && cantidad >= 0)
                {
                    return cantidad;
                }

                Console.WriteLine("Error: La cantidad no puede ser negativa.");
            }
        }
    }
}