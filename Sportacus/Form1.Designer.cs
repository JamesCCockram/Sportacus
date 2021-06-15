
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
            this.btnYourEvents.BackColor = System.Drawing.Color.Black;
            this.btnYourEvents.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYourEvents.ForeColor = System.Drawing.Color.White;
            this.btnYourEvents.Location = new System.Drawing.Point(658, 250);
            this.btnYourEvents.Name = "btnYourEvents";
            this.btnYourEvents.Size = new System.Drawing.Size(250, 150);
            this.btnYourEvents.TabIndex = 0;
            this.btnYourEvents.Text = "Your Events";
            this.btnYourEvents.UseVisualStyleBackColor = false;
            // 
            // btnAvailableEvents
            // 
            this.btnAvailableEvents.BackColor = System.Drawing.Color.Black;
            this.btnAvailableEvents.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailableEvents.ForeColor = System.Drawing.Color.White;
            this.btnAvailableEvents.Location = new System.Drawing.Point(658, 465);
            this.btnAvailableEvents.Name = "btnAvailableEvents";
            this.btnAvailableEvents.Size = new System.Drawing.Size(250, 150);
            this.btnAvailableEvents.TabIndex = 1;
            this.btnAvailableEvents.Text = "Available Events";
            this.btnAvailableEvents.UseVisualStyleBackColor = false;
            this.btnAvailableEvents.Click += new System.EventHandler(this.btnAvailableEvents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 929);
            this.Controls.Add(this.btnAvailableEvents);
            this.Controls.Add(this.btnYourEvents);
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

