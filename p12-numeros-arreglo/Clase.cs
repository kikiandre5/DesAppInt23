public static class Funciones {
    
    public static void numero (int[] Arreglo){
        for (int i = 0; i < Arreglo.Length; i++) {
        Console.WriteLine($"numero {i + 1}: {Arreglo[i]}");
    }
}
    public static double sum (int[] Arreglo){
        int suma = 0;
        for (int i = 0; i < Arreglo.Length; i++) {
        suma = suma + Arreglo[i];
    }
    return suma;
    }
    public static double sumDiv(int[] Arreglo){
        double rest = 0,sumaDivision = 0;
        for (int i = 0; i < Arreglo.Length; i++) {
        rest = Arreglo[i] / 2;
        sumaDivision = sumaDivision + rest;
}
    return sumaDivision;
    }

    public static void inverso(int[] Arreglo){
        for (int i = Arreglo.Length - 1; i >= 0; i--) {
            Console.WriteLine($"numero {i}: {Arreglo[i]}");
        }
    }
}
