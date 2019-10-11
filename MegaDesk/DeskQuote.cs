using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote : Desk
    {
        private string _customerName;
        private bool _rushOrder;
        private int _rushOrderTime;
        private int _rushOrderPrice;
        private decimal _totalPrice;

        public string GetCustomerName()
        {
            return _customerName;
        }

        public void SetCustomerName(string customerName)
        {
            _customerName = customerName;
        }

        public bool GetRushOrder()
        {
            return _rushOrder;
        }

        public void SetRushOrder(bool isRushOrder)
        {
            _rushOrder = isRushOrder;
        }

        public int GetRushOrderTime()
        {
            return _rushOrderTime;
        }

        public void SetRushOrderTime(int rushOrderTime)
        {
            _rushOrderTime = rushOrderTime;
        }

        public int GetRushOrderPrice()
        {
            CalcRushOrderPrice();
            return _rushOrderPrice;
        }

        public void CalcRushOrderPrice()
        {
            var surfaceArea = GetSurfaceArea();
            bool isSmallDesk = surfaceArea < 1000;
            bool isMedDesk = surfaceArea >= 1000 && surfaceArea <= 2000;
            bool isLargeDesk = surfaceArea > 2000;

            switch (_rushOrderTime)
            {
                case 3:
                    if (isSmallDesk)
                    {
                        _rushOrderPrice = 60;
                    }
                    else if (isMedDesk)
                    {
                        _rushOrderPrice = 70;
                    }
                    else
                    {
                        _rushOrderPrice = 80;
                    }

                    break;
                case 5:
                    if (isSmallDesk)
                    {
                        _rushOrderPrice = 40;
                    }
                    else if (isMedDesk)
                    {
                        _rushOrderPrice = 50;
                    }
                    else
                    {
                        _rushOrderPrice = 60;
                    }

                    break;
                case 7:
                    if (isSmallDesk)
                    {
                        _rushOrderPrice = 30;
                    }
                    else if (isMedDesk)
                    {
                        _rushOrderPrice = 35;
                    }
                    else
                    {
                        _rushOrderPrice = 40;
                    }

                    break;
            }
        }

        public decimal GetTotalPrice()
        {
            return _totalPrice;
        }

        public void CalcTotalPrice()
        {
            _totalPrice = 200 + (GetNumDrawers() * 50) + GetSurfacePrice() + _rushOrderPrice;
            if (GetSurfaceArea() > 1000)
            {
                _totalPrice += GetSurfaceArea() - 1000;
            }
        }
    }
}
