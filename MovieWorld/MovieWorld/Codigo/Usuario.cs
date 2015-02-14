using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorld
{
    class Usuario
    {

        private String nombre;
        private String apellido;
        private String nickName;
        private String genero;
        private String email;
        private String numeroTelefono;
        private String contraseña;
        private DateTime ultimoInicioSesion;

        /// <summary>
        /// Inicializa los valores del usuario
        /// </summary>
        /// <param name="pNick">Nombre de Usuario</param>
        /// <param name="pEmail">Correo electronico activo</param>
        /// <param name="pTelefono">Numero telefonico</param>
        /// <param name="pUltimaSesion">Ultima vez que inicio sesion en el sistema</param>
        public Usuario(String pNick, String pEmail, String pTelefono, DateTime pUltimaSesion)
        {
            nickName = pNick;
            email = pEmail;
            numeroTelefono = pTelefono;
            ultimoInicioSesion = pUltimaSesion;
        }

        /// <summary>
        /// Inicializa los valores del usuario
        /// </summary>
        /// <param name="pNick">Nombre de Usuario</param>
        /// <param name="pEmail">Correo electronico activo</param>
        /// <param name="pTelefono">Numero telefonico</param>
        public Usuario(String pNick, String pEmail, String pTelefono)
        {
            nickName = pNick;
            email = pEmail;
            numeroTelefono = pTelefono;
            ultimoInicioSesion = DateTime.Now;
        }

        /// <summary>
        /// Obtiene y establece el nombre del usuario
        /// </summary>
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene y establece los apellidos del usuario
        /// </summary>
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        /// <summary>
        /// Obtiene y establece el genero del usuario
        /// </summary>
        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        /// <summary>
        /// Obtiene y establece el numero telefonico del usuario
        /// </summary>
        public String NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }

        /// <summary>
        /// Obtiene y establece el correo electronico del usuario
        /// </summary>
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Obtiene y establece la fecha del ultimo inicio de sesion del usuario
        /// </summary>
        public DateTime UltimoInicioSesion
        {
            get { return ultimoInicioSesion; }
            set { ultimoInicioSesion = value; }
        }

        /// <summary>
        /// Obtiene y establece el nickname de usuario
        /// </summary>
        public String NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        /// <summary>
        /// Obtiene y establece la contraseña del usuario
        /// </summary>
        public String Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
    }
}
