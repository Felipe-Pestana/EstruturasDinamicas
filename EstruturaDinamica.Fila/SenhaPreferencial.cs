public class SenhaPreferencial : Senha
{
    public SenhaPreferencial()
    {
        Id = "P" + Random.Shared.Next(1, 1000);
        Proximo = null;
    }
    public override string ToString()
    {
        return Id;
    }
}