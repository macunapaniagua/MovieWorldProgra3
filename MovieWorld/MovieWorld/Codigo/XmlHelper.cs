using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MovieWorld
{
    class XmlHelper
    {
        private String rutaXmlUsuarios;
        private String rutaXmlPeliculas;

        /// <summary>
        /// Inicializa las rutas donde se encuentran los XML
        /// </summary>
        public XmlHelper()
        {
            rutaXmlPeliculas = "ArchivosXML/Peliculas.xml";
            rutaXmlUsuarios = "ArchivosXML/Usuarios.xml";
        }         

        /// <summary>
        /// Busca y retorna un usuario en especifico
        /// </summary>
        /// <param name="pUserName">Nombre del Usuario buscado</param>
        /// <returns>El usuario que cumple con el userName o null si no existe</returns>
        public Usuario ObtenerUsuario(String pUserName)
        {
            // Verifica si el archivo no existe en el sistema
            if (!File.Exists(rutaXmlUsuarios))
            {
                return null;
            }
            else
            {
                XmlDocument docXML = new XmlDocument();
                docXML.Load(rutaXmlUsuarios);
                // Busca el usuario con la cadena XPath dada y verifica si existe o no
                XmlNode usuario = docXML.SelectSingleNode("/Usuarios/Usuario[@nickName='" + pUserName + "']");
                if (usuario == null)
                {
                    return null;
                }
                else
                {
                    String nick = usuario.Attributes["nickName"].Value;
                    String email = usuario["correo"].InnerText;
                    String telefono = usuario["telefono"].InnerText;
                    String fecha = usuario["ultimaSesion"].InnerText;
                    DateTime ultimaSesion = DateTime.ParseExact(fecha, "dd/MM/yyyy", null);
                    // Se crea el nuevo usuario y se retorna
                    return new Usuario(nick, email, telefono, ultimaSesion);
                }
            }
        }

        /// <summary>
        /// Insertra un usuario en el xml Usuarios
        /// </summary>
        /// <param name="pUser">Usuario a insertar</param>
        /// <returns>true si se inserta o false en caso contrario</returns>
        public Boolean AgregarUsuario(Usuario pUser)
        {
            if (!File.Exists(rutaXmlUsuarios))
            {
                return false;
            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(rutaXmlUsuarios);
                // Verifica si el usuario existe sino, para crearlo
                if (xmlDoc.SelectSingleNode("/Usuarios/Usuario[@nickName='" + pUser.NickName + "']") != null)
                {
                    return false;
                }
                else
                {
                    // Crea el nuevo usuario
                    XmlElement nuevoUsuario = xmlDoc.CreateElement("Usuario");
                    nuevoUsuario.SetAttribute("nickName", pUser.NickName);
                    // Correo
                    XmlElement correo = xmlDoc.CreateElement("correo");
                    correo.InnerText = pUser.Email;
                    // Telefono
                    XmlElement telefono = xmlDoc.CreateElement("telefono");
                    telefono.InnerText = pUser.NumeroTelefono;
                    // Ultima Sesion
                    XmlElement ultimaSesion = xmlDoc.CreateElement("ultimaSesion");
                    ultimaSesion.InnerText = pUser.UltimoInicioSesion.ToShortDateString();
                    // Agrega los hijos al NuevoNodo
                    nuevoUsuario.AppendChild(correo);
                    nuevoUsuario.AppendChild(telefono);
                    nuevoUsuario.AppendChild(ultimaSesion);
                    // Agrega el nuevo Usuario al XML
                    xmlDoc.DocumentElement.AppendChild(nuevoUsuario);
                    // Guarda el xml modificado
                    xmlDoc.Save(rutaXmlUsuarios);
                    return true;
                }
            }
        }
        




// SOLUCIONAR


        /// <summary>
        /// Obtiene una determinada pelicula, recibiendo por parametro el nombre de la misma
        /// </summary>
        /// <param name="numEmpleado"></param>
        public static void ObtenerPeliculas(String nombrePelicula)
        {
            //Creamos un documento y lo cargamos con los datos del XML.
            XmlDocument documento = new XmlDocument();
            documento.Load("product2.xml");

            //Obtenemos una colección con todos los Usuario.
            XmlNodeList listaPeli = documento.SelectNodes("Peliculas/Pelicula");

            //Creamos un único Usuario.
            XmlNode unaPeli;

            //Recorremos toda la lista de Usuario.
            for (int i = 0; i < listaPeli.Count; i++)
            {
                //Obtenemos cada Usuario.
                unaPeli = listaPeli.Item(i);

                //Seleccionamos el nombre del Usuario.
                String nomPelicula = unaPeli.SelectSingleNode("Nombre").InnerText;

                //Comprobamos que el id de Usuario sea el mismo que el número introducido por el usuario.
                if (nombrePelicula.Equals(nomPelicula))
                {
                    Console.WriteLine();

                    //Obtenemos el nombre.
                    Console.WriteLine("Nombre: {0}", unaPeli.SelectSingleNode("Nombre").InnerText);

                    //Obtenemos la duracion.
                    Console.WriteLine("Duracion: {0}", unaPeli.SelectSingleNode("Duracion").InnerText);

                    //Obtenemos la fechal.
                    Console.WriteLine("Fecha: {0}", unaPeli.SelectSingleNode("Fecha").InnerText);

                    //Obtenemos Cartel.
                    Console.WriteLine("Cartel: {0}", unaPeli.SelectSingleNode("Cartel").InnerText);

                    //Obtenemos trailer
                    Console.WriteLine("UrlTrailer: {0}", unaPeli.SelectSingleNode("UrlTrailer").InnerText);

                    //Obtenemos sinopsis.
                    Console.WriteLine("Sinopsis: {0}", unaPeli.SelectSingleNode("Sinopsis").InnerText);

                    //Obtenemos director.
                    Console.WriteLine("Director: {0}", unaPeli.SelectSingleNode("Director").InnerText);

                    //Obtenemos promedio.
                    Console.WriteLine("Valoracion Promedio: {0}", unaPeli.SelectSingleNode("ValoracionPromedio").InnerText);

                    //Obtenemos votantes.
                    Console.WriteLine("Votantes: {0}", unaPeli.SelectSingleNode("Votantes").InnerText);
                }
            }
        }
        
        /// <summary>
        /// Escribe el xml
        /// </summary>
        public static void EscribirXml(List<Usuario> usuario)
        {
            //Creamos el escritor.
            using (XmlTextWriter Writer = new XmlTextWriter("product.xml", Encoding.Unicode))
            {
                //Declaración inicial del Xml.
                Writer.WriteStartDocument();

                ////Configuración.
                //Writer.Formatting = Formatting.Indented;
                //Writer.Indentation = 5;

                //Escribimos el nodo principal.
                Writer.WriteStartElement("Usuarios");

                foreach (Usuario usu in usuario)
                {
                    //Escribimos un nodo Usuario.
                    Writer.WriteStartElement("Usuario");

                    //Escribimos cada uno de los elementos del nodo Usuario.
                    Writer.WriteElementString("Nombre", usu.NickName);
                    Writer.WriteElementString("Fecha", usu.UltimoInicioSesion.ToString());
                    Writer.WriteElementString("Email", usu.Email);
                    Writer.WriteElementString("Telefono", usu.NumeroTelefono);

                    //Cerramos el nodo y el documento.
                    Writer.WriteEndElement();
                }
                Writer.WriteEndDocument();
                Writer.Flush();
            }
        }

        /// <summary>
        /// Escribe el xml de las peliculas
        /// </summary>
        public static void EscribirXmlPeliculas(List<Pelicula> pelicula)
        {
            //Creamos el escritor.
            using (XmlTextWriter Writer = new XmlTextWriter("product2.xml", Encoding.Unicode))
            {
                //Declaración inicial del Xml.
                Writer.WriteStartDocument();

                //Escribimos el nodo principal.
                Writer.WriteStartElement("Peliculas");

                foreach (Pelicula peli in pelicula)
                {
                    //Escribimos un nodo Usuario.
                    Writer.WriteStartElement("Pelicula");

                    //Escribimos cada uno de los elementos del nodo Usuario.
                    Writer.WriteElementString("Nombre", peli.Nombre);
                    Writer.WriteStartElement("Generos");
                    foreach (string item in peli.Genero)
                    {
                        Writer.WriteElementString("Genero", item);
                    }
                    Writer.WriteEndElement();
                    Writer.WriteElementString("Duracion", peli.Duracion.ToString());
                    Writer.WriteElementString("Fecha", peli.FechaEstreno.ToString());
                    Writer.WriteElementString("Cartel", peli.Cartel);
                    Writer.WriteElementString("UrlTrailer", peli.UrlTrailer);
                    Writer.WriteElementString("Sinopsis", peli.Sinopsis);
                    Writer.WriteElementString("Director", peli.Director);
                    Writer.WriteStartElement("Actores");
                    foreach (string item in peli.Actores)
                    {
                        Writer.WriteElementString("Actor", item);
                    }
                    Writer.WriteEndElement();
                    Writer.WriteElementString("ValoracionPromedio", peli.ValoracionPromedio.ToString());
                    Writer.WriteElementString("Votantes", peli.CantidadVotantes.ToString());

                    //Cerramos el nodo y el documento.
                    Writer.WriteEndElement();
                }
                Writer.WriteEndDocument();
                Writer.Flush();
            }
        }
                
        /// <summary>
        /// Crea la pelicula y la inserta al final de la lista
        /// </summary>
        /// <returns>retorna el nodo al final de todo el xml</returns>
        private static XmlNode CrearNodoXmlPeli(List<Pelicula> peliculas)
        {
            XmlDocument documento = new XmlDocument();
            XmlElement Pelicula = documento.CreateElement("Pelicula");
            foreach (Pelicula peli in peliculas)
            {
                //Creamos un documento y lo cargamos con los datos del XML.
                documento = new XmlDocument();
                documento.Load("product2.xml");


                //Obtenemos el nodo raiz del documento.
                XmlNode nodoRaiz = documento.DocumentElement;


                //Creamos el nodo que deseamos insertar.
                Pelicula = documento.CreateElement("Pelicula");

                //Creamos el elemento nombre.
                XmlElement nom = documento.CreateElement("Nombre");
                nom.InnerText = peli.Nombre;
                Pelicula.AppendChild(nom);

                //Creamos el elemento nombre.
                XmlElement gene = documento.CreateElement("Genero");
                foreach (string item in peli.Genero)
                {
                    XmlElement Elgenero = documento.CreateElement("Generos");
                    Elgenero.InnerText = item;
                    Pelicula.AppendChild(Elgenero);
                }
                Pelicula.AppendChild(gene);

                //Creamos el elemento numeroSS.
                XmlElement Durac = documento.CreateElement("Duracion");
                Durac.InnerText = peli.Duracion.ToString();
                Pelicula.AppendChild(Durac);

                //Creamos el elemento numeroSS.
                XmlElement fecha = documento.CreateElement("Fecha");
                fecha.InnerText = DateTime.Now.ToString();
                Pelicula.AppendChild(fecha);

                //Creamos el elemento apellidos.
                XmlElement cartell = documento.CreateElement("Cartel");
                cartell.InnerText = peli.Cartel;
                Pelicula.AppendChild(cartell);

                //Creamos el elemento telefonos.
                XmlElement trailer = documento.CreateElement("UrlTrailer");
                trailer.InnerText = peli.UrlTrailer;
                Pelicula.AppendChild(trailer);

                //Creamos el elemento telefonos.
                XmlElement sinop = documento.CreateElement("Sinopsis");
                sinop.InnerText = peli.Sinopsis;
                Pelicula.AppendChild(sinop);

                //Creamos el elemento telefonos.
                XmlElement direct = documento.CreateElement("Director");
                direct.InnerText = peli.Director;
                Pelicula.AppendChild(direct);

                //Creamos los actores
                XmlElement actores = documento.CreateElement("Actor");
                foreach (string item in peli.Actores)
                {
                    XmlElement actor = documento.CreateElement("Actores");
                    actor.InnerText = item;
                    Pelicula.AppendChild(actor);
                }
                Pelicula.AppendChild(actores);

                //Creamos el elemento telefonos.
                XmlElement valora = documento.CreateElement("ValoracionPromedio");
                valora.InnerText = peli.ValoracionPromedio.ToString();
                Pelicula.AppendChild(valora);

                //Creamos el elemento telefonos.
                XmlElement votantes = documento.CreateElement("Votantes");
                votantes.InnerText = peli.CantidadVotantes.ToString();
                Pelicula.AppendChild(votantes);

                //Insertamos el nodo Usuario al final del archivo
                nodoRaiz.InsertAfter(Pelicula, nodoRaiz.LastChild);   //***
            }

            documento.Save("product2.xml");

            return Pelicula;
        }               
    }
}
