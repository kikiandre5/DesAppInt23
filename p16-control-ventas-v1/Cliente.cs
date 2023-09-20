public class Cliente{

    public string Nombre {get;set;}
    public string RFC {get;set;}
    public string Domicilio{get;set;}
    public string Correo{get;set;}
    public double TotalC {get;set;}


    public Cliente(string nombre, string rfc, string domicilio, string correo,double totalC) => (Nombre,RFC,Domicilio,Correo,TotalC) = (nombre,rfc,domicilio,correo,totalC);

    public override string ToString() => $"\nNombre: {Nombre}\nRFC: {RFC}\nDomicilio: {Domicilio}\nCorreo: {Correo}\nTotal Acumulado: {TotalC:f2}";
    
    public double sumaT(double x) => TotalC += x;

}