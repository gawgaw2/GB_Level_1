using System;

namespace Удвоитель
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCommfnd1 = new System.Windows.Forms.Button();
            this.btnConnfnd2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(31, 77);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(16, 17);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "0";
            // 
            // btnCommfnd1
            // 
            this.btnCommfnd1.Location = new System.Drawing.Point(93, 71);
            this.btnCommfnd1.Name = "btnCommfnd1";
            this.btnCommfnd1.Size = new System.Drawing.Size(75, 23);
            this.btnCommfnd1.TabIndex = 1;
            this.btnCommfnd1.Text = "+1";
            this.btnCommfnd1.UseVisualStyleBackColor = true;
            this.btnCommfnd1.Click += new System.EventHandler(this.btnCommfnd1_Click);
            // 
            // btnConnfnd2
            // 
            this.btnConnfnd2.Location = new System.Drawing.Point(93, 124);
            this.btnConnfnd2.Name = "btnConnfnd2";
            this.btnConnfnd2.Size = new System.Drawing.Size(75, 23);
            this.btnConnfnd2.TabIndex = 2;
            this.btnConnfnd2.Text = "*2";
            this.btnConnfnd2.UseVisualStyleBackColor = true;
            this.btnConnfnd2.Click += new System.EventHandler(this.btnConnfnd2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(93, 179);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(202, 76);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(16, 17);
            this.lbl_1.TabIndex = 4;
            this.lbl_1.Text = "0";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(205, 129);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(16, 17);
            this.lbl_2.TabIndex = 5;
            this.lbl_2.Text = "0";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(205, 184);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(16, 17);
            this.lbl_3.TabIndex = 6;
            this.lbl_3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConnfnd2);
            this.Controls.Add(this.btnCommfnd1);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCommfnd1;
        private System.Windows.Forms.Button btnConnfnd2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
    }
}

