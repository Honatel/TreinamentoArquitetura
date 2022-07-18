namespace DesignPatterns.Creational.Factory.Method.FactoryMethod.Hona
{
    internal class OracleFactory : DbFactory
    {
        public override DbConnectionBase CriaConexao(string connectionString)
        {
            return new OracleDbConnection(connectionString);
        }
    }
}