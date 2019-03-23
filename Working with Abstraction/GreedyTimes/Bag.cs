using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyTimes
{
    public class Bag
    {
        private List<Item> bag;
        private long capacity;
        private long current;

        public Bag(long capacity)
        {
            this.capacity = capacity;
            bag = new List<Item>();
        }

        public long GoldItemValue
        {
            get
            {
                return bag.Where(i => i is GoldItem).Sum(i => i.Value);
            }
        }

        public long CashItemValue
        {
            get
            {
                return bag.Where(i => i is CashItem).Sum(i => i.Value);
            }
        }

        public long GemItemValue
        {
            get
            {
                return bag.Where(i => i is GemItem).Sum(i => i.Value);
            }
        }

        public void AddGoldItem(GoldItem item)
        {
            if (capacity >= current + item.Value)
            {
                var goldItems = GetGoldItems();

                if (goldItems.Any(gi => gi.Key == item.Key))
                {
                    goldItems.Single(gi => gi.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    bag.Add(item);
                }

                current += item.Value;
            }
        }

        public void AddGemItem(GemItem item)
        {
            if (capacity >= current + item.Value &&  GoldItemValue >= GemItemValue + item.Value)
            {
                var gemItems = GetGemItems();
                if (gemItems.Any(gi => gi.Key == item.Key))
                {
                    gemItems.Single(gi => gi.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    bag.Add(item);
                }
                current += item.Value;
            }
        }

        public void AddCashItem(CashItem item)
        {
            if (capacity >= current + item.Value && GemItemValue >= CashItemValue + item.Value )
            {
                var cashItem = GetCashItem();

                if (cashItem.Any(gi => gi.Key == item.Key))
                {
                    cashItem.Single(gi => gi.Key == item.Key).IncreaseValue(item.Value);
                }
                else
                {
                    bag.Add(item);
                }

                current += item.Value;
            }
        }

        private List<Item> GetCashItem()
        {
            return bag.Where(i => i is CashItem).ToList();
        }

        private List<Item> GetGemItems()
        {
            return bag.Where(i => i is GemItem).ToList();
        }

        private List<Item> GetGoldItems()
        {
            return bag.Where(i => i is GoldItem).ToList();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            var dictionary = bag.GroupBy(i => i.GetType().Name)
                .ToDictionary(g => g.Key, g => g.ToList());

            foreach (var kvp in dictionary.OrderByDescending(kv => kv.Value.Sum(i => i.Value)))
            {
                if (kvp.Key == "CashItem")
                {
                    builder.AppendLine($"<Cash> ${kvp.Value.Sum(i => i.Value)}");
                }
                else if (kvp.Key == "GemItem")
                {
                    builder.AppendLine($"<Gem> ${kvp.Value.Sum(i => i.Value)}");
                }
                else if (kvp.Key == "GoldItem")
                {
                    builder.AppendLine($"<Gold> ${kvp.Value.Sum(i => i.Value)}");
                }

                foreach (var item in kvp.Value.OrderByDescending(i => i.Key).ThenBy(i => i.Value))
                {
                    builder.AppendLine($"##{item.Key} - {item.Value}");
                }
            }

            return builder.ToString().TrimEnd();
        }
    }
}
