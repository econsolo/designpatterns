namespace Builder
{
    public interface ISmartPhone
    {
        void BuildScreen();
        void BuildBattery();
        void BuildSystem();
        void BuildCamera();

        SmartPhone SmartPhone { get; }
    }
}
