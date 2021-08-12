
namespace Sportacus
{
    partial class Events
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.studentEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentEventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentEventsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentEventsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1478, 800);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(Sportacus.Main.Student);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "[Student] Events";
            // 
            // studentEventsBindingSource
            // 
            this.studentEventsBindingSource.DataSource = typeof(Sportacus.Events);
            // 
            // studentEventsBindingSource1
            // 
            this.studentEventsBindingSource1.DataSource = typeof(Sportacus.Events);
            // 
            // studentEventsBindingSource2
            // 
            this.studentEventsBindingSource2.DataSource = typeof(Sportacus.Events);
            // 
            // studentEventsBindingSource3
            // 
            this.studentEventsBindingSource3.DataSource = typeof(Sportacus.Events);
            // 
            // Events
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.StudentEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentEventsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentEventsBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource studentEventsBindingSource1;
        private System.Windows.Forms.BindingSource studentEventsBindingSource2;
        private System.Windows.Forms.BindingSource studentEventsBindingSource3;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}