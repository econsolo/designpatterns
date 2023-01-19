namespace Adapter
{
    public class EnemyRobotAdapter : IEnemyAttack
    {
        private readonly EnemyRobot _enemyRobot;

        public EnemyRobotAdapter(EnemyRobot enemyRobot)
        {
            _enemyRobot = enemyRobot;
        }

        public void Gunfire()
        {
            _enemyRobot.SmashWithHands();
        }

        public void Move()
        {
            _enemyRobot.WalkForward();
        }

        public void ToPilot(string pilot)
        {
            _enemyRobot.InteractWithHuman(pilot);
        }
    }
}
