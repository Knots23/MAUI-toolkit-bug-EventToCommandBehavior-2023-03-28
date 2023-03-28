using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Bug_EventToCommandBahavior_2023_03_28;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
