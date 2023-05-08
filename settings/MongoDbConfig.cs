﻿namespace AuthMongoDB.settings
{
    public class MongoDbConfig
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}
