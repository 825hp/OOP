using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
namespace ObjectOrientedPractics.Model.Discounts
{
    internal class PercentDiscount: IDiscount
    {
        private double _discount;
        private Category _category;
        private double _spentInCategory;

        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {Discount * 100}%";
            }
        }
        public double Discount
        {
            get { return _discount; }
            set
            {
                if (value > 0.1)
                {
                    throw new Exception($"{value} > 10");
                }
                _discount = value;
            }
        }
        public Category Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public double SpentInCategory
        {
            get { return _spentInCategory; }

            set
            {
                _spentInCategory = value;
            }
        }

        public double Calculate(List<Item> items)
        {
            double totalDiscount = 0;
            foreach (var item in items)
            {
                if (item.CategoryOfItem == Category)
                {
                    totalDiscount += item.Cost * Discount;
                }
            }
            return totalDiscount;
        }
        public double Apply(List<Item> items)
        {
            foreach (var item in items)
            {
                if (item.CategoryOfItem == Category)
                {
                    //item.Cost = (float)(item.Cost*(1- Discount));
                    SpentInCategory = SpentInCategory + item.Cost;
                }
            }

            return Calculate(items);
        }
        public void Update(List<Item> items)
        {
            if (SpentInCategory % 1000 >= 1 && SpentInCategory % 1000 < 10)
            {
                Discount = SpentInCategory % 100000;
            }
        }

        public PercentDiscount(Category category)
        {
            Discount = 0.01;
            Category = category;
            SpentInCategory = 0;
        }

        public int CompareTo(PercentDiscount other)
        {
            if (other == null)
                return 1;

            return this.Discount.CompareTo(other.Discount);
        }

    }
}
