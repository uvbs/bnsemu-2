﻿namespace NCAuthServer.Model.Structs
{
    public struct DatabaseStruct
    {
        public string Url;

        public string Name;

        public DatabaseStruct(string url, string name)
        {
            Url = url;
            Name = name;
        }
    }
}
