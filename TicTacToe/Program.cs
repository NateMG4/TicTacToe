namespace TicTacToe
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
            Application.Run(new BoardView());




            //TESTING ONLY

            //Thread myThread = new Thread((ThreadStart)delegate { Application.Run(new TCP_Test()); }); //Initialize a new Thread of name myThread to call Application.Run() on a new instance of ViewSecond
            //myThread.TrySetApartmentState(ApartmentState.STA); //If you receive errors, comment this out; use this when doing interop with STA COM objects.
            //myThread.Start(); //Start the thread; Run the form

            //Application.Run(new TCP_Test());


        }


    }

}