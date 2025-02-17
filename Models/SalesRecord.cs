﻿using SiteVendasMVC.Models.Enums;
using System;

namespace SiteVendasMVC.Models {
    public class SalesRecord {
        public int id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        public SaleStatus status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller) {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
}
