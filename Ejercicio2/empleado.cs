public class Empleado{
    public string Nombre, Apellido;
    public char EstadoCivil, Genero;
    public DateTime FechaDeNacimiento, FechaDeIngreso;
    public double Sueldo;
    public Cargos cargo;

    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Especialista, 
        Ingeniero,
        Investigador
    }

    
    public Empleado(string nombre, string apellido, char estado_civil, char genero, DateTime fecha_de_nacimiento, DateTime fecha_de_ingreso, double sueldo, Cargos puesto_de_trabajo)
    {
        if (nombre == null){
            Nombre = "";
        } else {
            Nombre = nombre;
        }
        if(apellido == null){
            Apellido = "";
        } else{
            Apellido = apellido;
        }
        EstadoCivil = estado_civil;
        Genero = genero;
        FechaDeNacimiento = fecha_de_nacimiento;
        FechaDeIngreso = fecha_de_ingreso;
        Sueldo = sueldo;
        cargo = puesto_de_trabajo;
    }

    public int Antiguedad(){
        DateTime FechaActual = DateTime.Now;
        if (FechaActual.Month >= FechaDeIngreso.Month){
            return FechaActual.Year - FechaDeIngreso.Year;
        }
        return FechaActual.Year - FechaDeIngreso.Year - 1;
    }

    public int Edad(){
        DateTime FechaActual = DateTime.Today;
        if (FechaActual.Month > FechaDeNacimiento.Month && FechaActual.Day > FechaDeNacimiento.Day){
            return FechaActual.Year - FechaDeNacimiento.Year;
        }
        return FechaActual.Year - FechaDeNacimiento.Year - 1;
    }

    public double MontoACobrar(){
        double Adicional = 0, MontoTotal;
        if (Antiguedad()>20){
            Adicional += 0.25*Sueldo;
        } else{
            Adicional += Antiguedad()*0.01*Sueldo;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista){
            Adicional += 0.50*Sueldo;
        }
        if (EstadoCivil == 'C' || EstadoCivil == 'c'){
            Adicional += 15000;
        }
        MontoTotal = Sueldo + Adicional;
        return MontoTotal;
    }

    public int Jubilacion(){
        int Anio;
        if (Genero == 'F' || Genero == 'f'){
            Anio = 60 - Edad();
        } else{
            Anio = 65 - Edad();
        }
        return Anio;
    }
       
}