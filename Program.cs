using System;
class Market
{
    static void Main(string[] arg)
    {
        Console.WriteLine("Bienvenido al sistema de ventas de Market ");
        Console.WriteLine("favor ingrese su Nombre");
        String Nombre = Console.ReadLine();
        Console.WriteLine("favor ingrese su Edad");
        String Edad = Console.ReadLine();
        Console.WriteLine("Elija la categoria del producto que deceas ");
        Console.WriteLine("A: Carnes");
        Console.WriteLine("B: Refrescos");
        Console.WriteLine("C: Snaks");
        Console.WriteLine("D: Frutas");
        Console.WriteLine("E: Verduras");
        String Categoria = Console.ReadLine();
        
        
        
         if (Categoria == "A")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado");
            Console.WriteLine("1. Filete 40.Lps. ");
            Console.WriteLine("2. Chuleta 60.Lps");
            Console.WriteLine("3. Pollo 54.Lps");
        }
        else if (Categoria == "B")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado");
            Console.WriteLine("1. Coca Cola 45.Lps");
            Console.WriteLine("2. Pepsi 68.Lps");
            Console.WriteLine("3. Seven 45.Lps");
        }
        else if (Categoria == "C")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado");
            Console.WriteLine("1. Galletas 25.Lps ");
            Console.WriteLine("2. Gomitas 45.Lps");
            Console.WriteLine("3. Churros 14.Lps");
        }
        else if (Categoria == "D")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado");
            Console.WriteLine("1. Manzanas 10:Lps. ");
            Console.WriteLine("2. Uvas 25.Lps");
            Console.WriteLine("3. piñas 15.Lps");
        }
        else if (Categoria == "E")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado");
            Console.WriteLine("1. Yuca 16.Lps ");
            Console.WriteLine("2. Papas 12.Lps");
            Console.WriteLine("3. Repollo 16.Lps");
        }
        else
        {
            Console.WriteLine("La Categoria del producto seleccionado no existe");
        }
    }
}  