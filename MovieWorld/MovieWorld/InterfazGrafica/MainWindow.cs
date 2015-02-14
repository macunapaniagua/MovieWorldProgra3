using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWorld
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            lblTitulo.Parent = imgFondo;
            lblCrearCuenta.Parent = imgFondo;
            lblUsuario.Parent = imgFondo;

            pictureBox1.Parent = imgFondo;
        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            XmlHelper xml = new XmlHelper();
            
            if (xml.AgregarUsuario(new Usuario("Norlia", "asdf", "89517281", DateTime.Now)))
            {
                MessageBox.Show("Usuario Creado");
            }
            else
            {
                MessageBox.Show("El nombre de usuario ya existe");
            }
            //RegistroDeUsuarios registro = new RegistroDeUsuarios();
            //registro.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            XmlHelper xml = new XmlHelper();
            Usuario user = xml.ObtenerUsuario(txtUserName.Text);
            // Verifica si el usuario existe o no en el sistema
            if (user == null)
            {
                MessageBox.Show(this, "El nombre de usuario no se encuentra registrado en el sistema", 
                    "Usuario inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario : " + user.NickName +
                                "\ncorreo : " + user.Email +
                                "\ntelefono : " + user.NumeroTelefono + 
                                "\nultimo inicio de sesion : " + user.UltimoInicioSesion.ToShortDateString().ToString());
            }
            // limpia el cuadro de texto del nickName
            txtUserName.Clear();
        }
    }
}
