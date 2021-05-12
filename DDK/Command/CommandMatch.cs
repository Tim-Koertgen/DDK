using System;
using System.Collections.Generic;

namespace DDK.Command
{
    public class CommandMatch
    {
        private List<string> _internalCommands;
        private dynamic _config;

        public CommandMatch(dynamic config)
        {
            _config = config;
            _internalCommands = new List<string>();

            _internalCommands.Add("--version");
        }

        public bool IsInternalCommand(string command)
        {
            try
            {
                return _internalCommands.Contains(command);
            } catch (Exception e)
            {
                Log.Error(e.Message);
                return false;
            }
        }

        public dynamic Match(string command)
        {
            try
            {
                foreach(dynamic group in _config.groups)
                {
                    foreach (dynamic cmd in group)
                    {
                        foreach (dynamic item in cmd)
                        {
                            if (command.Equals(item.Name))
                            {
                                return item.Value;
                            }
                        }
                    }
                }

                return null;
            } catch (Exception e)
            {
                Log.Error(e.Message);
                return null;
            }
        }
    }
}
