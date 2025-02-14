namespace Assignment5;

public partial class BMIResult : ContentPage
{
	string status = "";
	public BMIResult(string choice, double height, double weight)
	{
		InitializeComponent();
		double bmi = (703 * weight) / (height * height);

		
		if (choice == "Female")
		{
			if (bmi < 18.5)
			{
				status = "Underweight";
			}
			if (bmi >= 18.5 && bmi < 25)
			{
				status = "Normal Weight";
			}
			if (bmi >= 25 && bmi < 30)
			{
				status = "Overweight";
			}
			if (bmi >= 30)
			{
				status = "Obese";
			}
		}
		else
		{
			if (bmi < 18)
			{
				status = "Underweight";
			}
			if (bmi >= 18 && bmi < 24)
			{
				status = "Normal Weight";
			}
			if (bmi >= 24 && bmi < 29)
			{
				status = "Overweight";
			}
			if (bmi >= 29)
			{
				status = "Obese";
			}
		}
		LblBMI.Text = "BMI: " + bmi.ToString() + "\nCategory: " + status;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new RecomPage(status));
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}