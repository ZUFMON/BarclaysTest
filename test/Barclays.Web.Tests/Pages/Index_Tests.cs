using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Barclays.Pages;

public class Index_Tests : BarclaysWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
