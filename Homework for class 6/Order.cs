﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace project1
{
    [Serializable]
    public class Order //订单
    {
        public int id { get; set; }  //订单号
        public string client { get; set; }  //客户
        public int sum { get; set; }  //总价格
        List<OrderItem> orderItem = new List<OrderItem>();
        public Order() { }
        public Order(int i, string c, List<OrderItem> list)
        {
            id = i; client = c;
            orderItem = list;
            foreach (OrderItem ordItem in orderItem)
            {
                sum = sum + ordItem.Num * ordItem.price;
            }
        }
        public override bool Equals(object obj)
        {
            Order ord = obj as Order;
            return ord != null && ord.id == id && ord.client == client;
        }
        public override string ToString()
        {
            Console.WriteLine("订单号为" + id + "," + "客户名为" + client + "订单总价为" + sum);
            foreach (OrderItem ordItem in orderItem)
            {
                Console.WriteLine(ordItem.ToString());
            }
            return "---------------";
        }
    }
}
