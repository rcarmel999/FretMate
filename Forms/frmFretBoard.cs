using FretMate.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FretMate.Forms
{
    public partial class frmFretBoard : Form
    {
        System.Drawing.Image m_img = null;
        public frmFretBoard(frmScaleEditor frmSE, frmChordEditor frmCE)
        {
            //this.Activated += frmFretBoard_Activated;
            //base.Load += Form3_Load;
            //this.ResizeEnd += frmFretBoard_ResizeEnd;

            // This call is required by the designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
            m_scaleEditor = frmSE;
            m_chordEditor = frmCE;

            m_img = System.Drawing.Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\wood_2.jpg"));
        }

        private FretBoard m_board = new FretBoard();
        private List<Scale> m_scales = new List<Scale>();
        private List<Scale> m_chords = new List<Scale>();
        private frmScaleEditor m_scaleEditor;
        private frmChordEditor m_chordEditor;
        private bool m_bDisplayAll = false;
        private int m_startFret = 0;

        public int StartFret
        {
            get
            {
                return m_startFret;
            }

            set
            {
                m_startFret = value;
            }
        }

        private int m_endFret = 22;

        public int EndFret
        {
            get
            {
                return m_endFret;
            }

            set
            {
                m_endFret = value;
            }
        }

        public void CalculateBoard()
        {
            m_board.CalculateScales(m_scales, m_chords, m_bDisplayAll);
            this.pnlBoard.Invalidate();
        }

        private void pnlFretMarkers_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            int x = 0;
            //int y = 0;
            x = this.pnlBoard.Width / 23;
            for (int j = 0; j <= 22; j++)
            {
                // e.Graphics.DrawString(j +1, Me.pnlBoard.Font, Brushes.Black, x, 0)

                SizeF size = e.Graphics.MeasureString(j.ToString(), this.pnlBoard.Font);
                int l = (int)size.Width / 2;
                var fheight = size.Height / 2;
                e.Graphics.DrawString(j.ToString(), this.pnlBoard.Font, Brushes.Black, x - this.pnlBoard.Width / 23 / 2 - l, 0); // y - fheight)
                x += this.pnlBoard.Width / 23;
            }
        }

        private void pnlBoard_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int x = pnlBoard.Width / 23;
            int y = pnlBoard.Height / 6;
            int xPos;
            int yPos;

            xPos = e.X / x;
            yPos = e.Y / y;

            //    xPos = Conversions.ToInteger(e.X / x);
            //  yPos = Conversions.ToInteger(e.Y / y);



            // Me.Text = e.X & ", " & yPos
            Fret f = m_board.Board[yPos][xPos];
            f.Color = Color.Blue;
            pnlBoard.Invalidate();


            // For Each sc As Scale In Scales
            // Dim scn As ScaleNote = sc.GetScaleNote(f.Note)
            // If scn IsNot Nothing Then

            // End If

            // Next


            // Me.m_board.CalculateBoard()


        }

        private void pnlBoard_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            const int NUM_FRETS = 23;
            const int NUM_STRINGS = 6;
                        
            var p = new Point(0, 0);
            e.Graphics.DrawImage(m_img, 0, 0, this.pnlBoard.Width, this.pnlBoard.Height);


            int x = 0;
            int y = 0;

            // Draw Frets
            var pp = new Pen(Color.Gray);
            x = this.pnlBoard.Width / NUM_FRETS;
            for (int j = 0; j < NUM_FRETS; j++)
            {
                pp.Color = Color.Gray;
                pp.Width = 2;
                e.Graphics.DrawLine(pp, x, 0, x, this.pnlBoard.Height);
                pp.Width = 1;
                pp.Color = Color.White;
                e.Graphics.DrawLine(pp, x, 0, x, this.pnlBoard.Height);
                x += this.pnlBoard.Width / NUM_FRETS;
            }


            // Draw horozontal lines
            pp.Color = Color.LightGray;
            pp.Width = 2;
            y = this.pnlBoard.Height / 6 / 2;
            x = this.pnlBoard.Width / NUM_FRETS;
            for (int i = 0; i < NUM_STRINGS; i++)
            {
                e.Graphics.DrawLine(pp, x, y, this.pnlBoard.Width, y);
                y += this.pnlBoard.Height / NUM_STRINGS;
            }

            pp.Dispose();
            y = 0;
            System.Drawing.Font fnt = this.pnlBoard.Font;
            System.Drawing.Font intFnt = new Font(this.pnlBoard.Font.FontFamily, 8, FontStyle.Italic);




            // Draw notes
            y = this.pnlBoard.Height / NUM_STRINGS / 2;
            for (int i = 0; i < NUM_STRINGS; i++)
            {
                x = this.pnlBoard.Width / NUM_FRETS;
                for (int j = 0; j < NUM_FRETS; j++)
                {
                    Fret f = m_board.Board[i][j];
                    if (f.Visible & j >= m_startFret & j <= m_endFret)
                    {
                        string value = f.Note.ToString();
                        SizeF size = e.Graphics.MeasureString(value, fnt);
                        int l = (int)size.Width / 2;
                        var fheight = size.Height / 2;
                        var b = new SolidBrush(f.Color);
                        e.Graphics.FillEllipse(b, new Rectangle(x - this.pnlBoard.Width / NUM_FRETS / 2 - 12, y - 12, 24, 24));
                        if (f.Color != Color.Transparent)
                        {
                            e.Graphics.DrawEllipse(Pens.Black, new Rectangle(x - this.pnlBoard.Width / NUM_FRETS / 2 - 12, y - 12, 24, 24));
                        }

                        e.Graphics.DrawString(f.Note.ToString(), fnt, Brushes.Black, x - this.pnlBoard.Width / NUM_FRETS / 2 - l, y - fheight);
                        if (f.IntervalLabel != string.Empty)
                        {
                            SizeF tsize = e.Graphics.MeasureString(f.IntervalLabel, intFnt);
                            int xt = x - this.pnlBoard.Width / NUM_FRETS / 2 - 12;
                            xt = xt - (int)tsize.Width + 1;
                            int yt = y - (int)fheight;
                            yt = yt - (int)tsize.Height / 2;
                            e.Graphics.DrawString(f.IntervalLabel, intFnt, Brushes.Black, xt, yt);
                        }

                        b.Dispose();
                    }

                    x += this.pnlBoard.Width / NUM_FRETS;
                }

                y += this.pnlBoard.Height / NUM_STRINGS;
            }

            intFnt.Dispose();
        }

        private void frmFretBoard_Activated(object sender, EventArgs e)
        {
            //((frmMain)this.MdiParent).SelectForm(this);
        }

        private void frmFretBoard_Load(object sender, EventArgs e)
        {
            m_board.CalculateBoard();
            //int i = 0;
            this.Text = "Fretboard ";
        }
        private void frmFretBoard_ResizeBegin(object sender, EventArgs e)
        {
            this.SuspendLayout();
            pnlBoard.SuspendLayout();
        }
        private void frmFretBoard_ResizeEnd(object sender, EventArgs e)
        {
            this.pnlBoard.Invalidate();
            this.pnlBoard.ResumeLayout();
            this.pnlFretMarkers.Invalidate();

            this.ResumeLayout();

        }




        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        public List<Scale> Scales
        {
            get
            {
                return m_scales;
            }
        }

        public List<Scale> Chords
        {
            get
            {
                return m_chords;
            }
        }

        public bool DisplayAll
        {
            get
            {
                return m_bDisplayAll;
            }

            set
            {
                m_bDisplayAll = value;
                CalculateBoard();
            }
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */

        private void mnuScales_Click(object sender, EventArgs e)
        {
            m_scaleEditor.ShowDialog(Owner, m_scales, this);
        }

        private void mnuDisplay_Click(object sender, EventArgs e)
        {
            var f = new frmDisplaySettings();
            f.txtStartFret.Text = StartFret.ToString();
            f.txtEndFret.Text = EndFret.ToString();
            f.ShowDialog(this, m_chords, this);

        }

        private void mnuChords_Click(object sender, EventArgs e)
        {
            m_chordEditor.ShowDialog(Owner, m_chords, this);
        }

        private void cmdDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayAll = !DisplayAll;
        }

       
    }

}
