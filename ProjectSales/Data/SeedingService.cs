using Microsoft.EntityFrameworkCore.Internal;
using ProjectSales.Models;
using ProjectSales.Models.Enums;
using System;

namespace ProjectSales.Data

{
    public class SeedingService
    {
        private ProjectSalesContext _context;

        public SeedingService(ProjectSalesContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //Db has been seeded 
            }

            Department department1 = new Department(1,"Computers");
            Department department2 = new Department(2, "Electronics");
            Department department3 = new Department(3, "Tools");
            Department department4 = new Department(4, "Camping");

            Seller seller1 = new Seller(1, "Paulo", "paulo@gmail.com", new DateTime(1993, 4, 21), 1200, department1);
            Seller seller2 = new Seller(2, "Maria", "Maria@gmail.com", new DateTime(1998, 6, 2), 1000, department2);
            Seller seller3 = new Seller(3, "Gabriel","gabriel@gmail.com", new DateTime(2001, 1, 25), 1300, department2);
            Seller seller4 = new Seller(4, "Josi", "josi@gmail.com", new DateTime(2002, 11, 13), 1000, department3);
            Seller seller5 = new Seller(5, "Katia", "katia@gmail.com", new DateTime(1988, 11, 15), 1250, department4);
            Seller seller6 = new Seller(6, "Pedro", "pedro@gmail.com", new DateTime(2001, 12, 12), 1100, department2);
            Seller seller7 = new Seller(7, "Carla", "carla@gmail.com", new DateTime(1998, 10, 21), 1100, department3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 10, 12), 1500, SalesStatus.Billed, seller1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 8, 15), 500, SalesStatus.canceled, seller3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 8, 20), 2500, SalesStatus.Billed, seller1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 10, 12), 1850, SalesStatus.Billed, seller4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 11, 5), 150, SalesStatus.canceled, seller5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 11, 10), 2300, SalesStatus.Billed, seller6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 11, 11), 3500, SalesStatus.Billed, seller4);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 11, 11), 300, SalesStatus.Billed, seller2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 11, 20), 1550, SalesStatus.Billed, seller2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 11, 21), 85, SalesStatus.Billed, seller4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 11, 25), 2200, SalesStatus.Billed, seller5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 11, 29), 1580, SalesStatus.Pending, seller6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2022, 12, 04), 1500, SalesStatus.Pending, seller7);

            _context.Department.AddRange(department1, department2, department3, department4);
            _context.Seller.AddRange(seller1, seller2, seller3, seller4, seller5, seller6, seller7);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13);

            _context.SaveChanges();

        }   
    }
}
