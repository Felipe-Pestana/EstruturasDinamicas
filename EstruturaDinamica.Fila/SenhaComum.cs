public class SenhaComum : Senha
{
    public SenhaComum()
    {
        Id = "C" + Random.Shared.Next(1, 1000);
        Proximo = null;
    }

    public override string ToString()
    {
        return Id;
    }
}
