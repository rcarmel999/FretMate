using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FretMate.Classes;

namespace FretMate.Forms
{
    

    public partial class frmDisplaySettings : Form
    {
        private List<Scale> m_chords = new List<Scale>();
        private List<Scale> m_boardChords;
        private frmFretBoard m_fretBoard;

        public frmDisplaySettings()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.DialogResult ShowDialog(IWin32Window owner, List<Scale> chrds, frmFretBoard frm)
        {
            m_boardChords = chrds;
            m_fretBoard = frm;

            return this.ShowDialog(owner);
        }

        private void frmDisplaySettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_fretBoard.StartFret = int.Parse(this.txtStartFret.Text);
            m_fretBoard.EndFret = int.Parse(this.txtEndFret.Text);


        }
    }
}
