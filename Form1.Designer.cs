
namespace DPRN3_U2_EA_JHRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmpMujer = new System.Windows.Forms.RadioButton();
            this.cmpHombre = new System.Windows.Forms.RadioButton();
            this.cmpEstado = new System.Windows.Forms.ComboBox();
            this.cmpCurp = new System.Windows.Forms.TextBox();
            this.cmpNombre = new System.Windows.Forms.TextBox();
            this.cmpApellidoPaterno = new System.Windows.Forms.TextBox();
            this.cmpApellidoMaterno = new System.Windows.Forms.TextBox();
            this.cmpPersona = new System.Windows.Forms.ComboBox();
            this.cmpCp = new System.Windows.Forms.TextBox();
            this.cmpNumInt = new System.Windows.Forms.TextBox();
            this.cmpNumExt = new System.Windows.Forms.TextBox();
            this.cmpCalle = new System.Windows.Forms.TextBox();
            this.cmpCiudad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmpSexo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmpSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OldLace;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(607, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar a BD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label33.Location = new System.Drawing.Point(46, 109);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 20);
            this.label33.TabIndex = 1;
            this.label33.Text = "CURP";
            this.label33.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(394, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRO DE CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Paterno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calle";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Número exterior";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Número interior";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "C.P.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ciudad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Tipo de persona";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cmpMujer
            // 
            this.cmpMujer.AutoSize = true;
            this.cmpMujer.Location = new System.Drawing.Point(162, 26);
            this.cmpMujer.Name = "cmpMujer";
            this.cmpMujer.Size = new System.Drawing.Size(78, 24);
            this.cmpMujer.TabIndex = 14;
            this.cmpMujer.TabStop = true;
            this.cmpMujer.Text = "Mujer";
            this.cmpMujer.UseVisualStyleBackColor = true;
            // 
            // cmpHombre
            // 
            this.cmpHombre.AutoSize = true;
            this.cmpHombre.Location = new System.Drawing.Point(308, 26);
            this.cmpHombre.Name = "cmpHombre";
            this.cmpHombre.Size = new System.Drawing.Size(98, 24);
            this.cmpHombre.TabIndex = 15;
            this.cmpHombre.TabStop = true;
            this.cmpHombre.Text = "Hombre";
            this.cmpHombre.UseVisualStyleBackColor = true;
            // 
            // cmpEstado
            // 
            this.cmpEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpEstado.FormattingEnabled = true;
            this.cmpEstado.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Coahuila",
            "Colima",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Durango",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "México",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.cmpEstado.Location = new System.Drawing.Point(171, 252);
            this.cmpEstado.Name = "cmpEstado";
            this.cmpEstado.Size = new System.Drawing.Size(151, 28);
            this.cmpEstado.TabIndex = 16;
            // 
            // cmpCurp
            // 
            this.cmpCurp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpCurp.Location = new System.Drawing.Point(208, 109);
            this.cmpCurp.Name = "cmpCurp";
            this.cmpCurp.Size = new System.Drawing.Size(253, 27);
            this.cmpCurp.TabIndex = 17;
            // 
            // cmpNombre
            // 
            this.cmpNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpNombre.Location = new System.Drawing.Point(208, 150);
            this.cmpNombre.Name = "cmpNombre";
            this.cmpNombre.Size = new System.Drawing.Size(253, 27);
            this.cmpNombre.TabIndex = 18;
            this.cmpNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmpApellidoPaterno
            // 
            this.cmpApellidoPaterno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpApellidoPaterno.Location = new System.Drawing.Point(208, 193);
            this.cmpApellidoPaterno.Name = "cmpApellidoPaterno";
            this.cmpApellidoPaterno.Size = new System.Drawing.Size(253, 27);
            this.cmpApellidoPaterno.TabIndex = 19;
            this.cmpApellidoPaterno.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cmpApellidoMaterno
            // 
            this.cmpApellidoMaterno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpApellidoMaterno.Location = new System.Drawing.Point(208, 242);
            this.cmpApellidoMaterno.Name = "cmpApellidoMaterno";
            this.cmpApellidoMaterno.Size = new System.Drawing.Size(253, 27);
            this.cmpApellidoMaterno.TabIndex = 20;
            this.cmpApellidoMaterno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cmpPersona
            // 
            this.cmpPersona.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpPersona.FormattingEnabled = true;
            this.cmpPersona.Items.AddRange(new object[] {
            "Física",
            "Moral"});
            this.cmpPersona.Location = new System.Drawing.Point(208, 383);
            this.cmpPersona.Name = "cmpPersona";
            this.cmpPersona.Size = new System.Drawing.Size(151, 28);
            this.cmpPersona.TabIndex = 21;
            // 
            // cmpCp
            // 
            this.cmpCp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpCp.Location = new System.Drawing.Point(171, 154);
            this.cmpCp.Name = "cmpCp";
            this.cmpCp.Size = new System.Drawing.Size(94, 28);
            this.cmpCp.TabIndex = 25;
            // 
            // cmpNumInt
            // 
            this.cmpNumInt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpNumInt.Location = new System.Drawing.Point(171, 114);
            this.cmpNumInt.Name = "cmpNumInt";
            this.cmpNumInt.Size = new System.Drawing.Size(94, 28);
            this.cmpNumInt.TabIndex = 24;
            // 
            // cmpNumExt
            // 
            this.cmpNumExt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpNumExt.Location = new System.Drawing.Point(172, 69);
            this.cmpNumExt.Name = "cmpNumExt";
            this.cmpNumExt.Size = new System.Drawing.Size(94, 28);
            this.cmpNumExt.TabIndex = 23;
            // 
            // cmpCalle
            // 
            this.cmpCalle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpCalle.Location = new System.Drawing.Point(172, 26);
            this.cmpCalle.Name = "cmpCalle";
            this.cmpCalle.Size = new System.Drawing.Size(253, 28);
            this.cmpCalle.TabIndex = 22;
            // 
            // cmpCiudad
            // 
            this.cmpCiudad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmpCiudad.Location = new System.Drawing.Point(171, 202);
            this.cmpCiudad.Name = "cmpCiudad";
            this.cmpCiudad.Size = new System.Drawing.Size(253, 28);
            this.cmpCiudad.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(833, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 42);
            this.button2.TabIndex = 27;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmpSexo
            // 
            this.cmpSexo.Controls.Add(this.cmpMujer);
            this.cmpSexo.Controls.Add(this.cmpHombre);
            this.cmpSexo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmpSexo.Location = new System.Drawing.Point(55, 293);
            this.cmpSexo.Name = "cmpSexo";
            this.cmpSexo.Size = new System.Drawing.Size(415, 70);
            this.cmpSexo.TabIndex = 28;
            this.cmpSexo.TabStop = false;
            this.cmpSexo.Text = "Sexo";
            this.cmpSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmpCalle);
            this.groupBox1.Controls.Add(this.cmpNumExt);
            this.groupBox1.Controls.Add(this.cmpNumInt);
            this.groupBox1.Controls.Add(this.cmpCiudad);
            this.groupBox1.Controls.Add(this.cmpCp);
            this.groupBox1.Controls.Add(this.cmpEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(545, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 306);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmpSexo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmpPersona);
            this.Controls.Add(this.cmpApellidoMaterno);
            this.Controls.Add(this.cmpApellidoPaterno);
            this.Controls.Add(this.cmpNombre);
            this.Controls.Add(this.cmpCurp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmpSexo.ResumeLayout(false);
            this.cmpSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton cmpMujer;
        private System.Windows.Forms.RadioButton cmpHombre;
        private System.Windows.Forms.ComboBox cmpEstado;
        private System.Windows.Forms.TextBox cmpCurp;
        private System.Windows.Forms.TextBox cmpNombre;
        private System.Windows.Forms.TextBox cmpApellidoPaterno;
        private System.Windows.Forms.TextBox cmpApellidoMaterno;
        private System.Windows.Forms.ComboBox cmpPersona;
        private System.Windows.Forms.TextBox cmpCp;
        private System.Windows.Forms.TextBox cmpNumInt;
        private System.Windows.Forms.TextBox cmpNumExt;
        private System.Windows.Forms.TextBox cmpCalle;
        private System.Windows.Forms.TextBox cmpCiudad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox cmpSexo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

