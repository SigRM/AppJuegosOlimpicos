using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJuegoOlimpico.DAL
{
    class UsuariosDAL
    {
        private static readonly log4net.ILog _log =
log4net.LogManager.GetLogger("MyControlEventos");
        //CRUD: Create Read Update Delete
        // Create
        public void Create(Usuarios usuarios)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"INSERT INTO [dbo].[Usuarios]
            ([Id]
           [Usuario]
           ,[Contraseña]
           ,[NombreCompleto]
           ,[FotoUsuario]
           ,[CodigoRoles])
     VALUES
           (@Id
            ,@Usuario
           ,@Contraseña
           ,@NombreCompleto
           ,@FotoUsuario
           ,@CodigoRoles)";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Id", usuarios.Id);
                    comando.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", usuarios.Contraseña);
                    comando.Parameters.AddWithValue("@NombreCompleto", usuarios.NombreCompleto);
                    comando.Parameters.AddWithValue("@FotoUsuario", usuarios.FotoUsuario);
                    comando.Parameters.AddWithValue("@CodigoRoles", usuarios.CodigoRoles);
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

        public void Update(Usuarios usuarios)
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
                    string sql = @"UPDATE [dbo].[Usuarios]
   SET [Id] = @Id
[Usuario] = @Usuario
      ,[Contraseña] = @Contraseña
      ,[NombreCompleto] = @NombreCompleto
      ,[FotoUsuario] = @FotoUsuario
      ,[CodigoRoles] = @CodigoRoles
                             WHERE [Usuario] = @Usuario";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Id", usuarios.Id);
                    comando.Parameters.AddWithValue("@Usuario", usuarios.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", usuarios.Contraseña);
                    comando.Parameters.AddWithValue("@NombreCompleto", usuarios.NombreCompleto);
                    comando.Parameters.AddWithValue("@FotoUsuario", usuarios.FotoUsuario);
                    comando.Parameters.AddWithValue("@CodigoRoles", usuarios.CodigoRoles);
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
        public void Delete(Usuarios usuarios)
        {
            try
            {
                string cadena = FactoryConexion.CreateConnection();

                using (IDataBase db = FactoryDatabase.CreateDataBase(cadena))
                {
                    var comando = new SqlCommand();
                    string sql = @"DELETE FROM [dbo].[Usuarios]
                                WHERE   [Id] = @Id";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Usuario", usuarios.Usuario);

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

        public List<Usuarios> ReadAll()
        {
            try
            {
                var list = new List<Usuarios>();
                //string cadena = FactoryConexion.CreateConnection();
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT Id, Usuario
      ,Contraseña
      ,NombreCompleto
      ,FotoUsuario
      ,CodigoRoles
  FROM dbo.Usuarios";
                    comando.CommandText = sql;
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Usuarios usuarios = new Usuarios();
                        usuarios.Id = Convert.ToInt32(reader["Id"]);
                        usuarios.Usuario = reader["Name"].ToString();
                        usuarios.Contraseña = reader["Name"].ToString();
                        usuarios.NombreCompleto = reader["Name"].ToString();
                        if (reader["Photo"] != System.DBNull.Value)
                            usuarios.FotoUsuario = (byte[])reader["Photo"];
                 //      usuarios.CodigoRoles = new RolesDAL().ReadById(Convert.ToInt32(reader["CategoryId"]));
                        list.Add(usuarios);
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

        public Usuarios ReadById(int id)
        {
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var comando = new SqlCommand();
                    string sql = @"SELECT Id Usuario
      ,Contraseña
      ,NombreCompleto
      ,FotoUsuario
      ,CodigoRoles
  FROM dbo.Usuarios";
                    comando.CommandText = sql;
                    comando.Parameters.AddWithValue("@Id", id);
                    var reader = db.ExecuteReader(comando);
                    while (reader.Read())
                    {
                        Usuarios usuarios = new Usuarios();
                        usuarios.Id = Convert.ToInt32(reader["Id"]);
                        usuarios.Usuario = reader["Name"].ToString();
                        usuarios.Contraseña = reader["Name"].ToString();
                        usuarios.NombreCompleto = reader["Name"].ToString();
                        if (reader["Photo"] != System.DBNull.Value)
                            usuarios.FotoUsuario = (byte[])reader["Photo"];
                        //    usuarios.CodigoRoles = new RolesDAL().ReadById(Convert.ToInt32(reader["CategoryId"]));
                        return usuarios;
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
