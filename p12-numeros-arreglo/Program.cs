//crea un programa para calcular datos de un arreglo

int[] Arreglo = {100, 123, 456, 222, 999, 895, 325, 234, 322, 988};
Console.Clear();

Funciones.numero(Arreglo);
Console.WriteLine($"La suma es: {Funciones.sum(Arreglo)}");;
Console.WriteLine($"La suma con division es: {Funciones.sumDiv(Arreglo)}");
Funciones.inverso(Arreglo);

