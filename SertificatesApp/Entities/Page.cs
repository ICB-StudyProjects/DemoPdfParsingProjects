namespace SertificatesApp.Entities
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Drawing;

    public class Page
    {
        private readonly ICollection<Rectangle> coordinates;

        [JsonConstructor]
        public Page(int id, IList<Coordinate> coordinates)
        {
            this.Id = id;
            this.coordinates = new HashSet<Rectangle>();

            ParseCoordinates(coordinates);
        }

        public int Id { get; set; }
        public IEnumerable<Rectangle> Coordinates => this.coordinates;

        private void ParseCoordinates(IList<Coordinate> coords)
        {
            foreach (Coordinate coord in coords)
            {
                Point point = new Point(coord.X, coord.Y);
                Size size = new Size(coord.W, coord.H);
                Rectangle rect = new Rectangle(point, size);

                this.coordinates.Add(rect);
            }
        }
    }
}
