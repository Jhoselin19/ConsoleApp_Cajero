using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CajeroAutomatico:CuentaBancaria
    {

        public void GenerarPIN()
        {
            Random rnd = new Random();
            Pin = rnd.Next(1000, 10000);
        }

        public int ConsultarPIN()
        {
            return Pin;
        }

        public void CambiarPIN(int nuevoPIN)
        {
            Pin = nuevoPIN;
            Console.WriteLine("PIN cambiado exitosamente.");
        }

        //CONSULTAR SALDO
        public double ConsultarSaldo()
        {
            return Saldo;
        }

        //DEPOSITAR SALDO
        public void Depositar(double deposito)
        {
            if (deposito > 0)
            {
                Saldo += deposito;
                Console.WriteLine($"Se han depositado {deposito} en la cuenta.");
            }
            else
            {
                Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
            }
        }

        //RETIRAR SALDO

        public void Retirar(double retiro)
        {
            if(Saldo > retiro & retiro > 0)
            {
                Saldo -= retiro;
                Console.WriteLine($"Se han retirado {retiro} de la cuenta.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

        }


    }
}
