namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    internal class ClassificacaoLivreFactory : ClassificacaoFactory
    {
        public override Classificacao CreateClassificacao()
        {
            return ClassificacaoCreator.Criar(Genero.Comedia);
        }

        public override Filme CreateFilme(Genero genero, string franquia)
        {
            return FilmeCreator.Criar(genero, franquia);
        }
    }
}