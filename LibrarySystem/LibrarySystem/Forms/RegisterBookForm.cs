using System;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Data;
using LibrarySystem.Models;

namespace LibrarySystem.Forms
{

	public partial class RegisterBookForm : Form
	{
		public RegisterBookForm()
		{

			InitializeComponent();

		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Hide();
			new MainForm().ShowDialog();
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			// 1. Validação simples
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please inform the title and the author.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Criando o objeto com as regras
            var newBook = new Book
            {
                Id = DataContext.GetNextBookId(),
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                ISBN = txtISBN.Text,
                Genre = txtGenre.Text,
                PublicationYear = int.Parse(txtPublicationYear.Text)
            };

            // 3. Salva na lista central
            DataContext.Books.Add(newBook);

            MessageBox.Show("Book successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Hide();
            new MainForm().ShowDialog();
		}
		void RegisterBookFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
	}
}
