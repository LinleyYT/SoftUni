using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Pet_Clinic
{
    public class Clinic
    {
        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.NumberOfRooms = rooms;
            this.OccupiedRooms = new List<Pet>();

            for (int i = 0; i < this.NumberOfRooms; i++)
            {
                this.OccupiedRooms.Add(null);
            }
        }
        private int numberOfRooms;

        public string Name { get; set; }
        public int NumberOfRooms
        {
            get { return this.numberOfRooms; }
            private set
            {
                if (value % 2 == 0 || value < 1 || value > 101)
                {
                    throw new ArgumentException("Invalid Operation!");
                }
                this.numberOfRooms = value;
            }
        }

        public List<Pet> OccupiedRooms { get; set; }

        public bool HasRooms()
        {
            if (this.OccupiedRooms.Any(x => x == null))
            {
                return true;
            }
            return false;
        }

        public bool AddPet(Pet pet)
        {
            if (pet == null)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            if (!this.HasRooms())
            {
                return false;
            }

            var currentIndex = this.NumberOfRooms / 2;
            var counter = 1;

            for (int i = 0; i < this.OccupiedRooms.Count; i++)
            {
                if (this.OccupiedRooms[currentIndex] == null)
                {
                    this.OccupiedRooms[currentIndex] = pet;
                    return true;
                }

                if (currentIndex < this.OccupiedRooms.Count / 2)
                {
                    currentIndex = this.OccupiedRooms.Count / 2 + counter;
                    counter++;
                }
                else
                {
                    currentIndex = this.OccupiedRooms.Count / 2 - counter;
                }
            }
            return false;
        }

        public bool Release()
        {
            for (int i = this.OccupiedRooms.Count / 2; i < this.OccupiedRooms.Count; i++)
            {
                if (this.OccupiedRooms[i] != null)
                {
                    this.OccupiedRooms[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < this.OccupiedRooms.Count / 2; i++)
            {
                if (this.OccupiedRooms[i] != null)
                {
                    this.OccupiedRooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var pet in this.OccupiedRooms)
            {
                sb.AppendLine(pet?.ToString() ?? "Room empty");
            }

            return sb.ToString().Trim();
        }
    }
}