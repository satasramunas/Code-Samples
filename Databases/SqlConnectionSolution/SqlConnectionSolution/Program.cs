// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

string connectionString;
SqlConnection cnn;
connectionString = @"Server=.;Database=TestDataBase;Trusted_Connection=True;";
cnn = new SqlConnection(connectionString);
cnn.Open();
cnn.Close();