// Calcular la distancia entre dos puntos, dadas las coodenadas del punto A y el punto B

double Ax = 0, Ay = 0, Bx = 0, By = 0, distancia = 0;

Console.Clear();

Console.Write("Ingresa la coordenada X del punto A: "); Ax = double.Parse(Console.ReadLine());
Console.Write("Ingresa la coordenada Y del punto A: "); Ay = double.Parse(Console.ReadLine());
Console.Write("Ingresa la coordenada X del punto B: "); Bx = double.Parse(Console.ReadLine());
Console.Write("Ingresa la coordenada Y del punto B: "); By = double.Parse(Console.ReadLine());

distancia = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2));

Console.WriteLine($"La distancia entre los puentos es: {distancia:f2}");