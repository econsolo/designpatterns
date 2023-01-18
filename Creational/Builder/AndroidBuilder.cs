namespace Builder
{
    public class AndroidBuilder : ISmartPhone
    {
        private SmartPhone _smartPhone;

        public AndroidBuilder()
        {
            _smartPhone = new SmartPhone("Android");
        }

        public SmartPhone SmartPhone => _smartPhone;

        public void BuildBattery()
        {
            _smartPhone.Battery = "4000mah";
        }

        public void BuildCamera()
        {
            _smartPhone.Camera = "12 MP";
        }

        public void BuildScreen()
        {
            _smartPhone.Screen = "7 inches";
        }

        public void BuildSystem()
        {
            _smartPhone.System = "Android 12";
        }
    }
}
