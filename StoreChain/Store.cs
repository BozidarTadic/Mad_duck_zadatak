using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreChain
{
    public class Store
    {
        private  string name { get; set; }
        private string storeType { get; set; }
        public List<Products> products = new List<Products>();
        private List<Bill> bills = new List<Bill>();

        public Store(string name,string StoreType ) 
        {
            this.name = name; 
            this.storeType = StoreType;
            this.products = CreateListOfProdycts();
        }

        
        private List<Products> CreateListOfProdycts()
        {
            List<Products> products = new List<Products>();
            if (storeType == "corner shop")
            {
                
                Products products1 = new Products();
                products1.Name = "parking tickets";
                products1.Amounth = 10;
                products1.Price = 1.00M;
                products.Add(products1);

                Products products2 = new Products();
                products2.Name = "cigarettes";
                products2.Amounth = 200;
                products2.Price = 5.00M;
                products.Add(products2);

                Products products3 = new Products();
                products3.Name = "drink";
                products3.Amounth = 20;
                products3.Price = 1.50M;
                products.Add(products3);
            }
            if(storeType == "supermarket")
            {
                products = new List<Products>();

                Products products1 = new Products();
                products1.Name = "food";
                products1.Amounth = 10;
                products1.Price = 1.00M;
                products.Add(products1);

                Products products2 = new Products();
                products2.Name = "cigarettes";
                products2.Amounth = 200;
                products2.Price = 5.00M;
                products.Add(products2);

                Products products3 = new Products();
                products3.Name = "drink";
                products3.Amounth = 20;
                products3.Price = 1.50M;
                products.Add(products3);
            }
            if(storeType == "pharmacy")
            {
                products = new List<Products>();

                Products products1 = new Products();
                products1.Name = "toys";
                products1.Amounth = 10;
                products1.Price = 1.00M;
                products.Add(products1);

                Products products2 = new Products();
                products2.Name = "medicine";
                products2.Amounth = 200;
                products2.Price = 5.00M;
                products.Add(products2);

                Products products3 = new Products();
                products3.Name = "drink";
                products3.Amounth = 20;
                products3.Price = 1.50M;
                products.Add(products3);

            }
            return products;
        }

        public List<Products> GetProducts()
        {
            return products;
        }
        public string GetName()
        {
            return name;
        }
        public string GetStoreType()
        {
            return storeType;
        }
        public Bill GetNewBill(string FirstName , string LastName , string telephone)
        {
            Bill bill = new Bill();

            bill.firstName = FirstName;
            bill.lastName = LastName;
            bill.telephone = telephone;

           
            
                    
            return bill;
        }
        public Bill AddProtuctToBill(Bill bill, Products product)
        {
            var pr = products.Where(p => product.Name == product.Name).FirstOrDefault();
            if (product.Name == "medicine" && product.Name == "parking tickets")
            {
                bill.serialNumber.Add(DateTime.Now.ToString());
            }
            if(product.Amounth > pr.Amounth)
            {
                return null;
            }

            bill.products.Add(product);

            return bill;
        }
        public void FinishBill(Bill bill)
        {
            foreach(var product in bill.products)
            {
                var pr = products.Where(p => product.Name == product.Name).FirstOrDefault().Amounth -= product.Amounth;
            }
            bills.Add(bill);
        }
    }
}
