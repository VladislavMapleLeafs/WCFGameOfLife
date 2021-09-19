using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        ServiceReference.ServiceClient client;
        public int numOfThreads;
        public int[] arr;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            comboBoxSize.SelectedIndex = 0;
            comboBoxThreads.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Time:";
            if (client != null)
            {
                client.Close();
            }
            client = new ServiceReference.ServiceClient();

            if (comboBoxSize.SelectedIndex == 0)
            {
                arr = new int[300 * 300];
            }
            else
            {
                arr = new int[600 * 600];
            }

            int n = (int)Math.Sqrt(arr.Length);
            for (int i = 0; i < n; i++)
            {
                if (random.NextDouble() < 0.25)
                    arr[i] = 1;
            }

            numOfThreads = Convert.ToInt32(comboBoxThreads.Text);
            DateTime time1 = DateTime.Now; DateTime time2 = DateTime.Now;
            client.gameOfLife(ref arr, numOfThreads, ref time1, ref time2);
            labelResult.Text = "Time: " +
                ((int)(time2 - time1).TotalMilliseconds).ToString() + " ms.";
            int[,] result = new int[n, n];

            int z = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = arr[z];
                    z++;
                }
            }
            
        }
    }
}
