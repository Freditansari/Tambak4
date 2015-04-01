using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.DataVisualization;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Telerik.Windows.Controls.Map;

namespace tambak
{
    public class MapItem : INotifyPropertyChanged
    {
        private double baseZoomLevel = double.NaN;
        private string caption = string.Empty;
        private Location location = Location.Empty;
        private ZoomRange zoomRange = ZoomRange.Empty;

        public MapItem(
            string caption,
            Location location,
            double baseZoomLevel,
            ZoomRange zoomRange)
        {
            this.Caption = caption;
            this.Location = location;
            this.BaseZoomLevel = baseZoomLevel;
            this.ZoomRange = zoomRange;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public double BaseZoomLevel
        {
            get
            {
                return this.baseZoomLevel;
            }
            set
            {
                this.baseZoomLevel = value;
                this.OnPropertyChanged("BaseZoomLevel");
            }
        }

        public string Caption
        {
            get
            {
                return this.caption;
            }

            set
            {
                this.caption = value;
                this.OnPropertyChanged("Caption");
            }
        }

        public Location Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.location = value;
                this.OnPropertyChanged("Location");
            }
        }

        public ZoomRange ZoomRange
        {
            get
            {
                return this.zoomRange;
            }

            set
            {
                this.zoomRange = value;
                this.OnPropertyChanged("ZoomRange");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(
                    this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
