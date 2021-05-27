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

namespace osAndXs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OsAndXs g = new OsAndXs();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(0);
            if (result == true) updateGUI();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(1);
            if (result == true) updateGUI();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(2);
            if (result == true) updateGUI();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(3);
            if (result == true) updateGUI();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(4);
            if (result == true) updateGUI();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(5);
            if (result == true) updateGUI();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(6);
            if (result == true) updateGUI();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(7);
            if (result == true) updateGUI();

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            bool result = g.addCounter(8);
            if (result == true) updateGUI();

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void updateGUI()
        {
            Button[] bs = { P1, P2, P3, P4, P5, P6, P7, P8, P9 };
            Board b = g.getBoard();
            int[] elementsBoard = b.getBoard();
            
            for(int x=0; x < elementsBoard.Length; x++)
            {
                if (elementsBoard[x] == 0) bs[x].Content = " ";
                if (elementsBoard[x] == 1) bs[x].Content = "O";
                if (elementsBoard[x] == 2) bs[x].Content = "X";
            }

        }
    }
}
