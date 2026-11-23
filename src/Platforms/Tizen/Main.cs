using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace syncfusion_maui_toolkit_stroke_areaseries_android_issue
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
