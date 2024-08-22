using System;
class Market
{

    static void Main(string[] arg)
    {
        Console.WriteLine("//Bienvenido al sistema de ventas de Market// ");
        Console.WriteLine("favor ingrese su Nombre");
        String Nombre = Console.ReadLine();
        Console.WriteLine("favor ingrese su Edad");
        int Edad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Elija la categoria del producto que deceas ");
        Console.WriteLine("A: Carnes");
        Console.WriteLine("B: Refrescos");
        Console.WriteLine("C: Snaks");
        Console.WriteLine("D: Frutas");

        String Categoria = Console.ReadLine();

        double Precio = 0;
        string Producto = "";
        string Tamaño = "";

        if (Categoria == "A")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado//");
            Console.WriteLine("1. Filete 40 Lps ");
            Console.WriteLine("2. Chuleta 60 Lps");
            Console.WriteLine("3. Pollo 54 Lps");
            Console.WriteLine("4. Tajo Premiun 60 Lps");
            Console.WriteLine("5. Pescado 50 Lps");
            Producto = Console.ReadLine();


            if (Producto == "1")
            {
                Precio = 40;
            }
            else if (Producto == "2")
            {
                Precio = 60;
            }
            else if (Producto == "3")
            {
                Precio = 54;
            }
            else if (Producto == "4")
            {
                Precio = 60;
            }
            else if (Producto == "5")
            {
                Precio = 50;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }

        else if (Categoria == "B")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado//");
            Console.WriteLine("1. Coca Cola 45.Lps");
            Console.WriteLine("2. Pepsi 68 Lps");
            Console.WriteLine("3. Seven 45 Lps");
            Console.WriteLine("4. Link 30 Lps");
            Console.WriteLine("5. Banana 45 Lps");
            Producto = Console.ReadLine();



            if (Producto == "1")
            {
                Precio = 45;
            }
            else if (Producto == "2")
            {
                Precio = 68;
            }
            else if (Producto == "3")
            {
                Precio = 45;
            }
            else if (Producto == "4")
            {
                Precio = 30;
            }
            else if (Producto == "5")
            {
                Precio = 45;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }


        }

        else if (Categoria == "C")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado//");
            Console.WriteLine("1. Galletas 25.Lps ");
            Console.WriteLine("2. Gomitas 45 Lps");
            Console.WriteLine("3. Churros 14 Lps");
            Console.WriteLine("4. Chicles 10  Lps");
            Console.WriteLine("5. Donas 45 Lps");
            Producto = Console.ReadLine();



            if (Producto == "1")
            {
                Precio = 25;
            }
            else if (Producto == "2")
            {
                Precio = 45;
            }
            else if (Producto == "3")
            {
                Precio = 14;
            }
            else if (Producto == "4")
            {
                Precio = 10;
            }
            else if (Producto == "5")
            {
                Precio = 45;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }

        else if (Categoria == "D")
        {
            Console.WriteLine("Tenemos los siguientes Productos, Escriba el numero deseado//");
            Console.WriteLine("1. Manzanas 10 Lps. ");
            Console.WriteLine("2. Uvas 25 Lps");
            Console.WriteLine("3. piñas 15 Lps");
            Console.WriteLine("4. Fresas 25 Lps");
            Console.WriteLine("5. Mango 10 Lps");
            Producto = Console.ReadLine();


            if (Producto == "1")
            {
                Precio = 10;
            }
            else if (Producto == "2")
            {
                Precio = 25;
            }
            else if (Producto == "3")
            {
                Precio = 15;
            }
            else if (Producto == "4")
            {
                Precio = 25;
            }
            else if (Producto == "5")
            {
                Precio = 10;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }
        }

        if (Precio > 0)
        {
            Console.WriteLine("Elija el tamaño  del producto:");
            Console.WriteLine("G. Grande");
            Console.WriteLine("M. Mediano");
            Console.WriteLine("P. Pequeño");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño == 1)
            {
                Precio = Precio;
            }
            else if (tamaño == 2)
            {
                Precio = Precio * 1.2;
            }
            else if (tamaño == 3)
            {
                Precio = Precio * 1.2 * 1.3;
            }
            Console.WriteLine("El precio del producto es: " + Precio);
            Console.Write("Ingrese la cantidad deseada: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            double subtotal = (Precio * cantidad);
            double
            impuesto = 0;
            if (Categoria == "1")
            {
                impuesto = 0;
            }
            else
            {
                impuesto = subtotal * 0.15;
            }
            double descuento = 0;
            if (Edad >= 60)
            {
                descuento = subtotal * 0.3;
            }
            else
            {
                descuento = 0;
            }

            double total = subtotal + impuesto - descuento;
            Console.WriteLine("El valor a pagar es de:" + total, "Usted esta pagando un impuesto de:" + impuesto, "Y un descuento de:" + descuento);
            Console.WriteLine($"El valor a pagar es de;); {total} Usted esta pagando un impuesto de: {impuesto} Y un descuento de: {descuento} ");


        }
    }
}