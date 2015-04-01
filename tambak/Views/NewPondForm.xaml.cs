using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using tambak.Web.DomainServices;
using tambak.Web;

namespace tambak.Views
{
    public partial class NewPondForm : ChildWindow
    {
        PondsDS newPondDomainContext = new PondsDS();

        public NewPondForm()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Technician") || WebContext.Current.User.IsInRole("Super Admin"))
                {
                    InitializeComponent();

                }
                else
                {
                    throw new ArgumentException("Insufficient Access. Please login with higher access.");
                }
            }

            catch (ArgumentException g)
            {
                MessageBox.Show(g.Message);

            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void pondDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //add new pond to database
            Pond newPond = new Pond();
            newPond.PondDescription = pondDescriptionTextBox.Text;
            newPond.PondLocation = pondLocationTextBox.Text;
            newPond.pondSize = Convert.ToInt32(pondSizeTextBox.Text);
            newPond.pondUOM = pondUOMTextBox.Text;

            
            //newPondDomainContext.Ponds.Add(newPond);
            newPondDomainContext.Ponds.Add(newPond);
            newPondDomainContext.SubmitChanges();

        }
    }
}

