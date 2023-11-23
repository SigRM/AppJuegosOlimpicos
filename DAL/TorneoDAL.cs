using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class TorneoDAL
    {
        private static readonly log4net.ILog _log =
log4net.LogManager.GetLogger("MyControlEventos");
        //CRUD: Create Read Update Delete
        // Create
        public void Create(Torneo torneo)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Torneo]
           ([Torneo_Id]
           ,[Torneo_Nombre]
           ,[Promotora]
           ,[FechaInicio]
           ,[FechaFinal]
           ,[CostoCRC]
           ,[CostoUSD]
           ,[Estado]
           ,[Correo])
     VALUES
           (@Torneo_Id, int,
           ,@Torneo_Nombre, varchar(255),
           ,@Promotora, varchar(100),
           ,@FechaInicio, date,
           ,@FechaFinal, date,
           ,@CostoCRC, money,
           ,@CostoUSD, money,
           ,@Estado, bit,
           ,@Correo, varchar(100))";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@id", torneo.Torneo_Id);
                    comando.Parameters.AddWithValue("@name", torneo.Torneo_Nombre);
                    comando.Parameters.AddWithValue("@enabled", torneo.Promotora);
                    comando.Parameters.AddWithValue("@id", torneo.FechaInicio);
                    comando.Parameters.AddWithValue("@name", torneo.FechaFinal);
                    comando.Parameters.AddWithValue("@enabled", torneo.CostoCRC);
                    comando.Parameters.AddWithValue("@id", torneo.CostoUSD);
                    comando.Parameters.AddWithValue("@name", torneo.Estado);
                    comando.Parameters.AddWithValue("@enabled", torneo.Correo);
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

        public void Update(Torneo torneo)
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
                    string sql = @"UPDATE [dbo].[Torneo]
   SET [Torneo_Id] = @Torneo_Id
      ,[Torneo_Nombre] = @Torneo_Nombre
      ,[Promotora] = @Promotora
      ,[FechaInicio] = @FechaInicio
      ,[FechaFinal] = @FechaFinal
      ,[CostoCRC] = @CostoCRC
      ,[CostoUSD] = @CostoUSD
      ,[Estado] = @Estado
      ,[Correo] = @Correo
                             WHERE [Torneo_Id] = @Torneo_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@id", torneo.Torneo_Id);
                    comando.Parameters.AddWithValue("@name", torneo.Torneo_Nombre);
                    comando.Parameters.AddWithValue("@enabled", torneo.Promotora);
                    comando.Parameters.AddWithValue("@id", torneo.FechaInicio);
                    comando.Parameters.AddWithValue("@name", torneo.FechaFinal);
                    comando.Parameters.AddWithValue("@enabled", torneo.CostoCRC);
                    comando.Parameters.AddWithValue("@id", torneo.CostoUSD);
                    comando.Parameters.AddWithValue("@name", torneo.Estado);
                    comando.Parameters.AddWithValue("@enabled", torneo.Correo);
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
        public void Delete(Torneo torneo)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"DELETE FROM [dbo].[Torneo]
                                WHERE [Torneo_Id] = @Torneo_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Torneo_Id", torneo.Torneo_Id);

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

        public List<Torneo> ReadAll()
        {
            try
            {
                var list = new List<Torneo>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT Torneo_Id
      ,Torneo_Nombre
      ,Promotora
      ,FechaInicio
      ,FechaFinal
      ,CostoCRC
      ,CostoUSD
      ,Estado
      ,Correo
  FROM dbo.Torneo";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Torneo torneo = new Torneo();
                        torneo.Torneo_Id = Convert.ToInt32(reader["Id"]);
                        torneo.Torneo_Nombre = reader["Nombre"].ToString();
                        torneo.Promotora =reader["Promotora"].ToString();
                        torneo.FechaInicio = Convert.ToDateTime(reader["Inicio"]);
                        torneo.FechaFinal = Convert.ToDateTime(reader["Final"]);
                        torneo.CostoCRC = Convert.ToDouble(reader["CRC"]);
                        torneo.CostoUSD = Convert.ToDouble(reader["USD"]);
                        torneo.Estado = Convert.ToBoolean(reader["Estado"]);
                        torneo.Correo= reader["Correo"].ToString();
                        list.Add(torneo);
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

        public Torneo ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT Torneo_Id
      ,Torneo_Nombre
      ,Promotora
      ,FechaInicio
      ,FechaFinal
      ,CostoCRC
      ,CostoUSD
      ,Estado
      ,Correo
  FROM dbo.Torneo where Torneo_Id = @Torneo_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Id", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Torneo torneo = new Torneo();
                        torneo.Torneo_Id = Convert.ToInt32(reader["Id"]);
                        torneo.Torneo_Nombre = reader["Nombre"].ToString();
                        torneo.Promotora = reader["Promotora"].ToString();
                        torneo.FechaInicio = Convert.ToDateTime(reader["Inicio"]);
                        torneo.FechaFinal = Convert.ToDateTime(reader["Final"]);
                        torneo.CostoCRC = Convert.ToDouble(reader["CRC"]);
                        torneo.CostoUSD = Convert.ToDouble(reader["USD"]);
                        torneo.Estado = Convert.ToBoolean(reader["Estado"]);
                        torneo.Correo = reader["Correo"].ToString();
                        return torneo;
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
