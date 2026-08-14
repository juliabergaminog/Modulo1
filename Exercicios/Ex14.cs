Console.WriteLine("A média das notas do aluno:\n");

double N1 = 8.0; double N2 = 7.6; double N3 = 6.5;

Console.WriteLine($"A média das notas {N1}, {N2} e {N3} é {CalcularMedia(N1, N2, N3):F2}");

static double CalcularMedia(double nota1, double nota2, double nota3)

{

    double Media = (nota1 + nota2 + nota3) / 3;


    return Media;

}