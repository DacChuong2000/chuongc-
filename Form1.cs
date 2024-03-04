
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
namespace chuong_xoso

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable hashTableResult = new Hashtable();
        Random rd = new Random();
        int miligiay = 0;
        int giay;
        int dotre = 2;
        private object giai_ĐB;
        private string SaveFile;

        string Quay(int so)
        {
            if (so == 2)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }
            else if (so == 3)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }
            else if (so == 4)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }
            else if (so == 5)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }
            else if (so == 6)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }
            else if (so == 7)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }
            else if (so == 8)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }
            else if (so == 9)
            {
                return (rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString() + "" + rd.Next(10).ToString());
            }

            return null;
        }


        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            btnStart.Text = btnStart.Text == "Stop" ? "Start" : "Stop";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            miligiay = miligiay + timer1.Interval;
            giay = miligiay / 1000;
            if (giay <= 2)
            {
                g8.Text = Quay(2);

            }
            else if (giay <= dotre * 2)
            {
                g7.Text = Quay(2);
            }
            else if (giay <= dotre * 3)
            {
                g6.Text = Quay(3);
            }
            else if (giay <= dotre * 4)
            {
                g51.Text = Quay(3);
            }
            else if (giay <= dotre * 5)
            {
                g52.Text = Quay(3);
            }
            else if (giay <= dotre * 6)
            {
                g53.Text = Quay(4);
            }
            else if (giay <= dotre * 7)
            {
                g41.Text = Quay(4);
            }
            else if (giay <= dotre * 8)
            {
                g42.Text = Quay(4);
            }
            else if (giay <= dotre * 9)
            {
                g43.Text = Quay(5);
            }
            else if (giay <= dotre * 10)
            {
                g31.Text = Quay(5);
            }
            else if (giay <= dotre * 11)
            {
                g32.Text = Quay(5);
            }
            else if (giay <= dotre * 12)
            {
                g33.Text = Quay(5);
            }
            else if (giay <= dotre * 13)
            {
                g21.Text = Quay(5);
            }
            else if (giay <= dotre * 14)
            {
                g22.Text = Quay(5);
            }
            else if (giay <= dotre * 15)
            {
                g23.Text = Quay(5);
            }
            else if (giay <= dotre * 16)
            {
                g11.Text = Quay(5);
            }
            else if (giay <= dotre * 17)
            {
                g13.Text = Quay(5);
            }
            else if (giay <= dotre * 18)
            {
                gdb.Text = Quay(5);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            g8.Text = "xx";
            g7.Text = "xx";
            g6.Text = "xx";
            g51.Text = "xx";
            g52.Text = "xx";
            g53.Text = "xx";
            g41.Text = "xx";
            g42.Text = "xx";
            g43.Text = "xx";
            g31.Text = "xx";
            g32.Text = "xx";
            g33.Text = "xx";
            g21.Text = "xx";
            g22.Text = "xx";
            g23.Text = "xx";
            g11.Text = "xx";
            g13.Text = "xx";
            gdb.Text = "xx";
            timer1.Enabled = false;
            miligiay = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string name = "Chuong";
            string path = "C:\\Users\\PC\\source\\repos\\chuong_xoso\\chuong_xoso\\chuong_xoso\\chuong_xoso\\chuong_xoso\\xoso.txt";
            string noidung = g8.Text + "\t" + g7.Text;
            string KhuVuc = cbKhuVuc.Text;
            if (cbKhuVuc.SelectedIndex == 0)
            {
                KhuVuc = "Miền Trung";
            }
            else if (cbKhuVuc.SelectedIndex == 1)
            {
                KhuVuc = "Miền Nam";
            }
            else if (cbKhuVuc.SelectedIndex == 2)
            {
                KhuVuc = "Miền Bắc";
            }

            string giave = CbGiaVexs.Text;
            if (CbGiaVexs.SelectedIndex == 0)
            {
                giave = "10.000";
            }
            else if (CbGiaVexs.SelectedIndex == 1)
            {
                giave = "20.000";
            }
            else if (CbGiaVexs.SelectedIndex == 2)
            {
                giave = "30.000";
            }
            string kq = name + "\t" + "Giá vé :" + giave + "\t" + KhuVuc + "\t" + "Giải 8:" + g8.Text + "\t" + "Giải 7:" + g7.Text + "\t" + "Giải 6:" + g6.Text + "\t" + "Giải 5.1:" + g51.Text + "\t" + "Giải 5.2:" + g52.Text + "\t" + "Giải 5.3:" + g53.Text + "\t" + "Giải 4.1:" + g41.Text + "\t" + "Giải 4.2:" + g42.Text + "\t" + "Giải 4.3:" + g43.Text + "\t" + "Giải 3.1:" + g31.Text + "\t" + "Giải 3.2:" + g32.Text + "\t" + "Giải 3.3:" + g33.Text + "\t" + "Giải 2.1:" + g21.Text + "\t" + "Giải 2.2:" + g22.Text + "\t" + "Giải 2.3:" + g23.Text + "\t" + "Giải 1.1" + g11.Text + "\t" + "Giải 1.2:" + g13.Text + "\t" + "Giải Đặc biệt:" + gdb.Text + "\n";
            File.AppendAllText(path, kq);

        }

        private void g31_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndoso_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }


        private void dosomt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbGiaVexs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doxoso_Click(object sender, EventArgs e)
        {

        }
    }
}