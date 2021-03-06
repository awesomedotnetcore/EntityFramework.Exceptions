﻿using EntityFramework.Exceptions.MySQL.Pomelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace EntityFramework.Exceptions.Tests
{
    public class MySQLServerPomeloTests : DatabaseTests, IClassFixture<MySQLDemoContextPomeloFixture>
    {
        public MySQLServerPomeloTests(MySQLDemoContextPomeloFixture fixture) : base(fixture.Context)
        {

        }
    }

    public class MySQLDemoContextPomeloFixture : DemoContextFixture
    {
        protected override DbContextOptionsBuilder<DemoContext> BuildOptions(DbContextOptionsBuilder<DemoContext> builder, IConfigurationRoot configuration)
        {
            return builder.UseMySql(configuration.GetConnectionString("MySQL")).UseExceptionProcessor();
        }
    }
}
