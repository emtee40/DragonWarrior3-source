﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DW3Editor
{
	public static class Lookups
	{

		public static readonly Dictionary<int, string> Items = new Dictionary<int, string>
		{
			{ 0x00, "Cypress Stick" },
			{ 0x01, "Club" },
			{ 0x02, "Copper Sword" },
			{ 0x03, "Magic Knife" },
			{ 0x04, "Iron Spear" },
			{ 0x05, "Battle Axe" },
			{ 0x06, "Broad Sword" },
			{ 0x07, "Wizard's Wand" },
			{ 0x08, "Poison Needle" },
			{ 0x09, "Iron Claw" },
			{ 0x0A, "Thorn Whip" },
			{ 0x0B, "Giant Shears" },
			{ 0x0C, "Chain Sickle" },
			{ 0x0D, "Thor's Sword" },
			{ 0x0E, "Snowblast Sword" },
			{ 0x0F, "Demon Axe" },
			{ 0x10, "Staff of Rain" },
			{ 0x11, "Sword of Gaia" },
			{ 0x12, "Staff of Reflection" },
			{ 0x13, "Sword of Destruction" },
			{ 0x14, "Multi-Edge Sword" },
			{ 0x15, "Staff of Force" },
			{ 0x16, "Sword of Illusion" },
			{ 0x17, "Zombie Slasher" },
			{ 0x18, "Falcon Sword" },
			{ 0x19, "Sledge Hammer" },
			{ 0x1A, "Thunder Sword" },
			{ 0x1B, "Staff of Thunder" },
			{ 0x1C, "Sword of Kings" },
			{ 0x1D, "Orochi Sword" },
			{ 0x1E, "Dragon Killer" },
			{ 0x1F, "Staff of Judgement" },
			{ 0x20, "Clothes" },
			{ 0x21, "Training Suit" },
			{ 0x22, "Leather Armor" },
			{ 0x23, "Flashy Clothes" },
			{ 0x24, "Half Plate Armor" },
			{ 0x25, "Full Plate Armor" },
			{ 0x26, "Magic Armor" },
			{ 0x27, "Cloak of Evasion" },
			{ 0x28, "Armor of Radiance" },
			{ 0x29, "Iron Apron" },
			{ 0x2A, "Animal Suit" },
			{ 0x2B, "Fighting Suit" },
			{ 0x2C, "Sacred Robe" },
			{ 0x2D, "Armor of Hades" },
			{ 0x2E, "Water Flying Cloth" },
			{ 0x2F, "Chain Mail" },
			{ 0x30, "Wayfarer's Clothes" },
			{ 0x31, "Revealing Swimsuit" },
			{ 0x32, "Magic Bikini" },
			{ 0x33, "Shell Armor" },
			{ 0x34, "Armor of Terrafirma" },
			{ 0x35, "Dragon Mail" },
			{ 0x36, "Swordedge Armor" },
			{ 0x37, "Angel's Robe" },
			{ 0x38, "Leather Shield" },
			{ 0x39, "Iron Shield" },
			{ 0x3A, "Shield of Strength" },
			{ 0x3B, "Shield of Heroes" },
			{ 0x3C, "Shield of Sorrow" },
			{ 0x3D, "Bronze Shield" },
			{ 0x3E, "Silver Shield" },
			{ 0x3F, "Golden Crown" },
			{ 0x40, "Iron Helmet" },
			{ 0x41, "Mysterious Hat" },
			{ 0x42, "Unlucky Helmet" },
			{ 0x43, "Turban" },
			{ 0x44, "Noh Mask" },
			{ 0x45, "Leather Helmet" },
			{ 0x46, "Iron Mask" },
			{ 0x47, "Sacred Amulet" },
			{ 0x48, "Ring of Life" },
			{ 0x49, "Shoes of Happiness" },
			{ 0x4A, "Golden Claw" },
			{ 0x4B, "Meteorite Armband" },
			{ 0x4C, "Book of Satori" },
			{ 0x4D, "(blank)" },
			{ 0x4E, "Wizard's Ring" },
			{ 0x4F, "Black Pepper" },
			{ 0x50, "Sage's Stone" },
			{ 0x51, "Mirror of Ra" },
			{ 0x52, "Vase of Drought" },
			{ 0x53, "Lamp of Darkness" },
			{ 0x54, "Staff of Change" },
			{ 0x55, "Stone of Light" },
			{ 0x56, "Invisibility Herb" },
			{ 0x57, "Magic Ball" },
			{ 0x58, "Thief's Key" },
			{ 0x59, "Magic Key" },
			{ 0x5A, "Final Key" },
			{ 0x5B, "Dream Ruby" },
			{ 0x5C, "Wake Up Powder" },
			{ 0x5D, "Royal Scroll" },
			{ 0x5E, "Oricon" },
			{ 0x5F, "Strength Seed" },
			{ 0x60, "Agility Seed" },
			{ 0x61, "Vitality Seed" },
			{ 0x62, "Luck Seed" },
			{ 0x63, "Intelligence Seed" },
			{ 0x64, "Acorns of Life" },
			{ 0x65, "Medical Herb" },
			{ 0x66, "Antidote Herb" },
			{ 0x67, "Fairy Water" },
			{ 0x68, "Wing of Wyvern" },
			{ 0x69, "Leaf of World Tree" },
			{ 0x6A, "(blank)" },
			{ 0x6B, "Locket of Love" },
			{ 0x6C, "Full Moon Herb" },
			{ 0x6D, "Water Blaster" },
			{ 0x6E, "Sailor's Thigh Bone" },
			{ 0x6F, "Echoing Flute" },
			{ 0x70, "Fairy Flute" },
			{ 0x71, "Silver Harp" },
			{ 0x72, "Sphere of Light" },
			{ 0x73, "Poison Moth Powder" },
			{ 0x74, "Spider's Web" },
			{ 0x75, "Stones of Sunlight" },
			{ 0x76, "Rainbow Drop" },
			{ 0x77, "Silver Orb" },
			{ 0x78, "Red Orb" },
			{ 0x79, "Yellow Orb" },
			{ 0x7A, "Purple Orb" },
			{ 0x7B, "Blue Orb" },
			{ 0x7C, "Green Orb" },
			{ 0x7D, "Stick Slime" },
			{ 0x7E, "Black Raven" },
			{ 0x7F, "Sword Horned" },
			{ 0x80, "eCypress Stick" },
			{ 0x81, "eClub" },
			{ 0x82, "eCopper Sword" },
			{ 0x83, "eMagic Knife" },
			{ 0x84, "eIron Spear" },
			{ 0x85, "eBattle Axe" },
			{ 0x86, "eBroad Sword" },
			{ 0x87, "eWizard's Wand" },
			{ 0x88, "ePoison Needle" },
			{ 0x89, "eIron Claw" },
			{ 0x8A, "eThorn Whip" },
			{ 0x8B, "eGiant Shears" },
			{ 0x8C, "eChain Sickle" },
			{ 0x8D, "eThor's Sword" },
			{ 0x8E, "eSnowblast Sword" },
			{ 0x8F, "eDemon Axe" },
			{ 0x90, "eStaff of Rain" },
			{ 0x91, "eSword of Gaia" },
			{ 0x92, "eStaff of Reflection" },
			{ 0x93, "eSword of Destruction" },
			{ 0x94, "eMulti-Edge Sword" },
			{ 0x95, "eStaff of Force" },
			{ 0x96, "eSword of Illusion" },
			{ 0x97, "eZombie Slasher" },
			{ 0x98, "eFalcon Sword" },
			{ 0x99, "eSledge Hammer" },
			{ 0x9A, "eThunder Sword" },
			{ 0x9B, "eStaff of Thunder" },
			{ 0x9C, "eSword of Kings" },
			{ 0x9D, "eOrochi Sword" },
			{ 0x9E, "eDragon Killer" },
			{ 0x9F, "eStaff of Judgement" },
			{ 0xA0, "eClothes" },
			{ 0xA1, "eTraining Suit" },
			{ 0xA2, "eLeather Armor" },
			{ 0xA3, "eFlashy Clothes" },
			{ 0xA4, "eHalf Plate Armor" },
			{ 0xA5, "eFull Plate Armor" },
			{ 0xA6, "eMagic Armor" },
			{ 0xA7, "eCloak of Evasion" },
			{ 0xA8, "eArmor of Radiance" },
			{ 0xA9, "eIron Apron" },
			{ 0xAA, "eAnimal Suit" },
			{ 0xAB, "eFighting Suit" },
			{ 0xAC, "eSacred Robe" },
			{ 0xAD, "eArmor of Hades" },
			{ 0xAE, "eWater Flying Cloth" },
			{ 0xAF, "eChain Mail" },
			{ 0xB0, "eWayfarer's Clothes" },
			{ 0xB1, "eRevealing Swimsuit" },
			{ 0xB2, "eMagic Bikini" },
			{ 0xB3, "eShell Armor" },
			{ 0xB4, "eArmor of Terrafirma" },
			{ 0xB5, "eDragon Mail" },
			{ 0xB6, "eSwordedge Armor" },
			{ 0xB7, "eAngel's Robe" },
			{ 0xB8, "e Leather Shield" },
			{ 0xB9, "eIron Shield" },
			{ 0xBA, "eShield of Strength" },
			{ 0xBB, "eShield of Heroes" },
			{ 0xBC, "eShield of Sorrow" },
			{ 0xBD, "eBronze Shield" },
			{ 0xBE, "eSilver Shield" },
			{ 0xBF, "eGolden Crown" },
			{ 0xC0, "eIron Helmet" },
			{ 0xC1, "eMysterious Hat" },
			{ 0xC2, "eUnlucky Helmet" },
			{ 0xC3, "eTurban" },
			{ 0xC4, "eNoh Mask" },
			{ 0xC5, "eLeather Helmet" },
			{ 0xC6, "eIron Mask" },
			{ 0xC7, "eSacred Amulet" },
			{ 0xC8, "eRing of Life" },
			{ 0xC9, "eShoes of Happiness" },
			{ 0xCA, "eGolden Claw" },
			{ 0xCB, "eMeteorite Armband" },
			{ 0xCC, "eBook of Satori" },
			{ 0xCD, "e(blank)" },
			{ 0xCE, "eWizard's Ring" },
			{ 0xCF, "eBlack Pepper" },
			{ 0xD0, "eSage's Stone" },
			{ 0xD1, "eMirror of Ra" },
			{ 0xD2, "eVase of Drought" },
			{ 0xD3, "eLamp of Darkness" },
			{ 0xD4, "eStaff of Change" },
			{ 0xD5, "eStone of Light" },
			{ 0xD6, "eInvisibility Herb" },
			{ 0xD7, "eMagic Ball" },
			{ 0xD8, "eThief's Key" },
			{ 0xD9, "eMagic Key" },
			{ 0xDA, "eFinal Key" },
			{ 0xDB, "eDream Ruby" },
			{ 0xDC, "eWake Up Powder" },
			{ 0xDD, "eRoyal Scroll" },
			{ 0xDE, "eOricon" },
			{ 0xDF, "eStrength Seed" },
			{ 0xE0, "eAgility Seed" },
			{ 0xE1, "eVitality Seed" },
			{ 0xE2, "eLuck Seed" },
			{ 0xE3, "eIntelligence Seed" },
			{ 0xE4, "eAcorns of Life" },
			{ 0xE5, "eMedical Herb" },
			{ 0xE6, "eAntidote Herb" },
			{ 0xE7, "eFairy Water" },
			{ 0xE8, "eWing of Wyvern" },
			{ 0xE9, "eLeaf of World Tree" },
			{ 0xEA, "e(blank)" },
			{ 0xEB, "eLocket of Love" },
			{ 0xEC, "eFull Moon Herb" },
			{ 0xED, "eWater Blaster" },
			{ 0xEE, "eSailor's Thigh Bone" },
			{ 0xEF, "eEchoing Flute" },
			{ 0xF0, "eFairy Flute" },
			{ 0xF1, "eSilver Harp" },
			{ 0xF2, "eSphere of Light" },
			{ 0xF3, "ePoison Moth Powder" },
			{ 0xF4, "eSpider's Web" },
			{ 0xF5, "eStones of Sunlight" },
			{ 0xF6, "eRainbow Drop" },
			{ 0xF7, "eSilver Orb" },
			{ 0xF8, "eRed Orb" },
			{ 0xF9, "eYellow Orb" },
			{ 0xFA, "ePurple Orb" },
			{ 0xFB, "eBlue Orb" },
			{ 0xFC, "eGreen Orb" },
			{ 0xFD, "eStick Slime" },
			{ 0xFE, "eBlack Raven" },
			{ 0xFF, "(empty)" }
		};

		public static readonly Dictionary<int, string> Enemies = new Dictionary<int, string>
		{
			{ 0x00, "Slime" },
			{ 0x01, "Black Raven" },
			{ 0x02, "Horned Rabbit" },
			{ 0x03, "Giant Anteater" },
			{ 0x04, "Masked Moth" },
			{ 0x05, "Froggore" },
			{ 0x06, "Babble" },
			{ 0x07, "Magician" },
			{ 0x08, "Scorpion Wasp" },
			{ 0x09, "Healer" },
			{ 0x0A, "Demon Anteater" },
			{ 0x0B, "Spiked Hare" },
			{ 0x0C, "Poison Toad" },
			{ 0x0D, "Caterpillar" },
			{ 0x0E, "Humanabat" },
			{ 0x0F, "Putrepup" },
			{ 0x10, "Killer Bee" },
			{ 0x11, "Army Crab" },
			{ 0x12, "Gas Clouds" },
			{ 0x13, "Demon Toadstool" },
			{ 0x14, "Poison Silkworm" },
			{ 0x15, "Avenger Raven" },
			{ 0x16, "Madhound" },
			{ 0x17, "Deadly Toadstool" },
			{ 0x18, "Shadow" },
			{ 0x19, "Vampire" },
			{ 0x1A, "Man-Eater Moth" },
			{ 0x1B, "Rogue Knight" },
			{ 0x1C, "Vampire Cat" },
			{ 0x1D, "King Froggore" },
			{ 0x1E, "Wild Ape" },
			{ 0x1F, "Trick Bag" },
			{ 0x20, "Mummy Man" },
			{ 0x21, "Infernus Crab" },
			{ 0x22, "Lumpus" },
			{ 0x23, "Flamapede" },
			{ 0x24, "Mummy" },
			{ 0x25, "Mage Toadstool" },
			{ 0x26, "Hunter Fly" },
			{ 0x27, "Avenger Jackal" },
			{ 0x28, "Nev" },
			{ 0x29, "Heat Clouds" },
			{ 0x2A, "Tonguebear" },
			{ 0x2B, "Curer" },
			{ 0x2C, "Rammore" },
			{ 0x2D, "Catula" },
			{ 0x2E, "Evil Mage" },
			{ 0x2F, "Simiac" },
			{ 0x30, "Garuda" },
			{ 0x31, "Metal Slime" },
			{ 0x32, "Goategon" },
			{ 0x33, "Executioner" },
			{ 0x34, "Demonite" },
			{ 0x35, "Deranger" },
			{ 0x36, "Man-Eater Chest" },
			{ 0x37, "Eliminator" },
			{ 0x38, "Great Beak" },
			{ 0x39, "Slime Snaii" },
			{ 0x3A, "Sky Dragon" },
			{ 0x3B, "Barnabas" },
			{ 0x3C, "Witch" },
			{ 0x3D, "Avenger Beak" },
			{ 0x3E, "Infernus Knight" },
			{ 0x3F, "Marine Slime" },
			{ 0x40, "Man O' Wars" },
			{ 0x41, "Merzon" },
			{ 0x42, "King Squid" },
			{ 0x43, "Crabus" },
			{ 0x44, "Merzoncian" },
			{ 0x45, "Hades' Condor" },
			{ 0x46, "Fierce Bear" },
			{ 0x47, "Hork" },
			{ 0x48, "Bighorn" },
			{ 0x49, "Stingwing" },
			{ 0x4A, "Venom Zombies" },
			{ 0x4B, "Blue Beak" },
			{ 0x4C, "Lethal ARmor" },
			{ 0x4D, "Avenger" },
			{ 0x4E, "Lava Basher" },
			{ 0x4F, "Witch Doctors" },
			{ 0x50, "Old Hag" },
			{ 0x51, "Terror Shadow" },
			{ 0x52, "Glacier Basher" },
			{ 0x53, "Wyvern" },
			{ 0x54, "Kong" },
			{ 0x55, "Tortragon" },
			{ 0x56, "Elysium Bird" },
			{ 0x57, "Bomb Crag" },
			{ 0x58, "Grizzly" },
			{ 0x59, "Voodoo Shaman" },
			{ 0x5A, "King Tortragon" },
			{ 0x5B, "Snow Dragon" },
			{ 0x5C, "Troll" },
			{ 0x5D, "Frost Cloud" },
			{ 0x5E, "Dancing Jewel" },
			{ 0x5F, "Minidemon" },
			{ 0x60, "Tentacles" },
			{ 0x61, "Skeleton" },
			{ 0x62, "Mimic" },
			{ 0x63, "Marauder" },
			{ 0x64, "Hologhost" },
			{ 0x65, "Orochi" },
			{ 0x66, "Stone Hulk" },
			{ 0x67, "Salamander" },
			{ 0x68, "Red Slime" },
			{ 0x69, "Goopi" },
			{ 0x6A, "Vile Shadow" },
			{ 0x6B, "Voodoo Warlock" },
			{ 0x6C, "Metal Babble" },
			{ 0x6D, "Ghoul" },
			{ 0x6E, "Lionhead" },
			{ 0x6F, "Boss Troll" },
			{ 0x70, "Gold Basher" },
			{ 0x71, "Scalgon" },
			{ 0x72, "King Merzon" },
			{ 0x73, "Kragacles" },
			{ 0x74, "Darthbear" },
			{ 0x75, "Granite Titan" },
			{ 0x76, "Leona" },
			{ 0x77, "Archmage" },
			{ 0x78, "Magiwyvern" },
			{ 0x79, "Winged Demon" },
			{ 0x7A, "Hydra" },
			{ 0x7B, "Troll King" },
			{ 0x7C, "Green Dragon" },
			{ 0x7D, "Barog" },
			{ 0x7E, "Putregon" },
			{ 0x7F, "Lionroar" },
			{ 0x80, "Swordoid" },
			{ 0x81, "King Hydra" },
			{ 0x82, "Baramos Bomus" },
			{ 0x83, "Baramos Gonus" },
			{ 0x84, "Baramos" },
			{ 0x85, "Zoma" },
			{ 0x86, "Zoma Weakened" },
			{ 0x87, "Ortega" },
			{ 0x88, "Kandar" },
			{ 0x89, "Kandar II" },
			{ 0x8A, "Kandar Henchman" }
		};
	}
}
