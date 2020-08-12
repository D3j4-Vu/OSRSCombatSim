﻿using OSRSComSim.Models;
using OSRSComSim.ViewModels;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OSRSComSim.Views
{
    public partial class SkillsView : UserControl
    {
        private SkillsViewModel view_model;
        public SkillsView(SkillsViewModel VM)
        {
            view_model = VM;
            DataContext = view_model;
            InitializeComponent();
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            view_model.editPlayerSkills(((Button)sender).Tag.ToString(), -1);
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            view_model.editPlayerSkills(((Button)sender).Tag.ToString(), 1);
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            view_model.resetPlayerSkills();
        }

        private void BtnRandom_Click(object sender, RoutedEventArgs e)
        {
            view_model.setRandomPlayerSkills();
        }
    }
}
