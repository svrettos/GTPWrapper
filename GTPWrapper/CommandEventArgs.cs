﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTPWrapper {
    /// <summary>
    /// Provides command data for events.
    /// </summary>
    public class CommandEventArgs {
        /// <summary>
        /// Gets or sets the GTP command.
        /// </summary>
        public Command Command { get; set; }

        /// <summary>
        /// Initializes a new instance of the CommandEventArgs class.
        /// </summary>
        /// <param name="command">The command.</param>
        public CommandEventArgs(Command command) {
            this.Command = command;
        }
    }
}
