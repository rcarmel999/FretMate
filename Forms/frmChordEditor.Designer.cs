namespace FretMate.Forms
{
    partial class frmChordEditor
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
            this.Label6 = new System.Windows.Forms.Label();
            this.cmd13th = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.cmd9th = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmd7th = new System.Windows.Forms.Button();
            this.cmd5th = new System.Windows.Forms.Button();
            this.cmdRoot = new System.Windows.Forms.Button();
            this.CD = new System.Windows.Forms.ColorDialog();
            this.cmd3rd = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lstChords = new System.Windows.Forms.ListBox();
            this.lstChordRoot = new System.Windows.Forms.ListBox();
            this.lstChordType = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(170, 126);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 13);
            this.Label6.TabIndex = 51;
            this.Label6.Text = "13th";
            // 
            // cmd13th
            // 
            this.cmd13th.BackColor = System.Drawing.Color.Yellow;
            this.cmd13th.Location = new System.Drawing.Point(199, 126);
            this.cmd13th.Name = "cmd13th";
            this.cmd13th.Size = new System.Drawing.Size(33, 18);
            this.cmd13th.TabIndex = 50;
            this.cmd13th.UseVisualStyleBackColor = false;
            this.cmd13th.Click += new System.EventHandler(this.cmd13th_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(176, 109);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(22, 13);
            this.Label5.TabIndex = 49;
            this.Label5.Text = "9th";
            // 
            // cmd9th
            // 
            this.cmd9th.BackColor = System.Drawing.Color.Yellow;
            this.cmd9th.Location = new System.Drawing.Point(199, 109);
            this.cmd9th.Name = "cmd9th";
            this.cmd9th.Size = new System.Drawing.Size(33, 18);
            this.cmd9th.TabIndex = 48;
            this.cmd9th.UseVisualStyleBackColor = false;
            this.cmd9th.Click += new System.EventHandler(this.cmd9th_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(176, 93);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(22, 13);
            this.Label4.TabIndex = 47;
            this.Label4.Text = "7th";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(176, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(22, 13);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "5th";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(176, 59);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(22, 13);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "3rd";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(179, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(15, 13);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "R";
            // 
            // cmd7th
            // 
            this.cmd7th.BackColor = System.Drawing.Color.Yellow;
            this.cmd7th.Location = new System.Drawing.Point(199, 93);
            this.cmd7th.Name = "cmd7th";
            this.cmd7th.Size = new System.Drawing.Size(33, 18);
            this.cmd7th.TabIndex = 43;
            this.cmd7th.UseVisualStyleBackColor = false;
            this.cmd7th.Click += new System.EventHandler(this.cmd7th_Click);
            // 
            // cmd5th
            // 
            this.cmd5th.BackColor = System.Drawing.Color.Yellow;
            this.cmd5th.Location = new System.Drawing.Point(199, 76);
            this.cmd5th.Name = "cmd5th";
            this.cmd5th.Size = new System.Drawing.Size(33, 18);
            this.cmd5th.TabIndex = 42;
            this.cmd5th.UseVisualStyleBackColor = false;
            this.cmd5th.Click += new System.EventHandler(this.cmd5th_Click);
            // 
            // cmdRoot
            // 
            this.cmdRoot.BackColor = System.Drawing.Color.Yellow;
            this.cmdRoot.Location = new System.Drawing.Point(199, 42);
            this.cmdRoot.Name = "cmdRoot";
            this.cmdRoot.Size = new System.Drawing.Size(33, 18);
            this.cmdRoot.TabIndex = 40;
            this.cmdRoot.UseVisualStyleBackColor = false;
            this.cmdRoot.Click += new System.EventHandler(this.cmdRoot_Click);
            // 
            // cmd3rd
            // 
            this.cmd3rd.BackColor = System.Drawing.Color.Yellow;
            this.cmd3rd.Location = new System.Drawing.Point(199, 59);
            this.cmd3rd.Name = "cmd3rd";
            this.cmd3rd.Size = new System.Drawing.Size(33, 18);
            this.cmd3rd.TabIndex = 41;
            this.cmd3rd.UseVisualStyleBackColor = false;
            this.cmd3rd.Click += new System.EventHandler(this.cmd3rd_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(190, 148);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(42, 23);
            this.cmdRemove.TabIndex = 39;
            this.cmdRemove.Text = "<";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(190, 13);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(42, 23);
            this.cmdAdd.TabIndex = 38;
            this.cmdAdd.Text = ">";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lstChords
            // 
            this.lstChords.FormattingEnabled = true;
            this.lstChords.Location = new System.Drawing.Point(238, 12);
            this.lstChords.Name = "lstChords";
            this.lstChords.Size = new System.Drawing.Size(166, 160);
            this.lstChords.TabIndex = 37;
            this.lstChords.DoubleClick += new System.EventHandler(this.lstChords_DoubleClick);
            // 
            // lstChordRoot
            // 
            this.lstChordRoot.FormattingEnabled = true;
            this.lstChordRoot.Items.AddRange(new object[] {
            "C",
            "Db",
            "D",
            "Eb",
            "E",
            "F",
            "Gb",
            "G",
            "Ab",
            "A",
            "B",
            "Bb"});
            this.lstChordRoot.Location = new System.Drawing.Point(4, 13);
            this.lstChordRoot.Name = "lstChordRoot";
            this.lstChordRoot.Size = new System.Drawing.Size(50, 160);
            this.lstChordRoot.TabIndex = 36;
            // 
            // lstChordType
            // 
            this.lstChordType.FormattingEnabled = true;
            this.lstChordType.Location = new System.Drawing.Point(60, 12);
            this.lstChordType.Name = "lstChordType";
            this.lstChordType.Size = new System.Drawing.Size(109, 160);
            this.lstChordType.TabIndex = 35;
            this.lstChordType.DoubleClick += new System.EventHandler(this.lstChordType_DoubleClick);
            // 
            // frmChordEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 177);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cmd13th);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.cmd9th);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmd7th);
            this.Controls.Add(this.cmd5th);
            this.Controls.Add(this.cmdRoot);
            this.Controls.Add(this.cmd3rd);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lstChords);
            this.Controls.Add(this.lstChordRoot);
            this.Controls.Add(this.lstChordType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChordEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chord Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button cmd13th;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button cmd9th;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button cmd7th;
        internal System.Windows.Forms.Button cmd5th;
        internal System.Windows.Forms.Button cmdRoot;
        internal System.Windows.Forms.ColorDialog CD;
        internal System.Windows.Forms.Button cmd3rd;
        internal System.Windows.Forms.Button cmdRemove;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.ListBox lstChords;
        internal System.Windows.Forms.ListBox lstChordRoot;
        internal System.Windows.Forms.ListBox lstChordType;
    }
}