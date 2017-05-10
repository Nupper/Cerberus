﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Servers.CR.Database;
using BL.Servers.CR.Extensions;
using BL.Servers.CR.Extensions.List;
using BL.Servers.CR.Files;
using BL.Servers.CR.Files.CSV_Helpers;
using BL.Servers.CR.Logic.Enums;
using BL.Servers.CR.Logic.Slots.Items;

namespace BL.Servers.CR.Logic.Slots
{
   
    using System.Collections.Generic;
    using System.Linq;


    internal class Resources : List<Slot>
    {
        internal Avatar Player;

        /// <summary>
        /// Initializes a new instance of the <see cref="Resources"/> class.
        /// </summary>
        internal Resources()
        {
            // Resources.
        }

        internal Resources(Avatar _Player, bool Initialize = false)
        {
            this.Player = _Player;

            if (Initialize)
                this.Initialize();
        }

        internal int Gems => this.Get(Resource.Diamonds);

        internal int Get(int Gl_ID)
        {
            int i = this.FindIndex(R => R.Data == Gl_ID);

            if (i > -1)
                return this[i].Count;

            return 0;
        }

        internal int Get(Resource Gl_ID)
        {
            return this.Get(3000000 + (int) Gl_ID);
        }

        internal void Set(int Gl_ID, int Count)
        {
            int i = this.FindIndex(R => R.Data == Gl_ID);

            if (i > -1)
                this[i].Count = Count;
            else this.Add(new Slot(Gl_ID, Count));
        }

        internal void Set(Resource Resource, int Count)
        {
            this.Set(3000000 + (int) Resource, Count);
        }

        internal void Plus(int Gl_ID, int Count)
        {
            int i = this.FindIndex(R => R.Data == Gl_ID);

            if (i > -1)
                this[i].Count += Count;
            else this.Add(new Slot(Gl_ID, Count));
        }

        internal void Plus(Resource Resource, int Count)
        {
            this.Plus(3000000 + (int) Resource, Count);
        }

        internal bool Minus(int Gl_ID, int Count)
        {
            int i = this.FindIndex(R => R.Data == Gl_ID);

            if (i > -1)
                if (this[i].Count >= Count)
                {
                    this[i].Count -= Count;
                    return true;
                }

            return false;
        }

        internal void Minus(Resource _Resource, int _Value)
        {
            int Index = this.FindIndex(T => T.Data == 3000000 + (int) _Resource);

            if (Index > -1)
            {
                this[Index].Count -= _Value;
            }
        }

        internal byte[] ToBytes
        {
            get
            {
                List<byte> Packet = new List<byte>();

                Packet.AddInt(this.Count - 1);
                foreach (Slot Resource in this.Skip(1))
                {
                    Packet.AddInt(Resource.Data);
                    Packet.AddInt(Resource.Count);
                }

                return Packet.ToArray();
            }
        }

        internal void Initialize()
        {
            this.Set(Resource.Diamonds, Utils.ParseConfigInt("startingGems"));

            this.Set(Resource.Resource1, Utils.ParseConfigInt("startingGold"));
        }
    }
}