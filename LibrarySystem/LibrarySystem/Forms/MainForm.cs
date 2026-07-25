using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Forms;

namespace LibrarySystem
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		void BtnRegisterBookClick(object sender, EventArgs e)
		{
			this.Hide();
			new RegisterBookForm().ShowDialog();
		}
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		void BtnRegisterUserClick(object sender, EventArgs e)
		{
			this.Hide();
			new RegisterUserForm().ShowDialog();
		}
		void BtnLoanBookClick(object sender, EventArgs e)
		{
			this.Hide();
			new LoanBookForm().ShowDialog();
		}
		void BtnReturnBookClick(object sender, EventArgs e)
		{
			this.Hide();
			new ReturnBookForm().ShowDialog();
		}
		void BtnListBooksClick(object sender, EventArgs e)
		{
			this.Hide();
			new BooksForm().ShowDialog();
		}
	}
}
