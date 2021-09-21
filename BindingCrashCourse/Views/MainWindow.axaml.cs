using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using BindingCrashCourse.ViewModels;
using System;
using MessageBox.Avalonia;
using System.Xml.Linq;
using System.Collections.Generic;
using BindingCrashCourse.Models;
using System.Linq;

namespace BindingCrashCourse.Views
{
    public partial class MainWindow : Window
    {
        public BindingPlayGroundViewModel? ViewModel
        {
            get
            {
                if (this.DataContext is BindingPlayGroundViewModel)
                {
                    return this.DataContext as BindingPlayGroundViewModel;
                }
                else
                {
                    return null;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            var root = XElement.Load("c0000.xml");
            var rootModel = new XElementModel(root, null);
            UsefulFunctions.XElementRootToXElementModel(root, rootModel);

            var listModels = new List<XElementModel>();
            listModels.Add(rootModel);
            ViewModel.XmlDataSource = listModels;

#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Click_GenerateRandomInts(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                ViewModel.RandomInts = UsefulFunctions.GenerateListOfRandomInts(1, 100);
            }
        }

        private void Click_GenerateRandomInt(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                ViewModel.JustAString = new Random().Next().ToString();
            }
        }

        private void Click_PrintJustAString(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow("Just a message", ViewModel.JustAString);
                messageBoxStandardWindow.Show();
            }
        }
    }
}
