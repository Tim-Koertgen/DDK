using System;
using System.Collections.Generic;
using DDK.Helper;
namespace DDK.Validator
{
    public class ConfigValidator
    {
        private List<string> _requiredCommandKeysList;

        public ConfigValidator()
        {
            _requiredCommandKeysList = new List<string>();
            _requiredCommandKeysList.Add("commands");
            _requiredCommandKeysList.Add("description");
        }

        public List<string> Validate(dynamic config)
        {
            try
            {
                
                List<string> errorList = new List<string>();

                if (config != null)
                {
                    errorList = ValidateGroups(errorList, config);

                    foreach (dynamic group in config.groups)
                    {
                        foreach (dynamic command in group)
                        {
                            foreach (dynamic item in command)
                            {
                                errorList = ValidateCommandKeys(errorList, item);
                            }
                        }
                    }
                } else
                {
                    errorList.Add("No .ddk.json config file found");
                }

                return errorList;
            } catch (Exception e)
            {
                Log.Error(e.Message);
                return null;
            }
        }

        private List<string> ValidateGroups(List<string> errorList, dynamic config)
        {
            if (!DynamicHelper.HasProperty(config, "groups"))
            {
                errorList.Add("Groups key missing");
            }

            return errorList;
        }

        private List<string> ValidateCommandKeys(List<string> errorList, dynamic item)
        {
            foreach (string requiredKey in _requiredCommandKeysList)
            {
                if (!DynamicHelper.HasProperty(item.Value, requiredKey))
                {
                    errorList.Add($"Required key [{requiredKey}] missing in [{item.Name}] command");
                }
            }

            return errorList;
        }
    }
}
