using System;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Data;
using LibrarySystem.Models;
using System.Linq;

namespace LibrarySystem.Forms
{

	public partial class LoanBookForm : Form
	{
		public LoanBookForm()
		{

			InitializeComponent();
			
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Hide();
			new MainForm().ShowDialog();
		}
		void LoanBookFormLoad(object sender, EventArgs e)
		{
			
			dtpReturnDate.Value = DateTime.Now.AddDays(14);
            cmbBooks.DataSource = DataContext.Books.Where(b => !b.IsBorrowed).ToList();
            
            // insere os usuarios no combobox
            cmbUsers.DataSource = DataContext.Users.ToList();
		}
		void BtnLoanClick(object sender, EventArgs e)
		{
            var selectedBook = cmbBooks.SelectedItem as Book;
            var selectedUser = cmbUsers.SelectedItem as User;

            if (selectedBook == null || selectedUser == null)
            {
                MessageBox.Show("Selecione um livro e um usuário válidos.", "Atenção");
                return;
            }

            // cria o empréstimo
            var loan = new Loan(DataContext.GetNextLoanId(), selectedBook, selectedUser, 14);

            // salva na lista
            DataContext.Loans.Add(loan);

            MessageBox.Show(string.Format("The book '{0}' was sucessfully loaned to {1}!\nReturn by: {2:dd/MM/yyyy}", 
    						selectedBook.Title, selectedUser.Name, loan.LoanDateDue), 
    						"Sucesso");

            this.Hide();
            new MainForm().ShowDialog();
		}
		void LoanBookFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
