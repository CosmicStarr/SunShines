namespace Infrastructure.Models
{
    public class CartItems
    {
        public int CartItemsId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
        public string itemImageUrl { get; set; }
        public string ItemBrand { get; set; }
        public string itemCategory { get; set; }
    }
}