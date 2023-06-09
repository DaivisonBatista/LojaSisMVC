﻿using System.Collections.Generic;
using System;
using System.Linq;
namespace LojaSisMVC.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departments() 
        {
        }

        public Departments(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime incial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(incial, final));
        }
    }
}
