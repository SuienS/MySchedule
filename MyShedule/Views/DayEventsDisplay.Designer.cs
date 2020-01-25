namespace MyShedule
{
    partial class DayEventsDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayEventsDisplay));
            this.flpDayEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoEvents = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAddEventsSingleView = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpDayEvents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpDayEvents
            // 
            this.flpDayEvents.Controls.Add(this.lblNoEvents);
            this.flpDayEvents.Location = new System.Drawing.Point(12, 84);
            this.flpDayEvents.Name = "flpDayEvents";
            this.flpDayEvents.Padding = new System.Windows.Forms.Padding(5);
            this.flpDayEvents.Size = new System.Drawing.Size(460, 475);
            this.flpDayEvents.TabIndex = 0;
            // 
            // lblNoEvents
            // 
            this.lblNoEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoEvents.AutoSize = true;
            this.lblNoEvents.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEvents.ForeColor = System.Drawing.Color.White;
            this.lblNoEvents.Location = new System.Drawing.Point(140, 55);
            this.lblNoEvents.Margin = new System.Windows.Forms.Padding(135, 50, 3, 0);
            this.lblNoEvents.Name = "lblNoEvents";
            this.lblNoEvents.Size = new System.Drawing.Size(175, 37);
            this.lblNoEvents.TabIndex = 2;
            this.lblNoEvents.Text = "- No Events -";
            this.lblNoEvents.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(457, 37);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddEventsSingleView
            // 
            this.btnAddEventsSingleView.AutoSize = true;
            this.btnAddEventsSingleView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddEventsSingleView.Depth = 0;
            this.btnAddEventsSingleView.Icon = null;
            this.btnAddEventsSingleView.Location = new System.Drawing.Point(186, 637);
            this.btnAddEventsSingleView.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddEventsSingleView.Name = "btnAddEventsSingleView";
            this.btnAddEventsSingleView.Primary = true;
            this.btnAddEventsSingleView.Size = new System.Drawing.Size(102, 36);
            this.btnAddEventsSingleView.TabIndex = 2;
            this.btnAddEventsSingleView.Text = "Add Events";
            this.btnAddEventsSingleView.UseVisualStyleBackColor = true;
            this.btnAddEventsSingleView.Click += new System.EventHandler(this.btnAddEventsSingleView_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.flpDayEvents);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 638);
            this.panel1.TabIndex = 3;
            // 
            // DayEventsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 699);
            this.Controls.Add(this.btnAddEventsSingleView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DayEventsDisplay";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day View";
            this.Load += new System.EventHandler(this.DayEventsDisplay_Load);
            this.flpDayEvents.ResumeLayout(false);
            this.flpDayEvents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDayEvents;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNoEvents;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddEventsSingleView;
        private System.Windows.Forms.Panel panel1;
    }
}