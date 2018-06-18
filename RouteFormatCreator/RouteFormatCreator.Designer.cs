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
            this.lblNameWarning = new System.Windows.Forms.Label();
            this.lblLowerboundWarning = new System.Windows.Forms.Label();
            this.lblUpperboundWarning = new System.Windows.Forms.Label();
            this.lblRangeTypeWarning = new System.Windows.Forms.Label();
            this.lblDirectionWarning = new System.Windows.Forms.Label();
            this.btnAddStreet = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
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
            this.tbStreetname.Size = new System.Drawing.Size(120, 20);
            this.tbStreetname.TabIndex = 1;
            this.tbStreetname.TextChanged += new System.EventHandler(this.tbStreetname_TextChanged);
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
            this.nudUpperbound.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudUpperbound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperbound.Name = "nudUpperbound";
            this.nudUpperbound.Size = new System.Drawing.Size(120, 20);
            this.nudUpperbound.TabIndex = 5;
            this.nudUpperbound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUpperbound.ValueChanged += new System.EventHandler(this.nudUpperbound_ValueChanged);
            // 
            // nudLowerbound
            // 
            this.nudLowerbound.Location = new System.Drawing.Point(85, 36);
            this.nudLowerbound.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLowerbound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerbound.Name = "nudLowerbound";
            this.nudLowerbound.Size = new System.Drawing.Size(120, 20);
            this.nudLowerbound.TabIndex = 6;
            this.nudLowerbound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLowerbound.ValueChanged += new System.EventHandler(this.nudLowerbound_ValueChanged);
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
            this.cbRangeType.Size = new System.Drawing.Size(120, 21);
            this.cbRangeType.TabIndex = 8;
            this.cbRangeType.SelectedIndexChanged += new System.EventHandler(this.cbRangeType_SelectedIndexChanged);
            // 
            // cbDirection
            // 
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(85, 117);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(120, 21);
            this.cbDirection.TabIndex = 9;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
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
            // lblNameWarning
            // 
            this.lblNameWarning.AutoSize = true;
            this.lblNameWarning.Location = new System.Drawing.Point(224, 18);
            this.lblNameWarning.Name = "lblNameWarning";
            this.lblNameWarning.Size = new System.Drawing.Size(10, 13);
            this.lblNameWarning.TabIndex = 12;
            this.lblNameWarning.Text = ".";
            // 
            // lblLowerboundWarning
            // 
            this.lblLowerboundWarning.AutoSize = true;
            this.lblLowerboundWarning.Location = new System.Drawing.Point(224, 38);
            this.lblLowerboundWarning.Name = "lblLowerboundWarning";
            this.lblLowerboundWarning.Size = new System.Drawing.Size(10, 13);
            this.lblLowerboundWarning.TabIndex = 13;
            this.lblLowerboundWarning.Text = ".";
            // 
            // lblUpperboundWarning
            // 
            this.lblUpperboundWarning.AutoSize = true;
            this.lblUpperboundWarning.Location = new System.Drawing.Point(224, 64);
            this.lblUpperboundWarning.Name = "lblUpperboundWarning";
            this.lblUpperboundWarning.Size = new System.Drawing.Size(10, 13);
            this.lblUpperboundWarning.TabIndex = 14;
            this.lblUpperboundWarning.Text = ".";
            // 
            // lblRangeTypeWarning
            // 
            this.lblRangeTypeWarning.AutoSize = true;
            this.lblRangeTypeWarning.Location = new System.Drawing.Point(224, 92);
            this.lblRangeTypeWarning.Name = "lblRangeTypeWarning";
            this.lblRangeTypeWarning.Size = new System.Drawing.Size(10, 13);
            this.lblRangeTypeWarning.TabIndex = 15;
            this.lblRangeTypeWarning.Text = ".";
            // 
            // lblDirectionWarning
            // 
            this.lblDirectionWarning.AutoSize = true;
            this.lblDirectionWarning.Location = new System.Drawing.Point(224, 120);
            this.lblDirectionWarning.Name = "lblDirectionWarning";
            this.lblDirectionWarning.Size = new System.Drawing.Size(10, 13);
            this.lblDirectionWarning.TabIndex = 16;
            this.lblDirectionWarning.Text = ".";
            // 
            // btnAddStreet
            // 
            this.btnAddStreet.Location = new System.Drawing.Point(85, 144);
            this.btnAddStreet.Name = "btnAddStreet";
            this.btnAddStreet.Size = new System.Drawing.Size(120, 23);
            this.btnAddStreet.TabIndex = 17;
            this.btnAddStreet.Text = "Add street";
            this.btnAddStreet.UseVisualStyleBackColor = true;
            this.btnAddStreet.Click += new System.EventHandler(this.btnAddStreet_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(530, 141);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export list";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RouteFormatCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 649);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAddStreet);
            this.Controls.Add(this.lblDirectionWarning);
            this.Controls.Add(this.lblRangeTypeWarning);
            this.Controls.Add(this.lblUpperboundWarning);
            this.Controls.Add(this.lblLowerboundWarning);
            this.Controls.Add(this.lblNameWarning);
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
        private System.Windows.Forms.Label lblNameWarning;
        private System.Windows.Forms.Label lblLowerboundWarning;
        private System.Windows.Forms.Label lblUpperboundWarning;
        private System.Windows.Forms.Label lblRangeTypeWarning;
        private System.Windows.Forms.Label lblDirectionWarning;
        private System.Windows.Forms.Button btnAddStreet;
        private System.Windows.Forms.Button btnExport;
    }
}

