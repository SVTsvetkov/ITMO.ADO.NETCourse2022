using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Net.Mime;

namespace ControlTask
{
    public class CategoryRepository
    {
        private string _connectionString;
        public CategoryRepository(string login, string password)
        {
            var sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                AttachDBFilename = $"{System.AppDomain.CurrentDomain.BaseDirectory}northwnd.mdf",
                Password = password,
                UserID = login,

            };
            _connectionString = sqlBuilder.ConnectionString;
        }

        public CategoryRepository()
        {
            var sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                IntegratedSecurity = true,
                AttachDBFilename = $"{System.AppDomain.CurrentDomain.BaseDirectory}northwnd.mdf"
            };
            _connectionString = sqlBuilder.ConnectionString;
        }

        public List<Category> GetAll()
        {
            List<Category> result = new List<Category>();
                       
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {             
                connection.Open();

                SqlCommand selectCommand = new SqlCommand(
                    $@"SELECT TOP (1000) [CategoryID] 
                        ,[CategoryName]  
                        ,[Description]                   
                    FROM Categories",
                    connection);
                using (SqlDataReader rdr = selectCommand.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var category = new Category()
                        {
                            CategoryID = rdr["CategoryID"].ToString(),
                            CategoryName = rdr["CategoryName"].ToString(),
                            Description = rdr["Description"].ToString(),
                        };

                        result.Add(category);
                    }
                    return result;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateCategory(Category categoryToSave)
        {
            var savedCategories = GetAll();
            var savedCategory = savedCategories.FirstOrDefault(c => c.CategoryID == categoryToSave.CategoryID);
            if (savedCategory != null)
            {
                if (savedCategory.CategoryName != categoryToSave.CategoryName || savedCategory.Description != categoryToSave.Description)
                {
                    SqlConnection connection = new SqlConnection(_connectionString);
                    try
                    {                      
                        connection.Open();
                        string updateSql = @"UPDATE Categories
                                                SET [CategoryName] = @CategoryName
                                                    ,[Description] = @Description
                                                WHERE CategoryId = @CategoryId";

                        SqlCommand updateCommand = new SqlCommand(updateSql, connection);
                        updateCommand.Parameters.AddWithValue("@CategoryName", categoryToSave.CategoryName);
                        updateCommand.Parameters.AddWithValue("@Description", categoryToSave.Description);
                        updateCommand.Parameters.AddWithValue("@CategoryId", savedCategory.CategoryID);
                        updateCommand.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw;
                    }
                    finally
                    {                     
                        connection.Close();
                    }
                }
            }

        }

        public string AddCategory(Category categoryToAdd)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            try
            {             
                connection.Open();

                string insertSql = @"INSERT INTO Categories 
                                (CategoryName, Description) 
                                VALUES (@CategoryName, @Description) 
                                SELECT SCOPE_IDENTITY()";

                SqlCommand insertCommand = new SqlCommand(insertSql, connection);
                insertCommand.Parameters.AddWithValue("@CategoryName", categoryToAdd.CategoryName);
                insertCommand.Parameters.AddWithValue("@Description", categoryToAdd.Description);
                var insertedId = insertCommand.ExecuteScalar().ToString();
                return insertedId;
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {             
                connection.Close();
            }
        }
        public bool DeleteCategory(Category category)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {             
                connection.Open();

                string deleteSql = @"DELETE FROM Categories 
                                    WHERE CategoryId = @CategoryId";

                SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);
                deleteCommand.Parameters.AddWithValue("@CategoryId", category.CategoryID);
                deleteCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {             
                connection.Close();
            }

            return true;
        }
    }
}
