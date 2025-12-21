namespace Kick_Chat
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            bool createdNew;
            using (System.Threading.Mutex mutex = new System.Threading.Mutex(true, "KickChatSingletonMutex", out createdNew))
            {
                if (!createdNew)
                {
                    return;
                }

                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}
