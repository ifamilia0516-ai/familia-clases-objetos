using System;

namespace TecnoPuntoInventario
{
    public class Producto
    {
        // Campos privados
        private string codigo = string.Empty;
        private string nombre = string.Empty;
        private decimal precio;
        private int cantidad;

        // Propiedad Codigo
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        // Propiedad Nombre
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                nombre = value;
            }
        }

        // Propiedad Precio
        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El precio debe ser mayor que 0.");
                }
                precio = value;
            }
        }

        // Propiedad Cantidad
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La cantidad no puede ser negativa.");
                }
                cantidad = value;
            }
        }

        // Propiedad ValorTotal
        public decimal ValorTotal
        {
            get { return precio * cantidad; }
        }

        // Constructor
        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Método MostrarInfo

        public void MostrarInfo()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio unitario: RD${Precio:N2}");
            Console.WriteLine($"Cantidad en existencia: {Cantidad}");
            Console.WriteLine($"Valor total: RD${ValorTotal:N2}");
            Console.WriteLine("----------------------------------------");
        }

    }
}

