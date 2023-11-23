using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class JugadorDAL
    {
        private static readonly log4net.ILog _log =
        log4net.LogManager.GetLogger("MyControlEventos");


        //CRUD: Create Read Update Delete
        // Create
        public void Create(Jugador jugador)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Jugador]
           ([Jugador_Id]
           ,[Identificacion]
           ,[FotoCedula]
           ,[Jugador_Nombre]
           ,[Nacionalidad]          
           ,[FechaNacimiento]
           ,[Telefono]
           ,[CorreoElectronico]
           ,[Direccion]
           ,[CodigoEquipo]
           ,[CodigoSexo]
           ,[Estado])
     VALUES
           (@Jugador_Id,
           ,@Identificacion, 
           ,@FotoCedula,
           ,@Jugador_Nombre, 
           ,@Nacionalidad,          
           ,@FechaNacimiento,
           ,@Telefono, 
           ,@CorreoElectronico,
           ,@Direccion, 
           ,@CodigoEquipo,
           ,@CodigoSexo, 
           ,@Estado)";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Jugador_Id", jugador.Jugador_Id);
                    comando.Parameters.AddWithValue("@Identificacion", jugador.Identificacion);
                    comando.Parameters.AddWithValue("@FotoCedula", jugador.FotoCedula);
                    comando.Parameters.AddWithValue("@Jugador_Nombre", jugador.Jugador_Nombre);
                    comando.Parameters.AddWithValue("@Nacionalidad", jugador.Nacionalidad);                   
                    comando.Parameters.AddWithValue("@FechaNacimiento", jugador.FechaNacimiento);                  
                    comando.Parameters.AddWithValue("@Telefono", jugador.Telefono);
                    comando.Parameters.AddWithValue("@CorreoElectronico", jugador.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Direccion", jugador.Direccion);
                    comando.Parameters.AddWithValue("@CodigoEquipo", jugador.CodigoEquipo);
                    comando.Parameters.AddWithValue("@CodigoSexo", jugador.CodigoSexo.Codigo);
                    comando.Parameters.AddWithValue("@Estado", jugador.Estado);           
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

        public void Update(Jugador jugador)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"UPDATE [dbo].[Jugador]
                              SET [Jugador_Id] = @Jugador_Id
                                 ,[Identificacion] = @Identificacion, 
                                 ,[FotoCedula] = @FotoCedula, 
                                 ,[Jugador_Nombre] = @Jugador_Nombre,
                                 ,[Nacionalidad] = @Nacionalidad,                                
                                 ,[FechaNacimiento] = @FechaNacimiento, 
                                 ,[Telefono] = @Telefono, 
                                 ,[CorreoElectronico] = @CorreoElectronico,
                                 ,[Direccion] = @Direccion, 
                                 ,[CodigoEquipo] = @CodigoEquipo,
                                 ,[CodigoSexo] = @CodigoSexo,
                                 ,[Estado] = @Estado,
                            WHERE [Jugador_Id] = @Jugador_Id";

                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Jugador_Id", jugador.Jugador_Id);
                    comando.Parameters.AddWithValue("@Identificacion", jugador.Identificacion);
                    comando.Parameters.AddWithValue("@FotoCedula", jugador.FotoCedula);
                    comando.Parameters.AddWithValue("@Jugador_Nombre", jugador.Jugador_Nombre);
                    comando.Parameters.AddWithValue("@Nacionalidad", jugador.Nacionalidad);                  
                    comando.Parameters.AddWithValue("@FechaNacimiento", jugador.FechaNacimiento);
                    comando.Parameters.AddWithValue("@Telefono", jugador.Telefono);
                    comando.Parameters.AddWithValue("@CorreoElectronico", jugador.CorreoElectronico);
                    comando.Parameters.AddWithValue("@Direccion", jugador.Direccion);
                    comando.Parameters.AddWithValue("@CodigoEquipo", jugador.CodigoEquipo);
                    comando.Parameters.AddWithValue("@CodigoSexo", jugador.CodigoSexo.Codigo);
                    comando.Parameters.AddWithValue("@Estado", jugador.Estado);
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

        public void Delete(Jugador jugador)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();

                    string sql = @"DELETE FROM [dbo].[Jugador]
                               WHERE [Jugador_Id] = @Jugador_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Jugador_Id", jugador.Jugador_Id);

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

        public List<Jugador> ReadAll()
        {
            try
            {
                List<Jugador> list = new List<Jugador>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"Select Jugador_Id, Identificacion, FotoCedula, Jugador_Nombre, Nacionalidad, FechaNacimiento, 
                                          , Telefono, CorreoElectronico, Direccion, CodigoEquipo,CodigoSexo,Estado from dbo.Jugador";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Jugador jugador = new Jugador();
                        jugador.Jugador_Id = Convert.ToInt32(reader["Jugador_Id"]);
                        jugador.Identificacion = reader["Identificacion"].ToString();
                        jugador.FotoCedula = (byte[])(reader["FotoCedula"]);
                        jugador.Jugador_Nombre = reader["Jugador_Nombre"].ToString();
                       // jugador.Nacionalidad = reader["Nacionalidad"].ToString();                      
                        jugador.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        jugador.Telefono = reader["Telefono"].ToString();
                        jugador.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        jugador.Direccion = reader["Direccion"].ToString();
                        jugador.CodigoEquipo = Convert.ToInt32(reader["CodigoEquipo"]);
                        jugador.CodigoSexo = new SexoDAL().ReadById(Convert.ToChar(reader["CodigoSexo"]));
                        jugador.Estado = Convert.ToBoolean(reader["Estado"]);
                        list.Add(jugador);
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

        public Jugador ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"Select Jugador_Id,Identificacion,FotoCedula Jugador_Nombre, Nacionalidad,FechaNacimiento,Telefono,CorreoElectronico, 
                                          Direccion,CodigoEquipo,CodigoSexo,Estado from dbo.Category";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Jugador_Id", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Jugador jugador = new Jugador();
                        jugador.Jugador_Id = Convert.ToInt32(reader["Jugador_Id"]);
                        jugador.Identificacion = reader["Identificacion"].ToString();
                        jugador.FotoCedula = (byte[])(reader["FotoCedula"]);
                        jugador.Jugador_Nombre = reader["Jugador_Nombre"].ToString();
                        jugador.Nacionalidad = reader["Nacionalidad"].ToString();                   
                        jugador.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        jugador.Telefono = reader["Telefono"].ToString();
                        jugador.CorreoElectronico = reader["CorreoElectronico"].ToString();
                        jugador.Direccion = reader["Direccion"].ToString();
                        jugador.CodigoEquipo = Convert.ToInt32(reader["CodigoEquipo"].ToString());
                        jugador.CodigoSexo = new SexoDAL().ReadById(Convert.ToChar(reader["CodigoSexo"]));
                        jugador.Estado = Convert.ToBoolean(reader["Estado"]);
                        return jugador;
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
