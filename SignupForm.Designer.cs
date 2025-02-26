namespace winforms;

partial class SignupForm
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
    private Button button_signup;
    private TextBox textbox_signup_username;
    private TextBox textbox_signup_password;
    private int textbox_width = 200;
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(300,200);
        this.Text = "Sign up";

        this.textbox_signup_username = new System.Windows.Forms.TextBox();
        this.textbox_signup_username.AcceptsReturn = true;
        this.textbox_signup_username.AcceptsTab = true;
        this.textbox_signup_username.Dock = System.Windows.Forms.DockStyle.None;
        this.Controls.Add(this.textbox_signup_username);
        this.textbox_signup_username.Location = new Point(50,50);
        this.textbox_signup_username.Width = textbox_width;
        
        this.textbox_signup_password = new System.Windows.Forms.TextBox();
        this.textbox_signup_password.AcceptsReturn = true;
        this.textbox_signup_password.AcceptsTab = true;
        this.textbox_signup_password.Dock = System.Windows.Forms.DockStyle.None;
        this.Controls.Add(this.textbox_signup_password);
        this.textbox_signup_password.Location = new Point(textbox_signup_username.Left,textbox_signup_username.Top + 30);
        this.textbox_signup_password.Width = textbox_width;

        this.button_signup = new System.Windows.Forms.Button();
        this.button_signup.Location = new Point(textbox_signup_password.Left + 70,textbox_signup_password.Top + 30);
        this.button_signup.Width = 60;
        this.button_signup.Text = "Sign up";
        this.Controls.Add(this.button_signup);
        this.button_signup.Click += new System.EventHandler(this.ButtonSignup_Click);

        this.StartPosition = FormStartPosition.CenterScreen;
        this.AcceptButton = button_signup;
    }

    #endregion
}
