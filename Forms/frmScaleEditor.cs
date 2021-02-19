using FretMate.Classes;
using System;
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
    public partial class frmScaleEditor : Form
    {
        private List<Scale> m_scales = new List<Scale>();
        private List<Scale> m_boardScales;
        private frmFretBoard m_fretBoard;

        public frmScaleEditor(List<Scale> sc)
        {
            this.InitializeComponent();
            this.lstBoardScales.DisplayMember = "Name";
            m_scales = sc;
            InitListBoxes();
        }

        public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner, List<Scale> sc, frmFretBoard frm)
        {
            m_boardScales = sc;
            m_fretBoard = frm;
            lstBoardScales.Items.Clear();
            foreach (Scale s in m_boardScales)
                lstBoardScales.Items.Add(s);
            return this.ShowDialog(owner);
        }

        private void FillScaleList(string category)
        {
            this.lstScales.Items.Clear();
            foreach (Scale s in m_scales)
            {
                if (s.Category == category | category == "All")
                {
                    this.lstScales.Items.Add(s);
                }
            }
        }

        private void InitListBoxes()
        {
            foreach (Scale sc in m_scales)
            {
                if (!this.lstCategory.Items.Contains(sc.Category))
                {
                    this.lstCategory.Items.Add(sc.Category);
                }
            }

            this.lstScales.DisplayMember = "Name";

            // Me.lstChords.DisplayMember = "ChordName"

        }

        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillScaleList(lstCategory.SelectedItem.ToString());
        }

        private void cmdRemove_Click(object sender, EventArgs e)
        {
            RemoveScale();
        }

        private void RemoveScale()
        {
            if (lstBoardScales.SelectedIndex == -1)
            {
                if (lstBoardScales.Items.Count > 0)
                {
                    lstBoardScales.SelectedIndex = 0;
                }
                else
                {
                    return;
                }
            }

            m_boardScales.Remove((Scale)lstBoardScales.SelectedItem);
            this.lstBoardScales.Items.Remove(lstBoardScales.SelectedItem);
            m_fretBoard.CalculateBoard();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddScale();
        }

        private void AddScale()
        {
            if (this.lstRoot.SelectedIndex == -1)
            {
                this.lstRoot.SelectedIndex = 0;
            }
            // If Me.m_currentForm IsNot Nothing Then
            // Me.m_currentForm.Scales.Clear()
            Scale ss = lstScales.SelectedItem as Scale;
            var s = new Scale();
            s.Intervals.AddRange(ss.Intervals);
            s.OverrideScaleColor = true;
            s.ScaleColor = cmdColor.BackColor;
            if (s is object)
            {
                Notes n;
                Enum.TryParse<Notes>(this.lstRoot.SelectedItem.ToString(), out n);

                s.CalculateNotes(n);
                s.Name = lstRoot.SelectedItem.ToString() + " " + ss.Name;
                m_boardScales.Add(s);
                this.lstBoardScales.Items.Add(s);
                m_fretBoard.CalculateBoard();
            }
        }

        private void lstScales_DoubleClick(object sender, EventArgs e)
        {
            AddScale();
        }

        private void lstBoardScales_DoubleClick(object sender, EventArgs e)
        {
            RemoveScale();
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            if (CD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CD.AnyColor = true;
                cmdColor.BackColor = CD.Color;
            }
        }
    }
}
