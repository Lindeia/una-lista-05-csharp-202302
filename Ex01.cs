int[] numeros = new int[5];

Console.WriteLine("Digite 5 números inteiros (pressionar Enter para cada número digitado)");

for (int p = 0; p < numeros.Length; p++)
{
    numeros[p] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\n\nEstes são os números que você digitou:");
for (int p = 0; p < numeros.Length; p++)
{
    Console.WriteLine(numeros[p]);
}