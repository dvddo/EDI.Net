using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Tests.Models;
using Xunit;

namespace indice.Edi.Tests
{
    public class SeatMapTest
    {
        [Fact, Trait(Traits.Tag, "EDIFact"), Trait(Traits.Issue, "#999")]
        public void EmptySegment_Withought_A_segmentname_separator_should_parse() {
            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(Edifact_SeatMap);
            using (var stream = Helpers.GetResourceStream("edifact.Issue.SeatMap.edi")) {
                interchange = new EdiSerializer().Deserialize<Edifact_SeatMap>(new StreamReader(stream), grammar);
            }
            Assert.NotNull(interchange);
        }
    }
}
