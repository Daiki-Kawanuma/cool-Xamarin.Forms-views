using CoolViewSample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolViewSample.Models
{
    public class AccordionItem : ISelectable
    {
        public bool IsVisible { get; set; }
        public bool IsSelected { get; set; }
        public string Date { get; set; }
        public string Icon { get; set; }
        public string Category1st { get; set; }
        public string Category2nd { get; set; }
        public string Category3rd { get; set; }

        public static IList<AccordionItem> Participants = new List<AccordionItem>
        {
            new AccordionItem{ IsVisible = true, Date = "1st",
                Icon = "https://pbs.twimg.com/profile_images/796746691265236992/U09lhRCX_400x400.jpg",
                Category1st = Constants.XamrinImageUrl,
                Category2nd = Constants.AndroidImageUrl,
                Category3rd = Constants.iOSImageUrl
            },
            new AccordionItem{ IsVisible = true, Date = "2nd",
                Icon = "https://pbs.twimg.com/profile_images/747601253266395136/2HeCGdiG_400x400.jpg",
                Category1st = Constants.XamrinImageUrl,
                Category2nd = Constants.AzureImageUrl
            },
            new AccordionItem{ IsVisible = true, Date = "3rd", Icon = "https://pbs.twimg.com/profile_images/763183255528976385/k1LorAyM_400x400.jpg" },
            new AccordionItem{ IsVisible = true, Date = "4th", Icon = "https://pbs.twimg.com/profile_images/810708295501479936/wVwD0TGt_400x400.jpg" },
            new AccordionItem{ IsVisible = true, Date = "5th", Icon = "https://pbs.twimg.com/profile_images/464440152270442497/shZN7Osi_400x400.png" },
            new AccordionItem{ IsVisible = true, Date = "6th", Icon = "https://pbs.twimg.com/profile_images/751091357825929216/RiXRpWA3_400x400.jpg" },
            new AccordionItem{ IsVisible = true, Date = "7th", Icon = "https://pbs.twimg.com/profile_images/888527392645369856/fJ_uL-0e_400x400.jpg" },
            new AccordionItem{ IsVisible = true, Date = "8th", Icon = "https://pbs.twimg.com/profile_images/422625980721545216/ts67sb01_400x400.jpeg" },
            new AccordionItem{ IsVisible = true, Date = "9th", Icon = "https://pbs.twimg.com/profile_images/927852560504913920/H3smDU7S_400x400.jpg" },
            new AccordionItem{ IsVisible = true, Date = "10th", Icon = "https://avatars2.githubusercontent.com/u/16933811?v=4" },
        };
    }   
}
