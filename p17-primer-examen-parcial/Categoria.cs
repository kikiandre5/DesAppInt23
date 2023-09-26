public class Categoria{
    public string Nombre {get;set;}
    public string Rango {get;set;}
    public double Costo {get;set;}
    public List<Jugador> Jugadores {get;set;}
    public Categoria() => Jugadores = new List<Jugador>();
    public double sbt = 0;
    public int Th = 0;
    public int Tm = 0;

    public Categoria (string nombre,string rango, double costo) :this() => (Nombre,Rango,Costo) = (nombre,rango,costo);

    public void AgregarJugador(Jugador jugador) => Jugadores.Add(jugador);

    public override string ToString() => $"Nombre: {Nombre,-15} Rango: {Rango,-20} Costo {Costo:c2}";

    public void TotalGen(){
        foreach (Jugador jugador in Jugadores)
        {
            if(jugador.Sexo == 'H'){
                Th += 1;
            }
            else Tm += 1;
        }
    }

    public void SubTotal(int i)
    {
        foreach (Jugador jugador in Jugadores)
        {
            if(jugador.Becado == false){
                sbt += 1;
            }
            
        }
        if(i == 1) sbt = sbt*1250;
        if(i == 2) sbt = sbt*850;
        if(i == 3) sbt = sbt*700;
    }
}