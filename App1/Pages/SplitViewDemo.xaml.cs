using App1.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitViewDemo : Page
    {
        public SplitViewDemo()
        {
            this.InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }

        private void ListUsers_Loaded(object sender, RoutedEventArgs e)
        {
            User u1 = new User("Nguyen Van An", "annv@gmail.com");
            User u2 = new User("Nguyen Van An", "annv@gmail.com");
            ListUsers.Items.Add(u1);
            ListUsers.Items.Add(u2);
        }
    }
}
