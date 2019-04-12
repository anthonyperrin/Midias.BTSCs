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
        ClientDto GetClient(int id);
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

    class ClientsService : ServiceBase, IClientsService
    {
        public ClientsService()
        {
        }

        public ClientDto GetClient(int id)
        {
            var client = Context.Client.Where(p => p.Id == id).FirstOrDefault();
            return new ClientDto()
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
            };
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
            Context.Client.Add(new Client()
            {
                Id = client.Id,
                Nom = client.Nom,
                Prenom = client.Prenom,
                Adresse = new Adresse()
                {
                    Id = client.Adresse.Id,
                    Rue1 = client.Adresse.Rue1,
                    Rue2 = client.Adresse.Rue2,
                    CodePostal = client.Adresse.CodePostal,
                    Ville = client.Adresse.Ville,
                    Pays = client.Adresse.Pays
                }
            });
            Context.SaveChanges();
        }

        public ClientDto UpdateClient(ClientDto clientDto)
        {
            var client = GetClient(clientDto.Id);

            client.Nom = clientDto.Nom;
            client.Prenom = clientDto.Prenom;
            client.Adresse = clientDto.Adresse;

            Context.SaveChanges();

            return new ClientDto()
            {
                Id = client.Id,
                Nom = client.Nom,
                Prenom = client.Prenom,
                Adresse = client.Adresse
            };
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
