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
using System.Windows.Shapes;

namespace MK.Windows
{
    /// <summary>
    /// Логика взаимодействия для Result.xaml
    /// </summary>
    public partial class Result : Window
    {
        public Result(double Results)
        {
            InitializeComponent();
            ResultLabel.Content = Results.ToString()+"%";
            if (Results >= 85) 
            {
                EvaluationLabel.Content = "Отлично";
            }
            else if ((85 > Results)&&(Results>= 65))
            {
                EvaluationLabel.Content = "Хорошо";
            }
            else if ((64 > Results) && (Results >= 40))
            {
                EvaluationLabel.Content = "Удовлетворительно";
            }
            else
            {
                EvaluationLabel.Content = "Плохо";
            }
        }

    }
}
