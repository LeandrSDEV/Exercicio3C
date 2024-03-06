using System;
using System.Collections.Generic;


namespace Fixação_Ex3.Entities.Enums
{
    enum OrderStatus : int
    {
        PedingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
