using System;
using System.Windows.Forms;
using Ping;
using VNC;
using Security;
using Data;

namespace Laboratorios.Modelo
{
    public class VNC
    {
        String VNCUser;
        Equipos Equipo;
        public VNC(String VNCUser, Equipos Equipo)
        {
            this.VNCUser = VNCUser;
            this.Equipo = Equipo;
        }

        public void Execute()
        {
            if (PingForName.Execute(Equipo.Nombre))
            {
                String userVNC = Decode.Execute(VNCUser);
                String userWindows = Decode.Execute(Roles.UserAdmin);
                String passWindows = Decode.Execute(Roles.PassAdmin);
                ControlOrViewer.Execute(userVNC, userWindows, passWindows, Equipo.Nombre);
            }
            else
            {
                MessageBox.Show("Error. Equipo( "+Equipo.Nombre+" ) Apagado O Inacesible");
            }
        }
    }
}
