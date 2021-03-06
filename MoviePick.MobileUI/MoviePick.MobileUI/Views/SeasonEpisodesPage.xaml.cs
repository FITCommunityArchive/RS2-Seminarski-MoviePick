﻿using MoviePick.MobileUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviePick.MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeasonEpisodesPage : ContentPage
    {
        SeasonEpisodesViewModel model = null;
        public SeasonEpisodesPage(Data.Model.TvshowSeason TvshowSeason)
        {
            InitializeComponent();
            BindingContext = model = new SeasonEpisodesViewModel
            {
                TvshowSeason = TvshowSeason
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}