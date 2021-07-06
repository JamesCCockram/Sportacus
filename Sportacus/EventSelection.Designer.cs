
namespace Sportacus
{
    partial class EventSelection
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
            this.lblEventName = new System.Windows.Forms.Label();
            this.radioButtonHeat1 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(150, 100);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(259, 48);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonHeat1
            // 
            this.radioButtonHeat1.AutoSize = true;
            this.radioButtonHeat1.Location = new System.Drawing.Point(220, 220);
            this.radioButtonHeat1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonHeat1.Name = "radioButtonHeat1";
            this.radioButtonHeat1.Size = new System.Drawing.Size(108, 29);
            this.radioButtonHeat1.TabIndex = 1;
            this.radioButtonHeat1.TabStop = true;
            this.radioButtonHeat1.Text = "Heat A";
            this.radioButtonHeat1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 590);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(310, 590);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(150, 44);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            // 
            // EventSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 729);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.radioButtonHeat1);
            this.Controls.Add(this.lblEventName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventSelection";
            this.Text = "Event Selection";
            this.Load += new System.EventHandler(this.EventSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.RadioButton radioButtonHeat1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnJoin;
    }
}