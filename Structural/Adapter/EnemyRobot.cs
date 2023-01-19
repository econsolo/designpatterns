namespace Adapter
{
    public class EnemyRobot
    {
        private readonly Random _generator = new();

        public void SmashWithHands()
        {
            var attackDamage = _generator.Next(10) + 1;
            Console.WriteLine($"Enemy robot did {attackDamage} of damage with Smash with Hands!");
        }

        public void WalkForward()
        {
            var movement = _generator.Next(5) + 1;
            Console.WriteLine($"Enemy robot moved forward {movement} meters!");
        }

        public void InteractWithHuman(string pilot)
        {
            Console.WriteLine($"Enemy robot will interact with its pilot: {pilot}!");

        }
    }
}
