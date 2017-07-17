namespace CatLady
{
    public class StreetExtraordinaire : Cat
    {
        private int decibelsOfMeows;

        public StreetExtraordinaire(string name, int decibelsOfMeows)
            : base(name)
        {
            this.decibelsOfMeows = decibelsOfMeows;
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {base.Name} {this.decibelsOfMeows}";
        }
    }
}