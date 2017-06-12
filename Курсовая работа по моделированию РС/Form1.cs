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
    public partial class Form1 : Form
    {
        //------------------------------------------------------------------------// 
        //                          Переменные, типы, классы                        //
        //------------------------------------------------------------------------// 
        public enum dist { NORM, EXP, REL, LNORM} //возможные распределения


        dist distribution;        //Перечисление. Идентифицирует текущее распределение
        Form2 f = new Form2();    //Переменная для обращения ко второй форме
        double exp_val = 0;       //значение мат. ожидания
        double disp_val = 1;      //значение дисперсии
        int N;                    //размер реализации
        int intervals;            //Количество интервалов для гистограммирования и рассчета СВ
        double up_val = 4;         //Вехний предел
        double down_val = -1.5;       //Нижний предел

        public delegate double Func(double x, double SKO = 1, double exp_val = 0); /*описание делегата для передачи
                                                                                    * в генератор чисел 
                                                                                    * функции распределения
                                                                                    */



        //------------------------------------------------------------------------// 
        //                   Описание плотностей вероятности                        //
        //------------------------------------------------------------------------//

        double W_NORM(double x, double SKO=1, double exp_val=0) //Плотность вероятности нормального распределения
        {
            return (1/(Math.Sqrt(2*Math.PI)*SKO))*Math.Exp(-Math.Pow(x-exp_val,2)/(2*Math.Pow(SKO,2)));         
        }

        double W_LNORM(double x, double SKO=1, double exp_val=0) //плотность вероятности логарифмически-нормального распределения
        {
            if (x <= 0)
                return 0;
            else
                return (1/(Math.Sqrt(2*Math.PI)*SKO*x))*Math.Exp(-Math.Pow(Math.Log(x)-exp_val,2)/(2*Math.Pow(SKO,2)));    
        }

        double W_REL(double x, double SKO=1, double exp_val=0) //плотность вероятности релеевского распределения
        {
            if (x < 0)
                return 0;
            else
                return (x/Math.Pow(SKO,2))*Math.Exp(-(Math.Pow(x,2))/(2*Math.Pow(SKO,2)));
        }

        double W_EXP(double x, double SKO = 1, double exp_val = 0)
        {
            if (x < 0)
                return 0;
            else
                return (1 / SKO * Math.Exp(-x / SKO));
        }

        //------------------------------------------------------------------------// 
        //                   Универсальный алгоритм генерации реализации СВ         //
        //------------------------------------------------------------------------//

        double[,] generator(Func W, int number, double up_val, double down_val, int intervals, double SKO=1, double m=0)
        {
            double point=down_val, step = (up_val - down_val) / intervals;    //вычисление шага по х и установка "курсора" на начало интервала
            double[,] dinarray = new double[intervals,2];                        //выходной массив. Индекс 0 - информационный, 1 - положения
            double temp=0;                                                    //для промежуточных вычислений...
            double[] F = new double[intervals];                               //будущая функция распределения      

            for (int i = 0; i < intervals; i++) 
            {
                dinarray[i, 1] = point;     //заполнение массива положения
                point += step;

                dinarray[i, 0] = 0;         //инициализация выходного массива данных
                F[i] = W(point,SKO,m);            //чтение плотности вероятности в массив F
                temp += F[i];               //вычисление суммы плотности распределения для дальнейшей нормировки
            }

            for (int i = 1; i < intervals; i++) //преобразование плотности распределения в функцию распределения
            {
                F[i] += F[i - 1];
            }

            for (int i = 0; i < intervals; i++) //нормировка функции распределения
            {
                F[i] /= temp;
                //dinarray[i, 0] = F[i];
            }

            Random random = new Random();       //инициализация генератора псевдослучайных чисел

            for (int k = 0; k < number; k++)
            {
                temp = random.NextDouble();
                if (temp<F[0]) 
                {
                   // dinarray[0,0]++;
                }
                else 
                    if (temp>=F[intervals-1]) dinarray[intervals-1, 0]++; 
                    else
                for (int i = 0; i < intervals-1; i++)
                    if (temp >= F[i] && temp < F[i + 1])
                    {
                        dinarray[i, 0]++;
                        break;
                    }


            }


                /*for (int i = 0; i < number; i++)
                {
                    dinarray[i,0] = W(i*0.3);
                dinarray[i,1]=i*0.3;
                }*/
            // выравнивание математического ожидания и дисперсии согласно заданным
            double m_temp = 0, Disp_temp=0;

            for (int i = 0; i < intervals; i++)
                m_temp += dinarray[i, 1] * dinarray[i, 0];

            m_temp /= number;

            for (int i = 0; i < intervals; i++)
                Disp_temp += Math.Pow((dinarray[i, 0] * dinarray[i, 1] - m_temp * dinarray[i, 0]), 2) ;

            Disp_temp/=number;

                for (int i = 0; i < intervals; i++)
                    dinarray[i, 1] = (dinarray[i, 1] - m_temp )/ Disp_temp*SKO + m;


                return dinarray;
        }




        public Form1()
        {
            InitializeComponent();
        }


        //------------------------------------------------------------------------// 
        //                   Описание поведения элементов формы Form1               //
        //------------------------------------------------------------------------// 


        //Присвоение перечислению distribution значения, соответствующего разным распределениям
        //в зависимости от положения радиокнопок
     
        private void radioButtonNorm_CheckedChanged(object sender, EventArgs e)
        {
            distribution = dist.NORM; //нормальное
           
        }

        private void radioButtonExp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonExp.Checked)
            {
                exp_valua.Visible = false;
                exp_valua.Enabled = false;
                label2.Visible = false;
            }
            else
            {
                exp_valua.Visible = true;
                exp_valua.Enabled = true;
                label2.Visible = true;
            }
            distribution = dist.EXP; //экспоненциальное
            
        }

        private void radioButtonRel_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRel.Checked)
            {
                exp_valua.Visible = false;
                exp_valua.Enabled = false;
                label2.Visible = false;
            }
            else 
            {
                exp_valua.Visible = true;
                exp_valua.Enabled = true;
                label2.Visible = true;
            }
            distribution = dist.REL; //релеевское
            
        }

        private void radioButtonLNorm_CheckedChanged(object sender, EventArgs e)
        {
            distribution = dist.LNORM; //логарифмически нормальное
        }

        
        //------------------------------------------------------------------------// 
        //------------------------------------------------------------------------// 
        

        private void button1_Click(object sender, EventArgs e) //вывод графика на экран
        {
            N = Convert.ToInt32(number_of_dist.Value);         //Ввод в программу размера реализации
            intervals = Convert.ToInt32(10 * Math.Log10(N));   //Вычисление количества интервалов
            up_val = float.Parse(upNum.Text);
            down_val = float.Parse(downNum.Text);
            disp_val = Math.Sqrt(float.Parse(disp.Text));
            exp_val = float.Parse(exp_valua.Text);

            f.Hide();                                          //скрыть предыдущий экземпляр окна 
            f.data_var.size = intervals;                       //передача во вспомогательное окно числа отсчетов
            

            disp_val = Math.Sqrt(disp_val); //перевод в СКО
            switch (distribution) //выбор закона распределения и передача данных во второе окно
            { 
                case dist.EXP: 
                    f.data_var.array = generator(W_EXP, N, up_val, down_val, intervals, disp_val, disp_val);
                    break;
                case dist.NORM: 
                    f.data_var.array = generator(W_NORM, N, up_val, down_val, intervals, disp_val, exp_val);
                    break;
                case dist.LNORM: 
                    f.data_var.array = generator(W_LNORM, N, up_val, down_val, intervals, disp_val, exp_val);
                    break;
                case dist.REL:
                    f.data_var.array = generator(W_REL, N, up_val, down_val, intervals, disp_val, disp_val*1.25);
                    break;
       
            }
            f.Show();              //показать окно
            this.Activate();       //вывод родительской формы на передний план
        }

        private void number_of_dist_ValueChanged(object sender, EventArgs e)
        {

        }

        private void upNum_Leave(object sender, EventArgs e)
        {
            try
            {
                up_val = float.Parse(upNum.Text);
            }
            catch (FormatException)
            {
                upNum.Text = "1";
            }

            if (down_val >= up_val)
            {
                down_val = up_val - 1;
                downNum.Text = down_val.ToString();
            }
        }

        private void downNum_Leave(object sender, EventArgs e)
        {
            try
            {
                down_val = float.Parse(downNum.Text);
            }
            catch (FormatException)
            {
                downNum.Text = "0";
            }

            if (down_val >= up_val)
            {
                down_val = up_val - 1;
                downNum.Text = down_val.ToString();
            }
        }

        private void disp_Leave(object sender, EventArgs e)
        {
            try
            {
                disp_val = float.Parse(disp.Text);
            }
            catch (FormatException)
            {
                disp.Text = "1";
            }

            if (disp_val <= 0)
            {
                disp_val = 1;
                disp.Text = "1";
            }
        }

        private void exp_valua_Leave(object sender, EventArgs e)
        {
            try
            {
                exp_val = float.Parse(exp_valua.Text);
            }
            catch (FormatException)
            {
                exp_valua.Text = "0";
            }
        }

        //------------------------------------------------------------------------// 
        //------------------------------------------------------------------------// 
    }
}
