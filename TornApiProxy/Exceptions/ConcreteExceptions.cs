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

    /// <summary>
    /// Represents error code 0
    /// </summary>
    public class UnknownException : ApiException
    {
        public UnknownException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 1
    /// </summary>
    public class EmptyApiKeyException : ApiException
    {
        public EmptyApiKeyException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 2
    /// </summary>
    public class IncorrectApiKeyException : ApiException
    {
        public IncorrectApiKeyException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 3
    /// </summary>
    public class WrongTypeException : ApiException
    {
        public WrongTypeException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 4
    /// </summary>
    public class WrongFieldException : ApiException
    {
        public WrongFieldException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 5
    /// </summary>
    public class TooManyRequestsException : ApiException
    {
        public TooManyRequestsException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 6
    /// </summary>
    public class IncorrectIdException : ApiException
    {
        public IncorrectIdException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 7
    /// </summary>
    public class IncorrectIdEntityRelationException : ApiException
    {
        public IncorrectIdEntityRelationException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 8
    /// </summary>
    public class BlockedIpException : ApiException
    {
        public BlockedIpException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 9
    /// </summary>
    public class ApiDisabledException : ApiException
    {
        public ApiDisabledException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 10
    /// </summary>
    public class PlayerBannedException : ApiException
    {
        public PlayerBannedException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 11
    /// </summary>
    public class ApiKeyChangeException : ApiException
    {
        public ApiKeyChangeException(ExceptionInfo ex) : base(ex) { }
    }

    /// <summary>
    /// Represents error code 12
    /// </summary>
    public class ApiKeyReadException : ApiException
    {
        public ApiKeyReadException(ExceptionInfo ex) : base(ex) { }
    }
}
