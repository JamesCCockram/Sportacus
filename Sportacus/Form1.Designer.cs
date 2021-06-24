
namespace Sportacus
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
            this.btnYourEvents = new System.Windows.Forms.Button();
            this.btnAvailableEvents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYourEvents
            // 
            this.btnYourEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnYourEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYourEvents.ForeColor = System.Drawing.Color.White;
            this.btnYourEvents.Location = new System.Drawing.Point(269, 106);
            this.btnYourEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYourEvents.Name = "btnYourEvents";
            this.btnYourEvents.Size = new System.Drawing.Size(200, 100);
            this.btnYourEvents.TabIndex = 0;
            this.btnYourEvents.Text = "Your Events";
            this.btnYourEvents.UseVisualStyleBackColor = false;
            // 
            // btnAvailableEvents
            // 
            this.btnAvailableEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnAvailableEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableEvents.ForeColor = System.Drawing.Color.White;
            this.btnAvailableEvents.Location = new System.Drawing.Point(269, 254);
            this.btnAvailableEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAvailableEvents.Name = "btnAvailableEvents";
            this.btnAvailableEvents.Size = new System.Drawing.Size(200, 100);
            this.btnAvailableEvents.TabIndex = 1;
            this.btnAvailableEvents.Text = "Available Events";
            this.btnAvailableEvents.UseVisualStyleBackColor = false;
            this.btnAvailableEvents.Click += new System.EventHandler(this.btnAvailableEvents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 483);
            this.Controls.Add(this.btnAvailableEvents);
            this.Controls.Add(this.btnYourEvents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sportacus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYourEvents;
        private System.Windows.Forms.Button btnAvailableEvents;
    }
}

