namespace State
{
    public class StateConcreteA : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateConcreteB();
        }
    }
}
