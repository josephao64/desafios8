namespace Desafio1_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora micalculadora = new Calculadora();
            micalculadora.Marca = "Casio";
            micalculadora.Serie = "HJ1452";

            double suma = micalculadora.Sumar(2.33, 3.20);
            double resta = micalculadora.Restar(5,2);
            double multiplicacion = micalculadora.Sumar(2.20, 3.30);
            double division = micalculadora.Sumar(4,2);

            Console.WriteLine("Calculadora: ");
            Console.WriteLine("Marca de la calculadora: " + micalculadora.Marca);
            Console.WriteLine("Serie de la calculadora: " + micalculadora.Serie);
            Console.WriteLine("Resultado de la suma: "+suma);
            Console.WriteLine("Resultado de la resta: "+ resta);
            Console.WriteLine("Resultado de la multiplicacion: "+ multiplicacion);
            Console.WriteLine("Resultado de la division: "+ division);

            Console.WriteLine();

            CalculadoraCientifica micalculadoraCientifica = new CalculadoraCientifica();
            micalculadoraCientifica.Marca = "Rolex";
            micalculadoraCientifica.Serie = "GA855";

            double potencia = micalculadoraCientifica.Potencia(2,3);
            double raiz = micalculadoraCientifica.Raiz(16);
            double modulo = micalculadoraCientifica.Modulo(10, 2);
            double logaritmo = micalculadoraCientifica.Logaritmo(100, 10);

            Console.WriteLine("Calculadora: ");
            Console.WriteLine("Marca de la calculadora: " + micalculadoraCientifica.Marca);
            Console.WriteLine("Serie de la calculadora: " + micalculadoraCientifica.Serie);
            Console.WriteLine("Resultado de la potencia: " + potencia);
            Console.WriteLine("Resultado de la raiz: " + raiz);
            Console.WriteLine("Resultado del modulo: " + modulo);
            Console.WriteLine("Resultado del logaritmos: " + logaritmo);

            Console.WriteLine();
        }
    }
}