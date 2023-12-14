// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {   // importando clases y generando isntancias de al calculadora
        CalculadoraModel modelo = new CalculadoraModel();
        CalculadoraView vista = new CalculadoraView();
        CalculadoraController controlador = new CalculadoraController(modelo, vista);
        controlador.EjecutarCalculadora();
    }
}

/*
    Explicacion -

    1- Creo main en el archivo program, importo las clases y el metodo a ejecutar

*/
