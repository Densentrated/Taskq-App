﻿using Taskq_App_Revised.Views;

namespace Taskq_App_Revised;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
		Routing.RegisterRoute(nameof(AddTasksPage), typeof(AddTasksPage));
		Routing.RegisterRoute(nameof(DashBoardPage), typeof(DashBoardPage));
	}
}
