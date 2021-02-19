namespace FretMate.Forms
{
    partial class frmFretBoard
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
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuScales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChords = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdDisplayAll = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.pnlFretMarkers = new System.Windows.Forms.Panel();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuScales,
            this.mnuChords,
            this.mnuDisplay,
            this.cmdDisplayAll});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(130, 92);
            // 
            // mnuScales
            // 
            this.mnuScales.Name = "mnuScales";
            this.mnuScales.Size = new System.Drawing.Size(152, 22);
            this.mnuScales.Text = "Scales...";
            this.mnuScales.Click += new System.EventHandler(this.mnuScales_Click);
            // 
            // mnuChords
            // 
            this.mnuChords.Name = "mnuChords";
            this.mnuChords.Size = new System.Drawing.Size(152, 22);
            this.mnuChords.Text = "Chords...";
            this.mnuChords.Click += new System.EventHandler(this.mnuChords_Click);
            // 
            // mnuDisplay
            // 
            this.mnuDisplay.Name = "mnuDisplay";
            this.mnuDisplay.Size = new System.Drawing.Size(152, 22);
            this.mnuDisplay.Text = "Display...";
            this.mnuDisplay.Click += new System.EventHandler(this.mnuDisplay_Click);
            // 
            // cmdDisplayAll
            // 
            this.cmdDisplayAll.Name = "cmdDisplayAll";
            this.cmdDisplayAll.Size = new System.Drawing.Size(152, 22);
            this.cmdDisplayAll.Text = "Display All";
            this.cmdDisplayAll.Click += new System.EventHandler(this.cmdDisplayAll_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBoard.Location = new System.Drawing.Point(0, 18);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(952, 197);
            this.pnlBoard.TabIndex = 2;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint);
            this.pnlBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBoard_MouseClick);
            // 
            // pnlFretMarkers
            // 
            this.pnlFretMarkers.BackColor = System.Drawing.Color.White;
            this.pnlFretMarkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFretMarkers.Location = new System.Drawing.Point(0, 0);
            this.pnlFretMarkers.Name = "pnlFretMarkers";
            this.pnlFretMarkers.Size = new System.Drawing.Size(952, 18);
            this.pnlFretMarkers.TabIndex = 3;
            this.pnlFretMarkers.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFretMarkers_Paint);
            // 
            // frmFretBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 215);
            this.ContextMenuStrip = this.ContextMenuStrip1;
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.pnlFretMarkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmFretBoard";
            this.Text = "Fret Board";
            this.Activated += new System.EventHandler(this.frmFretBoard_Activated);
            this.Load += new System.EventHandler(this.frmFretBoard_Load);
            this.ResizeBegin += new System.EventHandler(this.frmFretBoard_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmFretBoard_ResizeEnd);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem mnuScales;
        internal System.Windows.Forms.ToolStripMenuItem mnuChords;
        internal System.Windows.Forms.ToolStripMenuItem mnuDisplay;
        internal System.Windows.Forms.ToolStripMenuItem cmdDisplayAll;
        internal System.Windows.Forms.Panel pnlBoard;
        internal System.Windows.Forms.Panel pnlFretMarkers;
    }
}