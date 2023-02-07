﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HaoTienEcommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder = 1,
        StartProcessing = 2,
        FinishOrder = 3,
        CancelOrder = 4
    }
}
