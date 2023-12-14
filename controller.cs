public class CalculadoraController
{
    private CalculadoraModel modelo;
    private CalculadoraView vista;

    public CalculadoraController(CalculadoraModel modelo, CalculadoraView vista)
    {
        this.modelo = modelo;
        this.vista = vista;
    }


    public void EjecutarCalculadora()
    {
        string entradaNum1 = vista.ObtenerEntrada("Ingrese el primer número: ");
        double num1;

        if (double.TryParse(entradaNum1, out num1))
        {
            string operador = vista.ObtenerEntrada("Ingrese el operador (+, -, *, /): ");

            string entradaNum2 = vista.ObtenerEntrada("Ingrese el segundo número: ");
            double num2;

            if (double.TryParse(entradaNum2, out num2))
            {
                double resultado = modelo.RealizarOperacion(num1, num2, operador);
                vista.MostrarResultado(resultado);
            }
            else
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el primer número.");
        }
    }
}
