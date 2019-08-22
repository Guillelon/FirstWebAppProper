using DAL.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ClientRepository
    {
        private FirstWebAppDbContext context;


        public ClientRepository()
        {
            context = new FirstWebAppDbContext();
        }

        public List<Client> Get()
        {
            return context.Client.ToList();

        }

        public Client GetById(int id)
        {

            var client = context.Client.Where(b => b.Id == id).FirstOrDefault();
            return client;

        }

        public Client Create(Client client)
        {

            context.Client.Add(client);
            context.SaveChanges();
            return client;
        }

        public Client Edit(Client client)
        {
            context.Entry(client).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return client;
        }

        public void Delete(Client client)
        {
            var clientToDelete = GetById(client.Id);
            context.Entry(clientToDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}
