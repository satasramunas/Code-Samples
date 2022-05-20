// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

// establishing a connection to the local server
string connectionString;
SqlConnection cnn;
connectionString = @"Server=.;Database=TestDataBase;Trusted_Connection=True;";
cnn = new SqlConnection(connectionString);
cnn.Open();

// inserting items into a table
string insertText = @"insert into Persons (PersonID, LastName, FirstName, Address, City)
Values (1, 'name1', 'firstName1', 'blabla street', 'blablacity')";

var command = cnn.CreateCommand();
command.CommandText = insertText;
command.ExecuteNonQuery();

cnn.Close();

// we have to open and close the connection after every command!