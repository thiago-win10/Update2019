﻿namespace SalesWebMvc.Models.Enums
{
    public enum SaleStatus : int 
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2,
        Resolved = 3,
        Open = 4,
        Closed = 5,
        Payment = 6
    }
}
