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
using tambak.Web;
using tambak.Web.DomainServices;

namespace tambak.Views.Inventory
{

    public partial class NewCategoryChildWindow : ChildWindow
    {
        public bool itHasGotFocus { get; set; }
        CategoryDS categoryDomainContext = new CategoryDS();
        bool itHasCleared = false;


        public NewCategoryChildWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Category newCategory = new Category();
            newCategory.CategoryName = categoryNameTextBox.Text;
            categoryDomainContext.Categories.Add(newCategory);
            categoryDomainContext.SubmitChanges().Completed += NewCategoryChildWindow_Completed;
            
        }

        void NewCategoryChildWindow_Completed(object sender, EventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void categoryDomainDataSource_LoadedData_1(object sender, LoadedDataEventArgs e)
        {

            if (e.HasError)
            {
                System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            if (itHasGotFocus == false)
            {
                cleantextboxes();
                itHasGotFocus = true;
            }
        }

        private void cleantextboxes()
        {
            categoryNameTextBox.Text = "";
        }

        private void LayoutRoot_GotFocus(object sender, RoutedEventArgs e)
        {
            if (itHasCleared == false)
            {
                categoryNameTextBox.Text = "";
                itHasCleared = true;
            }
        }

        
    }
}

