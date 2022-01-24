using System;

namespace TesteSemFalha{

    public class Pilha
{
    Posicao primeiro;

    private Posicao Primeiro { get => Primeiro1; set => Primeiro1 = value; }
    private Posicao Primeiro1 { get => primeiro; set => primeiro = value; }

    public void Empilha(object item)
    {
        Primeiro = new Posicao(Primeiro, item);
    }

    public object Desempilha()
    {
        if (Primeiro == null)
        {
            throw new InvalidOperationException("A pilha está vazia!");
        }

        object resultado = Primeiro.item;
        Primeiro = Primeiro.proximo;
        return resultado;
    }

    class Posicao
    {
        public Posicao proximo;
        public object item;
        public Posicao(Posicao proximo, object item)
        {
            this.proximo = proximo;
            this.item = item;
        }
    }
}
}


