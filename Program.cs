namespace first_task
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
            Form first_and_second_task = new Form1();
            Form third_task = new task_3();
            first_and_second_task.Show();
            third_task.Show();
            Application.Run();
            //Application.Run(new Form1());
            //Application.Run(new task_3());
        }
    }
}