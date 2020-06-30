using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {
        OrderDAO orderdao = new OrderDAO();

        public List<Order> GetOrders(MenuItemType type)
        {
            try
            {
                List<Order> orders = orderdao.GetAllOrders(type);
                return orders;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public List<OrderItem> GetOrderItems(int id, MenuItemType type)
        {
            try
            {
                List<OrderItem> orders = orderdao.GetKitchenBarItems(id, type);
                return orders;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public int WriteOrder(Order order, Table table) // make it a boolean
        {
            try
            {
                TablesDAO tabledao = new TablesDAO();
                table.Status = TableStatus.Occupied; // change table state to occupied
                tabledao.UpdateTableStatus(table); // update table state
                int row = this.orderdao.WriteOrder(order); // write order


                int orderID = this.orderdao.GetLastOrderID();
                int oirows = 0;
                foreach (OrderItem item in order.OrderItems)
                {
                    // send the int order id
                    oirows = this.orderdao.WriteOrderItems(orderID, item);
                } // we cant write the order and order items 
                  //simultaneousely because the orderid in the order table is identity and 
                  //db decides for it's value, on the other hand orderid is referenced as a 
                  //foreign key in the orderitems table, so if we dont have the orderid we 
                  //cant write the order items, on the other hand some orders might be deleted 
                  //so just trying to guess the orderid in c# and calculating it wont alway work
                  // that is why we have to first write the order, let the db choose the orderid for the
                  //entire order, then get it back from db (line 69) and write the orderitems using that orderid
                  // and we have a list of orderitems that all of them need to be written to the db, so we use a foreach
                  // and foreach orderitem in the orderitems list of the order, we write it's menuitem and quantity in the db

                if (oirows > 0)
                {
                    return row;
                }
                return -1;
            }
            catch (Exception)
            {
                return -2;
            }


        }
        public bool MarkOrderReady(int id)
        {
            try
            {
                orderdao.UpdateReady(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public bool CheckStatusReady(int id)
        {
            try
            {
                List<int> status = orderdao.GetStatus(id);
                foreach (int state in status)
                {
                    if (state != 2)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public bool MarkOrderCompeteReady(int id)
        {
            try
            {
                orderdao.OrderReady(id);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        public Order GetRunningOrderForTable(int tableNumber)
        {
            Order existingOrder = orderdao.GetRunningOrderForTable(tableNumber);
            if(existingOrder == null)
            {
                return null;
            }
            existingOrder.OrderItems = orderdao.GetOrderItemsForTable(existingOrder.OrderID);

            return existingOrder;
        }
    }
}

