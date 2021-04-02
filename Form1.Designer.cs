using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace KalkulatorIP_v2
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            this.IPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.networkAdressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.firstUsefulTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lastUsefulTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ipOctet1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ipOctet2 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet3 = new System.Windows.Forms.NumericUpDown();
            this.ipOctet4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cidrTextBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(150, 68);
            this.IPTextBox.Mask = "###\\.###\\.###\\.###";
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(87, 23);
            this.IPTextBox.TabIndex = 0;
            this.IPTextBox.Text = "255255255255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska:";
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(150, 97);
            this.MaskTextBox.Mask = "###\\.###\\.###\\.###";
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(87, 23);
            this.MaskTextBox.TabIndex = 2;
            this.MaskTextBox.Text = "255255255255";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(244, 71);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(156, 165);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Policz";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateIP);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres sieci:";
            // 
            // networkAdressTextBox
            // 
            this.networkAdressTextBox.Location = new System.Drawing.Point(150, 126);
            this.networkAdressTextBox.Mask = "###\\.###\\.###\\.###";
            this.networkAdressTextBox.Name = "networkAdressTextBox";
            this.networkAdressTextBox.ReadOnly = true;
            this.networkAdressTextBox.Size = new System.Drawing.Size(87, 23);
            this.networkAdressTextBox.TabIndex = 5;
            this.networkAdressTextBox.Text = "055055055055";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(150, 155);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(87, 23);
            this.BroadcastTextBox.TabIndex = 7;
            this.BroadcastTextBox.Text = "055055055055";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres rozgłoszeniowy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pierwszy użyteczny adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ostatni użyteczny adres :";
            // 
            // firstUsefulTextBox
            // 
            this.firstUsefulTextBox.Location = new System.Drawing.Point(150, 184);
            this.firstUsefulTextBox.Mask = "###\\.###\\.###\\.###";
            this.firstUsefulTextBox.Name = "firstUsefulTextBox";
            this.firstUsefulTextBox.ReadOnly = true;
            this.firstUsefulTextBox.Size = new System.Drawing.Size(87, 23);
            this.firstUsefulTextBox.TabIndex = 11;
            this.firstUsefulTextBox.Text = "055055055055";
            // 
            // lastUsefulTextBox
            // 
            this.lastUsefulTextBox.Location = new System.Drawing.Point(150, 213);
            this.lastUsefulTextBox.Mask = "###\\.###\\.###\\.###";
            this.lastUsefulTextBox.Name = "lastUsefulTextBox";
            this.lastUsefulTextBox.ReadOnly = true;
            this.lastUsefulTextBox.Size = new System.Drawing.Size(87, 23);
            this.lastUsefulTextBox.TabIndex = 12;
            this.lastUsefulTextBox.Text = "055055055055";
            // 
            // ipOctet1
            // 
            this.ipOctet1.Location = new System.Drawing.Point(78, 12);
            this.ipOctet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet1.Name = "ipOctet1";
            this.ipOctet1.Size = new System.Drawing.Size(42, 23);
            this.ipOctet1.TabIndex = 13;
            this.ipOctet1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adres IP:";
            // 
            // ipOctet2
            // 
            this.ipOctet2.Location = new System.Drawing.Point(126, 12);
            this.ipOctet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet2.Name = "ipOctet2";
            this.ipOctet2.Size = new System.Drawing.Size(42, 23);
            this.ipOctet2.TabIndex = 15;
            this.ipOctet2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet3
            // 
            this.ipOctet3.Location = new System.Drawing.Point(174, 12);
            this.ipOctet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet3.Name = "ipOctet3";
            this.ipOctet3.Size = new System.Drawing.Size(42, 23);
            this.ipOctet3.TabIndex = 16;
            this.ipOctet3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ipOctet4
            // 
            this.ipOctet4.Location = new System.Drawing.Point(222, 12);
            this.ipOctet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOctet4.Name = "ipOctet4";
            this.ipOctet4.Size = new System.Drawing.Size(42, 23);
            this.ipOctet4.TabIndex = 17;
            this.ipOctet4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Maska:";
            // 
            // cidrTextBox
            // 
            this.cidrTextBox.Location = new System.Drawing.Point(350, 14);
            this.cidrTextBox.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.cidrTextBox.Name = "cidrTextBox";
            this.cidrTextBox.Size = new System.Drawing.Size(42, 23);
            this.cidrTextBox.TabIndex = 19;
            this.cidrTextBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(430, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cidrTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ipOctet4);
            this.Controls.Add(this.ipOctet3);
            this.Controls.Add(this.ipOctet2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ipOctet1);
            this.Controls.Add(this.lastUsefulTextBox);
            this.Controls.Add(this.firstUsefulTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.networkAdressTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPTextBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOctet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaskedTextBox IPTextBox;
        private Label label1;
        private Label label2;
        private MaskedTextBox MaskTextBox;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Button CalculateButton;
        private Label label3;
        private MaskedTextBox networkAdressTextBox;

        private MaskedTextBox BroadcastTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox firstUsefulTextBox;
        private MaskedTextBox lastUsefulTextBox;
        private NumericUpDown ipOctet1;
        private Label label7;
        private NumericUpDown ipOctet2;
        private NumericUpDown ipOctet3;
        private NumericUpDown ipOctet4;
        private Label label8;
        private NumericUpDown cidrTextBox;
        private Button button1;
    }
}