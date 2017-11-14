using CoolViewSample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoolViewSample.Models
{
    public class AccordionItem : ISelectable
    {
        public bool IsVisible { get; set; }
        public bool IsSelected { get; set; }
        public string Date { get; set; }
        public string Icon { get; set; }
        public ImageSource Category1st { get; set; }
        public ImageSource Category2nd { get; set; }
        public ImageSource Category3rd { get; set; }

        public static IList<AccordionItem> Participants = new List<AccordionItem>
        {
            new AccordionItem{ IsVisible = true, Date = "1st",
                Icon = "https://pbs.twimg.com/profile_images/796746691265236992/U09lhRCX_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri),
                Category2nd = ImageSource.FromResource(Constants.AndroidImageUri),
                Category3rd = ImageSource.FromResource(Constants.iOSImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "2nd",
                Icon = "https://pbs.twimg.com/profile_images/747601253266395136/2HeCGdiG_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri),
                Category2nd = ImageSource.FromResource(Constants.NetImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "3rd",
                Icon = "https://pbs.twimg.com/profile_images/763183255528976385/k1LorAyM_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri),
                Category2nd = ImageSource.FromResource(Constants.AzureImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "4th", Icon = "https://pbs.twimg.com/profile_images/810708295501479936/wVwD0TGt_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri),
                Category2nd = ImageSource.FromResource(Constants.AzureImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "5th",
                Icon = "https://pbs.twimg.com/profile_images/464440152270442497/shZN7Osi_400x400.png",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "6th",
                Icon = "https://pbs.twimg.com/profile_images/751091357825929216/RiXRpWA3_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "7th",
                Icon = "https://pbs.twimg.com/profile_images/888527392645369856/fJ_uL-0e_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri),
                Category2nd = ImageSource.FromResource(Constants.AzureImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "8th",
                Icon = "https://pbs.twimg.com/profile_images/422625980721545216/ts67sb01_400x400.jpeg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri),
                Category2nd = ImageSource.FromResource(Constants.NetImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "9th",
                Icon = "https://pbs.twimg.com/profile_images/927852560504913920/H3smDU7S_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri),                
            },
            new AccordionItem{ IsVisible = true, Date = "10th",
                Icon = "https://avatars2.githubusercontent.com/u/16933811?v=4",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "11th",
                Icon = "https://pbs.twimg.com/profile_images/741561516890062848/ES4tGCHi_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "12th",
                Icon = "https://pbs.twimg.com/profile_images/863913986462330881/COjIU6ir_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "13th",
                Icon = "https://pbs.twimg.com/profile_images/716222975192641536/UU__aMIF_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "14th",
                Icon = "https://pbs.twimg.com/profile_images/898332437498871808/z6K1Kiqd_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
            new AccordionItem{ IsVisible = true, Date = "15th",
                Icon = "https://pbs.twimg.com/profile_images/875499561770393600/-JMQPRzC_400x400.jpg",
                Category1st = ImageSource.FromResource(Constants.XamarinImageUri)
            },
        };
    }   
}
