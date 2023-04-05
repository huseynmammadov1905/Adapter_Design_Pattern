using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternTask
{
	internal class AdapterRobot : IEnemyAttacker
	{
		EnemyRobot EnemyRobot { get; set; }
		public AdapterRobot(EnemyRobot enemyRobot)
		{
			EnemyRobot = enemyRobot;
		}
		public void Weapon()
		{
			EnemyRobot.smashHands();
		}
	}
}
