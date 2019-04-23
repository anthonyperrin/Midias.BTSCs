using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System.Collections.Generic;
using System.Linq;

namespace Midias.BTSCs.Services
{
    public interface IVehiculeService
    {
        /// <summary>
        /// Returns the matching vehicle
        /// </summary>
        /// <param name="id">Vehicle Id</param>
        /// <returns></returns>
        VehiculeDto GetVehicule(int id);
        /// <summary>
        /// Returns a list with all the vehicles
        /// </summary>
        /// <returns></returns>
        List<VehiculeDto> GetVehicules();
        /// <summary>
        /// Adds a new vehicle
        /// </summary>
        /// <param name="produit">Vehicle Dto</param>
        /// <returns></returns>
        void AddVehicule(VehiculeDto vehicule);
        /// <summary>
        /// Updates the given vehicle with its new values
        /// </summary>
        /// <param name="produitDto">New vehicle Dto</param>
        /// <returns></returns>
        VehiculeDto UpdateVehicule(VehiculeDto vehicule);
        /// <summary>
        /// Delete the vehicle template
        /// </summary>
        /// <param name="id">Vehicle to remove Id</param>
        /// <returns></returns>
        void DeleteVehicule(int id);
    }

    public class VehiculeService : ServiceBase, IVehiculeService
    {
        public VehiculeService()
        {
        }

        public VehiculeDto GetVehicule(int id)
        {
            var vehicule = Context.Vehicule.Where(v => v.Id == id).FirstOrDefault();
            return new VehiculeDto()
            {
                Id = vehicule.Id,
                CarteGrise = vehicule.CarteGrise,
                Immatriculation = vehicule.Immatriculation,
                Marque = vehicule.Marque,
                Modele = vehicule.Modele,
            };
        }

        public List<VehiculeDto> GetVehicules()
        {
            return Context.Vehicule.Select(v => new VehiculeDto()
            {
                Id = v.Id,
                CarteGrise = v.CarteGrise,
                Immatriculation = v.Immatriculation,
                Marque = v.Marque,
                Modele = v.Modele,
            }).ToList();
        }

        public void AddVehicule(VehiculeDto vehicule)
        {
            Context.Vehicule.Add(new Vehicule()
            {
                Id = vehicule.Id,
                CarteGrise = vehicule.CarteGrise,
                Immatriculation = vehicule.Immatriculation,
                Marque = vehicule.Marque,
                Modele = vehicule.Modele,
            });
            Context.SaveChanges();
        }

        public VehiculeDto UpdateVehicule(VehiculeDto vehiculeDto)
        {
            var vehicule = GetVehicule(vehiculeDto.Id);

            vehicule.Id = vehiculeDto.Id;
            vehicule.CarteGrise = vehiculeDto.CarteGrise;
            vehicule.Immatriculation = vehiculeDto.Immatriculation;
            vehicule.Marque = vehiculeDto.Marque;
            vehicule.Modele = vehiculeDto.Modele;

            Context.SaveChanges();

            return new VehiculeDto()
            {
                Id = vehicule.Id,
                CarteGrise = vehicule.CarteGrise,
                Immatriculation = vehicule.Immatriculation,
                Marque = vehicule.Marque,
                Modele = vehicule.Modele,
                Livraison = vehiculeDto.Livraison
            };
        }

        public void DeleteVehicule(int id)
        {
            var vehicule = Context.Vehicule.Where(v => v.Id == id).FirstOrDefault();

            if (vehicule == null)
                return;

            Context.Vehicule.Remove(vehicule);

            Context.SaveChanges();
        }
    }
}