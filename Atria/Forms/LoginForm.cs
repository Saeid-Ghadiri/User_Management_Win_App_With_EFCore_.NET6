using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Atria.Forms
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		#region Ctor
		public LoginForm() : base()
		{
			InitializeComponent();
		}

		#endregion

		#region Form Load
		private void LoginForm_Load(object sender, System.EventArgs e)
		{
			this.AcceptButton = LoginButton;
			this.CancelButton = ExitButton;
		}
		#endregion

		#region RestForm
		public void ResetForm()
		{
			passwordTextBox.Text = string.Empty;
			usernameTextBox.Text = string.Empty;

			usernameTextBox.Focus();

			//Infrastructure.Utility.AuthenticatedUser = null;
		}
		#endregion RestForm

		#region UserLoginAsync

		private async System.Threading.Tasks.Task UserLoginAsync()
		{
			// **************************************************
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
				string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				System.Windows.Forms.MessageBox
					.Show(
					text: "!نام کاربری و رمز لازمه بزن"
					);

				usernameTextBox.Text =
						usernameTextBox.Text?.Replace(" ", string.Empty);

				passwordTextBox.Text =
						passwordTextBox.Text?.Replace(" ", string.Empty);


				if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
				{
					usernameTextBox.Focus();
				}
				else
				{
					passwordTextBox.Focus();
				}

				return;
			}
			// **************************************************
			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

				var usernameTextBox = 
					"usernameTextBox.Text";

				var foundedUser =
					await
					databaseContext.Users
					.Where(current => current.Username!.ToLower() == usernameTextBox.ToLower())
					.FirstOrDefaultAsync();

				if (foundedUser == null)
				{
					System.Windows.Forms.MessageBox
						.Show("نام کاربری اشتباه است.");

					//usernameTextBox.Focus();

					return;
				}

				var passwordTextBox =
					"passwordTextBox.text";

				var foundedPass =
					await
					databaseContext.Users
					.Where(current => current.Password!.ToLower() == passwordTextBox.ToLower())
					.FirstOrDefaultAsync();

				if (foundedPass != null)
				{
					System.Windows.Forms.MessageBox
						.Show(
						text: "رمز اشتباه است"
						);
				}


				// خطا میده
				//if (string.Compare(foundedPass.Password, passwordTextBox.Text, ignoreCase: false) != 0)
				//	if (foundedUser != null)
				//	{
				//		System.Windows.Forms.MessageBox
				//			.Show("Password is not correct!");

				//		//usernameTextBox.Focus();

				//		return;
				//	}

				//if (foundedUser.IsActive != false)
				//{
				//	System.Windows.Forms.MessageBox
				//		.Show("You can not login right now! Please contact support.");

				//	//usernameTextBox.Focus();

				//	return;
				//}

				// **************************************************
				//روش lazy loading
				Hide();

				Infrastructure.Utility.MainForm.ResetForm();

				Infrastructure.Utility.MainForm.Show();
				// **************************************************
			}
			catch (System.Exception ex)
			{
				// Log Error!

				System.Windows.Forms.MessageBox
					.Show(text: $"Error: {ex.Message}");
			}
			finally
			{
				if (databaseContext != null)
				{
					await databaseContext.DisposeAsync();
				}
			}
		}
		#endregion UserLoginAsync

		#region Accept Button
		private async void LoginButton_Click(object sender, System.EventArgs e)
		{
			#region EF 6
			//// **************************************************
			//if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
			//	string.IsNullOrWhiteSpace(passwordTextBox.Text))
			//{
			//	System.Windows.Forms.MessageBox
			//		.Show(
			//		text: "Username and Password are requied!"
			//		);

			//	usernameTextBox.Text =
			//			usernameTextBox.Text?.Replace(" ", string.Empty);

			//	passwordTextBox.Text =
			//			passwordTextBox.Text?.Replace(" ", string.Empty);


			//	if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			//	{
			//		usernameTextBox.Focus();
			//	}
			//	else
			//	{
			//		passwordTextBox.Focus();
			//	}

			//	return;
			//}
			//// **************************************************

			//// **************************************************
			//Data.DatabaseContext? databaseContext = null;

			//try
			//{
			//	databaseContext =
			//		new Data.DatabaseContext();

			//	var foundedUser =
			//		databaseContext.Users
			//		.Where(current => current.Username!.ToLower() == usernameTextBox.Text.ToLower())
			//		.FirstOrDefault();

			//	if (foundedUser == null)
			//	{

			//		System.Windows.Forms.MessageBox
			//			.Show("Username and/or Password is not correct!");

			//		usernameTextBox.Focus();

			//		return;
			//	}

			//	if (string.Compare(foundedUser.Password, passwordTextBox.Text, ignoreCase: false) != 0)
			//	{

			//		System.Windows.Forms.MessageBox
			//			.Show("Username and/or Password is not correct!");

			//		usernameTextBox.Focus();

			//		return;
			//	}

			//	if (foundedUser.IsActive == false)
			//	{
			//		System.Windows.Forms.MessageBox
			//			.Show("You can not login right now! Please contact support.");

			//		usernameTextBox.Focus();

			//		return;
			//	}

			//	// **************************************************

			//	// **************************************************

			//	//Infrastructure.Utility.AuthenticatedUser = foundedUser;

			//	// **************************************************

			//	// **************************************************
			//	//روش lazy loading
			//	Hide();

			//	Infrastructure.Utility.MainForm.ResetForm();

			//	Infrastructure.Utility.MainForm.Show();
			//	// **************************************************
			//	// **************************************************
			//	// **************************************************
			//}
			//	catch (System.Exception ex)
			//	{
			//		System.Windows.Forms.MessageBox
			//			.Show(text: $"Error: {ex.Message}");
			//	}
			//	finally
			//	{
			//		if (databaseContext != null)
			//		{
			//			databaseContext.Dispose();
			//			databaseContext = null;
			//		}
			//	}
			// **************************************************
			#endregion EF 6

			#region EF Core .NET 6

			await UserLoginAsync();

			#endregion EF Core .NET 6
		}
		#endregion Accept Button

		#region Exit Form
		private void ExitButton_Click(object sender, System.EventArgs e)
{
	this.ExitButton.TabStop = false;
	this.ExitButton.FlatAppearance.BorderSize = 0;
	this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
	this.ExitButton.BackColor = System.Drawing.Color.Transparent;

	//------------------------------------------------------------
	System.Windows.Forms.DialogResult enmResult =
		System.Windows.Forms.MessageBox.Show(
			this,
			text: "آیا به خروج از برنامه اطمینان دارید؟",
			caption: "سوال :: خروج",
			buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
			icon: System.Windows.Forms.MessageBoxIcon.Question,
			defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button3,
			options: System.Windows.Forms.MessageBoxOptions.RtlReading
			);

	if (enmResult == System.Windows.Forms.DialogResult.Yes)
	{
		System.Windows.Forms.Application.Exit();
	}
	//------------------------------------------------------------
}

#endregion Exit Form

#region Event Handler
private void passwordTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
{
	if (e.KeyData == System.Windows.Forms.Keys.Enter)
	{
		LoginButton_Click(sender, e);
	}
}

		#endregion


	}
}
