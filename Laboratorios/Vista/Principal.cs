using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Laboratorios.Modelo;
using System.Threading;
using Laboratorios.Vista;
using Encender;

namespace Laboratorios
{
    public partial class Principal : Form
    {
        List<CheckBox> check = new List<CheckBox>();//System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        List<Equipos> equipo = new List<Equipos>();
        public Principal()
        {
            InitializeComponent();
            equipo.Add(new Equipos("CAPACITACION-01", "484d7ed4307d", ICapacitacion01));//0
            equipo.Add(new Equipos("CAPACITACION-02", "484d7ed42df7", ICapacitacion02));//1
            equipo.Add(new Equipos("CAPACITACION-03", "484d7ed42e4d", ICapacitacion03));//2
            equipo.Add(new Equipos("CAPACITACION-04", "484d7ed3db47", ICapacitacion04));//3
            equipo.Add(new Equipos("CAPACITACION-05", "484d7ed435b9", ICapacitacion05));//4
            equipo.Add(new Equipos("CAPACITACION-06", "484d7ed42b07", ICapacitacion06));//5
            equipo.Add(new Equipos("CAPACITACION-07", "484d7ed3de36", ICapacitacion07));//6
            equipo.Add(new Equipos("CAPACITACION-08", "1866da490ee4", ICapacitacion08));//7
            equipo.Add(new Equipos("CAPACITACION-09", "484d7ed42b64", ICapacitacion09));//8
            equipo.Add(new Equipos("CAPACITACION-10", "484d7ed429e1", ICapacitacion10));//9
            equipo.Add(new Equipos("CAPACITACION-11", "484d7ed43a15", ICapacitacion11));//10
            equipo.Add(new Equipos("CAPACITACION-12", "484d7ed38902", ICapacitacion12));//11
            equipo.Add(new Equipos("CAPACITACION-13", "1866da4b62b9", ICapacitacion13));//12
            equipo.Add(new Equipos("CAPACITACION-14", "484d7ed3d98f", ICapacitacion14));//13
            equipo.Add(new Equipos("CAPACITACION-15", "484d7ed42b21", ICapacitacion15));//14
            equipo.Add(new Equipos("CAPACITACION-16", "484d7ed12708", ICapacitacion16));//15
            equipo.Add(new Equipos("ADMINISTRACION", "1866da4b398b", IAdministracion));//16    ADMINISTRADOR
            equipo.Add(new Equipos("DESARROLLO-01", "484d7ed37b70", IDesarrollo01));//17
            equipo.Add(new Equipos("DESARROLLO-02", "1866da491ae8", IDesarrollo02));//18
            equipo.Add(new Equipos("DESARROLLO-03", "484d7ed42ef1", IDesarrollo03));//19
            equipo.Add(new Equipos("DESARROLLO-04", "484d7ed38447", IDesarrollo04));//20
            equipo.Add(new Equipos("DESARROLLO-05", "1866da4b5e45", IDesarrollo05));//21
            equipo.Add(new Equipos("DESARROLLO-06", "1866da4bab66", IDesarrollo06));//22
            equipo.Add(new Equipos("DESARROLLO-07", "1866da4b5ec5", IDesarrollo07));//23
            equipo.Add(new Equipos("DESARROLLO-08", "1866da4ba5c5", IDesarrollo08));//24
            equipo.Add(new Equipos("DESARROLLO-09", "484d7ed37b6b", IDesarrollo09));//25
            equipo.Add(new Equipos("IMAGEN-01", "484d7ed3cc88", pictureBox18));//26
        }

        //
        public void SalaCapacitacion(Boolean estado)
        {
            Capacitacion01.Checked = estado; Capacitacion02.Checked = estado; Capacitacion03.Checked = estado; Capacitacion04.Checked = estado;
            Capacitacion05.Checked = estado; Capacitacion06.Checked = estado; Capacitacion07.Checked = estado; Capacitacion08.Checked = estado;
            Capacitacion09.Checked = estado; Capacitacion10.Checked = estado; Capacitacion11.Checked = estado; Capacitacion12.Checked = estado;
            Capacitacion13.Checked = estado; Capacitacion14.Checked = estado; Capacitacion15.Checked = estado; Capacitacion16.Checked = estado;
            for (int i = 0; i < 16; i++)
            {
                equipo[i].Check = estado;
            }
        }

        public void SalaDesarrollo(Boolean estado)
        {
            Desarrollo01.Checked = estado; Desarrollo02.Checked = estado; Desarrollo03.Checked = estado;
            Desarrollo04.Checked = estado; Desarrollo05.Checked = estado; Desarrollo06.Checked = estado;
            Desarrollo07.Checked = estado; Desarrollo08.Checked = estado; Desarrollo09.Checked = estado;
            for (int i = 17; i < 26; i++)
            {
                equipo[i].Check = estado;
            }
        }

        public void SalaAdministracion(Boolean estado)
        {
            equipo[16].Check = estado;
            Administracion.Checked = estado;
        }

        public void SalaImagen(Boolean estado)
        {
            equipo[26].Check = estado;
            Imagen.Checked = estado;
        }

        public void EstadosCheck(Boolean estado)
        {
            SalaCapacitacion(estado);
            SalaDesarrollo(estado);
            SalaAdministracion(estado);
            SalaImagen(estado);
        }

        public void RestablecerRadioButtons()
        {
            TodosCapacitacion.Checked = false;
            NingunoCapacitacion.Checked = false;
            Apagar.Checked = false;
            Encender.Checked = false;
            Reiniciar.Checked = false;
            EstaEncendido.Checked = false;
            VNCVisor.Checked = false;
            VNCControl.Checked = false;
            Administrador.Checked = false;
            Practicante.Checked = false;
            Visitantes.Checked = false;
            TodosDesarrollo.Checked = false;
            NingunoDesarrollo.Checked = false;
        }

        //Función utilizada para saber que radio button selecciono el usuario
        public int Checker()
        {
            if (Administrador.Checked == true)//ADMINISTRADOR
            {
                return 1;
            }
            if (Apagar.Checked == true)//APAGAR
            {
                return 2;
            }
            if (Encender.Checked == true)//ENCENDER
            {
                return 3;
            }
            if (Reiniciar.Checked == true)//REINICIAR
            {
                return 4;
            }
            if (VNCVisor.Checked == true)//VNCVisor
            {
                return 5;
            }
            if (VNCControl.Checked == true)//VNCControl
            {
                return 6;
            }
            if (EstaEncendido.Checked == true)//VERIFICAR ESTADO
            {
                return 7;
            }
            if (Practicante.Checked == true)//PRACTICANTE
            {
                return 8;
            }
            if (Visitantes.Checked == true)//Visitantes
            {
                return 9;
            }
            return 0;
        }

        // para optimizar el codigo de Opciones
        public void ApoyoOpciones(Equipos x, int posicion, int caso)
        {
            if (caso == 2) Metodos_Funciones.Remotos(x, 1);
            if (caso == 4) Metodos_Funciones.Remotos(x, 2);
        }

        //Opciones que desee el usuario
        public void Opciones(Equipos x, int caso)/*2 = ApagarEquipos     4 = ReiniciarEquipos*/
        {
            switch (x.Nombre)
            {
                case "CAPACITACION-01":
                    ApoyoOpciones(x, 0, caso);
                    break;
                case "CAPACITACION-02":
                    ApoyoOpciones(x, 1, caso);
                    break;
                case "CAPACITACION-03":
                    ApoyoOpciones(x, 2, caso);
                    break;
                case "CAPACITACION-04":
                    ApoyoOpciones(x, 3, caso);
                    break;
                case "CAPACITACION-05":
                    ApoyoOpciones(x, 4, caso);
                    break;
                case "CAPACITACION-06":
                    ApoyoOpciones(x, 5, caso);
                    break;
                case "CAPACITACION-07":
                    ApoyoOpciones(x, 6, caso);
                    break;
                case "CAPACITACION-08":
                    ApoyoOpciones(x, 7, caso);
                    break;
                case "CAPACITACION-09":
                    ApoyoOpciones(x, 8, caso);
                    break;
                case "CAPACITACION-10":
                    ApoyoOpciones(x, 9, caso);
                    break;
                case "CAPACITACION-11":
                    ApoyoOpciones(x, 10, caso);
                    break;
                case "CAPACITACION-12":
                    ApoyoOpciones(x, 11, caso);
                    break;
                case "CAPACITACION-13":
                    ApoyoOpciones(x, 12, caso);
                    break;
                case "CAPACITACION-14":
                    ApoyoOpciones(x, 13, caso);
                    break;
                case "CAPACITACION-15":
                    ApoyoOpciones(x, 14, caso);
                    break;
                case "CAPACITACION-16":
                    ApoyoOpciones(x, 15, caso);
                    break;
                case "ADMINISTRACION":
                    ApoyoOpciones(x, 16, caso);
                    break;
                case "DESARROLLO-01":
                    ApoyoOpciones(x, 17, caso);
                    break;
                case "DESARROLLO-02":
                    ApoyoOpciones(x, 18, caso);
                    break;
                case "DESARROLLO-03":
                    ApoyoOpciones(x, 19, caso);
                    break;
                case "DESARROLLO-04":
                    ApoyoOpciones(x, 20, caso);
                    break;
                case "DESARROLLO-05":
                    ApoyoOpciones(x, 21, caso);
                    break;
                case "DESARROLLO-06":
                    ApoyoOpciones(x, 22, caso);
                    break;
                case "DESARROLLO-07":
                    ApoyoOpciones(x, 23, caso);
                    break;
                case "DESARROLLO-08":
                    ApoyoOpciones(x, 24, caso);
                    break;
                case "DESARROLLO-09":
                    ApoyoOpciones(x, 25, caso);
                    break;
                case "IMAGEN-01":
                    ApoyoOpciones(x, 26, caso);
                    break;
            }
        }

        //Checked sala capacitacion
        private void TodosCapacitacion_CheckedChanged(object sender, EventArgs e)
        {
            SalaCapacitacion(true);
        }
        private void NingunoCapacitacion_CheckedChanged(object sender, EventArgs e)
        {
            SalaCapacitacion(false);
        }
        private void Capacitacion01_CheckedChanged(object sender, EventArgs e)
        {
            equipo[0].Check = Capacitacion01.Checked;
        }

        private void Capacitacion02_CheckedChanged(object sender, EventArgs e)
        {
            equipo[1].Check = Capacitacion02.Checked;
        }

        private void Capacitacion03_CheckedChanged(object sender, EventArgs e)
        {
            equipo[2].Check = Capacitacion03.Checked;
        }

        private void Capacitacion04_CheckedChanged(object sender, EventArgs e)
        {
            equipo[3].Check = Capacitacion04.Checked;
        }

        private void Capacitacion05_CheckedChanged(object sender, EventArgs e)
        {
            equipo[4].Check = Capacitacion05.Checked;
        }

        private void Capacitacion06_CheckedChanged(object sender, EventArgs e)
        {
            equipo[5].Check = Capacitacion06.Checked;
        }

        private void Capacitacion07_CheckedChanged(object sender, EventArgs e)
        {
            equipo[6].Check = Capacitacion07.Checked;
        }

        private void Capacitacion08_CheckedChanged(object sender, EventArgs e)
        {
            equipo[7].Check = Capacitacion08.Checked;
        }

        private void Capacitacion09_CheckedChanged(object sender, EventArgs e)
        {
            equipo[8].Check = Capacitacion09.Checked;
        }

        private void Capacitacion10_CheckedChanged(object sender, EventArgs e)
        {
            equipo[9].Check = Capacitacion10.Checked;
        }

        private void Capacitacion11_CheckedChanged(object sender, EventArgs e)
        {
            equipo[10].Check = Capacitacion11.Checked;
        }

        private void Capacitacion12_CheckedChanged(object sender, EventArgs e)
        {
            equipo[11].Check = Capacitacion12.Checked;
        }

        private void Capacitacion13_CheckedChanged(object sender, EventArgs e)
        {
            equipo[12].Check = Capacitacion13.Checked;
        }

        private void Capacitacion14_CheckedChanged(object sender, EventArgs e)
        {
            equipo[13].Check = Capacitacion14.Checked;
        }

        private void Capacitacion15_CheckedChanged(object sender, EventArgs e)
        {
            equipo[14].Check = Capacitacion15.Checked;
        }

        private void Capacitacion16_CheckedChanged(object sender, EventArgs e)
        {
            equipo[15].Check = Capacitacion16.Checked;
        }

        //Checked sala administracion
        private void Administracion_CheckedChanged(object sender, EventArgs e)
        {
            equipo[16].Check = Administracion.Checked;
        }

        //Checked sala desarrollo
        private void TodosDesarrollo_CheckedChanged(object sender, EventArgs e)
        {
            SalaDesarrollo(true);
        }
        private void NingunoDesarrollo_CheckedChanged(object sender, EventArgs e)
        {
            SalaDesarrollo(false);
        }
        private void Desarrollo01_CheckedChanged(object sender, EventArgs e)
        {
            equipo[17].Check = Desarrollo01.Checked;
        }

        private void Desarrollo02_CheckedChanged(object sender, EventArgs e)
        {
            equipo[18].Check = Desarrollo02.Checked;
        }

        private void Desarrollo03_CheckedChanged(object sender, EventArgs e)
        {
            equipo[19].Check = Desarrollo03.Checked;
        }

        private void Desarrollo04_CheckedChanged(object sender, EventArgs e)
        {
            equipo[20].Check = Desarrollo04.Checked;
        }

        private void Desarrollo05_CheckedChanged(object sender, EventArgs e)
        {
            equipo[21].Check = Desarrollo05.Checked;
        }

        private void Desarrollo06_CheckedChanged(object sender, EventArgs e)
        {
            equipo[22].Check = Desarrollo06.Checked;
        }

        private void Desarrollo07_CheckedChanged(object sender, EventArgs e)
        {
            equipo[23].Check = Desarrollo07.Checked;
        }

        private void Desarrollo08_CheckedChanged(object sender, EventArgs e)
        {
            equipo[24].Check = Desarrollo08.Checked;
        }

        private void Desarrollo09_CheckedChanged(object sender, EventArgs e)
        {
            equipo[25].Check = Desarrollo09.Checked;
        }

        //Checked sala Imagen
        private void Imagen_CheckedChanged(object sender, EventArgs e)
        {
            equipo[26].Check = Imagen.Checked;
        }


        private void btEjecutar_Click(object sender, EventArgs e)
        {
            List<Equipos> eq = new List<Equipos>();
            eq = (from a in equipo where a.Check == true select a).ToList();
            //MessageBox.Show("Equipos: " + eq.Count() + "");
            int Opcion = Checker();
            switch (Opcion)
            {
                case 1://ADMINISTRADOR
                    foreach (Equipos x in eq)
                    {
                        Metodos_Funciones.RemoteAccessOptions(x, 1);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    break;
                case 2://APAGAR
                    foreach (Equipos x in eq)
                    {
                        Opciones(x, 2);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    break;
                case 3://ENCENDER
                    foreach (Equipos x in eq)
                    {
                        try
                        {
                            WakeOnLan.SendWOLPacket(x.Mac);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(string.Format("Error En: " + x.Nombre, ex.Message), "Error");
                        }//Red.Encender(x);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    MessageBox.Show("Ordenes Enviadas: ");
                    break;
                case 4://REINICIAR
                    foreach (Equipos x in eq)
                    {
                        Opciones(x, 4);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    MessageBox.Show("Ordenes Enviadas: ");
                    break;
                case 5://VNCVisor
                    foreach (Equipos x in eq)
                    {
                        //MessageBox.Show(x.Nombre+" : "+x.Mac);
                        Metodos_Funciones.VNCOptions(x, 2);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    break;
                case 6://VNCControl
                    foreach (Equipos x in eq)
                    {
                        Metodos_Funciones.VNCOptions(x, 1);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    break;
                case 7://VERIFICAR ESTADO
                    foreach (Equipos x in eq)
                    {//MessageBox.Show(x.Nombre);
                        //MessageBox.Show(x.Nombre + " : " + x.Mac);
                        Hilo_Encendido_Apagado objeto_hilo = new Hilo_Encendido_Apagado(x, x.Imagen);
                        Thread hilo = new Thread(new ThreadStart(objeto_hilo.Encendido_Apagado));
                        hilo.Start();
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    break;
                case 8://PRACTICANTE
                    foreach (Equipos x in eq)
                    {
                        Metodos_Funciones.RemoteAccessOptions(x, 2);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    break;
                case 9://VISITANTES
                    foreach (Equipos x in eq)
                    {
                        Metodos_Funciones.RemoteAccessOptions(x, 3);
                    }
                    RestablecerRadioButtons();
                    EstadosCheck(false);
                    break;
                default:
                    MessageBox.Show("NO SELECCIONASTE NINGUNA OPCION");
                    break;
            }
        }
        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}