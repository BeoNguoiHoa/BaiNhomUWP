using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using App1.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using App1.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoFetchApi : Page
    {
        public DemoFetchApi()
        {
            this.InitializeComponent();
            /* List<Item> list = new List<Item>();
             list.Add(new Item { id = 1, icon = "", name = "burger" });
             list.Add(new Item { id = 1, icon = "", name = "burger" });
             list.Add(new Item { id = 1, icon = "", name = "burger" });
             MNItems.ItemsSource = list;*/
            GetCollection();
        }

        public async void GetCollection()
        {
            
               
                MenuService service = new MenuService();
                Menu menu = await service.GetMenu();
                if (menu != null)
                {
                MNItems.ItemsSource = menu.data;
                }
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string msg = e.Parameter as string;

        }



    }
}
