using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioListasDiccionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productos = new List<string>();
            productos.Add("Acondicionador");
            productos.Add("Shampoo");
            productos.Add("Jabon");
            productos.Insert(3, "Nuevo Producto");
            productos.Add("Pasta");
            productos.Add("Ace");
            productos.Add("Cloro");
            productos.Add("Aceite");
            productos.Add("Acido");
            productos.Add("Bicarbonato");
            productos.RemoveAt(productos.Count - 1);
            foreach (string producto in productos)
            {
                Console.WriteLine(producto);
            }


        }
    }
}
