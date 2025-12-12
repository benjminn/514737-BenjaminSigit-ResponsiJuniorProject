using Npgsql;
using System;

namespace Responsi2
{
    public class DatabaseHelper
    {

        private static string connectionString =
            "Host=localhost;Port=5432;Database=Responsi_junpro_ben;Username=benjaminsigitt;Password=0909";

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                var connection = new NpgsqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Gagal terhubung ke database PostgreSQL. " +
                    "Pastikan PostgreSQL sudah berjalan dan credentials benar.\n" +
                    "Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error koneksi database: " + ex.Message);
            }
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    return conn.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
