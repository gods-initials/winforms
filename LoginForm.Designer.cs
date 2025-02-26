namespace winforms;

partial class LoginForm
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
    private TextBox textbox_username;
    private TextBox textbox_password;
    private int textbox_width = 200;
    private Button button_login;
    private Button button_signup_redirect;
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(300,200);
        this.Text = "Login";

        this.textbox_username = new System.Windows.Forms.TextBox();
        this.textbox_username.AcceptsReturn = true;
        this.textbox_username.AcceptsTab = true;
        this.textbox_username.Dock = System.Windows.Forms.DockStyle.None;
        this.Controls.Add(this.textbox_username);
        this.textbox_username.Location = new Point(50,50);
        this.textbox_username.Width = textbox_width;
        
        this.textbox_password = new System.Windows.Forms.TextBox();
        this.textbox_password.AcceptsReturn = true;
        this.textbox_password.AcceptsTab = true;
        this.textbox_password.Dock = System.Windows.Forms.DockStyle.None;
        this.Controls.Add(this.textbox_password);
        this.textbox_password.Location = new Point(textbox_username.Left,textbox_username.Top + 30);
        this.textbox_password.Width = textbox_width;

        this.button_login = new System.Windows.Forms.Button();
        this.button_login.Location = new Point(textbox_password.Left + 70,textbox_password.Top + 30);
        this.button_login.Width = 60;
        this.Controls.Add(this.button_login);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.button_login.Text = "Sign in";
        this.button_login.Click += new System.EventHandler(this.ButtonLogin_Click);

        this.button_signup_redirect = new System.Windows.Forms.Button();
        this.button_signup_redirect.Location = new Point(textbox_password.Left + 70,button_login.Top + 30);
        this.button_signup_redirect.Width = 60;
        this.Controls.Add(this.button_signup_redirect);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.button_signup_redirect.Text = "Sign up";
        this.button_signup_redirect.Click += new System.EventHandler(this.ButtonSignupRedirect_Click);

        this.AcceptButton = button_login;
    }

    #endregion
}
