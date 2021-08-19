using PilhaEstatica2021.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaEstatica2021.Entidades
{
    public class PilhaEstatica : IPilha<int>
    {
        private int[] VetorElementos;
        private int TamanhoMaximo = 30;
        private int Indice;

        public PilhaEstatica()
        {
            VetorElementos = new int[TamanhoMaximo];
            Indice = 0;
        }

        public PilhaEstatica(int tamanhoMaximo)
        {
            if (tamanhoMaximo < 0)
                throw new ArgumentException("tamanhoMaximo", "Tamanho não pode ser menor ou igual a zero");
            TamanhoMaximo = tamanhoMaximo;
            VetorElementos = new int[TamanhoMaximo];
            Indice = 0;
        }

        public int Desempilha()
        {
            if (EstaVazia())
                throw new InvalidOperationException("Pilha Vazia, operação não pode ser realizada");
            return VetorElementos[--Indice];
        }

        public void Empilha(int obj)
        {
            if (Indice == TamanhoMaximo)
                throw new InvalidOperationException("Pilha Cheia, operação não pode ser realizada");
            VetorElementos[Indice] = obj;
            Indice++;
        }

        public IEnumerable<int> RetornaTodosElementos()
        {
            for (int i = Indice - 1; i >= 0; i--)
            {
                yield return VetorElementos[i];
            }
        }

        public int Tamanho()
        {
            return Indice;
        }

        public int Topo()
        {
            if (EstaVazia())
                throw new InvalidOperationException("Exceção: Pilha Vazia");
            return VetorElementos[Indice - 1];
        }

        public bool EstaVazia()
        {
            return Indice == 0;
        }


        public int MaiorElemento()
        {
            throw new NotImplementedException();
        }
        public int MenorElemento()
        {
            throw new NotImplementedException();
        }
        public bool MediaAritmetica(PilhaEstatica)
        {
            throw new NotImplementedException();
        }
        public bool SaoIguais(PilhaEstatica)
        {
            throw new NotImplementedException();
        }

        public bool SaoIguais()
        {
            throw new NotImplementedException();
        }

        public bool MediaAritmetica()
        {
            throw new NotImplementedException();
        }
    } 
}