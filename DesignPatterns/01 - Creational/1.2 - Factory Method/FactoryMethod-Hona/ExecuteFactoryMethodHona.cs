using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory.Method.FactoryMethod.Hona
{
    public class ExecuteFactoryMethodHona
    {
        public static void Executar()
        {
            var connectionSql = DbFactory
                                .CriaInstanciaConcreta(TipoBanco.SqlServer)
                                .CriaConexao("CS-SQL")
                                .Conectar();

            connectionSql.ExecuteCommand("Select * from produto");
            connectionSql.Close();


            var connectionOracle = DbFactory
                    .CriaInstanciaConcreta(TipoBanco.Oracle)
                    .CriaConexao("CS-ORACLE")
                    .Conectar();

            connectionSql.ExecuteCommand("Select * from produto");
            connectionSql.Close();
        }
    }
}