// el usuario podra seleccionar cuantos articulos va a vender y cual sera el precio con iva

int respuesta = 1;

Console.Clear();

do {
double ivat = 0;

Console.Write("digita la cantidad de articulos a vender: "); int tam = int.Parse(Console.ReadLine());

double[] NArticulos = new double[tam];
Console.Clear();

for (int i = 0; i < tam; i++) {
    int subtotal = 0;
    Console.WriteLine($"Articulo numero {i + 1}");
    Console.Write("Cuantos articulos de estos vas a vender?: "); int articulo = int.Parse(Console.ReadLine());
    Console.Write("Cuanto cuesta cada articulo?: "); int precioart = float.Parse(Console.ReadLine());
    subtotal = articulo * precioart;
    NArticulos[i] = subtotal;
    Console.Clear();
}

for (int i = 0; i < tam; i++)
{
    double iva = 0;
    if(NArticulos[i] < 1200)
    {
        iva = NArticulos[i] * 0.16;
        NArticulos[i] = NArticulos[i] + iva;
    }
    Console.WriteLine($"Articulo {i + 1}: ${NArticulos[i]} pesos");
    ivat = ivat + iva;
}
Console.WriteLine($"El total de iva fue: ${ivat:f2} pesos");

Console.Write("Ingresa 1 para continuar o cualquier otro número para salir: ");
respuesta = Convert.ToInt32(Console.ReadLine());
} while (respuesta == 1);