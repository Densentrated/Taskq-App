namespace Taskq_App_Revised.Views;

public partial class DashBoardPage : ContentPage
{
	public DashBoardPage()
	{
		InitializeComponent();
	}

	public async void OnTaskBoxSwiped(object sender, SwipedEventArgs e)
	{
		await Navigation.PushAsync(new AddTasksPage());
	}

	public async void OnPageChangeButtonClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new AddTasksPage());
    }
}