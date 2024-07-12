using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace OnlineStudentRegistrationForm
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            // Form is valid, proceed with sign up process
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            // 1. Username validation
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text))
            {
                ErrorTextBlock.Text = "Please enter your Username";
                isValid = false;
            }

            // 2. Password validation
            if (string.IsNullOrWhiteSpace(PasswordBox.Password) || PasswordBox.Password.Length > 10)
            {
                ErrorTextBlock.Text = "Please enter the password with Max Length = 10 chr";
                isValid = false;
            }

            // 3. Gender validation
            if (!MaleRadioButton.IsChecked.Value && !FemaleRadioButton.IsChecked.Value)
            {
                ErrorTextBlock.Text = "Must Enter Gender";
                isValid = false;
            }

            // 4. Payment option validation
            if (!CreditDebitRadioButton.IsChecked.Value && !NetbankingRadioButton.IsChecked.Value && !PaypalRadioButton.IsChecked.Value)
            {
                ErrorTextBlock.Text = "Must Enter 1 Payment Option";
                isValid = false;
            }

            // 5. Terms and Conditions validation
            if (!TermsConditionsCheckBox.IsChecked.Value)
            {
                ErrorTextBlock.Text = "MUST check the Check Box to agree to our Terms and Conditions";
                isValid = false;
            }

            return isValid;
        }

        private void ResetFormButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset the form fields to their default values
            UserNameTextBox.Text = string.Empty;
            PasswordBox.Password = string.Empty;
            MaleRadioButton.IsChecked = false;
            FemaleRadioButton.IsChecked = false;
            CreditDebitRadioButton.IsChecked = false;
            NetbankingRadioButton.IsChecked = false;
            PaypalRadioButton.IsChecked = false;
            TermsConditionsCheckBox.IsChecked = false;
            ErrorTextBlock.Text = string.Empty;
        }

        private void CloseFormButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the form
        }

        private void ResetPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle the password reset process
        }
    }
}