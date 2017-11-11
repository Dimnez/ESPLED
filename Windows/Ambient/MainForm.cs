using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambient
{
    public partial class MainForm : Form
    {

        public bool completedWrite = true;
        private SerialPort port = null;


        public MainForm()
        {
            InitializeComponent();
        }


        //Timer which refrehs the LEDs
        private void RefreshLED_Tick(object sender, EventArgs e)
        {
            if (!cb_active.Checked)
                RefreshLED.Enabled = false;

            if (completedWrite)
            {
                completedWrite = false;
                List<char> SendCollection = new List<char>();

                List<Color> screenColors = Extensions.GetColorsFromScreen(Convert.ToInt32(tb_pixel.Text));

                for (int led = 0; led < 30; led++)
                {
                    Color n = screenColors.ElementAt(led);
                    port.Write(new byte[] 
                    {
                        Convert.ToByte(led),
                        Convert.ToByte(n.G),
                        Convert.ToByte(n.R),
                        Convert.ToByte(n.B)
                    }, 0, 4);
                }

                completedWrite = true; 
            }

        }

        private void bu_savesettings_Click(object sender, EventArgs e)
        {
            //Open the selected port
            port = new SerialPort(dd_COM.Text.ToString(), 115200, Parity.None, 8, StopBits.One);

            //Open Port
            if(!port.IsOpen)
            port.Open();

            //Activate Timer
            RefreshLED.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Fill COM-Port-Dropdown
            dd_COM.Items.AddRange(SerialPort.GetPortNames());


        }
    }
}
