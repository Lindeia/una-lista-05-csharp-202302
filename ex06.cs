	public static void Main()
	{
		float[] notas = new float[4];
        float[] somaNotas = new float[10];
        float[] mediaNotas = new float[10];
        int i = 0;
        int numAlunos = 10;
        int aluno = 0;
        int maiorQueSete = 0;

        while (aluno < numAlunos) {
            Console.WriteLine($"Digite as 4 notas do aluno {(aluno + 1)}: ");

            while (i <= 3) {
                notas[i] = Convert.ToSingle(Console.ReadLine());
                i++;
            }

            somaNotas[aluno] = notas[0] + notas[1] + notas[2] + notas[3];
            mediaNotas[aluno] = somaNotas[aluno] / 4;
            i = 0;
            
            aluno++;
        }

        aluno = 0;

        while (aluno < numAlunos) {
            if (mediaNotas[aluno] >= 7.0) {
                maiorQueSete++;
            }
            aluno++;
        }

        Console.WriteLine($"O número de alunos que possuem uma nota maior que sete é {maiorQueSete}");
	}
