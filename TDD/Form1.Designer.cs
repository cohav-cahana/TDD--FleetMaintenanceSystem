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
            this.track_random = new System.Windows.Forms.Button();
            this.btn_all_cars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // car_info
            // 
            this.car_info.Location = new System.Drawing.Point(264, 99);
            this.car_info.Name = "car_info";
            this.car_info.Size = new System.Drawing.Size(260, 64);
            this.car_info.TabIndex = 0;
            this.car_info.Text = "הזנת רכבים";
            this.car_info.UseVisualStyleBackColor = true;
            this.car_info.Click += new System.EventHandler(this.car_info_Click);
            // 
            // track_random
            // 
            this.track_random.Location = new System.Drawing.Point(264, 183);
            this.track_random.Name = "track_random";
            this.track_random.Size = new System.Drawing.Size(260, 64);
            this.track_random.TabIndex = 1;
            this.track_random.Text = "מעקב אחרי תחזוקה";
            this.track_random.UseVisualStyleBackColor = true;
            // 
            // btn_all_cars
            // 
            this.btn_all_cars.Location = new System.Drawing.Point(264, 264);
            this.btn_all_cars.Name = "btn_all_cars";
            this.btn_all_cars.Size = new System.Drawing.Size(260, 63);
            this.btn_all_cars.TabIndex = 2;
            this.btn_all_cars.Text = "הצגת כל הרכבים הקיימים";
            this.btn_all_cars.UseVisualStyleBackColor = true;
            this.btn_all_cars.Click += new System.EventHandler(this.btn_all_cars_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.btn_all_cars);
            this.Controls.Add(this.track_random);
            this.Controls.Add(this.car_info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button car_info;
        private System.Windows.Forms.Button track_random;
        private System.Windows.Forms.Button btn_all_cars;
    }
}

