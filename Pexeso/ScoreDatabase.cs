using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;
using SQLite;

namespace Pexeso
{
    public class ScoreDatabase
    {
        public SQLiteAsyncConnection Database;

        public ScoreDatabase(string dbPath)
        {
            Database = new SQLiteAsyncConnection(dbPath);
            Database.CreateTableAsync<Score>().Wait();
        }
        public Task<List<Score>> QueryGet()
        {
            return Database.QueryAsync<Score>("SELECT * FROM [Score];");
        }
        public Task<List<Score>> QueryGetById(int id)
        {
            return Database.QueryAsync<Score>("SELECT * FROM [Score] WHERE [primaryId] = ?;", id);
        }
        public Task<int> SaveItemAsync(Score item)
        {
            return Database.InsertAsync(item);
        }

        public int CheckDatabase()
        {
            return Database.QueryAsync<Score>("SELECT * FROM [Score] LIMIT 1").Result.Count;
        }

    }
}

