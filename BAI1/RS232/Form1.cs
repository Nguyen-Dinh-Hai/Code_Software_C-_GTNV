using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace RS232
{
    public partial class Form1 : Form
    {
        string ReceiveData = String.Empty;
        string TransmitData = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;

        }


        // nut ket noi com
        private void btnConn_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Select COM Port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show(" COM Ports is connected and ready for use ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        serialPort1.Open();
                        txtConn.BackColor = Color.Lime;
                        txtConn.Text = " Connecting...";
                        comboBox1.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("COM port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        // nut ngat ket noi com
        private void btnDisConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    txtConn.BackColor = Color.Red;
                    txtConn.Text = " Disconnected !";
                    comboBox1.Enabled = true;

                }
                else
                {
                    MessageBox.Show(" COM Ports is disconnected and ready for use ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // nut OPEN
        private void btnOn_Click(object sender, EventArgs e)
        {

            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "a";
                    serialPort1.Write(TransmitData);

                }
                else
                {
                    MessageBox.Show(" COM Ports is disconnected and ready for use ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // nut CLOSE
        private void btnOff_Click(object sender, EventArgs e)
        {

            try

            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "d";
                    serialPort1.Write(TransmitData);

                }
                else
                {
                    MessageBox.Show(" COM Ports is disconnected and ready for use ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceiveData = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DoupDate));
        }

        private void DoupDate(object sender, EventArgs e)
        {
            if (ReceiveData == "s")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledon;
            }
            else if (ReceiveData == "f")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledoff;

            }

        }

        // nut STOP
        private void buttstop_Click(object sender, EventArgs e)
        {
            try

            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "d";
                    serialPort1.Write(TransmitData);

                }
                else
                {
                    MessageBox.Show(" COM Ports is disconnected and ready for use ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exits? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
        }
    }
}
