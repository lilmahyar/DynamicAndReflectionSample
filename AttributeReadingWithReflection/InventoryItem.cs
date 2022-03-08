
namespace AttributeReadingWithReflection
{
    public class InventoryItem
    {
        [Coulmn("Part #")]
        public string PartNumber { get; set; }
        [Coulmn("Name")]
        public string Description { get; set; }
        [Coulmn("Amount")]
        public int Count { get; set;  }
        [Coulmn("Price")]
        public decimal ItemPrice { get; set;  }
        [Coulmn("Total")]
        public decimal CalculateTotal() 
        {
            return ItemPrice * Count; 
        }
    }
}
