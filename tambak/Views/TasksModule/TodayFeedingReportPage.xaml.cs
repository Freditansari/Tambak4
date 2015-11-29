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

namespace tambak.Views.TasksModule
{
    public partial class TodayFeedingReportPage : UserControl
    {
        public TodayFeedingReportPage()
        {
            try
            {
                if (WebContext.Current.User.IsInRole("Manager")  || WebContext.Current.User.IsInRole("Super Admin"))
                {


                    InitializeComponent();
        
                }
                else
                {
                    throw new ArgumentException("Insufficient Access. Please login with higher access.");
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            
        }
    }
}
