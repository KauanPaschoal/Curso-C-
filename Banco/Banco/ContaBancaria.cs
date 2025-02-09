public class ContaBancaria
{

    public string NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    public Cliente Cliente { get; set; }


    public void Depositar(decimal valor)
    {
        if (valor > 0){
            Console.WriteLine("Realizando deposito");
            Saldo += valor;
        }
        else
        {
            Console.WriteLine("Deposito não pode ser efetuado!");
        }    
    }

    public void Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Console.WriteLine("Realizando saque!");
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saque impossibilitado por falta de saldo");
        }
    }

    public void Transferir(decimal valor, ContaBancaria contaDestino)
    {
        if (Saldo < valor)
        {
            Console.WriteLine("Você não tem dinheiro suficiente para fazer esta transferencia ");
        }
        else
        {
            Console.WriteLine($"Fazendo transferencia para {contaDestino.Cliente.Nome}");
            Saldo -= valor;
            contaDestino.Depositar(valor);
        }
            
    }


}