using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Arrays_Indexes_task2
{
    public class Store
    {
        private Article[] _articles;

        public Store(int quantity)
        {
            _articles = new Article[quantity];
            _articles[0] = new Article("tel", "Apple", 9000);
            _articles[1] = new Article("monitor", "Apple", 8000);
            _articles[2] = new Article("notebook", "Dell", 5600);
        }

        public Article this[int index]
        {
            get { return _articles[index]; }
        }

        public Article this[string name]
        {
            get 
            {
                for (int i = 0; i < _articles.Length; i++)
                {
                    if (_articles[i].ProductName == name)
                    { 
                        return _articles[i]; 
                    }
                }
                throw new IndexOutOfRangeException("There is no such productName");
            }
        }
    }
}
