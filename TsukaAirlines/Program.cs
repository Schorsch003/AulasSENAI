using System;

namespace TsukaAirlines {
    class Program {
        static void Main (string[] args) {

            Passageiro[] passageiros = new Passageiro[2];
            int numPassageiros = 0;
            Console.WriteLine ("Seja bem-vindo à Tsukamoto Airlines!");
            bool sair = false;
            do {

                Console.WriteLine ("Escolha uma opção:");

                Console.WriteLine ("1 - Registrar Passageiro");
                Console.WriteLine ("2 - Exibir passageiros");
                Console.WriteLine ("0 - Sair");

                int opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        Passageiro p = new Passageiro ();
                        Console.Write ("Digite seu nome: ");
                        p.setNome (Console.ReadLine ());
                        Console.Write ("Digite o numero da sua passagem: ");
                        p.setNumeroPassagem (int.Parse (Console.ReadLine ()));
                        Console.Write ("Digite a data de seu viagem: ");
                        p.setData (DateTime.Parse(Console.ReadLine ()));
                        passageiros[numPassageiros] = p;
                        numPassageiros++;
                        Console.WriteLine ("Cadastro concluído!!!!");
                        break;
                    case 2:
                        foreach (Passageiro passageiro in passageiros) {
                            if (passageiro != null) {
                                Console.WriteLine (passageiro.getNome ());
                                Console.WriteLine (passageiro.getNumeroPassagem ());
                                Console.WriteLine (passageiro.getData ());
                            }
                        }
                        break;
                    case 0:
                        sair = true;
                        break;
                }
            } while (!sair);
        }
    }
}