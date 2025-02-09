public class Cliente
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }


    public void AtualizarEndereco(string novoEndereco)
    {
        Endereco = novoEndereco;
    }

    public void AtualizarTelefone(string novoTelefone)
    {
        Telefone = novoTelefone;
    }


        }