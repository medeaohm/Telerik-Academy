using System.Collections.Generic;

namespace Flyweight
{
    public class MoneyFactory
    {
        public static int ObjectsCount = 0;
        private Dictionary <EnMoneyType, IMoney> moneyObjects;
        public IMoney GetMoneyToDisplay(EnMoneyType form) // Same as GetFlyWeight()
        {
            if (moneyObjects == null)
            {
                moneyObjects = new Dictionary<EnMoneyType, IMoney>();
            }

            if (moneyObjects.ContainsKey(form))
            {
                return moneyObjects[form];
            }
               
            switch (form)
            {
                case EnMoneyType.Metallic:
                    moneyObjects.Add(form, new MetallicMoney());
                    ObjectsCount++;
                break;
                case EnMoneyType.Paper:
                    moneyObjects.Add(form, new PaperMoney());
                    ObjectsCount++;
                break;
                default:
                break;
            }
            return moneyObjects[form];
        }
    }
}
