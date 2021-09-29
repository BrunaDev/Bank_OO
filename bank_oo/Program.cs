using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioFelipe = new Funcionario();
            funcionarioFelipe.Nome = "Felipe";
            funcionarioFelipe.CPF = "123.123.123-23";
            funcionarioFelipe.Cargo = "Vendedor";
            funcionarioFelipe.Salario = 1000;

            Funcionario funcionarioMaria = new Funcionario();
            funcionarioMaria.Nome = "Maria";
            funcionarioMaria.CPF = "456.456.456-56";
            funcionarioMaria.Cargo = "Vendedora";
            funcionarioMaria.Salario = 1000;

            ContaCorrente contaDaBruna = new ContaCorrente("Bruna Soares Magalhães", 1234, 120, funcionarioFelipe); //Felipe
            ContaCorrente contaDaStefany = new ContaCorrente("Stefany", 1234, 100.50, funcionarioMaria); //Maria
            ContaCorrente contaDoPedro = new ContaCorrente("Pedro", 1234, 1500, funcionarioMaria); //Maria

            Console.WriteLine("O titular da conta é: "+contaDaBruna.Titular);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O vendedor responsável foi o: " + funcionarioFelipe.Nome);

            Console.WriteLine("O titular da conta é: "+contaDaStefany.Titular);
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + funcionarioMaria.Nome);

            Console.WriteLine("O titular da conta é: "+contaDoPedro.Titular);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + funcionarioMaria.Nome);

            Console.WriteLine("---------------------------------------------------");

            //Saque
            contaDaBruna.Sacar(20);
            Console.WriteLine("Operação de saque, num valor de R$ 20,00");
            Console.WriteLine("O saldo atual da conta da Bruna é: " + contaDaBruna.Saldo);

            Console.WriteLine("---------------------------------------------------");
            
            //Trasferencia
            contaDaBruna.Transferir(10, contaDoPedro);
            Console.WriteLine("Operação de tranferência, num valor de R$ 10,00 - da Bruna para o Pedro.");
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O saldo da conta da Pedro é: " + contaDoPedro.Saldo);

            Console.WriteLine("---------------------------------------------------");

            //Deposito
            contaDaStefany.Depositar(50);
            Console.WriteLine("Operação de Despósito, num valor de R$ 50,00");
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);

            Console.WriteLine("---------------------------------------------------");
            
            /*Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.Saldo);

            Console.WriteLine("---------------------------------------------------");*/

            Console.WriteLine("A comissao do Vendedor Felipe é: " + funcionarioFelipe.Comissao);
            Console.WriteLine("A comissao da Vendedora Maria é: " + funcionarioMaria.Comissao);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Total de comissão a ser pago: " + ContaCorrente.TotalDeComissao);
        }
    }

}