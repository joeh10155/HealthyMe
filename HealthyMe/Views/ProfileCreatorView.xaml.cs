using System.Windows;
using System.Windows.Controls;
using HealthyMe.Enums;

namespace HealthyMe.Views
{
	/// <summary>
	/// Interaction logic for ProfileCreatorView.xaml
	/// </summary>
	public partial class ProfileCreatorView : UserControl
	{
		public ProfileCreatorView()
		{
			InitializeComponent();
		}

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
			string name = nameTextBox.Text;
			int.TryParse(ageTextBox.Text, out int age);
			Gender gender = (Gender)genderComboBox.SelectedIndex;

			HealthProfile profile = new HealthProfile(name, age, gender);
			SessionData.profile = profile;


			MessageBox.Show($"{name}, {age}, {gender}");
        }
    }
}
