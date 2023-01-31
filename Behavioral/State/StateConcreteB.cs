namespace State
{
    public class StateConcreteB : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateConcreteA();
        }
    }
}
