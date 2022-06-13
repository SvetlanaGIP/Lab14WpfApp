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

namespace Lab14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Problem>();
        public MainWindow()
        {
            InitializeComponent();
            problems = new List<Problem>();
            problems.Add(new Problem()
            {
                ProblemName = "Task1",
                Description = "To Do Homework",
                Priority = 2,
                ProblemType = ProblemTypes.Work
            });
            problems.Add(new Problem()
            {
                ProblemName = "Task2",
                Description = "To water the flowers",
                Priority = 1,
                ProblemType = ProblemTypes.Home
            });
            problems.Add(new Problem()
            {
                ProblemName = "Task3",
                Description = "To make dinner",
                Priority = 1,
                ProblemType = ProblemTypes.Work
            });
            lstBx.ItemsSource = problems;
        }
    }
}
