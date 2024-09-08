
int numero = 5;
long resultado = Fatorial(numero);
Console.WriteLine($"O fatorial de {numero} é {resultado}");


long Fatorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    else
    {
        return n * Fatorial(n - 1);
    }
}