﻿using System.Collections.Generic;

using ProtoFlipPizzaSystem.Models.Administrator.Contracts;

namespace PortoFlipPizzaSystem.Data.Contracts
{
    public interface IGetAllCustomer
    {
        ICollection<ICustomer> GetAllCustomers();
    }
}