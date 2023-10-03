List<string> frutas = new() {"pera","melon","sandia","durazno","manzana","platano","kiwi","naranja","jicama","piña","papaya","limas","moras","lichis","guamuchiles","chilitos","pitayas","maracuya","xoconostle"};

Console.Clear();

var mfrutas = (from f in frutas where f.StartsWith('m') select f).ToList();
Console.WriteLine("\nFrutas que inician con la letra m " + mfrutas.Count());
mfrutas.ForEach(f => Console.Write(f + " "));

var anfrutas = (from f in frutas where f.Contains("an") select f).ToList();
Console.WriteLine("\nFrutas que contienen an " + anfrutas.Count());
anfrutas.ForEach(f => Console.Write(f + " "));

var afrutas = (from f in frutas where f.EndsWith("a") select f).ToList();
Console.WriteLine("\nFrutas que terminan con la leta a " + afrutas.Count());
afrutas.ForEach(f => Console.Write(f + " "));

var xzfrutas = (from f in frutas where (f.Contains("x") || f.Contains("z")) select f).ToList();
Console.WriteLine("\nFrutas que contiene una letra x o z " + xzfrutas.Count());
xzfrutas.ForEach(f => Console.Write(f + " "));

