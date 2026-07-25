/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 25/07/2026
 * Time: 10:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem.Forms
{
	partial class BooksForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView dgvBooks;
		private System.Windows.Forms.PictureBox picSearch;
		private System.Windows.Forms.Button btnExit;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvBooks = new System.Windows.Forms.DataGridView();
			this.picSearch = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Books";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(80, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Search:";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(144, 80);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(776, 33);
			this.txtSearch.TabIndex = 2;
			// 
			// dgvBooks
			// 
			this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBooks.Location = new System.Drawing.Point(24, 136);
			this.dgvBooks.Name = "dgvBooks";
			this.dgvBooks.Size = new System.Drawing.Size(976, 400);
			this.dgvBooks.TabIndex = 3;
			// 
			// picSearch
			// 
			this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
			this.picSearch.Location = new System.Drawing.Point(928, 88);
			this.picSearch.Name = "picSearch";
			this.picSearch.Size = new System.Drawing.Size(16, 16);
			this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picSearch.TabIndex = 4;
			this.picSearch.TabStop = false;
			this.picSearch.Click += new System.EventHandler(this.PicSearchClick);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(928, 16);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 32);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// BooksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1018, 554);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.picSearch);
			this.Controls.Add(this.dgvBooks);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "BooksForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Books";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BooksFormFormClosed);
			this.Load += new System.EventHandler(this.BooksFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
