using System;
using System.Collections.Generic;
using DDK.Helper;

namespace DDK.Command
{
    public class CommandHelper
    {
        public List<string> BuildOutput(dynamic config, string projectDir, bool isValid)
        {
            List<string> outputList = new List<string>();

            string version = new AssemblyHelper().GetAssemblyVersion();
            outputList.Add($"DDK version {version}");
            outputList.Add("");

            if (isValid)
            {
                outputList.Add("Configured commands:");
                outputList.Add("");
                outputList = BuildCommandOutput(outputList, config);
            }

            return outputList;
        }

        private List<string> BuildCommandOutput(List<string> outputList, dynamic config)
        {
            try
            {
                foreach (dynamic group in config.groups)
                {
                    foreach (dynamic command in group)
                    {
                        outputList.Add(group.Name);
                        foreach (dynamic item in command)
                        {
                            string output = "";
                            output = AppendCommandName(item, output);
                            output = AppendRequiredArguments(item.Value, output);
                            output = AppendOptionalArguments(item.Value, output);
                            output = AppendDescription(item.Value, output);

                            outputList.Add($"  {output}");
                        }
                    }
                }

                return outputList;
            } catch (Exception e)
            {
                Log.Error(e.Message);
                return null;
            }
        }

        private string AppendCommandName(dynamic command, string output)
        {
            return $"{output}{command.Name}";
        }

        private string AppendRequiredArguments(dynamic item, string output)
        {
            string requiredArguments = "";
            if (DynamicHelper.HasProperty(item, "allowArguments")
                && item.allowArguments == "True"
                && DynamicHelper.HasProperty(item, "requiredArguments"))
            {
                foreach (string requiredArgument in item.requiredArguments)
                {
                    requiredArguments += $" <{requiredArgument}>";
                }
            }

            return $"{output}{requiredArguments}";
        }

        private string AppendOptionalArguments(dynamic item, string output)
        {
            string optionalArguments = "";
            if (DynamicHelper.HasProperty(item, "allowArguments")
                && item.allowArguments == "True"
                && DynamicHelper.HasProperty(item, "optionalArguments"))
            {
                foreach (string optionalArgument in item.optionalArguments)
                {
                    optionalArguments += $" [<{optionalArgument}>]";
                }
            }

            return $"{output}{optionalArguments}";
        }

        private string AppendDescription(dynamic item, string output)
        {
            return $"{output.PadRight(50)}{item.description}";
        }
    }
}
