using System;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Data;
using LibrarySystem.Models;

namespace LibrarySystem.Forms
{

	public partial class RegisterUserForm : Form
	{
		public RegisterUserForm()
		{

			InitializeComponent();
			
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Hide();
			new MainForm().ShowDialog();
		}
		void BtnRegisterClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all the data.", "Attention");
                return;
            }

            User user = new User
            {
                Id = DataContext.GetNextUserId(),
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            DataContext.Users.Add(user);
            MessageBox.Show("User successfully registered!", "Success");
            this.Hide();
            new MainForm().ShowDialog();
		}
		void RegisterUserFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
