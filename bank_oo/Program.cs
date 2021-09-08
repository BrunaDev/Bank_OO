using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaBruna = new ContaCorrente();
            
            contaDaBruna.titular = "Bruna";
            contaDaBruna.agencia = 1234;
            contaDaBruna.conta = 790;
            contaDaBruna.saldo = 120;

            ContaCorrente contaDaBarbara = new ContaCorrente();

            contaDaBarbara.titular = "Barbara";
            contaDaBarbara.agencia = 1234;
            contaDaBarbara.conta = 789;
            contaDaBarbara.saldo = 100.50;

            Console.WriteLine("O titular da conta é: "+contaDaBruna.titular);
            Console.WriteLine("O titular da conta é: "+contaDaBarbara.titular);
        }
    }
}
