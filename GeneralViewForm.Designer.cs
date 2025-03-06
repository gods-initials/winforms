namespace winforms;

partial class GeneralViewForm
{
    private System.ComponentModel.IContainer components = null;
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
    private DataGridView gamesDataGridView = new DataGridView();
    private CheckBox outcomeCheckBox = new();
    private TextBox[] textBoxes = new TextBox[2];
    private MaskedTextBox dateTextBox = new();
    private CheckBox winCheckBox = new();
    private Button submitEntryButton = new();
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.Text = "Game data";
        
        this.Controls.Add(gamesDataGridView);
        this.gamesDataGridView.Location = new Point(50,50);
        this.gamesDataGridView.Size = new Size(500,400);

        this.winCheckBox.Location = new Point(50,500);
        this.winCheckBox.Size = new Size(25,25);
        this.Controls.Add(winCheckBox);

        for (int i = 0; i < textBoxes.Length; i++)
        {
            textBoxes[i] = new TextBox();
            textBoxes[i].Location = new Point(100 + i * 400, 500);
            textBoxes[i].Size = new System.Drawing.Size(180, 25);
            this.Controls.Add(textBoxes[i]);
        }
        textBoxes[0].Name = "heroTextBox";
        textBoxes[1].Name = "noteTextBox";

        this.dateTextBox.Location = new Point(300, 500);
        this.dateTextBox.Size = new System.Drawing.Size(180, 25);
        this.dateTextBox.Mask = "00/00/0000";
        this.Controls.Add(dateTextBox);

        this.submitEntryButton.Location = new Point(50,525);
        this.submitEntryButton.Size = new Size(100,25);
        this.submitEntryButton.Text = "Submit";
        this.Controls.Add(submitEntryButton);
        this.submitEntryButton.Click += new EventHandler(this.SubmitButtonClick);

        this.StartPosition = FormStartPosition.CenterScreen;
        this.AcceptButton = this.submitEntryButton;
    }
    #endregion
}