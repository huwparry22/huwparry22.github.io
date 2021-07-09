using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubPages.OfficialJokeApi.Responses
{
    public class JokeResponse
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Setup { get; set; }

        public string Punchline { get; set; }
    }
}
