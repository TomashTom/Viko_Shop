using Viko_Shop.Server.Services.CategoryService;
using Viko_Shop.Shared;

namespace Viko_Shop.Server.Services.ProductService
{
    

    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Title = "Vero Cafe",
                    Description = "AeroPress GO – vienas kompaktiškiausių kavinukų pasaulyje. Patogus ir praktiškas tiems, kurie daug juda ir keliauja! Pati naujausia AeroPress versija, kurią jau pamėgo tikri kavos entuziastai!",
                    Image = "https://fastly.4sqi.net/img/general/600x600/29957003_84bLEzLOLh2Cj8vhSnFjBQSboe8_0CEIpymsi6f2nN8.jpg",
                    CategoryId = 1,
                    Price = 9.99m,
                    OriginalPrice = 10.99m

                 },

                new Product
                 {
                    Id = 2,
                    Title = "Huracan cafe",
                    Description = "eškote išskirtinių kavos ir arbatos skonių? ☕ Laiko patikrinta, aukščiausios kokybės, rūšinė Huracan kava ir arbata internetu. Užsukite.",
                    Image = "https://s.inyourpocket.com/gallery/133401.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m,
                    CategoryId = 1
                 },

                new Product
                {
                    Id = 3,
                    Title = "Caffein",
                    Description = "NAUJAUSIA KAVINĖ. CAFFEINE kavinė esanti Kovo 11-osios g. 26, Kaune (Kauno ledo rūmuose) - naujausia kavinė Lietuvoje.",
                    Image = "https://apklausa.lt/system/forms/pics/000/196/552/original/pic.jpg?1540295868",
                    Price = 9.99m,
                    OriginalPrice = 10.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "Astorija Baras",
                    Description = "Nauji namai džinui Vilniuje. Astorija baro asortimente – 101+ džinų iš įvairių pasaulio vietų: nuo Anglijos ir kaimynių Latvijos bei Estijos iki tolimos Japonijos. Kruopšiai rinkome džinų sąrašą, norėdami pasiūlyti nuo jau mėgstamiausių iki prabangių, retų bei išskirtinių. Džinų asortimentą  lydi 13 rinktinių tonikų kolekcija.",
                    Image = "https://astorijabrasserie.lt/wp-content/uploads/2019/06/RS-79-011_HiRes30cm-500x500.jpg",
                    CategoryId = 2,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 5,
                    Title = "Spiritus Bar",
                    Description = "Šaunus baras pačioje Vilniaus širdyje su vaizdu į Basanavičių. Interjeras neįpareigojantis, neišskirtinis. Kainos vidutinės",
                    Image = "https://s1.15min.lt/images/photos/2015/04/02/big/vilniuje-atidarytas-tekilos-baras-spiritus-551ce9dfbf5fe.jpg",

                    CategoryId = 2,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 6,
                    Title = "Huracan cafe",
                    Description = "eškote išskirtinių kavos ir arbatos skonių? ☕ Laiko patikrinta, aukščiausios kokybės, rūšinė Huracan kava ir arbata internetu. Užsukite.",
                    Image = "https://s.inyourpocket.com/gallery/133401.jpg",
                    CategoryId = 2,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 7,
                    Title = "Local Pub",
                    Description = "You are always welcome at Local Pub. You can book table for specific time 16:00 - 19:00. If you’re booking for more than 10 people, you need to make an advance payment of 15€ per person. The bank details are depicted below.",
                    Image = "https://media-cdn.tripadvisor.com/media/photo-p/11/c1/3c/3f/local-pub-vilnius.jpg",
                    CategoryId = 2,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 8,
                    Title = "Būsi trečias",
                    Description = "Jei ieškote maloniai stebinančių patirčių, Trinity pasirūpinsime naujais gėrimų atradimais. Autentiški, italų kultūros įkvėpti kokteiliai ir malonus šurmulys pačiame Vilniaus centre.",
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/18/83/cf/07/photo1jpg.jpg",
                    CategoryId = 3,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 9,
                    Title = "Alaus studija",
                    Description = "Alaus studija - S. Žukausko g. 20, VILNIUS. Alaus studija apipinta ir legendomis, ir gandais, ir apkalbomis... Truputį atitrauksime miglos šydą ir įvesime ....",
                    Image = "https://fastly.4sqi.net/img/general/600x600/14709800_sCNPXLRpbtONov1tlrHapzsyDmmeDYzJcS7anRP2swY.jpg",

                    CategoryId = 3,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 10,
                    Title = "+++",
                    Description = "Esame gastrobarai, kuriuose rasi vien tik pliusus: skanius užkandžius + puikius gėrimus + žemiausias kainas mieste + jaukią aplinką + visada gerą muziką. Mus gali drąsiai vadinti taip, kaip liežuviui patogiau – pasirinkome grafišką pavadinimą. Nes kad ir kiek daug minusų per dieną nutiktų, norim, kad atėjęs pas mus taptum optimistu." +
                    "+++ istorija prasidėjo 2016-ais, vėjuotą spalio mėnesį, mažoje, ne daug kam žinomoje, Vingrių gatvelėje. Nuo tada iš visų jėgų stengėmės, kad apsilankius kartą, norėtųsi pakartoti. Todėl dabar gali mus aplankyti ne vienoje Vilniaus vietoje arba išsikviesti į savo namus." +
                    "Jei esi čia naujokas, turime tau pasakyti, kad pagrindinė mūsų meniu valdovė - montadita. Tai – ispaniška sumuštinio giminaitė: garuojanti bandelė ir iš Viduržemio jūros regiono šalių atsivežti ingredientai. O mūsų meniu – savotiškas manifestas, skelbiantis, kad pabūti su draugais nereiškia finansiškai save nubausti, todėl 1 Eur – dažniausias skaičius, kurį matysi." +
                    "Norim, kad pas mus pasikviestum savo mėgstamiausius ir būtum tiek, kiek sėdisi, o ne tol, kol imtų tavęs klausinėti, ar tikrai nieko netrūksta. Nes jei trūksta, pats ateini prie baro ir užsisakai.",
                    Image = "https://www.mada.lt/images/shop_logo__image_.3004a7021062798215262f5a077e37da.jpg",

                    CategoryId = 3,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 11,
                    Title = "The portobello pub",
                    Description = "LAIKAI – NE LIKE’ai, BET DARBUOTOJŲ REIKIA. Kuo mes skiriamės nuo kitų barų? Savimi!Netrukus atsidarys legendinis daug metų mylimo, tikro ir GYVYBINGO Vilniaus Senamiesčio pub’o THE PORTOBELLO kiemas, todėl tikimės savo tradicijų išmokyti ir pilnaverčiais Dream-Team’o nariais vadinti:NAUJUS BARman’us/BARwoman’es:Pagrindinis reikalavimas: NUOŠIRDUS NORAS (dirbti, sužinoti, išmokti, suprasti...)Rimtas reikalavimas: POZITYVI ENERGIJA (bendrauti, linksmintis, ragauti, vertinti...)  Šalutinis reikalavimas:  SVEIKAS HUMORAS (turėti, naudoti, girdėti, juoktis...)" +
                    "PAŽADAME: Daug įdomių Svečių(nes pas mus “klientų” nebūna)Tvirtas žinias apie alų ir kt. (nes degustuojame ir diskutuojame nuolat)Adekvatų atlyginimą(nes geri žmonės ant medžių neauga) Parduokite savo vasarą mums! Kartu mes galime daugiau.Uždirbti irgi.Kalbėkimės!",
                    Image = "https://media-cdn.tripadvisor.com/media/photo-s/03/96/6f/82/the-portobello.jpg",
                    CategoryId = 3,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 12,
                    Title = "Gringo Pub",
                    Description = "Hands down the best bar in Vilnius, food is AMAZING a little bit on the expensive side for a bar but definitely worth it. I take my hat off to the owner for creating such a great place in the oldtown.",
                    Image = "https://fastly.4sqi.net/img/general/600x600/43566050_R2YWs8K3c9Katp0dQa1bBfdBW5wfQJb5_Av6j6_OsOg.jpg",
                    CategoryId = 3,
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                 new Product
                 {
                     Id = 13,
                     Title = "Forum Cinemas",
                     Description = "Filmų seansai prasideda reklama ir kino anonsais, kurių laiką (iki 20 min.) reikėtų prisumuoti prie filmo trukmės. Reguliarūs savaitiniai repertuarai (nuo penktadienio iki ketvirtadienio) sudaromi ir skelbiami antradieniais.Kino centras pasilieka teisę keisti bilietų kainas, seansų laiką bei amžiaus cenzą.",
                     CategoryId = 4,
                     Image = "https://kaledumiestelis.lt/wp-content/uploads/2018/10/forum-cinemas-logo.png",
                     Price = 9.99m,
                     OriginalPrice = 10.99m
                 },
                new Product
                {
                    Id = 14,
                    Title = "Akropolio Ledas",
                    Description = "AKROPOLIO ledo arena – tai visus metus veikianti laisvalaikio ir aktyvaus poilsio zona, įsikūrusi prekybos ir pramogų centre AKROPOLIS. Iš aplink ledo areną įrengtų kavinių galima stebėti tiek dailiojo čiuožimo pasirodymus, tiek ledo ritulio varžybas. Taip pat vaikams siūlomos dailiojo čiuožimo bei ledo ritulio treniruotės. Perkant bilietą čiuožimo sesijai, pačiūžos išduodamos nemokamai. ",
                    CategoryId = 4,
                    Image = "https://www.akropolis.lt/image/15564784445832_430_430_1.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 15,
                    Title = "Ozo Multikono",
                    CategoryId = 4,
                    Description = "MULTIKINO kino centras - naujausi 2D ir 3D filmai, įsimintinos pramogos ir šventės, modernios kino salės ir malonus aptarnavimas. Akcijos ir dovanų kuponai.",
                    Image = "https://www.ozas.lt/img/gallery/full/slider/557e8dec3b602.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 16,
                    Title = "Vichy Parkas",
                    CategoryId = 4,
                    Description = "The theme of “Vichy“ aqua park is a hospitable and exotic environment of Polynesian islands so called the last paradise in the world and the mood. This covers all zones of the park from locker-room, cash desks, attractions and pools to staff clothing, music, food and drinks served in the park.",
                    Image = "https://assets.geradovana.lt/files/uploaded/programs/6ca3ae3f472244639f9136f9e0e3effe.jpeg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 17,
                    Title = "Dazasvidis",
                    CategoryId = 4,
                    Description = "Kviečiame Jus pasinerti į didžiulį ir kupiną įdomybių dažasvydžio pasaulį. Ateikite ir mėgaukitės nepamirštama patirtimi mūsų dažasvydžio srityje.",
                    Image = "https://assets.geradovana.lt/files/uploaded/programs/vidinei_dazasvydis_(1)_20141107154010733.jpeg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 18,
                    Title = "ŠRATASVYDIS",
                    CategoryId = 4,
                    Description = "Šratasvydis (dar žinomas kaip straikbolas arba airsoftas) – sportinis karinis žaidimas, aktyvus laisvalaikio praleidimo būdas ir hobis, kuriame naudojamos itin realistiškai atrodančios tikrų ginklų elektro-pneumatinės kopijos (AEG), šaudančios plastikiniais rutuliukais (BB). Žaidimą žaidžiantys pavieniai asmenys ar komandos imituoja kariuomenės, policijos, teroristinių grupuočių veiksmus, ginkluotę, aprangą bei taktiką.",
                    Image = "https://www.airsoftas.lt/images/Userfiles/index/first.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    Id = 19,
                    CategoryId = 4,
                    Title = "Apollo Boulingas",
                    Description = "O'Learys pramogų centre rasite 14-ika boulingo takelių, iš kurių 4 takeliai yra interaktyvūs, naujausios kartos. Kaip atrodo žaidimas prie interaktyvių takelių, kviečiame susipažinti INTERAKTYVUS BOULINGAS",
                    Image = "https://www.visitorify.com/static/photos/apollo-boulingas-347.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    CategoryId = 4,
                    Id = 20,
                    Title = "Karoliniskiu Boulingas",
                    Description = "Ko gero tai populiariausias žaidimas pasaulyje. Puiki pramoga draugų kompanijai, norinčiai linksmai praleisti laiką. Mėgautis žaidimu galima nepriklausomai nuo pasiekto rezultato: azarto ir gerų metimų čia niekada netrūksta. Boulingą žaisti gali ir vaikai – per kelias akimirkas takelį galima “patobulinti” taip, kad visi metimai pasiektų tikslą!",
                    Image = "https://fastly.4sqi.net/img/general/600x600/hUGBzXSYEThHQ2gnh119ROhtcveW0VqJ3rnHHhHP_XM.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    CategoryId = 4,
                    Id = 21,
                    Title = "Sky Parkas",
                    Description = "1600kv.m. ploto erdvėje rasite didžiausias batutų platformas Europoje, kempinių baseinus, įvairias pramogas. Galėsite išbandyti individualias batutų fitneso treniruotes su patyrusiais treneriais. Jūsų laukia net 13 skirtingų temų gimtadienio kambariai. ",
                    Image = "https://www.1551.lt/images/gallery/229982_3.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    CategoryId = 4,
                    Id = 22,
                    Title = "Gym+",
                    Description = "Gym+ didžiausias sporto klubų tinklas Lietuvoje, turintis net 14 sporto klubų Vilniuje, Kaune, Panevėžyje ir Klaipėdoje. Išbandyk visus Gym+ pliusus ir nevaržyk savęs sportuodamas, nes veikiame visą parą!",
                    Image = "https://gymplius.lt/image/gyms/2020/12/01/Gym%20Plius%20Pnvz-35.jpg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                },
                new Product
                {
                    CategoryId = 4,
                    Id = 23,
                    Title = "Virtualus Kampabys",
                    Description = "Tai specialiai paruošta erdvė, kurioje komanda gali grupėje žaisti komandinius virtualios realybės žaidimus. Visi komandiniai žaidimai yra free roam tipo, tai reiškia, kad žaidėjai gali laisvai vaikščioti, koordinuoti veiksmus tarpusavyje, kadangi mato vienas kitą virtualioje realybėje. ",
                    Image = "https://assets.geradovana.lt/files/uploaded/programs/354dbce6c3764f11bf1452e035b9b901.jpeg",
                    Price = 9.99m,
                    OriginalPrice = 10.99m
                }

            };
    }
}
