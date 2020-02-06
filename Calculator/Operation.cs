using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    class Operation
    {
        #region Public Properties

        public string LeftSide { get; set; } // Right side of operation
        public string RightSide { get; set; } // Left side of operation
        public OperationType OperationType { get; set; } // The type of operation to perform
        public Operation InnerOpeartion { get; set; } // The inner operation to be performed initially before this operation

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Operation()
        {
            // Create empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion
    }
}
