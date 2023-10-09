using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using TP9.Models;

namespace TP9;

public static class BD
{   
    private static string _connectionString = @"Server=localhost;DataBase=BD_Login;Trusted_Connection=True;"; //cambiar a localhost

    public static void InsertarUsuario(Usuario Usu)
    {
        string SQL = "insert into Usuario (UserName, Contraseña, Nombre, Email, Telefono) values(@pUsername, @pContraseña, @pNombre, @pEmail, @pTelefono)";
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            DB.Execute(SQL, new {pUsername = Usu.UserName, pContraseña = Usu.Contraseña, pNombre = Usu.Nombre, pEmail = Usu.Email, pTelefono = Usu.Telefono});  
        }
    }

    public static Usuario ObtenerUsuario(string UserName, string Contraseña)
    {
        using (SqlConnection DB = new SqlConnection(_connectionString)){
        string SQL = "select * from Usuario where UserName = @pUsername and Contraseña = @pContraseña";
            return DB.QueryFirstOrDefault<Usuario>(SQL, new {pUsername = UserName, pContraseña = Contraseña});
        }
    }
    public static void CambiarContraseña(string UserName, string Contraseña)
    {
        string SQL = "update Usuario set Contraseña = @pContraseña where UserName like @pUsername";
        using (SqlConnection DB = new SqlConnection(_connectionString))
        {
            DB.Execute(SQL,new{pContraseña = Contraseña, pUsername = UserName});
        }
    }
}
 