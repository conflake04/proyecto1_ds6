using proyecto1_ds6.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1_ds6.Data
{
    public class DataBaseContext
    {
        public SQLiteAsyncConnection Connection { get; set; }
        public const SQLite.SQLiteOpenFlags Flags =
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create |
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;
        public DataBaseContext(string path) 
        {
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<Item>().Wait();
        }

        public async Task<int> InsertItemAsyn(Item item) 
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<List<Item>> GetItemsAsync()
        {
            return await Connection.Table<Item>().ToListAsync();
        }
    }
}
