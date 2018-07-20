namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;

    public struct Coordinate
    {
        public int X, Y, W, H;

        [JsonConstructor]
        public Coordinate(int x, int y, int w, int h)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
        }
    }
}
