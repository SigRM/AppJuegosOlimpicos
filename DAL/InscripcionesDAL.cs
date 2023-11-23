using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class InscripcionesDAL
    {
        private static readonly log4net.ILog _log =
log4net.LogManager.GetLogger("MyControlEventos");
        //CRUD: Create Read Update Delete
        // Create
        public void Create(Inscripciones inscripciones)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Inscripciones]
                                   ([Inscripcion_Id]
                                   ,[ModalidadPago],
                                   ,[MontoPagoCRC],
                                   ,[MontoPagoUSD],
                                   ,[FechaInscripcion],
                                   ,[TipoCambio],
                                   ,[Estado],
                                   ,[Torneo_Id],
                                   ,[Jugador_Id],
                                   ,[Correo])
                             VALUES
                                   (@Inscripcion_Id
                                   ,@MontoPagoCRC
                                   ,@MontoPagoUSD
                                   ,@FechaInscripcion
                                   ,@TipoCambio
                                   ,@Estado
                                   ,@Torneo_Id
                                   ,@Jugador_Id
                                   ,@Correo)";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Inscripcion_Id", inscripciones.Inscripcion_Id);
                    comando.Parameters.AddWithValue("@ModalidadPago", inscripciones.ModalidadPago);
                    comando.Parameters.AddWithValue("@MontoPagoCRC", inscripciones.MontoPagoCRC);
                    comando.Parameters.AddWithValue("@MontoPagoUSD", inscripciones.MontoPagoUSD);
                    comando.Parameters.AddWithValue("@FechaInscripcion", inscripciones.FechaInscripcion);
                    comando.Parameters.AddWithValue("@TipoCambio", inscripciones.TipoCambio);
                    comando.Parameters.AddWithValue("@Estado", inscripciones.Estado);
                    comando.Parameters.AddWithValue("@Torneo_Id", inscripciones.Torneo_Id);
                    comando.Parameters.AddWithValue("@Jugador_Id", inscripciones.Jugador_Id);
                    comando.Parameters.AddWithValue("@Correo", inscripciones.Correo);
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

        public void Update(Inscripciones inscripciones)
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
                    string sql = @"UPDATE [dbo].[Inscripciones]
   SET [ModalidadPago] = @ModalidadPago
      ,[MontoPagoCRC] = @MontoPagoCRC
      ,[MontoPagoUSD] = @MontoPagoUSD
      ,[FechaInscripcion] = @FechaInscripcion
      ,[TipoCambio] = @TipoCambio
      ,[Estado] = @Estado
      ,[Inscripcion_Id] = @Inscripcion_Id
      ,[Torneo_Id] = @Torneo_Id
      ,[Jugador_Id] = @Jugador_Id
      ,[Correo] = @Correo
                             WHERE [Inscripcion_Id] = @Inscripcion_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Inscripcion_Id", inscripciones.Inscripcion_Id);
                    comando.Parameters.AddWithValue("@ModalidadPago", inscripciones.ModalidadPago);
                    comando.Parameters.AddWithValue("@MontoPagoCRC", inscripciones.MontoPagoCRC);
                    comando.Parameters.AddWithValue("@MontoPagoUSD", inscripciones.MontoPagoUSD);
                    comando.Parameters.AddWithValue("@FechaInscripcion", inscripciones.FechaInscripcion);
                    comando.Parameters.AddWithValue("@TipoCambio", inscripciones.TipoCambio);
                    comando.Parameters.AddWithValue("@Estado", inscripciones.Estado);
                    comando.Parameters.AddWithValue("@Torneo_Id", inscripciones.Torneo_Id);
                    comando.Parameters.AddWithValue("@Jugador_Id", inscripciones.Jugador_Id);
                    comando.Parameters.AddWithValue("@Correo", inscripciones.Correo);
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
        public void Delete(Inscripciones inscripciones)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"DELETE FROM [dbo].[Inscripciones]
                                WHERE [Inscripciones_Id] = @Inscripciones_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Inscripciones_Id", inscripciones.Inscripcion_Id);

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

        public List<Inscripciones> ReadAll()
        {
            try
            {
                var list = new List<Inscripciones>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT ModalidadPago ,MontoPagoCRC ,MontoPagoUSD ,FechaInscripcion ,TipoCambio,Estado ,Inscripcion_Id ,Torneo_Id ,Jugador_Id,Correo FROM dbo.Inscripciones";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Inscripciones inscripciones = new Inscripciones();
                        inscripciones.Inscripcion_Id= Convert.ToInt32(reader["Id"]);
                        inscripciones.ModalidadPago = reader["Name"].ToString();
                        inscripciones.MontoPagoCRC = Convert.ToDouble(reader["Enabled"]);
                        inscripciones.MontoPagoUSD = Convert.ToDouble(reader["Id"]);
                        inscripciones.FechaInscripcion = Convert.ToDateTime(reader["Name"].ToString());
                        inscripciones.TipoCambio = Convert.ToDouble(reader["Enabled"]);
                        inscripciones.Estado = Convert.ToBoolean(reader["Id"]);
                     //   inscripciones.Torneo_Id = new TorneoDAL().ReadById(Convert.ToInt32(reader["Name"]));
                        inscripciones.Jugador_Id = new JugadorDAL().ReadById(Convert.ToInt32(reader["Enabled"]));
                        inscripciones.Correo= reader["Enabled"].ToString();
                        list.Add(inscripciones);
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

        public Inscripciones ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT ModalidadPago ,MontoPagoCRC ,MontoPagoUSD ,FechaInscripcion ,TipoCambio,Estado ,Inscripcion_Id ,Torneo_Id ,Jugador_Id,Correo FROM dbo.Inscripciones where Inscripcion_Id = @Inscripcion_Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Id", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Inscripciones inscripciones = new Inscripciones();
                        inscripciones.Inscripcion_Id = Convert.ToInt32(reader["Id"]);
                        inscripciones.ModalidadPago = reader["Name"].ToString();
                        inscripciones.MontoPagoCRC = Convert.ToDouble(reader["Enabled"]);
                        inscripciones.MontoPagoUSD = Convert.ToDouble(reader["Id"]);
                        inscripciones.FechaInscripcion = Convert.ToDateTime(reader["Name"].ToString());
                        inscripciones.TipoCambio = Convert.ToDouble(reader["Enabled"]);
                        inscripciones.Estado = Convert.ToBoolean(reader["Id"]);
                        inscripciones.Torneo_Id = new TorneoDAL().ReadById(Convert.ToInt32(reader["Name"]));
                        inscripciones.Jugador_Id = new JugadorDAL().ReadById(Convert.ToInt32(reader["Enabled"]));
                        inscripciones.Correo = reader["Enabled"].ToString();
                        return inscripciones;
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
