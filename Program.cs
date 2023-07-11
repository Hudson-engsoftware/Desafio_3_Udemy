
using System;
using System.Globalization;

namespace Course;

    class Program{
    public static object Saldo { get; private set; }

    static void Main(String[]args){

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int  Numero  = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.Write("Entre com o Titular da Conta : ");
            string Titular = Console.ReadLine();

            Console.WriteLine("Haverá Desposito inicial (s/n)");
            char resposta = char.Parse(Console.ReadLine());

                if(resposta == 's'){

                    Console.WriteLine("Entre com o valor de deposito inicial:");
                    double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    conta = new ContaBancaria(numero,titular,depositoInicial);

                }else{

                    conta = new ContaBancaria(numero,titular);
                }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta :");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para Deposito : ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da Conta atualizados :");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write("Entre com um valor para Saque : ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da Conta atualizados :");
            Console.WriteLine(conta);




        {
                
            }

        }
    }
