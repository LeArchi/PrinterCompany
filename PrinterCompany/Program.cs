using System.Configuration;

namespace PrinterCompany
{
    internal class Program
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();

        static void Main(string[] args)
        {
            
        }
    }
}