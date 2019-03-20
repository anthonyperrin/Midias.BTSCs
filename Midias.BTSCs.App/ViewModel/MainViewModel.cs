using GalaSoft.MvvmLight;
using Midias.BTSCs.Dto;
using Midias.BTSCs.Services;
using System.Collections.Generic;

namespace Midias.BTSCs.App.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public List<ProduitDto> list { get; set; }
        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text == value)
                    return;

                _text = value;
                RaisePropertyChanged(Text);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            IProduitsService service = new ProduitsService();
            //service.CreateNewProduit(new ProduitDto()
            //{
            //    Id = 2,
            //    Libelle = "Article test",
            //    Categorie = new CategorieDto()
            //    {
            //        Id = 1,
            //        Libelle = "Catégorie test"
            //    },
            //    PrixHT = 2,
            //    Quantite = 1,
            //    Taxe = 2
            //});
            list = service.GetProduits();
        }
    }
}