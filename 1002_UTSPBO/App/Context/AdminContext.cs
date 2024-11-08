using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1002_UTSPBO.App.Core;
using _1002_UTSPBO.App.Models;
using Npgsql;
using NpgsqlTypes;

namespace _1002_UTSPBO.App.Context
{
    internal class AdminContext
    {
        internal class C_Login : DatabaseWrapper
        {
            private static string table = "data_admin";

            public static long login(string username, string password_admin)
            {
                try
                {
                    string query = $"SELECT COUNT(*) FROM {table} WHERE username = @username AND password_admin = @password_admin";
                    NpgsqlParameter[] parameters =
                    {
                        new NpgsqlParameter("username", NpgsqlDbType.Varchar) { Value = username },
                        new NpgsqlParameter("password_admin", NpgsqlDbType.Varchar) { Value = password_admin }
                    };

                    long result = commandExecutor(query, parameters);
                    return result > 0 ? 1 : 0; // Return 1 if a match is found, otherwise return 0
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0;
                }
            }


        }
    }
