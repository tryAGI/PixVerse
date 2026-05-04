/*
order: 20
title: Get account balance
slug: get-account-balance

Read the PixVerse API account balance.
*/

namespace PixVerse.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GetBalance()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.GetAccountBalanceAsync();

        response.ErrCode.Should().Be(0);
    }
}
