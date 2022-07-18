using System;

namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    public enum Genero
    {
        Terror,
        Comedia,
        Acao
    }
    public abstract class Filme
    {
        public string Franquia { get; set; }
        public Genero Genero { get; set; }
        public Filme(string franquia, Genero genero)
        {
            Franquia = franquia;
            Genero = genero;
        }
    }

    public class FilmeTerror : Filme
    {
        public FilmeTerror(string franquia, Genero genero) : base(franquia, genero)
        {
        }
    }

    public class FilmeComedia : Filme
    {
        public FilmeComedia(string franquia, Genero genero) : base(franquia, genero)
        {
        }
    }

    public class FilmeAcao : Filme
    {
        public FilmeAcao(string franquia, Genero genero) : base(franquia, genero)
        {
        }
    }

    public class FilmeCreator
    {
        public static Filme Criar(Genero genero, string franquia)
        {
            switch (genero)
            {
                case Genero.Terror:
                    return new FilmeTerror(franquia, genero);
                case Genero.Comedia:
                    return new FilmeComedia(franquia, genero);
                case Genero.Acao:
                    return new FilmeAcao(franquia, genero);
                default:
                    throw new ApplicationException("Genero de filme desconhecido.");
            }
        }
    }
}