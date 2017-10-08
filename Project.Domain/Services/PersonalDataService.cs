namespace Project.Domain
{
    public sealed class PersonalDataService : BaseDataServices<Personal>
    {
        public int InsertCommand(Personal p)
        {
            string query = "INSERT INTO Personal VALUES (@Name,@Lastname)";

            return ExecuteCommandText(query,p);
        }
    }
}
