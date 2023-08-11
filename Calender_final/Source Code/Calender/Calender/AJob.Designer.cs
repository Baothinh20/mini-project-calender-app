namespace Calender
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.nmtominutes = new System.Windows.Forms.NumericUpDown();
            this.nmtohour = new System.Windows.Forms.NumericUpDown();
            this.To = new System.Windows.Forms.Label();
            this.nmfromminutes = new System.Windows.Forms.NumericUpDown();
            this.nmfromhour = new System.Windows.Forms.NumericUpDown();
            this.txbJob = new System.Windows.Forms.TextBox();
            this.ckbDone = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmtominutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtohour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfromminutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfromhour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txbJob);
            this.panel1.Controls.Add(this.ckbDone);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 39);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.nmtominutes);
            this.panel2.Controls.Add(this.nmtohour);
            this.panel2.Controls.Add(this.To);
            this.panel2.Controls.Add(this.nmfromminutes);
            this.panel2.Controls.Add(this.nmfromhour);
            this.panel2.Location = new System.Drawing.Point(357, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 33);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(517, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(443, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 29);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(286, 3);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(151, 28);
            this.cbStatus.TabIndex = 5;
            // 
            // nmtominutes
            // 
            this.nmtominutes.Location = new System.Drawing.Point(223, 4);
            this.nmtominutes.Name = "nmtominutes";
            this.nmtominutes.Size = new System.Drawing.Size(57, 27);
            this.nmtominutes.TabIndex = 4;
            // 
            // nmtohour
            // 
            this.nmtohour.Location = new System.Drawing.Point(160, 3);
            this.nmtohour.Name = "nmtohour";
            this.nmtohour.Size = new System.Drawing.Size(57, 27);
            this.nmtohour.TabIndex = 3;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(129, 6);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(25, 20);
            this.To.TabIndex = 2;
            this.To.Text = "To";
            // 
            // nmfromminutes
            // 
            this.nmfromminutes.Location = new System.Drawing.Point(66, 4);
            this.nmfromminutes.Name = "nmfromminutes";
            this.nmfromminutes.Size = new System.Drawing.Size(57, 27);
            this.nmfromminutes.TabIndex = 1;
            // 
            // nmfromhour
            // 
            this.nmfromhour.Location = new System.Drawing.Point(3, 3);
            this.nmfromhour.Name = "nmfromhour";
            this.nmfromhour.Size = new System.Drawing.Size(57, 27);
            this.nmfromhour.TabIndex = 0;
            // 
            // txbJob
            // 
            this.txbJob.Location = new System.Drawing.Point(36, 8);
            this.txbJob.Name = "txbJob";
            this.txbJob.Size = new System.Drawing.Size(315, 27);
            this.txbJob.TabIndex = 1;
            // 
            // ckbDone
            // 
            this.ckbDone.AutoSize = true;
            this.ckbDone.Location = new System.Drawing.Point(12, 12);
            this.ckbDone.Name = "ckbDone";
            this.ckbDone.Size = new System.Drawing.Size(18, 17);
            this.ckbDone.TabIndex = 0;
            this.ckbDone.UseVisualStyleBackColor = true;
            this.ckbDone.CheckedChanged += new System.EventHandler(this.ckbDone_CheckedChanged);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(960, 45);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmtominutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmtohour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfromminutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfromhour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnDelete;
        private Button btnEdit;
        private ComboBox cbStatus;
        private NumericUpDown nmtominutes;
        private NumericUpDown nmtohour;
        private Label To;
        private NumericUpDown nmfromminutes;
        private NumericUpDown nmfromhour;
        private TextBox txbJob;
        private CheckBox ckbDone;
    }
}
