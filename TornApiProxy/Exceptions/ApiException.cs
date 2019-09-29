/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2019  TornCityPro
  
  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.
  
  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.
  
  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
************************************************************************/

﻿namespace TornApiProxy.Exceptions
{
    using Contract.Shared;
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An extension of exception specific to exceptions thrown by the Torn API
    /// </summary>
    [Serializable()]
    public class ApiException : Exception
    {
        /// <summary>
        /// Gets the error object used to construct the error
        /// </summary>
        public ExceptionInfo TornErrorInfo { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ApiException() : base() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="error">Torn API Error info object</param>
        public ApiException(ExceptionInfo error) : base(error.ErrorMessage)
        {
            this.TornErrorInfo = error;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        public ApiException(string message) : base(message) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner exception</param>
        public ApiException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="info">Serialization info</param>
        /// <param name="context">Conext</param>
        protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        /// <summary>
        /// Converts the API return object with error info into an exception
        /// </summary>
        /// <param name="ex">The error information from the api call</param>
        /// <returns>The concrete exception class for the specific error</returns>
        public static ApiException CreateExceptionFromExceptionInfo(ExceptionInfo ex)
        {
            return ex.ErrorCode switch
            {
                1 => new EmptyApiKeyException(ex),
                2 => new IncorrectApiKeyException(ex),
                3 => new WrongTypeException(ex),
                4 => new WrongFieldException(ex),
                5 => new TooManyRequestsException(ex),
                6 => new IncorrectIdException(ex),
                7 => new IncorrectIdEntityRelationException(ex),
                8 => new BlockedIpException(ex),
                9 => new ApiDisabledException(ex),
                10 => new PlayerBannedException(ex),
                11 => new ApiKeyChangeException(ex),
                12 => new ApiKeyReadException(ex),
                _ => new UnknownException(ex),
            };
        }
    }
}
