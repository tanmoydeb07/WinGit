using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WinGit.Views.Theme_1
{
    /// <summary>
    /// Interaction logic for PageCurrentBranch.xaml
    /// </summary>
    public partial class PageCurrentBranch : Page
    {
        public PageCurrentBranch()
        {
            InitializeComponent();

            List<string> changedFiles = new List<string>(10);
            changedFiles.Add(@"views\window1.xaml");
            changedFiles.Add(@"views\window1.cs");
            changedFiles.Add(@"viewmodels\vm_main.cs");
 
            DataContext = changedFiles;
        }
    }
}
