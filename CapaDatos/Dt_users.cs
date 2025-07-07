using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos 
{
    public class Dt_users
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable D_user(En_Usuarios obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logueo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Usuario", obje.Usuario);
            cmd.Parameters.AddWithValue("@Clave", obje.Clave);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}
