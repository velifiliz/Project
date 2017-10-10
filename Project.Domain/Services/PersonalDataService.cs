using System.Collections.Generic;

namespace Project.Domain
{
    public sealed class PersonalDataService : BaseDataServices<Personal>
    {

        public Personal PersonalGetData()
        {
            string query = "SELECT * FROM Personal WHERE Id = 1";
            return GetData(query);
        }

        public List<Personal> PersonalGetDataList()
        {
            string query = "SELECT * FROM Personal";
            return GetDataList(query);

        }

        public int InsertCommand(Personal p)
        {
            string query = "INSERT INTO Personal VALUES (@Name,@Lastname)";
            return ExecuteCommandText(query,p);
        }

        public int InsertCommandScalar(Personal p)
        {
            string query = "INSERT INTO Personal VALUES (@Name,@Lastname) SELECT CAST (scope_identity() as int)";
            return ExecuteCommandScalar(query, p);
        }

        public int FastInsert(Personal p)
        {
            return Insert(p);
        }
    }
}
