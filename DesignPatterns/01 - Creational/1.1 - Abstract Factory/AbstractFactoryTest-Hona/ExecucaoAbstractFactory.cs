using System.Collections.Generic;

namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var listFilmes = new List<Filme>()
            {
                FilmeCreator.Criar(Genero.Terror, "Sony"),
                FilmeCreator.Criar(Genero.Comedia, "Warner"),
                FilmeCreator.Criar(Genero.Acao, "Marvel")
            };

            listFilmes.ForEach(f => Catalogo.CatalogoCreate(f).Classificar());
        }
    }
}