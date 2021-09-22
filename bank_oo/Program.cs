using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBruna = new ContaCorrente("Bruna", 1234,120);
            contaDaBruna.Conta = 789;
            ContaCorrente contaDaBarbara = new ContaCorrente("Barbara", 1234, 100.50);
            ContaCorrente contaDoPedro = new ContaCorrente("Pedro", 1234, 1050);

            /*Console.WriteLine("O titular da conta é: "+contaDaBruna.titular);
            Console.WriteLine("O titular da conta é: "+contaDaBarbara.titular);
            Console.WriteLine("O titular da conta é: "+contaDoPedro.titular);*/

            //Saque
            contaDaBruna.Sacar(120);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O número da conta da Bruna é: " + contaDaBruna.Conta);
            
            //Trasferencia
            /*contaDaBruna.Transferir(120, contaDoPedro);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O saldo da conta da Pedro é: " + contaDoPedro.Saldo);*/

            //Deposito
            /*contaDaBruna.Depositar(30);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.saldo);

            

            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.saldo);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.saldo);*/
        }
    }

}
