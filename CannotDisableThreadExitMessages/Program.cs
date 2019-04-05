using System.Threading;

namespace CannotDisableThreadExitMessages
{
    internal static class Program
    {
        private static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                var t = new Thread(DoStuff);
                t.Start();
            }
        }

        private static void DoStuff()
        {
            Thread.Sleep(50);
        }
    }
}
