
namespace reverse2
{
    partial class Casino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Casino));
            this.button = new System.Windows.Forms.Button();
            this.numbers = new System.Windows.Forms.Label();
            this.notifications = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(87, 48);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(207, 60);
            this.button.TabIndex = 0;
            this.button.Text = "try your luck";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // numbers
            // 
            this.numbers.AutoSize = true;
            this.numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numbers.Location = new System.Drawing.Point(396, 9);
            this.numbers.Name = "numbers";
            this.numbers.Size = new System.Drawing.Size(392, 135);
            this.numbers.TabIndex = 1;
            this.numbers.Text = "00000";
            // 
            // notifications
            // 
            this.notifications.AutoSize = true;
            this.notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notifications.Location = new System.Drawing.Point(12, 397);
            this.notifications.Name = "notifications";
            this.notifications.Size = new System.Drawing.Size(0, 44);
            this.notifications.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(476, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 247);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Casino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notifications);
            this.Controls.Add(this.numbers);
            this.Controls.Add(this.button);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Casino";
            this.Text = "FlagCasino OATCTF2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label numbers;
        private System.Windows.Forms.Label notifications;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

