namespace Builder
{
    public class IphoneBuilder : ISmartPhone
    {
        private SmartPhone _smartPhone;

        public IphoneBuilder()
        {
            _smartPhone = new SmartPhone("iPhone");
        }

        public SmartPhone SmartPhone => _smartPhone;

        public void BuildBattery()
        {
            _smartPhone.Battery = "3300mah";
        }

        public void BuildCamera()
        {
            _smartPhone.Camera = "48 MP";
        }

        public void BuildScreen()
        {
            _smartPhone.Screen = "6 inches";
        }

        public void BuildSystem()
        {
            _smartPhone.System = "iOS 16";
        }
    }
}
