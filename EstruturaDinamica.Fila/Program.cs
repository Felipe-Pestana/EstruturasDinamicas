var fila = new Fila();

var p1 = new Pessoa("Felipe");
var p2 = new Pessoa("Eric");
var p3 = new Pessoa("Higor");
var p4 = new Pessoa("Gabriel");

fila.InserirElemento(p1);
//fila.MostrarFila();

fila.InserirElemento(p3);
//fila.MostrarFila();

fila.InserirElemento(p4);
//fila.MostrarFila();

fila.InserirElemento(p2);
fila.MostrarFila();

Console.ReadKey();

fila.RemoverElemento();
fila.MostrarFila();

fila.RemoverElemento();
fila.MostrarFila();

fila.RemoverElemento();
fila.MostrarFila();

fila.RemoverElemento();
fila.MostrarFila();