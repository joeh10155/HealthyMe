using System;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HealthyMe.UserControls
{
    /// <summary>
    /// Interaction logic for BodyImageControl.xaml
    /// </summary>
    public partial class BodyImageControl : UserControl
    {
        string imageName = "";

        public BodyImageControl()
        {
            InitializeComponent();
        }

        public BodyImageControl(string imageName)
        {
            this.imageName = imageName;

            /*Assembly asm = Assembly.GetExecutingAssembly();
            Stream iconStream = asm.GetManifestResourceStream($"_{imageName}");
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = iconStream;
            bitmap.EndInit();*/

            bodyImage.Source = new BitmapImage(Get($"{imageName}"));
            //var uriSource = new Uri($"/HealthyMe;component/Resources/{imageName}", UriKind.Relative);
            /*BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($"pack://application:,,,/HealthyMe;component/Resources/{imageName}");
            image.EndInit();*/
            //bodyImage.Source = image;            
        }

        public Uri Get(string resourcePath)
        {
            var uri = string.Format(
                "pack://application:,,,/{0};component/{1}"
                , Assembly.GetExecutingAssembly().GetName().Name
                , resourcePath
            );

            return new Uri(uri);
        }
    }
}
