using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    /// <remarks>Класс, представляющий заказ, который делает клиент</remarks>
    public class Order
    {
        private int orderNumber;
        private DateOnly orderDate;
        private DateOnly orderComplete;

        public OrderItem OrderItem
        {
            get => default;
            set
            {
            }
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public void SetInfo()
        {
            throw new System.NotImplementedException();
        }

        public void GetInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}