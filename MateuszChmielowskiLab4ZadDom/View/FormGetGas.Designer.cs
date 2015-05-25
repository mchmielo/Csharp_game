namespace MateuszChmielowskiLab4ZadDom.View
{
    partial class FormGetGas
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
            this.trackBarFuelAmount = new System.Windows.Forms.TrackBar();
            this.labelStationName = new System.Windows.Forms.Label();
            this.textBoxToPay = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelToPay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFuelAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarFuelAmount
            // 
            this.trackBarFuelAmount.Location = new System.Drawing.Point(31, 124);
            this.trackBarFuelAmount.Name = "trackBarFuelAmount";
            this.trackBarFuelAmount.Size = new System.Drawing.Size(398, 45);
            this.trackBarFuelAmount.TabIndex = 0;
            this.trackBarFuelAmount.Scroll += new System.EventHandler(this.trackBarFuelAmount_Scroll);
            // 
            // labelStationName
            // 
            this.labelStationName.AutoSize = true;
            this.labelStationName.Location = new System.Drawing.Point(12, 9);
            this.labelStationName.Name = "labelStationName";
            this.labelStationName.Size = new System.Drawing.Size(35, 13);
            this.labelStationName.TabIndex = 1;
            this.labelStationName.Text = "label1";
            // 
            // textBoxToPay
            // 
            this.textBoxToPay.Enabled = false;
            this.textBoxToPay.Location = new System.Drawing.Point(15, 188);
            this.textBoxToPay.Name = "textBoxToPay";
            this.textBoxToPay.Size = new System.Drawing.Size(447, 20);
            this.textBoxToPay.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(387, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(306, 283);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Kup paliwo";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(427, 142);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(35, 13);
            this.labelMax.TabIndex = 1;
            this.labelMax.Text = "label1";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(12, 142);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(13, 13);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "0";
            // 
            // labelToPay
            // 
            this.labelToPay.AutoSize = true;
            this.labelToPay.Location = new System.Drawing.Point(12, 172);
            this.labelToPay.Name = "labelToPay";
            this.labelToPay.Size = new System.Drawing.Size(62, 13);
            this.labelToPay.TabIndex = 1;
            this.labelToPay.Text = "Do zapłaty:";
            // 
            // FormGetGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 318);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxToPay);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelToPay);
            this.Controls.Add(this.labelStationName);
            this.Controls.Add(this.trackBarFuelAmount);
            this.Name = "FormGetGas";
            this.Text = "FormGetGas";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFuelAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarFuelAmount;
        private System.Windows.Forms.Label labelStationName;
        private System.Windows.Forms.TextBox textBoxToPay;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelToPay;
    }
}