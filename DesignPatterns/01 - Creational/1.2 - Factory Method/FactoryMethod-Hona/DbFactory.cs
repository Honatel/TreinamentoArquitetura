using System;

namespace DesignPatterns.Creational.Factory.Method.FactoryMethod.Hona
{
    public abstract class DbFactory
    {
        // Factory Method
        public abstract DbConnectionBase CriaConexao(string connectionString);

        public static DbFactory CriaInstanciaConcreta(TipoBanco tipo)
        {
            switch (tipo)
            {
                case TipoBanco.SqlServer:
                    return new SqlServerFactory();
                case TipoBanco.Oracle:
                    return new OracleFactory();
                default:
                    throw new ApplicationException("Banco de dados não existente");
            }
        }
    }
}