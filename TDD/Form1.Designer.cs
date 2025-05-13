namespace TDD
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
            this.car_info = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // car_info
            // 
            this.car_info.BackColor = System.Drawing.Color.LightGray;
            this.car_info.Cursor = System.Windows.Forms.Cursors.Default;
            this.car_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car_info.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.car_info.Location = new System.Drawing.Point(249, 216);
            this.car_info.Name = "car_info";
            this.car_info.Size = new System.Drawing.Size(260, 64);
            this.car_info.TabIndex = 0;
            this.car_info.Text = "Vehicle Details ";
            this.car_info.UseVisualStyleBackColor = false;
            this.car_info.Click += new System.EventHandler(this.car_info_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(538, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "עצור הרצה";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::TDD.Properties.Resources.car_back;
            this.ClientSize = new System.Drawing.Size(737, 533);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.car_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button car_info;
        private System.Windows.Forms.Button track_random;
        private System.Windows.Forms.Button btn_all_cars;
        private System.Windows.Forms.Button btnExit;
    }
}

