using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorfDemo
{
    class Product
    {


        private int _productNumber;

        public int ProductNumber
        {
            get { return _productNumber; }
            set { _productNumber = value; }
        }

        private int _stockStatus;

        public int StockStatus
        {
            get { return _stockStatus; }
            set { _stockStatus = value; }
        }



    }
}
