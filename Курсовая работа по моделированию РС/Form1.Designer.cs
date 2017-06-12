namespace Курсовая_работа_по_моделированию_РС
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonLNorm = new System.Windows.Forms.RadioButton();
            this.radioButtonRel = new System.Windows.Forms.RadioButton();
            this.radioButtonExp = new System.Windows.Forms.RadioButton();
            this.radioButtonNorm = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.downNum = new System.Windows.Forms.TextBox();
            this.upNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disp = new System.Windows.Forms.TextBox();
            this.exp_valua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.number_of_dist = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_dist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLNorm);
            this.groupBox1.Controls.Add(this.radioButtonRel);
            this.groupBox1.Controls.Add(this.radioButtonExp);
            this.groupBox1.Controls.Add(this.radioButtonNorm);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButtonLNorm
            // 
            resources.ApplyResources(this.radioButtonLNorm, "radioButtonLNorm");
            this.radioButtonLNorm.Name = "radioButtonLNorm";
            this.radioButtonLNorm.TabStop = true;
            this.radioButtonLNorm.UseVisualStyleBackColor = true;
            this.radioButtonLNorm.CheckedChanged += new System.EventHandler(this.radioButtonLNorm_CheckedChanged);
            // 
            // radioButtonRel
            // 
            resources.ApplyResources(this.radioButtonRel, "radioButtonRel");
            this.radioButtonRel.Name = "radioButtonRel";
            this.radioButtonRel.TabStop = true;
            this.radioButtonRel.UseVisualStyleBackColor = true;
            this.radioButtonRel.CheckedChanged += new System.EventHandler(this.radioButtonRel_CheckedChanged);
            // 
            // radioButtonExp
            // 
            resources.ApplyResources(this.radioButtonExp, "radioButtonExp");
            this.radioButtonExp.Name = "radioButtonExp";
            this.radioButtonExp.TabStop = true;
            this.radioButtonExp.UseVisualStyleBackColor = true;
            this.radioButtonExp.CheckedChanged += new System.EventHandler(this.radioButtonExp_CheckedChanged);
            // 
            // radioButtonNorm
            // 
            resources.ApplyResources(this.radioButtonNorm, "radioButtonNorm");
            this.radioButtonNorm.Name = "radioButtonNorm";
            this.radioButtonNorm.TabStop = true;
            this.radioButtonNorm.UseVisualStyleBackColor = true;
            this.radioButtonNorm.CheckedChanged += new System.EventHandler(this.radioButtonNorm_CheckedChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.downNum);
            this.groupBox2.Controls.Add(this.upNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.disp);
            this.groupBox2.Controls.Add(this.exp_valua);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.number_of_dist);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // downNum
            // 
            resources.ApplyResources(this.downNum, "downNum");
            this.downNum.Name = "downNum";
            this.downNum.Leave += new System.EventHandler(this.downNum_Leave);
            // 
            // upNum
            // 
            resources.ApplyResources(this.upNum, "upNum");
            this.upNum.Name = "upNum";
            this.upNum.Leave += new System.EventHandler(this.upNum_Leave);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // disp
            // 
            resources.ApplyResources(this.disp, "disp");
            this.disp.Name = "disp";
            this.disp.Leave += new System.EventHandler(this.disp_Leave);
            // 
            // exp_valua
            // 
            resources.ApplyResources(this.exp_valua, "exp_valua");
            this.exp_valua.Name = "exp_valua";
            this.exp_valua.Leave += new System.EventHandler(this.exp_valua_Leave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // number_of_dist
            // 
            resources.ApplyResources(this.number_of_dist, "number_of_dist");
            this.number_of_dist.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_of_dist.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.number_of_dist.Name = "number_of_dist";
            this.number_of_dist.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_of_dist.ValueChanged += new System.EventHandler(this.number_of_dist_ValueChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_dist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonLNorm;
        private System.Windows.Forms.RadioButton radioButtonRel;
        private System.Windows.Forms.RadioButton radioButtonExp;
        private System.Windows.Forms.RadioButton radioButtonNorm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown number_of_dist;
        private System.Windows.Forms.TextBox disp;
        private System.Windows.Forms.TextBox exp_valua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox downNum;
        private System.Windows.Forms.TextBox upNum;



    }
}

