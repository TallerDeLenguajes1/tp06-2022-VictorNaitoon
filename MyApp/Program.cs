Calculadora cal = new Calculadora(0);

int eleccion, eleccion2 , valor;



do{
    Console.WriteLine("Ingrese un valor");
    valor = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Que Operación desea realizar: (1-Suma, 2-Restar, 3-Multiplicar, 4-Dividir, 5-Borrar)");
    eleccion = Convert.ToInt32(Console.ReadLine());

    switch (eleccion){
        case 1:
            cal.Sumar(valor);
            break;
        case 2:
            cal.Restar(valor);
            break;
        case 3:
            cal.Multiplicar(valor);
            break;
        case 4:
            cal.Dividir(valor);
            break;
        case 5:
            cal.Resultado = 0;
            break;
    }

    Console.WriteLine("¿Desea realizar otra operacion? (1-Si 0-No)");
    eleccion2 = Convert.ToInt32(Console.ReadLine());
} while (eleccion2 != 0);

