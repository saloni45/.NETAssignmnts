using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Assignment1

{
    class Program
    {

        static void Main(string[] args)
        {
            int Choice = -1;
            while (true)
            {
                Console.WriteLine("1. Add a new Product");
                Console.WriteLine("2. Search a Product by ID");
                Console.WriteLine("3. Delete a Product");
                Console.WriteLine("4. Display all Product");
                Console.WriteLine("5.Exit");
                Console.WriteLine("\n Your Choice");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1: AddProduct(); break;
                    case 2: SearchProduct(); break;
                    case 3: DeleteProduct(); break;
                    case 4: DisplayProductDisconnected(); break;
                    case 5: Environment.Exit(0); break;
                    default: Console.WriteLine("Invalid Input"); break;
                }

            }
        }
        private static void AddProduct()
        {
            var FISConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (var Connection = new SqlConnection(FISConnectionString))
            {
                try
                {
                    Console.WriteLine("enter Product Id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter Product Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("enter Product Price");
                    int price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter Product Description");
                    string description = Console.ReadLine();

                    Console.WriteLine("enter Product Availability");
                    string IsActive = Console.ReadLine();

                    var query = $"insert into Products values({id}, '{name}', {price}, '{description}', '{ IsActive}')";
                    var Command = new SqlCommand(query, Connection);
                    Connection.Open();
                    int Rows = Command.ExecuteNonQuery();

                    Console.WriteLine($"{Rows} affected");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        private static void SearchProduct()
        {
            var FISConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (var Connection = new SqlConnection(FISConnectionString))
            {
                try
                {

                    Console.WriteLine("Enter Product Id to serach");
                    int id = Convert.ToInt32(Console.ReadKey());

                    var query = $"Search from Products where id ={id}";
                    var command = new SqlCommand(query, Connection);


                   
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }

        public static void DeleteProduct()
        {
            var FISConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (var Connection = new SqlConnection(FISConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter Product Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                 
                    var query = $"delete from products where id={id}";
                    var Command = new SqlCommand(query, Connection);
                    Connection.Open();
                    int Rows = Command.ExecuteNonQuery();
                    Console.WriteLine($"{Rows} affected");


                   
                }
                catch(SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Connection.Close();
                }
            }
        }
        private static void DisplayProductDisconnected()
        {
            
            
                try
                {
                var FISConnection = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                var Query = "select * from Products";
                var Adapter = new SqlDataAdapter(Query, FISConnection);

                var DataSetObj = new DataSet("ProductDB");
                Adapter.Fill(DataSetObj, "Products");

                Console.WriteLine($"Data set name = {DataSetObj.DataSetName}");
                Console.WriteLine($"Table count = {DataSetObj.Tables.Count}");
                Console.WriteLine($"Table name = {DataSetObj.Tables[0].TableName}");
                Console.WriteLine($"Rows Count = {DataSetObj.Tables[0].Rows.Count}");
                Console.WriteLine($"Columns Count = {DataSetObj.Tables[0].Columns.Count}");

                DataTable table = DataSetObj.Tables["products"];
                foreach (DataColumn column in table.Columns)
                    Console.WriteLine(column.ColumnName + "\t");

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine();
                    for (int Index = 0; Index < table.Columns.Count; Index++)
                        Console.WriteLine(row[Index] + "\t");

                }
                Console.WriteLine();

            }
                catch(SqlException ex)
                {
                    Console.WriteLine("ex.Message");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ex.Message");
                }
               
        }
    }
    }
        
    
