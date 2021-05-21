using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace DDK.Command
{
    public class CommandExecuter
    {
        private string _lastErrorMessage;
        private CommandMatch _commandMatch;

        public CommandExecuter(CommandMatch commandMatch)
        {
            _commandMatch = commandMatch;
        }

        public string GetLastErrorMessage()
        {
            return _lastErrorMessage;
        }

        public bool Execute(dynamic commands, List<string> argsList, bool allowedToFail)
        {
            try
            {
                foreach (string command in commands)
                {
                    dynamic match = _commandMatch.Match(command);
                    if (match != null)
                    {
                        if (match.commands == commands)
                        {
                            IO.Write($"Loop found. Skipping execution.");
                            continue;
                        }

                        this.Execute(match.commands, argsList, allowedToFail);
                        continue;
                    }

                    List<string> commandList = command.Split(' ').ToList();
                    string fileName = commandList.First();

                    commandList.RemoveAt(0);

                    foreach (string arg in argsList)
                    {
                        commandList.Add(arg);
                    }

                    string arguments = string.Join(' ', commandList);

                    ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = fileName, Arguments = arguments, };
                    Process proc = new Process() { StartInfo = startInfo, };
                    proc.Start();

                    while (!proc.HasExited)
                    {
                        Thread.Sleep(100);
                    }

                    if (proc.ExitCode != 0 && allowedToFail == false)
                    {
                        break;
                    }
                }

                return true;
            } catch (Exception e)
            {
                _lastErrorMessage = e.Message;
                Log.Error(e.Message);
                return false;
            }
        }
    }
}
