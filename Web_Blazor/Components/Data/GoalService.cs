

using MongoDB.Driver;

namespace Web_Blazor.Components.Data
{
    public class GoalService
    {
        IMongoCollection<Goal> _goals;

        public GoalService(IConfiguration configuration)
        {
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "GoalDB";
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            _goals = database.GetCollection<Goal>("goal");

        }

        public List<Goal> GetGoals()
        {
            var filter = Builders<Goal>.Filter.Empty;
            return _goals.Find(filter).ToList();
        }

        public Goal GetGoalById(string id) 
        {
            var filter = Builders<Goal>.Filter.Eq(a => a.Id,id);
            return _goals.Find(filter).FirstOrDefault();
        }

        public void AddGoal(Goal goal)
        {
            _goals.InsertOne(goal);
        }

        public void EditGoal(Goal goal)
        {
            var filter = Builders<Goal>.Filter.Eq(a => a.Id, goal.Id);
            var update = Builders<Goal>.Update
                .Set(a => a.Name, goal.Name)
                .Set(a => a.Date, goal.Date)
                .Set(a => a.Status, goal.Status);
            _goals.UpdateOne(filter, update);
        }

        public void DeleteGoal(string id)
        {
            var filter = Builders<Goal>.Filter.Eq(a => a.Id,id);
            _goals.DeleteOne(filter);
        }
    }
}
