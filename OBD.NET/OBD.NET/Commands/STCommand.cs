﻿namespace OBD.NET.Commands
{
    public class STCommand
    {
        #region Values

        //TODO DarthAffe 19.03.2017: Implement all commands

        internal static readonly STCommand AddPassFilter = new STCommand("STFAP");
        internal static readonly STCommand AddBlockFilter = new STCommand("STFAB");
        internal static readonly STCommand AddFlowControlFilter = new STCommand("STFAFC");
        internal static readonly STCommand ClearPassFilters = new STCommand("STFCP");
        internal static readonly STCommand ClearBlockFilters = new STCommand("STFCB");
        internal static readonly STCommand ClearFlowControlFilters = new STCommand("STFCFC");
        internal static readonly STCommand Monitor = new STCommand("STM");
        internal static readonly STCommand MonitorAll = new STCommand("STMA");

        #endregion

        #region Properties & Fields

        public string Command { get; }

        #endregion

        #region Constructors

        protected STCommand(string command)
        {
            this.Command = command;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Command;
        }

        #endregion

        #region Operators

        public static implicit operator string(STCommand command)
        {
            return command.ToString();
        }

        #endregion
    }
}
