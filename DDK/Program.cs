using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DDK.Command;
using DDK.Helper;
using DDK.Reader;
using DDK.Validator;

namespace DDK
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectDir = Directory.GetCurrentDirectory();
            List<string> argsList = args.ToList();

            ConfigReader configReader = new ConfigReader(projectDir);
            dynamic config = configReader.Read();

            ConfigValidator configValidator = new ConfigValidator();
            List<string> errorList = configValidator.Validate(config);
            bool isValid = (errorList.Count == 0);

            if (isValid && args.Length > 0)
            {
                CommandMatch commandMatch = new CommandMatch(config);

                if (commandMatch.IsInternalCommand(argsList.First()))
                {
                    InternalCommandExecuter internalCommandExecuter = new InternalCommandExecuter();

                    if (internalCommandExecuter.Execute(argsList))
                    {
                        IO.Write(internalCommandExecuter.GetCommandOutput());
                    } else
                    {
                        IO.Write(internalCommandExecuter.GetLastErrorMessage());
                    }
                }
                else
                {

                    dynamic command = commandMatch.Match(argsList.First());

                    CommandExecuter commandExecuter = new CommandExecuter();
                    argsList.RemoveAt(0);

                    bool allowedToFail = true;

                    if (DynamicHelper.HasProperty(command, "allowedToFail") && command.allowedToFail == "False")
                    {
                        allowedToFail = false;
                    }

                    if (!commandExecuter.Execute(command.commands, argsList, allowedToFail))
                    {
                        IO.Write(commandExecuter.GetLastErrorMessage());
                    }
                }
            } else
            {
                CommandHelper commandHelper = new CommandHelper();
                IO.Write(commandHelper.BuildOutput(config, projectDir, isValid));
                IO.Write(errorList);
            }
        }
    }
}
