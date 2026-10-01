namespace Aulaaaaaa
{

public class ExercicioFuncao
    {
        public delegate double Media(int [] valores);
        
        static double Medias(int[] valores)
        {
            double media = 0;
            foreach (var valor in valores)
            {
                media += valor;
            }
            return media / valores.Length;

        }
                static void Main(string[] args)
        {
            Media medias = Medias; 
            int [] vetor = new int[10];
            System.Console.WriteLine("Digite 10 numeros");
            for(int i = 0; i < 10; i++){
                int n = int.Parse(System.Console.ReadLine());
                vetor [i] = n;
            }
            System.Console.WriteLine(medias(vetor));

        }
    }
}        