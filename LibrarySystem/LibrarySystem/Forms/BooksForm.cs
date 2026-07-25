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

            // Filtra por Título OU Autor
            var filteredBooks = DataContext.Books
                .Where(b => (b.Title != null && b.Title.ToLower().Contains(searchTerm)) ||
                            (b.Author != null && b.Author.ToLower().Contains(searchTerm)))
                .ToList();

            LoadBooks(filteredBooks);
		}
		
		private void FormatDataGridView()
		{
    		// 1. Faz as colunas ocuparem todo o espaço disponível na largura do DataGridView
    		dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

    		// 2. Aumenta a altura das linhas para o texto não ficar "espremido"
    		dgvBooks.RowTemplate.Height = 30;

    		// 3. (Opcional) Melhora o alinhamento e altera a fonte das células
    		dgvBooks.DefaultCellStyle.Font = new System.Drawing.Font("Yu Gothica", 9F);
    
    		// 4. (Opcional) Melhora o visual do cabeçalho
    		dgvBooks.ColumnHeadersHeight = 35;
    		dgvBooks.EnableHeadersVisualStyles = false;
    
    		// 5. Ajusta o alinhamento para não cortar títulos longos
    		dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
		}
		
	}
}
