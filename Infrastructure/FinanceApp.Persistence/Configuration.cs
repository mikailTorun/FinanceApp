using Microsoft.Extensions.Configuration;

namespace FinanceApp.Persistence
{
    public static class Configuration
    {
        static public string GetConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("PostgreSql");
            }
        } 
    }
}
