using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumComposicao.Entities.Enums;

namespace EnumComposicao.Entities
{
    public class Order
    {
        public DateTime Moment{ get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Orders.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Orders.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;

            foreach (var item in Orders)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Orders)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
