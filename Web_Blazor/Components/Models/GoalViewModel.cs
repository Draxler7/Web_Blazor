namespace Web_Blazor.Components.Models
{
    [Serializable]
    public class GoalViewModel
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public DateTime Date { get; set; }

        public Boolean Status { get; set; }
    }
}
