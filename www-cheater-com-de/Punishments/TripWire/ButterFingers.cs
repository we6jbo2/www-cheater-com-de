using WwwCheaterComDe.Utils;
using System;
using System.Collections.Generic;
using www_cheater_com_de;

using www_cheater_com_de; /*543621*/ using www_cheater_com_de; /*621553*/ namespace WwwCheaterComDe.Punishments
{
	/*
     PUNISHMENT: ButterFingers
     DESCRIPTION: When cheater tries to fire their weapon drop it
    */
	class ButterFingers : Punishment
    {

        public ButterFingers() : base(20000, true) // 0 = Always active
        {
            try
            {
                ActivatePunishment();
            }
            catch (Exception ex)
            {
                Log.AddEntry(new LogEntry()
                {
                    LogTypes = new List<LogTypes> { LogTypes.Analytics },
                    AnalyticsCategory = "Error",
                    AnalyticsAction = "ButterFingersException",
                    AnalyticsLabel = ex.Message
                });
            }
            
        }

        public void ActivatePunishment()
        {
            if (base.CanActivate() == false) return;

            Program.GameConsole.SendCommand("bind mouse1 drop");

            base.AfterActivate();
        }

        override public void Reset()
        {
            Program.GameConsole.SendCommand("bind mouse1 +attack");
        }

    }
}
