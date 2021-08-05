using System.Windows.Controls;
using HealthyMe.UserControls;

namespace HealthyMe.Views
{
    /// <summary>
    /// Interaction logic for BodyImageSelecter.xaml
    /// </summary>
    public partial class BodyImageSelecter : UserControl
    {
        public BodyImageSelecter()
        {
            InitializeComponent();
            itemStackPanel.Children.Add(new BodyImageControl("a.png"));
            itemStackPanel.Children.Add(new BodyImageControl("5-7.png"));
            itemStackPanel.Children.Add(new BodyImageControl("8-10.png"));
            itemStackPanel.Children.Add(new BodyImageControl("11-12.png"));
            itemStackPanel.Children.Add(new BodyImageControl("13-15.png"));
            itemStackPanel.Children.Add(new BodyImageControl("16-19.png"));
            itemStackPanel.Children.Add(new BodyImageControl("20-24.png"));
            itemStackPanel.Children.Add(new BodyImageControl("25-30.png"));
            itemStackPanel.Children.Add(new BodyImageControl("35-40.png"));
        }
    }
}
