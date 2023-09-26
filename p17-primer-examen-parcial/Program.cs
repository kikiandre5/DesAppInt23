Console.Clear();

Academia miacademia = new Academia("Club Chivas","Andres Fernandez","Fresnillo,Zacatecas");

//Console.WriteLine(miacademia.ToString());

//Agregar Categorias a la Academia
miacademia.AgregarCategoria(new Categoria ("Junior A","2006/2007/2008",1250.00));
miacademia.AgregarCategoria(new Categoria ("Junior B","2009/2010/2011",850.00));
miacademia.AgregarCategoria(new Categoria("Pony A","2012/2013/2014",700.00));

//Agregar Jugadores a la Categoria
miacademia.Categorias[0].AgregarJugador(new Jugador("Alexander Lopez",2006,'H',false));
miacademia.Categorias[0].AgregarJugador(new Jugador ("Uriel Puga",2007,'H',true));
miacademia.Categorias[0].AgregarJugador(new Jugador ("Alejandra Escalona",2008,'M',false));

miacademia.Categorias[1].AgregarJugador(new Jugador ("Armando Santana",2009,'H',false));
miacademia.Categorias[1].AgregarJugador(new Jugador("Daniel Mijares",2010,'H',false));
miacademia.Categorias[1].AgregarJugador(new Jugador("Antonio Hernandez",2011,'M',true));

miacademia.Categorias[2].AgregarJugador(new Jugador("Andrea Solis",2012,'M',true));
miacademia.Categorias[2].AgregarJugador(new Jugador("Marissa Hernandez",2013,'M',true));
miacademia.Categorias[2].AgregarJugador(new Jugador("Diana Soto",2014,'M',false));

foreach (Categoria categoria in miacademia.Categorias)
{
    categoria.TotalGen();
}

miacademia.Categorias[0].SubTotal(1);
miacademia.Categorias[1].SubTotal(2);
miacademia.Categorias[2].SubTotal(3);

Console.WriteLine("REPORTE DEL CLUB DEPORTIVO\n");
Console.WriteLine(miacademia.ToString());

Console.WriteLine($"Total de categorias: {miacademia.Categorias.Count()}");

Console.WriteLine($"Total de Hombres: {miacademia.Categorias[0].Th + miacademia.Categorias[1].Th + miacademia.Categorias[2].Th}");
Console.WriteLine($"Total de Mujeres: {miacademia.Categorias[0].Tm + miacademia.Categorias[1].Tm + miacademia.Categorias[2].Tm}");

Console.WriteLine("\n>> Datos generales de las Categorias");

foreach(Categoria categoria in miacademia.Categorias){
    Console.WriteLine(categoria.ToString());
}

Console.WriteLine($"\n\n> Junior A - 2006/2007/2008 - ({miacademia.Categorias[0].Jugadores.Count()}) \n");
Console.WriteLine(miacademia.Categorias[0].Jugadores[0].ToString());
Console.WriteLine(miacademia.Categorias[0].Jugadores[1].ToString());
Console.WriteLine(miacademia.Categorias[0].Jugadores[2].ToString());

Console.WriteLine($"\nSubtotal: {miacademia.Categorias[0].sbt:c2}");

Console.WriteLine($"\n\n> Junior B - 2009/2010/2011 - ({miacademia.Categorias[1].Jugadores.Count()}) \n");
Console.WriteLine(miacademia.Categorias[1].Jugadores[0].ToString());
Console.WriteLine(miacademia.Categorias[1].Jugadores[1].ToString());
Console.WriteLine(miacademia.Categorias[1].Jugadores[2].ToString());

Console.WriteLine($"\nSubtotal: {miacademia.Categorias[1].sbt:c2}");

Console.WriteLine($"\n\n> Junior C - 2012/2013/2014 - ({miacademia.Categorias[0].Jugadores.Count()}) \n");
Console.WriteLine(miacademia.Categorias[2].Jugadores[0].ToString());
Console.WriteLine(miacademia.Categorias[2].Jugadores[1].ToString());
Console.WriteLine(miacademia.Categorias[2].Jugadores[2].ToString());

Console.WriteLine($"\nSubtotal: {miacademia.Categorias[2].sbt:c2}");

Console.WriteLine($"\nTotal: {miacademia.Categorias[0].sbt + miacademia.Categorias[1].sbt + miacademia.Categorias[2].sbt:c2}");