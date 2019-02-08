using CodeFirst.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class AnaForm : Form
    {
        BusModel _busModel;
        Bus _bus;
        public AnaForm()
        {
            InitializeComponent();
            _busModel = new BusModel();
            _bus = new Bus();
            groupBox1.Visible = false;
            comboxBusList.Items.AddRange(_busModel.Buses.ToArray());
            comboxBusList.SelectedItem = _busModel.Buses.ToArray().FirstOrDefault();
            comboxDeparture.Items.AddRange(_busModel.Cities.ToArray());
            comboxArrival.Items.AddRange(_busModel.Cities.ToArray());

        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            SeatList();
               
        }

        private void newButton_Click(object sender, EventArgs e)
        {

            if (comboxBusList.SelectedItem.ToString() != null || comboxArrival.SelectedItem.ToString() != null || comboxDeparture.SelectedItem.ToString() != null )
            {
                try
                {
                    string msg = Interaction.InputBox("Adınızı Ve Soyadınızı Giriniz?", "Title", "Default Text");
                    string departureCity = comboxDeparture.SelectedItem.ToString();
                    string arrivalCity = comboxArrival.SelectedItem.ToString();
                    DateTime date = Convert.ToDateTime(dateTimePicker2.Text);
                    MessageBox.Show("Merhaba " + msg + departureCity + " ilinden " + arrivalCity + " iline " + dateTimePicker2.Text + " tarihli biletiniz oluşturulmuştur ");
                  ((Control )sender).BackColor = Color.Red;
                    ((Control)sender).Enabled = false;


                }
                catch (Exception)
                {

                    MessageBox.Show("Bilgiler eksik lütfen gerekli bilgileri giriniz");
                }
              
            }
     
        
        }

        private void comboxBusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBus.Controls.Clear();
            SeatList();
        }

        private void SeatList()
        {
            List<Bus> busList = _busModel.Buses.ToList();
            int seatCount = (from b in busList
                             where b.Id == comboxBusList.SelectedIndex + 1
                             select b.SeatCount).Single();
            int number = 1;
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < seatCount / 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 2 || i * j > seatCount) {

                        continue;
                    }
                        
                    
                    Button newButton = new Button();
                    newButton.Text = (number).ToString();
                    newButton.Location = new Point(293 - (i * 46), 20 + (j * 46));
                    newButton.Width = 50;
                    newButton.Height = 40;
                    newButton.BackColor = Color.Orange;
                    newButton.Name = "Seat" + (number++);
                    newButton.Click += new EventHandler(newButton_Click);
                    buttons.Add(newButton);
                    panelBus.Controls.Add(newButton);
                }

            }
        }
    }
}
