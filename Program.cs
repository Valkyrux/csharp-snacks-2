List<int> listInt = new List<int>() {1, 2, 3, 4, 5, 6, 7};

var mettiAlQuadrato1 = () => { int tot = 0;  return ((int i) => { tot += i; return tot; }); };
var ciao = mettiAlQuadrato1();

Console.WriteLine("Accumulatore con metodo CLOSURE");
Console.WriteLine(ciao(10));
Console.WriteLine(ciao(20));
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
Console.WriteLine("____________________________");
Console.WriteLine("NUMERI:");
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
Console.WriteLine("\n____________________________\n");
Console.WriteLine("LISTA GENERATA DA FUNZIONE CON METODO CLOSURE:");
foreach (int i in listaDiSomme)
{
    Console.WriteLine(i);
}

//trovare da una lista di stringhe di partenza una lista di lunghezze rispettive ad ogni stringa
List<string> listaDiStringhe = new List<string>() { "ciao", "come", "stai", "pieralberto angeli"};

List<int> EseguiCalcolo1(List<string> listaStringhe, Func<string, int> fun)
{
    List<int> result = new List<int>();
    foreach (string str in listaStringhe)
    {
        result.Add(fun(str));
    }
    return result;
}


List<int> listaLunghezze = EseguiCalcolo1(listaDiStringhe, (str) => str.Length);
for (int i = 0; i < listaLunghezze.Count; i++)
{
    Console.WriteLine("{0} : {1}", listaDiStringhe[i], listaLunghezze[i]);
}

Dictionary<string, int> dizionario = new Dictionary<string, int>() { { "uno", 1 }, { "due", 2 }, { "tre", 3 }, { "quattro", 4 }, { "cinque", 5 }, { "sei", 6 } };
Dictionary<int, string> dizionario1 = new Dictionary<int, string>() { { 1, "uno" }, { 2, "due" }, { 3, "tre" }, { 4, "quattro" }, { 5, "cinque" }, { 6, "sei" } };

string NumberSumString(string str1, string str2)
{
    int num1 = dizionario[str1];
    int num2 = dizionario[str2];
    return dizionario1[num1 + num2];
}

List<string> listString = new List<string>() { "tre", "due", "uno", "Cinque", "cinque", "Tre" };
Console.WriteLine("\n___LISTA STRINGHE INIZIALE___");
foreach (string str in listString)
{
    Console.WriteLine(str);
}


listString.Sort(
    (string s1, string s2) =>
    {
        if(dizionario[s1.ToLower()] > dizionario[s2.ToLower()])
        {
            return 1;
        } 
        else if(dizionario[s1.ToLower()] < dizionario[s2.ToLower()])
        {
            return -1;
        }
        else
        {
            return 0;
        }
    });

Console.WriteLine("\n___ORDINAMENTO DEI NUMERI SECONDO IL SIGNIFICATO DELLA PAROLA___");
foreach (string str in listString)
{
    Console.WriteLine(str);
}

listString.Sort();
Console.WriteLine("\n___ORDINAMENTO LESSICALE___");
foreach (string str in listString)
{
    Console.WriteLine(str);
}

listString.Sort((string s1, string s2) => -s1.CompareTo(s2));
Console.WriteLine("\n___ORDINAMENTO LESSICALE DECRESCENTE___");
foreach (string str in listString)
{
    Console.WriteLine(str);
}

List<Tuple<DateTime, int>> ListaFinale = new List<Tuple<DateTime, int>>();
for (int i = 0; i<10; i++)
{
    DateTime start = new DateTime(1970, 1, 1);
    int range = (DateTime.Today - start).Days;
    DateTime randomDate = start.AddDays(new Random().Next(range));
    ListaFinale.Add(new Tuple<DateTime, int>(randomDate, i));
}

Console.WriteLine("\n___TUPLE GENERATE___");
foreach (var tuple in ListaFinale)
{
    Console.WriteLine("{0} - {1}/{2}/{3}", tuple.Item2, tuple.Item1.Day, tuple.Item1.Month, tuple.Item1.Year);
}

ListaFinale.Sort((t1, t2) =>
{
    if (t1.Item1 > t2.Item1)
    {
        return 1;
    }
    else if (t1.Item1 < t2.Item1)
    {
        return -1;
    }
    else
    {
        return 0;
    }
});

Console.WriteLine("\n___TUPLE ORDINATE PER DATA___");
foreach (var tuple in ListaFinale)
{
    Console.WriteLine("{0} - {1}/{2}/{3}", tuple.Item2, tuple.Item1.Day, tuple.Item1.Month, tuple.Item1.Year);
}

Console.WriteLine("\n___SOMMA DI NUMERI A PAROLE___");
Console.WriteLine("{0} piu' {1} fa {2}", "due", "uno", NumberSumString("due","uno"));