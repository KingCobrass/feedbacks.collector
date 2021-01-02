using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.Collector.Utilities.ResponseCodes
{
    public class FCResponseCode
    {
        #region Users 000-020
        /// <summary>
        /// FCAPI000: User signup success
        /// </summary>
        public const string FCAPI000 = "FCAPI000";
        public const string FCAPI000_MESSAGE = "User signup success";
        /// <summary>
        /// FCAPI001: Failed user signup
        /// </summary>
        public const string FCAPI001 = "FCAPI001";
        public const string FCAPI001_MESSAGE = "User signup failed";
        #endregion


        #region System error (021-040)
        /// <summary>
        /// 021-040 for System 
        /// FCAPI021: Unexpected system error. Please try again.
        /// </summary>
        public const string FCAPI021 = "FCAPI021";
        public const string FCAPI021_MESSAGE = "Unexpected system error. Please try again";
        #endregion
        #region Common (041-060)

        /// <summary>
        /// 041-060 for common 
        /// FCAPI041: Required parameter can not be null or empty
        /// </summary>
        public const string FCAPI041 = "FCAPI041";
        public const string FCAPI041_MESSAGE = "Required parameter can not be null or empty";
        /// <summary>
        /// FCAPI042: No Data Found
        /// </summary>
        public const string FCAPI042 = "FCAPI042";
        public const string FCAPI042_MESSAGE = "No Data Found";
        /// <summary>
        /// FCAPI042: Data Found
        /// </summary>
        public const string FCAPI043 = "FCAPI043";
        public const string FCAPI043_MESSAGE = "Data Found";
        #endregion
    }
}
