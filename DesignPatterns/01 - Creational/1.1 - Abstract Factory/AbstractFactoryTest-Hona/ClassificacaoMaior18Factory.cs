namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    internal class ClassificacaoMaior18Factory : ClassificacaoFactory
    {
        public override Classificacao CreateClassificacao()
        {
            return ClassificacaoCreator.Criar(Genero.Terror);
        }

        public override Filme CreateFilme(Genero genero, string franquia)
        {
            return FilmeCreator.Criar(genero, franquia);
        }
    }
}