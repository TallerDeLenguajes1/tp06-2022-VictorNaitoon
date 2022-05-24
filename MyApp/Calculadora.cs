public class Calculadora
{
    public Calculadora (double Inicio){
        Resultado = Inicio;
    }
    public double Resultado;
    public void Sumar(double valor){
        Resultado += valor;
    }
    public void Restar(double valor){
        Resultado -= valor;
    }
    public void Multiplicar(double valor){
        Resultado *= valor;
    }
    public void Dividir(double valor){
        if (valor != 0){
            Resultado /= valor;
        } else {
            Console.WriteLine("Error no se puede dividir por 0");
        }
    }
}