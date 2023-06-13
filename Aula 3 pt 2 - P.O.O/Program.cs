public class Programa
{
    static void Main(string[] args)
    {
        Metodos a = new Metodos();
        double soma = a.Somar(190, 210);
        Console.WriteLine(soma);


        Metodos b = new Metodos();
        double subtracao = b.Subtrair(90,87);
        Console.WriteLine(subtracao);

        Metodos c = new Metodos();
        double multiplicacao = c.Multiplicar(60, 63);
        Console.WriteLine(multiplicacao);

        Metodos d = new Metodos();
        double divisao = c.Divisão(100, 10);
        Console.WriteLine(divisao);
    }
}