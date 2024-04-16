using Web_Blazor.Components.Models;

namespace Web_Blazor
{
    public interface IObjectiveService
    {
        List<ObjectiveViewModel> GetObjectives();

        void AddObjective(ObjectiveViewModel objective);

        void RemoveObjective(string name,DateTime date);
    }
}
