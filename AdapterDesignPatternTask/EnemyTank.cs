using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternTask
{
	internal class EnemyTank : IEnemyAttacker
	{
		private int damageTank = 10;
		public void Weapon()
		{
			Console.WriteLine($"Tank damage {damageTank} ");
		}
	}
}
