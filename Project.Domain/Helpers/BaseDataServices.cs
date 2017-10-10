using Dapper;
using Dapper.FastCrud;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Project.Domain
{
    public abstract class BaseDataServices<T> where T : BaseDataEntities
    {
        readonly string ConnectionString = @"Data Source=MACBOOK\SA;Initial Catalog=mvcders;Integrated Security=True";

        protected IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConnectionString);
            }
        }

        protected T GetData(string query, object param = null)
        {
            return Connection.QuerySingleOrDefault<T>(query, param);
        }

        protected List<T> GetDataList(string query, object param = null)
        {
            return Connection.Query<T>(query, param).ToList();
        }

        protected int ExecuteCommandText(string query, object param = null)
        {
            return Connection.Execute(query, param, commandType: CommandType.Text);
        }

        protected int ExecuteCommandScalar(string query, object param = null)
        {
            return Connection.ExecuteScalar<int>(query, param, commandType: CommandType.Text);
        }

        protected List<T> ExecuteCommandProcedure(string query , object param = null)
        {
            return Connection.Query<T>(query, param, commandType: CommandType.StoredProcedure).ToList();
        }

        // FASTCRUD
        protected int Insert(T item)
        {
            Connection.Insert<T>(item);
            return item.Id;
        }

        protected bool Update(T item)
        {
            return Connection.Update<T>(item);
        }

        protected bool Delete(T item)
        {
            return Connection.Delete<T>(item);
        }
 
    }
}
