Random rnd = new Random();
int[] numeros = new int[10];
//rnd = new Random();
//static Random rnd;
Preencher();

Console.WriteLine("Esses são os números que escolhi: ");
//int numeros = Convert.ToInt32(Console.ReadLine());
Imprimir();
Console.WriteLine();

Console.WriteLine("A Ordem decrescente dos números que escolhi são: ");
OrdenarDecrescente();
Imprimir();
Console.WriteLine();

void Preencher()
{
    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] = rnd.Next(1, 100);

    }
}
void OrdenarDecrescente()
{
    for (int i = 0; i < numeros.Length - 1; i++)
    {
        for (int j = i + 1; j < numeros.Length; j++)
        {
            if (numeros[i] < numeros[j])
            {
                int aux = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = aux;
            }
        }
    }
}

void Imprimir()
{
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine("Posição: " + i + "\tValor: " + numeros[i]);

    }
}Console.ReadLine();