using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteCarlos = new Gerente(){
                Nome = "Carlos",
                CPF = "987.988.987.87",
                Salario = 2000
            };

            gerenteCarlos.Bonificacao = gerenteCarlos.Salario;

            Vendedor vendedorFelipe = new Vendedor(){
                Nome = "Felipe",
                CPF = "123.123.123-23",
                Salario = 1000
            };

            vendedorFelipe.Bonificacao = vendedorFelipe.Salario;

            Vendedor vendedorMaria = new Vendedor(){
                Nome = "Maria",
                CPF = "456.456.456-56",
                Salario = 1000
            };

            ContaCorrente contaDaBruna = new ContaCorrente("Bruna", 1234, 120, vendedorFelipe); //Felipe
            ContaCorrente contaDaStefany = new ContaCorrente("Stefany", 1234, 100.50, vendedorMaria); //Maria
            ContaCorrente contaDoPedro = new ContaCorrente("Pedro", 1234, 1500, vendedorFelipe); //Maria

            Console.WriteLine("O saldo da conta da Barbara é: " + contaDaBruna.Saldo);
        }
    }

}