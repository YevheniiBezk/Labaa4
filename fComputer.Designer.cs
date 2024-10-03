using System;

namespace Labaa4
{
    partial class fComputer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasWiFi = new System.Windows.Forms.CheckBox();
            this.chbHasGraphicsCard = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbStorage = new System.Windows.Forms.TextBox();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(350, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(350, 47);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasWiFi);
            this.groupBox2.Controls.Add(this.chbHasGraphicsCard);
            this.groupBox2.Location = new System.Drawing.Point(25, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 94);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристика";
            // 
            // chbHasWiFi
            // 
            this.chbHasWiFi.AutoSize = true;
            this.chbHasWiFi.Location = new System.Drawing.Point(6, 61);
            this.chbHasWiFi.Name = "chbHasWiFi";
            this.chbHasWiFi.Size = new System.Drawing.Size(60, 17);
            this.chbHasWiFi.TabIndex = 3;
            this.chbHasWiFi.Text = "Є Wi-Fi";
            this.chbHasWiFi.UseVisualStyleBackColor = true;
            this.chbHasWiFi.CheckedChanged += new System.EventHandler(this.chbHasWiFi_CheckedChanged);
            // 
            // chbHasGraphicsCard
            // 
            this.chbHasGraphicsCard.AutoSize = true;
            this.chbHasGraphicsCard.Location = new System.Drawing.Point(6, 28);
            this.chbHasGraphicsCard.Name = "chbHasGraphicsCard";
            this.chbHasGraphicsCard.Size = new System.Drawing.Size(91, 17);
            this.chbHasGraphicsCard.TabIndex = 2;
            this.chbHasGraphicsCard.Text = "Є відеокарта";
            this.chbHasGraphicsCard.UseVisualStyleBackColor = true;
            this.chbHasGraphicsCard.CheckedChanged += new System.EventHandler(this.chbHasGraphicsCard_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbStorage);
            this.groupBox1.Controls.Add(this.tbRAM);
            this.groupBox1.Controls.Add(this.tbProcessor);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 227);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(135, 141);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 11;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbStorage
            // 
            this.tbStorage.Location = new System.Drawing.Point(135, 114);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.Size = new System.Drawing.Size(100, 20);
            this.tbStorage.TabIndex = 10;
            this.tbStorage.TextChanged += new System.EventHandler(this.tbStorage_TextChanged);
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(135, 88);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(100, 20);
            this.tbRAM.TabIndex = 9;
            this.tbRAM.TextChanged += new System.EventHandler(this.tbRAM_TextChanged);
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(135, 58);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(100, 20);
            this.tbProcessor.TabIndex = 8;
            this.tbProcessor.TextChanged += new System.EventHandler(this.tbProcessor_TextChanged);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(135, 30);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 7;
            this.tbModel.TextChanged += new System.EventHandler(this.tbModel_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ціна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пам\'ять";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Оперативна пам\'ять";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Процесор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // fComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fComputer";
            this.Text = "fComputer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasWiFi;
        private System.Windows.Forms.CheckBox chbHasGraphicsCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbStorage;
        private System.Windows.Forms.TextBox tbRAM;
        private System.Windows.Forms.TextBox tbProcessor;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public EventHandler label6_Click { get; private set; }
        public EventHandler label5_Click { get; private set; }
        public EventHandler label4_Click { get; private set; }
        public EventHandler label3_Click { get; private set; }
        public EventHandler label2_Click { get; private set; }
        public EventHandler label1_Click { get; private set; }
        public EventHandler groupBox1_Enter { get; private set; }
        public EventHandler groupBox2_Enter { get; private set; }
    }
}