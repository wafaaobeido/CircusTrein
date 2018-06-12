namespace Circustrein
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
            this.txt_Naam = new System.Windows.Forms.TextBox();
            this.RB_vlees = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_planten = new System.Windows.Forms.RadioButton();
            this.GB_formaat = new System.Windows.Forms.GroupBox();
            this.RB_klein = new System.Windows.Forms.RadioButton();
            this.RB_Middelgroot = new System.Windows.Forms.RadioButton();
            this.RB_groot = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_toevoegen = new System.Windows.Forms.Button();
            this.btn_verdelen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.GB_formaat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Naam
            // 
            this.txt_Naam.Location = new System.Drawing.Point(72, 31);
            this.txt_Naam.Name = "txt_Naam";
            this.txt_Naam.Size = new System.Drawing.Size(139, 20);
            this.txt_Naam.TabIndex = 0;
            // 
            // RB_vlees
            // 
            this.RB_vlees.AutoSize = true;
            this.RB_vlees.Location = new System.Drawing.Point(17, 34);
            this.RB_vlees.Name = "RB_vlees";
            this.RB_vlees.Size = new System.Drawing.Size(51, 17);
            this.RB_vlees.TabIndex = 1;
            this.RB_vlees.TabStop = true;
            this.RB_vlees.Text = "Vlees";
            this.RB_vlees.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_planten);
            this.groupBox1.Controls.Add(this.RB_vlees);
            this.groupBox1.Location = new System.Drawing.Point(33, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soort eten";
            // 
            // RB_planten
            // 
            this.RB_planten.AutoSize = true;
            this.RB_planten.Location = new System.Drawing.Point(117, 34);
            this.RB_planten.Name = "RB_planten";
            this.RB_planten.Size = new System.Drawing.Size(61, 17);
            this.RB_planten.TabIndex = 2;
            this.RB_planten.TabStop = true;
            this.RB_planten.Text = "Planten";
            this.RB_planten.UseVisualStyleBackColor = true;
            // 
            // GB_formaat
            // 
            this.GB_formaat.Controls.Add(this.RB_klein);
            this.GB_formaat.Controls.Add(this.RB_Middelgroot);
            this.GB_formaat.Controls.Add(this.RB_groot);
            this.GB_formaat.Location = new System.Drawing.Point(254, 77);
            this.GB_formaat.Name = "GB_formaat";
            this.GB_formaat.Size = new System.Drawing.Size(156, 127);
            this.GB_formaat.TabIndex = 3;
            this.GB_formaat.TabStop = false;
            this.GB_formaat.Text = "Formaat";
            // 
            // RB_klein
            // 
            this.RB_klein.AutoSize = true;
            this.RB_klein.Location = new System.Drawing.Point(30, 89);
            this.RB_klein.Name = "RB_klein";
            this.RB_klein.Size = new System.Drawing.Size(48, 17);
            this.RB_klein.TabIndex = 5;
            this.RB_klein.TabStop = true;
            this.RB_klein.Text = "Klein";
            this.RB_klein.UseVisualStyleBackColor = true;
            // 
            // RB_Middelgroot
            // 
            this.RB_Middelgroot.AutoSize = true;
            this.RB_Middelgroot.Location = new System.Drawing.Point(30, 55);
            this.RB_Middelgroot.Name = "RB_Middelgroot";
            this.RB_Middelgroot.Size = new System.Drawing.Size(80, 17);
            this.RB_Middelgroot.TabIndex = 4;
            this.RB_Middelgroot.TabStop = true;
            this.RB_Middelgroot.Text = "Middelgroot";
            this.RB_Middelgroot.UseVisualStyleBackColor = true;
            // 
            // RB_groot
            // 
            this.RB_groot.AutoSize = true;
            this.RB_groot.Location = new System.Drawing.Point(30, 19);
            this.RB_groot.Name = "RB_groot";
            this.RB_groot.Size = new System.Drawing.Size(51, 17);
            this.RB_groot.TabIndex = 3;
            this.RB_groot.TabStop = true;
            this.RB_groot.Text = "Groot";
            this.RB_groot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naam";
            // 
            // btn_toevoegen
            // 
            this.btn_toevoegen.Location = new System.Drawing.Point(231, 29);
            this.btn_toevoegen.Name = "btn_toevoegen";
            this.btn_toevoegen.Size = new System.Drawing.Size(92, 23);
            this.btn_toevoegen.TabIndex = 5;
            this.btn_toevoegen.Text = "Voeg dier toe";
            this.btn_toevoegen.UseVisualStyleBackColor = true;
            this.btn_toevoegen.Click += new System.EventHandler(this.btn_toevoegen_Click);
            // 
            // btn_verdelen
            // 
            this.btn_verdelen.Location = new System.Drawing.Point(329, 29);
            this.btn_verdelen.Name = "btn_verdelen";
            this.btn_verdelen.Size = new System.Drawing.Size(107, 23);
            this.btn_verdelen.TabIndex = 6;
            this.btn_verdelen.Text = "Dieren verdelen";
            this.btn_verdelen.UseVisualStyleBackColor = true;
            this.btn_verdelen.Click += new System.EventHandler(this.btn_verdelen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 212);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 438);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_verdelen);
            this.Controls.Add(this.btn_toevoegen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_formaat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Naam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GB_formaat.ResumeLayout(false);
            this.GB_formaat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Naam;
        private System.Windows.Forms.RadioButton RB_vlees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_planten;
        private System.Windows.Forms.GroupBox GB_formaat;
        private System.Windows.Forms.RadioButton RB_klein;
        private System.Windows.Forms.RadioButton RB_Middelgroot;
        private System.Windows.Forms.RadioButton RB_groot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_toevoegen;
        private System.Windows.Forms.Button btn_verdelen;
        private System.Windows.Forms.ListBox listBox1;
    }
}

