// Control Empleados

//Instanciar y reservar espacion en memoria para un objeto de una clase determinada

Empleado empleado01 = new Empleado();

Console.Clear();

empleado01.Nombre = "Juan Carlos";
empleado01.Edad = 22;
empleado01.Sexo = 'H';
empleado01.Casado = false;
empleado01.ImprimirDatos();

// Instanciar, luego reservar espacion en memoria para un objeto de una clase determinada

Empleado empleado02;
empleado02 = new Empleado();
empleado02.Nombre = "Andres Fernandez";
empleado02.Edad = 24;
empleado02.Sexo = 'H';
empleado02.Casado = true;
empleado02.ImprimirDatos();

Empleado empleado03 = new Empleado("Pedro y Pablo",33,'M',false);
empleado03.ImprimirDatos();

Empleado empleado04 = new Empleado{Nombre="Amlo",Edad=65,Sexo='H',Casado=true};
empleado04.ImprimirDatos();