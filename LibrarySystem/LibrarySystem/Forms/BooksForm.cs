using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibrarySystem.Data;
using LibrarySystem.Models;
using System.Linq;

namespace LibrarySystem.Forms
{

	public partial class BooksForm : Form
	{
		public BooksForm()
		{

			InitializeComponent();
			
		}
		void BtnExitClick(object sender, EventArgs e)
		{
			this.Hide();
			new MainForm().ShowDialog();
		}
		void BooksFormLoad(object sender, EventArgs e)
		{
			FormatDataGridView();
			LoadBooks(DataContext.Books);
		}
		private void LoadBooks(List<Book> booksList)
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = booksList;
        }
		void BooksFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		void PicSearchClick(object sender, EventArgs e)
		{
			string searchTerm = txtSearch.Text.Trim().ToLower();

            
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadBooks(DataContext.Books);
                return;
            }

            //filtrar por titulo ou autor
            var filteredBooks = DataContext.Books
                .Where(b => (b.Title != null && b.Title.ToLower().Contains(searchTerm)) ||
                            (b.Author != null && b.Author.ToLower().Contains(searchTerm)))
                .ToList();

            LoadBooks(filteredBooks);
		}
		
		private void FormatDataGridView()
		{
    		
    		dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    		dgvBooks.RowTemplate.Height = 30;
    		dgvBooks.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothica", 9F);
    		dgvBooks.ColumnHeadersHeight = 35;
    		dgvBooks.EnableHeadersVisualStyles = false;
    		dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
		}
		
	}
}
