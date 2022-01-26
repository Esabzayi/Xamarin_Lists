using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Lists.Models;

namespace Xamarin_Lists
{
    public partial class MainPage : ContentPage
    {
        List<Contacts> GetContacts(string searchtext = null)
        {
            var contact = new List<Contacts>
            {
                new Contacts {Id = 1 , Name = "Chris" , Status = "Working" , ImageUrl = "https://img.icons8.com/external-vitaliy-gorbachev-lineal-color-vitaly-gorbachev/452/external-person-infographic-elements-vitaliy-gorbachev-lineal-color-vitaly-gorbachev.png"},
                new Contacts {Id = 2 ,Name = "Jack" , Status = "Un-Active" , ImageUrl = "https://img.icons8.com/dusk/344/person-male.png"},
                new Contacts {Id = 3 ,Name = "Salman" , Status = "Working on Xamarin Lists" , ImageUrl = "https://img.icons8.com/external-flat-juicy-fish/344/external-person-school-flat-flat-juicy-fish.png"},
                new Contacts {Id = 4 ,Name = "Aliyan" , Status = "Not Much" , ImageUrl = "https://img.icons8.com/emoji/344/person-gesturing-no.png"},
                new Contacts {Id = 5 ,Name = "Jian Yang" , Status = "Eric Crying" , ImageUrl = "https://img.icons8.com/external-wanicon-two-tone-wanicon/344/external-key-person-training-and-coaching-wanicon-two-tone-wanicon.png"},
                new Contacts {Id = 6 ,Name = "Deema Saeed" , Status = "Living life" , ImageUrl = "https://img.icons8.com/dusk/344/person-female.png"},
                new Contacts {Id = 7 ,Name = "Faddy Balouch" , Status = "Property Dealer" , ImageUrl = "https://img.icons8.com/bubbles/344/popular-man.png"},
                new Contacts {Id = 8 ,Name = "Ali" , Status = "What you Looking at" , ImageUrl = "https://img.icons8.com/emoji/344/person-astronaut.png"},
            };

            if (string.IsNullOrWhiteSpace(searchtext))
            {
                return contact;
            }
            else
            {
                return contact.Where(x => x.Name.StartsWith(searchtext)).ToList();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            Mylist.ItemsSource = GetContacts();
        }

        public async void Mylist_ItemTapped(object sender , ItemTappedEventArgs e)
        {
            var SeletectedItem = (Contacts)e.Item;
            await DisplayAlert("You have Tapped " + SeletectedItem.Id, SeletectedItem.Name, "Cancel");
        }

        public async void Mylist_ItemSelected(object sender, ItemTappedEventArgs e)
        {
            Mylist.SelectedItem = null;
        }

        private void Mylist_Refreshing(object sender, EventArgs e)
        {
            Mylist.ItemsSource = GetContacts();
            Mylist.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
          Mylist.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}
