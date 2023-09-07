// Codigo de clase

public class Empleado{
    public string Nombre{get;set;}
    public int Edad {get;set;}
    public char Sexo {get;set;}
    public bool Casado{get;set;}

    public Empleado(){}
    public Empleado(string nombre) => Nombre = nombre;
    public Empleado(string nombre, int edad, char sexo,bool casado) => (Nombre,Edad,Sexo,Casado) = (nombre,edad,sexo,casado);
    public void ImprimirDatos(){
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Sexo: {(Sexo == 'M'?"Mujer":"Hombre")}");
        Console.WriteLine($"Casado: {(Casado?"Casado":"Soltero")}");
        Console.WriteLine();
    }

}