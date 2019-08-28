namespace InterfaceImplementation
{
    class Triangle : IShape
    {
        double tBase;
        double tHeight;

        public Triangle()
        {

        }
        public Triangle(double tbase, double theight)
        {
            tBase = tbase;
            tHeight = theight;
        }
        public double TBase { get => tBase; set => tBase = value; }
        public double THeight { get => tHeight; set => tHeight = value; }

        public double CalculateArea()
        {
            return 0.5 * tBase * tHeight;
        }
    }
}
