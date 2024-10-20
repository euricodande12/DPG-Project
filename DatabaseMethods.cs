using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NoahsArk
{
    internal class DatabaseMethods
    {
        public static string connectionString = "Data Source=DESKTOP-5D53KNT\\SQLEXPRESS;Initial Catalog=Noahs_Ark_Test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public static void ExecuteStoredProcedure(string storedProcedureName, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseMethods.connectionString))
            {
                // Set up an event handler to capture messages sent from the SQL Server
                connection.InfoMessage += (sender, e) =>
                {
                    foreach (SqlError err in e.Errors)
                    {
                        MessageBox.Show(err.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };

                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the SqlCommand if any are provided
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(new SqlParameter(param.Key, param.Value));
                        }
                    }

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        foreach (SqlError error in ex.Errors)
                        {
                            MessageBox.Show(error.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public static int ExecuteStoredProcedureWithOutput(string storedProcedureName, Dictionary<string, object> parameters)
        {
            int outputValue = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Set up an event handler to capture messages sent from the SQL Server
                connection.InfoMessage += (sender, e) =>
                {
                    foreach (SqlError err in e.Errors)
                    {
                        MessageBox.Show(err.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };

                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameters to the SqlCommand
                    foreach (var param in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(param.Key, param.Value));
                    }

                    // Add output parameter
                    SqlParameter outputParam = new SqlParameter("@isAuthenticated", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        outputValue = Convert.ToInt32(command.Parameters["@isAuthenticated"].Value);
                    }
                    catch (SqlException ex)
                    {
                        foreach (SqlError error in ex.Errors)
                        {
                            MessageBox.Show(error.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return outputValue;
        }

        public static void LoadDataIntoADataGridView(DataGridView dgvTable, string procedureName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    try
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvTable.DataSource = dataTable;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
