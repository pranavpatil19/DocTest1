using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Document.Master.Pages
{
    public class Index_Tests : MasterWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
