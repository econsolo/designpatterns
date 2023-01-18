namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICharacter ChooseCharacter(string character)
        {
            switch (character)
            {
                case nameof(Goku):
                    return new Goku();
                case nameof(Vegeta):
                    return new Vegeta();
                case nameof(Gohan):
                    return new Gohan();
                case nameof(Trunks):
                    return new Trunks();
                default:
                    return null;
            }
        }
    }
}
