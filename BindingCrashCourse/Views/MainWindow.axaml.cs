using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using BindingCrashCourse.ViewModels;
using System;
using MessageBox.Avalonia;

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
