public class CuentaBancaria{
    public double Saldo { get; set; }  
    public CuentaBancaria(double cantidad) => Saldo = cantidad;

    public void Depositar(double cantidad ) => Saldo += cantidad;

    public bool Retirar(double cantidad){
        if(Saldo >= cantidad){
            Saldo -= cantidad;
            return true;
        }
        else{
            return false;
        }
    }


}