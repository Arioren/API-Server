namespace API_Server.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public Agent agent { get; set; }
        public Target target { get; set; }
        //public TimeOnly Time { 
        //    get {
        //        if (Agent == null || Target == null)
        //            return TimeOnly.MaxValue;
        //        return TimeOnly Math.Sqrt(Math.Pow(Agent.x_location - Target.x_location, 2) + Math.Pow(Agent.y_location - Target.y_location, 2))/5 ; TimeOnly.FromDateTime(DateTime.Now);
        //    } 
        //}
        public float hours
        {
            get
            {
                if (agent == null || target == null)
                    return 0;
                return (float)Math.Sqrt(Math.Pow(agent.x_location - target.x_location, 2) + Math.Pow(agent.y_location - target.y_location, 2)) / 5;
            }
        }
    }
}
