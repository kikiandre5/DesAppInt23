public class InicializadorBD
{
    public static void Inicializar(ContextoDatos contexto)
    {
        if (contexto.Clientes.Any() || contexto.Habitaciones.Any() || contexto.Reservas.Any())
        {
            return; // La base de datos ya ha sido inicializada
        }

        // Inicializar datos de clientes
        var clientes = new List<Cliente>
        {
            new Cliente { Nombre = "Rosario", Apellido = "Correa", Genero = 'F', FechaCumple = DateTime.Parse("1971-12-01"), Correo = "chayo@msn.com", Telefono = "4923456786" },
            new Cliente { Nombre = "Carlos", Apellido = "Gonzalez", Genero = 'M', FechaCumple = DateTime.Parse("1975-05-05"), Correo = "charly@gmail.com", Telefono = "4941245677" },
            new Cliente { Nombre = "Miroslava", Apellido = "Aguirre", Genero = 'F', FechaCumple = DateTime.Parse("1981-04-03"), Correo = "mirosag@yahoo.com.mx", Telefono = "4441234567" },
            new Cliente { Nombre = "Fatima", Apellido = "Delgado", Genero = 'F', FechaCumple = DateTime.Parse("2000-04-04"), Correo = "fedlgado@bimbo.com.mx", Telefono = "4921063456" },
            new Cliente { Nombre = "Leonardo", Apellido = "Ovalle", Genero = 'M', FechaCumple = DateTime.Parse("1999-08-08"), Correo = "ovalleleo@gmc.com.mx", Telefono = "4342345890" },
            new Cliente { Nombre = "Hector", Apellido = "Ramirez", Genero = 'M', FechaCumple = DateTime.Parse("1959-10-11"), Correo = "hramirez@gmail.com", Telefono = "4921245677" },
            new Cliente { Nombre = "Carlos", Apellido = "Ramirez", Genero = 'M', FechaCumple = DateTime.Parse("1971-12-02"), Correo = "castr@uaz.edu.mx", Telefono = "4928920917" }
        };
        contexto.Clientes.AddRange(clientes);
        contexto.SaveChanges();

        // Inicializar datos de habitaciones
        var habitaciones = new List<Habitacion>
        {
            new Habitacion {Id = 1, NoHab = 12, Tipo = "Individual", Piso = 1, Costo = 1234.00 },
            new Habitacion { Id = 2, NoHab = 5, Tipo = "Doble", Piso = 2, Costo = 2500.00 },
            new Habitacion { Id = 3, NoHab = 7, Tipo = "Triple", Piso = 2, Costo = 2800.00 },
            new Habitacion { Id = 4, NoHab = 10, Tipo = "Individual", Piso = 4, Costo = 1500.00 },
            new Habitacion { Id = 5, NoHab = 8, Tipo = "Doble", Piso = 1, Costo = 2464.00 },
            new Habitacion { Id = 6, NoHab = 15, Tipo = "Triple", Piso = 2, Costo = 3200.00 },

        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();

        // Inicializar datos de reservas
        var reservas = new List<Reserva>
        {
            new Reserva { HabitacionId = 1, ClienteId = 1, InicioReserva = DateTime.Parse("2022-10-11"), FinReserva = DateTime.Parse("2022-10-12") },
            new Reserva { HabitacionId = 2, ClienteId = 2, InicioReserva = DateTime.Parse("2021-05-05"), FinReserva = DateTime.Parse("2021-05-08") },
            new Reserva { HabitacionId = 3, ClienteId = 6, InicioReserva = DateTime.Parse("2022-04-01"), FinReserva = DateTime.Parse("2022-05-01") },
            new Reserva { HabitacionId = 4, ClienteId = 5, InicioReserva = DateTime.Parse("2020-04-01"), FinReserva = DateTime.Parse("2020-05-01") },
            new Reserva { HabitacionId = 5, ClienteId = 7, InicioReserva = DateTime.Parse("2023-11-04"), FinReserva = DateTime.Parse("2023-11-05") }
           
        };
        contexto.Reservas.AddRange(reservas);
        contexto.SaveChanges();
    }
}