using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteJulia = new Gerente(){
                Nome = "Júlia",
                CPF = "987.988.987.87",
                Salario = 2000,
                NumeroDeAgencias = 5
            };

            gerenteJulia.Bonificacao = gerenteJulia.Salario;

            Vendedor vendedorFelipe = new Vendedor(){
                Nome = "Felipe",
                CPF = "123.123.123-23",
                Salario = 1000,
                NumeroClientesAtendidos = 2
            };

            vendedorFelipe.Bonificacao = vendedorFelipe.Salario;

            Vendedor vendedorMaria = new Vendedor(){
                Nome = "Maria",
                CPF = "456.456.456-56",
                Salario = 1000,
                NumeroClientesAtendidos = 4
            };

            vendedorMaria.Bonificacao = vendedorMaria.Salario;

            Vendedor vendedorJoseph = new Vendedor(){
                Nome = "Joseph",
                CPF = "789.789.789-89",
                Salario = 1000,
                NumeroClientesAtendidos = 3
            };

            vendedorJoseph.Bonificacao = vendedorJoseph.Salario;

            ContaCorrente contaDaBruna = new ContaCorrente("Bruna Soares Magalhães", 1234, 120, vendedorJoseph); //Joseph
            ContaCorrente contaDaStefany = new ContaCorrente("Stefany", 1234, 100, vendedorMaria); //Maria
            ContaCorrente contaDoPedro = new ContaCorrente("Pedro", 1234, 1500, vendedorFelipe); //Felipe

            Console.WriteLine("------------------------------------Contas------------------------------------");

            Console.WriteLine("O titular da conta é: "+contaDaBruna.Titular);
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O vendedor responsável foi o: " + vendedorJoseph.Nome);
            Console.WriteLine("");
            Console.WriteLine("O titular da conta é: "+contaDaStefany.Titular);
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + vendedorMaria.Nome);
            Console.WriteLine("");
            Console.WriteLine("O titular da conta é: "+contaDoPedro.Titular);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + vendedorFelipe.Nome);
            Console.WriteLine("");
            Console.WriteLine("Operações");
            Console.WriteLine("-------------------------------------Saque-------------------------------------");

            //Saque
            contaDaBruna.Sacar(20);
            Console.WriteLine("Operação de saque, num valor de R$ 20,00");
            Console.WriteLine("O saldo atual da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("");
            Console.WriteLine("-------------------------------Transferência-------------------------------");
            
            //Trasferencia
            contaDaBruna.Transferir(10, contaDoPedro);
            Console.WriteLine("Operação de tranferência, num valor de R$ 10,00 - da Bruna para o Pedro.");
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O saldo da conta da Pedro é: " + contaDoPedro.Saldo);
            Console.WriteLine("");
            Console.WriteLine("----------------------------------Depósito----------------------------------");

            //Deposito
            contaDaStefany.Depositar(50);
            Console.WriteLine("Operação de Despósito, num valor de R$ 50,00");
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("");
            Console.WriteLine("------------------------------Saldo das Contas-----------------------------");
            
            Console.WriteLine("O saldo da conta da Bruna é: " + contaDaBruna.Saldo);
            Console.WriteLine("O saldo da conta da Stefany é: " + contaDaStefany.Saldo);
            Console.WriteLine("O saldo da conta do Pedro é: " + contaDoPedro.Saldo);
            Console.WriteLine("");
            Console.WriteLine("---------------------------Comissão vendedores----------------------------");

            Console.WriteLine("A comissao do vendedor Felipe é: " + vendedorFelipe.Comissao);
            Console.WriteLine("A comissao da vendedora Maria é: " + vendedorMaria.Comissao);
            Console.WriteLine("A comissao da vendedor Joseph é: " + vendedorJoseph.Comissao);
            Console.WriteLine("Total de comissão a ser pago: " + ContaCorrente.TotalDeComissao);
            Console.WriteLine("");
            Console.WriteLine("------------------------------Bonificação Anual-----------------------------");

            Console.WriteLine("A bonificação do vendedor Felipe é de: R$" + vendedorFelipe.Bonificacao);
            Console.WriteLine("A bonificação da vendedora Maria é de: R$" + vendedorMaria.Bonificacao);
            Console.WriteLine("A bonificação do vendedor Joseph é de: R$" + vendedorJoseph.Bonificacao);
            Console.WriteLine("A bonificação da gerente Júlia é de: R$" + gerenteJulia.Bonificacao);
            Console.WriteLine("");
            Console.WriteLine("-----------------------------Remuneração Total-----------------------------");
            
            Console.WriteLine("O vendedor Felipe receberá R$" + vendedorFelipe.RemuneracaoTotal(vendedorFelipe.Salario, vendedorFelipe.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A vendedora Maria receberá R$" + vendedorMaria.RemuneracaoTotal(vendedorMaria.Salario, vendedorMaria.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("O vendedor Joseph receberá R$" + vendedorJoseph.RemuneracaoTotal(vendedorJoseph.Salario, vendedorJoseph.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("A gerente Júlia receberá R$" + gerenteJulia.RemuneracaoTotal(gerenteJulia.Salario, gerenteJulia.Bonificacao) + " de remuneração total anual.");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------Férias----------------------------------");

            Console.WriteLine("A gerente Júlia terá " + gerenteJulia.CalcularFerias() + " dias de férias");
            Console.WriteLine("O vendedor Felipe terá " + vendedorFelipe.CalcularFerias() + " dias de férias");
            Console.WriteLine("A vendedora Maria terá " + vendedorMaria.CalcularFerias() + " dias de férias");
            Console.WriteLine("O vendedor Joseph terá " + vendedorJoseph.CalcularFerias() + " dias de férias");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------Total de Contas-----------------------------");

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
        }
    }
}