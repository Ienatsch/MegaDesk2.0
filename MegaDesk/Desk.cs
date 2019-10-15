
namespace MegaDesk
{
    enum SurfaceMaterials
    {
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300

    };

    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public string SurfaceMaterial { get; set; }
        public int SurfacePrice { get; set; }
        public int SurfaceArea { get; set; }

        public int CalcSurfaceArea()
        {
            return Depth * Width;
        }
    }
}
