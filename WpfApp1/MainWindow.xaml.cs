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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer dispatcherTimer=new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(30);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
           // dispatcherTimer.Start();
            //StackPanel +
            //WrapPanel
            //DockPanel 
            //Canvas +     
            //UniFormgrid
            //Grid
        }
        public int MyAngle { get; set; } = 1;
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            //var tr=new RotateTransform();
            //MyAngle += 1;
            //tr.Angle = MyAngle;
            //mylabel.RenderTransform = tr;


            var tr = new SkewTransform();
            MyAngle += 1;
            tr.AngleY = MyAngle;
            //mylabel.RenderTransform = tr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
