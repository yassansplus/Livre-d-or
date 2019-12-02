using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LivreDOr
{
    class DataBaseTask
    {

        private MongoClient client;
        private IMongoDatabase database;

        public DataBaseTask()
        {
            this.client = new MongoClient("mongodb+srv://root:root@cluster0-1q7zn.mongodb.net/test?retryWrites=true&w=majority");
            this.database = client.GetDatabase("myDb");



        }

        public void insererCritique(Critique cri)
        {
            
            var Collec = this.database.GetCollection<BsonDocument>("livreDor");
            var documnt = new BsonDocument{
                {"Nom",cri.Name},
                {"Message", cri.Message},
                
            };
            Collec.InsertOne(documnt);
        }

        public ArrayList findAllCritiques()
        {
            ArrayList myCritiques = new ArrayList();
            var Collec = this.database.GetCollection<BsonDocument>("livreDor");
            Collec.Find(new BsonDocument()).ForEachAsync(X=>myCritiques.Add((new Critique((string)X.GetValue(1), (string)X.GetValue(2)))));


            return myCritiques;
            




        }

            
    }
}
