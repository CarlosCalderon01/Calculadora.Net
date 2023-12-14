public class CalculadoraView
{
    public void MostrarResultado(double resultado)
    {
        Console.WriteLine($"Resultado: {resultado}");
    }

    public string ObtenerEntrada(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }
}

/*
    Explicacion -

    1- Creo dos clases para la entrada o salida
    1- Creo la clase resultado pasandole un parametro que va ser el resultado calculado
    2- Creo la clase entrada para leer el dato ingresado en la consola

*/