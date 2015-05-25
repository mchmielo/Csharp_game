namespace MateuszChmielowskiLab4ZadDom
{
    partial class FormGame
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
            this.mainMap = new GMap.NET.WindowsForms.GMapControl();
            this.labelPlayerMoney = new System.Windows.Forms.Label();
            this.labelPlayerFuel = new System.Windows.Forms.Label();
            this.progressBarFuelLevel = new System.Windows.Forms.ProgressBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.pictureBoxPlayerCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpeedmeter = new System.Windows.Forms.PictureBox();
            this.pictureFuel = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            this.labelQuestTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeedmeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMap
            // 
            this.mainMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMap.Bearing = 0F;
            this.mainMap.CanDragMap = true;
            this.mainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mainMap.GrayScaleMode = false;
            this.mainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mainMap.LevelsKeepInMemmory = 5;
            this.mainMap.Location = new System.Drawing.Point(12, 68);
            this.mainMap.MarkersEnabled = true;
            this.mainMap.MaxZoom = 2;
            this.mainMap.MinZoom = 2;
            this.mainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mainMap.Name = "mainMap";
            this.mainMap.NegativeMode = false;
            this.mainMap.PolygonsEnabled = true;
            this.mainMap.RetryLoadTile = 0;
            this.mainMap.RoutesEnabled = true;
            this.mainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mainMap.ShowTileGridLines = false;
            this.mainMap.Size = new System.Drawing.Size(948, 479);
            this.mainMap.TabIndex = 0;
            this.mainMap.Zoom = 0D;
            // 
            // labelPlayerMoney
            // 
            this.labelPlayerMoney.AutoSize = true;
            this.labelPlayerMoney.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerMoney.Location = new System.Drawing.Point(68, 25);
            this.labelPlayerMoney.Name = "labelPlayerMoney";
            this.labelPlayerMoney.Size = new System.Drawing.Size(52, 23);
            this.labelPlayerMoney.TabIndex = 1;
            this.labelPlayerMoney.Text = "label1";
            // 
            // labelPlayerFuel
            // 
            this.labelPlayerFuel.AutoSize = true;
            this.labelPlayerFuel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayerFuel.Location = new System.Drawing.Point(510, 25);
            this.labelPlayerFuel.Name = "labelPlayerFuel";
            this.labelPlayerFuel.Size = new System.Drawing.Size(52, 23);
            this.labelPlayerFuel.TabIndex = 1;
            this.labelPlayerFuel.Text = "label1";
            // 
            // progressBarFuelLevel
            // 
            this.progressBarFuelLevel.Location = new System.Drawing.Point(255, 25);
            this.progressBarFuelLevel.Name = "progressBarFuelLevel";
            this.progressBarFuelLevel.Size = new System.Drawing.Size(249, 23);
            this.progressBarFuelLevel.Step = 1;
            this.progressBarFuelLevel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarFuelLevel.TabIndex = 3;
            this.progressBarFuelLevel.Value = 100;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpeed.Location = new System.Drawing.Point(667, 25);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(52, 23);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "label1";
            // 
            // pictureBoxPlayerCar
            // 
            this.pictureBoxPlayerCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPlayerCar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayerCar.Image = global::MateuszChmielowskiLab4ZadDom.Properties.Resources.Truck1;
            this.pictureBoxPlayerCar.Location = new System.Drawing.Point(475, 282);
            this.pictureBoxPlayerCar.Name = "pictureBoxPlayerCar";
            this.pictureBoxPlayerCar.Size = new System.Drawing.Size(22, 50);
            this.pictureBoxPlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayerCar.TabIndex = 2;
            this.pictureBoxPlayerCar.TabStop = false;
            // 
            // pictureBoxSpeedmeter
            // 
            this.pictureBoxSpeedmeter.Image = global::MateuszChmielowskiLab4ZadDom.Properties.Resources.speedmeter;
            this.pictureBoxSpeedmeter.Location = new System.Drawing.Point(611, 12);
            this.pictureBoxSpeedmeter.Name = "pictureBoxSpeedmeter";
            this.pictureBoxSpeedmeter.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSpeedmeter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSpeedmeter.TabIndex = 2;
            this.pictureBoxSpeedmeter.TabStop = false;
            // 
            // pictureFuel
            // 
            this.pictureFuel.Image = global::MateuszChmielowskiLab4ZadDom.Properties.Resources.fuelGreen;
            this.pictureFuel.Location = new System.Drawing.Point(199, 12);
            this.pictureFuel.Name = "pictureFuel";
            this.pictureFuel.Size = new System.Drawing.Size(50, 50);
            this.pictureFuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFuel.TabIndex = 2;
            this.pictureFuel.TabStop = false;
            // 
            // pictureBoxCoin
            // 
            this.pictureBoxCoin.Image = global::MateuszChmielowskiLab4ZadDom.Properties.Resources.coin;
            this.pictureBoxCoin.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCoin.Name = "pictureBoxCoin";
            this.pictureBoxCoin.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoin.TabIndex = 2;
            this.pictureBoxCoin.TabStop = false;
            // 
            // labelQuestTimer
            // 
            this.labelQuestTimer.AutoSize = true;
            this.labelQuestTimer.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuestTimer.Location = new System.Drawing.Point(821, 19);
            this.labelQuestTimer.Name = "labelQuestTimer";
            this.labelQuestTimer.Size = new System.Drawing.Size(72, 31);
            this.labelQuestTimer.TabIndex = 1;
            this.labelQuestTimer.Text = "label1";
            this.labelQuestTimer.Visible = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(972, 559);
            this.Controls.Add(this.progressBarFuelLevel);
            this.Controls.Add(this.pictureBoxPlayerCar);
            this.Controls.Add(this.pictureBoxSpeedmeter);
            this.Controls.Add(this.pictureFuel);
            this.Controls.Add(this.pictureBoxCoin);
            this.Controls.Add(this.labelQuestTimer);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelPlayerFuel);
            this.Controls.Add(this.labelPlayerMoney);
            this.Controls.Add(this.mainMap);
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGame_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeedmeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mainMap;
        private System.Windows.Forms.Label labelPlayerMoney;
        private System.Windows.Forms.PictureBox pictureBoxCoin;
        private System.Windows.Forms.Label labelPlayerFuel;
        private System.Windows.Forms.PictureBox pictureFuel;
        private System.Windows.Forms.PictureBox pictureBoxPlayerCar;
        private System.Windows.Forms.ProgressBar progressBarFuelLevel;
        private System.Windows.Forms.PictureBox pictureBoxSpeedmeter;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelQuestTimer;
    }
}