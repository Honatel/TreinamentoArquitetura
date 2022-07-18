namespace DesignPatterns.Creational.Factory.Method.FactoryMethod.Hona
{
    public abstract class DbConnectionBase
    {
        public DbConnectionBase(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
        public abstract Connection Conectar();
    }
}