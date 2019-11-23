using RemoteWindows;
using System;

namespace Laboratorios.Modelo
{
    public class RemoteAccessWindows
    {
        Equipos Equipo;
        String Username;
        String Password;
        public RemoteAccessWindows(String Username, String Password, Equipos Equipo)
        {
            this.Username = Username;
            this.Password = Password;
            this.Equipo = Equipo;
        }

        public void Execute()
        {
            AccessForName.Execute(Equipo.Nombre, Username, Password);            
        }
    }
}
