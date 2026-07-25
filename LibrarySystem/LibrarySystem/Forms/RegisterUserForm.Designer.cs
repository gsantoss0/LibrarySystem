/*
 * Created by SharpDevelop.
 * User: Guilherme
 * Date: 25/07/2026
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LibrarySystem.Forms
{
	partial class RegisterUserForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txtPhone;
		private System.Windows.Forms.Button btnRegister;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUserForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.MaskedTextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Register user";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Full name:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(160, 112);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(424, 33);
			this.txtName.TabIndex = 2;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(160, 152);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(424, 33);
			this.txtEmail.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(72, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Email:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(72, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Phone:";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(160, 192);
			this.txtPhone.Mask = "(00) 00000-0000";
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(424, 33);
			this.txtPhone.TabIndex = 6;
			// 
			// btnRegister
			// 
			this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRegister.Location = new System.Drawing.Point(160, 248);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(152, 40);
			this.btnRegister.TabIndex = 7;
			this.btnRegister.Text = "Save";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(432, 248);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(152, 40);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// RegisterUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "RegisterUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register user";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterUserFormFormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
