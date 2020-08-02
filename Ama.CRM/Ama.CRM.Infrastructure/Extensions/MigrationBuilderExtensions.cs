using System.IO;

namespace Ama.CRM.Infrastructure.Extensions
{
  public static class MigrationBuilderExtensions
  {
    public static void SqlFile(this MigrationBuilder migrationBuilder, string path)
    {
      var sql = File.ReadAllText(path);
      migrationBuilder.Sql(sql);
    }
  }
}
