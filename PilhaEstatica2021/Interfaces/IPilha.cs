using System;
using System.Collections.Generic;
using System.Text;

namespace PilhaEstatica2021.Interfaces
{
    public interface IPilha<T>
    {
        public void Empilha(T obj);

        public T Desempilha();

        public T Topo();

        public int Tamanho();

        public IEnumerable<T> RetornaTodosElementos();

        public bool EstaVazia();

        public T MaiorElemento();

        public T MenorElemento();

        public bool SaoIguais();

        public bool MediaAritmetica();

    }
}

