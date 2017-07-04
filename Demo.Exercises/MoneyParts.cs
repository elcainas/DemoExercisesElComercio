using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Exercises
{
    public class MoneyParts
    {
        private readonly List<decimal> Denominations = new List<decimal>{
            200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m, 0.5m, 0.2m, 0.1m, 0.05m
        };
        private List<List<decimal>> ListOfGroups { get; set; }

        public List<List<decimal>> Build(decimal amount)
        {
            ListOfGroups = new List<List<decimal>>();
            GetGroup(amount);
            return ListOfGroups;
        }

        private void GetGroup(decimal amount, decimal coinValue = 0m, List<decimal> group = null)
        {
            coinValue = coinValue == 0m ? Denominations.First() : coinValue;
            group = group == null ? new List<decimal>() : group;
            var indexOfNextCoin = Denominations.IndexOf(coinValue) + 1;
            var multiple = (int)Math.Floor((amount / coinValue));
            var noCoins = multiple;
            do
            {
                var groupAux = new List<decimal>(group);
                for (int y = 0; y < noCoins; y++)
                    groupAux.Add(coinValue);

                if (amount - (coinValue * noCoins) < Denominations.Last() && amount != 0)
                    ListOfGroups.Add(groupAux);

                if (coinValue == Denominations.Last())
                    break;
                GetGroup(amount - (coinValue * noCoins), Denominations[indexOfNextCoin], groupAux);
                noCoins--;
            } while (noCoins >= 0);
        }
    }
}
