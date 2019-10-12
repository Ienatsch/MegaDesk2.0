using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int _surfaceArea;
        //private int MIN_WIDTH = 24;
        //private int MAX_WIDTH = 96;
        //private int MIN_DEPTH = 12;
        //private int MAX_DEPTH = 48;

        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public string SurfaceMaterial { get; set; }
        public int SurfacePrice { get; set; }

        public int GetSurfaceArea()
        {
            CalcSurfaceArea();
            return _surfaceArea;
        }

        public void CalcSurfaceArea()
        {
            _surfaceArea = Depth * Width;
        }
    }
}
