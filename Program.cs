using System;


namespace ProductoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto miProducto = new Producto(1, "Laptop", 850.00, 10);
            miProducto.MostrarProducto();

            Console.WriteLine("\n--- Probando asignación de valores inválidos ---");

            miProducto.Precio = -50.0;
            miProducto.Stock = -5;

            Console.WriteLine("\n--- Probando método DescontarStock ---");

            miProducto.DescontarStock(4);
            miProducto.DescontarStock(10);

            Console.WriteLine("\n--- Estado final del producto ---");
            miProducto.MostrarProducto();

            Console.ReadKey();
        }
    }
}
