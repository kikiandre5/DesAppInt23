// Imprime una tabla de conversion de peso a otras monedas

int ini,fin,c;
float tcd = 17.70f,tcl = 21.21f,tce = 18.19f,tca = 0.48f;

Console.Clear();
Console.WriteLine("Imprime tabla de conversion de monedas \n");

do{
    Console.Write("Inicio   : ");ini = int.Parse(Console.ReadLine());
    Console.Write("Final    : ");fin = int.Parse(Console.ReadLine());
}while (fin < ini);

c = ini;
Console.WriteLine("Peso\tDolar\tLibra\tEuro\tPesoA");
Console.WriteLine(new string('-',38));
while (c<=fin){
    Console.WriteLine($"{c:f2}\t{c/tcd:f2}\t{c/tcl:f2}\t{c/tce:f2}\t{c/tca:c2}");
    c++;
}