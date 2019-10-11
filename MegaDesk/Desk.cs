using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    enum SurfaceMaterial
    {
        Pine = 50,
        Laminate = 100,
        Veneer = 125,
        Oak = 200,
        Rosewood = 300

    };

    class Desk
    {
        private int _width;
        private int _depth;
        private int _numDrawers;
        private int _surfaceArea;
        private string _surfaceMaterial;
        private int _surfacePrice;
        private int MIN_WIDTH = 24;
        private int MAX_WIDTH = 96;
        private int MIN_DEPTH = 12;
        private int MAX_DEPTH = 48;

        public int GetWidth()
        {
            return _width;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public int GetDepth()
        {
            return _depth;
        }

        public void SetDepth(int depth)
        {
            _depth = depth;
        }

        public int GetNumDrawers()
        {
            return _numDrawers;
        }

        public void SetNumDrawers(int numDrawers)
        {
            _numDrawers = numDrawers;
        }

        public string GetSurfaceMaterial()
        {
            return _surfaceMaterial;
        }

        public void SetSurfaceMaterial(string surfaceMaterial)
        {
            _surfaceMaterial = surfaceMaterial;
            SetSurfacePrice();
        }

        public int GetSurfacePrice()
        {
            return _surfacePrice;
        }

        public void SetSurfacePrice()
        {
            if (Enum.TryParse(_surfaceMaterial, out SurfaceMaterial material))
            {
                _surfacePrice = (int)material;
            }
        }

        public int GetSurfaceArea()
        {
            CalcSurfaceArea();
            return _surfaceArea;
        }

        public void CalcSurfaceArea()
        {
            _surfaceArea = GetDepth() * GetWidth();
        }
    }
}
