public class ContaCorrente {

    public string titular;
    public int agencia;
    public int conta;
    public double saldo {get; private set;}

    public ContaCorrente(){} //Boas praticas que devem sempre ser seguidas

    public ContaCorrente(string contacorrente_titular, int contacorrente_agencia, int contacorrente_conta, double contacorrente_saldo)
    {
        /*this.titular = titular;*/ //No lugar de this, podemos apenas mudar o nome da variável para uma não existente
        titular = contacorrente_titular;
        agencia = contacorrente_agencia;
        conta = contacorrente_conta;
        saldo = contacorrente_saldo;
    }

    public bool Sacar (double valor){ //o método precisa de um retorno
        if (this.saldo < valor){
            return false;
        }
        else {
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar (double valor){ //o método não precisa de um retorno
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino){
        if(this.saldo < valor){
            return false;
        }
        else{
            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
