using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Arrays_Indexes_task2
{
    public class Article
    {
        private string _productName;
        private string _storeName;
        private double _price;

        public Article(string productName, string storeName, double price)
        {
            _productName = productName;
            _storeName = storeName;
            _price = price;
        }

        public string ProductName
        {
            get { return _productName; }
        }

        public string StoreName
        {
            get { return _storeName; }
        }

        public double Price
        {
            get { return _price; }
        }
    }
}
