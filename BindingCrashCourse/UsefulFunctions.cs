using Avalonia.Controls;
using BindingCrashCourse.Models;
using BindingCrashCourse.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BindingCrashCourse
{
    class UsefulFunctions
    {
        public static List<int> GenerateListOfRandomInts(int intsRandomMinimumNumber, int intsRandomMaximumNumber)
        {
            List<int> randomNumbersList = new List<int>();
            Random randomNumberGenerator = new Random();
            for (int i = 0; i <= randomNumberGenerator.Next(intsRandomMinimumNumber, intsRandomMaximumNumber); i++)
            {
                randomNumbersList.Add(randomNumberGenerator.Next());
            }
            return randomNumbersList;
        }
        public static void XElementRootToXElementModel(XElement currentXElement, XElementModel currentXElementModel)
        {
            foreach (XElement xelem in currentXElement.Elements())
            {
                var newXElementModel = new XElementModel(xelem, currentXElementModel);
                currentXElementModel.Children.Add(newXElementModel);
                XElementRootToXElementModel(xelem, newXElementModel);
            }
        }
        public static void XElementRootToTreeViewItem(XElement currentXElement, TreeViewItem currentXElementModel)
        {
            var a = new List<TreeViewItem>();
            foreach (XElement xelem in currentXElement.Elements())
            {
                var newXElementModel = new TreeViewItem() {Header=xelem.Name };
                a.Add(newXElementModel);
                XElementRootToTreeViewItem(xelem, newXElementModel);
            }
            currentXElementModel.Items = a;
        }
    }
}
