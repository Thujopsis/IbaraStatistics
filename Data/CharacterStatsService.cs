using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace IbaraStatistics.Data
{
    public class CharacterStatsService
    {
        public async Task<CharacterStats> GetCharacterStats_Pejuta(String path)
        {
            var scraper = new HtmlScraper();
            var document = await scraper.Scrape(path).ConfigureAwait(true);
            var ceno = document.QuerySelector<IHtmlDivElement>("div.CEN");
            string eno = new Regex("\\d+$").Match(ceno.InnerHtml).Groups[0].Value;

            string name = document.QuerySelector<IHtmlDivElement>("div.CNM").InnerHtml;
            IHtmlTableElement[] charaAblTables = document.QuerySelector<IHtmlImageElement>("img[src='../../p/t_skill.png']")
                                                         .ParentElement
                                                         .Children
                                                         .Filter("table[width='860']")
                                                         .Cast<IHtmlTableElement>()
                                                         .ToArray();
            IHtmlTableElement charaExTable = charaAblTables[0];
            string[] exs = charaExTable.QuerySelectorAll<IHtmlTableCellElement>("tr:nth-child(n+2) > td:nth-child(1)").Select(td => td.TextContent).ToArray();
            IHtmlTableElement charaASkTable = charaAblTables[1];
            IHtmlTableElement charaPSkTable = charaAblTables[2];
            string[] skls = new[] { charaASkTable, charaPSkTable }.SelectMany(table => table.QuerySelectorAll<IHtmlTableCellElement>("tr:nth-child(n+2) > td:nth-child(2)"))
                                                                  .Select(td => td.TextContent)
                                                                  .ToArray();

            IHtmlTableElement charaItmTable = document.QuerySelector<IHtmlImageElement>("img[src='../../p/t_item.png']")
                                                      .ParentElement
                                                      .Children
                                                      .Filter("table[width='860']")
                                                      .Cast<IHtmlTableElement>()
                                                      .First();
            string[] itms = charaItmTable.QuerySelectorAll<IHtmlTableCellElement>("tr:nth-child(n+2) > td:nth-child(2)").Select(td => td.TextContent).ToArray();

            return new CharacterStats()
            {
                Eno           = eno,
                CharacterName = name,
                Extraordinary = exs,
                Item          = itms,
                Skill         = skls,
            };
        }
    }
}
