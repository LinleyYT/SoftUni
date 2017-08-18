using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using _02.Blobs.Attributes;
using _02.Blobs.Interfaces;

namespace _02.Blobs.Core
{
    public class CommandInterpreter : ICommandInterpretable
    {
        private const string CommandSuffix = "Command";

        private IRepository repository;
        private IBehaviourFactory behaviourFactory;
        private IAttackFactory attackFactory;

        public CommandInterpreter(IRepository repository, IBehaviourFactory behaviourFactory, IAttackFactory attackFactory)
        {
            this.repository = repository;
            this.behaviourFactory = behaviourFactory;
            this.attackFactory = attackFactory;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            var command = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandSuffix;

            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == command);

            object[] commandParams =
            {
                data
            };

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }

            IExecutable currentCommand = (IExecutable)Activator.CreateInstance(commandType, commandParams);

            currentCommand = this.InjectDependencies(currentCommand);

            return currentCommand;
        }

        private IExecutable InjectDependencies(IExecutable currentCommand)
        {
            FieldInfo[] fields = currentCommand.GetType()
                .GetFields(BindingFlags.Instance
                           | BindingFlags.NonPublic)
                .Where(f => f.GetCustomAttributes<InjectAttribute>() != null).ToArray();

            FieldInfo[] interpreterFields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                field.SetValue(currentCommand, interpreterFields
                    .FirstOrDefault(f => f.FieldType == field.FieldType)
                    .GetValue(this));
            }

            return currentCommand;
        }
    }
}