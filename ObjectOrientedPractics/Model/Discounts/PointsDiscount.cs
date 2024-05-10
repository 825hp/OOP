using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    internal class PointsDiscount: IDiscount
    {
        private int _amountOfPoints;
        public string Info
        {
            get
            {
                return $"Накопительная – {GetAmount} баллов";
            }
        }
        public int GetAmount
        { 
            get
            {
                return _amountOfPoints;
            }
        }
        private int SetAmount
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception($"{value} < 0");
                }
                _amountOfPoints = value;
            }
        }
        public double Calculate(List<Item> items)
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            double maxSale = totalCost * 0.30;
            if (maxSale <= GetAmount)
            {
                return maxSale;
            }
            else
            {
                return GetAmount;
            }
        }
        public double Apply(List<Item> items)
        {
            double sale = Calculate(items);
            double saleForItem = sale / items.Count;
            foreach (var item in items)
            {
                item.Cost = (float)(item.Cost - saleForItem);
            }
            SetAmount = GetAmount - (int)sale;
            return sale;
        }
        public void Update(List<Item> items)
        {
            foreach (var item in items)
            {
                SetAmount = GetAmount + (int)(item.Cost * 0.10);
            }
        }

        public PointsDiscount()
        {
            SetAmount = 0;
        }
    }
}
