﻿using System;



namespace ArangoDBNetStandard.Serialization
{
    [Serializable]
    public class SerializationException : Exception
    {
        public SerializationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}