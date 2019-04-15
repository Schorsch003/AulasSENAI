using System;
namespace TsukaAirlines
{
    public class Passageiro
    {
        
        string nome;
        int numeroPassagem;
        DateTime data;


        public void setNome(string nome){
            this.nome = nome;
        }

        public string getNome(){
            return nome;
        }

        public void setNumeroPassagem(int numeroPassagem){
            this.numeroPassagem = numeroPassagem;
        }

        public int getNumeroPassagem(){
            return numeroPassagem;
        }

        public void setData(DateTime data){
            this.data = data;
        }

        public DateTime getData(){
            return data;
        }
    }
}