using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BIG_BROTHER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] hostproft = new string[4, 300];
        bool bb = false;
        private void Form1_Load(object sender, EventArgs e)
        {
          //  string[] filedata;
         //   filedata = System.IO.File.ReadAllLines ("hostes.txt");
          //  foreach (string parametr in filedata)
          //  {
        //        string[] a = parametr.Split('*');
        //        serversList.Add(a[0]);      
         //       serversnList.Add(a[1]);
         //   }            
         //   int i = 0;
         //   dataGridView1.Rows.Clear();
          //  foreach (string server in serversList)
          //  {
          //      pingReply = ping.Send(server);
            //        dataGridView1.Rows.Add();
            //        dataGridView1[0, i].Value = pingReply.Address; //IP
             //       dataGridView1[2, i].Value = pingReply.Status; //Статус
              //      dataGridView1[3, i].Value = pingReply.RoundtripTime; //Время ответа
              //      i++;
                
          //  }
         //   i = 0;
          //  foreach (string servern in serversnList)
           // {
           //     dataGridView1[1, i].Value = servern;
         //       i++;
           // }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();    
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Михалко А.В." + Environment.NewLine + "Контакты:" + Environment.NewLine + "E-mail: mihandr1@mail.ru");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void сборкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Beta 2.0");
        }

        private void редактироватьHostыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("hostes.txt");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i < dataGridView1.RowCount-1; i++)
            {
                new System.Threading.Thread(delegate () { a2(i); }).Start();
                Thread.Sleep(80);
            }      
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bb)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void byErehonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/erehon99");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bb = true;
            this.Close();
        }

        private void сканироватьСетьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            backgroundWorker2.RunWorkerAsync();

        }

        private void a1(int np)
        {

            Ping ping = new System.Net.NetworkInformation.Ping();
            PingReply pingReply2 = null;
            int col = np;
            pingReply2 = ping.Send("192.168.1." + col);
            hostproft[0,np]= ("192.168.1." + Convert.ToString(col));
            if (pingReply2.Status != IPStatus.Success)
                {
                hostproft[1, np] = ("ERROR!!!");
                hostproft[2, np] = Convert.ToString(pingReply2.Status); 
            }
                else
                {
                System.Net.IPHostEntry ip = System.Net.Dns.GetHostEntry("192.168.1." + col);
                hostproft[1, np] = (ip.HostName);
                hostproft[2, np] = "Success";
                hostproft[3, np] = Convert.ToString(pingReply2.RoundtripTime); //Время ответа
            }
            this.progressBar1.BeginInvoke((MethodInvoker)(delegate
            {
                progressBar1.Value++;
            }));
        }
        private void a2(int np)
        {
            Ping ping = new System.Net.NetworkInformation.Ping();
            PingReply pingReply = null;
            while (true)
            {

                    pingReply = ping.Send(Convert.ToString(dataGridView1[0, np].Value));

                    if (pingReply.Status == IPStatus.Success) dataGridView1[2, np].Style.BackColor = Color.Green;
                    else
                    {
                        dataGridView1[2, np].Style.BackColor = Color.Red;
                      //  notifyIcon1.ShowBalloonTip(4, "Проблемы с соединением!", "Нет доступа к " + dataGridView1[1, np].Value + " Хост: " + dataGridView1[0, np].Value, ToolTipIcon.Warning);
                    }
                    dataGridView1[2, np].Value = pingReply.Status; //Статус
                    dataGridView1[3, np].Value = pingReply.RoundtripTime; //Время ответа

                Thread.Sleep(100);
            }
        }

            private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i < 240; i++)
            {
                new System.Threading.Thread(delegate () { a1(i); }).Start();
                Thread.Sleep(20);
            }
            while(progressBar1.Value!=240)
            { }
             this.dataGridView1.BeginInvoke((MethodInvoker)(delegate
            {
            dataGridView1.Rows.Clear();
            
            for (int i = 0; i < 240; i++)
            {
                
                    dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = hostproft[0, i]; //IP                  
                dataGridView1[1, i].Value = hostproft[1, i];
                dataGridView1[2, i].Value = hostproft[2, i];
                dataGridView1[3, i].Value = hostproft[3, i];
                if (hostproft[2, i] == "Success") dataGridView1[2, i].Style.BackColor = Color.Green;
                else
                    dataGridView1[2, i].Style.BackColor = Color.Red;
                
            }
           
           
            }));
           // MessageBox.Show("Сканирование сети завершено! Найдено " + dataGridView1.RowCount+" активных хостов");
            
        }

        private void реинициализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

         


        }

        private void фильтранутьХостыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void мониторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void конфигурацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void фильтранутьХостыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                if (dataGridView1[1, i].Value == "ERROR!!!")
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
        }
    }
}

       
    
