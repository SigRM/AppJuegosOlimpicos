using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class PartidosDAL
    {
        private static readonly log4net.ILog _log =
log4net.LogManager.GetLogger("MyControlEventos");
        //CRUD: Create Read Update Delete
        // Create
        public void Create(Partidos partidos)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Partidos]
           ([Partido_id]
           ,[Equipo1_id]
           ,[Equipo2_id]
           ,[fecha]
           ,[Estado]
           ,[Set_Number]
           ,[Equipo1_Puntos]
           ,[Equipo2_Puntos])
     VALUES
           (@Partido_id
           ,@Equipo1_id
           ,@Equipo2_id
           ,@fecha
           ,@Estado
           ,@Set_Number
           ,@Equipo1_Puntos
           ,@Equipo2_Puntos)";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Partido_id]", partidos.Partido_id);
                    comando.Parameters.AddWithValue("@Equipo1_id", partidos.Equipo1_id);
                    comando.Parameters.AddWithValue("@Equipo2_id", partidos.Equipo2_id);
                    comando.Parameters.AddWithValue("@fecha", partidos.fecha);
                    comando.Parameters.AddWithValue("@Estado", partidos.Estado);
                    comando.Parameters.AddWithValue("@Set_Number", partidos.Set_Number);
                    comando.Parameters.AddWithValue("@Equipo1_Puntos", partidos.Equipo1_Puntos);
                    comando.Parameters.AddWithValue("@Equipo2_Puntos", partidos.Equipo2_Puntos);
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

        public void Update(Partidos partidos)
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
                    string sql = @"UPDATE [dbo].[Partidos]
   SET [Partido_id] = @Partido_id
      ,[Equipo1_id] = @Equipo1_id
      ,[Equipo2_id] = @Equipo2_id
      ,[fecha] = @fecha
      ,[Estado] = @Estado
      ,[Set_Number] = @Set_Number
      ,[Equipo1_Puntos] = @Equipo1_Puntos
      ,[Equipo2_Puntos] = @Equipo2_Puntos
                             WHERE [Partido_id]] = @Partido_id]";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Partido_id]", partidos.Partido_id);
                    comando.Parameters.AddWithValue("@Equipo1_id", partidos.Equipo1_id);
                    comando.Parameters.AddWithValue("@Equipo2_id", partidos.Equipo2_id);
                    comando.Parameters.AddWithValue("@fecha", partidos.fecha);
                    comando.Parameters.AddWithValue("@Estado", partidos.Estado);
                    comando.Parameters.AddWithValue("@Set_Number", partidos.Set_Number);
                    comando.Parameters.AddWithValue("@Equipo1_Puntos", partidos.Equipo1_Puntos);
                    comando.Parameters.AddWithValue("@Equipo2_Puntos", partidos.Equipo2_Puntos);
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

        //Delete
        public void Delete(Partidos partidos)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"DELETE FROM [dbo].[Partidos]
                                WHERE [Partido_id] = @Partido_id]";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Partido_id]", partidos.Partido_id);

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

        public List<Partidos> ReadAll()
        {
            try
            {
                var list = new List<Partidos>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT Partido_id
      ,Equipo1_id
      ,Equipo2_id
      ,fecha
      ,Estado
      ,Set_Number
      ,Equipo1_Puntos
      ,Equipo2_Puntos
  FROM dbo.Partidos";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Partidos partidos = new Partidos();
                        partidos.Partido_id= Convert.ToInt32(reader["Partido_id"]);
                        partidos.Equipo1_id = Convert.ToInt32(reader["Equipo1_id"]);
                        partidos.Equipo2_id = Convert.ToInt32(reader["Equipo2_id"]);
                        partidos.fecha = Convert.ToDateTime(reader["fecha"]);
                        partidos.Estado = Convert.ToBoolean(reader["Estado"]);
                        partidos.Set_Number = Convert.ToInt32(reader["Set_Number"]);
                        partidos.Equipo1_Puntos = Convert.ToInt32(reader["Equipo1_Puntos"]);
                        partidos.Equipo2_Puntos= Convert.ToInt32(reader["Equipo2_Puntos"]);

                        list.Add(partidos);
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

        public Partidos ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT Partido_id
      ,Equipo1_id
      ,Equipo2_id
      ,fecha
      ,Estado
      ,Set_Number
      ,Equipo1_Puntos
      ,Equipo2_Puntos
  FROM dbo.Partidos";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Id", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Partidos partidos = new Partidos();
                        partidos.Partido_id = Convert.ToInt32(reader["Partido_id"]);
                        partidos.Equipo1_id = Convert.ToInt32(reader["Equipo1_id"]);
                        partidos.Equipo2_id = Convert.ToInt32(reader["Equipo2_id"]);
                        partidos.fecha = Convert.ToDateTime(reader["fecha"]);
                        partidos.Estado = Convert.ToBoolean(reader["Estado"]);
                        partidos.Set_Number = Convert.ToInt32(reader["Set_Number"]);
                        partidos.Equipo1_Puntos = Convert.ToInt32(reader["Equipo1_Puntos"]);
                        partidos.Equipo2_Puntos = Convert.ToInt32(reader["Equipo2_Puntos"]);
                        return partidos;
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
