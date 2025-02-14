namespace Assignment5;

public partial class RecomPage : ContentPage
{
	public RecomPage(string status)
	{
		InitializeComponent();
		string recommendation ="";
		LblStatus.Text = status;
		if (status == "Underweight")
		{
			recommendation = "Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, Underweight whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
		}
		if (status == "Normal")
		{
			recommendation = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
		}
		if (status == "Overweight")
		{
			recommendation = "Reduce processed foods and focus on portion control. Engage in regular Overweight aerobic exercises (e.g., jogging, swimming) and strength training. Drink plenty of water and track your progress.";
		}
		if (status == "obese")
		{
			recommendation = "Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
		}
		LblRecom.Text = "Recommendation: " + recommendation;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PopToRootAsync();
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}