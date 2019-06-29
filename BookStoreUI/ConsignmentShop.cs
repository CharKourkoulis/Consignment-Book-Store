using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace BookStoreUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold==false).ToList();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = cartBinding;

            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorsBinding;
            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";


        }


        private void SetupData()
        {
            Vendor demoVendor1 = new Vendor("Bill","Smith");
            Vendor demoVendor2 = new Vendor("Sue", "Jones");
            store.Vendors.Add(demoVendor1);
            store.Vendors.Add(demoVendor2);


            store.Items.Add(new Item { Title = "Dracula", Description = "Bram Stoker", Price = 6.50M, Owner = store.Vendors[0]});
            store.Items.Add(new Item { Title = "Mountains Of Madness", Description = "H.P Lovecraft", Price = 8.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Colour Out of Space", Description = "H.P Lovecraft", Price = 7.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Shadow Over Innsmouth", Description = "H.P Lovecraft", Price = 9.50M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Nightmare Factory", Description = "Thomas Ligotti", Price = 7.90M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Conspiracy Against Human Race", Description = "Thomas Ligotti", Price = 8.90M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Revival", Description = "Stephen King", Price = 7.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "King In Yellow", Description = "R.W Chambers", Price = 7.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Selected Stories", Description = "Edgar Allan Poe", Price = 9.90M, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Whisperer In Darkness", Description = "H.P Lovecraft", Price = 6.90M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "From Beyond", Description = "H.P Lovecraft", Price = 7.90M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "The Music of Erich Zann", Description = "H.P Lovecraft", Price = 7.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "The Call of Cthulhu", Description = "H.P Lovecraft", Price = 7.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "The Shadow Out of Time", Description = "H.P Lovecraft", Price = 9.80M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "The Haunter of the Dark", Description = "H.P Lovecraft", Price = 12.50M, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "The Thing on the Doorstep", Description = "H.P Lovecraft", Price = 11.90M, Owner = store.Vendors[0] });

            store.Name = "Horror Books Store";


        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(selectedItem.Title);
            //figure out what is selected from the items list.
            //Copy that item to the shopping cart.
            //Remove the item from the items list.

            Item selectedItem = (Item)itemsListbox.SelectedItem;
            
            //MessageBox.Show("Added to the Cart!");

            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);




        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {
            //Mark each item in the cart as sold
            //clear the cart

            foreach (var item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission * item.Price);
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("$ {0}", storeProfit.ToString("F"));
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
            MessageBox.Show("Purchased !");



        }
    }
}
