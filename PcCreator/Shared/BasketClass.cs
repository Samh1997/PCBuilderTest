namespace PcCreator.Shared
{
    public class BasketClass
    {
        Dictionary<PCItem, int> basket = new Dictionary<PCItem, int>();



       /* public void AddBasketItem(PCItem pcItem)
        {
            bool keyExists = basket.ContainsKey(pcItem);
            if (keyExists)
            {
                basket[pcItem]++;
            }
            else
                basket.Add(pcItem, 1);
        }
*/
    }
}
