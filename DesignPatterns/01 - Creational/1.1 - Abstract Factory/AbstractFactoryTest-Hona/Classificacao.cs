using System;

namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    public abstract class Classificacao
    {
        public Genero Genero { get; set; }

        public Classificacao(Genero genero)
        {
            Genero = genero;
        }

        public abstract void Classificar(Filme filme);
    }

    public class ClassificacaoMaior18 : Classificacao
    {
        public ClassificacaoMaior18(Genero genero) : base(genero)
        {
        }
        public override void Classificar(Filme filme)
        {
            Console.WriteLine("Filme classificado com o genero " + this.Genero
            + "E só pode ser assistido por pessoas com idade maior de 18");
        }
    }

    public class ClassificacaoMaior16 : Classificacao
    {
        public ClassificacaoMaior16(Genero genero) : base(genero)
        {
        }
        public override void Classificar(Filme filme)
        {
            Console.WriteLine("Filme classificado com o genero " + this.Genero
            + "E só pode ser assistido por pessoas com idade maior de 16");
        }
    }

    public class ClassificacaoLivre : Classificacao
    {
        public ClassificacaoLivre(Genero genero) : base(genero)
        {
        }
        public override void Classificar(Filme filme)
        {
            Console.WriteLine("Filme classificado com o genero " + this.Genero
            + "E pode ser assistido por todas as pessoas.");
        }
    }

    public class ClassificacaoCreator
    {
        public static Classificacao Criar(Genero genero)
        {
            switch (genero)
            {
                case Genero.Terror:
                    return new ClassificacaoMaior18(genero);
                case Genero.Acao:
                    return new ClassificacaoMaior16(genero);
                case Genero.Comedia:
                    return new ClassificacaoLivre(genero);
                default:
                    throw new ApplicationException("Genero não encontrado para criar uma Classificação");
            }
        }
    }

}