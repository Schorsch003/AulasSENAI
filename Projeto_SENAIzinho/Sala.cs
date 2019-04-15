namespace Projeto_SENAIzinho {
    public class Sala {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;


        public void AlocarAluno(Aluno a, int SalaParaMover){
            a.numeroSala = SalaParaMover;
        }
    }
}