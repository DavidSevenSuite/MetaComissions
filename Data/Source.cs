using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Data
{
    public class Source
    {

        public static void Main(string DataSource)
        {
            // Esta funcion sirve para crear la BD y la tabla de clientes desde el backend para evitar crearla manualmente

            string ServerName = DataSource;
            string dbName = "METACOMISIONS";
            string tableName = "METACLIE";
            string ConnectionStr = $"Server={ServerName};Integrated Security=True;";
            
            // Crear BD si no existe
            using (SqlConnection masterConnection = new SqlConnection(ConnectionStr))
            {
                masterConnection.Open();

                // Verificar si la base de datos existe
                string DbQuery = $"SELECT db_id('{dbName}')";
                using (SqlCommand comando = new SqlCommand(DbQuery, masterConnection))
                {
                    var result = comando.ExecuteScalar();
                    if(result == DBNull.Value)
                    {
                        string CreateDB = $"CREATE DATABASE {dbName} ";
                        using (SqlCommand CreateDBComand = new SqlCommand(CreateDB, masterConnection))
                        {
                            CreateDBComand.ExecuteNonQuery();
                        }
                    }
                }
            }

            // Crear Tabla si no existe

            string ConnectionString2 = $"Server={ServerName};DataBase={dbName};Integrated Security=True;";

            using (SqlConnection dbConnection = new SqlConnection(ConnectionString2))
            {
                dbConnection.Open();

                // Verificar si la tabla existe
                string checkTable = $@"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}')
                BEGIN
                    CREATE TABLE {tableName} (
                        Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
                        Nombre_clie NVARCHAR(1000) NOT NULL,
                        Telefono INT NOT NULL,
                        Correo NVARCHAR(100) NOT NULL,
                        Identificacion INT,
                        Arti_vendi NVARCHAR(1000),
                        Referencia NVARCHAR(1000),
                        Comision BIT
                    )
                END";

                using (SqlCommand comando2 = new SqlCommand(checkTable, dbConnection))
                {
                    comando2.ExecuteNonQuery();
                }
            }

            // Hacer update al objeto
            ConnectionString.DataBase = dbName;
        }
        
    }
}
