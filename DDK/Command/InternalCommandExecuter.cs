using System;
using System.Collections.Generic;
using System.Linq;
using DDK.Helper;

namespace DDK.Command
{
    public class InternalCommandExecuter
    {
        private string _lastErrorMessage;
        private List<string> _outputList;

        public InternalCommandExecuter()
        {
            _outputList = new List<string>();
        }

        public string GetLastErrorMessage()
        {
            return _lastErrorMessage;
        }

        public List<string> GetCommandOutput()
        {
            return _outputList;
        }

        public bool Execute(List<string> argsList)
        {
            try
            {
                switch (argsList.First())
                {
                    case "--version":
                        string version = new AssemblyHelper().GetAssemblyVersion();
                        _outputList.Add($"DDK version {version}");
                        break;
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
