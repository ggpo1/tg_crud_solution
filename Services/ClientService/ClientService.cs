using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tg_crud_solution.Models.DataBase;

namespace tg_crud_solution.Services.ClientService
{
    public class ClientService : IClientService
    {

        public List<Client> GetClients()
        { 
            List<Client> _clients = ApplicationDB.db.Client.ToList();
            return _clients;
        }

    }
}
