using System.Windows;
using System.Windows.Controls;

namespace ProMonitoringService_WPFClient.Controls
{
    public class PopupedContentControl : ContentControl
    {
        public PopupedContentControl()
        {
            Style = App.Current.FindResource(nameof(PopupedContentControl) + "_DefaultStyle") as Style;
        }

        #region PopupContent
        public object PopupContent
        {
            get { return GetValue(PopupContentProperty); }
            set { SetValue(PopupContentProperty, value); }
        }

        public static readonly DependencyProperty PopupContentProperty =
            DependencyProperty.Register(
                nameof(PopupContent), 
                typeof(object), 
                typeof(PopupedContentControl), 
                new PropertyMetadata(null));
        #endregion

        #region IsForACLView
        public bool IsForACLView
        {
            get { return (bool)GetValue(IsForACLViewProperty); }
            set { SetValue(IsForACLViewProperty, value); }
        }

        public static readonly DependencyProperty IsForACLViewProperty =
            DependencyProperty.Register(
                nameof(IsForACLView), 
                typeof(bool), 
                typeof(PopupedContentControl), 
                new PropertyMetadata(false));
        #endregion
    }
}
