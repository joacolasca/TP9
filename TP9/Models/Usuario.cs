using System.Collections.Generic;
using System.Data.SqlClient;

namespace TP9;
public class Usuario
{
    public int Id_Usuario {get; set;}
    public string UserName {get;set;}
    public string Contraseña {get;set;}
    public string Nombre {get;set;}
    public string Email {get;set;}
    public int Telefono {get;set;}
}