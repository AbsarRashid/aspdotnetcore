using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstGitHubRepoVs19.DBClass
{
    public class ClassNameRepository
    {
        SqlConnection _connString;
        public ClassNameRepository()
        {
            var configuration = GetConfigurationRoot();
            _connString = new SqlConnection(configuration.GetConnectionString("DBWEBContext"));

        }
        public SqlConnection StringName()
        {
            return _connString;
        }

        public IConfigurationRoot GetConfigurationRoot()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            return builder.Build();
        }
    }
}
