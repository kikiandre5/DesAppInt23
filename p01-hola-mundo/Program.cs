// Programa que manda saludos a la pantalla

string amigo = "Adrian";
string hermano = "Paco";

Console.WriteLine("Hola " + amigo);
Console.WriteLine($"Hola {hermano} bienvenido a c#");
Console.WriteLine($"\nMi amigo es {amigo} mi hermano es {hermano}");
Console.WriteLine("Nombres en mayusculas");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");