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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControls
{
    public partial class GearsView : UserControl
    {
        public GearsView()
        {
            InitializeComponent();
        }


        DoubleAnimation gearAAnimation = null;

        DoubleAnimation gearBAnimation = null;

        public void StartAnim()
        {
            gearAAnimation = new DoubleAnimation
            {
                From = 0,
                To = 360,
                Duration = new Duration(TimeSpan.FromSeconds(2)),
                RepeatBehavior = RepeatBehavior.Forever
            };

            gearBAnimation = new DoubleAnimation
            {
                From = 360,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(2)),
                RepeatBehavior = RepeatBehavior.Forever
            };

            gear1.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, gearAAnimation);
            gear2.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, gearBAnimation);
        }

        public void StopAnim()
        {
            gear1.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, null);
            gear2.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, null);
        }

    }
}
