using Projeto_plataforma_ensino.Entities;
using Task = Projeto_plataforma_ensino.Entities.Task;

namespace Projeto_plataforma_ensino {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Quantas aulas tem o curso? ");
            int n = int.Parse(Console.ReadLine());
            List<Lesson> list = new List<Lesson>();
            Video video;
            Task task;
            int somaTask = 0;
            int somaVideo = 0;

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a aula:");
                Console.Write("Conteudo ou tarefa (c/t)? ");
                char resposta = char.Parse(Console.ReadLine());
                Console.Write("Título: ");

                if (resposta == 'c' || resposta == 'C') {
                    string titulo = Console.ReadLine();
                    Console.Write("URL do vídeo: ");
                    string url = Console.ReadLine();
                    Console.Write("Duração em segundos: ");
                    int duracao = int.Parse(Console.ReadLine());
                    video = new Video(url, duracao, titulo);
                    list.Add(video);

                }
                else if (resposta == 't' || resposta == 'T') {
                    string titulo = Console.ReadLine();
                    Console.Write("Descrição: ");
                    string descricao = Console.ReadLine();
                    Console.Write("Quantidade de questões: ");
                    int qtdQuestoes = int.Parse(Console.ReadLine());
                    task = new Task(titulo, descricao, qtdQuestoes);
                    list.Add(task);
                }
            }
            int c = 0;
            foreach(Lesson l in list) {
                c += l.Duration();
            }

            Console.WriteLine("DURAÇÃO TOTAL DO CURSO: = " + c + " SEGUNDOS");
        }
    }
}
