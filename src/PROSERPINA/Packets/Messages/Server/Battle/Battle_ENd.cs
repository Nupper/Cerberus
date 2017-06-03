﻿using BL.Servers.CR.Extensions.List;
using BL.Servers.CR.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Servers.CR.Packets.Messages.Server.Battle
{
    internal class Battle_End : Message
    {
        public Battle_End(Device Device) : base(Device)
        {
            this.Identifier = 20225;
        }

        internal override void Encode()
        {
            //this.Data.AddHexa("7B 09 65 15 6C 3C FE F0 F8 F4 DB D6 C7 5D 6F 5E 96 8B 23 B8 54 FE C9 3C D1 DB F4 C3 01 30 AF 56 FC 5D F0 14 8D F0 14 1C 19 0C 0D 14 FA 97 FA D4 24 A4 90 44 3F 85 17 C4 7D CD 59 2F A8 A2 2F E6 C5 7F 37 45 EC 31 8E 1F A8 6D 09 29 01 AE 56 AE 38 50 3F 60 C9 09 D7 F9 85 86 A8 6C 89 41 6C 46 0A D4 F6 C8 84 F7 4E F6 49 E5 57 56 99 15 CD FD 5D AB EC A5 F1 EC 34 1B 97 84 8A 6D 6F B5 4C DF 26 7E F5 58 C6 03 D9 F0 4F 85 72 AB 8C F4 33 49 D2 E9 84 73 E9 A5 2E 00 E5 EC 75 BA D2 56 17 BE 5D 63 F7 3E 88 F1 C2 EA 1F 41 6C 21 97 0B F0 D8 4B 90 9C FE 6D C1 1A 7F 6A 5F 2E 55 F9 38 B9 6B 00 44 EB 25 24 AF 94 BF B7 F8 B9 58 3E 0C CD 16 52 2B 27 C5 5B 52 7C 9A F1 51 95 A3 8F E8 3A 2B A9 19 81 78 D0 CD 14 8C DA E4 9B B5 E7 84 B5 E2 6F 7F 32 43 20 9C F6 CB 48 64 E2 59 EB 60 C2 5F D8 B4 2F 6E 16 96 C3 6C CF 8A 9E 9E B7 43 FC 90 95 D4 BB CC B1 8A 15 27 42 52 73 59 6E 55 94 85 0C 2E AD D0 E2 4D 3F B7 D9 94 99 12 62 FF ED CF 74 53 85 51 3F 66 E5 B3 1D 23 26 56 B3 4A 97 9D E2 1F 82 A1 E5 04 4F CF E7 26 45 73 77 EB 42 EE CF 60 BB E1 43 C0 26 9F AE D5 1E D9 D7 81 C8 F1 BC 0F 38 82 66 0D 8C 6D 26 F6 05 C7 A4 47 4C 46 89 19 FC 56 CD F7 2D ED A7 9A EB EC 9E F7 74 69 C7 05 98 AD 59 60 3F 39 67 5F B7 49 12 AD 40 41 18 FE EF 42 E9 C7 3E 5F F5 D3 12 80 3C BF A6 FC 7F 3B 3D CF 4B E9 97 81 42 82 CB 29 04 3D B9 77 24 53 7A 35 83 83 E6 C0 1D 3D 48 61 87 9D 2D B9 AA 83 63 A6 FF 07 FD 3D CF 33 C1 B2 B3 93 67 0D 08 61 CE 48 25 E3 CE B9 3A 7B AB EE C0 30 C6 85 16 E7 10 8C C7 DD 8E 32 6C 8B A4 85 ED 97 27 BA 5B 37 18 C8 02 3D 41 BA D6 16 2B D1 BD 1C A9 84 CD 68 E6 F7 DE 90 33 29 0B 28 5D 2D 45 F6 A7 96 81 50 5A C1 76 55 5B 92 0C 12 EA 16 79 03 C6 76 13 D6 39 E1 C8 F3 0F 00 DC D8 AE 28 D3 E3 FF 37 F4 F1 BB DA B3 A3 CF 0B 48 A8 5B 4D 2B 8E 83 18 72 F7 D5 DF 8D 98 68 9C EF 95 80 36 53 6E 0D 20 C5 AD 5C 93 55 2D CF 1B 0C E1 B4 A7 43 2A 28 BC 37 25 CF 96 00 9C 0D 4C 23 9D 3E F9 CC CD F9 2F 75 1C 22 54 C4 49 1F 66 81 37 DA 16 E8 C9 06 D6 D4 61 6C DF 74 49 44 06 1A BD B1 D0 38 5F 27 9F F5 FA A6 2A 0C 16 70 4E EF DF DD 84 65 34 97 CF F6 CE C2 9C 44 9F 4F 7D D7 0D AE 56 48 74 B6 01 AF 32 55 84 C0 6B 4B A7 1B 2C 7E 6D F8 CF B9 13 DD 36 1B A5 57 AA 8B 1A 99 FE 7C 0A B2 B1 CA 98 57 B9 9C 38 4C 2B B5 36 2E 8F A5 E4 70 A6 53 3A 46 9F 47 39 E9 52 8B 0E 84 E2 98 29 B3 76 A2 35 9C 5D D3 4C 40 DE 80 4A 5A 69 CF 49 84 F9 BA F6 FB 7B DD 2B 63 10 19 48 4C BE 0C EC C1 CD BF 13 17 15 33 E3 5A B6 73 A1 7A 99 DA 7C DB 1B 8A 77 1D F7 0E 3B 8D 75 A9 9C 64 AB FB FD CA 36 D4 62 74 54 DF 38 B0 76 74 DD 30 FA 28 D7 79 9E DD C8 8B F8 2A CA 0F 45 EA D9 18 D7 C1 A2 0F B3 80 14 EB 50 68 71 D5 E7 A1 4F 9A F1 36 2A A2 02 B8 91 03 4F 65 C4 16 D9 31 6D 8B 60 0F FC 1A AF 14 6F 2D C9 F1 91 86 76 FF A6 1E 9E 51 BA 9D 4B BD 42 A9 53 7D 52 3B 19 34 EE B8 E8 9B C1 92 87 36 B5 DE 81 A5 97 F2 2B DD FA 15 4D CD F3 75 D4 98 E2 B5 82 BC 24 03 FE 40 ED EB 4A 53 F1 14 FF 25 43 9D 2F C5 1F 4E 2A 99 0B BA 80 7C C9 DB 53 D3 0B 8F 65 0F C4 3A 53 EE 6C A5 01 1C 70 B5 ED DD 13 ED F9 E9 35 12 6E 63 35 64 0E 0A C8 E8 96 01 E8 BE 36 C5 14 B3 87 0D 62 A0 E8 BB A6 D0 EE 78 B8 D3 7E 62 D4 7A CA 49 5D E2 1E 3B 93 13 36 43 25 F0 BB EB FC D7 BA 0A 12".Replace(" ", ""));
            //this.Data.AddHexa("B2 46 93 47 A8 EA 90 92 0B 0B B2 46 96 39 89 2E B5 87 C1 D3 05 01 1E 87 D8 9D 01 1E 87 D8 9D 01 1E 87 D8 9D 01 00 00 00 0E 54 68 69 61 67 6F 78 47 61 6D 65 72 39 39 08 A7 30 A2 04 00 00 00 00 00 1F 00 00 00 00 00 07 0D 05 01 8B A5 04 05 02 BD 09 05 03 03 05 04 01 05 0C 87 0B 05 0D 00 05 0E 00 05 0F 88 14 05 16 8F 0D 05 19 A4 E3 B0 C7 0D 05 1A 10 05 1C 01 05 1D 8A 88 D5 44 00 00 00 05 05 06 BD 34 05 07 B8 04 05 0B 1F 05 14 0A 05 1B 0A 88 01 1A 00 00 1A 01 00 1A 02 00 1A 03 00 1A 04 00 1A 05 00 1A 06 03 1A 07 00 1A 08 00 1A 09 00 1A 0A 00 1A 0B 00 1A 0C 05 1A 0D 00 1A 0E 00 1A 0F 00 1A 10 00 1A 11 00 1A 12 00 1A 13 00 1A 14 00 1A 15 00 1A 16 00 1A 17 00 1A 18 00 1A 19 00 1A 1A 00 1A 1B 00 1A 1C 00 1A 1D 18 1A 1E 00 1A 1F 00 1A 20 93 03 1A 21 00 1A 22 00 1A 23 00 1A 24 03 1A 25 2A 1A 26 00 1A 27 00 1A 28 00 1A 29 06 1A 2A 04 1A 2B 00 1A 2D 00 1A 2E 09 1B 00 00 1B 01 00 1B 02 00 1B 03 04 1B 04 00 1B 05 00 1B 06 00 1B 07 00 1B 08 00 1B 09 00 1B 0A 00 1C 00 00 1C 01 04 1C 02 00 1C 03 00 1C 04 00 1C 05 00 1C 06 00 1C 07 05 1C 08 00 1C 09 00 1C 0A 1D 1C 0B 00 1C 0C 00 1C 0D 00 1C 10 00 00 0A 02 11 A2 C2 05 00 00 00 0A 55 6E 4D 61 6B 65 20 32 2E 30 A3 02 9C 28 24 00 82 11 BE 0F 01 98 0D 22 00 01 03 DF D2 41 00 00 02 19 A2 ED 86 09 19 A2 ED 86 09 19 A2 ED 86 09 00 00 00 07 53 65 74 65 68 68 5F 08 A5 32 A0 05 00 00 00 00 00 1F 00 00 00 00 00 07 0B 05 01 B5 E0 04 05 02 80 06 05 03 04 05 04 00 05 0C AB 0B 05 0D 00 05 0E 04 05 0F 97 09 05 16 91 0A 05 1C 00 05 1D 8A 88 D5 44 00 00 00 05 05 06 82 34 05 07 87 09 05 0B 1F 05 14 0A 05 1B 0A 88 01 1A 00 00 1A 01 00 1A 02 00 1A 03 00 1A 04 00 1A 05 00 1A 06 00 1A 07 00 1A 08 00 1A 09 00 1A 0A 00 1A 0B 00 1A 0C 01 1A 0D 00 1A 0E 00 1A 0F 00 1A 10 00 1A 11 00 1A 12 00 1A 13 00 1A 14 00 1A 15 00 1A 16 00 1A 17 04 1A 18 00 1A 19 00 1A 1A 04 1A 1B 00 1A 1C 00 1A 1D 00 1A 1E 00 1A 1F 00 1A 20 86 02 1A 21 03 1A 22 00 1A 23 00 1A 24 00 1A 25 00 1A 26 00 1A 27 00 1A 28 00 1A 29 00 1A 2A 05 1A 2B 05 1A 2D 00 1A 2E 00 1B 00 00 1B 01 00 1B 02 00 1B 03 00 1B 04 00 1B 05 00 1B 06 00 1B 07 00 1B 08 00 1B 09 00 1B 0A 00 1C 00 00 1C 01 00 1C 02 00 1C 03 00 1C 04 00 1C 05 00 1C 06 00 1C 07 00 1C 08 04 1C 09 00 1C 0A 2C 1C 0B 04 1C 0C 00 1C 0D 00 1C 10 00 00 0A 02 07 B8 DA 26 00 00 00 0D 4F 73 20 47 75 61 72 64 69 C3 B5 65 73 0B A6 31 0C 9D 05 A0 15 AE 16 03 3E 09 00 01 03 DF D2 41 00 00 00 0C 02 00 0B 1E 87 D8 9D 01 00 19 A2 ED 86 09 00 00 00 00 00 00 00 00 00 11 00 A1 3E 00 00 B5 01 CB 7E 11 83 04 C3 7E 0A 23 01 23 01 23 01 23 00 23 00 22 09 22 13 22 02 22 02 22 02 00 01 00 00 01 00 00 00 00 00 05 01 05 02 05 03 05 04 05 05 05 8F 02 05 92 02 05 93 02 05 94 02 05 95 02 08 0D AC 36 A4 65 00 86 03 A2 02 00 A4 01 00 00 00 00 01 00 00 00 00 00 00 00 00 08 0D AC 36 9C 8E 03 00 09 C1 7C 02 A4 01 00 00 00 00 01 00 00 00 00 00 00 00 00 08 0D A4 E2 01 A4 65 00 13 BF 03 00 A4 01 00 00 00 00 02 00 00 00 00 00 00 00 00 08 0C A8 8C 01 B8 2E 00 00 80 04 00 A4 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 05 04 01 01 7E 03 00 04 06 05 04 07 07 06 00 90 8D 06 00 04 00 00 1D 00 00 A4 EA E5 18 83 F3 DF 19 A9 EA E5 18 81 FC D9 1A AA EA E5 18 87 FC D9 1A 8C EA E5 18 86 EA E5 18 08 0D A8 8C 01 88 C5 03 00 00 C0 7C 00 A4 01 00 00 00 00 00 00 00 00 00 00 00 00 00 00 05 04 00 04 01 7E 04 01 02 07 06 00 06 02 00 98 CC 0B 00 08 00 96 34 1E 00 00 AB EA E5 18 9A EA E5 18 A1 EA E5 18 97 EA E5 18 AA EA E5 18 8B FC D9 1A 88 FC D9 1A 8C EA E5 18 07 0F 97 DE 01 A5 BE 02 00 03 80 04 01 A4 01 00 00 00 00 02 00 00 00 00 00 00 00 00 08 0F 96 3B 98 89 02 00 77 80 04 01 A4 01 00 00 00 00 01 00 00 00 00 00 00 00 00 08 0F 81 3B 90 9D 02 00 7A 80 04 01 A4 01 00 00 00 00 01 00 00 00 00 00 00 00 00 08 0F 84 DE 01 8A 93 02 00 08 80 04 01 A4 01 00 00 00 00 02 00 00 00 00 00 00 00 00 08 0F 97 DE 01 AF A5 02 00 04 80 04 01 A4 01 00 00 00 00 02 00 00 00 00 00 00 00 00 00 00 AC 36 9C 8E 03 00 00 00 05 02 00 00 83 3B 98 9B 02 00 00 00 05 93 02 00 00 A8 8C 01 88 C5 03 00 00 00 05 05 00 00 A4 E2 01 9C 8E 03 00 00 00 00 00 00 AC 36 A4 65 00 00 00 05 01 00 00 A8 8C 01 88 C5 03 00 00 00 05 05 00 00 AC 36 9C 8E 03 00 00 00 05 02 00 00 AC 36 9C 8E 03 00 00 00 05 02 00 00 A8 8C 01 88 C5 03 00 00 00 05 05 00 00 A8 8C 01 88 C5 03 00 00 00 05 05 00 13 B3 1F 5D 01 01 01 01 01 5D 5C 5C 5C 5C 5C 5D 5D 5C 5C 5C 5C 00 00 00 00 00 00 00 00 7F 00 00 00 03 80 04 00 A2 4B 00 7F 7F 00 05 A7 16 5C 5C 5C 5C 00 00 00 00 00 00 00 00 7F 00 00 00 77 80 04 00 AA 7A 00 7F 7F 10 0B AB 1B 5C 5C 5C 5C 5C 5C 5C 5C 5C 5C 00 00 00 00 00 00 00 00 7F 00 00 00 7C 80 04 00 AA 7A 00 7F 7F 00 1A B2 1F 5D 01 01 01 01 01 01 5D 5C 5C 5C 5C 5C 5C 5D 5D 5C 5C 5C 5C 5C 5C 5C 5C 5C 00 00 00 00 00 00 00 00 7F 00 00 00 08 80 04 00 B6 72 00 7F 7F 10 17 B2 1F 5D 01 01 01 01 01 01 5D 5C 5C 5C 5C 5C 5C 5D 5D 5C 5C 5C 5C 5C 5C 00 00 00 00 00 00 00 00 7F 00 00 00 03 80 04 00 B6 72 00 7F 7F A6 27 B4 26 AE 10 A8 3E A8 3E BC 01 AE 01 A9 02 0A 0A 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 00 00 00 00 00 00 00 A4 01 A4 01 FF 01 0D 03 07 02 2B 00 36 06 2A 08 25 05 82 01 08 88 01 03 00 FE 03 22 00 2B 00 1B 00 18 00 2C 08 0D 03 89 01 08 8C 01 00 00 00 05 06 02 02 04 01 03 00 00 00 00 00 00 00 00 00 05 0B 01 01 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 00 00 00 00 00 00 00 0C 00 00 00 B4 A9 A5 E3 04 00 2A 00 2B".Replace(" ", ""));
        }

        internal override void Process()
        {
        }
    }
}