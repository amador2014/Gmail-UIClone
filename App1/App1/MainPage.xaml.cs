﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace App1
{
    
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : Xamarin.Forms.TabbedPage
    {

        public MainPage()
        {
            InitializeComponent();

            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    entry.Text = (Application.Current as App).DisplayText;
        //}

        //void OnEntryCompleted(object sender, EventArgs e)
        //{
        //    (Application.Current as App).DisplayText = entry.Text;
        //}
    }
}
