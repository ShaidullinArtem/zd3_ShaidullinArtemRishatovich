using System;

namespace zd3_Shaidullin.types
{
    public class Stall : Shop
    {
        
        public int P;
        public string DaySpProduct { get; set; }
        public string HitProduct { get; set; }

        public Stall(string name, string address, int salesCount, double salesTotal, int p, string daySpProduct, string hitProduct)
            : base(name, address, salesCount, salesTotal)
        {
            P = p;
            DaySpProduct = daySpProduct;
            HitProduct = hitProduct;
        }
        
        public double Qp()
        {
            double q = Q();
            return P > 50_000 ? 2 * q : 0.5 * q;
        }
    }
}