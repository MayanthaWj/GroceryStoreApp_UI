using GroceryStoreApp.ViewModel.Base;
using System.Collections.ObjectModel;

namespace GroceryStoreApp.ViewModel
{
    public class HomePageViewModel: BaseViewModel
    {
        private ObservableCollection<CategoryItem> categoryItemList = new ObservableCollection<CategoryItem>();
        private ObservableCollection<OfferItem> offerViewList = new ObservableCollection<OfferItem>();
        private ObservableCollection<BestDealItem> bestDealItemList = new ObservableCollection<BestDealItem>();
        public ObservableCollection<CategoryItem> CategoryItemList
        {
            get => categoryItemList;
            set
            {
                if(categoryItemList == value) return;
                categoryItemList = value;
                    OnPropertyChanged(nameof(CategoryItemList));
            }
        }

        public ObservableCollection<OfferItem> OfferViewList
        {
            get => offerViewList;
            set
            {
                if(offerViewList == value) return;
                offerViewList = value;
                OnPropertyChanged(nameof(OfferViewList));
            }
        }

       public ObservableCollection<BestDealItem> BestDealItemList
        {
            get => bestDealItemList;
            set
            {
                if (bestDealItemList == value) return;
                bestDealItemList = value;
                OnPropertyChanged(nameof(BestDealItemList));
            }
        }
        public HomePageViewModel()
        {
            InitializeInfo();
        }
        private void InitializeInfo() 
        {
            //Adding ithems to CategoryItemList
            categoryItemList.Add(new CategoryItem() {
                CategoryIcon = "fruitIcon.png",
                CategoryName = "Fruits"
            });
            categoryItemList.Add(new CategoryItem()
            {
                CategoryIcon = "vegeIcon.png",
                CategoryName = "Vegetables"
            });
            categoryItemList.Add(new CategoryItem()
            {
                CategoryIcon = "drinksIcon.png",
                CategoryName = "Drinks"
            });
            categoryItemList.Add(new CategoryItem()
            {
                CategoryIcon = "milkIcon.png",
                CategoryName = "Milk & Eggs"
            });
            categoryItemList.Add(new CategoryItem()
            {
                CategoryIcon = "breadIcon.png",
                CategoryName = "Bread"
            });

            //Adding items to offerViewList
            offerViewList.Add(new OfferItem()
            {
                OfferHeader = "Up to 25% off!",
                OfferBody1 = "Enjoy our big offer of",
                OfferBody2 = "every day"
            });
            offerViewList.Add(new OfferItem()
            {
                OfferHeader = "Up to 15% off!",
                OfferBody1 = "Enjoy our big offer for",
                OfferBody2 = "this week"
            });
            offerViewList.Add(new OfferItem()
            {
                OfferHeader = "Up to 5% off!",
                OfferBody1 = "Hurry Up & Get",
                OfferBody2 = "Weekend Offer"
            });

            //Adding items to bestDealItemList
            bestDealItemList.Add(new BestDealItem()
            {
                BestItemName = "Fresh Grapes",
                BestItemIcon = "grapes.png"
            });
            bestDealItemList.Add(new BestDealItem()
            {
                BestItemName = "Fresh Mango",
                BestItemIcon = "mango.png"
            });
            bestDealItemList.Add(new BestDealItem()
            {
                BestItemName = "Fresh Apple",
                BestItemIcon = "apple.png"
            });
        }

    }
    public class CategoryItem
    {
        public string CategoryIcon { get; set; }
        public string CategoryName { get; set; }
    }

    public class OfferItem
    {
        public string OfferHeader { get; set;}
        public string OfferBody1 { get; set;}
        public string OfferBody2 { get; set;}
    }

    public class BestDealItem
    {
        public string BestItemName { get; set; }

        public string BestItemIcon { get; set; }
    }
}
