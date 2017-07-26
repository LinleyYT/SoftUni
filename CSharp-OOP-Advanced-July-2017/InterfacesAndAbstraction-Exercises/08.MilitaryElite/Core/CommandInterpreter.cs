using System;
using System.Collections.Generic;
using System.Linq;
using _08.MilitaryElite.Models.Classes;
using _08.MilitaryElite.Models.Interfaces;

namespace _08.MilitaryElite.Core
{
    public class CommandInterpreter
    {
        public CommandInterpreter()
        {
            this.DataManager = new DataManager();
        }
        public DataManager DataManager { get; set; }

        public void Run()
        {
            var input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    var inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    ExecuteCommand(inputArgs);
                }
                catch (Exception e)
                {
                }
            }

            foreach (var soldier in DataManager.Soldiers)
            {
                Console.WriteLine(soldier.ToString().Trim());
            }
        }

        private void ExecuteCommand(string[] inputArgs)
        {
            var soldier = CreateSoldier(inputArgs);
            DataManager.AddSoldier(soldier);
        }

        public ISoldier CreateSoldier(string[] soldierStrings)
        {
            var soldierType = soldierStrings[0];
            var id = int.Parse(soldierStrings[1]);
            var firstName = soldierStrings[2];
            var lastName = soldierStrings[3];

            switch (soldierType)
            {
                case "Private":
                    var privateSalary = double.Parse(soldierStrings[4]);
                    return new Private(id, firstName, lastName, privateSalary);
                case "LeutenantGeneral":
                    var ltSalary = double.Parse(soldierStrings[4]);
                    var currentLt = new LeutenantGeneral(id, firstName, lastName, ltSalary);

                    for (int i = 5; i < soldierStrings.Length; i++)
                    {
                        var privateId = int.Parse(soldierStrings[i]);
                        if (DataManager.SoldierExists(privateId))
                        {
                            currentLt.AddPrivate(DataManager.ReturnPrivateSoldier(privateId));
                        }
                    }

                    return currentLt;
                case "Engineer":
                    var engineerSalary = double.Parse(soldierStrings[4]);
                    var corps = soldierStrings[5];
                    var currentEngineer = new Engineer(id, firstName, lastName, engineerSalary, corps);

                    for (int i = 6; i < soldierStrings.Length; i += 2)
                    {
                        var part = soldierStrings[i];
                        var hours = int.Parse(soldierStrings[i + 1]);
                        var repair = new Repair(part, hours);
                        currentEngineer.AddRepair(repair);
                    }

                    return currentEngineer;
                case "Commando":
                    var commandoSalary = double.Parse(soldierStrings[4]);
                    var commandoCorps = soldierStrings[5];
                    var currentCommando = new Commando(id, firstName, lastName, commandoSalary, commandoCorps);

                    for (int i = 6; i < soldierStrings.Length; i += 2)
                    {
                        try
                        {
                            var codeName = soldierStrings[i];
                            var state = soldierStrings[i + 1];
                            var mission = new Mission(codeName, state);
                            currentCommando.AddMission(mission);
                        }
                        catch (Exception e)
                        {
                        }
                    }

                    return currentCommando;
                case "Spy":
                    var codeNumber = int.Parse(soldierStrings[4]);
                    return new Spy(id, firstName, lastName, codeNumber);
                default:
                    return null;
            }
        }
    }
}