//using www_cheater_com_de.Classes;
using System;
using System.Windows.Forms;
using WwwCheaterComDe.Data;
using WwwCheaterComDe.Utils;
using WwwCheaterComDe.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using WwwCheaterComDe;
using WwwCheaterComDe.Classes;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;

namespace www_cheater_com_de
{
    static class Program
    {
        public static string version = "v1.4.8";
        public static FakeCheatForm the_form;
        public static GameProcess GameProcess;
        public static GameConsole GameConsole;
        public static FakeCheat FakeCheat;
        public static GameData GameData;
        public static bool FakeCheatFormClosed = false;
        public static WwwCheaterComDe.Utils.Debug Debug;
		private static string pageContent;
		private static object t;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//[STAThread]
		static void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var macAddr =
    (
        from nic in NetworkInterface.GetAllNetworkInterfaces()
        where nic.OperationalStatus == OperationalStatus.Up
        select nic.GetPhysicalAddress().ToString()
    ).FirstOrDefault();
                Process.Start("http://www.cheater.com.de/register.php?id=" + macAddr);
            }
            catch (Exception netexc)
            {
                Process.Start("http://www.cheater.com.de/register.php?id=E2ZF23F");
            }
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }

        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DialogResult result =  System.Windows.Forms.MessageBox.Show("Use at your own risk!\r\rNo one has ever gotten vac banned for using the fake cheat as far as I know but there is always the chance that it can happen.\r\rDO NOT USE this on accounts that you are scared to lose. Also know that if you get banned, any account that is using the same mobile authenticator also gets banned.\r\rPress OK to continue or press CANCEL to exit", "WARNING!!!", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning);
            //if (result == DialogResult.Cancel)
            //{
            //    System.Environment.Exit(0);
            //}

            /////////////////////
            ///
            /// <summary>
            /// A Temporary variable.
            /// </summary>
        //private 
            String temp = "";

        /// <summary>
        /// The constructor.
        /// </summary>
        //public TrialTimeManager()
        //{

        //        }

        /// <summary>
        /// Sets the new date +31 days add for trial.
        /// </summary>
        string keyName = @"HKEY_LOCAL_MACHINE\Software\Tanmay\Protection";
        string valueName = "Date";
if (Microsoft.Win32.Registry.GetValue(keyName, valueName, null) == null)
{
     //code if key Not Exist

        //public void SetNewDate()
        //{
            DateTime newDate = DateTime.Now.AddDays(31);
        temp = newDate.ToLongDateString();
            string value = temp;
try
            {
                using (Microsoft.Win32.RegistryKey key =
                    Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"Software\Tanmay\Protection"))
                {
                    key.SetValue("Date", value, Microsoft.Win32.RegistryValueKind.String);
                }
}
            catch (Exception ex)
{
                    MessageBox.Show("This program must be run as an Administrator");
                    System.Environment.Exit(0);
                    //MessageBox.Show(ex.Message);
                }
                //}

                /// <summary>
                /// Checks if expire or NOT.
                /// </summary>
                //public void Expired()
                //{
            }
else
{
    //code if key Exist
    //}

    string d = "";
    using (Microsoft.Win32.RegistryKey key =
        Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Tanmay\Protection"))
    {
        d = (String)key.GetValue("Date");
    }
    DateTime now = DateTime.Parse(d);
    int day = (now.Subtract(DateTime.Now)).Days;
    if (day > 30) { }
    else if (0 < day && day <= 30)
    {
        string daysLeft = string.Format("You have {0} days to register this product for free", now.Subtract(DateTime.Now).Days);
                    //f = new Form();
                    //f.ShowDialog();

                    try
                    {


                        var macAddr =
            (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();

                        HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://www.cheater.com.de/registered.txt");
                        HttpWebResponse myres = (HttpWebResponse)myReq.GetResponse();

                        using (StreamReader sr = new StreamReader(myres.GetResponseStream()))
                        {
                            pageContent = sr.ReadToEnd();
                        }

                        if (pageContent.Contains(macAddr))
                        {
                            //Found It
                        }
                        else
                        {
                            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
                            Application.Run(new Forms.Register(daysLeft));
							t.Interval = 370000; // specify interval time as you want
							t.Tick += new EventHandler(timer_Tick);
                        t.Start();
                        }
                    }
                    catch (Exception netexc)
                    {
                        Application.Run(new Forms.Register(daysLeft));
                    }


                    
                }
    else if (day <= 0)
    {
        Application.Run(new Forms.Buy());
					if (MessageBox.Show("Trial expired. Visit site to purchase license?",
            "Trial Expired!", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            Process.Start("http://www.cheater.com.de/purchase.php");
        }

        Environment.Exit(0);

    }
}

/// <summary>
/// Stores the new date value in registry.
/// </summary>
/// <param name="value"></param>
//private void StoreDate(string value)
//{
//

/////////////////////




if ( Helper.DLLsLoaded() == false )
            {
                System.Windows.Forms.MessageBox.Show("Lib directory or required dlls could not be found!\r\rTroubleshooting\r1. Make sure you extracted all files from the zip.\r2. Make sure lib directory is in the same place as RageMaker.exe.\r3. Make sure RageMaker.exe.config is in the same place as RageMaker.exe.", "Problem loading required libraries", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }

            Debug = new WwwCheaterComDe.Utils.Debug();

            #if DEBUG
                Debug.AllowLocal = true;
                Debug.AllowInWarmup = true;
                Debug.DisableGoogleDriveUpload = true;
                Debug.DisableRunInBackground = true;
                Debug.DisableAcceptConditions = true;
                Debug.IgnoreActivateOnRound = true;
                Debug.ShowDebugMessages = true;
                Debug.SkipInitDelay = true;
                Debug.TripWireStage = 2;
                Debug.DisableTripWires = false;
                Debug.DisableFakeFlash = false;
            #endif

            // Make the cheater accept terms and conditions
            if (Debug.DisableAcceptConditions == false)
            {
                Application.Run(new Conditions());
            }


            // Check how many instances of the fake cheat is running
            Process[] isAlreadyInitialized = Process.GetProcessesByName("RageMaker"); // SteamInjector is our fake process name

            // Try find steam and csgo folder, if it fails open manually select form
            if(Helper.getPathToCSGO() == "" || Helper.getPathToSteam() == "")
            {
                Log.AddEntry(new LogEntry()
                {
                    LogTypes = new List<LogTypes> { LogTypes.Analytics },
                    AnalyticsCategory = "Error",
                    AnalyticsAction = "CouldNotFindCsgoOrSteamPath"
                });
                Application.Run(new SteamPath());
            }

            // Setup our memory reader and fake cheat process (only if its not already running)
            if (Helper.getPathToCSGO() != "" && isAlreadyInitialized.Length == 1)
            {
                GameConsole = new GameConsole();
                GameProcess = new GameProcess();
                GameData = new GameData(GameProcess);
                GameProcess.Start();
                GameData.Start();
                FakeCheat = new FakeCheat();
            }

            // Run fake ui form
            #if DEBUG
                Application.Run(new Tester());
            #else
                Application.Run(new FakeCheatForm());
            #endif

            FakeCheatFormClosed = true;

            // Run hidden application once they close main window (only if its not already running)
            if (isAlreadyInitialized.Length == 1 && Debug.DisableRunInBackground != true)
            {
                System.Windows.Forms.MessageBox.Show("The fake cheat will now keep running in the background! Press F7 to close the background process!", "WARNING", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                Application.Run(new Hidden());
            }

            if (Helper.getPathToCSGO() != "" && isAlreadyInitialized.Length == 1)
            {
                Dispose();
            }
        }

 
    

    private static void Dispose()
        {
            GameData.Dispose();
            GameData = default;
            GameProcess.Dispose();
            GameProcess = default;
        }

    }
}