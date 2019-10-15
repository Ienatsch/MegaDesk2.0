using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk
{
    class DeskQuote : Desk
    {
        private const int BasePrice = 200;
        private const int PricePerDrawer = 50;
        private const int MaxUnchargedDeskArea = 1000;

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
            decimal totalPrice = BasePrice + (NumDrawers * PricePerDrawer) + SurfacePrice + RushOrderPrice;
            if (SurfaceArea > MaxUnchargedDeskArea)
            {
                totalPrice += SurfaceArea - MaxUnchargedDeskArea;
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

        public List<DeskQuote> GetAllQuotes()
        {
            StreamReader sr = new StreamReader("quotes.json");
            List<DeskQuote> allQuotes = new List<DeskQuote>();

            while (!sr.EndOfStream)
            {
                allQuotes.Add(JsonConvert.DeserializeObject<DeskQuote>(sr.ReadLine()));
            }

            return allQuotes;
        }
    }
}
