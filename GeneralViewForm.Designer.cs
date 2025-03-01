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
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.Text = "Game data";
        
        this.Controls.Add(gamesDataGridView);
        this.gamesDataGridView.Location = new Point(50,50);
        this.gamesDataGridView.Size = new System.Drawing.Size(500,400);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.AcceptButton = null;
    }

    #endregion
}
