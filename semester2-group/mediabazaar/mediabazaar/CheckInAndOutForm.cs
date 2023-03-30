using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO.Ports;
using System.Threading;
using System.Media;
using Logic;


namespace mediabazaar
{
    public partial class CheckInAndOutForm : Form
    {
        static SerialPort serialPort ;
        List<string> CardIDs = new List<string>();
        Employee? employee = null;
        List<DateTime> dateTimesStart = new List<DateTime>();
        List<DateTime> dateTimesProcess = new List<DateTime>();



        SalesService salesService = new SalesService();
        public CheckInAndOutForm()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            CardIDs.Add("3396800034");
            serialPort.Open();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                if (serialPort.BytesToRead > 0)
                {
                    string input = serialPort.ReadLine();
                    input = input.Trim();

                    employee = salesService.GetEmployeeByRfid(input);

                    
                    if (employee != null)
                    {
                        if (input == employee.Rfid.SerialNumber)
                        {
                            string message = "AccesGranted";
                            using (var soundPlayer = new SoundPlayer(@"retinal_scanner_access_granted01.wav"))
                            {
                                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                                dateTimesStart = SalesService.GetShiftsDate(employee.Id);
                                dateTimesProcess = SalesService.GetProccessDates(input);
                                foreach (var item in dateTimesStart)
                                {
                                    if (dateTimesProcess.Contains(item))
                                    {

                                    }
                                    else
                                    {
                                        SalesService.Absent(employee);
                                    }
                                }
                            }

                            SalesService.CheckIn(message, salesService.GetEmployeeByRfid(input));
                            

                        }
                    }
                    else
                    {
                        string message = "AccesDenied";
                        using (var soundPlayer = new SoundPlayer(@"doorlocked_buzz1.wav"))
                        {
                            soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                        }
                    }
                }
            }
            else
            {
                serialPort.Close();
            }
           
        }
    }
}
