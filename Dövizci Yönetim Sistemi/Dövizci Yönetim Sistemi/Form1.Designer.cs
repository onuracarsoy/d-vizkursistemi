namespace Dövizci_Yönetim_Sistemi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblSterlin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsbr = new System.Windows.Forms.Label();
            this.lbljaponyeni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblbulgarlevasi = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblcinyeni = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbliranriyali = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblSterlinA = new System.Windows.Forms.Label();
            this.lblsbrA = new System.Windows.Forms.Label();
            this.lbljaponyeniA = new System.Windows.Forms.Label();
            this.lblbulgarlevasiA = new System.Windows.Forms.Label();
            this.lblcinyeniA = new System.Windows.Forms.Label();
            this.lbliranriyaliA = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.ForeColor = System.Drawing.Color.White;
            this.lblDolar.Location = new System.Drawing.Point(1152, 108);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(105, 40);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "label1";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Arial", 26.25F);
            this.lblEuro.ForeColor = System.Drawing.Color.White;
            this.lblEuro.Location = new System.Drawing.Point(1152, 170);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(105, 40);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "label2";
            this.lblEuro.Click += new System.EventHandler(this.LblEuro_Click);
            // 
            // lblSterlin
            // 
            this.lblSterlin.AutoSize = true;
            this.lblSterlin.Font = new System.Drawing.Font("Arial", 26.25F);
            this.lblSterlin.ForeColor = System.Drawing.Color.White;
            this.lblSterlin.Location = new System.Drawing.Point(1152, 236);
            this.lblSterlin.Name = "lblSterlin";
            this.lblSterlin.Size = new System.Drawing.Size(105, 40);
            this.lblSterlin.TabIndex = 3;
            this.lblSterlin.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(419, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "DOLAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(419, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "EURO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(419, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "STERLİN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(419, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "SUUDİ ARABİSTAN RİYALİ";
            // 
            // lblsbr
            // 
            this.lblsbr.AutoSize = true;
            this.lblsbr.Font = new System.Drawing.Font("Arial", 26.25F);
            this.lblsbr.ForeColor = System.Drawing.Color.White;
            this.lblsbr.Location = new System.Drawing.Point(1152, 303);
            this.lblsbr.Name = "lblsbr";
            this.lblsbr.Size = new System.Drawing.Size(105, 40);
            this.lblsbr.TabIndex = 8;
            this.lblsbr.Text = "label3";
            // 
            // lbljaponyeni
            // 
            this.lbljaponyeni.AutoSize = true;
            this.lbljaponyeni.Font = new System.Drawing.Font("Arial", 26.25F);
            this.lbljaponyeni.ForeColor = System.Drawing.Color.White;
            this.lbljaponyeni.Location = new System.Drawing.Point(1152, 367);
            this.lbljaponyeni.Name = "lbljaponyeni";
            this.lbljaponyeni.Size = new System.Drawing.Size(105, 40);
            this.lbljaponyeni.TabIndex = 9;
            this.lbljaponyeni.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(419, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "JAPON YENİ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 83);
            this.panel1.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(253, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 41);
            this.label21.TabIndex = 34;
            this.label21.Text = "Birim";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(1152, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 41);
            this.label14.TabIndex = 15;
            this.label14.Text = "Satış";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(931, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 41);
            this.label13.TabIndex = 14;
            this.label13.Text = "Alış";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(419, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 41);
            this.label12.TabIndex = 13;
            this.label12.Text = "Döviz Cinsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 41);
            this.label6.TabIndex = 12;
            this.label6.Text = "Döviz Kodu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(14, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "USD/TRY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(13, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 41);
            this.label8.TabIndex = 13;
            this.label8.Text = "EUR/TRY";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(14, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 41);
            this.label9.TabIndex = 14;
            this.label9.Text = "GBP/TRY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(17, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 41);
            this.label10.TabIndex = 15;
            this.label10.Text = "SAR/TRY";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(14, 365);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 41);
            this.label11.TabIndex = 16;
            this.label11.Text = "JPY/TRY";
            // 
            // lblbulgarlevasi
            // 
            this.lblbulgarlevasi.AutoSize = true;
            this.lblbulgarlevasi.Font = new System.Drawing.Font("Arial", 26.25F);
            this.lblbulgarlevasi.ForeColor = System.Drawing.Color.White;
            this.lblbulgarlevasi.Location = new System.Drawing.Point(1152, 430);
            this.lblbulgarlevasi.Name = "lblbulgarlevasi";
            this.lblbulgarlevasi.Size = new System.Drawing.Size(105, 40);
            this.lblbulgarlevasi.TabIndex = 17;
            this.lblbulgarlevasi.Text = "label3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Olive;
            this.label16.Location = new System.Drawing.Point(419, 427);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(292, 41);
            this.label16.TabIndex = 18;
            this.label16.Text = "BULGAR LEVASI";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Olive;
            this.label15.Location = new System.Drawing.Point(14, 428);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 41);
            this.label15.TabIndex = 19;
            this.label15.Text = "BGN/TRY";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Olive;
            this.label17.Location = new System.Drawing.Point(419, 493);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 41);
            this.label17.TabIndex = 20;
            this.label17.Text = "ÇİN YENİ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Olive;
            this.label18.Location = new System.Drawing.Point(14, 494);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 41);
            this.label18.TabIndex = 21;
            this.label18.Text = "CNY/TRY";
            // 
            // lblcinyeni
            // 
            this.lblcinyeni.AutoSize = true;
            this.lblcinyeni.Font = new System.Drawing.Font("Arial", 26.25F);
            this.lblcinyeni.ForeColor = System.Drawing.Color.White;
            this.lblcinyeni.Location = new System.Drawing.Point(1152, 496);
            this.lblcinyeni.Name = "lblcinyeni";
            this.lblcinyeni.Size = new System.Drawing.Size(105, 40);
            this.lblcinyeni.TabIndex = 22;
            this.lblcinyeni.Text = "label3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Olive;
            this.label19.Location = new System.Drawing.Point(14, 561);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 41);
            this.label19.TabIndex = 23;
            this.label19.Text = "IRR/TRY";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Olive;
            this.label20.Location = new System.Drawing.Point(419, 560);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(217, 41);
            this.label20.TabIndex = 24;
            this.label20.Text = "İRAN RİYALİ";
            // 
            // lbliranriyali
            // 
            this.lbliranriyali.AutoSize = true;
            this.lbliranriyali.Font = new System.Drawing.Font("Arial", 26.25F);
            this.lbliranriyali.ForeColor = System.Drawing.Color.White;
            this.lbliranriyali.Location = new System.Drawing.Point(1152, 562);
            this.lbliranriyali.Name = "lbliranriyali";
            this.lbliranriyali.Size = new System.Drawing.Size(105, 40);
            this.lbliranriyali.TabIndex = 25;
            this.lbliranriyali.Text = "label3";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.ForeColor = System.Drawing.Color.White;
            this.lblDolarA.Location = new System.Drawing.Point(931, 107);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(105, 40);
            this.lblDolarA.TabIndex = 26;
            this.lblDolarA.Text = "label1";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.ForeColor = System.Drawing.Color.White;
            this.lblEuroA.Location = new System.Drawing.Point(931, 169);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(105, 40);
            this.lblEuroA.TabIndex = 27;
            this.lblEuroA.Text = "label1";
            // 
            // lblSterlinA
            // 
            this.lblSterlinA.AutoSize = true;
            this.lblSterlinA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSterlinA.ForeColor = System.Drawing.Color.White;
            this.lblSterlinA.Location = new System.Drawing.Point(931, 235);
            this.lblSterlinA.Name = "lblSterlinA";
            this.lblSterlinA.Size = new System.Drawing.Size(105, 40);
            this.lblSterlinA.TabIndex = 28;
            this.lblSterlinA.Text = "label1";
            // 
            // lblsbrA
            // 
            this.lblsbrA.AutoSize = true;
            this.lblsbrA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsbrA.ForeColor = System.Drawing.Color.White;
            this.lblsbrA.Location = new System.Drawing.Point(931, 301);
            this.lblsbrA.Name = "lblsbrA";
            this.lblsbrA.Size = new System.Drawing.Size(105, 40);
            this.lblsbrA.TabIndex = 29;
            this.lblsbrA.Text = "label1";
            // 
            // lbljaponyeniA
            // 
            this.lbljaponyeniA.AutoSize = true;
            this.lbljaponyeniA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljaponyeniA.ForeColor = System.Drawing.Color.White;
            this.lbljaponyeniA.Location = new System.Drawing.Point(931, 365);
            this.lbljaponyeniA.Name = "lbljaponyeniA";
            this.lbljaponyeniA.Size = new System.Drawing.Size(105, 40);
            this.lbljaponyeniA.TabIndex = 30;
            this.lbljaponyeniA.Text = "label1";
            // 
            // lblbulgarlevasiA
            // 
            this.lblbulgarlevasiA.AutoSize = true;
            this.lblbulgarlevasiA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbulgarlevasiA.ForeColor = System.Drawing.Color.White;
            this.lblbulgarlevasiA.Location = new System.Drawing.Point(931, 429);
            this.lblbulgarlevasiA.Name = "lblbulgarlevasiA";
            this.lblbulgarlevasiA.Size = new System.Drawing.Size(105, 40);
            this.lblbulgarlevasiA.TabIndex = 31;
            this.lblbulgarlevasiA.Text = "label1";
            // 
            // lblcinyeniA
            // 
            this.lblcinyeniA.AutoSize = true;
            this.lblcinyeniA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcinyeniA.ForeColor = System.Drawing.Color.White;
            this.lblcinyeniA.Location = new System.Drawing.Point(931, 495);
            this.lblcinyeniA.Name = "lblcinyeniA";
            this.lblcinyeniA.Size = new System.Drawing.Size(105, 40);
            this.lblcinyeniA.TabIndex = 32;
            this.lblcinyeniA.Text = "label1";
            // 
            // lbliranriyaliA
            // 
            this.lbliranriyaliA.AutoSize = true;
            this.lbliranriyaliA.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliranriyaliA.ForeColor = System.Drawing.Color.White;
            this.lbliranriyaliA.Location = new System.Drawing.Point(931, 561);
            this.lbliranriyaliA.Name = "lbliranriyaliA";
            this.lbliranriyaliA.Size = new System.Drawing.Size(105, 40);
            this.lbliranriyaliA.TabIndex = 33;
            this.lbliranriyaliA.Text = "label1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Olive;
            this.label22.Location = new System.Drawing.Point(280, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 41);
            this.label22.TabIndex = 34;
            this.label22.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Olive;
            this.label23.Location = new System.Drawing.Point(280, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 41);
            this.label23.TabIndex = 35;
            this.label23.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Olive;
            this.label24.Location = new System.Drawing.Point(280, 234);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 41);
            this.label24.TabIndex = 36;
            this.label24.Text = "1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Olive;
            this.label25.Location = new System.Drawing.Point(280, 303);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 41);
            this.label25.TabIndex = 37;
            this.label25.Text = "1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Olive;
            this.label26.Location = new System.Drawing.Point(263, 364);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 41);
            this.label26.TabIndex = 38;
            this.label26.Text = "100";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Olive;
            this.label27.Location = new System.Drawing.Point(280, 427);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 41);
            this.label27.TabIndex = 39;
            this.label27.Text = "1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Olive;
            this.label28.Location = new System.Drawing.Point(280, 493);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 41);
            this.label28.TabIndex = 40;
            this.label28.Text = "1";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Olive;
            this.label29.Location = new System.Drawing.Point(263, 560);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 41);
            this.label29.TabIndex = 41;
            this.label29.Text = "100";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label30.Location = new System.Drawing.Point(202, 6);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(133, 41);
            this.label30.TabIndex = 42;
            this.label30.Text = "label30";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label30);
            this.panel2.Location = new System.Drawing.Point(0, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 77);
            this.panel2.TabIndex = 43;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.label31.Location = new System.Drawing.Point(1, 6);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(204, 41);
            this.label31.TabIndex = 43;
            this.label31.Text = "Gelişmeler:";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label31);
            this.panel3.Location = new System.Drawing.Point(0, 676);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 58);
            this.panel3.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1329, 732);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbliranriyaliA);
            this.Controls.Add(this.lblcinyeniA);
            this.Controls.Add(this.lblbulgarlevasiA);
            this.Controls.Add(this.lbljaponyeniA);
            this.Controls.Add(this.lblsbrA);
            this.Controls.Add(this.lblSterlinA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lbliranriyali);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblcinyeni);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblbulgarlevasi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbljaponyeni);
            this.Controls.Add(this.lblsbr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSterlin);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblSterlin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsbr;
        private System.Windows.Forms.Label lbljaponyeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblbulgarlevasi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblcinyeni;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbliranriyali;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblSterlinA;
        private System.Windows.Forms.Label lblsbrA;
        private System.Windows.Forms.Label lbljaponyeniA;
        private System.Windows.Forms.Label lblbulgarlevasiA;
        private System.Windows.Forms.Label lblcinyeniA;
        private System.Windows.Forms.Label lbliranriyaliA;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel3;
    }
}

