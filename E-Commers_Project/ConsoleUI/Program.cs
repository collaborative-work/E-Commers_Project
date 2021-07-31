﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.NpgSql;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandDalTest();
            //ColorDalTest();
            //ProductDalTest();
            //CategoryDalTest();

            IProductService productService = new ProductManager(new NSProductDal());
            List<Product> products = new List<Product>();
           products= productService.List();

            foreach (var p in products)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        private static void BrandDalTest()
        {
            NSBrandDal nSBrandDal = new NSBrandDal();
            string query = "select*from brands";
            DataSet dataSet = new DataSet();
            dataSet = nSBrandDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["brand_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["brand_name"].ToString());
           

             }

        }
        private static void CategoryDalTest()
        {
            NSCategoryDal nSPCategoryDal = new NSCategoryDal();
            string query = "select*from categories";
            DataSet dataSet = new DataSet();
            dataSet = nSPCategoryDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["category_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["category_name"].ToString());
                Console.WriteLine();

            }
        }
        private static void ColorDalTest()
        {
            NSColorDal nSColorDal = new NSColorDal();
            string query = "select*from colors";
            DataSet dataSet = new DataSet();
            dataSet = nSColorDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["color_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["color_name"].ToString());
                Console.WriteLine();
            }
        }

        private static void ProductDalTest()
        {
            NSProductDal nSProductDal = new NSProductDal();
            string query = "select*from products";
            DataSet dataSet = new DataSet();
            dataSet = nSProductDal.List(query);

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Console.Write(dataSet.Tables[0].Rows[i]["product_id"].ToString());

                Console.Write(dataSet.Tables[0].Rows[i]["product_name"].ToString());
                Console.WriteLine();
            }
        }

            

        }

       

    
}
