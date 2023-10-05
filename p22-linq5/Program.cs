Console.Clear();

List<Estudiante> estudiantes = new List<Estudiante>();

estudiantes.Add(new Estudiante("1234","Juan Perez","Principal 123","Zacatecas",'H',21,true,new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("2345","Maria Lopez","Principal 126","Fresnillo",'M',22,false,new List<float>{75,84,91,40}));
estudiantes.Add(new Estudiante("1234","Rodrigo Mata","Av Mexico 114","Rio Grande",'H',21,true,new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("2356","Miguel Mejia","La Loma 666","Fresnillo",'H',31,true,new List<float>{66,44,22,55}));
estudiantes.Add(new Estudiante("8888","David Monreal","5 de Mayo 23","Rio Grande",'H',41,false,new List<float>{98,100,85,70}));
estudiantes.Add(new Estudiante("1345","Brenda Buen Rostro","Av Rayon 45","Zacatecas",'M',22,true,new List<float>{100,65,82,65}));
estudiantes.Add(new Estudiante("2265","Liliana Morones","Sierra Madre 23","Rio Grande",'M',34,false,new List<float>{95,90,77,85}));
estudiantes.Add(new Estudiante("999","Berenice Diaz","Av Rayon","Zacatecas",'M',25,false,new List<float>{80,20,30,100}));
estudiantes.Add(new Estudiante("999","Rocio Bernal","Sirre Mezquite 143","Fresnillo",'M',25,true,new List<float>{77,66,33,22}));

Console.WriteLine("\nTodos los estudiantes en el grupo: ");
estudiantes.ForEach(e => Console.WriteLine(e));

string mun = "Fresnillo";
//var estmun = (from e in estudiantes where e.Municipio==mun select e).ToList();
var estmun = estudiantes.Where(e => e.Municipio==mun).ToList();
Console.WriteLine($"\nEstudiantes que son de {mun} - {estmun.Count()}");
estmun.ForEach(e=>Console.WriteLine(e));

float prom=65f;
//var estprom = (from e in estudiantes where e.Califs.Average() >= prom orderby e.Nombre select e).ToList();
var estprom = estudiantes.Where(e => e.Califs.Average() = prom);
Console.WriteLine("\nEstudiantes con promedio >= {prom} - {estprom.Count()}");
estprom.ForEach(e=>Console.WriteLine(e));

//var estprom1 = (from e in estudiantes select $"Nombre={e.Nombre,-18} - Prom = {e.Califs.Average(),5:n2} Becado = {e.Becado}").ToList();
var estprom1 = estudiantes.Select(e => new{Nombre=e.Nombre,Promedio = e.Califs.Average()}).ToList();
Console.WriteLine("\nLista de alimnos y promedio: ");
estprom1.ForEach(e=>Console.WriteLine(e));

Console.WriteLine("\n\nSubtotales: ");
//var pedades = (from e in estudiantes select e.Edad).Average();
var pedades = estudiantes.Average(e => e.Edad);
Console.WriteLine($"Promedio de edades = {pedades:n2}");

//var pcalifs = (from e in estudiantes select e.Califs.Average()).Average();
var pcalifs = estudiantes.Average(e => e.Califs.Average());
Console.WriteLine($"Promdedio de promedios = {pcalifs:n2}");

//var totm = (from e in estudiantes where e.Sexo == 'M' select e).Count();
var totm = estudiantes.Count(e => e.Sexo=='H');
Console.WriteLine($"Total de mujeres = {totm}");

//var toth = (from e in estudiantes where e.Sexo == 'H' select e).Count();
var toth = estudiantes.Count(e => e.Sexo=='H');
Console.WriteLine($"Total de mujeres = {toth}");

//var totb = (from e in estudiantes where e.Becado select e).Count();
var totb = estudiantes.Count(e => e.Becado);
Console.WriteLine($"Total de becados = {totb}");

//var totnb = (from e in estudiantes where !e.Becado select e).Count();
var totnb = estudiantes.Count(e => !e.Becado);
Console.WriteLine($"Total de no becados = {totnb}");

//var totmb = (from e in estudiantes where e.Becado && e.Sexo == 'M' select e).Count();
var totmb = estudiantes.Count(e => e.Becado && e.Sexo=='M');
Console.WriteLine($"Total de mujeres becadas = {totmb}");

//var gpoest = from e in estudiantes group e by e.Municipio;
var gpoest = estudiantes.GroupBy(e => e.Municipio);
Console.WriteLine("\nEstudiantes agrupados por municipio: ");
foreach(var gpo in gpoest){
    Console.WriteLine($"\n {gpo.Key} : {gpo.Count()}");
    foreach(var est in gpo){
        Console.WriteLine(est);
    }
}