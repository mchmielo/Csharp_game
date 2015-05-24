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
            this.pictureBoxFuel = new System.Windows.Forms.PictureBox();
            this.pictureBoxCoin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuel)).BeginInit();
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
            this.mainMap.Size = new System.Drawing.Size(897, 479);
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
            this.labelPlayerFuel.Location = new System.Drawing.Point(353, 25);
            this.labelPlayerFuel.Name = "labelPlayerFuel";
            this.labelPlayerFuel.Size = new System.Drawing.Size(52, 23);
            this.labelPlayerFuel.TabIndex = 1;
            this.labelPlayerFuel.Text = "label1";
            // 
            // pictureBoxFuel
            // 
            this.pictureBoxFuel.Image = global::MateuszChmielowskiLab4ZadDom.Properties.Resources.fuelGreen;
            this.pictureBoxFuel.Location = new System.Drawing.Point(297, 12);
            this.pictureBoxFuel.Name = "pictureBoxFuel";
            this.pictureBoxFuel.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFuel.TabIndex = 2;
            this.pictureBoxFuel.TabStop = false;
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
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 559);
            this.Controls.Add(this.pictureBoxFuel);
            this.Controls.Add(this.pictureBoxCoin);
            this.Controls.Add(this.labelPlayerFuel);
            this.Controls.Add(this.labelPlayerMoney);
            this.Controls.Add(this.mainMap);
            this.Name = "FormGame";
            this.Text = "FormGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mainMap;
        private System.Windows.Forms.Label labelPlayerMoney;
        private System.Windows.Forms.PictureBox pictureBoxCoin;
        private System.Windows.Forms.PictureBox pictureBoxFuel;
        private System.Windows.Forms.Label labelPlayerFuel;
    }
}