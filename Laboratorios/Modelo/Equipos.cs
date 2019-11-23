using System;
using System.Windows.Forms;

namespace Laboratorios.Modelo
{
    public class Equipos
    {
        public String Nombre { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }

        public PictureBox Imagen { get; set; }

        public Boolean Check { get; set; }

        public Equipos(String Nombre, String Mac, PictureBox Imagen)
        {
            this.Check = false;
            this.Nombre = Nombre;
            this.Ip = "0.0.0.0";
            this.Mac = Mac;
            this.Imagen = Imagen;
        }
    }
}
