namespace StoreMaterial.Repository.Administrator
{
    public interface IUser
    {
        bool Login(string un, string pw);
    }
}