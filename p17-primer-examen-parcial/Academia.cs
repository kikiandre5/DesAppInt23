public class Academia{
    public string Nombre {get;set;}
    public string Propietario {get;set;}
    public string Domicilio {get;set;}
    public List<Categoria> Categorias {get;set;}

    public Academia() => Categorias = new List<Categoria>();
    public Academia(string nombre,string propietario,string domicilio) : this() => (Nombre,Propietario,Domicilio) = (nombre,propietario,domicilio);

    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public override string ToString() => $"Nombre de la Academia: {Nombre,16}\nPropietario de la Academia: {Propietario}\nDomicilio de la Academia: {Domicilio,21}\n";

}