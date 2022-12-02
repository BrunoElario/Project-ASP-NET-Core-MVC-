﻿using ProjectSales.Models.Enums;
using System;

namespace ProjectSales.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int MyProperty { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, int myProperty, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            MyProperty = myProperty;
            Status = status;
            Seller = seller;
        }
    }
}
