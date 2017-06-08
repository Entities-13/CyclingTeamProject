namespace Cycling.Web.Contracts
{
    public interface IRemoveCyclist
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        void Remove();
    }
}