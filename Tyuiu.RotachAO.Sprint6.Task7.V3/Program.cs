﻿using Tyuiu.RotachAO.Sprint6.Task7.V3.Lib;
namespace Tyuiu.RotachAO.Sprint6.Task7.V3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}