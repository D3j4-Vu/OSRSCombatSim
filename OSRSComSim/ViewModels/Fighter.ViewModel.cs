﻿using OSRSComSim.Models;
using OSRSComSim.Views;
using System;
using System.Threading;

namespace OSRSComSim.ViewModels
{
    public class FighterViewModel : ObservableObject
    {
        const int gameticks = 600;
        private const int status_show_time = 1000;

        Thread th_show_stats;

        
        public object View { get; set; }
        public ControlPanelViewModel ControlPanel { get; set; }
        public string Name { get; set; }
        public PlayerModel Fighter { get; set; }
        public CombatModel FighterCombat { get; set; }

        public string LastAtkStatColor { get; set; }
        public string LastAtkStatContext { get; set; }


        public FighterViewModel(): this (null) { }
        public FighterViewModel(PlayerModel selectedplayer = null)
        {
            if (selectedplayer == null) selectedplayer = new PlayerModel();
            ControlPanel = new ControlPanelViewModel(player: selectedplayer, cp_mode: "Interactive");
            Name = selectedplayer.Name;
            Fighter = selectedplayer;
            FighterCombat = selectedplayer.Combat;
            WeaponTypeModel.setOptions(selectedplayer.Combat, selectedplayer.Equiped.Weapon.WeaponType);
            setupFighter();

            View = new FighterView(this);
        }
        private void setupFighter()
        {
            LastAtkStatColor = "Transparent";
            LastAtkStatContext = "";
        }


        public string getAttackRessult(PlayerModel deffender)
        {
            int deffender_def_roll = CombatModel.Deffend(deffender, FighterCombat);
            return CombatModel.Attack(Fighter, deffender_def_roll);
        }
        private Thread startStatusShow(string context, string color)
        {
            var t = new Thread(() => statusShow(context, color));
            t.Start();
            return t;
        }
        private void statusShow(string context, string color)
        {
            LastAtkStatColor = color;
            LastAtkStatContext = context;
            Thread.Sleep(status_show_time);
            LastAtkStatColor = "Transparent";
            LastAtkStatContext = "";
        }

        public void rest()
        {
            Thread.Sleep((Fighter.Equiped.getTotalSpeed() - FighterCombat.CurretOptions.StancBonusSpd) * gameticks);
        }
        public void takeDamage(string attack_res)
        {
            if (attack_res == "def")
            {
                th_show_stats = startStatusShow("0", "Blue");
            }
            else if (attack_res == "Message")
            {
                th_show_stats = startStatusShow("Debug: you cant attack", "Transparent");
            }
            else
            {
                StatusModel.takeDmage(Fighter.Skills.Status, int.Parse(attack_res));
                th_show_stats = startStatusShow(attack_res.ToString(), "Red");
            }
        }
        public bool isDead()
        {
            return Fighter.Skills.Status.HealthTaken == 100;
        }
        public void Reset()
        {
            StatusModel.reset_status(Fighter.Skills.Status);
            LastAtkStatColor = "Transparent";
            LastAtkStatContext = "";
        }

    }
}
