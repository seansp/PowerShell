//
//    Copyright (C) Microsoft.  All rights reserved.
//

using Microsoft.PowerShell.Activities;
using System.Management.Automation;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;


namespace Microsoft.PowerShell.Security.Activities
{
    /// <summary>
    /// Activity to invoke the Microsoft.PowerShell.Security\ConvertFrom-SecureString command in a Workflow.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.PowerShell.Activities.ActivityGenerator.GenerateFromName", "3.0")]
    public sealed class ConvertFromSecureString : PSRemotingActivity
    {
        /// <summary>
        /// Gets the display name of the command invoked by this activity.
        /// </summary>
        public ConvertFromSecureString()
        {
            this.DisplayName = "ConvertFrom-SecureString";
        }

        /// <summary>
        /// Gets the fully qualified name of the command invoked by this activity.
        /// </summary>
        public override string PSCommandName { get { return "Microsoft.PowerShell.Security\\ConvertFrom-SecureString"; } }

        // Arguments

        /// <summary>
        /// Provides access to the SecureString parameter.
        /// </summary>
        [ParameterSpecificCategory]
        [DefaultValue(null)]
        public InArgument<System.Security.SecureString> SecureString { get; set; }

        /// <summary>
        /// Provides access to the SecureKey parameter.
        /// </summary>
        [ParameterSpecificCategory]
        [DefaultValue(null)]
        public InArgument<System.Security.SecureString> SecureKey { get; set; }

        /// <summary>
        /// Provides access to the Key parameter.
        /// </summary>
        [ParameterSpecificCategory]
        [DefaultValue(null)]
        public InArgument<System.Byte[]> Key { get; set; }


        // Module defining this command


        // Optional custom code for this activity


        /// <summary>
        /// Returns a configured instance of System.Management.Automation.PowerShell, pre-populated with the command to run.
        /// </summary>
        /// <param name="context">The NativeActivityContext for the currently running activity.</param>
        /// <returns>A populated instance of System.Management.Automation.PowerShell</returns>
        /// <remarks>The infrastructure takes responsibility for closing and disposing the PowerShell instance returned.</remarks>
        protected override ActivityImplementationContext GetPowerShell(NativeActivityContext context)
        {
            System.Management.Automation.PowerShell invoker = global::System.Management.Automation.PowerShell.Create();
            System.Management.Automation.PowerShell targetCommand = invoker.AddCommand(PSCommandName);

            // Initialize the arguments

            if (SecureString.Expression != null)
            {
                targetCommand.AddParameter("SecureString", SecureString.Get(context));
            }

            if (SecureKey.Expression != null)
            {
                targetCommand.AddParameter("SecureKey", SecureKey.Get(context));
            }

            if (Key.Expression != null)
            {
                targetCommand.AddParameter("Key", Key.Get(context));
            }


            return new ActivityImplementationContext() { PowerShellInstance = invoker };
        }
    }
}
