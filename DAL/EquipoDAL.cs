using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class EquipoDAL
    {
        private static readonly log4net.ILog _log =
          log4net.LogManager.GetLogger("MyControlEventos");


        //CRUD: Create Read Update Delete
        // Create
        public void Create(Equipo equipo)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Equipo]
                                 ([Equipo_Id]
                                  ,[Equipo_Nombre]
                                  ,[Estado])
                          VALUES
                                 (@Equipo_Id,
                                  @Equipo_Nombre,
                                  @Estado)";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Equipo_Id", equipo.Equipo_Id);
                    comando.Parameters.AddWithValue("@Equipo_Nombre", equipo.Equipo_Nombre);
                    comando.Parameters.AddWithValue("@Estado", equipo.Estado);
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                _log.Error(msg);
                throw new ApplicationException("Error. Contacte a soporte!");
            }
            catch (Exception ex)
            {
                _log.Error("Error en DAL.Create", ex);
                throw ex;
            }
        }

        public void Update(Equipo equipo)
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
                    string sql = @"UPDATE [dbo].[Equipo]
                               SET [Equipo_Nombre] = @Equipo_Nombre, 
                                  ,[Estado] = @Estado,
                             WHERE [Equipo_Id] = @Equipo_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Equipo_Id", equipo.Equipo_Id);
                    comando.Parameters.AddWithValue("@Equipo_Nombre", equipo.Equipo_Nombre);
                    comando.Parameters.AddWithValue("@Estado", equipo.Estado);
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                _log.Error(msg);
                throw new ApplicationException("Error. Contacte a soporte!");
            }
            catch (Exception ex)
            {
                _log.Error("Error en DAL.Update", ex);
                throw ex;
            }
        }

        public void Delete(Equipo equipo)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"DELETE FROM [dbo].[Equipo]
                                   WHERE [Equipo_Id] = @Equipo_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Equipo_Id", equipo.Equipo_Id);

                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                _log.Error(msg);
                throw new ApplicationException("Error. Contacte a soporte!");
            }
            catch (Exception ex)
            {
                _log.Error("Error en DAL.Delete", ex);
                throw ex;
            }
        }

        public List<Equipo> ReadAll()
        {
            try
            {
                var list = new List<Equipo>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"select Equipo_Id, Equipo_Nombre, Estado from dbo.Equipo";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Equipo equipo = new Equipo();
                        equipo.Equipo_Id = Convert.ToInt32(reader["Equipo_Id"]);
                        equipo.Equipo_Nombre = reader["Equipo_Nombre"].ToString();
                        equipo.Estado = Convert.ToBoolean(reader["Estado"]);
                        list.Add(equipo);
                    }
                    return list;
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                _log.Error(msg);
                throw new ApplicationException("Error. Contacte a soporte!");
            }
            catch (Exception ex)
            {
                _log.Error("Error en DAL.ReadAll", ex);
                throw ex;
            }

        }
       
        public Equipo ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"Select Equipo_Id, Equipo_Nombre, Estado from dbo.Equipo where Equipo_Id=@Equipo_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Equipo_Id", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Equipo category = new Equipo();
                        category.Equipo_Id = Convert.ToInt32(reader["Equipo_Id"]);
                        category.Equipo_Nombre = reader["Equipo_Nombre"].ToString();
                        category.Estado= Convert.ToBoolean(reader["Estado"]);
                        return category;
                    }
                    return null;
                }
            }
            catch (SqlException sqlEx)
            {
                string msg = UtilError.CreateSQLExceptionsErrorDetails(sqlEx);
                _log.Error(msg);
                throw new ApplicationException("Error. Contacte a soporte!");
            }
            catch (Exception ex)
            {
                _log.Error("Error en DAL.ReadById", ex);
                throw ex;
            }

        }
    }
}
