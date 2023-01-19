namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var enemyTank = new EnemyTank();
            var robotEnemy = new EnemyRobot();

            var robotAdapted = (IEnemyAttack) new EnemyRobotAdapter(robotEnemy);

            Console.WriteLine("==== Robot ====");
            robotEnemy.InteractWithHuman("John");
            robotEnemy.WalkForward();
            robotEnemy.SmashWithHands();

            Console.WriteLine();

            Console.WriteLine("==== Tank ====");
            enemyTank.ToPilot("Willian");
            enemyTank.Move();
            enemyTank.Gunfire();

            Console.WriteLine();

            Console.WriteLine("==== Adapted Robot ====");
            robotAdapted.ToPilot("Stifler");
            robotAdapted.Move();
            robotAdapted.Gunfire();
        }
    }
}