// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> listInt = new List<int>() {1, 2, 3, 4, 5, 6, 7};

var mettiAlQuadrato1 = () => { int tot = 0;  return ((int i) => { tot += i; return tot; }); };
var ciao = mettiAlQuadrato1();
Console.WriteLine(ciao(10));
Console.WriteLine(ciao(20));

List<int> listAlQuadrato = mettiAlQuadrato(listInt);
List<int> listAlCubo = mettiAlCubo(listInt);

List<int> mettiAlQuadrato(List<int> listInt)
{
    List<int> listAlQuadrato = new List<int>();
    foreach (int i in listInt)
    {
        listAlQuadrato.Add( i * i );
    }
    return listAlQuadrato;
}


List<int> mettiAlCubo(List<int> listInt)
{
    List<int> listAlQuadrato = new List<int>();
    foreach (int i in listInt)
    {
        listAlQuadrato.Add(i * i * i);
    }
    return listAlQuadrato;
}

Console.WriteLine("\nNUMERI:");
foreach (int i in listInt)
{
    Console.Write("{0}, ", i);
}

Console.WriteLine("\nNUMERI AL QUADRATO:");
foreach (int i in listAlQuadrato)
{
    Console.Write("{0}, ", i);
}

Console.WriteLine("\nNUMERI AL CUBO:");
foreach (int i in listAlCubo)
{
    Console.Write("{0}, ", i);
}


List<int> EseguiCalcolo(List<int> li, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    
    foreach(int element in li)
    {
        lout.Add(fun(element));
    }

    return lout;
}

List<int> listaAlQuadrato1 = EseguiCalcolo(listInt, (n) => n * n * n);
List<int> listaDiSomme = EseguiCalcolo(listInt, (n) => n * (n + 1) / 2);

foreach (int i in listaDiSomme)
{
    Console.WriteLine(i);
}