namespace CatLady
{
    public class Siamese : Cat
    {
        private int earSize;

        public Siamese(string name, int earSize)
            : base(name)
        {
            this.earSize = earSize;
        }

        public override string ToString()
        {
            return $"Siamese {base.Name} {this.earSize}";
        }
    }
}