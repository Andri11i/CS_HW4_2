using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW4
{
    public class ApplicationSettings
    {
        public string ApplicationName { get; set; }
        public string Version { get; set; }

        public class DatabaseSettings
        {
            public string ConnectionString { get; set; }
            public int Timeout { get; set; }

            public override string ToString()
            {
                return $"Connection String: {ConnectionString}, Timeout: {Timeout} seconds";
            }
        }

        public DatabaseSettings DbSettings { get; set; }

        public string GetFullSettings()
        {
            return $"Application: {ApplicationName}, Version: {Version}, Database Settings: {DbSettings}";
        }
    }
}
