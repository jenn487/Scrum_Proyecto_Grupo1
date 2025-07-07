using System.Data;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class Ne_users
    {
        Dt_users objd = new Dt_users();

        public DataTable N_user(En_Usuarios obje)
        {
            return objd.D_user(obje);
        }
    }
}
