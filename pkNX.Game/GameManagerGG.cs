﻿using System.IO;
using System.Linq;
using pkNX.Containers;
using pkNX.Structures;

namespace pkNX.Game
{
    public class GameManagerGG : GameManager
    {
        public GameManagerGG(GameLocation rom, int language) : base(rom, language) { }
        private GameVersion ActualGame;
        public string TitleID => ActualGame == GameVersion.GP ? Pikachu : Eevee;
        private const string Pikachu = "010003F003A34000";
        private const string Eevee = "0100187003A36000";

        protected override void SetMitm()
        {
            var basePath = Path.GetDirectoryName(ROM.RomFS);
            var eeveevidpath = Path.Combine(ROM.RomFS, Path.Combine("bin", "movies", "EEVEE_GO"));
            bool eevee = Directory.Exists(eeveevidpath);
            ActualGame = eevee ? GameVersion.GE : GameVersion.GP;
            var redirect = Path.Combine(basePath, TitleID);
            // get pikachu vs eevee
            FileMitm.SetRedirect(basePath, redirect);
        }

        protected override void Initialize()
        {
            // initialize gametext
            GetFilteredFolder(GameFile.GameText, z => Path.GetExtension(z) == ".dat");

            // initialize common structures
            var personal = GetFilteredFolder(GameFile.PersonalStats, z => Path.GetFileNameWithoutExtension(z) == "personal_total");
            Data = new GameData
            {
                MoveData = new DataCache<Move>(this[GameFile.MoveStats]) // mini
                {
                    Create = z => new Move7(z),
                    Write = z => z.Write(),
                },
                LevelUpData = new DataCache<Learnset>(this[GameFile.Learnsets]) // gfpak
                {
                    Create = z => new Learnset6(z),
                    Write = z => z.Write(),
                },

                // folders;
                PersonalData = new PersonalTable(personal[0], Game),
                MegaEvolutionData = new DataCache<MegaEvolutionSet[]>(GetFilteredFolder(GameFile.MegaEvolutions))
                {
                    Create = MegaEvolutionSet.ReadArray,
                    Write = MegaEvolutionSet.WriteArray,
                },
                EvolutionData = new DataCache<EvolutionSet>(GetFilteredFolder(GameFile.Evolutions))
                {
                    Create = (data) => new EvolutionSet7(data),
                    Write = evo => evo.Write(),
                },
            };
        }

        protected override void Terminate()
        {
            // Store Personal Data back in the file. Let the container detect if it is modified.
            var personal = this[GameFile.PersonalStats];
            personal[0] = Data.PersonalData.Table.SelectMany(z => z.Write()).ToArray();
        }
    }
}