﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Lab_13._2.Models;

namespace Lab_13._2.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=CoffeeShop;user id=CoffeeShopUser;password=password");
			database.Open();
			List<string> productCategories = database.Query<string>("select distinct Category from Product order by Category desc").AsList<string>();
			database.Close();

			return View(productCategories);
		}
	
		public IActionResult Products(string category)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=CoffeeShop;user id=CoffeeShopUser;password=password");
			database.Open();
			List<Product> products = database.Query<Product>($"select * from Product where Category = '{category}' order by Name").AsList<Product>();
			database.Close();

			return View(products);
		}

		public IActionResult ProductInfo(int productID)
		{
			IDbConnection database = new SqlConnection("Server=BCKW433\\SQLEXPRESS;Database=CoffeeShop;user id=CoffeeShopUser;password=password");
			database.Open();
			Product product = database.QuerySingle<Product>($"select * from Product where ID = {productID}");
			database.Close();

			return View(product);
		}
	}
}
