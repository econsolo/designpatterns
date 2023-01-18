namespace Builder
{
    public class Manufacturer
    {
        public void CreateSmartPhone(ISmartPhone smartPhoneBuilder)
        {
            smartPhoneBuilder.BuildBattery();
            smartPhoneBuilder.BuildScreen();
            smartPhoneBuilder.BuildCamera();
            smartPhoneBuilder.BuildSystem();
        }
    }
}
