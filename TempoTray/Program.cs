using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TempoTray
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create our AppContext (TrayIcon + Form1) instead of Form1 directly
            Application.Run(new TapAppContext());
        }
    }

    public class TapAppContext : ApplicationContext
    {
        // Main form for the counter
        Form1 mainForm;
        
        // trayIcon that lives in tray
        private NotifyIcon trayIcon;

        // Constructor for app context
        public TapAppContext()
        {
            trayIcon = new NotifyIcon()
            {
                // Setup tray icon
                Icon = TempoTray.Properties.Resources.Icon,
                Text = "TempoTray",
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Exit", Exit)
                }),
                Visible = true,
            };

            // Add event handler to create the counter form
            trayIcon.MouseClick += new MouseEventHandler(this.OpenForm);

            mainForm = new Form1();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }

        void OpenForm(object sender, MouseEventArgs e)
        {
            // Check if the mainForm is visibile/not null and if the tray icon was left clicked
            if (e.Button == MouseButtons.Left)
            {
                mainForm.Show();
            }
        }

    }
}
