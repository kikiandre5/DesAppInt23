// Control Bancario
// Probar clase Cuenta Bancaria

Console.Clear();

CuentaBancaria cuenta = new CuentaBancaria(100);
cuenta.Depositar(200);
Console.WriteLine($"Saldo: {cuenta.Saldo}");
if(cuenta.Retirar(1500)) Console.WriteLine("Retiro Exitoso");
else Console.WriteLine("Saldo insuficiente");

//Probar Cliente

Cliente cliente01 = new Cliente("Juan Carlos","Jcarlos@gmail.com",cuenta);
cliente01.Cuenta.Depositar(1500);
Console.WriteLine($"\nDatos del cliente : {cliente01.ToString()}");
Console.WriteLine($"\nSaldo cuenta: {cliente01.Cuenta.Saldo}");

Cliente cliente02 = new Cliente("Paola Diaz","paola@msn.com",new CuentaBancaria(450));
//cliente02.Cuenta = new CuentaBancaria(450);

Console.WriteLine($"\nDatos del cliente : {cliente02.ToString()}");
Console.WriteLine($"\nSaldo cuenta: {cliente02.Cuenta.Saldo}");

//Probar la clase banco

Banco mibanco = new Banco("Banco del Bienestar","Fresnillo");
mibanco.AgregarCliente(cliente01);
mibanco.AgregarCliente(cliente02);
mibanco.AgregarCliente(new Cliente("Fernanda","Fer@hotmail.com",new CuentaBancaria(200)));
mibanco.Clientes[2].Cuenta.Depositar(2000);
Console.WriteLine(mibanco.ToString());
Console.WriteLine($"\nEl banco tiene {mibanco.Clientes.Count} clientes");
foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"\nCliente {cl.ToString()}");
    Console.WriteLine($"Saldo: {cl.Cuenta.Saldo}");
}

