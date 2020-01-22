using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyShop1.Core
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgPath { get; set; }
        public bool Selected { get; set; }
    }
}
