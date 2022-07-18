namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    internal class ClassificacaoMaior16Factory : ClassificacaoFactory
    {
        public override Classificacao CreateClassificacao()
        {
            return ClassificacaoCreator.Criar(Genero.Acao);
        }

        public override Filme CreateFilme(Genero genero, string franquia)
        {
            return FilmeCreator.Criar(genero, franquia);
        }
    }
}