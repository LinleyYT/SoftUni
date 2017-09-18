using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Pet_Clinic
{
    public class CommandInterpreter
    {
        public CommandInterpreter()
        {
            this.ListOfPets = new List<Pet>();
            this.Clinics = new List<Clinic>();
        }

        public List<Clinic> Clinics { get; private set; }
        public IList<Pet> ListOfPets { get; private set; }

        public void Run()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandArgs = Console.ReadLine()
                    .Trim()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    ExecuteCommand(commandArgs);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void ExecuteCommand(string[] commandArgs)
        {
            var command = commandArgs[0];

            if (command == "Create")
            {
                command += $" {commandArgs[1]}";
            }

            switch (command)
            {
                case "Create Pet":
                    CreatePet(commandArgs.Skip(2).ToArray());
                    break;

                case "Create Clinic":
                    CreateClinic(commandArgs.Skip(2).ToArray());
                    break;

                case "Add":
                    Console.WriteLine(this.AddPetToClinic(commandArgs.Skip(1).ToArray()));
                    break;

                case "HasEmptyRooms":
                    Console.WriteLine(this.HasRooms(commandArgs.Skip(1).ToArray()));
                    break;

                case "Print":
                    Print(commandArgs.Skip(1).ToArray());
                    break;

                case "Release":
                    Console.WriteLine(this.Release(commandArgs.Skip(1).ToArray()));
                    break;
            }
        }

        private bool Release(string[] strings)
        {
            var clinicToRelease = strings[0];

            return this.Clinics.FirstOrDefault(x => x.Name == clinicToRelease).Release();
        }

        private void Print(string[] strings)
        {
            var clinicToPrint = strings[0];

            if (strings.Length == 1)
            {
                Console.WriteLine(this.Clinics.FirstOrDefault(x => x.Name == clinicToPrint));
            }
            else
            {
                var roomToPrint = int.Parse(strings[1]) - 1;
                if (this.Clinics.FirstOrDefault(x => x.Name == clinicToPrint).OccupiedRooms[roomToPrint] == null)
                {
                    Console.WriteLine("Room empty");
                }
                else
                {
                    Console.WriteLine(this.Clinics.FirstOrDefault(x => x.Name == clinicToPrint)
                        .OccupiedRooms[roomToPrint]);
                }
            }
        }

        private bool HasRooms(string[] strings)
        {
            var clinicToCheck = strings[0];

            return this.Clinics.FirstOrDefault(x => x.Name == clinicToCheck).HasRooms();
        }

        private bool AddPetToClinic(string[] strings)
        {
            var petName = strings[0];
            var clinicName = strings[1];

            return this.Clinics.FirstOrDefault(x => x.Name == clinicName)
                .AddPet(this.ListOfPets.FirstOrDefault(x => x.Name == petName));
        }

        private void CreateClinic(string[] strings)
        {
            var clinicName = strings[0];
            var clinicRooms = int.Parse(strings[1]);

            var clinic = new Clinic(clinicName, clinicRooms);
            Clinics.Add(clinic);
        }

        private void CreatePet(string[] createPetStrings)
        {
            var name = createPetStrings[0];
            var age = int.Parse(createPetStrings[1]);
            var kind = createPetStrings[2];

            var currentPet = new Pet(name, age, kind);

            this.AddToListOfPets(currentPet);
        }

        private void AddToListOfPets(Pet currentPet)
        {
            this.ListOfPets.Add(currentPet);
        }
    }
}