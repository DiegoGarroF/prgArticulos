using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class clsEntidadUsuario
    {
        // Region para los atributos
        #region Atributos
        private string codigo;
        private string clave;
        private string perfil;
        private int estado;
        #endregion


        // Region para la propiedades 
        #region Propiedades
        // Inicio de los Metodos set
        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }
        public void setClave(string clave)
        {
            this.clave = clave;
        }
        public void setPerfil(string perfil)
        {
            this.perfil = perfil;
        }
        public void setEstado(int estado)
        {
            this.estado = estado;
        }
        // Fin de los Metodos set

        // Inicio de los Metodos Get
        public string getCodigo()
        {
            return this.codigo;
        }
        public string getClave()
        {
           return this.clave;
        }
        public string getPerfil()
        {
            return this.perfil;
        }
        public int getEstado()
        {
            return this.estado;
        }
        // Fin de los Metodos Get
        #endregion


        #region Constructor
        // Inicio del constructor
        public clsEntidadUsuario()
        {
            this.clave = "";
            this.codigo = "";
            this.perfil = "";
            this.estado = 0;
        }
        #endregion
        // fin del constructor
    }
}
