﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Constants
{
    public class ConfigurationContants
    {
        /// <summary>
        /// Custom date format.
        /// </summary>
        public const string SqlDateFormat = "date";

        /// <summary>
        /// Custom img type.
        /// </summary>
        public const string SqlAvatarFormat = "Varbinary(Max)";

        /// <summary>
        /// Min lenght for string field.
        /// </summary>
        public const int SqlMaxLengthShort = 63;

        /// <summary>
        /// Standart lenght for string field.
        /// </summary>
        public const int SqlMaxLengthMedium = 127;

        /// <summary>
        /// Max lenght for string field.
        /// </summary>
        public const int SqlMaxLengthLong = 600;
    }
}
