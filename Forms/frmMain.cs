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
    public partial class frmMain : Form
    {
        private List<Scale> m_scales = new List<Scale>();
        private List<Scale> m_chords = new List<Scale>();
        private frmScaleEditor m_scaleEditor;
        private frmChordEditor m_chordEditor;
        

        public frmMain()
        {
            InitializeComponent();
        }
        private void LoadScalesAndChords()
        {
            var xDoc = new System.Xml.XmlDocument();
            xDoc.Load("Scales.xml");
            var xmlScales = xDoc.SelectNodes("SCALES/SCALE");
            int i = 0;
            foreach (System.Xml.XmlNode n in xmlScales)
            {
                var scale = new Scale();
                scale.Category = n.SelectSingleNode("CATEGORY").InnerText;
                scale.Name = n.SelectSingleNode("NAME").InnerText;
                var intervals = n.SelectSingleNode("INTERVALS").InnerText.Split(',');
                scale.Intervals.AddRange(intervals);
                scale.BlueNotes.AddRange(n.SelectSingleNode("BLUE_NOTES").InnerText.Split(','));
                scale.ChordColor = Color.LightGreen;
                scale.ID = i;
                i += 1;
                m_scales.Add(scale);
            }

            xmlScales = xDoc.SelectNodes("SCALES/CHORD");
            foreach (System.Xml.XmlNode n in xmlScales)
            {
                var scale = new Scale();
                scale.Name = n.SelectSingleNode("NAME").InnerText;
                var intervals = n.SelectSingleNode("INTERVALS").InnerText.Split(',');
                scale.Intervals.AddRange(intervals);
                scale.ChordColor = Color.Yellow;
                m_chords.Add(scale);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.LoadScalesAndChords();
            //this.InitListBoxes();
            m_scaleEditor = new frmScaleEditor(this.m_scales);
            m_chordEditor = new frmChordEditor(this.m_chords);
            var ff = new frmFretBoard(m_scaleEditor, m_chordEditor);
            ff.MdiParent = this;
            ff.Visible = true;
        }

        private void cmdNew_Click(System.Object sender , System.EventArgs e)
        {
            frmFretBoard ff = new Forms.frmFretBoard(m_scaleEditor, m_chordEditor);
            ff.MdiParent = this;
            ff.Visible = true;
        }


        //private void FillScaleList(string category)
        //{
        //    this.lstScales.Items.Clear();
        //    foreach (Scale s in m_scales)
        //    {
        //        if (s.Category == category | category == "All")
        //        {
        //            this.lstScales.Items.Add(s);
        //        }
        //    }
        //}

        //private void InitListBoxes()
        //{
        //    foreach (Scale sc in m_scales)
        //    {
        //        if (!this.lstCategory.Items.Contains(sc.Category))
        //        {
        //            this.lstCategory.Items.Add(sc.Category);
        //        }
        //    }

        //    this.lstChordType.DataSource = m_chords;
        //    this.lstChordType.DisplayMember = "Name";
        //    this.lstScales.DisplayMember = "Name";
        //    this.lstChords.DisplayMember = "ChordName";
        //}
    }
}
