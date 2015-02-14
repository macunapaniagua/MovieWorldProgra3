using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorld
{
    class Pelicula
    {

        private String nombre;
        private List<String> genero;
        private int duracion;
        private DateTime fechaEstreno;
        private String cartel;
        private String urlTrailer;
        private String sinopsis;
        private String director;
        private List<String> actores;
        private int valoracionPromedio;
        private int cantidadVotantes;

        public int CantidadVotantes
        {
            get { return cantidadVotantes; }
            set { cantidadVotantes = value; }
        }


        public int ValoracionPromedio
        {
            get { return valoracionPromedio; }
            set { valoracionPromedio = value; }
        }


        public List<String> Actores
        {
            get { return actores; }
            set { actores = value; }
        }


        public String Director
        {
            get { return director; }
            set { director = value; }
        }


        public String Sinopsis
        {
            get { return sinopsis; }
            set { sinopsis = value; }
        }


        public String UrlTrailer
        {
            get { return urlTrailer; }
            set { urlTrailer = value; }
        }


        public String Cartel
        {
            get { return cartel; }
            set { cartel = value; }
        }


        public DateTime FechaEstreno
        {
            get { return fechaEstreno; }
            set { fechaEstreno = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }


        public List<String> Genero
        {
            get { return genero; }
            set { genero = value; }
        }


        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
