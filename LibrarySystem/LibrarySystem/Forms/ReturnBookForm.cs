using System;
using System.Drawing;
using System.Windows.Forms;
using LibrarySystem.Data;
using LibrarySystem.Models;
using System.Linq;

namespace LibrarySystem.Forms
{

	public partial class ReturnBookForm : Form
	{
		public ReturnBookForm()
		{
			InitializeComponent();
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Hide();
			new MainForm().ShowDialog();
		}
		void BtnConfirmClick(object sender, EventArgs e)
		{
			var selectedLoan = cmbActiveLoans.SelectedItem as Loan;

            if (selectedLoan == null)
            {
                MessageBox.Show("Select a valid loan.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            selectedLoan.RegisterReturn();

            MessageBox.Show("Book succesfully returned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            this.Hide();
            new MainForm().ShowDialog();
		}
		void ReturnBookFormLoad(object sender, EventArgs e)
		{
			LoadActiveLoans();
		}
		
		private void LoadActiveLoans()
        {
            
            var activeLoans = DataContext.Loans.Where(l => l.IsActive).ToList();

            cmbActiveLoans.DataSource = null;
            cmbActiveLoans.DataSource = activeLoans;

            
            if (activeLoans.Count == 0)
            {
                lblLoanDate.Text = "-";
                lblLoanReturn.Text = "-";
                btnConfirmReturn.Enabled = false;
            }
            else
            {
                btnConfirmReturn.Enabled = true;
                UpdateLoanDetails();
            }
        }
		
		private void UpdateLoanDetails()
        {
            var selectedLoan = cmbActiveLoans.SelectedItem as Loan;

            if (selectedLoan != null)
            {
                lblLoanDate.Text = selectedLoan.LoanDate.ToString("dd/MM/yyyy");
                lblLoanReturn.Text = selectedLoan.LoanDateDue.ToString("dd/MM/yyyy");
            }
            else
            {
                lblLoanDate.Text = "-";
                lblLoanReturn.Text = "-";
            }
        }
		void CmbActiveLoansSelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateLoanDetails();
		}
		void ReturnBookFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
	}
}
