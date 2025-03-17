namespace SE08101_SecondDemo
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
            Application.Run(new Form1());
            while (AppData.LoginState == true)
            {
                switch (AppData.CurrentForm)
                {
                    case "Login":
                        Application.Run(new Form1());
                        break;
                    case "Form1":
                        Application.Run(new Form1());
                        break;
                    case "FormList":
                        Application.Run(new FormList());
                        break;
                    default:
                        Application.Run(new Form1());
                        break;
                }
            }
        }
    }
}