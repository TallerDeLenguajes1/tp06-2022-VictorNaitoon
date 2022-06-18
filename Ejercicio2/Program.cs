Empleado trabajador1 = new Empleado("Marcos","Maidana",'C','M',new DateTime(1986,3,15), new DateTime(2010,2,25),25000,Empleado.Cargos.Ingeniero);
Empleado trabajador2 = new Empleado("Mariana","Reyes",'S','F',new DateTime(1997,5,7),new DateTime(2018,12,9),45000,Empleado.Cargos.Administrativo);
Empleado trabajador3 = new Empleado("Jose","Leguizamon",'C','M',new DateTime(1966,11,16), new DateTime(1986,2,24),65000,Empleado.Cargos.Especialista);

double MontoAPagar = trabajador1.MontoACobrar() + trabajador2.MontoACobrar() + trabajador3.MontoACobrar();

Console.WriteLine("El monto que la industria debe pagar por los tres empleado es de: "+MontoAPagar);

if (trabajador1.Jubilacion() < trabajador2.Jubilacion() && trabajador1.Jubilacion() < trabajador3.Jubilacion()){
    Console.WriteLine("El trabajador mas proximo a jubilarse es: ");
    Console.WriteLine("Nombre: "+trabajador1.Nombre);
    Console.WriteLine("Apellido: "+trabajador1.Apellido);
    Console.WriteLine("Edad: "+trabajador1.Edad());
    Console.WriteLine("Estado Civil: "+trabajador1.EstadoCivil);
    Console.WriteLine("Genero: "+trabajador1.Genero);
    Console.WriteLine("Cargo que ocupa: "+trabajador1.cargo);
    Console.WriteLine("Sueldo basico del trabajador: $"+trabajador1.Sueldo);
    Console.WriteLine("Sueldo total que cobra: $"+trabajador1.MontoACobrar());
    Console.WriteLine("Anio en el que ingreso a la industria: "+trabajador1.FechaDeIngreso);
    Console.WriteLine("Anios que le falta para jubilarse: "+trabajador1.Jubilacion());
    Console.WriteLine("Anios que lleva trabajando con nosotros: "+trabajador1.Antiguedad());
} else{
    if (trabajador2.Jubilacion() < trabajador1.Jubilacion() && trabajador2.Jubilacion() < trabajador3.Jubilacion()){
        Console.WriteLine("El trabajador mas proximo a jubilarse es: ");
        Console.WriteLine("Nombre: "+trabajador2.Nombre);
        Console.WriteLine("Apellido: "+trabajador2.Apellido);
        Console.WriteLine("Edad: "+trabajador2.Edad());
        Console.WriteLine("Estado Civil: "+trabajador2.EstadoCivil);
        Console.WriteLine("Genero: "+trabajador2.Genero);
        Console.WriteLine("Cargo que ocupa: "+trabajador2.cargo);
        Console.WriteLine("Sueldo basico del trabajador: $"+trabajador2.Sueldo);
        Console.WriteLine("Sueldo total que cobra: $"+trabajador2.MontoACobrar());
        Console.WriteLine("Anio en el que ingreso a la industria: "+trabajador2.FechaDeIngreso);
        Console.WriteLine("Anios que le falta para jubilarse: "+trabajador2.Jubilacion());
        Console.WriteLine("Anios que lleva trabajando con nosotros: "+trabajador2.Antiguedad());
    } else{
        Console.WriteLine("El trabajador mas proximo a jubilarse es: ");
        Console.WriteLine("Nombre: "+trabajador3.Nombre);
        Console.WriteLine("Apellido: "+trabajador3.Apellido);
        Console.WriteLine("Edad: "+trabajador3.Edad());
        Console.WriteLine("Estado Civil: "+trabajador3.EstadoCivil);
        Console.WriteLine("Genero: "+trabajador3.Genero);
        Console.WriteLine("Cargo que ocupa: "+trabajador3.cargo);
        Console.WriteLine("Sueldo basico del trabajador: $"+trabajador3.Sueldo);
        Console.WriteLine("Sueldo total que cobra: $"+trabajador3.MontoACobrar());
        Console.WriteLine("Anio en el que ingreso a la industria: "+trabajador3.FechaDeIngreso);
        Console.WriteLine("Anios que le falta para jubilarse: "+trabajador3.Jubilacion());
        Console.WriteLine("Anios que lleva trabajando con nosotros: "+trabajador3.Antiguedad());
    }
}

