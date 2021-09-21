using BindingCrashCourse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BindingCrashCourse.ViewModels
{
    public class BindingPlayGroundViewModel : INotifyPropertyChanged
    {
        private List<TreeObject> _HierarchicalDataSource = new List<TreeObject>();
        public List<TreeObject> HierarchicalDataSource
        {
            get
            {
                return _HierarchicalDataSource;
            }
            set
            {
                _HierarchicalDataSource = value;
                NotifyPropertyChanged(); //Notifies WPF The Property Has changed and that the binding should be updated in GUI
            }
        }

        private List<XElementModel> _XmlDataSource = new List<XElementModel>();
        public List<XElementModel> XmlDataSource
        {
            get
            {
                return _XmlDataSource;
            }
            set
            {
                _XmlDataSource = value;
                NotifyPropertyChanged(); //Notifies WPF The Property Has changed and that the binding should be updated in GUI
            }
        }

        private List<int> _RandomInts = new List<int>();
        public List<int> RandomInts
        {
            get
            {
                return _RandomInts;
            }
            set
            {
                _RandomInts = value;
                NotifyPropertyChanged(); //Notifies WPF The Property Has changed and that the binding should be updated in GUI
            }
        }

        private string _JustAString = "Press The Button On The Right To Replace Me With A Random Number Or Edit Me";
        public string JustAString 
        {
            get 
            {
                return _JustAString;
            }
            set 
            { 
                _JustAString = value;
                NotifyPropertyChanged(); //Notifies WPF The Property Has changed and that the binding should be updated in GUI
            }
        }

        public BindingPlayGroundViewModel()
        {
            //Simply Fills the list with some nodes.
            HierarchicalDataSource.Add(
            new TreeObject("Root",
                new List<TreeObject>
                    {
                        new TreeObject("Node1", 
                            new List<TreeObject>()
                        ),
                        new TreeObject("Node1", 
                            new List<TreeObject>()
                        )
                    }
                )
            );
        }

        //Property Changed Event Implementation
        public event PropertyChangedEventHandler ?PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
