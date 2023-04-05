

using AdapterDesignPatternTask;

EnemyTank enemyTank = new EnemyTank();

enemyTank.Weapon();


EnemyRobot enemyRobot = new EnemyRobot();


AdapterRobot adapter = new(enemyRobot);

adapter.Weapon();

