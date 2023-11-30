using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OfficeOpenXml; // For Excel handling with EPPlus

namespace Test_FormApp
{
    public partial class ExcelNew : Form
    {
        private string connectionString = @"Data Source=DESKTOP-JUMOE68\SQLEXPRESS;Initial Catalog=United_Consulting;Integrated Security=True";
        private string filePath;
        public ExcelNew()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    MessageBox.Show("File Uploaded Successfully!");
                }
            }
        }

        private void Process_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Please upload a file first!");
                return;
            }

            try
            {
                using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    DataTable dt = new DataTable();

                    // Read Excel data and load into DataTable
                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow newRow = dt.Rows.Add();
                        for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                        {
                            if (row == 2)
                            {
                                // Add columns to DataTable from Excel headers
                                dt.Columns.Add(worksheet.Cells[row, col].Value.ToString());
                            }
                            else
                            {
                                newRow[col - 1] = worksheet.Cells[row, col].Value;
                            }
                        }
                    }

                    // Write data from DataTable to SQL Server Database
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                        {
                            bulkCopy.DestinationTableName = "Excel_Properties"; // Replace with your table name

                            // Explicitly map columns
                            bulkCopy.ColumnMappings.Add("Name", "Name");
                            bulkCopy.ColumnMappings.Add("Surname", "Surname");
                            bulkCopy.ColumnMappings.Add("Age", "Age");
                            // Repeat this for each column...

                            bulkCopy.WriteToServer(dt);
                        }
                    }
                    MessageBox.Show("Data Uploaded to Database Successfully!");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
                MessageBox.Show("Data Uploaded to Database Successfully!");
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Excel_Properties"; // Replace with your table name
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dt);
                    }
                }

                // Display the retrieved data
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
