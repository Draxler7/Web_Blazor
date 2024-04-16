using Web_Blazor.Components.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Web_Blazor
{
    public class ObjectiveService : IObjectiveService 
    {
        private List<ObjectiveViewModel> ObjectiveList = new List<ObjectiveViewModel>();

        public List<ObjectiveViewModel> GetObjectives() { return ObjectiveList; }

        public void AddObjective(ObjectiveViewModel objective) { ObjectiveList.Add(objective); }

        public void RemoveObjective(string name,DateTime date)
        {
                ObjectiveViewModel itemObject = ObjectiveList.Where(x =>(( x.Name == name)&&(x.Date==date))).First();
                ObjectiveList.Remove(itemObject);
        }
    }
}
