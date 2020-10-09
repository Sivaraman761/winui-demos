#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Charts;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace syncfusion.chartdemos.winui.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SemiPieChart : Page, IDisposable
    {
        public SemiPieChart()
        {
            this.InitializeComponent();
        }

        public void Dispose()
        {
            Chart.Dispose();
        }
  
        private void StartSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Pieseries.StartAngle = e.NewValue;
        }

        private void EndSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Pieseries.EndAngle = e.NewValue;
        }

    }
}