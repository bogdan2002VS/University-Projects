using Logic.Account.Model;

namespace Logic.Order.Model
{
    public class CartModel
    {
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();

        public BonusCardModel BonusCard { get; set; }
        public double TotalPrice
        {
            get
            {
                if(BonusCard != null && BonusCard.BonusPointsToApply != 0)
                {
                    var discountToApply = BonusCard.BonusPointsToApply / 100d;
                    return Items.Sum(item => item.Product.Price * item.Quantity) - discountToApply;
                }
                return Items.Sum(item => item.Product.Price * item.Quantity);

            }
        }
    }
}
