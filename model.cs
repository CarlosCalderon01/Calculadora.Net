public class CalculadoraModel
{
    public double RealizarOperacion(double num1, double num2, string operador)
    {
        switch (operador)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "*":
                return num1 * num2;
            case "/":
                // en caso de ingresen un cero
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("error no se puede devidir con cero");
                    return double.NaN;
                }
            default:
                // Si el operador es diferente de los 4 casos
                Console.WriteLine("Operador no válido.");
                return double.NaN;
        }
    }
}

/*
    Explicacion -

    1- Creo los modelos en base a un switch segun el caso de uso.
    2- agrego una excepcion dado cero en el caso de la division
    3- agrego un resultado por defecto en caso de un imprevisto

*/