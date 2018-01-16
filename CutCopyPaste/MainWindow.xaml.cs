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

namespace CutCopyPaste
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string copyText = "";
        string cutText = "";

        bool isON;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            copyText = "";
            if (textbox1.SelectedText != "")
            {
                copyText = textbox1.SelectedText;
            }

            isON = true;
            
        }

        private void paste_Click(object sender, RoutedEventArgs e)
        {
            if (isON == true)
            {
                if (textbox2.Text != "")
                {
                    textbox2.Text += copyText;
                }
                else
                {
                    textbox2.Text = copyText;
                }
                
            }
            else if(isON==false)
            {
                if (textbox2.Text != "")
                {
                    textbox2.Text += cutText;
                }
                else
                {
                    textbox2.Text = cutText;
                }
            }

       
        }

        private void cut_Click(object sender, RoutedEventArgs e)
        {
            cutText = "";
            Clipboard.Clear();
            if (textbox1.SelectedText != "")
            {
                cutText = textbox1.SelectedText;
                textbox1.SelectedText = "";
            }
            
            isON = false;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
        }
    }
}
