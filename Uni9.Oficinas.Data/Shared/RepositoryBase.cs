using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uni9.Oficinas.Domain.Shared;

namespace Uni9.Oficinas.Data.Shared
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
    {
        protected readonly MongoClient client;
        protected readonly IMongoDatabase db;
        protected readonly IMongoCollection<T> collection;

        public RepositoryBase(string connectionString, string database, string collectionName)
        {
            client = new MongoClient(connectionString);
            db = client.GetDatabase(database);
            collection = db.GetCollection<T>(collectionName);
        }

        public virtual async Task Add(T entity)
        {
            await collection.InsertOneAsync(entity);
        }

        public virtual async Task Delete(Guid id)
        {
            var filter = Builders<T>.Filter.Eq(nameof(id), id);
            await collection.DeleteOneAsync(filter);
        }

        public virtual async Task Edit(Guid id, T entity)
        {
            var filter = Builders<T>.Filter.Eq(nameof(id), id);
            var update = Builders<T>.Update.Set("Days.$", 1).CurrentDate("LastModified");

            await collection.UpdateOneAsync(filter, update);
        }

        public virtual async Task<T> Get(Guid id)
        {
            var filter = Builders<T>.Filter.Eq("_id", id);
            return await collection.Find(filter).FirstOrDefaultAsync();
        }

        public virtual async Task<ICollection<T>> GetAll()
        {
            return await collection.Find(Builders<T>.Filter.Empty).ToListAsync();
        }

        public virtual async Task<ICollection<T>> GetAll(Guid id)
        {
            var filter = Builders<T>.Filter.Eq(nameof(id), id);
            return await collection.Find(filter).ToListAsync();
        }
    }
}
