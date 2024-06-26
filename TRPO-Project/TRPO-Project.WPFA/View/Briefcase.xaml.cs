﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using TRPO_Project.WPFA.ViewModel;

namespace TRPO_Project.WPFA.View
{
    /// <summary>
    /// Логика взаимодействия для Briefcase.xaml
    /// </summary>
    public partial class Briefcase : UserControl
    {

        public Briefcase()
        {
            InitializeComponent();

            var menuStock = new List<SubItem>();
            menuStock.Add(new SubItem(PackIconKind.CheckboxMarkedCircleOutline, "SBER", "1379.50 ₽", "+11.30 ₽ (0.8%)"));
            menuStock.Add(new SubItem(PackIconKind.CheckboxMarkedCircleOutline, "SBER", "1379.50 ₽", "+11.30 ₽ (0.8%)"));
            menuStock.Add(new SubItem(PackIconKind.CheckboxMarkedCircleOutline, "SBER", "1379.50 ₽", "+11.30 ₽ (0.8%)"));
            menuStock.Add(new SubItem(PackIconKind.CheckboxMarkedCircleOutline, "SBER", "1379.50 ₽", "+11.30 ₽ (0.8%)"));
            var item6 = new ItemMenu("Акции", menuStock, PackIconKind.ChartDonut);

            var menuCurrency = new List<SubItem>();
            menuCurrency.Add(new SubItem(PackIconKind.CurrencyRub, "Services", "₽", "+11.30 ₽ (0.8%)"));
            menuCurrency.Add(new SubItem(PackIconKind.CurrencyRub, "Meetings", "₽", "+11.30 ₽ (0.8%)"));
            var item1 = new ItemMenu("Валюта", menuCurrency, PackIconKind.ChartDonut);


            var menuMetals = new List<SubItem>();
            menuMetals.Add(new SubItem(PackIconKind.DiamondOutline, "Cash flow", "$", "+11 (0.8%)"));
            var item4 = new ItemMenu("Драгоценные металлы", menuMetals, PackIconKind.ChartDonut);

            //var item0 = new ItemMenu("Dashboard", new UserControl(), PackIconKind.ViewDashboard);

            //Menu.Children.Add(new UserControlMenuItem(item0));
            Menu.Children.Add(new UserControlMenuItem(item6));
            Menu.Children.Add(new UserControlMenuItem(item1));
            Menu.Children.Add(new UserControlMenuItem(item4));




            var item10 = new ItemMenu(PackIconKind.History, "SBER", "1379.50 ₽");
            var item11 = new ItemMenu(PackIconKind.History, "SBER", "768 ₽");
            var item12 = new ItemMenu(PackIconKind.History, "SBER", "768 ₽");

            Menu2.Children.Add(new UserControlMenuItem(item10));
            Menu2.Children.Add(new UserControlMenuItem(item11));
            Menu2.Children.Add(new UserControlMenuItem(item12));

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
