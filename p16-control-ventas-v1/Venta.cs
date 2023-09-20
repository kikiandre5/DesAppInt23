public class Venta {
    public string Articulo {get;set;}
    public int Cantidad {get;set;}
    public double Precio {get;set;}

    public double subtotal = 0;

    public Venta(string articulo,int cantidad,double precio) => (Articulo,Cantidad,Precio) = (articulo,cantidad,precio);


    public double subT(int x,double y){//X para cantidad Y para Precio
        subtotal = x*y;
        return subtotal;
    }

}

