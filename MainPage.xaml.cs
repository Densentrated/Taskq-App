
using System.Diagnostics;
using System.Net.Security;
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

	private void TaskScreenButtonClicked(object sender, EventArgs e)
	{
		//string taskText = taskInput.Text;
		//int taskTime = Int32.Parse(deadlineInput.Text);
		//int taskDurration = Int32.Parse(durrationInput.Text);

		//TasksOfToday.AddObjectiveByTime((taskText, taskTime, taskDurration));

		//(string, int, int) task1Data = TasksOfToday.head.data;
		//(string, int, int) task2Data = TasksOfToday.head.next.data;
		//(string, int, int) task3Data = TasksOfToday.head.next.next.data;

		FirstTaskText.Text = "Button Clicked";
		


    }
}
