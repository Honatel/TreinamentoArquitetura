using System;

namespace DesignPatterns.Creational.Factory.Method.FactoryMethod.Hona
{
    internal class OracleDbConnection : DbConnectionBase
    {
        public OracleDbConnection(string connectionString) : base(connectionString)
        {
        }
        public override Connection Conectar()
        {
            Console.WriteLine("Connectando ao Banco");
            var connection = new Connection(this.ConnectionString);
            connection.Open();

            return connection;
        }
    }
}