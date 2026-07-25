/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 25/07/2026
 * Time: 10:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegisterBook;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnRegisterUser;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnLoanBook;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnReturnBook;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button btnListBooks;
		private System.Windows.Forms.PictureBox pictureBox5;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegisterBook = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRegisterUser = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnLoanBook = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnReturnBook = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.btnListBooks = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(226, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "- Library System -";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnRegisterBook
			// 
			this.btnRegisterBook.BackColor = System.Drawing.Color.White;
			this.btnRegisterBook.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegisterBook.Location = new System.Drawing.Point(216, 113);
			this.btnRegisterBook.Name = "btnRegisterBook";
			this.btnRegisterBook.Size = new System.Drawing.Size(212, 39);
			this.btnRegisterBook.TabIndex = 1;
			this.btnRegisterBook.Text = "Register a book";
			this.btnRegisterBook.UseVisualStyleBackColor = false;
			this.btnRegisterBook.Click += new System.EventHandler(this.BtnRegisterBookClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(434, 113);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// btnRegisterUser
			// 
			this.btnRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegisterUser.Location = new System.Drawing.Point(216, 167);
			this.btnRegisterUser.Name = "btnRegisterUser";
			this.btnRegisterUser.Size = new System.Drawing.Size(212, 39);
			this.btnRegisterUser.TabIndex = 3;
			this.btnRegisterUser.Text = "Register user";
			this.btnRegisterUser.UseVisualStyleBackColor = true;
			this.btnRegisterUser.Click += new System.EventHandler(this.BtnRegisterUserClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(434, 167);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 39);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// btnLoanBook
			// 
			this.btnLoanBook.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLoanBook.Location = new System.Drawing.Point(216, 221);
			this.btnLoanBook.Name = "btnLoanBook";
			this.btnLoanBook.Size = new System.Drawing.Size(212, 39);
			this.btnLoanBook.TabIndex = 5;
			this.btnLoanBook.Text = "Loan book";
			this.btnLoanBook.UseVisualStyleBackColor = true;
			this.btnLoanBook.Click += new System.EventHandler(this.BtnLoanBookClick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(434, 221);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(34, 39);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			// 
			// btnReturnBook
			// 
			this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReturnBook.Location = new System.Drawing.Point(216, 276);
			this.btnReturnBook.Name = "btnReturnBook";
			this.btnReturnBook.Size = new System.Drawing.Size(212, 39);
			this.btnReturnBook.TabIndex = 7;
			this.btnReturnBook.Text = "Return book";
			this.btnReturnBook.UseVisualStyleBackColor = true;
			this.btnReturnBook.Click += new System.EventHandler(this.BtnReturnBookClick);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(434, 276);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(34, 39);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// btnListBooks
			// 
			this.btnListBooks.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListBooks.Location = new System.Drawing.Point(216, 330);
			this.btnListBooks.Name = "btnListBooks";
			this.btnListBooks.Size = new System.Drawing.Size(212, 39);
			this.btnListBooks.TabIndex = 9;
			this.btnListBooks.Text = "List books";
			this.btnListBooks.UseVisualStyleBackColor = true;
			this.btnListBooks.Click += new System.EventHandler(this.BtnListBooksClick);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(434, 330);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(34, 39);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.btnListBooks);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.btnReturnBook);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.btnLoanBook);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnRegisterUser);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRegisterBook);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LibrarySystem";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
