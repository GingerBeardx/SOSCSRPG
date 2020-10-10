using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Engine.Models
{
    /// <summary>
    /// This class handles the player information.
    /// </summary>
    public class Player : LivingEntity
    {
        private string _characterClass;
        private int _experiencePoints;
        private int _level;

        public string CharacterClass
        {
            get { return _characterClass; } //enables the ability to update our main window with updated values.
            set
            {
                _characterClass = value;
                OnPropertyChanged(nameof(CharacterClass));
            }
        }
        public int ExperiencePoints 
        { 
            get { return _experiencePoints; } //enables the ability to update our main window with updated values.
            set 
            { 
                _experiencePoints = value;
                OnPropertyChanged(nameof(ExperiencePoints));
            } 
        }
        public int Level
        {
            get { return _level; } //enables the ability to update our main window with updated values.
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }

        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Quests = new ObservableCollection<QuestStatus>();
        }

        public bool HasAllTheseItems(List<ItemQuantity> items)
        {
            foreach (ItemQuantity item in items)
            {
                if (Inventory.Count(i => i.ItemTypeId == item.ItemId) < item.Quantity)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
