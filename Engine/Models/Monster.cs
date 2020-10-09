﻿using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Monster : BaseNotification
    {
        private int _hitPoints;

        public string Name { get; set; }
        public string ImageName { get; set; }
        public int MaxHitPoints { get; set; }
        public int HitPoints
        {
            get { return _hitPoints; }
            private set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            } 
        }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int hitPoints,
            int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = string.Format($"/Engine;component/Images/Monsters{imageName}");
            MaxHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}