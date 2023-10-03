const int students = 10;
const int gradeLength = 4;
const int minAverage = 7;

float[,] inputs = new float[students, gradeLength];

for (int studentId = 0; studentId < students; studentId++)
{
    for (int gradeId = 0; gradeId < gradeLength; gradeId++)
    {

        float input;
        while (true)
        {
            Console.Write($"Digite a  {gradeId + 1}º nota do {studentId + 1}º aluno: ");
            if (float.TryParse(Console.ReadLine(), out input))
            {
                inputs[studentId, gradeId] = input;
                break;
            }
            else
            {
                Console.WriteLine("A nota digitada é inválida!");
            }
        }
    }

}

for (int i = 0; i < students; i++)
{
    var nota = Enumerable.Range(0, inputs.GetLength(1)).Select(g => inputs[i, g]).Average();
    if (nota >= minAverage)
    {
        Console.WriteLine($"Aluno {i + 1} nota: {nota}");
    }
}