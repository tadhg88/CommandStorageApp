using System.Collections.Generic;
using CommandStorageApp.Models;

namespace CommandStorageApp.Data
{
    public interface ICommandStorageAppRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);
    }
}