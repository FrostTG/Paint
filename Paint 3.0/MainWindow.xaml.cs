using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paint_3._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Ink_Click(object sender, RoutedEventArgs e)
        {
            inkCanv.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void eraser_Click(object sender, RoutedEventArgs e)
        {
            inkCanv.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void garbage_Click(object sender, RoutedEventArgs e)
        {
            inkCanv.Strokes.Clear();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
