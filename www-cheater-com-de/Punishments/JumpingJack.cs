﻿using Gma.System.MouseKeyHook;
using WwwCheaterComDe.Classes.Utils;
using WwwCheaterComDe.Utils;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using www_cheater_com_de; /*621553*/ namespace WwwCheaterComDe.Punishments
{
    /*
     PUNISHMENT: JumpingJack
     DESCRIPTION: Cause the cheater to jump with slight backward angle so he can't jump up on objects (creates, windows, edges etc)
    */
    class JumpingJack : Punishment
    {
        private bool IsActive = false;

        private DateTime LastLogEntry = DateTime.Now;

        public JumpingJack() : base(0) // 0 = Always active
        {


            Program.FakeCheat.m_GlobalHook.OnCombination(new Dictionary<Combination, Action>
            {
                {Combination.FromString("Control+Space"), CrouchJumping},
                {Combination.FromString("Space+Control"), CrouchJumping},
            });


            //Program.FakeCheat.m_GlobalHook.KeyDown += CrouchJumping;
            Program.FakeCheat.m_GlobalHook.KeyUp += ReleaseJump;
        }

        private void CrouchJumping(/*object sender, KeyEventArgs e*/)
        {
            try
            {
                if (!Helper.PlayerIsInSpawn() && IsActive == false/* && e.KeyCode == Keys.Space*/)
                { 
                    ActivatePunishment();
                }

            }
            catch (Exception ex)
            {
                Log.AddEntry(new LogEntry()
                {
                    LogTypes = new List<LogTypes> { LogTypes.Analytics },
                    AnalyticsCategory = "Error",
                    AnalyticsAction = "CrouchJumpingException",
                    AnalyticsLabel = ex.Message
                });
            }
        }

        private void ReleaseJump(object sender, KeyEventArgs e)
        {

           if(e.KeyCode == Keys.Space)
            {
                IsActive = false;
            }

        }

        public void ActivatePunishment()
        {
            if (base.CanActivate() == false) return;

            IsActive = true;

            Task.Run(() =>
            {
                Program.GameConsole.SendCommand("-forward; +back");
                Thread.Sleep(500);
                Program.GameConsole.SendCommand("-back");
            });

            // Don't spam log with entries
            if((LastLogEntry - DateTime.Now).TotalSeconds < -10)
            {
                LastLogEntry = DateTime.Now;
                base.AfterActivate();
            }
        }

    }
}
