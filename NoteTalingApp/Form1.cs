using System.Data;
using System.Windows.Forms;
using System.Text.Json;

namespace NoteTalingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        private const string SaveFile = "savedNotes.json"; // JSON file to save notes
        public NoteTaker()
        {
            InitializeComponent();
            //LoadNotes(); // Load notes on startup
        }
        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Notes");

            PreviousNote.DataSource = notes;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void NewNoteBtn_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NoteBox.Text = "";
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[PreviousNote.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("Not a valid note"); }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[PreviousNote.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[PreviousNote.CurrentCell.RowIndex]["Note"] = NoteBox.Text;
            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NoteBox.Text);
            }

            TitleBox.Text = "";
            NoteBox.Text = "";
            editing = false;
        }

        private void PreviousNote_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[PreviousNote.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
