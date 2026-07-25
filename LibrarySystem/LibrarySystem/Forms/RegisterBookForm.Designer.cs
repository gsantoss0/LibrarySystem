/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 25/07/2026
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem.Forms
{
	partial class RegisterBookForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label caption;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtISBN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtGenre;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.MaskedTextBox txtPublicationYear;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterBookForm));
			this.caption = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtISBN = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtGenre = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtPublicationYear = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// caption
			// 
			this.caption.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caption.Location = new System.Drawing.Point(48, 32);
			this.caption.Name = "caption";
			this.caption.Size = new System.Drawing.Size(184, 32);
			this.caption.TabIndex = 0;
			this.caption.Text = "Register a book ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(72, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Title:";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(136, 112);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(448, 33);
			this.txtTitle.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Author:";
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(136, 152);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(448, 33);
			this.txtAuthor.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(72, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "ISBN:";
			// 
			// txtISBN
			// 
			this.txtISBN.Location = new System.Drawing.Point(136, 192);
			this.txtISBN.Name = "txtISBN";
			this.txtISBN.Size = new System.Drawing.Size(448, 33);
			this.txtISBN.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(72, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Publication year:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(72, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Genre:";
			// 
			// txtGenre
			// 
			this.txtGenre.Location = new System.Drawing.Point(136, 232);
			this.txtGenre.Name = "txtGenre";
			this.txtGenre.Size = new System.Drawing.Size(448, 33);
			this.txtGenre.TabIndex = 10;
			// 
			// btnSave
			// 
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.Location = new System.Drawing.Point(208, 320);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(152, 40);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(432, 320);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(152, 40);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// txtPublicationYear
			// 
			this.txtPublicationYear.Location = new System.Drawing.Point(208, 272);
			this.txtPublicationYear.Mask = "0000";
			this.txtPublicationYear.Name = "txtPublicationYear";
			this.txtPublicationYear.Size = new System.Drawing.Size(376, 33);
			this.txtPublicationYear.TabIndex = 13;
			this.txtPublicationYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// RegisterBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.txtPublicationYear);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtGenre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtISBN);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAuthor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.caption);
			this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "RegisterBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register a book";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterBookFormFormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
