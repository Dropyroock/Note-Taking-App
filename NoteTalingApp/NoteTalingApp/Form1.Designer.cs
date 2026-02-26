namespace NoteTalingApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleBox = new TextBox();
            NoteBox = new TextBox();
            label1 = new Label();
            NoteLabel = new Label();
            PreviousNote = new DataGridView();
            LoadBtn = new Button();
            DeleteBTN = new Button();
            SaveBtn = new Button();
            NewNoteBtn = new Button();
            TitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PreviousNote).BeginInit();
            SuspendLayout();
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(387, 40);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(401, 23);
            TitleBox.TabIndex = 0;
            // 
            // NoteBox
            // 
            NoteBox.Location = new Point(387, 104);
            NoteBox.Multiline = true;
            NoteBox.Name = "NoteBox";
            NoteBox.Size = new Size(401, 342);
            NoteBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            // 
            // NoteLabel
            // 
            NoteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoteLabel.Location = new Point(387, 78);
            NoteLabel.Name = "NoteLabel";
            NoteLabel.Size = new Size(401, 23);
            NoteLabel.TabIndex = 3;
            NoteLabel.Text = "Note:";
            NoteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PreviousNote
            // 
            PreviousNote.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PreviousNote.BackgroundColor = Color.White;
            PreviousNote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PreviousNote.Location = new Point(12, 14);
            PreviousNote.Name = "PreviousNote";
            PreviousNote.Size = new Size(347, 336);
            PreviousNote.TabIndex = 4;
            PreviousNote.CellContentDoubleClick += PreviousNote_CellContentDoubleClick;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.White;
            LoadBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadBtn.Location = new Point(30, 366);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(155, 37);
            LoadBtn.TabIndex = 5;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.BackColor = Color.White;
            DeleteBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBTN.Location = new Point(191, 366);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(155, 37);
            DeleteBTN.TabIndex = 6;
            DeleteBTN.Text = "Delete";
            DeleteBTN.UseVisualStyleBackColor = false;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.White;
            SaveBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(191, 409);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(155, 37);
            SaveBtn.TabIndex = 7;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // NewNoteBtn
            // 
            NewNoteBtn.BackColor = Color.White;
            NewNoteBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewNoteBtn.Location = new Point(30, 409);
            NewNoteBtn.Name = "NewNoteBtn";
            NewNoteBtn.Size = new Size(155, 37);
            NewNoteBtn.TabIndex = 8;
            NewNoteBtn.Text = "New Note";
            NewNoteBtn.UseVisualStyleBackColor = false;
            NewNoteBtn.Click += NewNoteBtn_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(387, 14);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(401, 23);
            TitleLabel.TabIndex = 10;
            TitleLabel.Text = "Title:";
            TitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(TitleLabel);
            Controls.Add(NewNoteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(DeleteBTN);
            Controls.Add(LoadBtn);
            Controls.Add(PreviousNote);
            Controls.Add(NoteLabel);
            Controls.Add(label1);
            Controls.Add(NoteBox);
            Controls.Add(TitleBox);
            Name = "NoteTaker";
            Text = "Note Taker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)PreviousNote).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TitleBox;
        private TextBox NoteBox;
        private Label label1;
        private Label NoteLabel;
        private DataGridView PreviousNote;
        private Button LoadBtn;
        private Button DeleteBTN;
        private Button SaveBtn;
        private Button NewNoteBtn;
        private Label TitleLabel;
    }
}
