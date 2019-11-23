using System.Threading;
using System.Windows.Forms;
using System;
using Ping;
using RemoteWindows;
using IP;
using Data;
using Security;

namespace Laboratorios.Modelo
{
    public class Metodos_Funciones
    {
        public static void VNCOptions(Equipos equipo, int caso)
        {
            if (PingForName.Execute(equipo.Nombre))
            {
                VNC objeto_hilo;
                Thread hilo = null;
                if (caso == 1)//ACCESO TOTAL
                {
                    objeto_hilo = new VNC(TightVNC.Admin, equipo);
                    hilo = new Thread(new ThreadStart(objeto_hilo.Execute));
                }
                else//VISOR
                {
                    objeto_hilo = new VNC(TightVNC.Viewer, equipo);
                    hilo = new Thread(new ThreadStart(objeto_hilo.Execute));
                }

                hilo.Start();
            }
            else
            {
                MessageBox.Show("Error. Equipo Apagado O Inacesible");
            }
        }

        public static void RemoteAccessOptions(Equipos equipo, int caso)
        {
            try
            {
                RemoteAccessWindows objeto_hilo = null;
                Thread hilo = null;
                if (caso == 1)//ADMINISTRADOR
                {
                    String user = Decode.Execute(Roles.UserAdmin);
                    String pass = Decode.Execute(Roles.PassAdmin);
                    objeto_hilo = new RemoteAccessWindows(user, pass, equipo);
                }
                if (caso == 2)//PRACTICANTE
                {
                    String user = Decode.Execute(Roles.UserPracticante);
                    String pass = Decode.Execute(Roles.PassPracticante);
                    objeto_hilo = new RemoteAccessWindows(user, pass, equipo);
                }
                if (caso == 3)//VISITANTES
                {
                    String user = Decode.Execute(Roles.UserVisitantes);
                    String pass = Decode.Execute(Roles.PassVisitantes);
                    objeto_hilo = new RemoteAccessWindows(user, pass, equipo);
                }
                hilo = new Thread(new ThreadStart(objeto_hilo.Execute));
                hilo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Opciones remotas (APAGAR=1, REINICIAR)=2
        public static void Remotos(Equipos equipo, int orden)
        {
            equipo.Ip = IPV6.Execute(equipo.Nombre);
            if (!equipo.Ip.Equals("0.0.0.0"))
            {
                try
                {
                    String user = Decode.Execute(Roles.UserAdmin);
                    String pass = Decode.Execute(Roles.PassAdmin);
                    if (orden == 1) Shutdown.Execute(user, pass, equipo.Ip);
                    if (orden == 2) Restart.Execute(user, pass, equipo.Ip);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}