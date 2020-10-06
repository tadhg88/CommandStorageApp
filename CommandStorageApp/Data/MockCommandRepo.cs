using System.Collections.Generic;
using CommandStorageApp.Models;

namespace CommandStorageApp.Data
{
    public class MockCommandRepo : ICommandStorageAppRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            return new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "boil egg 1",
                    Line = "my line",
                    Platform = "windows"
                },
                new Command
                {
                    Id = 0,
                    HowTo = "boil egg 2",
                    Line = "my line 2",
                    Platform = "windows 2"
                },
                new Command
                {
                    Id = 0,
                    HowTo = "boil egg 3",
                    Line = "my line 3",
                    Platform = "windows 3"
                }
            };
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "boil egg",
                Line = "my line",
                Platform = "windows"
            };
        }
    }
}