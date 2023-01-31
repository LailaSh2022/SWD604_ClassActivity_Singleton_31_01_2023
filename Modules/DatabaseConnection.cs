using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD604_ClassActivity_Singleton_31_01_2023.Modules
{
	class DatabaseConnection
	{
		private static string host { get; set; }
        private static string database { get; set; }
        private static string Encrypt { get; set; }
        private static string Certificate { get; set; }
        private static string LoginDB { get; set; }
        private static string Connect { get; set; }
        private static string Access { get; set; }
        private static string Failover { get; set; }
        private static string strProvider { get; set; }
        private static string getHost()
		{
            host = "LAPTOP-Q4ENDLRT\\SQLEXPRESS";
            return host;
		}
        private static string getDatabase()
        {
            database = "CarDB";
            return database;
        }
        private static string getEncrypt()
        {
            Encrypt = "False";
            return Encrypt;
        }
        private static string getCertificate()
        {
            Certificate = "False";
            return Certificate;
        }
        private static string getLoginDB()
        {
            LoginDB = "True";
            return LoginDB;
        }
        private static string getConnect()
        {
            Connect = "30";
            return Connect;
        }
        private static string getAccess()
        {
            Access = "ReadWrite";
            return Access;
        }
        private static string getFailover()
        {
            Failover = "False";
            return Failover;
        }
        public static string getstrProvider()
        {
            strProvider = "Data Source=" + getHost() + ";Initial Catalog=" + getDatabase() + ";Integrated Security=" + getLoginDB()
            + ";Connect Timeout=" + getConnect() + ";Encrypt=" + getEncrypt() + ";TrustServerCertificate=" + getCertificate()
            + ";ApplicationIntent=" + getAccess() + ";MultiSubnetFailover=" + getFailover();
            return strProvider;
        }

    }
}
