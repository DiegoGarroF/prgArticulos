using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;// Permite hacer las conexiones con la base de datos
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// El llamo de las referencias propias del proyecto
using System.Data.SqlClient;
using Modelo;
using Controlador;


// espacio donde se encuentra la ventana
namespace prgArticulos
{
    public partial class frmAcceso : Form
    {
        #region
        clsConexionSQL conexion;
        clsEntidadUsuario pEntidadUsuario;
        clsUsuario usuario;
        SqlDataReader dtrUsuario;// Este es para el retorno de las tuplas 
        int intContador ;
        #endregion
        // Inicializamos los atributos que utilizaremos 
        public frmAcceso()
        {
            intContador = 0;
            conexion = new clsConexionSQL();
            pEntidadUsuario = new clsEntidadUsuario();
            usuario = new clsUsuario();
            InitializeComponent();
        }


        private void frmAcceso_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {


            Application.Exit();
        }

        private void txCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
                {
                // El Evento Focus hace unn traslado del cursor al indicado
                this.txClave.Focus();
            }
        }

        // Fin del key press de Usuario
        private void txClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (mValidarDatos() == true)
                {
                    this.btnIngresar.Enabled = true;
                }
                else
                {

                }
            }
        }// Fin del metodo key press clave


        #region Metodos
        // Este metodo se encarga de verificar la existencia del usario segun el codigo y la clave digitada
        private Boolean mValidarDatos()
        {
            if (intContador <= 2)
            {
                // llenado de los atributos del servidor para conectar,e a la base de datos
                conexion.setCodigo("admEstudiantes");
                conexion.setClave("123");
                // Llenado de los atributos de la clase EntidadUsuario
                pEntidadUsuario.setCodigo(this.txCodigo.Text.Trim());
                pEntidadUsuario.setClave(this.txClave.Text.Trim());

                // Consultamos si el usuario existe
                dtrUsuario = usuario.mConsultarUsu(conexion, pEntidadUsuario);

                // Evaluo si retorna tuplas o datos
                if (dtrUsuario != null)
                {
                    if (dtrUsuario.Read())
                    {
                        pEntidadUsuario.setPerfil(dtrUsuario.GetString(2));
                        pEntidadUsuario.setEstado(dtrUsuario.GetInt32(3));
                        if (pEntidadUsuario.getEstado() == 0)
                        {
                            this.btnIngresar.Enabled = true;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("El Usuario esta Bloqueado", "Atenciuon", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            return false;
                        }// Fin del pEntidad

                    }
                    else
                    {
                        MessageBox.Show("El Usuario No Existe", "Atencion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return false;
                    }// Fin del if del read 
                }
                else {
                    MessageBox.Show("El usuario no existe", "Atencion", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }// fin del if del null

            }else {
                MessageBox.Show("Usted digito 3 veces  su usuario de forma incorrecta","Usuario Bloqueado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }// Fin del if del contador
            
        }// fin del metodo validar usuario
        #endregion

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);// oculta el login
            mdiMenu menu = new mdiMenu(conexion);
            menu.Show();
        }
    } }
