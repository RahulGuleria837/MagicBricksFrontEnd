﻿using TranspotationManagment.View;

namespace TranspotationManagment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new LoginPage();
            MainPage = new Homepage();

        }
    }
}