using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Studio
{
    public class AppConfigWrapper
    {
        private Configuration appConfig;
        //private ConnectionStringSettingsCollection connectionStrings;

        public AppConfigWrapper()
        {
            appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStrings = ((ConnectionStringsSection)appConfig.GetSection("connectionStrings")).ConnectionStrings;
        }

        public ConnectionStringSettingsCollection ConnectionStrings { get; set; }

        public void EditConnectionString(string name, string provider, string connectionString)
        {
            ConnectionStrings[name].ConnectionString = connectionString;
            ConnectionStrings[name].ProviderName = provider;

            Save("connectionStrings");
        }

        public void AddConnectionString(string name, string provider, string connectionString)
        {
            ConnectionStrings.Add(new ConnectionStringSettings(name, connectionString, provider));
            Save("connectionStrings");
        }

        public void DeleteConnectionString(string name)
        {
            ConnectionStrings.Remove(name);
            Save("connectionStrings");
        }
        

        public void AddOrUpdateConnection(string name, string provider, string connectionString)
        {
            if (ConnectionStrings[name] == null)
            {
                AddConnectionString(name, provider, connectionString);
            }
            else
            {
                EditConnectionString(name, provider, connectionString);
            }
        }


        private void Save(string section)
        {
            appConfig.Save();
            ConfigurationManager.RefreshSection(section);
        }
    }
}

