using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace prjConversor
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Double celsius;
        private Double farenheit;

        public MainPage()
        {
            this.InitializeComponent();
            this.celsius = 0;
            this.farenheit = getFarenheit(this.celsius);
            this.updateText();
        }

        private void updateText()
        {
            txbCelsius.Text = celsius.ToString();
            txbFerenheit.Text = farenheit.ToString();
        }

        private Double getFarenheit(Double celsius) => (celsius * 1.8) + 32;

        private Double getCelsius(Double farenheit) => (farenheit - 32) / 1.8;

        private void plusCelsius_Click(object sender, RoutedEventArgs e)
        {
            this.farenheit = getFarenheit(++this.celsius);
            this.updateText();
        }

        private void plusFarenheit_Click(object sender, RoutedEventArgs e)
        {
            this.celsius = getCelsius(++this.farenheit);
            this.updateText();
        }

        private void minusCelsius_Click(object sender, RoutedEventArgs e)
        {
            this.farenheit = getFarenheit(--this.celsius);
            this.updateText();
        }

        private void minusFarenheit_Click(object sender, RoutedEventArgs e)
        {
            this.celsius = getCelsius(--this.farenheit);
            this.updateText();
        }
    }
}
