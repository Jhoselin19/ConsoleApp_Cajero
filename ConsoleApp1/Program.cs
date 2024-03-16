// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

// operacion = new Operacion();

//persona.ValorA = 10;
//persona.ValorB = 20;

//int suma = persona.Sumar();
//int resta = persona.Restar();

//Console.WriteLine("El resultado de la suma es: ");
//Console.WriteLine(suma);
//Console.WriteLine("El resultado de la resta es: ");
//Console.WriteLine(resta);

//Console.WriteLine("Hello, World!");

CajeroAutomatico cajero = new CajeroAutomatico();

int PinAleatorio = cajero.ConsultarPIN();

Console.WriteLine(cajero.ConsultarPIN());

Console.WriteLine("Ingrese PIN: ");

int pin = int.Parse(Console.ReadLine());


if (pin == PinAleatorio)
{
    int opcion = 0;

    while (opcion != 5)
    {
        Console.WriteLine("1) Depositar");
        Console.WriteLine("2) Retirar");
        Console.WriteLine("3) Cambiar PIN");
        Console.WriteLine("4) Mostrar Saldo");
        Console.WriteLine("5) Salir");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese el monto a depositar:");
                double deposito = double.Parse(Console.ReadLine());
                cajero.Depositar(deposito);
                break;
            case 2:
                Console.WriteLine("Ingrese el monto a retirar:");
                double retiro = double.Parse(Console.ReadLine());
                cajero.Retirar(retiro);
                break;
            case 3:
                Console.WriteLine("Ingrese el nuevo PIN:");
                int nuevoPIN = int.Parse(Console.ReadLine());
                cajero.CambiarPIN(nuevoPIN);
                break;
            case 4:
                Console.WriteLine("Saldo actual: S/." + cajero.ConsultarSaldo());
                break;
            case 5:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                break;
        }
    }
}
else
{
    Console.WriteLine("PIN incorrecto. Acceso denegado.");
}

//------------------------------------------------------
