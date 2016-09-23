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
    /// <summary>
    /// Interaction logic for GearsView.xaml
    /// </summary>
    public partial class GearsView : UserControl
    {
        public GearsView()
        {
            InitializeComponent();
        }


        DoubleAnimation da = null;

        DoubleAnimation db = null;

        public void StartAnim()
        {
            da = new DoubleAnimation();
            da.From = 0;
            da.To = 360;
            da.Duration = new Duration(TimeSpan.FromSeconds(2));
            da.RepeatBehavior = RepeatBehavior.Forever;

            db = new DoubleAnimation();
            db.From = 360;
            db.To = 0;
            db.Duration = new Duration(TimeSpan.FromSeconds(2));
            db.RepeatBehavior = RepeatBehavior.Forever;

            gear1.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, da);
            gear2.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, db);
        }

        public void StopAnim()
        {
            gear1.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, null);
            gear2.rotateTransform.BeginAnimation(RotateTransform.AngleProperty, null);
        }

    }
}
