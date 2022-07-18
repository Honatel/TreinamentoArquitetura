namespace DesignPatterns.Creational.Factory.Method.FactoryMethod.Hona
{
    internal class SqlServerFactory : DbFactory
    {
        // Factory Method
        public override DbConnectionBase CriaConexao(string connectionString)
        {
            return new SqlDbConnection(connectionString);
        }
    }
}