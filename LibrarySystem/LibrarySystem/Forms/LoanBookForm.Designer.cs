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
	partial class LoanBookForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbBooks;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbUsers;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpReturnDate;
		private System.Windows.Forms.Button btnLoan;
		private System.Windows.Forms.Button btnCancel;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanBookForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbBooks = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbUsers = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
			this.btnLoan = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Loan a book";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Choose a book:";
			// 
			// cmbBooks
			// 
			this.cmbBooks.FormattingEnabled = true;
			this.cmbBooks.Location = new System.Drawing.Point(200, 96);
			this.cmbBooks.Name = "cmbBooks";
			this.cmbBooks.Size = new System.Drawing.Size(384, 29);
			this.cmbBooks.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(72, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Choose a user:";
			// 
			// cmbUsers
			// 
			this.cmbUsers.FormattingEnabled = true;
			this.cmbUsers.Location = new System.Drawing.Point(200, 136);
			this.cmbUsers.Name = "cmbUsers";
			this.cmbUsers.Size = new System.Drawing.Size(384, 29);
			this.cmbUsers.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(72, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Loan date:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(200, 176);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(384, 33);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(72, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 48);
			this.label5.TabIndex = 8;
			this.label5.Text = "Return date expected:";
			// 
			// dtpReturnDate
			// 
			this.dtpReturnDate.Location = new System.Drawing.Point(200, 224);
			this.dtpReturnDate.Name = "dtpReturnDate";
			this.dtpReturnDate.Size = new System.Drawing.Size(384, 33);
			this.dtpReturnDate.TabIndex = 9;
			// 
			// btnLoan
			// 
			this.btnLoan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLoan.Location = new System.Drawing.Point(200, 272);
			this.btnLoan.Name = "btnLoan";
			this.btnLoan.Size = new System.Drawing.Size(168, 40);
			this.btnLoan.TabIndex = 10;
			this.btnLoan.Text = "Confirm loan";
			this.btnLoan.UseVisualStyleBackColor = true;
			this.btnLoan.Click += new System.EventHandler(this.BtnLoanClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(416, 272);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(168, 40);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// LoanBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnLoan);
			this.Controls.Add(this.dtpReturnDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbUsers);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbBooks);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "LoanBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loan book";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoanBookFormFormClosed);
			this.Load += new System.EventHandler(this.LoanBookFormLoad);
			this.ResumeLayout(false);

		}
	}
}
