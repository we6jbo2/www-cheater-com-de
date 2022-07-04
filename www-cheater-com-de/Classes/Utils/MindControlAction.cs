using WwwCheaterComDe.Punishments;
using SharpDX;

using www_cheater_com_de; /*621553*/ namespace WwwCheaterComDe.Utils
{
    class MindControlAction
    {
        public Vector3 AimLockAtWorldPoint { get; set; }
        public int AimLockDuration { get; set; } = 3000;
        public string ConsoleCommand { get; set; } = "";
        public int Sleep { get; set; } = 0;
    }
}
