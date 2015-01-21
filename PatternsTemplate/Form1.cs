using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsTemplate
{
    public partial class Form1 : Form, IView, IObserver
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxFlightClass.DataSource = Enum.GetValues(typeof(FlightClass));
            comboBoxFlightTime.DataSource = Enum.GetValues(typeof(FlightTime));
            comboBoxFlightDestination.DataSource = new BindingSource(FlightHelper.Instance.DistanceToDestination.Keys, null);

            comboBoxFlightDestination.SelectedItem = null;
            comboBoxFlightClass.SelectedItem = null;
            comboBoxFlightTime.SelectedItem = null;
        }

        IController controller;//интерфейс IView
        public void SetController(IController controller)
        {
            this.controller = controller;
        }
        public bool IsValid()
        {
            if (comboBoxFlightDestination.SelectedItem == null) return false;
            if (comboBoxFlightClass.SelectedItem == null) return false;
            if (comboBoxFlightClass.SelectedItem == null) return false;
            if ((numericUpDownAdults.Value == 0) && (numericUpDownChildren.Value == 0) && (numericUpDownBabies.Value == 0)) return false;
            return true;
        }
        public Flight GetFlight()
        {
            string destination = comboBoxFlightDestination.SelectedItem.ToString();

            int adults = (int)numericUpDownAdults.Value;
            int children = (int)numericUpDownChildren.Value;
            int babies = (int)numericUpDownBabies.Value;
            NumberOfPassengers passengers = new NumberOfPassengers(adults, children, babies);

            FlightClass flightClass;
            if (comboBoxFlightClass.SelectedItem.ToString() == "Business")
                flightClass = FlightClass.Business;
            else
                flightClass = FlightClass.Econom;

            FlightTime time;
            string tempTime = comboBoxFlightTime.SelectedItem.ToString();
            switch (tempTime)
            {
                case "Night":
                    time = FlightTime.Night;
                    break;
                case "Morning":
                    time = FlightTime.Morning;
                    break;
                case "Afternoon":
                    time = FlightTime.Afternoon;
                    break;
                case "Evening":
                    time = FlightTime.Evening;
                    break;
                default:
                    return null;
            }

            Flight flight = new Flight(destination, passengers, flightClass, time);

            return flight;
        }

        public void UpdatePrice(IModel model, ModelEventArgs e) // устанавливаем цену текущего запроса
        {
            textBoxResult.Text = e.Flight.Price.ToString();
        }

        public void UpdateForm(IModel model, ModelEventArgs e) // заполняем все поля формы
        {
            if (e.Flight != null)
            {
                comboBoxFlightDestination.SelectedItem = e.Flight.Destination;
                comboBoxFlightClass.SelectedItem = e.Flight.FlightClass;
                numericUpDownAdults.Value = e.Flight.Passengers.NumberOfAdults;
                numericUpDownChildren.Value = e.Flight.Passengers.NumberOfChildren;
                numericUpDownBabies.Value = e.Flight.Passengers.NumberOfBabies;
                textBoxResult.Text = e.Flight.Price.ToString();
            }
            else
                buttonUndo.Enabled = false;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                controller.CalculatePrice();
                buttonUndo.Enabled = true;
            }
            else
                textBoxResult.Text = "Недостаточно данных!";
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            controller.Undo();
        }
    }
}
