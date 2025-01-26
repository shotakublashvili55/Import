

using System.Xml;
using System;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using HtmlAgilityPack;


namespace ConsoleApp1.Library;

internal class NBG
{

    public static decimal NBG_(string RateDate, string CurrencyCode_)
    {
        string CurrencyCode = CurrencyCode_.ToUpper();
        decimal RateFin = 1;
        string rssUrl = $"https://nbg.gov.ge/gw/api/ct/monetarypolicy/currencies/en/rss/?date={RateDate}";


        using HttpClient client = new HttpClient();
        string rssData = client.GetStringAsync(rssUrl).Result;



        using XmlReader reader = XmlReader.Create(new System.IO.StringReader(rssData));
        SyndicationFeed feed = SyndicationFeed.Load(reader);

        HtmlDocument htmlDoc = new HtmlDocument();
        htmlDoc.LoadHtml(rssData);

        var rows = htmlDoc.DocumentNode.SelectNodes("//tr");
        foreach (var row in rows)
        {
            var cells = row.SelectNodes("td");
            if (cells != null && cells.Count >= 2)
            {
                string currency = cells[0].InnerText.Trim();
                string rate = cells[2].InnerText.Trim();
                string rateQuantity = cells[1].InnerText.Trim().Substring(0, cells[1].InnerText.Trim().IndexOf(" "));



                if (currency == CurrencyCode)
                {
                    if (decimal.Parse(rateQuantity) > 0) {
                        RateFin = decimal.Parse(rate) / decimal.Parse(rateQuantity);
                    }
                }

                //       Console.WriteLine($"{currency}: {rate}: {rateQuantity}");
            }

        }
        if (CurrencyCode != "" && CurrencyCode != "GEL") { 
        if (RateFin == 1 && (CurrencyCode != "" || CurrencyCode != "GEL"))
        {
            Console.WriteLine("NBG.GOV.GE Error. Operation Aborted");
            Environment.Exit(0);
        }
         }

        return RateFin;
    }


    }




