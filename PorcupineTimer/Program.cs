using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using PorcupineTimer.Audio;

namespace PorcupineTimer
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureDependencies();
            Application.Run(container.GetInstance<Form1>());
        }

        private static void ConfigureDependencies()
        {
            container = new Container();
            container.Register<IAudioManager, AudioManager>(Lifestyle.Singleton);
            container.Register<Form1>(Lifestyle.Singleton);

            container.Verify();

        }
    }
}
