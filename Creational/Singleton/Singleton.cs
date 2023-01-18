namespace Singleton
{
    public static class Singleton
    {
        private static Ball ball;

        public static Ball Ball
        {
            get
            {
                ball ??= new Ball("Fevernova");
                return ball;
            }
        }
    }
}
