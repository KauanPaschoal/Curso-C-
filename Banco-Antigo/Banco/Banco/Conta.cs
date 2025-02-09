internal class contaBancaria
{

    public int NumeroIndicador;
    public int Agencia;
    public double Saldo;
    public int Senha;

    Titular titular = new Titular();

    public void exibirInformações()
    {
        Console.WriteLine("Titular: " + titular.Nome);
        Console.WriteLine("Número da conta: " + NumeroIndicador);
        Console.WriteLine("Agência: " + Agencia);
        Console.WriteLine("Saldo: " + Saldo);
        Console.WriteLine("Senha: " + Senha);
    }
}