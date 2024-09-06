using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExelSolar.Classes;
using ExelSolar.Logica;

namespace ExelSolar.Classes
{
    public class ListClients: Client 
    {

        List<Client> clients = new List<Client>();

        public void ADDListClients(Client obj)
        {
            clients.Add(obj);
        }

        public void ShowIds()

        {
            string AuxFullName = null;
            foreach (Client obj in clients)
            {
                AuxFullName = obj.FullName();
                Console.WriteLine(AuxFullName);
            }
        }

    }
}
