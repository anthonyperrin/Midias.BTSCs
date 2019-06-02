using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services.Services
{
    public interface IClientsService
    {
        /// <summary>
        /// Returns the matching client
        /// </summary>
        /// <param name="id">Client Id</param>
        /// <returns></returns>
        Client GetClient(int id);
        /// <summary>
        /// Returns a list with all the clients
        /// </summary>
        /// <returns></returns>
        List<ClientDto> GetClients();
        /// <summary>
        /// Create a new template of client
        /// </summary>
        /// <param name="categorie">Client Dto</param>
        /// <returns></returns>
        void CreateNewClient(ClientDto client);
        /// <summary>
        /// Updates the given client with its new values
        /// </summary>
        /// <param name="clientDto">New client Dto</param>
        /// <returns></returns>
        ClientDto UpdateClient(ClientDto clientDto);
        /// <summary>
        /// Delete the client template
        /// </summary>
        /// <param name="id">Client to remove Id</param>
        /// <returns></returns>
        void DeleteClient(int id);
    }

    public class ClientsService : ServiceBase, IClientsService
    {
        public ClientsService()
        {
        }

        public Client GetClient(int id)
        {
            return Context.Client.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<ClientDto> GetClients()
        {
            return Context.Client.Select(client => new ClientDto()
            {
                Id = client.Id,
                Nom = client.Nom,
                Prenom = client.Prenom,
                Adresse = new AdresseDto()
                {
                    Id = client.Adresse.Id,
                    Rue1 = client.Adresse.Rue1,
                    Rue2 = client.Adresse.Rue2,
                    CodePostal = client.Adresse.CodePostal,
                    Ville = client.Adresse.Ville,
                    Pays = client.Adresse.Pays
                },
            }).ToList();
        }

        public void CreateNewClient(ClientDto client)
        {
            Adresse adresse = Context.Adresse.Where(c => c.Id == client.Adresse.Id).FirstOrDefault();
            Client cli = new Client();
            cli.Nom = client.Nom;
            cli.Prenom = client.Prenom;
            cli.Adresse = adresse;
            Context.Client.Add(cli);
            Context.SaveChanges();
        }

        public ClientDto UpdateClient(ClientDto clientDto)
        {
            var client = Context.Client.Where(p => p.Id == clientDto.Id).FirstOrDefault();

            client.Nom = clientDto.Nom;
            client.Prenom = clientDto.Prenom;
            client.Adresse.CodePostal = clientDto.Adresse.CodePostal;
            client.Adresse.Rue1 = clientDto.Adresse.Rue1;
            client.Adresse.Rue2 = clientDto.Adresse.Rue2;
            client.Adresse.Ville = clientDto.Adresse.Ville;
            client.Adresse.Pays = clientDto.Adresse.Pays;


            Context.SaveChanges();

            return clientDto;
        }

        public void DeleteClient(int id)
        {
            var client = Context.Client.Where(p => p.Id == id).FirstOrDefault();

            if (client == null)
                return;

            Context.Client.Remove(client);

            Context.SaveChanges();
        }
    }
}
