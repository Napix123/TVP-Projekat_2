using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace TVP_Projekat2.Cuvanje
{
    internal class ConnectionWrapper
    {
        private OleDbConnection connection;
        public delegate T QueryExecutor<T>(OleDbDataReader reader);

        public ConnectionWrapper(string connectionString)
        {
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        public T UseQuery<T>(string query, QueryExecutor<T> executor, params object[] parameters)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i] is DateTime)
                    {
                        cmd.Parameters.Add($"@{i}", OleDbType.Date);
                        cmd.Parameters[$"@{i}"].Value = (DateTime)parameters[i];
                    }
                    else cmd.Parameters.AddWithValue($"@{i}", parameters[i]);
                }
                OleDbDataReader reader = cmd.ExecuteReader();
                return executor(reader);
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u komunikaciji sa databazom !", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.Message);
                return default(T);
            }
        }

        public int UseVoidQuery(string query, params object[] parameters)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i] is DateTime)
                    {
                        cmd.Parameters.Add($"@{i}", OleDbType.Date);
                        cmd.Parameters[$"@{i}"].Value = (DateTime)parameters[i];
                    }
                    else cmd.Parameters.AddWithValue($"@{i}", parameters[i]);
                }
                int success = cmd.ExecuteNonQuery();
                if (success > 0)
                {
                    cmd.CommandText = "SELECT @@IDENTITY";
                    return (int)cmd.ExecuteScalar();
                }
                return -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska u komunikaciji sa databazom !", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
