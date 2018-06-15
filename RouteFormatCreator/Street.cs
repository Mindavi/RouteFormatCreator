namespace RouteFormatCreator
{
    public class Street
    {
        private string name;
        private Range range;
        private Direction direction;

        public Street(string name, Range range, Direction direction)
        {
            this.name = name;
            this.range = range;
            this.direction = direction;
        }

        public override string ToString()
        {
            return $"{name},{range},{direction}";
        }
    }
}
