﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;
using System.Windows.Forms;


namespace ChapeauLogic
{
    public class TablesServices
    {
        TablesDAO tabledao = new TablesDAO();
        List<Tables> tablesservices = new List<Tables>();
        List<Order> orderservice = new List<Order>();

        public List<Tables> GetALLTables()
        {
            try
            {
                tablesservices = tabledao.GetALLTables();
                return tablesservices;
            }
            catch (Exception)
            {
                throw new Exception("something went wrong connecting to the database");
            }
        }
        public void Updatetable(Tables table)
        {
            try
            {
                tabledao.UpdateTableStatus(table);
            }
            catch (Exception)
            {
                throw new Exception("something went wrong connecting to the database");
            }

           
        }
        public List<Order> GetAllOrders(Order order)
        {
            try
            {
                orderservice = tabledao.ReadAllOrders(order);
                return orderservice;
            }
            catch (Exception)
            {
                throw new Exception("something went wrong connecting to the database");           
            }
        }

    }
}
