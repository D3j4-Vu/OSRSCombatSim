﻿using OSRSComSim.Models;
using OSRSComSim.Views;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace OSRSComSim.ViewModels
{
   public class LoadScreenViewModel: ObservableObject
    {
        private string                          _fighter_num;
        public object                           _viewcontent;

        private ControlPanelViewModel           _controls_view;
        private MainWindowViewModel             _mainwindowVM;
        private Player                          _selected_player;

        private ObservableCollection<Player>    _player_list;


        public LoadScreenView                   View { get; set; }
        public ControlPanelViewModel            ControlsView
        {
            get
            {
                return _controls_view;
            }
            set
            {
                _controls_view = value;
                OnPropertyChanged("ControlsView");
            }
        }

        public ObservableCollection<Player>     PlayerList 
        {
            get
            {
                return _player_list;
            }
            private set
            {
                _player_list = value;
                OnPropertyChanged("PlayerList");
            }
        }
        public object                           ViewContent
        {
            get
            {
                return _viewcontent;
            }
            private set
            {
                _viewcontent = value;
                OnPropertyChanged("ViewContent");
            }
        }
        public Player                           SelectedPlayer
        {
            get 
            {
                return _selected_player;
            }
            set
            {
                _selected_player = value;

                ControlsView.SelectedPlayer = _selected_player;

                OnPropertyChanged("SelectedPlayer");
            }
        }

        public LoadScreenViewModel() : this(null, null) { }
        public LoadScreenViewModel(MainWindowViewModel mainWindowVM = null, string fighter_num = null)
        {
            _mainwindowVM = mainWindowVM;
            _player_list = new ObservableCollection<Player>();
            _selected_player = new Player();
            _fighter_num = fighter_num;
            ControlsView = new ControlPanelViewModel(this, SelectedPlayer, "View");
            Load_players();

            View = new LoadScreenView(this);
        }


        public void Back_to_main_screen()
        {
            _mainwindowVM.stopView();
        }
        public void viewCreatePlayer()
        {
            ViewContent = new ControlPanelViewModel(this, cp_mode: "Create").View;
        }
        public void viewrEditPlayer()
        {
            ViewContent = new ControlPanelViewModel(this, SelectedPlayer, "Create").View;
        }
        public void stopView()
        {
            ViewContent = null;
        }
        public void outline_button(Button btn)
        {

        }
        public void delete_player(string name) {
            Data_store.DeletePlayer(name);
            Load_players();
            SelectedPlayer = new Player();
        }
        public void loadSelectedFighter(string fighter_num)
        {
            if (HasNoSpecialChars(SelectedPlayer.Name))
            {
                loadFighter(fighter_num);
                Back_to_main_screen();
            }
        }

        public bool HasNoSpecialChars(string yourString)
        {
            return !yourString.Any(ch => !Char.IsLetterOrDigit(ch));
        }

        public void getPlayer(string fighter_num) {
            foreach(Player player in PlayerList)
            {
                if (player.Name == fighter_num)
                {
                    SelectedPlayer = player;
                }
            }
        }
        public void Load_players()
        {
            PlayerList.Clear();
            Data_store.LoadPlayers(PlayerList);
            PlayerList = PlayerList;
        }
        private void loadFighter(string fighter_num)
        {
            if (_fighter_num == "fighter 1")
            {
                _mainwindowVM.Battle.Fighter1 = new FighterViewModel(SelectedPlayer);
            }
            else if (_fighter_num == "fighter 2")
            {
                _mainwindowVM.Battle.Fighter2 = new FighterViewModel(SelectedPlayer);
            }
        }
    }
}
