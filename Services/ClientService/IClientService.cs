﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tg_crud_solution.Models.DataBase;

namespace tg_crud_solution.Services.ClientService
{
    public interface IClientService
    {
        List<Client> GetClients();
    }
}
