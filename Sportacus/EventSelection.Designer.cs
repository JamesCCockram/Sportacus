
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHeat2 = new System.Windows.Forms.RadioButton();
            this.radioButtonHeat3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(112, 80);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(202, 37);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonHeat1
            // 
            this.radioButtonHeat1.AutoSize = true;
            this.radioButtonHeat1.Location = new System.Drawing.Point(7, 27);
            this.radioButtonHeat1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonHeat1.Name = "radioButtonHeat1";
            this.radioButtonHeat1.Size = new System.Drawing.Size(84, 24);
            this.radioButtonHeat1.TabIndex = 1;
            this.radioButtonHeat1.TabStop = true;
            this.radioButtonHeat1.Text = "Heat A";
            this.radioButtonHeat1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(75, 472);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(232, 472);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(112, 35);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHeat3);
            this.groupBox1.Controls.Add(this.radioButtonHeat2);
            this.groupBox1.Controls.Add(this.radioButtonHeat1);
            this.groupBox1.Location = new System.Drawing.Point(114, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heats";
            // 
            // radioButtonHeat2
            // 
            this.radioButtonHeat2.AutoSize = true;
            this.radioButtonHeat2.Location = new System.Drawing.Point(7, 59);
            this.radioButtonHeat2.Name = "radioButtonHeat2";
            this.radioButtonHeat2.Size = new System.Drawing.Size(84, 24);
            this.radioButtonHeat2.TabIndex = 2;
            this.radioButtonHeat2.TabStop = true;
            this.radioButtonHeat2.Text = "Heat B";
            this.radioButtonHeat2.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeat3
            // 
            this.radioButtonHeat3.AutoSize = true;
            this.radioButtonHeat3.Location = new System.Drawing.Point(7, 90);
            this.radioButtonHeat3.Name = "radioButtonHeat3";
            this.radioButtonHeat3.Size = new System.Drawing.Size(84, 24);
            this.radioButtonHeat3.TabIndex = 3;
            this.radioButtonHeat3.TabStop = true;
            this.radioButtonHeat3.Text = "Heat C";
            this.radioButtonHeat3.UseVisualStyleBackColor = true;
            // 
            // EventSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEventName);
            this.Name = "EventSelection";
            this.Text = "Event Selection";
            this.Load += new System.EventHandler(this.EventSelection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.RadioButton radioButtonHeat1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonHeat2;
        private System.Windows.Forms.RadioButton radioButtonHeat3;
    }
}