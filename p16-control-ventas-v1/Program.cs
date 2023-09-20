Console.Clear();

Tienda tienda = new Tienda("Aurrera","Adrian Robles","Guadalupe");
Console.Write(tienda.ToString());

Cliente cliente01 = new Cliente("Erick shay","eric123","Guadalupe","Erick@gmail.com",0);
tienda.AgregarCliente(cliente01);
Venta venta01 = new Venta("Peras",8,10);
cliente01.sumaT(venta01.subT(venta01.Cantidad,venta01.Precio));
tienda.TotalD(venta01.subtotal);
Console.WriteLine(cliente01.ToString());


Cliente cliente02 = new Cliente("Johan","Asder87","Zacatecas","Asder@hotmail.com",0);
tienda.AgregarCliente(cliente02);
Venta venta02 = new Venta("Manzanas",9,1.87);
cliente02.sumaT(venta02.subT(venta02.Cantidad,venta02.Precio));
tienda.TotalD(venta02.subtotal);
Console.WriteLine(cliente02.ToString());

Venta venta03 = new Venta("Iphone 15pro plus x edition lamborgini",1,40000);
cliente01.sumaT(venta03.subT(venta03.Cantidad,venta03.Precio));
tienda.TotalD(venta03.subtotal);
Console.WriteLine(cliente01.ToString());

Console.Write(tienda.ToString());