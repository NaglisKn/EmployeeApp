using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace EmployeeApp.DAL
{
    public class WorkplaceConfiguration : DbConfiguration
    {
        public WorkplaceConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}