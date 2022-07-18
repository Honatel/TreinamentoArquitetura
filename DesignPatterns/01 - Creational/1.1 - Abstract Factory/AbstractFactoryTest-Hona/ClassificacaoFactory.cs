namespace DesignPatterns.Creational.Abstract.Factory.AbstractFactoryTest.Hona
{
    public abstract class ClassificacaoFactory
    {
        public abstract Filme CreateFilme(Genero genero, string franquia);

        public abstract Classificacao CreateClassificacao();
    }
}