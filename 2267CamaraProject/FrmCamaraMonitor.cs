using System;
using System.Data;
using System.Drawing;
using AForge.Video.DirectShow;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AForge.Video;

namespace _2267CamaraProject
{
    public partial class FrmCamaraMonitor : Form
    {

        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;

        // Move Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Variables para la animación
        public static int countImageAnimationCam1 = 0;

        // Variables para saber el estado de encendido apagado
        public static bool estaEncendidaCam1 = false;

        // Imagen que se utiliza para guardar una captura!
        public static Image capture;


        public FrmCamaraMonitor()
        {
            InitializeComponent();
        }

        // Cargar los dispositivos de entrada de video en el combobox
        private void CargaDiapositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                cbCamaraSelect.Items.Clear();

                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    cbCamaraSelect.Items.Add(MisDispositivos[i].Name.ToString());

                }
                cbCamaraSelect.Text = MisDispositivos[0].Name.ToString();
            }
            else
            {
                HayDispositivos = false;
            }
        }

        private void CerrarWebCam()
        {

            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }

        private void Capturando(object sender, NewFrameEventArgs eventsArgs)
        {
            Bitmap Imagen = (Bitmap)eventsArgs.Frame.Clone();
            // Rota la imagen 90 grados
            //Imagen.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picCamara.Image = Imagen;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
            CerrarWebCam();
        }

        private void IconIniciarCam_Click(object sender, EventArgs e)
        {
            if (TimerAnimation.Enabled == true)
            {
                TimerAnimation.Stop();
            }

            if (estaEncendidaCam1 == false)
            {
                CerrarWebCam();
                int i = cbCamaraSelect.SelectedIndex;
                string NombreVideo = MisDispositivos[i].MonikerString;
                MiWebCam = new VideoCaptureDevice(NombreVideo);
                MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
                MiWebCam.Start();
                estaEncendidaCam1 = true;
                IconIniciarCam.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            }
            else if (estaEncendidaCam1 == true)
            {
                CerrarWebCam();
                picCamara.Image.Dispose();
                picCamara.Image = Properties.Resources.signal1;
                TimerAnimation.Start();
                countImageAnimationCam1 = 1;
                estaEncendidaCam1 = false;
                IconIniciarCam.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            }
        }

        private void FrmCamaraMonitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
            TimerAnimation.Stop();
            countImageAnimationCam1 = 0;

            estaEncendidaCam1 = false;
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

                if (countImageAnimationCam1 == 0)
                {
                    picCamara.Image.Dispose();
                    picCamara.Image = Properties.Resources.signal1;
                    countImageAnimationCam1++;
                    return;
                }
                if (countImageAnimationCam1 == 1)
                {
                    picCamara.Image.Dispose();
                    picCamara.Image = Properties.Resources.signal2;
                    countImageAnimationCam1++;
                    return;
                }
                if (countImageAnimationCam1 == 2)
                {
                    picCamara.Image.Dispose();
                    picCamara.Image = Properties.Resources.signal3;
                    countImageAnimationCam1++;
                    return;
                }
                if (countImageAnimationCam1 == 3)
                {
                    picCamara.Image.Dispose();
                    picCamara.Image = Properties.Resources.signal4;
                    countImageAnimationCam1++;
                    return;
                }
                if (countImageAnimationCam1 == 4)
                {
                    picCamara.Image.Dispose();
                    picCamara.Image = Properties.Resources.signal5;
                    countImageAnimationCam1 = 0;
                    return;
                }
            }
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
        }
    }
}
