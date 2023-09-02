// Emitir una calificación con letra y un mensaje de acuerdo al promedio, según la tabla

double calificacion = 0;

Console.Clear();

Console.Write("Escribe tu nombre: "); string nombre = Console.ReadLine();

do {
    Console.Write ("Escribe una calificacion entre 0 y 10 "); calificacion = Convert.ToDouble(Console.ReadLine());
} while (calificacion < 0 || calificacion > 10);
Console.Clear();
if (calificacion <= 5.9) {
    tabla(nombre);
    Console.WriteLine($"{calificacion}\t\tD\tAndas mal");
} else {
    if (calificacion >= 6 && calificacion <= 7.5){
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tC\tMucho mejor");
    }else {
       if (calificacion >= 7.6 && calificacion <= 8.5){
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tB\tMuy bien");
        }
        else{
            tabla(nombre);
            Console.WriteLine($"{calificacion}\t\tA\tExcelente"); 
        }
    }
}
static void tabla(string nombre) {
        Console.WriteLine($"Hola {nombre}");
        Console.WriteLine("Promedio\tLetra\tMensaje");
}