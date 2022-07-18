using System;

namespace DesignPatterns.Creational.Factory.Method.FactoryMethod.Hona
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
        public bool Opend { get; set; }

        public void Open()
        {
            Opend = true;
            Console.WriteLine("Conexão aberta");
        }

        public void ExecuteCommand(string query)
        {
            Console.WriteLine("Executando comando" + query);
        }

        public void Close()
        {
            Console.WriteLine("Fechando Conexão");
            Opend = false;
        }
    }
}