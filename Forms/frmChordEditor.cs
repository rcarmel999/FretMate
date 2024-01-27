using FretMate.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FretMate.Forms
{
    public partial class frmChordEditor : Form
    {
        private List<Scale> m_chords = new List<Scale>();
        private List<Scale> m_boardChords;
        private frmFretBoard m_fretBoard;

        public frmChordEditor(List<Scale> sc)
        {
            this.InitializeComponent();
            m_chords = sc;
            this.lstChords.DisplayMember = "ChordName";
            this.lstChordType.DataSource = m_chords;
            this.lstChordType.DisplayMember = "Name";



            // InitListBoxes()

        }

        public  System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner, List<Scale> chrds, frmFretBoard frm)
        {
            m_boardChords = chrds;
            m_fretBoard = frm;
            lstChords.Items.Clear();
            foreach (Scale s in m_boardChords)
                lstChords.Items.Add(s);
            
            return this.ShowDialog(owner);
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            RemoveChord();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddChord();
        }

        private void RemoveChord()
        {
            var a = new ArrayList();
            foreach (Scale item in this.lstChords.SelectedItems)
                a.Add(item);
            foreach (Scale item in a)
            {
                if (m_boardChords.Contains(item))
                {
                    m_boardChords.Remove(item);
                }

                this.lstChords.Items.Remove(item);
            }

            m_fretBoard.CalculateBoard();
        }

        private void AddChord()
        {
            if (this.lstChordRoot.SelectedIndex == -1)
            {
                this.lstChordRoot.SelectedIndex = 0;
            }

            foreach (Scale item in this.lstChordType.SelectedItems)
            {
                var newScale = new Scale();
                newScale.Intervals = item.Intervals;
                newScale.ChordName = this.lstChordRoot.SelectedItem + " " + item.ScaleName;
                //newScale.CalculateNotes(Enum.Parse(typeof(Notes), this.lstChordRoot.SelectedItem.ToString()));

                Notes n;
                Enum.TryParse<Notes>(this.lstChordRoot.SelectedItem.ToString(), out n);
                newScale.CalculateNotes(n);

                newScale.ChordColor = Color.Yellow;
                newScale.ChordRootColor = cmdRoot.BackColor;
                newScale.Chord3rdColor = cmd3rd.BackColor;
                newScale.Chord5thColor = cmd5th.BackColor;
                newScale.Chord7thColor = cmd7th.BackColor;
                newScale.Chord9thColor = cmd9th.BackColor;
                newScale.Chord13thColor = cmd13th.BackColor;
                m_boardChords.Add(newScale);
                this.lstChords.Items.Add(newScale);
            }

            m_fretBoard.CalculateBoard();
        }

        private void lstChordType_DoubleClick(object sender, EventArgs e)
        {
            AddChord();
        }

        private void lstChords_DoubleClick(object sender, EventArgs e)
        {
            RemoveChord();
        }

        private void cmdRoot_Click(object sender, EventArgs e)
        {
            SetColor(sender);
        }

        private void cmd3rd_Click(object sender, EventArgs e)
        {
            SetColor(sender);
        }

        private void cmd5th_Click(object sender, EventArgs e)
        {
            SetColor(sender);
        }

        private void cmd7th_Click(object sender, EventArgs e)
        {
            SetColor(sender);
        }

        private void SetColor(object sender)
        {
            if (CD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CD.AnyColor = true;
                Button b = sender as Button;
                b.BackColor = CD.Color;
            }
        }

        private void cmd9th_Click(object sender, EventArgs e)
        {
            SetColor(sender);
        }

        private void cmd13th_Click(object sender, EventArgs e)
        {
            SetColor(sender);
        }

        private void cmdSetAllColor_Click(object sender, EventArgs e)
        {
            SetColor(sender);
            var b = sender as Button;
            var c = b.BackColor;
            cmdRoot.BackColor = c;
            cmd3rd.BackColor = c;
            cmd5th.BackColor = c;
            cmd7th.BackColor = c;
            cmd9th.BackColor = c;
            cmd13th.BackColor = c;
        }
    }
}
