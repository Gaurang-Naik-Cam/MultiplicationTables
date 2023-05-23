using System.Text;
namespace MultiplicationTables;

public partial class MainPage : ContentPage
{
	StringBuilder sb;

	public MainPage()
	{
		InitializeComponent();
		stepper.Value = 1;
		sb = new StringBuilder();
	}

	private void OnClicked(object sender, EventArgs e)
	{
		lblOutput.Text = "";
		sb.Clear();
        int num = 0;
		if (int.TryParse(txtbxNumber.Text, out num))
		{
			int tableValue = Convert.ToInt32(stepper.Value);

			for (int i = 1; i<=tableValue; i++)
			{
				sb.Append(string.Format(" {0} x {1} = {2}\n", num, i, (num * i)));
			}

			lblOutput.Text = sb.ToString();
		}
		else
		{
			DisplayAlert("Error", "Please enter a valid number", "Discard");
		}
	}

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblstepper.Text = string.Concat("Multiplication Number " ,stepper.Value.ToString());
    }
}

