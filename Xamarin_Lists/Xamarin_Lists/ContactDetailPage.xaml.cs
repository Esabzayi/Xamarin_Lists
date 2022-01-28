using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin_Lists.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Xamarin_Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
       Contacts AllContacts = new  Contacts();

        public ContactDetailPage(Contacts contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException();
            }


            BindingContext = contact;
            AllContacts = contact;
            InitializeComponent();
            Test();
        }
        
        void Test()
        {
            Console.WriteLine(AllContacts.Id);
        }
    }
}