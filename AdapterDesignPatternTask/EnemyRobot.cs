using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternTask
{
	internal class EnemyRobot
	{
		private int damageRobot = 5;

		public void smashHands()
		{
			Console.WriteLine($"Robot damage {damageRobot}");
		}
	}
}
