using CodeFirst.Entities;
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
    public partial class Form1 : Form
    {
        private BusModel _busModel;
        public Form1()
        {
            InitializeComponent();
            _busModel = new BusModel();
            //var trip = new Trip
            //{
            //    Bus = _busModel.Buses.First(),
            //    ArrivalTime = DateTime.Now,
            //    ArrivalCityId = 2,
            //    DepartureCityId=2,
            //    DepartureTime=DateTime.Now
            
            //};
            //_busModel.Trips.Add(trip);
            //_busModel.SaveChanges();
            //var dbTrip = _busModel.Trips.First();
            FillBusList();
        }

        private void FillBusList()
        {
            lstBuses.Items.Clear();
            lstBuses.Items.AddRange(_busModel.Buses.ToArray());
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusName.Text) == false && string.IsNullOrWhiteSpace(txtPlateNumber.Text) == false)
            {
                var bus = new Bus
                {
                    Name = txtBusName.Text,
                    PlateNumber = txtPlateNumber.Text,
                    SeatCount = (int)nudSeatCounter.Value
                };
                _busModel.Buses.Add(bus);
                _busModel.SaveChanges();
                FillBusList();
            }
        }

        private void lstBuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBuses.SelectedIndex != -1)
            {
                var selectedBus = (Bus)lstBuses.SelectedItem;
                txtBusName.Text = selectedBus.Name;
                txtPlateNumber.Text = selectedBus.PlateNumber;
                nudSeatCounter.Value = selectedBus.SeatCount;

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lstBuses.SelectedIndex != -1)
            {
                var bus = new Bus
                {
                    Id = ((Bus)lstBuses.SelectedItem).Id,
                    Name = txtBusName.Text,
                    PlateNumber = txtPlateNumber.Text,
                    SeatCount = (int)nudSeatCounter.Value
                };
                var original = _busModel.Buses.FirstOrDefault(x => x.Id == bus.Id);
                if (original != null)
                {
                    original.Name = bus.Name;
                    original.PlateNumber = bus.PlateNumber;
                    original.SeatCount = bus.SeatCount;

                    _busModel.SaveChanges();
                    FillBusList();
                }
            }
           
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstBuses.SelectedIndex != -1)
            {
                var busId = ((Bus)lstBuses.SelectedItem).Id;
                Bus bus = _busModel.Buses.FirstOrDefault(x => x.Id == busId);
                _busModel.Buses.Remove(bus);
                _busModel.SaveChanges();
                FillBusList();
            }
        }
    }
}
