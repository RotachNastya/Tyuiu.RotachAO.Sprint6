﻿using Tyuiu.RotachAO.Sprint6.Task1.V11.Lib;
namespace Tyuiu.RotachAO.Sprint6.Task1.V11
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