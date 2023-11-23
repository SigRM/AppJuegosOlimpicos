using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class RolesDAL
    {
        //CRUD: Create Read Update Delete
        // Create
        public void Create(Roles roles)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Roles]
                                 ([Codigo]
                                  ,[Nombre])
                          VALUES
                                 (@Codigo,
                                  @Nombre)";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Codigo", roles.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", roles.Nombre);               
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                throw new ApplicationException("Error. Contacte a soporte!");
            }

        }

        public void Update(Roles roles)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    //string sql = $@"UPDATE [dbo].[Category]
                    //               SET [Name] = '{category.Name}'
                    //                  ,[Enabled] = {(category.Enabled?"1":"0")}
                    //             WHERE [Id] = {category.Id}";
                    string sql = @"UPDATE [dbo].[Roles]
                               SET [Nombre] = @Nombre, 
                             WHERE [Codigo] = @Codigo";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Codigo", roles.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", roles.Nombre);
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                throw new ApplicationException("Error. Contacte a soporte!");
            }

        }

        public void Delete(Roles roles)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"DELETE FROM [dbo].[Roles]
                                   WHERE [Codigo] = @Codigo";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Codigo", roles.Codigo);

                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                throw new ApplicationException("Error. Contacte a soporte!");
            }

        }

        public List<Roles> ReadAll()
        {
            try
            {
                var list = new List<Roles>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"select Codigo,Nombre from dbo.Roles";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Roles roles = new Roles();
                        roles.Codigo = Convert.ToInt32(reader["Codigo"]);
                        roles.Nombre = reader["Nombre"].ToString();
                        list.Add(roles);
                    }
                    return list;
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                throw new ApplicationException("Error. Contacte a soporte!");
            }

        }

        public Equipo ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"Select Codigo, Nombre, from dbo.Roles where Codigo=@Codigo";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Codigo", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Roles roles = new Roles();
                        roles.Codigo = Convert.ToInt32(reader["Codigo"]);
                        roles.Nombre = reader["Nombre"].ToString();
                     //There was a return roles here
                    }
                    return null;
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                throw new ApplicationException("Error. Contacte a soporte!");
            }

        }
    }
}

