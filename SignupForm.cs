namespace winforms;

using System.Data;
using System.Windows.Forms;
using MySqlConnector;

public partial class SignupForm : Form
{
    public void ButtonSignup_Click(object sender, EventArgs e)
    {
        String username = textbox_signup_username.Text;
        String pass = textbox_signup_password.Text;

        DB db = new();

        DataTable table = new();

        MySqlDataAdapter adapter = new();

        MySqlCommand command = new(
            @"INSERT INTO `profiles` (`id`, `username`, `password`)
            VALUES (null, @uN, @uP)", db.getConnection()
        );

        command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = username;
        command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;

        adapter.SelectCommand = command;
        adapter.Fill(table);

        MessageBox.Show("Sigmed up");
        this.Close();
    }
    public SignupForm()
    {
        InitializeComponent();
    }
}
