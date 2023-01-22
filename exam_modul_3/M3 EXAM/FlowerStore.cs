using System;
using System.Collections.Generic;
using System.Linq;

namespace RegularExam
{
    internal class FlowerStore
    {
        private List<Flower> flowers;
        public List<Flower> Flowers
        {
            get { return flowers; }
            set { flowers = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 6) name = value;
                else throw new ArgumentException("Invalid flower store name!");
            }
        }
        public FlowerStore(string name)
        {
            Name = name;
            Flowers = new List<Flower>();
        }
        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }
        public bool SellFlower(Flower flower)
        {
            Flower temp = Flowers.Find(x => x.Price == flower.Price);
            if (temp != null)
            {
                Flowers.Remove(temp);
                return true;
            }
            else return false;
        }
        public double CalculateTotalPrice()
        {
            return Flowers.Sum(x => x.Price);
        }
        public Flower GetFlowerWithHighestPrice()
        {
            return Flowers.OrderByDescending(x => x.Price).First();
        }
        public Flower GetFlowerWithLowestPrice()
        {
            return Flowers.OrderBy(x => x.Price).First();
        }
        public void RenameFlowerStore(string newName)
        {
            Name = newName;
        }
        public void SellAllFlowers()
        {
            Flowers.Clear();
        }
        public override string ToString()
        {
            if (Flowers.Count >= 1) return $"Flower store {Name} has {Flowers.Count} flower/s:\n{string.Join("\n", Flowers)}";
            else return $"Flower store {Name} has no available flowers.";
        }
    }
}