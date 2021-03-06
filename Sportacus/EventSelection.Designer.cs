
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.panelHeats = new System.Windows.Forms.Panel();
            this.radioButtonHeatC = new System.Windows.Forms.RadioButton();
            this.radioButtonHeatB = new System.Windows.Forms.RadioButton();
            this.radioButtonHeatA = new System.Windows.Forms.RadioButton();
            this.panelHeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(72, 89);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(269, 46);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Event Name";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(75, 472);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 50);
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
            this.btnJoin.Size = new System.Drawing.Size(109, 50);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // panelHeats
            // 
            this.panelHeats.Controls.Add(this.radioButtonHeatC);
            this.panelHeats.Controls.Add(this.radioButtonHeatB);
            this.panelHeats.Controls.Add(this.radioButtonHeatA);
            this.panelHeats.Location = new System.Drawing.Point(119, 152);
            this.panelHeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeats.Name = "panelHeats";
            this.panelHeats.Size = new System.Drawing.Size(200, 164);
            this.panelHeats.TabIndex = 4;
            // 
            // radioButtonHeatC
            // 
            this.radioButtonHeatC.AutoSize = true;
            this.radioButtonHeatC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHeatC.Location = new System.Drawing.Point(4, 85);
            this.radioButtonHeatC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHeatC.Name = "radioButtonHeatC";
            this.radioButtonHeatC.Size = new System.Drawing.Size(130, 35);
            this.radioButtonHeatC.TabIndex = 2;
            this.radioButtonHeatC.Text = "Heat C";
            this.radioButtonHeatC.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeatB
            // 
            this.radioButtonHeatB.AutoSize = true;
            this.radioButtonHeatB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHeatB.Location = new System.Drawing.Point(5, 44);
            this.radioButtonHeatB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHeatB.Name = "radioButtonHeatB";
            this.radioButtonHeatB.Size = new System.Drawing.Size(128, 35);
            this.radioButtonHeatB.TabIndex = 1;
            this.radioButtonHeatB.Text = "Heat B";
            this.radioButtonHeatB.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeatA
            // 
            this.radioButtonHeatA.AutoSize = true;
            this.radioButtonHeatA.Checked = true;
            this.radioButtonHeatA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHeatA.Location = new System.Drawing.Point(5, 2);
            this.radioButtonHeatA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHeatA.Name = "radioButtonHeatA";
            this.radioButtonHeatA.Size = new System.Drawing.Size(128, 35);
            this.radioButtonHeatA.TabIndex = 0;
            this.radioButtonHeatA.TabStop = true;
            this.radioButtonHeatA.Text = "Heat A";
            this.radioButtonHeatA.UseVisualStyleBackColor = true;
            // 
            // EventSelection
            // 
            this.AcceptButton = this.btnJoin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(429, 582);
            this.Controls.Add(this.panelHeats);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEventName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventSelection";
            this.Text = "Event Selection";
            this.Load += new System.EventHandler(this.EventSelection_Load);
            this.panelHeats.ResumeLayout(false);
            this.panelHeats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Panel panelHeats;
        private System.Windows.Forms.RadioButton radioButtonHeatC;
        private System.Windows.Forms.RadioButton radioButtonHeatB;
        private System.Windows.Forms.RadioButton radioButtonHeatA;
    }
}