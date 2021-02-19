using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FretMate.Classes
{

    public class FretBoard
    {

        public Fret[][] Board { get; set; } = new Fret[6][];

        private Notes[] m_strings = new Notes[6];

        public FretBoard()
        {
            m_strings[0] = Notes.E;
            m_strings[1] = Notes.B;
            m_strings[2] = Notes.G;
            m_strings[3] = Notes.D;
            m_strings[4] = Notes.A;
            m_strings[5] = Notes.E;

            for (int i = 0; i <= 5; i++)
                Board[i] = new Fret[] { new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret(), new Fret() };
        }
        public void CalculateScales(List<Scale> scales, List<Scale> chords, bool bDisplayAll)
        {
            for (int i = 0; i <= 5; i++)
            {
                var note = m_strings[i];
                for (int j = 0; j <= 22; j++)
                {
                    Fret f = new Fret();

                    f = this.Board[i][j];

                    f.Visible = false;
                    f.Color = Color.Transparent;

                    if (bDisplayAll)
                        f.Visible = true;

                    foreach (Scale sc in scales)
                    {
                        ScaleNote scn = sc.GetScaleNote(f.Note);
                        if (scn != null)
                        {
                            if (sc.OverrideScaleColor)
                                f.Color = sc.ScaleColor;
                            else
                                f.Color = scn.Color;
                            f.IntervalLabel = "";
                            f.Visible = true;
                            break;
                        }
                    }

                    foreach (Scale ch in chords)
                    {
                        ScaleNote scn = ch.GetScaleNote(f.Note);
                        if (scn != null)
                        {
                            if (scn.NoteType == NoteType.ROOT)
                                f.Color = ch.ChordRootColor;
                            else if (scn.NoteType == NoteType.THIRD)
                                f.Color = ch.Chord3rdColor;
                            else if (scn.NoteType == NoteType.FIFTH)
                                f.Color = ch.Chord5thColor;
                            else if (scn.NoteType == NoteType.SEVENTH)
                                f.Color = ch.Chord7thColor;
                            else if (scn.NoteType == NoteType.NINTH)
                                f.Color = ch.Chord9thColor;
                            else if (scn.NoteType == NoteType.THIRTEENTH)
                                f.Color = ch.Chord13thColor;
                            else
                                f.Color = scn.Color;

                            f.IntervalLabel = scn.IntervalName;

                            f.Visible = true;
                        }
                    }
                }
            }
        }

        public void CalculateBoard()
        {
            for (int i = 0; i <= 5; i++)
            {
                var note = m_strings[i];
                for (int j = 0; j <= 22; j++)
                {
                    Fret f = new Fret();
                    f.Note = note;
                    f.Color = Color.Black;
                    this.Board[i][j] = f;

                    note += 1;
                    if ((int)note % 12 == 0)
                        note = 0;
                }
            }
        }

        
    }



    public class Fret
    {
        public Notes Note { get; set; }
        public System.Drawing.Color Color { get; set; }
        public bool Visible { get; set; }

        public string IntervalLabel { get; set; }

    }



    public enum Notes
    {
        C, Db, D, Eb, E, F, Gb, G, Ab, A, Bb, B
    }

    public enum NoteType
    {
        SCALE,
        ROOT,
        BLUE,
        THIRD,
        FIFTH,
        SEVENTH,
        NINTH,
        THIRTEENTH
    }

    public class ScaleNote
    {
        public Notes Note { get; set; }
        public NoteType NoteType { get; set; }
        public System.Drawing.Color Color { get; set; }
        public string IntervalName { get; set; }

        public ScaleNote(Notes n, NoteType type, string intervalName)
        {
            this.Note = n;
            this.NoteType = type;
            this.IntervalName = intervalName;

            switch (type)
            {
                case NoteType.BLUE:
                    this.Color = System.Drawing.Color.LightBlue;
                    break;
                case NoteType.ROOT:
                    this.Color = System.Drawing.Color.LightPink;
                    break;
                case NoteType.SCALE:
                    this.Color = System.Drawing.Color.LightGreen;
                    break;
                case NoteType.THIRD:
                case NoteType.FIFTH:
                case NoteType.SEVENTH:
                    this.Color = System.Drawing.Color.Yellow;
                    break;

            }
        }

    }

    


    public class Scale
    {
        public List<ScaleNote> ScaleNotes = new List<ScaleNote>();
        public List<string> Intervals = new List<string>();
        public string ScaleName;
        public List<string> BlueNotes = new List<string>();
        private Hashtable m_intervals = new Hashtable();
        private string m_category;
        private int m_scaleID;
        private string m_chordName;

        public System.Drawing.Color ChordColor;
        public System.Drawing.Color ChordRootColor;
        public System.Drawing.Color Chord3rdColor;
        public System.Drawing.Color Chord5thColor;
        public System.Drawing.Color Chord7thColor;
        public System.Drawing.Color Chord9thColor;
        public System.Drawing.Color Chord13thColor;
        public System.Drawing.Color ScaleColor;
        public bool OverrideScaleColor = false;


        public string ChordName
        {
            get
            {
                return this.m_chordName;
            }
            set
            {
                this.m_chordName = value;
            }
        }

        public int ID
        {
            get
            {
                return this.m_scaleID;
            }
            set
            {
                this.m_scaleID = value;
            }
        }
        public string Name
        {
            get
            {
                return ScaleName;
            }
            set
            {
                ScaleName = value;
            }
        }

        public string Category
        {
            get
            {
                return this.m_category;
            }
            set
            {
                this.m_category = value;
            }
        }

        public Scale()
        {
            // Convert interval to semitones
            m_intervals["1"] = 0; // C
            m_intervals["2b"] = 1;
            m_intervals["2"] = 2; // D
            m_intervals["3b"] = 3;
            m_intervals["3"] = 4; // E
            m_intervals["4"] = 5; // F
            m_intervals["5b"] = 6;
            m_intervals["5"] = 7; // G
            m_intervals["6b"] = 8;
            m_intervals["6"] = 9; // A
            m_intervals["7b"] = 10;
            m_intervals["7"] = 11; // B

            m_intervals["8"] = 12; // C
            m_intervals["9b"] = 13;
            m_intervals["9"] = 14; // D
            m_intervals["10b"] = 15;
            m_intervals["10"] = 16; // E
            m_intervals["11"] = 17; // F
            m_intervals["12b"] = 18; // 
            m_intervals["12"] = 19; // G
            m_intervals["13b"] = 20;
            m_intervals["13"] = 21; // A
            m_intervals["14b"] = 22;
            m_intervals["14"] = 23; // B
        }

        public void CalculateNotes(Notes rootNote)
        {
            ScaleNotes.Clear();
            ScaleNotes.Add(new ScaleNote(rootNote, NoteType.ROOT, Intervals[0]));


            for (int i = 1; i <= Intervals.Count - 1; i++)
            {
                Notes note = rootNote;
                int interval = (int)m_intervals[Intervals[i]];


                if ((int)note + interval > 11)
                    note = (Notes)((interval + (int)note) % 12);
                else
                    note += interval;

                ScaleNote sNote = null/* TODO Change to default(_) if this is not a reference type */;

                switch (Intervals[i])
                {
                    case "3":
                    case "3b":
                        {
                            sNote = new ScaleNote(note, NoteType.THIRD, Intervals[i]);
                            break;
                        }

                    case "5":
                        {
                            sNote = new ScaleNote(note, NoteType.FIFTH, Intervals[i]);
                            break;
                        }

                    case "7":
                    case "7b":
                        {
                            sNote = new ScaleNote(note, NoteType.SEVENTH, Intervals[i]);
                            break;
                        }

                    case "13":
                        {
                            sNote = new ScaleNote(note, NoteType.THIRTEENTH, Intervals[i]);
                            break;
                        }

                    case "9":
                        {
                            sNote = new ScaleNote(note, NoteType.NINTH, Intervals[i]);
                            break;
                        }

                    default:
                        {
                            if (this.BlueNotes.Contains(Intervals[i]))
                                sNote = new ScaleNote(note, NoteType.BLUE, Intervals[i]);
                            else
                                sNote = new ScaleNote(note, NoteType.SCALE, Intervals[i]);
                            break;
                        }
                }

                ScaleNotes.Add(sNote);
            }
        }

        public ScaleNote GetScaleNote(Notes value)
        {
            foreach (ScaleNote n in this.ScaleNotes)
            {
                if (n.Note == value)
                    return n;
            }

            return null/* TODO Change to default(_) if this is not a reference type */;
        }

        public ArrayList GetChords()
        {
            ArrayList a = new ArrayList();



            for (int j = 0; j <= this.ScaleNotes.Count - 1; j++)
            {
                Notes note = this.ScaleNotes[j].Note;
                string chordName = note.ToString();
                string flatFive = string.Empty;


                for (int i = 3 + j; i <= 13 + j; i += 2)
                {
                    int iNote = 0;
                    iNote = (i - 1) % this.ScaleNotes.Count;

                    Notes nextNote = this.ScaleNotes[iNote].Note;

                    int interval = 0;
                    if (nextNote > note)
                        interval = nextNote - note;
                    else if (nextNote < note)
                        interval = nextNote - note + 12;


                    switch (i - j)
                    {
                        case 3:
                            {
                                if (interval == 3)
                                    chordName += "Min";
                                break;
                            }

                        case 5:
                            {
                                switch (interval)
                                {
                                    case 6:
                                        {
                                            flatFive = "b5";
                                            break;
                                        }

                                    case 8:
                                        {
                                            flatFive = "#5";
                                            break;
                                        }
                                }

                                break;
                            }

                        case 7:
                            {
                                switch (interval)
                                {
                                    case 10:
                                        {
                                            chordName += "7";
                                            break;
                                        }

                                    case 9:
                                        {
                                            chordName += "Min7";
                                            break;
                                        }

                                    case 11:
                                        {
                                            chordName += "Maj7";
                                            break;
                                        }
                                }

                                chordName += flatFive;
                                break;
                            }

                        case 9:
                            {
                                switch (interval)
                                {
                                    case 3 // 15
                                   :
                                        {
                                            chordName += "#9";
                                            break;
                                        }

                                    case 1 // 13
                             :
                                        {
                                            chordName += "b9";
                                            break;
                                        }
                                }

                                break;
                            }

                        case 11:
                            {
                                switch (interval)
                                {
                                    case 6 // 18
                                   :
                                        {
                                            chordName += "#11";
                                            break;
                                        }

                                    case 4 // 16
                             :
                                        {
                                            chordName += "b11";
                                            break;
                                        }
                                }

                                break;
                            }

                        case 13:
                            {
                                switch (interval)
                                {
                                    case 8 // 20
                                   :
                                        {
                                            chordName += "b13";
                                            break;
                                        }

                                    case 10 // 22
                             :
                                        {
                                            chordName += "#13";
                                            break;
                                        }
                                }

                                break;
                            }
                    }
                }
                a.Add(chordName);
            }


            return a;
        }
    }


}
