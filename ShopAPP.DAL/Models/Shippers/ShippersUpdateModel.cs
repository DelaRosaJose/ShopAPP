﻿using ShopAPP.DAL.Core;

namespace ShopAPP.DAL.Models.Shippers
{
    public class ShippersUpdateModel : BaseUpdateModel
    {
        public int ShipperId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
