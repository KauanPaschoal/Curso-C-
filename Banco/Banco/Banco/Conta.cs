class contaBancaria 
{ 
    public string titular;
    public int numeroIndicador;
    public int agencia;
    public double saldo;
    public int senha;



    public void exibirInformações() { 
        Console.WriteLine("Titular: " + titular);
        Console.WriteLine("Número da conta: " + numeroIndicador);
        Console.WriteLine("Agência: " + agencia);
        Console.WriteLine("Saldo: " + saldo);
        Console.WriteLine("Senha: " + senha);
    }
}