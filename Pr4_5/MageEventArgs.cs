using System;

namespace MageBattle
{
    public class MageEventArgs : EventArgs
    {
        public Mage Attacker { get; }
        public Mage Defender { get; }
        public int Damage { get; }

        public MageEventArgs(Mage attacker, Mage defender)
        {
            Attacker = attacker;
            Defender = defender;
            Damage = 0;
        }

        public MageEventArgs(Mage defender, int damage)
        {
            Defender = defender;
            Damage = damage;
            Attacker = null;
        }
    }
}
