namespace winforms;

using System.Data;
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
}