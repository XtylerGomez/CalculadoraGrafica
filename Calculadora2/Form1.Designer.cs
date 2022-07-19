namespace Calculadora2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonIgual = new System.Windows.Forms.Button();
            this.ButtonAtras = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonPM = new System.Windows.Forms.Button();
            this.ButtonRaiz = new System.Windows.Forms.Button();
            this.Button07 = new System.Windows.Forms.Button();
            this.Button08 = new System.Windows.Forms.Button();
            this.Button09 = new System.Windows.Forms.Button();
            this.ButtonDivision = new System.Windows.Forms.Button();
            this.ButtonMod = new System.Windows.Forms.Button();
            this.Button04 = new System.Windows.Forms.Button();
            this.Button05 = new System.Windows.Forms.Button();
            this.Button06 = new System.Windows.Forms.Button();
            this.ButtonMulti = new System.Windows.Forms.Button();
            this.Button1x = new System.Windows.Forms.Button();
            this.Button01 = new System.Windows.Forms.Button();
            this.Button02 = new System.Windows.Forms.Button();
            this.Button03 = new System.Windows.Forms.Button();
            this.ButtonMenos = new System.Windows.Forms.Button();
            this.ButtonPunto = new System.Windows.Forms.Button();
            this.Button00 = new System.Windows.Forms.Button();
            this.ButtonMas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxResultado = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonIgual
            // 
            this.ButtonIgual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonIgual.AutoSize = true;
            this.ButtonIgual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonIgual.Location = new System.Drawing.Point(203, 153);
            this.ButtonIgual.Name = "ButtonIgual";
            this.tableLayoutPanel1.SetRowSpan(this.ButtonIgual, 2);
            this.ButtonIgual.Size = new System.Drawing.Size(50, 94);
            this.ButtonIgual.TabIndex = 25;
            this.ButtonIgual.Text = "=";
            this.ButtonIgual.UseVisualStyleBackColor = true;
            this.ButtonIgual.Click += new System.EventHandler(this.button25_Click);
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAtras.AutoSize = true;
            this.ButtonAtras.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAtras.Location = new System.Drawing.Point(3, 3);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(44, 44);
            this.ButtonAtras.TabIndex = 1;
            this.ButtonAtras.Text = "<--";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonCE
            // 
            this.ButtonCE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCE.AutoSize = true;
            this.ButtonCE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCE.Location = new System.Drawing.Point(53, 3);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(44, 44);
            this.ButtonCE.TabIndex = 2;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = true;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // ButtonC
            // 
            this.ButtonC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonC.AutoSize = true;
            this.ButtonC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonC.Location = new System.Drawing.Point(103, 3);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(44, 44);
            this.ButtonC.TabIndex = 3;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonPM
            // 
            this.ButtonPM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPM.AutoSize = true;
            this.ButtonPM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPM.Location = new System.Drawing.Point(153, 3);
            this.ButtonPM.Name = "ButtonPM";
            this.ButtonPM.Size = new System.Drawing.Size(44, 44);
            this.ButtonPM.TabIndex = 4;
            this.ButtonPM.Text = "+ -";
            this.ButtonPM.UseVisualStyleBackColor = true;
            this.ButtonPM.Click += new System.EventHandler(this.ButtonPM_Click);
            // 
            // ButtonRaiz
            // 
            this.ButtonRaiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRaiz.AutoSize = true;
            this.ButtonRaiz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonRaiz.Location = new System.Drawing.Point(203, 3);
            this.ButtonRaiz.Name = "ButtonRaiz";
            this.ButtonRaiz.Size = new System.Drawing.Size(50, 44);
            this.ButtonRaiz.TabIndex = 5;
            this.ButtonRaiz.Text = "√";
            this.ButtonRaiz.UseVisualStyleBackColor = true;
            this.ButtonRaiz.Click += new System.EventHandler(this.ButtonRaiz_Click);
            // 
            // Button07
            // 
            this.Button07.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button07.AutoSize = true;
            this.Button07.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button07.Location = new System.Drawing.Point(3, 53);
            this.Button07.Name = "Button07";
            this.Button07.Size = new System.Drawing.Size(44, 44);
            this.Button07.TabIndex = 6;
            this.Button07.Text = "7";
            this.Button07.UseVisualStyleBackColor = true;
            this.Button07.Click += new System.EventHandler(this.Button07_Click);
            // 
            // Button08
            // 
            this.Button08.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button08.AutoSize = true;
            this.Button08.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button08.Location = new System.Drawing.Point(53, 53);
            this.Button08.Name = "Button08";
            this.Button08.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button08.Size = new System.Drawing.Size(44, 44);
            this.Button08.TabIndex = 7;
            this.Button08.Text = "8";
            this.Button08.UseVisualStyleBackColor = true;
            this.Button08.Click += new System.EventHandler(this.Button08_Click);
            // 
            // Button09
            // 
            this.Button09.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button09.AutoSize = true;
            this.Button09.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button09.Location = new System.Drawing.Point(103, 53);
            this.Button09.Name = "Button09";
            this.Button09.Size = new System.Drawing.Size(44, 44);
            this.Button09.TabIndex = 8;
            this.Button09.Text = "9";
            this.Button09.UseVisualStyleBackColor = true;
            this.Button09.Click += new System.EventHandler(this.Button09_Click);
            // 
            // ButtonDivision
            // 
            this.ButtonDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDivision.AutoSize = true;
            this.ButtonDivision.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonDivision.Location = new System.Drawing.Point(153, 53);
            this.ButtonDivision.Name = "ButtonDivision";
            this.ButtonDivision.Size = new System.Drawing.Size(44, 44);
            this.ButtonDivision.TabIndex = 9;
            this.ButtonDivision.Text = "/";
            this.ButtonDivision.UseVisualStyleBackColor = true;
            this.ButtonDivision.Click += new System.EventHandler(this.button9_Click);
            // 
            // ButtonMod
            // 
            this.ButtonMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMod.AutoSize = true;
            this.ButtonMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMod.Location = new System.Drawing.Point(203, 53);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.Size = new System.Drawing.Size(50, 44);
            this.ButtonMod.TabIndex = 10;
            this.ButtonMod.Text = "%";
            this.ButtonMod.UseVisualStyleBackColor = true;
            this.ButtonMod.Click += new System.EventHandler(this.ButtonMod_Click);
            // 
            // Button04
            // 
            this.Button04.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button04.AutoSize = true;
            this.Button04.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button04.Location = new System.Drawing.Point(3, 103);
            this.Button04.Name = "Button04";
            this.Button04.Size = new System.Drawing.Size(44, 44);
            this.Button04.TabIndex = 11;
            this.Button04.Text = "4";
            this.Button04.UseVisualStyleBackColor = true;
            this.Button04.Click += new System.EventHandler(this.Button04_Click);
            // 
            // Button05
            // 
            this.Button05.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button05.AutoSize = true;
            this.Button05.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button05.Location = new System.Drawing.Point(53, 103);
            this.Button05.Name = "Button05";
            this.Button05.Size = new System.Drawing.Size(44, 44);
            this.Button05.TabIndex = 12;
            this.Button05.Text = "5";
            this.Button05.UseVisualStyleBackColor = true;
            this.Button05.Click += new System.EventHandler(this.Button05_Click);
            // 
            // Button06
            // 
            this.Button06.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button06.AutoSize = true;
            this.Button06.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button06.Location = new System.Drawing.Point(103, 103);
            this.Button06.Name = "Button06";
            this.Button06.Size = new System.Drawing.Size(44, 44);
            this.Button06.TabIndex = 13;
            this.Button06.Text = "6";
            this.Button06.UseVisualStyleBackColor = true;
            this.Button06.Click += new System.EventHandler(this.button13_Click);
            // 
            // ButtonMulti
            // 
            this.ButtonMulti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMulti.AutoSize = true;
            this.ButtonMulti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMulti.Location = new System.Drawing.Point(153, 103);
            this.ButtonMulti.Name = "ButtonMulti";
            this.ButtonMulti.Size = new System.Drawing.Size(44, 44);
            this.ButtonMulti.TabIndex = 14;
            this.ButtonMulti.Text = "x";
            this.ButtonMulti.UseVisualStyleBackColor = true;
            this.ButtonMulti.Click += new System.EventHandler(this.ButtonMulti_Click);
            // 
            // Button1x
            // 
            this.Button1x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1x.AutoSize = true;
            this.Button1x.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button1x.Location = new System.Drawing.Point(203, 103);
            this.Button1x.Name = "Button1x";
            this.Button1x.Size = new System.Drawing.Size(50, 44);
            this.Button1x.TabIndex = 15;
            this.Button1x.Text = "1/x";
            this.Button1x.UseVisualStyleBackColor = true;
            this.Button1x.Click += new System.EventHandler(this.Button1x_Click);
            // 
            // Button01
            // 
            this.Button01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button01.AutoSize = true;
            this.Button01.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button01.Location = new System.Drawing.Point(3, 153);
            this.Button01.Name = "Button01";
            this.Button01.Size = new System.Drawing.Size(44, 44);
            this.Button01.TabIndex = 16;
            this.Button01.Text = "1";
            this.Button01.UseVisualStyleBackColor = true;
            this.Button01.Click += new System.EventHandler(this.Button01_Click);
            // 
            // Button02
            // 
            this.Button02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button02.AutoSize = true;
            this.Button02.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button02.Location = new System.Drawing.Point(53, 153);
            this.Button02.Name = "Button02";
            this.Button02.Size = new System.Drawing.Size(44, 44);
            this.Button02.TabIndex = 17;
            this.Button02.Text = "2";
            this.Button02.UseVisualStyleBackColor = true;
            this.Button02.Click += new System.EventHandler(this.Button02_Click);
            // 
            // Button03
            // 
            this.Button03.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button03.AutoSize = true;
            this.Button03.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button03.Location = new System.Drawing.Point(103, 153);
            this.Button03.Name = "Button03";
            this.Button03.Size = new System.Drawing.Size(44, 44);
            this.Button03.TabIndex = 18;
            this.Button03.Text = "3";
            this.Button03.UseVisualStyleBackColor = true;
            this.Button03.Click += new System.EventHandler(this.Button03_Click);
            // 
            // ButtonMenos
            // 
            this.ButtonMenos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMenos.AutoSize = true;
            this.ButtonMenos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMenos.Location = new System.Drawing.Point(153, 153);
            this.ButtonMenos.Name = "ButtonMenos";
            this.ButtonMenos.Size = new System.Drawing.Size(44, 44);
            this.ButtonMenos.TabIndex = 19;
            this.ButtonMenos.Text = "-";
            this.ButtonMenos.UseVisualStyleBackColor = true;
            this.ButtonMenos.Click += new System.EventHandler(this.ButtonMenos_Click);
            // 
            // ButtonPunto
            // 
            this.ButtonPunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPunto.AutoSize = true;
            this.ButtonPunto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonPunto.Location = new System.Drawing.Point(103, 203);
            this.ButtonPunto.Name = "ButtonPunto";
            this.ButtonPunto.Size = new System.Drawing.Size(44, 44);
            this.ButtonPunto.TabIndex = 26;
            this.ButtonPunto.Text = ".";
            this.ButtonPunto.UseVisualStyleBackColor = true;
            this.ButtonPunto.Click += new System.EventHandler(this.button21_Click);
            // 
            // Button00
            // 
            this.Button00.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button00.AutoSize = true;
            this.Button00.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.Button00, 2);
            this.Button00.Location = new System.Drawing.Point(3, 203);
            this.Button00.Name = "Button00";
            this.Button00.Size = new System.Drawing.Size(94, 44);
            this.Button00.TabIndex = 23;
            this.Button00.Text = "0";
            this.Button00.UseVisualStyleBackColor = true;
            this.Button00.Click += new System.EventHandler(this.Button00_Click);
            // 
            // ButtonMas
            // 
            this.ButtonMas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMas.AutoSize = true;
            this.ButtonMas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMas.Location = new System.Drawing.Point(153, 203);
            this.ButtonMas.Name = "ButtonMas";
            this.ButtonMas.Size = new System.Drawing.Size(44, 44);
            this.ButtonMas.TabIndex = 24;
            this.ButtonMas.Text = "+";
            this.ButtonMas.UseVisualStyleBackColor = true;
            this.ButtonMas.Click += new System.EventHandler(this.ButtonMas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonMas, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button00, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMenos, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button03, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPunto, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Button02, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonAtras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button01, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button1x, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMulti, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button06, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button05, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button04, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMod, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDivision, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button09, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button08, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button07, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPM, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonCE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonRaiz, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonIgual, 4, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TextBoxResultado
            // 
            this.TextBoxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBoxResultado.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultado.Location = new System.Drawing.Point(7, 12);
            this.TextBoxResultado.Name = "TextBoxResultado";
            this.TextBoxResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxResultado.Size = new System.Drawing.Size(250, 52);
            this.TextBoxResultado.TabIndex = 26;
            this.TextBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(262, 328);
            this.Controls.Add(this.TextBoxResultado);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "[Calculadora]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonIgual;
        private System.Windows.Forms.Button ButtonAtras;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonPM;
        private System.Windows.Forms.Button ButtonRaiz;
        private System.Windows.Forms.Button Button07;
        private System.Windows.Forms.Button Button08;
        private System.Windows.Forms.Button Button09;
        private System.Windows.Forms.Button ButtonDivision;
        private System.Windows.Forms.Button ButtonMod;
        private System.Windows.Forms.Button Button04;
        private System.Windows.Forms.Button Button05;
        private System.Windows.Forms.Button Button06;
        private System.Windows.Forms.Button ButtonMulti;
        private System.Windows.Forms.Button Button1x;
        private System.Windows.Forms.Button Button01;
        private System.Windows.Forms.Button Button02;
        private System.Windows.Forms.Button Button03;
        private System.Windows.Forms.Button ButtonMenos;
        private System.Windows.Forms.Button ButtonPunto;
        private System.Windows.Forms.Button Button00;
        private System.Windows.Forms.Button ButtonMas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextBoxResultado;
    }
}

