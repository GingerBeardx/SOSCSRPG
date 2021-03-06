﻿namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsUnique { get; set; }

        public GameItem(int itemTypeId, string name, int price, bool isUnique = false)
        {
            ItemTypeId = itemTypeId;
            Name = name;
            Price = price;
            IsUnique = isUnique;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeId, Name, Price, IsUnique);
        }
    }
}
