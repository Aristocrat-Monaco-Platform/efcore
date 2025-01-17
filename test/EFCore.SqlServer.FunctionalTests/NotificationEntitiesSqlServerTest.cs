// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore;

public class NotificationEntitiesSqlServerTest(NotificationEntitiesSqlServerTest.NotificationEntitiesSqlServerFixture fixture)
    : NotificationEntitiesTestBase<NotificationEntitiesSqlServerTest.NotificationEntitiesSqlServerFixture>(fixture)
{
    public class NotificationEntitiesSqlServerFixture : NotificationEntitiesFixtureBase
    {
        protected override ITestStoreFactory TestStoreFactory
            => SqlServerTestStoreFactory.Instance;
    }
}
