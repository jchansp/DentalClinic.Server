namespace Entities
{
    public class User : Person
    {
        public virtual void Register()
        {
            Persist();
        }
    }
}