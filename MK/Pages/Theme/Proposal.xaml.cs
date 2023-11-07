using MK.Pages.Themes;
using MK.Windows;
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

namespace MK.Pages.Theme
{
    /// <summary>
    /// Логика взаимодействия для Proposal.xaml
    /// </summary>
    public partial class Proposal : Page
    {
        public Proposal()
        {
            InitializeComponent();
        }

    

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock txt = (TextBlock)sender;
            DataObject dataObject = new DataObject(txt.Text);
            DragDrop.DoDragDrop(txt, dataObject, DragDropEffects.Copy);
        }

      

        private void TextBox_Off(object sender, TextChangedEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.IsEnabled = false; // Отключаем TextBlock
        }



        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Proposal());
        }

        private void StopProposalButton_Click(object sender, RoutedEventArgs e)
        {

            int n = 0;
            var textBoxes = new List<TextBox> { Proposal_TextBox1, Proposal_TextBox2, Proposal_TextBox3, Proposal_TextBox4, Proposal_TextBox5, Proposal_TextBox6, Proposal_TextBox7 };
            var textBlockes = new List<TextBlock> { Proposal7TextBlock, Proposal3TextBlock, Proposal6TextBlock, Proposal5TextBlock, Proposal2TextBlock, Proposal1TextBlock, Proposal4TextBlock };
            for (int i = 0; i < textBoxes.Count; i++)
            {
                TextBox textBox = textBoxes[i];
                TextBlock textBlock = textBlockes[i];
                textBox.IsEnabled = false;

                if (textBox.Text == textBlock.Text)
                {
                    n++;
                    Brush newBrush = new SolidColorBrush(Colors.Green);
                    textBox.Foreground = newBrush;
                }
                else
                {
                    Brush newBrush = new SolidColorBrush(Colors.Red);
                    textBox.Foreground = newBrush;
                }

            }
            double RES = Math.Round(((n * 100.0) / 7.0), 2);
            var wind = new Result(RES);
            wind.Show();
        }

        private void ExitProposalButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new ThemesPage());
        }
    }
}




 



