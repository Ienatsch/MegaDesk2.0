using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote : Desk
    {
        public string Name { get; set; }
        public bool RushOrder { get; set; }
        public int RushOrderTime { get; set; }
        public int RushOrderPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public int CalcRushOrderPrice()
        {
            var surfaceArea = SurfaceArea;
            int rushOrderPrice = 0;
            bool isSmallDesk = surfaceArea < 1000;
            bool isMedDesk = surfaceArea >= 1000 && surfaceArea <= 2000;
            int[,] rushOrderPrices = GetRushOrderPrices();

            switch (RushOrderTime)
            {
                case 3:
                    if (isSmallDesk)
                    {
                        rushOrderPrice = rushOrderPrices[0,0];
                    }
                    else if (isMedDesk)
                    {
                        rushOrderPrice = rushOrderPrices[0, 1];
                    }
                    else
                    {
                        rushOrderPrice = rushOrderPrices[0, 2];
                    }

                    break;
                case 5:
                    if (isSmallDesk)
                    {
                        rushOrderPrice = rushOrderPrices[1, 0];
                    }
                    else if (isMedDesk)
                    {
                        rushOrderPrice = rushOrderPrices[1, 1];
                    }
                    else
                    {
                        rushOrderPrice = rushOrderPrices[1, 2];
                    }

                    break;
                case 7:
                    if (isSmallDesk)
                    {
                        rushOrderPrice = rushOrderPrices[2, 0];
                    }
                    else if (isMedDesk)
                    {
                        rushOrderPrice = rushOrderPrices[2, 1];
                    }
                    else
                    {
                        rushOrderPrice = rushOrderPrices[2, 2];
                    }

                    break;
            }

            return rushOrderPrice;
        }

        public decimal CalcTotalPrice()
        {
            decimal totalPrice = 200 + (NumDrawers * 50) + SurfacePrice + RushOrderPrice;
            if (SurfaceArea > 1000)
            {
                totalPrice += SurfaceArea - 1000;
            }

            return totalPrice;
        }

        public int[,] GetRushOrderPrices()
        {
            int[,] rushPrices = new int[3, 3];

            StreamReader sw = new StreamReader(Directory.GetCurrentDirectory() + "../rushOrderPrices.txt");
            int i = 0, j = 0;
            while (!sw.EndOfStream)
            {
                while (i < 3)
                {
                    while (j < 3)
                    {
                        int rushPrice = int.Parse(sw.ReadLine());
                        rushPrices[i, j] = rushPrice;
                        j++;
                    }

                    j = 0;
                    i++;
                }
            }
            sw.Close();
            return rushPrices;
        }     
    }
}
