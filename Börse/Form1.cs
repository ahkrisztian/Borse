using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Börse
{
    public partial class Form1 : Form
    {
        static Timer myTimer = new Timer();
        public static double eurodollar { get; set; }

        public static string key { get; set; }
        public static string workername { get; set; }
       

        public List<WorkerCall.HardwareModel> hardwaresList = new List<WorkerCall.HardwareModel>();
        public Form1()
        {
            MessageBox.Show(key);
            InitializeComponent();
            ApiHelper.InitializeClient();
            Load += new EventHandler(startButton_Click);
            Load += new EventHandler(button2_Click);
            Load += new EventHandler(comboBox1_SelectedIndexChanged);
            
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await LoadCoinData(comboBox1.Text);
        }

        private async Task LoadCoinData(string coinName)
        {
            var coin = await LoadCoinsProcessor.LoadCoin(comboBox1.Text);

            coinNameLabel.Text = coin.name;
            label2.Text = $"{Math.Round(coin.price / eurodollar, 3)}€";

        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                await LoadCoinData(comboBox1.Text);
            }
            catch
            {
                MessageBox.Show("Please try again!");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var worker = await LoadWorkerProcessor.LoadWorker(key, workername);

            List<WorkerModel.Hardware> hardwares = new List<WorkerModel.Hardware>();

            foreach (var v in worker.WORKER001.hardware)
            {
                var model = new WorkerModel.Hardware { name = v.name, temp = v.temp, power = v.power };
                hardwares.Add(model);
            }


            foreach(var hardware in hardwares)
            {
                hardwaresList.Add(new WorkerCall.HardwareModel { name = hardware.name, power = hardware.power, temp = hardware.temp});
            }

            foreach (var v in hardwaresList) { hardwarecomboBox.Items.Add(v.name); };


            workerLabel.Text = worker.WORKER001.info.name;

            if(worker.WORKER001.info.status == "online")
            {
                workerNamegroupBox.BackColor = Color.LightGreen;
            }
            else
            {
                workerNamegroupBox.BackColor = Color.IndianRed;
            }

            dayLabel.Text = $"Day: {Math.Round(worker.WORKER001.revenue.usd_day / eurodollar, 2)} €";
            weekLabel.Text = $"Week: {Math.Round(worker.WORKER001.revenue.usd_week / eurodollar, 2)} €";
            monthLabel.Text = $"Month: {Math.Round(worker.WORKER001.revenue.usd_month / eurodollar, 2)} €";

            miningClientlabel.Text = worker.WORKER001.mining.client;


            foreach (var v in hardwaresList)
            {
                hardwareNameLabel.Text = v.name;
                powerLabel.Text = $"{v.power} W";
                tempLabel.Text = $"{v.temp} C";
            }

            timerLoad();

        }

        private void timerLoad()
        {
            dateTimelabel.Text = $"Last update: {DateTime.UtcNow}";
            myTimer.Interval = (600000); 
            myTimer.Tick += new EventHandler(button2_Click);
            myTimer.Tick += new EventHandler(comboBox1_SelectedIndexChanged);
            myTimer.Tick += new EventHandler(startButton_Click);
            myTimer.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            foreach (var v in CoinsCall.LoadCoinList.coinModels()) { comboBox1.Items.Add(v.name); };
            
            eurodollar = GetStockPrice.GetStat.StatString("https://www.marketwatch.com/investing/currency/eurusd");

            dollareuroLabel.Text = $"Euro  {eurodollar}$";
            stocklabel1.Text = $"DAX: {CoinsCall.LoadCoinList.StockPrice("https://www.marketwatch.com/investing/index/dax?countrycode=dx&mod=over_search")} €";
            stocklabel2.Text = $"NVIDIA: {CoinsCall.LoadCoinList.StockDollarToEuro("https://www.marketwatch.com/investing/stock/nvda?mod=over_search")} €";
            stocklabel3.Text = $"AMD: {CoinsCall.LoadCoinList.StockDollarToEuro("https://www.marketwatch.com/investing/stock/amd?mod=over_search")} €";
            stocklabel4.Text = $"INTEL: {CoinsCall.LoadCoinList.StockDollarToEuro("https://www.marketwatch.com/investing/stock/intc?mod=over_search")} €";
        }

        private void hardwarecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gpu = hardwaresList[hardwarecomboBox.SelectedIndex];

            hardwareNameLabel.Text = gpu.name;
            powerLabel.Text = $"{gpu.power} W";
            tempLabel.Text = $"{gpu.temp} C";
        }
    }
}
