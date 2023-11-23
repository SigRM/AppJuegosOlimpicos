using AppJuegoOlimpico.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class SexoDAL
    {
        private static readonly log4net.ILog _log =
         log4net.LogManager.GetLogger("MyControlEventos");

        public Sexo ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"select Codigo,Nombre from dbo.Category where Codigo=@Codigo";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Codigo", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Sexo sexo = new Sexo();
                        sexo.Codigo = Convert.ToChar(reader["Codigo"]);
                        sexo.Nombre = reader["Nombre"].ToString();                    
                        return sexo;
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

        public void Create(Sexo sexo)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Sexo]
                                   ([Codigo]
                                   ,[Nombre]
                             VALUES
                                   (@Codigo
                                   ,@Nombre)";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Codigo", sexo.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", sexo.Nombre);
            
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

        public void Update(Sexo sexo)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();

                    string sql = @"UPDATE [dbo].[Sexo]
                               SET [Nombre] = @Nombre
                             WHERE [Codigo] = @Codigo";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Codigo", sexo.Codigo);
                    comando.Parameters.AddWithValue("@Nombre", sexo.Nombre);
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

        public List<Sexo> ReadAll()
        {
            try
            {
                var list = new List<Sexo>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"select Codigo, Nombre from dbo.Sexo";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Sexo sexo = new Sexo();
                        sexo.Codigo = Convert.ToChar(reader["Codigo"]);
                        sexo.Nombre = reader["Nombre"].ToString();
                        list.Add(sexo);
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
    }
}
