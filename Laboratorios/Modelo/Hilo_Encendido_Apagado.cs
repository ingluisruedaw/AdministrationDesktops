using Ping;
using System.Windows.Forms;
namespace Laboratorios.Modelo
{
    public class Hilo_Encendido_Apagado
    {
        Equipos equipo;
        PictureBox pictureBox;
        public Hilo_Encendido_Apagado(Equipos equipo, PictureBox pictureBox)
        {
            this.equipo = equipo;
            this.pictureBox = pictureBox;
        }

        public void Encendido_Apagado()
        {
            pictureBox.Image = Properties.Resources.inicial;
            if (PingForName.Execute(equipo.Nombre))
            {
                pictureBox.Image = Properties.Resources.encendido;
            }
            else
            {
                pictureBox.Image = Properties.Resources.apagado;
            }
        }
    }
}
