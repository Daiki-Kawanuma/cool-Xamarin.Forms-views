﻿using CoolViewSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoolViewSample
{
    public partial class MainPage : ContentPage
    {
        public IEnumerable<AccordionItem> Items = AccordionItem.Participants;

        public MainPage()
        {
            InitializeComponent();
            this.accordion.ItemsSource = Items;
        }
    }
}
