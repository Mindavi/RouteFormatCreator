namespace RouteFormatCreator
{
    partial class RouteFormatCreator
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
            this.lbStreets = new System.Windows.Forms.ListBox();
            this.tbStreetname = new System.Windows.Forms.TextBox();
            this.txtStreetname = new System.Windows.Forms.Label();
            this.txtLowerbound = new System.Windows.Forms.Label();
            this.nudUpperbound = new System.Windows.Forms.NumericUpDown();
            this.nudLowerbound = new System.Windows.Forms.NumericUpDown();
            this.txtUpperbound = new System.Windows.Forms.Label();
            this.cbRangeType = new System.Windows.Forms.ComboBox();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.txtRangeType = new System.Windows.Forms.Label();
            this.txtDirection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperbound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerbound)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStreets
            // 
            this.lbStreets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStreets.FormattingEnabled = true;
            this.lbStreets.Location = new System.Drawing.Point(0, 177);
            this.lbStreets.Margin = new System.Windows.Forms.Padding(10);
            this.lbStreets.Name = "lbStreets";
            this.lbStreets.Size = new System.Drawing.Size(617, 472);
            this.lbStreets.TabIndex = 0;
            // 
            // tbStreetname
            // 
            this.tbStreetname.AccessibleDescription = "";
            this.tbStreetname.AccessibleName = "Street name";
            this.tbStreetname.Location = new System.Drawing.Point(85, 12);
            this.tbStreetname.Name = "tbStreetname";
            this.tbStreetname.Size = new System.Drawing.Size(100, 20);
            this.tbStreetname.TabIndex = 1;
            // 
            // txtStreetname
            // 
            this.txtStreetname.AutoSize = true;
            this.txtStreetname.Location = new System.Drawing.Point(12, 15);
            this.txtStreetname.Name = "txtStreetname";
            this.txtStreetname.Size = new System.Drawing.Size(67, 13);
            this.txtStreetname.TabIndex = 2;
            this.txtStreetname.Text = "Street name:";
            // 
            // txtLowerbound
            // 
            this.txtLowerbound.AutoSize = true;
            this.txtLowerbound.Location = new System.Drawing.Point(12, 38);
            this.txtLowerbound.Name = "txtLowerbound";
            this.txtLowerbound.Size = new System.Drawing.Size(72, 13);
            this.txtLowerbound.TabIndex = 4;
            this.txtLowerbound.Text = "Lower bound:";
            // 
            // nudUpperbound
            // 
            this.nudUpperbound.Location = new System.Drawing.Point(85, 62);
            this.nudUpperbound.Name = "nudUpperbound";
            this.nudUpperbound.Size = new System.Drawing.Size(120, 20);
            this.nudUpperbound.TabIndex = 5;
            // 
            // nudLowerbound
            // 
            this.nudLowerbound.Location = new System.Drawing.Point(85, 36);
            this.nudLowerbound.Name = "nudLowerbound";
            this.nudLowerbound.Size = new System.Drawing.Size(120, 20);
            this.nudLowerbound.TabIndex = 6;
            // 
            // txtUpperbound
            // 
            this.txtUpperbound.AutoSize = true;
            this.txtUpperbound.Location = new System.Drawing.Point(12, 64);
            this.txtUpperbound.Name = "txtUpperbound";
            this.txtUpperbound.Size = new System.Drawing.Size(72, 13);
            this.txtUpperbound.TabIndex = 7;
            this.txtUpperbound.Text = "Upper bound:";
            // 
            // cbRangeType
            // 
            this.cbRangeType.FormattingEnabled = true;
            this.cbRangeType.Location = new System.Drawing.Point(85, 89);
            this.cbRangeType.Name = "cbRangeType";
            this.cbRangeType.Size = new System.Drawing.Size(121, 21);
            this.cbRangeType.TabIndex = 8;
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(85, 117);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(121, 21);
            this.cbDirection.TabIndex = 9;
            // 
            // txtRangeType
            // 
            this.txtRangeType.AutoSize = true;
            this.txtRangeType.Location = new System.Drawing.Point(12, 92);
            this.txtRangeType.Name = "txtRangeType";
            this.txtRangeType.Size = new System.Drawing.Size(65, 13);
            this.txtRangeType.TabIndex = 10;
            this.txtRangeType.Text = "Range type:";
            // 
            // txtDirection
            // 
            this.txtDirection.AutoSize = true;
            this.txtDirection.Location = new System.Drawing.Point(12, 120);
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(49, 13);
            this.txtDirection.TabIndex = 11;
            this.txtDirection.Text = "Direction";
            // 
            // RouteFormatCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 649);
            this.Controls.Add(this.txtDirection);
            this.Controls.Add(this.txtRangeType);
            this.Controls.Add(this.cbDirection);
            this.Controls.Add(this.cbRangeType);
            this.Controls.Add(this.txtUpperbound);
            this.Controls.Add(this.nudLowerbound);
            this.Controls.Add(this.nudUpperbound);
            this.Controls.Add(this.txtLowerbound);
            this.Controls.Add(this.txtStreetname);
            this.Controls.Add(this.tbStreetname);
            this.Controls.Add(this.lbStreets);
            this.Name = "RouteFormatCreator";
            this.Text = "Route  format creator";
            ((System.ComponentModel.ISupportInitialize)(this.nudUpperbound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowerbound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStreets;
        private System.Windows.Forms.TextBox tbStreetname;
        private System.Windows.Forms.Label txtStreetname;
        private System.Windows.Forms.Label txtLowerbound;
        private System.Windows.Forms.NumericUpDown nudUpperbound;
        private System.Windows.Forms.NumericUpDown nudLowerbound;
        private System.Windows.Forms.Label txtUpperbound;
        private System.Windows.Forms.ComboBox cbRangeType;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Label txtRangeType;
        private System.Windows.Forms.Label txtDirection;
    }
}

