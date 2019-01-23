using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHldx37RiP4Tx0cm572DgkZJjTH54tkuWQ0Er1ZaUyqFzoFIIo" +
                "EmHoalDuXRCdiRYT9GiVcZmqQ10v4+yT0fSlbbyjluyXq2aLLJ5tULO5kCwECd/i2DN8GnN4Azl8LXUZlOVS/qFhQB" +
                "Qs59ZhSta/VbwCniUNRUxssfp2x8lIcaiYS32/AEDiuWQdTid3MV/fH9oA7cZDtUAX548z4oCcNWRZhFsWm9wrrM0k" +
                "iF/uVbzwKC+6ZpVarbs63N9xV4YR5a7LNDd+Rnu7M0Y9NvIvt/+re+VUG9weRabxN8cUTmFQHX1Ap0ZyfXr853lfOR" +
                "Q9VPlRo0O6BM9xYVGj3UJJ537nPDWeoRdTIRddPwrFIXBBKKFBgQm1v+rp71JT/guWfedjqRt9vEe3IsfV5MCF5KkC" +
                "NfdySR3V6Q65lWVPgHFwNjYhhJrm7Ohn6xnkjkjINhlDsj83TEtSz0PqbRfPetxQIsmrmhKSVINTk+JWyp+ylblnps" +
                "Izu09tvAJWan9rlHLoaHI9K9T28M7W2zR0KgtCMNNp8p8OULCiDYYTufG30jtJpaMhfWpTAL+LObgvF0g9bKV7Sg9+" +
                "B8OyXchVmrIe6I6IVM5/mYaqj6+9VIXE7XzU5Sikq4zqYOUnfbh6E7sjni+/vaLsXZgg+C++PxkFUUI3OhSbc8eDk9" +
                "SG8z5p4ePZxVrme/72ILtpgcpms=";
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
