using System;

namespace DataProvider
{
    public class DbContext
    {
        private readonly string connectionString = "myConnectionString";

        public DbContext()
        {

        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
