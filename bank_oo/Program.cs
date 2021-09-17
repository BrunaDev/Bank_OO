using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBruna = new ContaCorrente("Bruna", 1234, 790,120);
            ContaCorrente contaDaBarbara = new ContaCorrente("Barbara", 1234, 789, 100.50);
            ContaCorrente contaDoPedro = new ContaCorrente("Pedro", 1234, 777, 1050);

            /*Console.WriteLine("O titular da conta é: "+contaDaBruna.titular);
            Console.WriteLine("O titular da conta é: "+contaDaBarbara.titular);
            Console.WriteLine("O titular da conta é: "+contaDoPedro.titular);*/

            //Saque
            contaDaBruna.Sacar(20);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.saldo);
            
            //Deposito
            /*contaDaBruna.Depositar(30);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.saldo);

            //Trasferencia
            contaDaBruna.Transferir(100, contaDoPedro);

            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.saldo);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.saldo);*/
        }
    }

}
