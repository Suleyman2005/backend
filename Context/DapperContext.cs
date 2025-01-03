﻿using System.Data;
using Microsoft.Data.SqlClient;

namespace backend.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection"); // Use the key from appsettings.json
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

    }
}
