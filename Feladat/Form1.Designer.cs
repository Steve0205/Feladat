namespace Feladat
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
            this.textBox_rendszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_tipus = new System.Windows.Forms.ComboBox();
            this.numericUpDown_gyartmany = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_teljesitmeny = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_auto = new System.Windows.Forms.ListBox();
            this.button_rogzit = new System.Windows.Forms.Button();
            this.checkBox_kombi = new System.Windows.Forms.CheckBox();
            this.checkBox_cabrio = new System.Windows.Forms.CheckBox();
            this.checkBox_haromajto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gyartmany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teljesitmeny)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_rendszam
            // 
            this.textBox_rendszam.Location = new System.Drawing.Point(158, 41);
            this.textBox_rendszam.Name = "textBox_rendszam";
            this.textBox_rendszam.Size = new System.Drawing.Size(122, 20);
            this.textBox_rendszam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rendszám:";
            // 
            // combobox_tipus
            // 
            this.combobox_tipus.FormattingEnabled = true;
            this.combobox_tipus.Items.AddRange(new object[] {
            "Ford",
            "Opel",
            "Peugeot",
            "Kia"});
            this.combobox_tipus.Location = new System.Drawing.Point(160, 92);
            this.combobox_tipus.Name = "combobox_tipus";
            this.combobox_tipus.Size = new System.Drawing.Size(121, 21);
            this.combobox_tipus.TabIndex = 2;
            // 
            // numericUpDown_gyartmany
            // 
            this.numericUpDown_gyartmany.Location = new System.Drawing.Point(161, 152);
            this.numericUpDown_gyartmany.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown_gyartmany.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_gyartmany.Name = "numericUpDown_gyartmany";
            this.numericUpDown_gyartmany.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown_gyartmany.TabIndex = 3;
            this.numericUpDown_gyartmany.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Típusa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gyártmány:";
            // 
            // numericUpDown_teljesitmeny
            // 
            this.numericUpDown_teljesitmeny.Location = new System.Drawing.Point(160, 193);
            this.numericUpDown_teljesitmeny.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_teljesitmeny.Name = "numericUpDown_teljesitmeny";
            this.numericUpDown_teljesitmeny.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown_teljesitmeny.TabIndex = 6;
            this.numericUpDown_teljesitmeny.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teljesítmény:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "LE";
            // 
            // listBox_auto
            // 
            this.listBox_auto.FormattingEnabled = true;
            this.listBox_auto.Location = new System.Drawing.Point(343, 23);
            this.listBox_auto.Name = "listBox_auto";
            this.listBox_auto.Size = new System.Drawing.Size(309, 290);
            this.listBox_auto.TabIndex = 9;
            this.listBox_auto.SelectedIndexChanged += new System.EventHandler(this.listBox_auto_SelectedIndexChanged);
            // 
            // button_rogzit
            // 
            this.button_rogzit.Location = new System.Drawing.Point(121, 281);
            this.button_rogzit.Name = "button_rogzit";
            this.button_rogzit.Size = new System.Drawing.Size(75, 23);
            this.button_rogzit.TabIndex = 10;
            this.button_rogzit.Text = "Rögzítés";
            this.button_rogzit.UseVisualStyleBackColor = true;
            this.button_rogzit.Click += new System.EventHandler(this.button_rogzit_Click);
            // 
            // checkBox_kombi
            // 
            this.checkBox_kombi.AutoSize = true;
            this.checkBox_kombi.Location = new System.Drawing.Point(85, 238);
            this.checkBox_kombi.Name = "checkBox_kombi";
            this.checkBox_kombi.Size = new System.Drawing.Size(54, 17);
            this.checkBox_kombi.TabIndex = 11;
            this.checkBox_kombi.Text = "kombi";
            this.checkBox_kombi.UseVisualStyleBackColor = true;
            // 
            // checkBox_cabrio
            // 
            this.checkBox_cabrio.AutoSize = true;
            this.checkBox_cabrio.Location = new System.Drawing.Point(177, 238);
            this.checkBox_cabrio.Name = "checkBox_cabrio";
            this.checkBox_cabrio.Size = new System.Drawing.Size(55, 17);
            this.checkBox_cabrio.TabIndex = 12;
            this.checkBox_cabrio.Text = "cabrio";
            this.checkBox_cabrio.UseVisualStyleBackColor = true;
            // 
            // checkBox_haromajto
            // 
            this.checkBox_haromajto.AutoSize = true;
            this.checkBox_haromajto.Location = new System.Drawing.Point(252, 238);
            this.checkBox_haromajto.Name = "checkBox_haromajto";
            this.checkBox_haromajto.Size = new System.Drawing.Size(57, 17);
            this.checkBox_haromajto.TabIndex = 13;
            this.checkBox_haromajto.Text = "3 ajtós";
            this.checkBox_haromajto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 340);
            this.Controls.Add(this.checkBox_haromajto);
            this.Controls.Add(this.checkBox_cabrio);
            this.Controls.Add(this.checkBox_kombi);
            this.Controls.Add(this.button_rogzit);
            this.Controls.Add(this.listBox_auto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_teljesitmeny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_gyartmany);
            this.Controls.Add(this.combobox_tipus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_rendszam);
            this.Name = "Form1";
            this.Text = "Gépjármű adatok";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gyartmany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_teljesitmeny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_rendszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_tipus;
        private System.Windows.Forms.NumericUpDown numericUpDown_gyartmany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_teljesitmeny;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_auto;
        private System.Windows.Forms.Button button_rogzit;
        private System.Windows.Forms.CheckBox checkBox_kombi;
        private System.Windows.Forms.CheckBox checkBox_cabrio;
        private System.Windows.Forms.CheckBox checkBox_haromajto;
    }
}

