namespace winforms;

using System.Data;
using System.Windows.Forms;
using MySqlConnector;

public partial class LoginForm : Form
{
    public void ButtonLogin_Click(object sender, EventArgs e)
    {
        String username = textbox_username.Text;
        String pass = textbox_password.Text;

        DB db = new DB();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        MySqlCommand command = new MySqlCommand(
            @"SELECT * FROM `profiles` 
            WHERE `username` = @uN 
            AND `password` = @uP", db.getConnection()
        );
        command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = username;
        command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;

        adapter.SelectCommand = command;
        adapter.Fill(table);

        switch (table.Rows.Count)
        {
            case 0:
                MessageBox.Show("Invalid username or password");
                break;
            case 1:
                MessageBox.Show("You are locked in");
                break;
            default:
                MessageBox.Show("WTF?");
                break;
        }
    }

    public void ButtonSignupRedirect_Click(object sender, EventArgs e)
    {
        SignupForm signupForm = new SignupForm();
        this.Hide();
        signupForm.Show();
        signupForm.FormClosed += (s, args) => this.Show();
    }
    public LoginForm()
    {
        InitializeComponent();
    }
}
