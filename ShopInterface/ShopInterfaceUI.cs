using ShopInterfaceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInterface
{
    public partial class ShopInterfaceUI : Form
    {
        private Store store = new Store();
        private List<Items> shoppingCartData = new List<Items>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartsBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        public ShopInterfaceUI()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items;
            itemListBox.DataSource = itemsBinding;
            itemListBox.DisplayMember = "Display";
            itemListBox.ValueMember = "Display";

            cartsBinding.DataSource = shoppingCartData;
            cartListBox.DataSource = cartsBinding;
            cartListBox.DisplayMember = "Display";
            cartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorsBinding;
            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Андрей", LastName = "Попов" });
            store.Vendors.Add(new Vendor { FirstName = "Наталья", LastName = "Сергеева" });
            store.Vendors.Add(new Vendor { FirstName = "Пётр", LastName = "Петров" });
            store.Items.Add(new Items { Title="Гарри Поттер.", 
                                        Discription="Философский камень.",
                                        Price=500.50M, 
                                        Owner=store.Vendors[0] }
                            );
            store.Items.Add(new Items { Title = "Золотой телёнок.",
                                        Discription = "Хорошая книга.",
                                        Price = 300.80M,
                                        Owner = store.Vendors[1]}
                            );
            store.Items.Add(new Items { Title = "12 стульев.",
                                        Discription = "Про Остапа Бендера.",
                                        Price = 450M,
                                        Owner = store.Vendors[2]}
                            );
            store.Items.Add(new Items { Title = "Тонкое искусство пофигизма.",
                                        Discription = "Парадоксальный способ быть счастливым.",
                                        Price = 200.5M,
                                        Owner = store.Vendors[0]}
                            );
        }
    }
}
