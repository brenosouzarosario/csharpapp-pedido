﻿using System;
using System.Collections.Generic;
using System.Text;
using Pedido.Entities.Enums;

namespace Pedido.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus status { get; set; }
        public OrderStatus Status { get; internal set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ". "
                + status;
        }
    }
}
