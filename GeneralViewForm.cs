namespace winforms;

using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using MySqlConnector;

public partial class GeneralViewForm : Form
{
    private int uID;
    public GeneralViewForm(int uID)
    {
        this.uID = uID;
        InitializeComponent();
        FillGridView();
    }
    public void FillGridView()
    {
        /// idk if i should rewrite the connection initialization, seems that mysql manages that, but it still looks like shit
        DB db = new();

        DataTable table = new();

        MySqlDataAdapter adapter = new();

        MySqlCommand command = new(
            @"SELECT * FROM `game_entries`
            WHERE `user_id` = @uID", db.getConnection()
        );
        command.Parameters.Add("@uID", MySqlDbType.VarChar).Value = this.uID;

        adapter.SelectCommand = command;
        adapter.Fill(table);
        table.Columns.Remove("user_id"); 
        table.Columns.Remove("id");
        this.gamesDataGridView.DataSource = table;
    }

    public void SubmitButtonClick(object sender, EventArgs e)
    {
        DB db = new();
        DateTime parsedDT = DateTime.ParseExact(this.dateTextBox.Text, "MM/dd/yyyy", null);

        MySqlCommand command = new( 
            @"INSERT INTO `game_entries` (`win`, `hero`, `date`, `note`, `user_id`) 
            VALUES (@win, @hero, @date, @note, @uID)", db.getConnection());

        command.Parameters.Add("@win", MySqlDbType.Bool).Value = this.winCheckBox.Checked;
        command.Parameters.Add("@hero", MySqlDbType.VarChar).Value = this.Controls["heroTextBox"]!.Text;
        command.Parameters.Add("@date", MySqlDbType.Date).Value = parsedDT;
        command.Parameters.Add("@note", MySqlDbType.VarChar).Value = this.Controls["noteTextBox"]!.Text;
        command.Parameters.Add("@uID", MySqlDbType.VarChar).Value = this.uID;
        db.getConnection().Open();
        command.ExecuteNonQuery();
        FillGridView();
    }
}