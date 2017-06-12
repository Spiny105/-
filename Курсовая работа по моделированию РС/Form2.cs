using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_по_моделированию_РС
{
    public partial class Form2 : Form
    {

        void grid()
        {
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < data_var.size; i++)
                chart1.Series[0].Points.AddXY(data_var.array[i,1], data_var.array[i,0]);
        }

        public struct data
        {

            public double[,] array;
            public int size;

            
        }
        
      
        public data data_var;

        

        public Form2()
        {
            InitializeComponent();
        }

        //-----------------------------------------//
        //-----------------------------------------//
        private void chart1_Click(object sender, EventArgs e) //построение графика
        {
           
        }
        //-----------------------------------------//


        //-----------------------------------------//
        //-----------------------------------------//
        private void Form2_FormClosing(object sender, FormClosingEventArgs e) //устранение вылета при закрытии формы
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }

            this.Hide();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            grid();
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            grid();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grid();
        }
        //-----------------------------------------//
        
    }
}
