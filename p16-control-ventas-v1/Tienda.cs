public class Tienda {
    public string Nombre {get;set;}
    public string Propietario {get;set;}
    public string Domicilio {get;set;}
    public double TotalFinal = 0;
    public List<Cliente> Ncliente {get;set;}

    public Tienda() => Ncliente = new List<Cliente>();

    public Tienda(string nombre,string propietario,string domicilio) : this() => (Nombre,Propietario,Domicilio) = (nombre,propietario,domicilio);

    public void AgregarCliente(Cliente cliente) => Ncliente.Add(cliente);
    
    public double TotalD(double x){
        TotalFinal += x;
        return TotalFinal;
    }
    public override string ToString() => $"\nNombre: {Nombre}\nPropietario: {Propietario}\nDomicilio: {Domicilio}\nVenta Total del Dia: {TotalFinal}\n";
}