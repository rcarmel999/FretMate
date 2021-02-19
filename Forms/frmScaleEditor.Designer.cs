namespace FretMate.Forms
{
    partial class frmScaleEditor
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
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.lstBoardScales = new System.Windows.Forms.ListBox();
            this.lstScales = new System.Windows.Forms.ListBox();
            this.lstRoot = new System.Windows.Forms.ListBox();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.CD = new System.Windows.Forms.ColorDialog();
            this.cmdColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(359, 96);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(42, 23);
            this.cmdRemove.TabIndex = 26;
            this.cmdRemove.Text = "<";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(359, 55);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(42, 23);
            this.cmdAdd.TabIndex = 25;
            this.cmdAdd.Text = ">";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // lstBoardScales
            // 
            this.lstBoardScales.FormattingEnabled = true;
            this.lstBoardScales.Location = new System.Drawing.Point(407, 10);
            this.lstBoardScales.Name = "lstBoardScales";
            this.lstBoardScales.Size = new System.Drawing.Size(166, 160);
            this.lstBoardScales.TabIndex = 24;
            this.lstBoardScales.DoubleClick += new System.EventHandler(this.lstBoardScales_DoubleClick);
            // 
            // lstScales
            // 
            this.lstScales.FormattingEnabled = true;
            this.lstScales.Location = new System.Drawing.Point(187, 10);
            this.lstScales.Name = "lstScales";
            this.lstScales.Size = new System.Drawing.Size(166, 160);
            this.lstScales.TabIndex = 23;
            this.lstScales.DoubleClick += new System.EventHandler(this.lstScales_DoubleClick);
            // 
            // lstRoot
            // 
            this.lstRoot.FormattingEnabled = true;
            this.lstRoot.Items.AddRange(new object[] {
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
            this.lstRoot.Location = new System.Drawing.Point(10, 10);
            this.lstRoot.Name = "lstRoot";
            this.lstRoot.Size = new System.Drawing.Size(50, 160);
            this.lstRoot.TabIndex = 22;
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.Location = new System.Drawing.Point(63, 10);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(120, 160);
            this.lstCategory.TabIndex = 21;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // cmdColor
            // 
            this.cmdColor.BackColor = System.Drawing.Color.Yellow;
            this.cmdColor.Location = new System.Drawing.Point(363, 10);
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(33, 28);
            this.cmdColor.TabIndex = 27;
            this.cmdColor.UseVisualStyleBackColor = false;
            this.cmdColor.Click += new System.EventHandler(this.cmdColor_Click);
            // 
            // frmScaleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 181);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.lstBoardScales);
            this.Controls.Add(this.lstScales);
            this.Controls.Add(this.lstRoot);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.cmdColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScaleEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmScaleEditor";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdRemove;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.ListBox lstBoardScales;
        internal System.Windows.Forms.ListBox lstScales;
        internal System.Windows.Forms.ListBox lstRoot;
        internal System.Windows.Forms.ListBox lstCategory;
        internal System.Windows.Forms.ColorDialog CD;
        internal System.Windows.Forms.Button cmdColor;
    }
}