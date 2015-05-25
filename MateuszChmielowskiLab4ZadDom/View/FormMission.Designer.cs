namespace MateuszChmielowskiLab4ZadDom.View
{
    partial class FormMission
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
            this.labelMission = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonDeny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMission
            // 
            this.labelMission.AutoSize = true;
            this.labelMission.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMission.Location = new System.Drawing.Point(161, 9);
            this.labelMission.Name = "labelMission";
            this.labelMission.Size = new System.Drawing.Size(86, 37);
            this.labelMission.TabIndex = 0;
            this.labelMission.Text = "Misja!";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(39, 60);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Brak opisu.";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(146, 271);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(126, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Akceptuję misję!";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonDeny
            // 
            this.buttonDeny.Location = new System.Drawing.Point(278, 272);
            this.buttonDeny.Name = "buttonDeny";
            this.buttonDeny.Size = new System.Drawing.Size(126, 23);
            this.buttonDeny.TabIndex = 1;
            this.buttonDeny.Text = "OdrzucamMisje";
            this.buttonDeny.UseVisualStyleBackColor = true;
            this.buttonDeny.Click += new System.EventHandler(this.buttonDeny_Click);
            // 
            // FormMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 307);
            this.Controls.Add(this.buttonDeny);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelMission);
            this.Name = "FormMission";
            this.Text = "FormMission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMission;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonDeny;
    }
}