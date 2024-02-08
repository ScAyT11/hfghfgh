using System.Windows;

namespace WpfApp12
{
    public partial class TaskWindow : Window
    {
        public TaskWindow()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            double y,u;
            int x = new Random().Next(0,5);
            //1
            u = Math.Sin(x);

            if (u + x > -0.5)
            {
                y = Math.Pow((2 * u + 1), 2) / 7 * Math.PI + x;
            }
            else if (-0.5 >= u + x && u + x <= Math.Pow(10, -3))
            {
                y = 
            }
            else if (u + x > Math.Pow(10, -3))
            {
                y = 
            }

            
        }
    }
}
