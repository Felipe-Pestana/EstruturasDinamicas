int contador = 0;
var filaComum = new Fila();
var filaPref = new Fila();

int Menu()
{
	Console.WriteLine("Informe a Opção desejada: ");
	Console.WriteLine("1 - Pegar Senha Comum");
	Console.WriteLine("2 - Pegar Senha Preferencial");
	Console.WriteLine("3 - Chamar Senha");
	Console.WriteLine("0 - Sair");
	int x = int.Parse(Console.ReadLine());
	return x;
}

void ChamarSenha()
{
	if (contador < 2 && filaPref.Head is not null)
	{
		Console.WriteLine(filaPref.Head);
		filaPref.RemoverElemento();
		contador++;
	}
	else if (filaComum.Head is not null)
	{
		Console.WriteLine(filaComum.Head);
		filaComum.RemoverElemento();
		contador = 0;
	}
	else
	{
        Console.WriteLine("As filas estão vazias, idiota!");
	}
}

void GerarSenha(Fila f)
{
	if (f.Equals(filaComum)) {
		f.InserirElemento(new SenhaComum());
	}
	else { 
		f.InserirElemento(new SenhaPreferencial());
	}
}

while (true)
{
	switch (Menu())
	{
		case 1:
			GerarSenha(filaComum);
			break;
		case 2:
			GerarSenha(filaPref);
			break;
		case 3:
			ChamarSenha();
			break;
		case 0:
			Environment.Exit(0);
			break;
		default:
            Console.WriteLine("Fez merda!");
			break;
	}
}