
using System.Security.Cryptography.X509Certificates;
using ObjectiveLinkedList;

namespace Taskq_App;

public partial class MainPage : ContentPage
{
    public ObjectiveList TasksOfToday = new ObjectiveList();
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnConfirmTaskButtonClicked(object sender, EventArgs e)
	{
		string taskText = taskInput.Text;
		int taskTime = Int32.Parse(deadlineInput.Text);
		int taskDurration = Int32.Parse(durrationInput.Text);

		TasksOfToday.AddObjectiveByTime((taskText, taskTime, taskDurration));

	}
}

