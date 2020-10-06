﻿using System.ComponentModel;

namespace Engine.Models
{
    /// <summary>
    /// This class handles the player information.
    /// </summary>
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name
        {
            get { return _name; } //enables the ability to update our main window with updated values.
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass
        {
            get { return _characterClass; } //enables the ability to update our main window with updated values.
            set
            {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }
        public int HitPoints
        {
            get { return _hitPoints; } //enables the ability to update our main window with updated values.
            set
            {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int ExperiencePoints 
        { 
            get { return _experiencePoints; } //enables the ability to update our main window with updated values.
            set 
            { 
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            } 
        }
        public int Level
        {
            get { return _level; } //enables the ability to update our main window with updated values.
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold
        {
            get { return _gold; } //enables the ability to update our main window with updated values.
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
