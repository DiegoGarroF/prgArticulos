using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// SE NECESITAN algunas otras bibliotecas para que se pueda establecert la conexion con sql
using System.Net;//Permite retornar de system de wimdows el nombre de la maquina
using System.Data.SqlClient;// accesos a la BD(IMEC) 

namespace Modelo
{
    public class clsConexionSQL
    {
        // aqui se escribe todo el codigo

        // Area de declaracion de las variables
        #region Atributos

        private string codigo;
        private string clave;
        private string perfil;
        private string baseDatos;

        private SqlConnection conexion; // Guarda la cadena de conexion del usuario con la base de datos 
        private SqlCommand comando; // Esta nos permite hacer , ejecutar los IMEC

    
        #endregion

        // Area del metodo inicial
        #region Constructor

        public clsConexionSQL()
    {
        this.codigo = "";
        this.clave = "";
        this.baseDatos = "BDEstudiantes";
        this.perfil = "";
    }

    #endregion

    // Propiedades de escritura y lectura
    #region Get y Set
            // codigo
        public void setCodigo(string codigo)
        {
            this.codigo = codigo.Trim();
        }
        public string getCodigo()
        {
            return this.codigo;
        }
        // Clave
        public void setClave(string clave)
        {
            this.clave = clave.Trim();
        }
        public string getClave()
        {
            return this.clave;
        }
        // Perfil
        public void setPerfil(string perfil)
        {
            this.perfil = perfil.Trim();
        }
        public string getPerfil()
        {
            return this.perfil;
        }
        #endregion

        // Metodos para la conexion con la base de datos
        #region Metodos 

        // Este metodo se encarga de poder ejecutrar los selects
        public SqlDataReader mSeleccionar(string strSentencia, clsConexionSQL cone)
        {
            try
            {
                // Aqui se necesita verificar que la coxion esta abierta para que se pueda ejecutar el data reader
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, conexion);// necesita dos parametros , la sentencia y la variable conexion
                    comando.CommandType = System.Data.CommandType.Text;
                    return comando.ExecuteReader();// perimite ejecutar la sentencia completamente y al mismo tiempo la envia
                    // el ExecuteReader ejecuta solo select
                }
                else
                    return null;
            } catch
            {
                return null;
            }
        }// Fin del metodo mSeleccionar

        // Este metodo permitira ejecutar los Insert,Update y Delete
        public Boolean mEjecutar(string strSentencia,clsConexionSQL cone)
        {
            try
            {
                if (mConectar(cone))
                {
                    comando = new SqlCommand(strSentencia, conexion);
                    comando.ExecuteReader();
                    return true;
                }
                else return false;
            } catch
            {
                return false;
            }

        }// fin del metodo mEjecutar


        // Este metodo nos permite abrir y conectarnos con la base de datos
        public Boolean mConectar(clsConexionSQL cone)
        {
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "user id='" + cone.getCodigo() + "'; password='"+cone.getClave()+"'; Data Source='"+mNombreServidor()+"'; Initial Catalog='"+this.baseDatos+"'";
                conexion.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }// fin del metodo mConectar


        // Este metodo me permite obtener el nombre de la maquina de wimdows
        public string mNombreServidor()
        {
            return Dns.GetHostName();
        }// fin del metodo mNombreServidor
        #endregion



    }
}
