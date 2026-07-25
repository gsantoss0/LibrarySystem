/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 25/07/2026
 * Time: 10:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem.Forms
{
	partial class ReturnBookForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbActiveLoans;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnConfirmReturn;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblLoanDate;
		private System.Windows.Forms.Label lblLoanReturn;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
			this.label1 = new System.Windows.Forms.Label();
			this.cmbActiveLoans = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnConfirmReturn = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblLoanDate = new System.Windows.Forms.Label();
			this.lblLoanReturn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Return a book";
			// 
			// cmbActiveLoans
			// 
			this.cmbActiveLoans.FormattingEnabled = true;
			this.cmbActiveLoans.Location = new System.Drawing.Point(112, 88);
			this.cmbActiveLoans.Name = "cmbActiveLoans";
			this.cmbActiveLoans.Size = new System.Drawing.Size(464, 29);
			this.cmbActiveLoans.TabIndex = 1;
			this.cmbActiveLoans.SelectedIndexChanged += new System.EventHandler(this.CmbActiveLoansSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(112, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Loan date:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(112, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Return date expected:";
			// 
			// btnConfirmReturn
			// 
			this.btnConfirmReturn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConfirmReturn.Location = new System.Drawing.Point(112, 240);
			this.btnConfirmReturn.Name = "btnConfirmReturn";
			this.btnConfirmReturn.Size = new System.Drawing.Size(208, 40);
			this.btnConfirmReturn.TabIndex = 4;
			this.btnConfirmReturn.Text = "Confirm return";
			this.btnConfirmReturn.UseVisualStyleBackColor = true;
			this.btnConfirmReturn.Click += new System.EventHandler(this.BtnConfirmClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(368, 240);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(208, 40);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// lblLoanDate
			// 
			this.lblLoanDate.Location = new System.Drawing.Point(288, 160);
			this.lblLoanDate.Name = "lblLoanDate";
			this.lblLoanDate.Size = new System.Drawing.Size(288, 23);
			this.lblLoanDate.TabIndex = 6;
			this.lblLoanDate.Text = "label4";
			// 
			// lblLoanReturn
			// 
			this.lblLoanReturn.Location = new System.Drawing.Point(288, 192);
			this.lblLoanReturn.Name = "lblLoanReturn";
			this.lblLoanReturn.Size = new System.Drawing.Size(288, 23);
			this.lblLoanReturn.TabIndex = 7;
			this.lblLoanReturn.Text = "label5";
			// 
			// ReturnBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.lblLoanReturn);
			this.Controls.Add(this.lblLoanDate);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirmReturn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbActiveLoans);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "ReturnBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Return book";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnBookFormFormClosed);
			this.Load += new System.EventHandler(this.ReturnBookFormLoad);
			this.ResumeLayout(false);

		}
	}
}
