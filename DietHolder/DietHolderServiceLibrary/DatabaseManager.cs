using System.Data;
using System.Data.SqlClient;

namespace DietHolderServiceLibrary
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly SqlConnectionStringBuilder connectionStringBuilder;
        public DatabaseManager()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder
            {
                AttachDBFilename = @"C:\Users\Tomasz\Documents\ProductsDatabase.mdf",
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                IntegratedSecurity = true,
                ConnectTimeout = 30
            };
        }
        public DataTable ShowAllPositionsFromTableProducts()
        {
            var productsTable = new DataTable();

            using(var sqlConnection = new SqlConnection(connectionStringBuilder.ToString()))
            {
                sqlConnection.Open();

                using(var sqlCommand = new SqlCommand(
                           "SELECT id AS ID, name AS Produkt, protein_value AS Białko, " +
                           "carbohydrates_value AS Węglowodany, fat_value AS Tłuszcze, " +
                           "calorific AS Calories FROM Products ",
                           sqlConnection))
                {
                    var dataReader = sqlCommand.ExecuteReader();
                    productsTable.Load(dataReader);
                }
            }
            return productsTable;
        }
        public DataTable SearchProduct(DataToInteractWithDatabase interactWithDatabase)
        {
            var productsTable = new DataTable("Products");

            using(var sqlConnection = new SqlConnection(connectionStringBuilder.ToString()))
            {
                sqlConnection.Open();

                using(var sqlCommand = new SqlCommand(
                            "SELECT id AS ID, name AS Produkt, protein_value AS Białko, " +
                            "carbohydrates_value AS Węglowodany, fat_value AS Tłuszcze, " +
                            "calorific AS Calories FROM Products WHERE name LIKE @name",
                            sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", "%" + interactWithDatabase.ProductName + "%");

                    var dataReader = sqlCommand.ExecuteReader();
                    productsTable.Load(dataReader);
                }
            }
            return productsTable;
        }
        public void InsertProduct(Product product)
        {
            using(var sqlConnection = new SqlConnection(connectionStringBuilder.ToString()))
            {
                using(var sqlCommand = new SqlCommand(
                    "INSERT INTO [Products] (id,name,protein_value,carbohydrates_value,fat_value,calorific) " +
                    "VALUES (@id,@name,@protein_value,@carbohydrates_value,@fat_value,@calorific)",
                    sqlConnection))
                {
                    var productsTable = ShowAllPositionsFromTableProducts();
                    sqlCommand.Parameters.AddWithValue("@id", OptimizeTableIdRecords(productsTable));
                    sqlCommand.Parameters.AddWithValue("@name", product.ProductName);
                    sqlCommand.Parameters.AddWithValue("@protein_value", product.ProductProteinValue);
                    sqlCommand.Parameters.AddWithValue("@carbohydrates_value", product.ProductCarboValue);
                    sqlCommand.Parameters.AddWithValue("@fat_value", product.ProductFatValue);
                    sqlCommand.Parameters.AddWithValue("@calorific",
                        GetProductCalorificValue(product.ProductFatValue, product.ProductProteinValue,
                            product.ProductCarboValue));

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        private static int OptimizeTableIdRecords(DataTable dataTable)
        {
            var isIdAssigned = false;
            var id = 0;

            for(int actualDataTableRow = 0; actualDataTableRow < dataTable.Rows.Count; actualDataTableRow++)
            {
                var cellValue = dataTable.Rows[actualDataTableRow]["id"];

                if((int)cellValue != actualDataTableRow)
                {
                    id = actualDataTableRow;
                    isIdAssigned = true;
                    break;
                }
            }

            if(isIdAssigned == false)
            {
                id = dataTable.Rows.Count;
            }
            return id;
        }
        private static double GetProductCalorificValue(double fat, double protein, double carbo)
        {
            var caloricValue = fat * 9 + protein * 4 + carbo * 4;
            return caloricValue;
        }
        public void UpdateProduct(Product product)
        {
            using(var sqlConnection = new SqlConnection(connectionStringBuilder.ToString()))
            {
                using(var sqlCommand = new SqlCommand(
                    "UPDATE [Products] Set " +
                    "protein_value = @protein_value," +
                    "carbohydrates_value = @carbohydrates_value ," +
                    "fat_value = @fat_value," +
                    "calorific = @calorific " +
                    "WHERE name = @name",
                    sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", product.ProductName);
                    sqlCommand.Parameters.AddWithValue("@protein_value", product.ProductProteinValue);
                    sqlCommand.Parameters.AddWithValue("@carbohydrates_value", product.ProductCarboValue);
                    sqlCommand.Parameters.AddWithValue("@fat_value", product.ProductFatValue);
                    sqlCommand.Parameters.AddWithValue("@calorific",
                        GetProductCalorificValue(product.ProductFatValue, product.ProductProteinValue,
                            product.ProductCarboValue));

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void DeleteProduct(DataToInteractWithDatabase dataToInteract)
        {
            using(var sqlConnection = new SqlConnection(connectionStringBuilder.ToString()))
            {
                using(var sqlCommand = new SqlCommand(
                    "DELETE FROM [Products] WHERE name = @name",
                    sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@name", dataToInteract.ProductName);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
