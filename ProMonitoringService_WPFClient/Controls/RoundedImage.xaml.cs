using System.Windows;
using System.Windows.Controls;

namespace ProMonitoringService_WPFClient.Controls
{
    /// <summary>
    /// Interaction logic for RoundedImage.xaml
    /// </summary>
    public partial class RoundedImage : UserControl
    {
        public RoundedImage()
        {
            InitializeComponent();
        }

        #region ImgSrc dp
        public string ImgSrc
        {
            get { return (string)GetValue(ImgSrcProperty); }
            set { SetValue(ImgSrcProperty, value); }
        }
        public static readonly DependencyProperty ImgSrcProperty =
            DependencyProperty.Register(
                nameof(ImgSrc), 
                typeof(string),
                typeof(RoundedImage), 
                new PropertyMetadata(string.Empty));
        #endregion

        #region RoundingRadius
        public int RoundingRadius
        {
            get { return (int)GetValue(RoundingRadiusProperty); }
            set { SetValue(RoundingRadiusProperty, value); }
        }
        public static readonly DependencyProperty RoundingRadiusProperty =
            DependencyProperty.Register(nameof(RoundingRadius), typeof(int), typeof(RoundedImage), new PropertyMetadata(0));
        #endregion
    }
}
