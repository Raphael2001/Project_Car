using Project_Car.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_Car.UI
{
    public partial class Form_Report : Form
    {
        int Num, Count;
        public Form_Report(int n)
        {
            InitializeComponent();

            Num = n;

            RadioButton(false);
            GetFun(Num);
            rb_Month.Checked = true;
        }

        public void CarExtraBuyToChart(DateTime dt)
        {
            RadioButton(true);

            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution");

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            OrderDetailsBuyArr detailsBuy = new OrderDetailsBuyArr();
            detailsBuy.Fill();

            CarExtraArr carExtraArr = detailsBuy.GetCarExtraArr();
            foreach (CarExtra extra in carExtraArr)
            {
                Count = detailsBuy.Filter(extra, dt).Count;
                if (Count > 0)
                {
                    dictionary.Add(extra.Name, Count);
                }
            }


            Series series = new Series("Car Extra", carExtraArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);

        }

        public void CarExtraRentToChart(DateTime dt)
        {
            RadioButton(true);


            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution");

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            OrderDetailsRentArr order = new OrderDetailsRentArr();
            order.Fill();

            CarExtraArr car = order.GetCarExtraArr();
            foreach (CarExtra extra in car)
            {
                Count = order.Filter(extra, dt).Count;
                if (Count > 0)
                {
                    dictionary.Add(extra.Name, Count);
                }
            }

            Series series = new Series("Car Extra", car.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);

        }

        public void CarBuyToChart(DateTime dt)
        {
            RadioButton(true);


            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution");

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            OrderBuyArr orderArr = new OrderBuyArr();
            orderArr.Fill();

            ProductArr productArr = orderArr.GetProductArr();
            CarArr carArr = productArr.GetCarArr();
            foreach (Car car in carArr)
            {
                Count = orderArr.Filter(car, dt).Count;
                if (Count > 0)
                {
                    dictionary.Add(car.Category + "" + car.Model, Count);
                }
            }

            Series series = new Series("Products", productArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);
        }

        public void DesignToChart(DateTime dt)
        {
            RadioButton(true);


            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution");

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            OrderBuyArr orderArr = new OrderBuyArr();
            orderArr.Fill();

            CarDesignArr carDesignArr = orderArr.GetCarDesignArr();
            foreach (CarDesign car in carDesignArr)
            {
                Count = orderArr.Filter(car, dt).Count;
                if (Count > 0)
                {
                    dictionary.Add(car.FullDesign, Count);
                }
            }

            Series series = new Series("Products", carDesignArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);
        }

        public void CarRentToChart(DateTime dt)
        {
            RadioButton(true);


            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution");

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            OrderRentArr orderArr = new OrderRentArr();
            orderArr.Fill();

            ProductArr productArr = orderArr.GetProductArr();
            CarArr carArr = productArr.GetCarArr();
            foreach (Car car in carArr)
            {
                Count = orderArr.Filter(car, dt).Count;
                if (Count > 0)
                {
                    dictionary.Add(car.Category + "" + car.Model, Count);
                }
            }

            Series series = new Series("Products", productArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);
        }

        public void EmployeeBuyToChart(DateTime dt)
        {
            RadioButton(true);

            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution");

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            OrderBuyArr detailsBuy = new OrderBuyArr();
            detailsBuy.Fill();

            EmployeeArr employeeArr = detailsBuy.GetEmployeeArr();
            foreach (Employee employee in employeeArr)
            {
                Count = detailsBuy.Filter(employee, dt).Count;
                if (Count > 0)
                {
                    dictionary.Add(employee.Fullname, Count);
                }
            }

            Series series = new Series("Employee", employeeArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);

        }

        public void EmployeeRentToChart(DateTime dt)
        {
            RadioButton(true);

            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Distribution");

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            OrderRentArr detailsRent = new OrderRentArr();
            detailsRent.Fill();

            EmployeeArr employeeArr = detailsRent.GetEmployeeArr();
            foreach (Employee employee in employeeArr)
            {
                Count = detailsRent.Filter(employee, dt).Count;
                if (Count > 0)
                {
                    dictionary.Add(employee.Fullname, Count);
                }
            }

            Series series = new Series("Employee", employeeArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);

        }

        public void DateBuyToChart()
        {
            RadioButton(false);

            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Months Purchased In");

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            OrderBuyArr orderArr = new OrderBuyArr();
            orderArr.Fill();

            DateTime dateTime = new DateTime(DateTime.Now.Year, 1, 1);

            while (dateTime < DateTime.Now.Date)
            {
                dictionary.Add(dateTime.ToString("MMM", CultureInfo.InvariantCulture), orderArr.Filter(dateTime).Count);

                dateTime = dateTime.AddMonths(1);
            }

            Series series = new Series("Month", orderArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);

        }

        public void DateRentToChart()
        {
            RadioButton(false);

            chart1.Palette = ChartColorPalette.SeaGreen;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            chart1.Titles.Clear();
            chart1.Titles.Add("Months Purchased In");

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            OrderRentArr orderArr = new OrderRentArr();
            orderArr.Fill();

            DateTime dateTime = new DateTime(DateTime.Now.Year, 1, 1);

            while (dateTime < DateTime.Now.Date)
            {
                dictionary.Add(dateTime.ToString("MMM", CultureInfo.InvariantCulture), orderArr.Filter(dateTime).Count);

                dateTime = dateTime.AddMonths(1);
            }

            Series series = new Series("Month", orderArr.Count);
            series.ChartType = SeriesChartType.Column;

            series.Label = "[#PERCENT{P0}]";
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            chart1.Series.Clear();
            chart1.Series.Add(series);

        }

        public void RadioButton(bool status)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).Visible = status;
                }
            }
        }

        public DateTime GetDate()
        {
            DateTime dateTime = DateTime.Now;

            if (rb_Month.Checked)
            {
                return dateTime.AddMonths(-1);
            }
            else if (rb_Two.Checked)
            {
                return dateTime.AddMonths(-2);
            }
            else if (rb_Year.Checked)
            {
                return dateTime.AddYears(-1);
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            GetFun(Num);
        }

        public void GetFun(int Num)
        {

            switch (Num)
            {
                case 1:
                    CarExtraBuyToChart(GetDate());
                    break;
                case 2:
                    CarExtraRentToChart(GetDate());
                    break;
                case 3:
                    CarBuyToChart(GetDate());
                    break;
                case 4:
                    CarRentToChart(GetDate());
                    break;
                case 5:
                    DesignToChart(GetDate());
                    break;
                case 6:
                    EmployeeBuyToChart(GetDate());
                    break;
                case 7:
                    EmployeeRentToChart(GetDate());
                    break;
                case 8:
                    DateBuyToChart();
                    break;
                case 9:
                    DateRentToChart();
                    break;
                default:
                    MessageBox.Show("Error");
                    break;

            }


        }
    }
}
