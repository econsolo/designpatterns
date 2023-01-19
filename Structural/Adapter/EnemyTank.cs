namespace Adapter
{
    public class EnemyTank : IEnemyAttack
    {
        private readonly Random _generator = new();

        public void Gunfire()
        {
            var attackDamage = _generator.Next(10) + 1;
            Console.WriteLine($"Enemy tank did {attackDamage} of damage!");
        }

        public void Move()
        {
            var movement = _generator.Next(5) + 1;
            Console.WriteLine($"Enemy tank moved {movement} meters!");
        }

        public void ToPilot(string pilot)
        {
            Console.WriteLine($"{pilot} are in charge!");
        }
    }
}
