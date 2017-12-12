using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Timers;



namespace NIRs_Virtual_Serial_GUI
{
    
    
    public partial class Form1 : Form
    {
        const int F7 = 0x200;
        const int F8 = 0x100; 
        const int FP1 = 0x80;
        const int FP2 = 0x40;
        const int T3  = 0x20;
        const int T4  = 0x10;
        const int T5  = 0x8;
        const int T6  = 0x4;
        const int O1  = 0x2;
        const int O2  = 0x1;


        const string comPortErrorCaption = "Com Port Error";
        const string comPortErrorMessage =  "Com Port is Disconnected"; 
        const string configSendErrorCaption = "Configuration Send Error";
        const string configSendErrorMessage =  "No Response from Device";       
        const string configSendSuccessCaption = "Configuration Sent";
        const string configSendSuccessMessage =  "Device recieved configuration settings";     

        int bytesAvailable = 0;

        int sensorSelectConfig = 0;
        bool timerTicking = false;


        public Form1()
        {
            InitializeComponent();
            panel_mainMenu.Hide();
            panel_test.Hide();
            panel_configuration.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }




        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!comPort.IsOpen)
            {
                comPort.Open();

                //comPort.Encoding = Encoding.GetEncoding(28591);
                System.Text.Encoding.GetEncoding(28591);
                toolStripStatusLabel_port.Text = "Device Connected";
                
                button_connect_comPort.Visible = false;
                button_disconnectComPort.Visible =true;

                panel_connectPort.Hide();
                panel_mainMenu.Show();
                comPort.ReadExisting();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                int x = 0;
                var inBuffer = new char[256];
                int bytesAvailable = 0;

                //string text = richTextBox1.Text;
                //serialPort1.WriteLine(text);
                bytesAvailable = comPort.BytesToRead;
                comPort.ReadLine();
                for (x = 0; x < bytesAvailable; x++)
                {
                    //richTextBox1.Text = inBuffer.ToString();
                }


            }
        }

 
        private void ToolStripMenuItem_configuration_Click(object sender, EventArgs e)
        {
            panel_mainMenu.Hide();
            panel_connectPort.Hide();
            panel_test.Hide();
            panel_configuration.Show();
                     
        }


        private void comboBox_ports_DropDown(object sender, EventArgs e)
        {
            int x;
            string[] ports = SerialPort.GetPortNames();

            comboBox_ports.Items.Clear();

            for (x = 0; x < ports.Length; x++)
            {
                comboBox_ports.Items.Add(ports[x]);
            }
        }

        private void comboBox_ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            comPort.PortName = comboBox_ports.SelectedItem.ToString();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_connectPort.Visible = true;
        }

        private void button_disconnectComPort_Click(object sender, EventArgs e)
        {
            comPort.Close();


            button_disconnectComPort.Hide();
            button_connect_comPort.Show();

            if (!comPort.IsOpen)
                toolStripStatusLabel_port.Text = "Device Disconnected";

        }


        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_connectPort.Visible = true;
        }




        private void button_runLedCalibration_Click(object sender, EventArgs e)
        {
            int x = 0;
            int pwmRedValue = 0;
            int pwmIrValue = 0;
            var inBuffer = new byte[8];
            var outBuffer = new byte[8];

            comPort.ReadExisting();

            outBuffer[x++] = 0x52;     /*  Request Packet */
            outBuffer[x++] = 0x03;     /*  Opcode for Config Req*/

            comPort.Write(outBuffer, 0, x);
            x = 0;
            while (comPort.BytesToRead == 0) ;
            bytesAvailable = comPort.BytesToRead;
            comPort.Read(inBuffer, 0, bytesAvailable);
            bytesAvailable = comPort.BytesToRead;
            comPort.Read(inBuffer, 0, bytesAvailable);
            //if (bytesAvailable == 0)
              //  MessageBox.Show(configSendErrorMessage, configSendErrorCaption);
           // else
             //   MessageBox.Show(configSendSuccessMessage, configSendSuccessCaption);

            while (comPort.BytesToRead == 0);
            bytesAvailable = comPort.BytesToRead;
                comPort.Read(inBuffer, 0, bytesAvailable);
                pwmRedValue = (inBuffer[3] << 8) + inBuffer[4];
                textBox_pwmRedValue.Text = pwmRedValue.ToString();

                pwmIrValue = (inBuffer[5] << 8) + inBuffer[6];
                textBox_pwmIrValue.Text = pwmIrValue.ToString();
                //MessageBox.Show("Calibration Complete", "CALIBRATION STATUS");

        }

        private void button_deviceSetup_Click(object sender, EventArgs e)
        {
            panel_mainMenu.Hide();
            panel_configuration.Show();
        }

        private void button_newTest_Click(object sender, EventArgs e)
        {
            panel_mainMenu.Hide();
            panel_test.Show();
        }




        private void button_sensorSelectChange_Click(object sender, EventArgs e)
        {
            button_sensorSelectChange.Hide();
            button_sensorSelectConfirm.Show();
            sensorSelect.Enabled = true;

        }

        private void checkBox_Fp1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Fp1.Checked)
                sensorSelectConfig |= FP1;
            else
                sensorSelectConfig &= ~FP1;

        }

        private void checkBox_Fp2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Fp2.Checked)
                sensorSelectConfig |= FP2;
            else
                sensorSelectConfig &= ~FP2;
        }

        private void checkBox_F8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_F8.Checked)
                sensorSelectConfig |= F8;
            else
                sensorSelectConfig &= ~F8;
        }

        private void checkBox_F7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_F7.Checked)
                sensorSelectConfig |= F7;
            else
                sensorSelectConfig &= ~F7;
        }

        private void checkBox_T3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T3.Checked)
                sensorSelectConfig |= T3;
            else
                sensorSelectConfig &= ~T3;
        }

        private void checkBox_T4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T4.Checked)
                sensorSelectConfig |= T4;
            else
                sensorSelectConfig &= ~T4;
        }

        private void checkBox_T5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T5.Checked)
                sensorSelectConfig |= T5;
            else
                sensorSelectConfig &= ~T5;
        }

        private void checkBox_T6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_T6.Checked)
                sensorSelectConfig |= T6;
            else
                sensorSelectConfig &= ~T6;
        }

        private void checkBox_O1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_O1.Checked)
                sensorSelectConfig |= O1;
            else
                sensorSelectConfig &= ~O1;
        }

        private void checkBox_O2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_O2.Checked)
                sensorSelectConfig |= O2;
            else
                sensorSelectConfig &= ~O2;
        }

        private void comboBox_sampleRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {

                int x = 0;
                var inBuffer = new byte[8];
                var outBuffer = new byte[8];


                inBuffer[x++] = 0x52;     /*  Request Packet */
                inBuffer[x++] = 0x04;     /*  Opcode for Config Req*/

                comPort.Write(inBuffer, 0, x);
                x = 0;
                bytesAvailable = comPort.BytesToRead;
                comPort.Read(outBuffer, 0, bytesAvailable);

                if (bytesAvailable == 0)
                    MessageBox.Show(configSendErrorMessage, configSendErrorCaption);
                else
                {
                    MessageBox.Show(configSendSuccessMessage, configSendSuccessCaption);


                    inBuffer[x++] = 0x69;   /* IND Packet */
                    inBuffer[x++] = 0x01;   /* Command Code for setting sample time*/
                    inBuffer[x++] = 0x02;   /* Number of data bytes sending */
                    inBuffer[x++] = 0x00;   /* To Do:  Packet Numbering */
                    inBuffer[x++] = 0x00;
                    inBuffer[x++] = Convert.ToByte(0xFF & Convert.ToInt16(comboBox_sampleRate.SelectedIndex));

                    comPort.Write(inBuffer, 0, x);
                    x = 0;
                }// end sample length send

            }
            else
                MessageBox.Show(comPortErrorMessage, comPortErrorCaption);
        }



        private void button_sensorSelectConfirm_Click(object sender, EventArgs e)
        {
            
            button_sensorSelectConfirm.Hide();
            button_sensorSelectChange.Show();
            sensorSelect.Enabled = false;

            /* send sensor configuration */

            if (comPort.IsOpen)
            {

                int x = 0;
                var inBuffer = new byte[8];
                var outBuffer = new byte[8];
               

                inBuffer[x++] = 0x52;     /*  Request Packet */
                inBuffer[x++] = 0x04;     /*  Opcode */

                comPort.Write(inBuffer, 0, x);
                x = 0;
                bytesAvailable = comPort.BytesToRead;
                comPort.Read(outBuffer, 0, bytesAvailable);

                if (bytesAvailable == 0)
                    MessageBox.Show(configSendErrorMessage, configSendErrorCaption);
                else
                {
                    MessageBox.Show(configSendSuccessMessage, configSendSuccessCaption);


                    inBuffer[x++] = 0x69;   /* IND Packet */
                    inBuffer[x++] = 0x00;   /* Command Code for Sensor Setup */
                    inBuffer[x++] = 0x02;   /* Number of data bytes sending */
                    inBuffer[x++] = 0x00;   /* To Do:  Packet Numbering */
                    inBuffer[x++] = Convert.ToByte((0xFF00 & sensorSelectConfig) >> 8);
                    inBuffer[x++] = Convert.ToByte(0xFF & sensorSelectConfig);

                    comPort.Write(inBuffer, 0, x);
                    x = 0;
                }// end sensorSelect send
            }
            else
                MessageBox.Show(comPortErrorMessage, comPortErrorCaption);
        }




        


        private void button_startTest_Click(object sender, EventArgs e)
        {
            

            if (button_startTest.Text == "Abort Test")
            {
                button_startTest.Text = "Start Test";
            }
            else
            {
                button_startTest.Text = "Abort Test";

                string path = @"C:\Users\Public\Documents\nirsdata.hex";
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    writer.Seek(0, 0);
                }
                //using (StreamWriter sw = File.CreateText(path))
                //{
                //    sw.WriteLine("Patient Name:  " + Convert.ToString(textBox_patientName.Text));
                //    sw.WriteLine("Sample Rate:  " + Convert.ToString(comboBox_sampleRate.Text));
                //    sw.WriteLine("Test Duration:  " + Convert.ToString(comboBox_testDuration.Text));
                //    sw.WriteLine("");
                //    sw.WriteLine("");
                //}
               
                UInt16 x = 0;
                var inBuffer = new byte[64];
                var outBuffer = new byte[8];
                bool dataToRead = true;
                bool evenPacket = true;
                int averageCount = 0;
                int currentPosition = 0;
                uint sensorOne = 0;
                uint sensorTwo = 0;
                uint sensorThree = 0;
                uint sensorFour = 0;
                uint sensorFive = 0;
                uint sensorSix = 0;
                uint sensorSeven = 0;
                uint sensorEight = 0;
                uint sensorNine = 0;
                uint sensorTen = 0;

                outBuffer[x++] = 0x52;     /*  Request Packet */
                outBuffer[x++] = 0x01;     /*  Opcode for Start Measurement Request */

                comPort.Write(outBuffer, 0, x);      /* Send Command */

                bytesAvailable = comPort.BytesToRead;

                comPort.Read(inBuffer, 0, bytesAvailable); /*  Check for return status */

                //if ((inBuffer[0] == 0x43) && (inBuffer[1] == 0x01) && (inBuffer[3] == 0x00))
                    //bytesAvailable = 4;
                //MessageBox.Show(configSendSuccessMessage, configSendSuccessCaption);
                //if (inBuffer[3] == 0x01)
                  //  MessageBox.Show(configSendErrorMessage, configSendErrorCaption);
               


                while(comPort.BytesToRead == 0);
                
                while (dataToRead)
                {
                        if (comPort.BytesToRead >= 64)
                        {
                            comPort.Read(inBuffer, 0, 64);
                            //y = 0;
                            //for (x = 0; x < 29; x++)
                            //{
                            //    tempvalue[x] = inbuffer[y++] << 8;
                            //    tempvalue[x] |= inbuffer[y++];
                            //}

                            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Open)))
                            {
                                writer.Seek(currentPosition, 0);
                                writer.Write(inBuffer);
                                currentPosition = currentPosition + 64;
                                if (evenPacket)
                                {
                                    sensorOne = ((sensorOne + Convert.ToUInt32(((inBuffer[4] << 8) + inBuffer[5]) + ((inBuffer[44] << 8) + inBuffer[45]))) / 3);
                                    sensorTwo = ((sensorTwo + Convert.ToUInt32(((inBuffer[6] << 8) + inBuffer[7]) + ((inBuffer[46] << 8) + inBuffer[47]))) / 3);
                                    sensorThree = ((sensorThree + Convert.ToUInt32(((inBuffer[8] << 8) + inBuffer[9]) + ((inBuffer[48] << 8) + inBuffer[49]))) / 3);
                                    sensorFour = ((sensorFour + Convert.ToUInt32(((inBuffer[10] << 8) + inBuffer[11]) + ((inBuffer[50] << 8) + inBuffer[51]))) / 3);
                                    sensorFive = ((sensorFive + Convert.ToUInt32(((inBuffer[12] << 8) + inBuffer[13]) + ((inBuffer[52] << 8) + inBuffer[53]))) / 3);
                                    sensorSix = ((sensorSix + Convert.ToUInt32(((inBuffer[14] << 8) + inBuffer[15]) + ((inBuffer[54] << 8) + inBuffer[55]))) / 3);
                                    sensorSeven = ((sensorSeven + Convert.ToUInt32(((inBuffer[16] << 8) + inBuffer[17]) + ((inBuffer[56] << 8) + inBuffer[57]))) / 3);
                                    sensorEight = ((sensorEight + Convert.ToUInt32(((inBuffer[18] << 8) + inBuffer[19]) + ((inBuffer[58] << 8) + inBuffer[59]))) / 3);
                                    sensorNine = ((sensorNine + Convert.ToUInt32(((inBuffer[20] << 8) + inBuffer[21]) + ((inBuffer[60] << 8) + inBuffer[61]))) / 3);
                                    sensorTen = ((sensorTen + Convert.ToUInt32(((inBuffer[22] << 8) + inBuffer[23]) + ((inBuffer[62] << 8) + inBuffer[63]))) / 3);

                                    averageCount++;

                                    if (averageCount > 5)
                                    {
                                        progressBar_sensor1.Increment(Convert.ToInt32(sensorOne) - progressBar_sensor1.Value);
                                        progressBar_sensor2.Increment(Convert.ToInt32(sensorTwo) - progressBar_sensor2.Value);
                                        progressBar_sensor3.Increment(Convert.ToInt32(sensorThree) - progressBar_sensor3.Value);
                                        progressBar_sensor4.Increment(Convert.ToInt32(sensorFour) - progressBar_sensor4.Value);
                                        progressBar_sensor5.Increment(Convert.ToInt32(sensorFive) - progressBar_sensor5.Value);
                                        progressBar_sensor6.Increment(Convert.ToInt32(sensorSix) - progressBar_sensor6.Value);
                                        progressBar_sensor7.Increment(Convert.ToInt32(sensorSeven) - progressBar_sensor7.Value);
                                        progressBar_sensor8.Increment(Convert.ToInt32(sensorEight) - progressBar_sensor8.Value);
                                        progressBar_sensor9.Increment(Convert.ToInt32(sensorNine) - progressBar_sensor9.Value);
                                        progressBar_sensor10.Increment(Convert.ToInt32(sensorTen) - progressBar_sensor10.Value);
                                        progressBar_sensor1.Increment(Convert.ToInt32(sensorOne) - progressBar_sensor1.Value);
                                        progressBar_sensor1.Increment(Convert.ToInt32(sensorOne) - progressBar_sensor1.Value);
                                        progressBar_sensor1.Increment(Convert.ToInt32(sensorOne) - progressBar_sensor1.Value);
                                        progressBar_sensor1.Increment(Convert.ToInt32(sensorOne) - progressBar_sensor1.Value);
                                        averageCount = 0;
                                    }
                                }

                                //sw.WriteLine(inBuffer, 0, 64);
                                evenPacket = !evenPacket;
                            }

                            
                        }
                        else if(comPort.BytesToRead == 0x4)
                        {
                             comPort.Read(inBuffer, 0, 4);
                             using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Open)))
                             {
                                 writer.Seek(currentPosition, 0);
                                 for(x = 0; x < 4; x++)
                                 {
                                     writer.Write(inBuffer[x]);
                                 }
                                
                             }
                             MessageBox.Show("Test Complete ", "Test Status");
                             dataToRead = false;
                             button_startTest.Text = "Start Test";

                        }
                }
            }
        }
    

        private void comboBox_testDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {

                int x = 0;
                var inBuffer = new byte[8];
                var outBuffer = new byte[8];


                inBuffer[x++] = 0x52;     /*  Request Packet */
                inBuffer[x++] = 0x04;     /*  Opcode for Config Req*/

                comPort.Write(inBuffer, 0, x);
                x = 0;
                bytesAvailable = comPort.BytesToRead;

                comPort.Read(outBuffer, 0, bytesAvailable);



                if (bytesAvailable == 0)
                    MessageBox.Show(configSendErrorMessage, configSendErrorCaption);
                else
                {
                    MessageBox.Show(configSendSuccessMessage, configSendSuccessCaption);


                    inBuffer[x++] = 0x69;   /* IND Packet */
                    inBuffer[x++] = 0x02;   /* Command Code for setting sample time*/
                    inBuffer[x++] = 0x02;   /* Number of data bytes sending */
                    inBuffer[x++] = 0x00;   /* To Do:  Packet Numbering */
                    inBuffer[x++] = 0x00;
                    inBuffer[x++] = Convert.ToByte(0xFF & Convert.ToInt16(comboBox_testDuration.SelectedIndex));
                    
                    comPort.Write(inBuffer, 0, x);
                    x = 0;
                }// end sample length send



            }
            else
                MessageBox.Show(comPortErrorMessage, comPortErrorCaption);


        }

        private void ToolStripMenuItem_Test_Click(object sender, EventArgs e)
        {
            panel_configuration.Hide();
            panel_mainMenu.Hide();
            panel_connectPort.Hide();
            panel_test.Show();
        }


        private void textBox_patientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }





    }
}
