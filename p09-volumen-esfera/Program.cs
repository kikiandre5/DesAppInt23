// Calcular el voumen de una esfera usando radio de un circulo

double PI = 3.14159;
double radio = 0;
double volumen = 0;

Console.Clear();
Console.Write("Ingresa el radio de el circulo: "); radio = double.Parse(Console.ReadLine());

volumen = (4/3)*(Math.Pow(radio,3))*(PI);

Console.WriteLine($"El volumen es: {volumen:f2}cm");