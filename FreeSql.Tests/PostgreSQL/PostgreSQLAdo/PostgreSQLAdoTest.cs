using FreeSql.DataAnnotations;
using System;
using Xunit;

namespace FreeSql.Tests.PostgreSQL {
	public class PostgreSQLAdoTest {
		[Fact]
		public void Pool() {
			var t1 = g.pgsql.Ado.MasterPool.StatisticsFullily;
		}

		[Fact]
		public void SlavePools() {
			var t2 = g.pgsql.Ado.SlavePools.Count;
		}

		[Fact]
		public void IsTracePerformance() {
			Assert.True(g.pgsql.Ado.IsTracePerformance);
		}

		[Fact]
		public void ExecuteReader() {
			
		}
		[Fact]
		public void ExecuteArray() {
			
		}
		[Fact]
		public void ExecuteNonQuery() {
			
		}
		[Fact]
		public void ExecuteScalar() {
			
		}

		[Fact]
		public void Query() {
			var t3 = g.pgsql.Ado.Query<xxx>("select * from song");

			var t4 = g.pgsql.Ado.Query<(int, string, string)>("select * from song");

			var t5 = g.pgsql.Ado.Query<dynamic>("select * from song");
		}

		class xxx {
			public int Id { get; set; }
			public string Path { get; set; }
			public string Title2 { get; set; }
		}
	}
}
