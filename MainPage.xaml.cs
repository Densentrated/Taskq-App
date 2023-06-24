
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

/**
namespace LinkedList
{
    class Program
    {
        public static LinkedList<string> taskList = new LinkedList<String>();
        public static LinkedList<string> taskTimeList = new LinkedList<String>();

        static void Main()
        {
            addTaskAndTime("BrushTeeth and Wash Hair","07:20-08:24");
            Console.WriteLine(taskList.ElementAt(0));
            Console.WriteLine(taskList.First);
        }

        // adds Items to thie following List
        static void addTaskAndTime(string task, string timeFrame)
        {
            taskList.AddLast(task);
            taskTimeList.AddLast(timeFrame);
        }
        
        // gets the first Five Items From the List
        static void getTasksAndTimes()
        {

        }

        // removes a specific Item from the List
        static void removeTaskandTimes()
        {

        }

        static void getTaskandTime()
        {

        }
    }
}

**/
