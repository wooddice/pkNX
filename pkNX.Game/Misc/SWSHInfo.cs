﻿using System.Collections.Generic;

namespace pkNX.Game
{
    public static class SWSHInfo
    {
        public static readonly IReadOnlyDictionary<ulong, byte> ZoneLocations = new Dictionary<ulong, byte>
        {
            {0x078BC1FF1A657844, 012}, // on Route 1
            {0x10355EFF1F4DB0B5, 018}, // on Route 2
            {0x776776717EA4483E, 122}, // in the Rolling Fields (in a Wild Area)
            {0x776777717EA449F1, 124}, // in the Dappled Grove (in a Wild Area)
            {0x776778717EA44BA4, 126}, // at Watchtower Ruins (in a Wild Area)
            {0x776779717EA44D57, 128}, // at East Lake Axewell (in a Wild Area)
            {0x77677A717EA44F0A, 130}, // at West Lake Axewell (in a Wild Area)
            {0x77677B717EA450BD, 132}, // on Axew’s Eye (in a Wild Area)
            {0x77676C717EA43740, 134}, // at South Lake Miloch (in a Wild Area)
            {0x77676D717EA438F3, 136}, // near the Giant’s Seat (in a Wild Area)
            {0x776AFA717EA75E61, 138}, // at North Lake Miloch (in a Wild Area)
            {0x194B97FF2492111A, 028}, // on Route 3
            {0x776E81717EAA799D, 140}, // at the Motostoke Riverbank (in a Wild Area)
            {0x776E7E717EAA7484, 142}, // in Bridge Field (in a Wild Area)
            {0xDBCF5CFF0180B073, 032}, // on Route 4
            {0x8F67CD45F405D66E, 008}, // in the Slumbering Weald
            {0xE0D6E5E78C91F4A7, 020}, // in the city of Motostoke
            {0xE4E595FF06C510D8, 040}, // on Route 5
            {0x1C7150C0594994E5, 044}, // in the town of Hulbury
            {0x7D3B7A45E97D4A51, 054}, // in Galar Mine No. 2
            {0x75D83E45E5AA7953, 030}, // in Galar Mine
            {0x7D3B7745E97D4538, 052}, // in the Motostoke Outskirts
            {0xA88AC04602050B95, 076}, // in Glimwood Tangle
            {0xEDFC32FF0C0A1B29, 068}, // on Route 6
            {0xF55F6BFF0FDCE70E, 084}, // on Route 7
            {0x449AE0FF3D19D777, 086}, // on Route 8
            {0x4BFDF9FF40EC6CFC, 088}, // on Route 8 (on Steamdrift Way)
            {0x4BFDFCFF40EC7215, 090}, // on Route 9
            {0x4BFDF6FF40EC67E3, 092}, // on Route 9 (in Circhester Bay)
            {0x4BFDFBFF40EC7062, 094}, // on Route 9 (in Outer Spikemuth)
            {0xB332930807F9D48A, 106}, // on Route 10 // Near Station
            {0x7771E5717EAD5960, 144}, // in the Stony Wilderness (in a Wild Area)
            {0x7771E8717EAD5E79, 146}, // in Dusty Bowl (in a Wild Area)
            {0x7771E7717EAD5CC6, 148}, // around the Giant’s Mirror (in a Wild Area)
            {0x7771EA717EAD61DF, 150}, // on the Hammerlocke Hills (in a Wild Area)
            {0x7771E9717EAD602C, 152}, // near the Giant’s Cap (in a Wild Area)
            {0x7771EC717EAD6545, 154}, // at the Lake of Outrage (in a Wild Area)
            {0x10355BFF1F4DAB9C, 018}, // on Route 2
            {0xB332920807F9D2D7, 106}, // on Route 10
            {0x8F67CB45F405D308, 008}, // in the Slumbering Weald

            {0xCD6E4FBCE1466F32, 012}, // on Route 1
            {0xDF686EC613544BD1, 018}, // on Route 2
            {0xD602B2A66C268F7C, 122}, // in the Rolling Fields (in a Wild Area)
            {0x458C9CA2C0087385, 124}, // in the Dappled Grove (in a Wild Area)
            {0xE20E6AE30AAA57D2, 126}, // at Watchtower Ruins (in a Wild Area)
            {0xEEEEAC06BAC8D0B3, 128}, // at East Lake Axewell (in a Wild Area)
            {0xF8D1E527F7B21FA0, 130}, // at West Lake Axewell (in a Wild Area)
            {0xB6CFE90E0378FD79, 132}, // on Axew’s Eye (in a Wild Area)
            {0x520D8DD522E9A4C6, 134}, // at South Lake Miloch (in a Wild Area)
            {0xBC7237A0392D8837, 136}, // near the Giant’s Seat (in a Wild Area)
            {0xB67C706F5BAE9E35, 138}, // at North Lake Miloch (in a Wild Area)
            {0xDA910F69A1B92FED, 130}, // at West Lake Axewell (in a Wild Area) // Surfing
            {0x7C17DB1B430F9543, 134}, // at South Lake Miloch (in a Wild Area) // Surfing
            {0xCC0F8A437312B8AC, 128}, // at East Lake Axewell (in a Wild Area) // Surfing
            {0x8BE2F6160986FB8E, 138}, // at North Lake Miloch (in a Wild Area) // Surfing
            {0x0E8392C0A57D5830, 028}, // on Route 3
            {0x82A7A328A26B9057, 030}, // in Galar Mine
            {0x5B2BC38E044EC2B7, 032}, // on Route 4
            {0x8D68276C03A332BE, 040}, // on Route 5
            {0x16D2FC4840A658A5, 054}, // in Galar Mine No. 2
            {0x3D6D58A96894575E, 052}, // in the Motostoke Outskirts
            {0x6AA652641154B119, 140}, // at the Motostoke Riverbank (in a Wild Area)
            {0x36A5DC94335E1E72, 142}, // in Bridge Field (in a Wild Area)
            {0xE503416A1C05765D, 068}, // on Route 6
            {0x201EF8E9D2A32D71, 076}, // in Glimwood Tangle
            {0x42312695C904658C, 084}, // on Route 7
            {0x1B95A78295F6F213, 086}, // on Route 8
            {0xAADAC3CB6A1DFE8A, 088}, // on Route 8 (on Steamdrift Way)
            {0x9116B224702CDCF1, 090}, // on Route 9
            {0xCDD3B5660D2E5E67, 092}, // on Route 9 (in Circhester Bay)
            {0x5A3B8F8147272058, 094}, // on Route 9 (in Outer Spikemuth)
            {0xA93101EA38598995, 090}, // on Route 9  // Surfing
            {0x0181225223DE5420, 106}, // on Route 10 // Near Station
            {0x1F0F1AE1818C4326, 144}, // in the Stony Wilderness (in a Wild Area)
            {0xAD11B3F3B2AC662D, 146}, // in Dusty Bowl (in a Wild Area)
            {0xCD9719B2E64F2AA4, 148}, // around the Giant’s Mirror (in a Wild Area)
            {0xCD48625EDC10CBFB, 150}, // on the Hammerlocke Hills (in a Wild Area)
            {0x712F3056573E23FA, 152}, // near the Giant’s Cap (in a Wild Area)
            {0x593196758BA16B61, 154}, // at the Lake of Outrage (in a Wild Area)
            {0xF79DE930E6F50533, 106}, // on Route 10
            {0xA26A4595F72EDAEA, 018}, // on Route 2 // high level
            {0x56580C94EDFCE664, 028}, // on Route 3 // just rolycoly and trubbish, probably trash
            {0xCB38FEA3F71C3958, 122}, // in the Rolling Fields (in a Wild Area) // Flying Spawns butterfree/pidove
            {0x1F174D36062B8C38, 122}, // in the Rolling Fields (in a Wild Area)  // Underground Spawns digglet/roggenrola
            {0x23017513039A78E7, 122}, // in the Rolling Fields (in a Wild Area)  // ? Second full table, has pancham instead of bunnelby 
            {0xF1BA4AAD9AAB2C1A, 126}, // at Watchtower Ruins (in a Wild Area) // Flying Spawns woobat/noibat
            {0x3D2E746F9D3F5CB5, 128}, // at East Lake Axewell (in a Wild Area) // Flying Spawns bufferfree/pidove
            {0x6E121A9CE4F58F1E, 128}, // at East Lake Axewell (in a Wild Area) // More Flying Spawns bufferfree/pidove, different rates than above
            {0x3171A0C61793816E, 134}, // at South Lake Miloch (in a Wild Area) // Flying Spawns wingull/drifloon
            {0x198E4023A1B2DDEF, 134}, // at South Lake Miloch (in a Wild Area) // ? Second table, has mostly machop/stunky/tyrogue
            {0xFAB1C08E70C0F1CA, 140}, // at the Motostoke Riverbank (in a Wild Area) // Surfing
            {0xB9F76CEE459CEC07, 142}, // in Bridge Field (in a Wild Area) // Surfing
            {0x5F4E0AB29FD3F13A, 142}, // in Bridge Field (in a Wild Area) // Flying Spawns noibat/woobat/tranquill
            {0xF603DEA4177200EA, 144}, // in the Stony Wilderness (in a Wild Area) // ? Second full table
            {0x76EE4E28DD28374E, 144}, // in the Stony Wilderness (in a Wild Area) // Flying Spawns tranquill/sigilyph
            {0x3F264B6FCB5647B4, 148}, // around the Giant’s Mirror (in a Wild Area) // Flying Spawns tranquill/corvisquire
            {0x2D887A1CA9B1B99A, 146}, // in Dusty Bowl (in a Wild Area) // Flying Spawns braviary
            {0x2BE7E6A8901ECC20, 148}, // around the Giant’s Mirror (in a Wild Area) // Underground Spawns dugtrio/excadrill/boldore
            {0x39F0170769BF4524, 146}, // in Dusty Bowl (in a Wild Area) // Surfing. Also used for 148,around the Giant’s Mirror (in a Wild Area) surfing.
            {0xB2067FBCF8D5C7BA, 152}, // near the Giant’s Cap (in a Wild Area) // Underground Spawns rolycoly/rhyhorn/boldore
            {0x48B9525945EE48B5, 144}, // in the Stony Wilderness (in a Wild Area) // ? third full table
            {0xB5756B87989661E1, 152}, // near the Giant’s Cap (in a Wild Area) // ? second full table
            {0x7AB83D18C831DDEB, 152}, // near the Giant’s Cap (in a Wild Area) // ? third full table
            {0xDBEF8A8593377AAA, 152}, // near the Giant’s Cap (in a Wild Area) // Underground Spawns Solrock
            {0x066F97F8765BC22D, 150}, // on the Hammerlocke Hills (in a Wild Area) // Flying Spawns Unfezant/Corvisquire
            {0x87A97AFF94BC6CF2, 154}, // at the Lake of Outrage (in a Wild Area) // Surfing
            {0x94289204B628522C, 008}, // in the Slumbering Weald  // early
            {0x5D02F15C043B872E, 008}, // in the Slumbering Weald // late
            {0xA4945486A2B97DFF, 018}, // on Route 2 // Surfing
            {0xAC1187E9EC166853, 092}, // on Route 9 (in Circhester Bay) // Surfing

            // DLC
            {0x908A64718CA374E6, 164}, // in the Fields of Honor
            {0x908A63718CA37333, 166}, // in the Soothing Wetlands
            {0x908A62718CA37180, 168}, // in the Forest of Focus
            {0x908A69718CA37D65, 170}, // on Challenge Beach
            {0x908A68718CA37BB2, 172}, // in Brawlers’ Cave
            {0x908A67718CA379FF, 174}, // on Challenge Road
            {0x908A66718CA3784C, 176}, // in Courageous Cavern
            {0x908A6D718CA38431, 178}, // in Loop Lagoon
            {0x908A6C718CA3827E, 180}, // in the Training Lowlands
            {0x90875F718CA13690, 182}, // in Warm-Up Tunnel
            {0x908760718CA13843, 184}, // in the Potbottom Desert
            {0x909170718CA9A7F8, 186}, // in the Workout Sea
            {0x909173718CA9AD11, 188}, // in the Stepping-Stone Sea
            {0x909172718CA9AB5E, 190}, // in the Insular Sea
            {0x909175718CA9B077, 192}, // in the Honeycalm Sea
            {0x908DEC718CA691D5, 194}, // on Honeycalm Island

            {0x525D03DF0309D804, 164}, // in the Fields of Honor // Ground Spawns
            {0xB0621052994A5089, 164}, // in the Fields of Honor // Surfing
            {0x91B1D1436BAF5871, 164}, // in the Fields of Honor // Beach
            {0xC449DFAB894F632C, 178}, // in Loop Lagoon // Beach
            {0x273693DD91D7BD10, 170}, // on Challenge Beach // Beach
            {0xD61582D408C39E60, 170}, // on Challenge Beach // Surfing (River)
            {0xBECC9623CD3E8C77, 166}, // in the Soothing Wetlands // Ground Spawns
            {0x1C051CB6F97C2068, 166}, // in the Soothing Wetlands // Puddles
            {0xBC028EF260AD9406, 168}, // in the Forest of Focus // Ground Spawns
            {0x32AB88FC9797DC83, 168}, // in the Forest of Focus // Surfing
            {0x39D078468AA0DCC1, 170}, // on Challenge Beach // Ground Spawns
            {0x3BFB22D0FB5B42D2, 170}, // on Challenge Beach // Surfing (Ocean)
            {0x2B1DF6E85F9BAE28, 172}, // in Brawlers’ Cave // Ground Spawns
            {0x36FE81B956D0DCB5, 172}, // in Brawlers’ Cave // Surfing
            {0xBBAA199D0705405B, 174}, // on Challenge Road // Ground Spawns
            {0xFB9A7FD6D979C6DA, 176}, // in Courageous Cavern // Ground Spawns
            {0xBC0E1701C0276FCF, 176}, // in Courageous Cavern // Surfing
            {0xAC2ED08E980FCFC5, 178}, // in Loop Lagoon // Ground Spawns
            {0x7D2E205E8E300EE1, 178}, // in Loop Lagoon // Water Spawns
            {0x67E3FF10EB64FB79, 180}, // in the Training Lowlands // Beach
            {0x85E286D82C666BBC, 180}, // in the Training Lowlands // Ground Spawns
            {0x95E125D2EE3ED656, 182}, // in Warm-up Tunnel
            {0xA7F495799F209587, 184}, // in the Potbottom Desert
            {0x30AAD92559FCE81E, 186}, // in the Workout Sea // Ground Spawns
            {0x6F748A46C8E3802C, 186}, // in the Workout Sea // Surfing
            {0x97A3E0687E3C5B01, 188}, // in the Stepping-Stone Sea // Surfing
            {0xDDDFF88957FD5B5C, 188}, // in the Stepping-Stone Sea // Ground Spawns (Main Area)
            {0xF3036CD294CE9365, 188}, // in the Stepping-Stone Sea // Ground Spawns (Area 2)
            {0xFB9BB438425D58DA, 190}, // in the Insular Sea // Surfing
            {0xC16C1E2A1B5FFE87, 192}, // in the Honeycalm Sea // Surfing
            {0x081D7EF6A1C192B1, 194}, // on Honeycalm Island // Ground Spawns
            {0x86EFBF49516B5555, 194}, // on Honeycalm Island // Surfing
            {0x39AB700A9F1AB71F, 180}, // in the Training Lowlands // Surfing
            {0x96C6A2A36131F383, 188}, // in the Stepping-Stone Sea // Sharpedo
            {0xC92D06352150C78A, 190}, // in the Insular Sea // Sharpedo
            {0xED1F9772AA35C3CD, 186}, // in the Workout Sea // Sharpedo
            {0x9C0049D3E6129924, 192}, // in the Honeycalm Sea // Sharpedo

            // DLC2
            {0x87E14B7187BC1CC1, 204}, // on Slippery Slope
            {0x87E1487187BC17A8, 206}, // in Freezington
            {0x87E1497187BC195B, 208}, // in Frostpoint Field
            {0x87E14E7187BC21DA, 210}, // in the Giant’s Bed
            {0x87E14F7187BC238D, 212}, // in the Old Cemetery
            {0x87E14C7187BC1E74, 214}, // on Snowslide Slope
            {0x87E14D7187BC2027, 216}, // in the Tunnel to the Top
            {0x87E1427187BC0D76, 218}, // on the Path to the Peak
            {0x87E1437187BC0F29, 220}, // at the Crown Shrine
            {0x87E4507187BE5B17, 222}, // at the Giant’s Foot
            {0x87E44F7187BE5964, 224}, // in Roaring-Sea Caves
            {0x87E4527187BE5E7D, 226}, // at the Frigid Sea
            {0x87E4517187BE5CCA, 228}, // in Three-Point Pass
            {0x87DA3F7187B5E9AF, 230}, // at Ballimere Lake
            {0x87DA407187B5EB62, 232}, // in Lakeside Cave
            {0x87DA417187B5ED15, 234}, // at Dyna Tree Hill

            {0xD6EA3DE40B009E55, 204}, // on Slippery Slope
            {0xADF616908BD308DF, 208}, // in Frostpoint Field
            {0x308C5EB6A846D1F0, 210}, // in the Giant’s Bed
            {0x50E781F91B97C049, 212}, // in the Old Cemetery
            {0xC303110BF1EC3322, 214}, // on Snowslide Slope
            {0xB768660B0BF4C0C3, 216}, // in the Tunnel to the Top
            {0xFCB78AFCCECAF094, 218}, // on the Path to the Peak
            {0xA345459C03EA6673, 222}, // at the Giant’s Foot
            {0xE4A982819ACF7292, 224}, // in Roaring-Sea Caves
            {0x18AAF85178C7B839, 226}, // at the Frigid Sea
            {0x3EC6FCDC0C77D460, 228}, // in Three-Point Pass
            {0xE5225F9325CCA74B, 230}, // at Ballimere Lake
            {0x2F1B41507D695958, 232}, // in Lakeside Cave

            {0xF8A59FCA719D1EAE, 210}, // in the Giant’s Bed (Surfing), also used for 222 (in the Giant's Foot surfing)
            {0x55D8F226A42368B7, 224}, // in Roaring-Sea Caves (Surfing)
            {0x78536116469DC44D, 226}, // at the Frigid Sea (Surfing)
            {0x9BDD6D11FFBEDA3F, 230}, // at Ballimere Lake (Surfing)
        };

        public static readonly IReadOnlyDictionary<ulong, string> Zones = new Dictionary<ulong, string>
        {
            { 0x078BC1FF1A657844, "Route 1" },
            { 0x10355EFF1F4DB0B5, "Route 2" },
            { 0x776776717EA4483E, "Rolling Fields" },
            { 0x776777717EA449F1, "Dappled Grove" },
            { 0x776778717EA44BA4, "Watchtower Ruins" },
            { 0x776779717EA44D57, "East Lake Axewell" },
            { 0x77677A717EA44F0A, "West Lake Axewell" },
            { 0x77677B717EA450BD, "Axew's Eye" },
            { 0x77676C717EA43740, "South Lake Miloch" },
            { 0x77676D717EA438F3, "Giant's Seat" },
            { 0x776AFA717EA75E61, "North Lake Miloch" },
            { 0x194B97FF2492111A, "Route 3" },
            { 0x776E81717EAA799D, "Motostoke Riverbank" },
            { 0x776E7E717EAA7484, "Bridge Field" },
            { 0xDBCF5CFF0180B073, "Route 4" },
            { 0x8F67CD45F405D66E, "Slumbering Weald" },
            { 0xE0D6E5E78C91F4A7, "City of Motostoke" },
            { 0xE4E595FF06C510D8, "Route 5" },
            { 0x1C7150C0594994E5, "Town of Hulbury" },
            { 0x7D3B7A45E97D4A51, "Galar Mine No. 2" },
            { 0x75D83E45E5AA7953, "Galar Mine" },
            { 0x7D3B7745E97D4538, "Motostoke Outskirts" },
            { 0xA88AC04602050B95, "Glimwood Tangle" },
            { 0xEDFC32FF0C0A1B29, "Route 6" },
            { 0xF55F6BFF0FDCE70E, "Route 7" },
            { 0x449AE0FF3D19D777, "Route 8" },
            { 0x4BFDF9FF40EC6CFC, "Route 8 (on Steamdrift Way)" },
            { 0x4BFDFCFF40EC7215, "Route 9" },
            { 0x4BFDF6FF40EC67E3, "Route 9 (in Circhester Bay)" },
            { 0x4BFDFBFF40EC7062, "Route 9 (in Outer Spikemuth)" },
            { 0xB332930807F9D48A, "Route 10 (Near Station)" },
            { 0x7771E5717EAD5960, "Stony Wilderness" },
            { 0x7771E8717EAD5E79, "Dusty Bowl" },
            { 0x7771E7717EAD5CC6, "Giant's Mirror" },
            { 0x7771EA717EAD61DF, "Hammerlocke Hills" },
            { 0x7771E9717EAD602C, "Giant's Cap" },
            { 0x7771EC717EAD6545, "Lake of Outrage" },
            { 0x10355BFF1F4DAB9C, "Route 2" },
            { 0xB332920807F9D2D7, "Route 10" },
            { 0x8F67CB45F405D308, "Slumbering Weald" },
            { 0xCD6E4FBCE1466F32, "Route 1" },
            { 0xDF686EC613544BD1, "Route 2" },
            { 0xD602B2A66C268F7C, "Rolling Fields" },
            { 0x458C9CA2C0087385, "Dappled Grove" },
            { 0xE20E6AE30AAA57D2, "Watchtower Ruins" },
            { 0xEEEEAC06BAC8D0B3, "East Lake Axewell" },
            { 0xF8D1E527F7B21FA0, "West Lake Axewell" },
            { 0xB6CFE90E0378FD79, "Axew's Eye" },
            { 0x520D8DD522E9A4C6, "South Lake Miloch" },
            { 0xBC7237A0392D8837, "Giant's Seat" },
            { 0xB67C706F5BAE9E35, "North Lake Miloch" },
            { 0xDA910F69A1B92FED, "West Lake Axewell (Surfing)" },
            { 0x7C17DB1B430F9543, "South Lake Miloch (Surfing)" },
            { 0xCC0F8A437312B8AC, "East Lake Axewell (Surfing)" },
            { 0x8BE2F6160986FB8E, "North Lake Miloch (Surfing)" },
            { 0x0E8392C0A57D5830, "Route 3" },
            { 0x82A7A328A26B9057, "Galar Mine" },
            { 0x5B2BC38E044EC2B7, "Route 4" },
            { 0x8D68276C03A332BE, "Route 5" },
            { 0x16D2FC4840A658A5, "Galar Mine No. 2" },
            { 0x3D6D58A96894575E, "Motostoke Outskirts" },
            { 0x6AA652641154B119, "Motostoke Riverbank" },
            { 0x36A5DC94335E1E72, "Bridge Field" },
            { 0xE503416A1C05765D, "Route 6" },
            { 0x201EF8E9D2A32D71, "Glimwood Tangle" },
            { 0x42312695C904658C, "Route 7" },
            { 0x1B95A78295F6F213, "Route 8" },
            { 0xAADAC3CB6A1DFE8A, "Route 8 (on Steamdrift Way)" },
            { 0x9116B224702CDCF1, "Route 9" },
            { 0xCDD3B5660D2E5E67, "Route 9 (in Circhester Bay)" },
            { 0x5A3B8F8147272058, "Route 9 (in Outer Spikemuth)" },
            { 0xA93101EA38598995, "Route 9  (Surfing)" },
            { 0x0181225223DE5420, "Route 10 (Near Station)" },
            { 0x1F0F1AE1818C4326, "Stony Wilderness" },
            { 0xAD11B3F3B2AC662D, "Dusty Bowl" },
            { 0xCD9719B2E64F2AA4, "Giant's Mirror" },
            { 0xCD48625EDC10CBFB, "Hammerlocke Hills" },
            { 0x712F3056573E23FA, "Giant's Cap" },
            { 0x593196758BA16B61, "Lake of Outrage" },
            { 0xF79DE930E6F50533, "Route 10" },
            { 0xA26A4595F72EDAEA, "Route 2 (High Level)" },
            { 0x56580C94EDFCE664, "Route 3 (Garbage)" },
            { 0xCB38FEA3F71C3958, "Rolling Fields (Flying)" },
            { 0x1F174D36062B8C38, "Rolling Fields (Ground)" },
            { 0x23017513039A78E7, "Rolling Fields (2)" },
            { 0xF1BA4AAD9AAB2C1A, "Watchtower Ruins (Flying)" },
            { 0x3D2E746F9D3F5CB5, "East Lake Axewell (Flying)" },
            { 0x6E121A9CE4F58F1E, "East Lake Axewell (Flying)" },
            { 0x3171A0C61793816E, "South Lake Miloch (Flying)" },
            { 0x198E4023A1B2DDEF, "South Lake Miloch (2)" },
            { 0xFAB1C08E70C0F1CA, "Motostoke Riverbank (Surfing)" },
            { 0xB9F76CEE459CEC07, "Bridge Field (Surfing)" },
            { 0x5F4E0AB29FD3F13A, "Bridge Field (Flying)" },
            { 0xF603DEA4177200EA, "Stony Wilderness (2)" },
            { 0x76EE4E28DD28374E, "Stony Wilderness (Flying)" },
            { 0x3F264B6FCB5647B4, "Giant's Mirror (Flying)" },
            { 0x2D887A1CA9B1B99A, "Dusty Bowl (Flying)" },
            { 0x2BE7E6A8901ECC20, "Giant's Mirror (Ground)" },
            { 0x39F0170769BF4524, "Dusty Bowl and Giant's Mirror (Surfing)" },
            { 0xB2067FBCF8D5C7BA, "Giant's Cap (Ground)" },
            { 0x48B9525945EE48B5, "Stony Wilderness (3)" },
            { 0xB5756B87989661E1, "Giant's Cap (2)" },
            { 0x7AB83D18C831DDEB, "Giant's Cap (3)" },
            { 0xDBEF8A8593377AAA, "Giant's Cap (Ground)" },
            { 0x066F97F8765BC22D, "Hammerlocke Hills (Flying)" },
            { 0x87A97AFF94BC6CF2, "Lake of Outrage (Surfing)" },
            { 0x94289204B628522C, "Slumbering Weald (Low Level)" },
            { 0x5D02F15C043B872E, "Slumbering Weald (High Level)" },
            { 0xA4945486A2B97DFF, "Route 2 (Surfing)" },
            { 0xAC1187E9EC166853, "Route 9 (in Circhester Bay) (Surfing)" },

            // DLC
            { 0x908A64718CA374E6, "Fields of Honor" },
            { 0x908A63718CA37333, "Soothing Wetlands" },
            { 0x908A62718CA37180, "Forest of Focus" },
            { 0x908A69718CA37D65, "Challenge Beach" },
            { 0x908A68718CA37BB2, "Brawlers’ Cave" },
            { 0x908A67718CA379FF, "Challenge Road" },
            { 0x908A66718CA3784C, "Courageous Cavern" },
            { 0x908A6D718CA38431, "Loop Lagoon" },
            { 0x908A6C718CA3827E, "Training Lowlands" },
            { 0x90875F718CA13690, "Warm-Up Tunnel" },
            { 0x908760718CA13843, "Potbottom Desert" },
            { 0x909170718CA9A7F8, "Workout Sea" },
            { 0x909173718CA9AD11, "Stepping-Stone Sea" },
            { 0x909172718CA9AB5E, "Insular Sea" },
            { 0x909175718CA9B077, "Honeycalm Sea" },
            { 0x908DEC718CA691D5, "Honeycalm Island" },
            
            { 0x525D03DF0309D804, "Fields of Honor" },
            { 0xB0621052994A5089, "Fields of Honor (Surfing)" },
            { 0x91B1D1436BAF5871, "Fields of Honor (Beach)" },
            { 0xC449DFAB894F632C, "Loop Lagoon (Beach)" },
            { 0x273693DD91D7BD10, "Challenge Beach (Beach)" },
            { 0xD61582D408C39E60, "Challenge Beach (Surfing - River)" },
            { 0xBECC9623CD3E8C77, "Soothing Wetlands" },
            { 0x1C051CB6F97C2068, "Soothing Wetlands (Puddles)" },
            { 0xBC028EF260AD9406, "Forest of Focus" },
            { 0x32AB88FC9797DC83, "Forest of Focus (Surfing)" },
            { 0x39D078468AA0DCC1, "Challenge Beach" },
            { 0x3BFB22D0FB5B42D2, "Challenge Beach (Surfing - Ocean)" },
            { 0x2B1DF6E85F9BAE28, "Brawlers’ Cave" },
            { 0x36FE81B956D0DCB5, "Brawlers’ Cave (Surfing)" },
            { 0xBBAA199D0705405B, "Challenge Road" },
            { 0xFB9A7FD6D979C6DA, "Courageous Cavern" },
            { 0xBC0E1701C0276FCF, "Courageous Cavern (Surfing)" },
            { 0xAC2ED08E980FCFC5, "Loop Lagoon" },
            { 0x7D2E205E8E300EE1, "Loop Lagoon (Surfing)" },
            { 0x67E3FF10EB64FB79, "Training Lowlands (Beach)" },
            { 0x85E286D82C666BBC, "Training Lowlands" },
            { 0x95E125D2EE3ED656, "Warm-up Tunnel" },
            { 0xA7F495799F209587, "Potbottom Desert" },
            { 0x30AAD92559FCE81E, "Workout Sea" },
            { 0x6F748A46C8E3802C, "Workout Sea (Surfing)" },
            { 0x97A3E0687E3C5B01, "Stepping-Stone Sea (Surfing)" },
            { 0xDDDFF88957FD5B5C, "Stepping-Stone Sea (Main Area)" },
            { 0xF3036CD294CE9365, "Stepping-Stone Sea (Area 2)" },
            { 0xFB9BB438425D58DA, "Insular Sea (Surfing)" },
            { 0xC16C1E2A1B5FFE87, "Honeycalm Sea (Surfing)" },
            { 0x081D7EF6A1C192B1, "Honeycalm Island" },
            { 0x86EFBF49516B5555, "Honeycalm Island (Surfing)" },
            { 0x39AB700A9F1AB71F, "Training Lowlands (Surfing)" },
            { 0x96C6A2A36131F383, "Stepping-Stone Sea (Sharpedo)" },
            { 0xC92D06352150C78A, "Insular Sea (Sharpedo)" },
            { 0xED1F9772AA35C3CD, "Workout Sea (Sharpedo)" },
            { 0x9C0049D3E6129924, "Honeycalm Sea (Sharpedo)" },

             // DLC2
            { 0x87E14B7187BC1CC1, "Slippery Slope" },
            { 0x87E1487187BC17A8, "Freezington" },
            { 0x87E1497187BC195B, "Frostpoint Field" },
            { 0x87E14E7187BC21DA, "the Giant’s Bed" },
            { 0x87E14F7187BC238D, "the Old Cemetery" },
            { 0x87E14C7187BC1E74, "Snowslide Slope" },
            { 0x87E14D7187BC2027, "the Tunnel to the Top" },
            { 0x87E1427187BC0D76, "the Path to the Peak" },
            { 0x87E1437187BC0F29, "the Crown Shrine" },
            { 0x87E4507187BE5B17, "the Giant’s Foot" },
            { 0x87E44F7187BE5964, "Roaring-Sea Caves" },
            { 0x87E4527187BE5E7D, "the Frigid Sea" },
            { 0x87E4517187BE5CCA, "Three-Point Pass" },
            { 0x87DA3F7187B5E9AF, "Ballimere Lake" },
            { 0x87DA407187B5EB62, "Lakeside Cave" },
            { 0x87DA417187B5ED15, "Dyna Tree Hill" },

            { 0xD6EA3DE40B009E55, "Slippery Slope" },
            { 0xADF616908BD308DF, "Frostpoint Field" },
            { 0x308C5EB6A846D1F0, "the Giant’s Bed" },
            { 0x50E781F91B97C049, "the Old Cemetery" },
            { 0xC303110BF1EC3322, "Snowslide Slope" },
            { 0xB768660B0BF4C0C3, "the Tunnel to the Top" },
            { 0xFCB78AFCCECAF094, "the Path to the Peak" },
            { 0xA345459C03EA6673, "the Giant’s Foot" },
            { 0xE4A982819ACF7292, "Roaring-Sea Caves" },
            { 0x18AAF85178C7B839, "the Frigid Sea" },
            { 0x3EC6FCDC0C77D460, "Three-Point Pass" },
            { 0xE5225F9325CCA74B, "Ballimere Lake" },
            { 0x2F1B41507D695958, "Lakeside Cave" },

            { 0xF8A59FCA719D1EAE,"Giant’s Bed and Giant's Foot (Surfing)" },
            { 0x55D8F226A42368B7,"Roaring-Sea Caves (Surfing)" },
            { 0x78536116469DC44D,"Frigid Sea (Surfing)" },
            { 0x9BDD6D11FFBEDA3F,"Ballimere Lake (Surfing)" },
        };
    }

    public enum SWSHEncounterType
    {
        Normal_Weather,
        Overcast,
        Raining,
        Thunderstorm,
        Intense_Sun,
        Snowing,
        Snowstorm,
        Sandstorm,
        Heavy_Fog,
        Shaking_Trees,
        Fishing,
    };
}
