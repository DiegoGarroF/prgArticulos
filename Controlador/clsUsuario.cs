using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
namespace Controlador
{
    public class clsUsuario
    {

        #region Atributos

        // Permite las sentencias del sql Transact
        private string strSentencia;

        // Permite enviar la ejecusion de la sentencia del modelo 
        clsConexionSQL conexion = new clsConexionSQL();
        #endregion
        #region Metodos

        // Metodo para accesar al sistema
        public SqlDataReader mConsultarUsu(Modelo.clsConexionSQL cone,Modelo.clsEntidadUsuario pEntidadUsuario)
        {
            strSentencia = "Select * from TBUsuarios where codigo='"+pEntidadUsuario.getCodigo()+"'and clave='"+pEntidadUsuario.getClave()+"'";

            return conexion.mSeleccionar(strSentencia,cone);
        }
        #endregion
    }
}
