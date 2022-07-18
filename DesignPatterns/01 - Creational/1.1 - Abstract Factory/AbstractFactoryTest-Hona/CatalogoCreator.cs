using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    public class Catalogo
    {
        private readonly Filme _filme;
        private readonly Classificacao _classificacao;

        public Catalogo(ClassificacaoFactory factory, Filme filme)
        {
            _filme = factory.CreateFilme(filme.Genero, filme.Franquia);
            _classificacao = factory.CreateClassificacao();
        }
        public void Classificar()
        {
            _classificacao.Classificar(_filme);
        }

        public static Catalogo CatalogoCreate(Filme filme)
        {
            switch (filme.Genero)
            {
                case Genero.Terror:
                    return new Catalogo(new ClassificacaoMaior18Factory(), filme);
                case Genero.Acao:
                    return new Catalogo(new ClassificacaoMaior16Factory(), filme);
                case Genero.Comedia:
                    return new Catalogo(new ClassificacaoLivreFactory(), filme);
                default:
                    throw new ApplicationException("Genero não existe");
            }
        }
    }
}