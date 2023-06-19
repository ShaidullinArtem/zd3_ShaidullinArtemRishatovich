namespace zd3_Shaidullin.types
{
    public class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int SalesCount { get; set; }
        public double SalesTotal { get; set; }

        public Shop(string name, string address, int salesCount, double salesTotal)
        {
            Name = name; 
            Address = address; 
            SalesCount = salesCount; 
            SalesTotal = salesTotal;
        }
        
        public double Q() // receives revenue for the month
        {
            return SalesTotal / SalesCount;
        }
        
        public string getInfo()
        {
            double q = Q();
            return $"{Name} (${Address}) заработал ${q} продав товаров: ${SalesCount} на общую сумму: ${SalesTotal}";
        }
    }
}