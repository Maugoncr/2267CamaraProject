using System;
using System.Data;
using System.Drawing;
using AForge.Video.DirectShow;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AForge.Video;
using System.Collections.Generic;

namespace _2267CamaraProject
{
    public partial class FrmCamaraMonitor : Form
    {

        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        private VideoCaptureDevice MiWebCam2;
        private VideoCaptureDevice MiWebCam3;
        private VideoCaptureDevice MiWebCam4;

        // Move Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Variables para la animación
        private int countImageAnimationCam1 = 0;
        private int countImageAnimationCam2 = 0;
        private int countImageAnimationCam3 = 0;
        private int countImageAnimationCam4 = 0;

        // Variables para saber el estado de encendido apagado
        private bool estaEncendidaCam1 = false;
        private bool estaEncendidaCam2 = false;
        private bool estaEncendidaCam3 = false;
        private bool estaEncendidaCam4 = false;

        // Camaras en Uso, para verificar un doble encendido

        private List<string> listaCamarasEnUso;
        private string Cam1InUse;
        private string Cam2InUse;
        private string Cam3InUse;
        private string Cam4InUse;

        // Imagen que se utiliza para guardar una captura!
        public static Image capture;


        public FrmCamaraMonitor()
        {
            InitializeComponent();
            listaCamarasEnUso = new List<string>();
        }

        // Cargar los dispositivos de entrada de video en el combobox
        private void CargaDiapositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                cbCamaraSelect.Items.Clear();
                cbCamaraSelect2.Items.Clear();
                cbCamaraSelect3.Items.Clear();
                cbCamaraSelect4.Items.Clear();

                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    cbCamaraSelect.Items.Add(MisDispositivos[i].Name.ToString());
                    cbCamaraSelect2.Items.Add(MisDispositivos[i].Name.ToString());
                    cbCamaraSelect3.Items.Add(MisDispositivos[i].Name.ToString());
                    cbCamaraSelect4.Items.Add(MisDispositivos[i].Name.ToString());

                }
                cbCamaraSelect.Text = MisDispositivos[0].Name.ToString();
                cbCamaraSelect2.Text = MisDispositivos[0].Name.ToString();
                cbCamaraSelect3.Text = MisDispositivos[0].Name.ToString();
                cbCamaraSelect4.Text = MisDispositivos[0].Name.ToString();
            }
            else
            {
                HayDispositivos = false;
            }
        }

        private void CerrarWebCam( int which)
        {
            if (which == 1)
            {
                if (MiWebCam != null && MiWebCam.IsRunning)
                {
                    MiWebCam.SignalToStop();
                    MiWebCam = null;
                }
            }
            else if (which == 2)
            {
                if (MiWebCam2 != null && MiWebCam2.IsRunning)
                {
                    MiWebCam2.SignalToStop();
                    MiWebCam2 = null;
                }
            }
            else if (which == 3)
            {
                if (MiWebCam3 != null && MiWebCam3.IsRunning)
                {
                    MiWebCam3.SignalToStop();
                    MiWebCam3 = null;
                }
            }
            else if (which == 4)
            {
                if (MiWebCam4 != null && MiWebCam4.IsRunning)
                {
                    MiWebCam4.SignalToStop();
                    MiWebCam4 = null;
                }
            }
        }


        private void Capturando(object sender, NewFrameEventArgs eventsArgs)
        {
            Bitmap Imagen = (Bitmap)eventsArgs.Frame.Clone();
            picCamara.Image = Imagen;
        }

        private void Capturando2(object sender, NewFrameEventArgs eventsArgs)
        {
            Bitmap Imagen = (Bitmap)eventsArgs.Frame.Clone();
            picCamara2.Image = Imagen;
        }

        private void Capturando3(object sender, NewFrameEventArgs eventsArgs)
        {
            Bitmap Imagen = (Bitmap)eventsArgs.Frame.Clone();
            picCamara3.Image = Imagen;
        }

        private void Capturando4(object sender, NewFrameEventArgs eventsArgs)
        {
            Bitmap Imagen = (Bitmap)eventsArgs.Frame.Clone();
            Imagen.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picCamara4.Image = Imagen;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            CerrarWebCam(1);
            CerrarWebCam(2);
            CerrarWebCam(3);
            CerrarWebCam(4);
            this.Close();
        }

        private void FrmCamaraMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam(1);
            CerrarWebCam(2);
            CerrarWebCam(3);
            CerrarWebCam(4);
            TimerAnimation.Stop();
            countImageAnimationCam1 = 0;
            countImageAnimationCam2 = 0;
            countImageAnimationCam3 = 0;
            countImageAnimationCam4 = 0;

            estaEncendidaCam1 = false;
            estaEncendidaCam2 = false;
            estaEncendidaCam3 = false;
            estaEncendidaCam4 = false;
        }

        private void iconMini_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void topNav_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            if (estaEncendidaCam1 == false)
            {
                switch (countImageAnimationCam1)
                {
                    case 0:
                        picCamara.Image.Dispose();
                        picCamara.Image = Properties.Resources.signal1;
                        break;
                    case 1:
                        picCamara.Image.Dispose();
                        picCamara.Image = Properties.Resources.signal2;
                        break;
                    case 2:
                        picCamara.Image.Dispose();
                        picCamara.Image = Properties.Resources.signal3;
                        break;
                    case 3:
                        picCamara.Image.Dispose();
                        picCamara.Image = Properties.Resources.signal4;
                        break;
                    case 4:
                        picCamara.Image.Dispose();
                        picCamara.Image = Properties.Resources.signal5;
                        break;
                }
            }

            if (estaEncendidaCam2 == false)
            {
                switch (countImageAnimationCam2) 
                {
                    case 0:
                        picCamara2.Image.Dispose();
                        picCamara2.Image = Properties.Resources.signal1;
                        break;
                    case 1:
                        picCamara2.Image.Dispose();
                        picCamara2.Image = Properties.Resources.signal2;
                        break;
                    case 2:
                        picCamara2.Image.Dispose();
                        picCamara2.Image = Properties.Resources.signal3;
                        break;
                    case 3:
                        picCamara2.Image.Dispose();
                        picCamara2.Image = Properties.Resources.signal4;
                        break;
                    case 4:
                        picCamara2.Image.Dispose();
                        picCamara2.Image = Properties.Resources.signal5;
                        break;
                }
            }

            if (estaEncendidaCam3 == false)
            {
                switch (countImageAnimationCam3)
                {
                    case 0:
                        picCamara3.Image.Dispose();
                        picCamara3.Image = Properties.Resources.signal1;
                        break;
                    case 1:
                        picCamara3.Image.Dispose();
                        picCamara3.Image = Properties.Resources.signal2;
                        break;
                    case 2:
                        picCamara3.Image.Dispose();
                        picCamara3.Image = Properties.Resources.signal3;
                        break;
                    case 3:
                        picCamara3.Image.Dispose();
                        picCamara3.Image = Properties.Resources.signal4;
                        break;
                    case 4:
                        picCamara3.Image.Dispose();
                        picCamara3.Image = Properties.Resources.signal5;
                        break;
                }
            }

            if (estaEncendidaCam4 == false)
            {
                switch (countImageAnimationCam4)
                {
                    case 0:
                        picCamara4.Image.Dispose();
                        picCamara4.Image = Properties.Resources.signal1;
                        break;
                    case 1:
                        picCamara4.Image.Dispose();
                        picCamara4.Image = Properties.Resources.signal2;
                        break;
                    case 2:
                        picCamara4.Image.Dispose();
                        picCamara4.Image = Properties.Resources.signal3;
                        break;
                    case 3:
                        picCamara4.Image.Dispose();
                        picCamara4.Image = Properties.Resources.signal4;
                        break;
                    case 4:
                        picCamara4.Image.Dispose();
                        picCamara4.Image = Properties.Resources.signal5;
                        break;
                }
            }

            if (countImageAnimationCam1 == 4)
                countImageAnimationCam1 = 0;
            else
                countImageAnimationCam1++;

            if (countImageAnimationCam2 == 4)
                countImageAnimationCam2 = 0;
            else
                countImageAnimationCam2++;

            if (countImageAnimationCam3 == 4)
                countImageAnimationCam3 = 0;
            else
                countImageAnimationCam3++;

            if (countImageAnimationCam4 == 4)
                countImageAnimationCam4 = 0;
            else
                countImageAnimationCam4++;

        }

        private void iconRefresh_Click(object sender, EventArgs e)
        {
            CargaDiapositivos();
        }

        private void iconCapture_Click(object sender, EventArgs e)
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                capture = picCamara.Image;
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CameraCapture);
                if (frm == null)
                {
                    CameraCapture send = new CameraCapture();
                    send.ShowDialog();
                }
                else
                {
                    frm.BringToFront();
                    return;
                }
            }
        }

        private void FrmCamaraMonitor_Load(object sender, EventArgs e)
        {
            CargaDiapositivos();
            TimerAnimation.Start();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(iconRefresh, "Reload the connected video input devices");
        }

        private void IconMaxin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private bool IsWebcamInUse()
        {
            // Obtener la lista de dispositivos de video disponibles
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Recorrer cada dispositivo para verificar si está siendo utilizado
            foreach (FilterInfo device in videoDevices)
            {
                // Crear un objeto VideoCaptureDevice para cada dispositivo
                VideoCaptureDevice videoDevice = new VideoCaptureDevice(device.MonikerString);

                // Si la captura está activa, entonces la webcam está siendo utilizada
                if (videoDevice.IsRunning)
                {
                    return true;
                }

                // Detener la captura para liberar recursos
                videoDevice.Stop();
            }

            // Si ningún dispositivo está siendo utilizado, entonces la webcam no está en uso
            return false;
        }

        private void IconIniciarCam_Click(object sender, EventArgs e)
        {
            string checkNameInUse = MisDispositivos[cbCamaraSelect.SelectedIndex].MonikerString;

            if (listaCamarasEnUso.Contains(checkNameInUse) && checkNameInUse != Cam1InUse)
            {
                MessageBox.Show("This video input device is already in use. Please turn off its usage before attempting to use it elsewhere.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (estaEncendidaCam1 == false)
            {
                CerrarWebCam(1);
                int i = cbCamaraSelect.SelectedIndex;
                string NombreVideo = MisDispositivos[i].MonikerString;
                MiWebCam = new VideoCaptureDevice(NombreVideo);
                MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
                MiWebCam.Start();
                estaEncendidaCam1 = true;
                IconIniciarCam.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;

                Cam1InUse = NombreVideo;
                listaCamarasEnUso.Add(NombreVideo);

            }
            else if (estaEncendidaCam1 == true)
            {
                CerrarWebCam(1);
                picCamara.Image.Dispose();
                picCamara.Image = Properties.Resources.signal1;
                estaEncendidaCam1 = false;
                IconIniciarCam.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;

                listaCamarasEnUso.Remove(Cam1InUse);
                Cam1InUse = "";
            }
        }

        private void IconIniciarCam2_Click(object sender, EventArgs e)
        {
            string checkNameInUse = MisDispositivos[cbCamaraSelect2.SelectedIndex].MonikerString;

            if (listaCamarasEnUso.Contains(checkNameInUse) && checkNameInUse != Cam2InUse)
            {
                MessageBox.Show("This video input device is already in use. Please turn off its usage before attempting to use it elsewhere.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (estaEncendidaCam2 == false)
            {
                CerrarWebCam(2);
                int i = cbCamaraSelect2.SelectedIndex;
                string NombreVideo = MisDispositivos[i].MonikerString;
                MiWebCam2 = new VideoCaptureDevice(NombreVideo);
                MiWebCam2.NewFrame += new NewFrameEventHandler(Capturando2);
                MiWebCam2.Start();
                estaEncendidaCam2 = true;
                IconIniciarCam2.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;

                Cam2InUse = NombreVideo;
                listaCamarasEnUso.Add(NombreVideo);

            }
            else if (estaEncendidaCam2 == true)
            {
                CerrarWebCam(2);
                picCamara2.Image.Dispose();
                picCamara2.Image = Properties.Resources.signal1;
                estaEncendidaCam2 = false;
                IconIniciarCam2.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;

                listaCamarasEnUso.Remove(Cam2InUse);
                Cam2InUse = "";
            }
        }

        private void IconIniciarCam3_Click(object sender, EventArgs e)
        {
            string checkNameInUse = MisDispositivos[cbCamaraSelect3.SelectedIndex].MonikerString;

            if (listaCamarasEnUso.Contains(checkNameInUse) && checkNameInUse != Cam3InUse)
            {
                MessageBox.Show("This video input device is already in use. Please turn off its usage before attempting to use it elsewhere.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (estaEncendidaCam3 == false)
            {
                CerrarWebCam(3);
                int i = cbCamaraSelect3.SelectedIndex;
                string NombreVideo = MisDispositivos[i].MonikerString;
                MiWebCam3 = new VideoCaptureDevice(NombreVideo);
                MiWebCam3.NewFrame += new NewFrameEventHandler(Capturando3);
                MiWebCam3.Start();
                estaEncendidaCam3 = true;
                IconIniciarCam3.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;

                Cam3InUse = NombreVideo;
                listaCamarasEnUso.Add(NombreVideo);

            }
            else if (estaEncendidaCam3 == true)
            {
                CerrarWebCam(3);
                picCamara3.Image.Dispose();
                picCamara3.Image = Properties.Resources.signal1;
                estaEncendidaCam3 = false;
                IconIniciarCam3.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;

                listaCamarasEnUso.Remove(Cam3InUse);
                Cam3InUse = "";
            }
        }

        private void IconIniciarCam4_Click(object sender, EventArgs e)
        {
            string checkNameInUse = MisDispositivos[cbCamaraSelect4.SelectedIndex].MonikerString;

            if (listaCamarasEnUso.Contains(checkNameInUse) && checkNameInUse != Cam4InUse)
            {
                MessageBox.Show("This video input device is already in use. Please turn off its usage before attempting to use it elsewhere.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (estaEncendidaCam4 == false)
            {
                CerrarWebCam(4);
                int i = cbCamaraSelect4.SelectedIndex;
                string NombreVideo = MisDispositivos[i].MonikerString;
                MiWebCam4 = new VideoCaptureDevice(NombreVideo);
                MiWebCam4.NewFrame += new NewFrameEventHandler(Capturando4);
                MiWebCam4.Start();
                estaEncendidaCam4 = true;
                IconIniciarCam4.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;

                Cam4InUse = NombreVideo;
                listaCamarasEnUso.Add(NombreVideo);

            }
            else if (estaEncendidaCam4 == true)
            {
                CerrarWebCam(4);
                picCamara4.Image.Dispose();
                picCamara4.Image = Properties.Resources.signal1;
                estaEncendidaCam4 = false;
                IconIniciarCam4.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;

                listaCamarasEnUso.Remove(Cam4InUse);
                Cam4InUse = "";
            }
        }

        private void iconCapture2_Click(object sender, EventArgs e)
        {
            if (MiWebCam2 != null && MiWebCam2.IsRunning)
            {
                capture = picCamara2.Image;
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CameraCapture);
                if (frm == null)
                {
                    CameraCapture send = new CameraCapture();
                    send.ShowDialog();
                }
                else
                {
                    frm.BringToFront();
                    return;
                }
            }
        }

        private void iconCapture3_Click(object sender, EventArgs e)
        {
            if (MiWebCam3 != null && MiWebCam3.IsRunning)
            {
                capture = picCamara3.Image;
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CameraCapture);
                if (frm == null)
                {
                    CameraCapture send = new CameraCapture();
                    send.ShowDialog();
                }
                else
                {
                    frm.BringToFront();
                    return;
                }
            }
        }

        private void iconCapture4_Click(object sender, EventArgs e)
        {
            if (MiWebCam4 != null && MiWebCam4.IsRunning)
            {
                capture = picCamara4.Image;
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CameraCapture);
                if (frm == null)
                {
                    CameraCapture send = new CameraCapture();
                    send.ShowDialog();
                }
                else
                {
                    frm.BringToFront();
                    return;
                }
            }
        }
    }
}
