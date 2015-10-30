using System;

namespace Terraria
{
	public class Lang
	{
		public static int lang;

		public static string[] misc;

		public static string[] menu;

		public static string[] gen;

		public static string[] inter;

		public static string[] tip;

		public static string[] mp;

		public static string[] dt;

		public static string[] chestType;

		public static string[] dresserType;

		public static string[] mapLegend;

		public static string[] prefix;

		public static string the;

		static Lang()
		{
			Lang.lang = 0;
			Lang.misc = new string[53];
			Lang.menu = new string[142];
			Lang.gen = new string[82];
			Lang.inter = new string[115];
			Lang.tip = new string[60];
			Lang.mp = new string[23];
			Lang.dt = new string[4];
			Lang.chestType = new string[52];
			Lang.dresserType = new string[28];
			Lang.prefix = new string[84];
		}

		public Lang()
		{
		}

		public static string AnglerQuestChat(bool gotFish = false)
		{
			NPC.firstNPCName(18);
			NPC.firstNPCName(17);
			NPC.firstNPCName(19);
			NPC.firstNPCName(20);
			NPC.firstNPCName(38);
			NPC.firstNPCName(54);
			NPC.firstNPCName(22);
			NPC.firstNPCName(108);
			NPC.firstNPCName(107);
			NPC.firstNPCName(124);
			NPC.firstNPCName(160);
			NPC.firstNPCName(178);
			NPC.firstNPCName(207);
			NPC.firstNPCName(208);
			NPC.firstNPCName(209);
			NPC.firstNPCName(227);
			NPC.firstNPCName(228);
			NPC.firstNPCName(229);
			NPC.firstNPCName(353);
			NPC.firstNPCName(368);
			string str = NPC.firstNPCName(369);
			int num = 8;
			string[] strArrays = new string[num];
			string[] strArrays1 = new string[num];
			strArrays[0] = "";
			int num1 = 0;
			string str1 = "";
			bool flag = false;
			if (gotFish)
			{
				switch (Main.rand.Next(5))
				{
					case 0:
					{
						strArrays1[0] = "Oh! Thanks for the fish I asked for, now scram!";
						break;
					}
					case 1:
					{
						strArrays1[0] = "Awesome catch! It's all going according to plan! He he he!";
						break;
					}
					case 2:
					{
						strArrays1[0] = "You make a great errand monkey! Now go away!";
						break;
					}
					case 3:
					{
						strArrays1[0] = "Muahahahahaha! You did it! You're still in one piece though, how boring!";
						break;
					}
					case 4:
					{
						strArrays1[0] = "Woah!? You actually did what I asked, and survived! Nice, hand it over and beat it!";
						break;
					}
				}
			}
			if (!Main.anglerQuestFinished)
			{
				switch (Main.anglerQuestItemNetIDs[Main.anglerQuest])
				{
					case 2450:
					{
						if (!gotFish)
						{
							int num2 = num1;
							num1 = num2 + 1;
							strArrays[num2] = "Na na na na na na na Bat-FISH!";
							int num3 = num1;
							num1 = num3 + 1;
							strArrays[num3] = "That means go digging underground, fetch it, and bring it to me!";
							flag = true;
							str1 = "\n(caught )";
							str1 = "\n(Caught in Underground & Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2451:
					{
						if (!gotFish)
						{
							int num4 = num1;
							num1 = num4 + 1;
							strArrays[num4] = string.Concat("The subterranean jungles of ", Main.worldName, " have the weirdest things!");
							int num5 = num1;
							num1 = num5 + 1;
							strArrays[num5] = "Like, there's this fish I saw that looked just like a giant bumblebee!";
							int num6 = num1;
							num1 = num6 + 1;
							strArrays[num6] = "I'm allergic to bees, so you have to catch it for me! I bet it'd taste like a tuna and honey sandwich!";
							flag = true;
							str1 = "\n(Caught in Honey)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2452:
					{
						if (!gotFish)
						{
							int num7 = num1;
							num1 = num7 + 1;
							strArrays[num7] = "I finally found a jungle cat that likes water! I think it's because it's also part fish.";
							int num8 = num1;
							num1 = num8 + 1;
							strArrays[num8] = "I don't know why this happened, and I don't want to know.";
							int num9 = num1;
							num1 = num9 + 1;
							strArrays[num9] = "I just want it in my hands, and make it snappy!";
							flag = true;
							str1 = "\n(Caught in Jungle Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2453:
					{
						if (!gotFish)
						{
							int num10 = num1;
							num1 = num10 + 1;
							strArrays[num10] = "There's a rumor going around that there are islands that float high up in the sky, and that they have amazing treasure!";
							int num11 = num1;
							num1 = num11 + 1;
							strArrays[num11] = "Who cares about that though, what's even cooler is that sometimes lakes form in the clouds, and in those lakes are fish made out of clouds!";
							int num12 = num1;
							num1 = num12 + 1;
							strArrays[num12] = "I wanna know what it tastes like, so you better go catch it for me!";
							flag = true;
							str1 = "\n(Caught in Sky Lakes)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2454:
					{
						if (!gotFish)
						{
							int num13 = num1;
							num1 = num13 + 1;
							strArrays[num13] = "There's a cursed fish swimming in the waters of the deepest corruption!";
							int num14 = num1;
							num1 = num14 + 1;
							strArrays[num14] = "It was forged of the cursed flames that spread from the fallen horrors that lurk down there.";
							int num15 = num1;
							num1 = num15 + 1;
							strArrays[num15] = "They say not even water can put out this fire, and that it can burn forever.";
							int num16 = num1;
							num1 = num16 + 1;
							strArrays[num16] = "I can think of some awesome things I can do with a fish like that! You gonna go get it for me, or are you too chicken!?";
							flag = true;
							str1 = "\n(Caught in Corruption)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2455:
					{
						if (!gotFish)
						{
							int num17 = num1;
							num1 = num17 + 1;
							strArrays[num17] = "I was reeling in the big one when this funny talking zombie burst out of the forest lake and started rambling on about this 'ferocious' species of fish made out of dirt!";
							int num18 = num1;
							num1 = num18 + 1;
							strArrays[num18] = "He says it could suffocate ten blokes his size, or something like that... I want it! NOW!";
							flag = true;
							str1 = "\n(Caught in Surface, Underground, & Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2456:
					{
						if (!gotFish)
						{
							int num19 = num1;
							num1 = num19 + 1;
							strArrays[num19] = "The demolitionist was raising cane about losing a stick of dynamite in the lake out in the forest. He has like, so many, so why does one matter?";
							int num20 = num1;
							num1 = num20 + 1;
							strArrays[num20] = "Apparently, because it grew fins and started swimming away! I don't know where he gets his materials to make those things, but that one is clearly possessed!";
							int num21 = num1;
							num1 = num21 + 1;
							strArrays[num21] = "Reel it in and bring it to me, I always wanted a suicide bombing fish! Don't ask why...";
							flag = true;
							str1 = "\n(Caught in Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2457:
					{
						if (!gotFish)
						{
							int num22 = num1;
							num1 = num22 + 1;
							strArrays[num22] = "I bet you're not brave enough to find the Eater of Plankton.";
							int num23 = num1;
							num1 = num23 + 1;
							strArrays[num23] = "A corrupt fish that was mutated from a severed piece of the Eater of Worlds itself!";
							int num24 = num1;
							num1 = num24 + 1;
							strArrays[num24] = "Capture it and bring it to me, and prove to me you're not a wuss!";
							flag = true;
							str1 = "\n(Caught in Corruption)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2458:
					{
						if (!gotFish)
						{
							int num25 = num1;
							num1 = num25 + 1;
							strArrays[num25] = "I love collecting those bright yellow stars that fall from the sky! I love it even more when they land on someone's head.";
							int num26 = num1;
							num1 = num26 + 1;
							strArrays[num26] = "But.. but.. nothing beats a star that falls in a foresty lake and turns into a fish!";
							int num27 = num1;
							num1 = num27 + 1;
							strArrays[num27] = "That's just totally rad, and you're just rad enough to get it for me!";
							flag = true;
							str1 = "\n(Caught in Sky Lakes)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2459:
					{
						if (!gotFish)
						{
							int num28 = num1;
							num1 = num28 + 1;
							strArrays[num28] = "Apparently, Demon Eyes can sometimes be amphibious. They don't fly, they swim!";
							int num29 = num1;
							num1 = num29 + 1;
							strArrays[num29] = "I want to see the look on someone's face when they find it in their bathtub!";
							int num30 = num1;
							num1 = num30 + 1;
							strArrays[num30] = "They hang around the same areas. That means you reel one in for me!";
							flag = true;
							str1 = "\n(Caught in Sky Lakes & Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2460:
					{
						if (!gotFish)
						{
							int num31 = num1;
							num1 = num31 + 1;
							strArrays[num31] = "I don't know what's worse, a bone fish or a bone fish with HANDS. This Fish-o-Tron deep in the caverns really freaks me out!";
							int num32 = num1;
							num1 = num32 + 1;
							strArrays[num32] = "I think it's possessed by the same evil spirits that possessed that old man by the dungeon!";
							int num33 = num1;
							num1 = num33 + 1;
							strArrays[num33] = "I double duck dare you to go catch it!";
							flag = true;
							str1 = "\n(Caught in Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2461:
					{
						if (!gotFish)
						{
							int num34 = num1;
							num1 = num34 + 1;
							strArrays[num34] = "I was trying to sleep by the hill lakeside when this fish swooped down at me. It was flying!";
							int num35 = num1;
							num1 = num35 + 1;
							strArrays[num35] = "It also had the face of a lady and had feathers! I think I screamed louder than she did!";
							int num36 = num1;
							num1 = num36 + 1;
							strArrays[num36] = "Hey you, go make her pay for scaring me like that!";
							flag = true;
							str1 = "\n(Caught in Sky Lakes & Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2462:
					{
						if (!gotFish)
						{
							int num37 = num1;
							num1 = num37 + 1;
							strArrays[num37] = "There's a piece of the Hunger that morphed from the Wall of Flesh into a small fish-like thing that swims around aimlessly in the underworld and it's gross and it's yucky and I want it now!";
							flag = true;
							str1 = "\n(Caught in Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2463:
					{
						if (!gotFish)
						{
							int num38 = num1;
							num1 = num38 + 1;
							strArrays[num38] = "Did you know deep in the crimson, some of those creatures make this gross yellow stuff?";
							int num39 = num1;
							num1 = num39 + 1;
							strArrays[num39] = "I overheard a crazy story about a pool of it having melted together into a shape of a fish and it swims around and everything!";
							int num40 = num1;
							num1 = num40 + 1;
							strArrays[num40] = "Fetch it for me, so I can stick it in someone's toilet!";
							flag = true;
							str1 = "\n(Caught in Crimson)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2464:
					{
						if (!gotFish)
						{
							int num41 = num1;
							num1 = num41 + 1;
							strArrays[num41] = "Oooooohhh, I'm going to be SO rich! Deep in the caverns, there is a fish made out of gemstones!";
							int num42 = num1;
							num1 = num42 + 1;
							strArrays[num42] = "Don't ask me how, I don't know, all I know is that this fish is totally awesome and you're going to catch it for me!";
							flag = true;
							str1 = "\n(Caught in Underground & Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2465:
					{
						if (!gotFish)
						{
							int num43 = num1;
							num1 = num43 + 1;
							strArrays[num43] = "There's some interesting critters to be found in the deeper Hallows, I tell you!";
							int num44 = num1;
							num1 = num44 + 1;
							strArrays[num44] = "They glow this crazy purple color and it messes with my eyes!";
							int num45 = num1;
							num1 = num45 + 1;
							strArrays[num45] = "It's totally wild, so I want you to catch a fish like that for me!";
							flag = true;
							str1 = "\n(Caught in Underground Hallow)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2466:
					{
						if (!gotFish)
						{
							int num46 = num1;
							num1 = num46 + 1;
							strArrays[num46] = "What's white and tan and fluffy and lives in a frozen underground lake? A mutant flinxfin!";
							int num47 = num1;
							num1 = num47 + 1;
							strArrays[num47] = "I wasn't telling a joke, you know, there really is a mutated variety of Flinx that is more adapted to an aquatic lifestyle!";
							int num48 = num1;
							num1 = num48 + 1;
							strArrays[num48] = "I want it to adapt to my fishbowl, so make sure that happens!";
							flag = true;
							str1 = "\n(Caught in Underground Tundra)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2467:
					{
						if (!gotFish)
						{
							int num49 = num1;
							num1 = num49 + 1;
							strArrays[num49] = "It's a whale! It's a dolphin! No, it's a penguin fish! Oh, and look, it's you!";
							int num50 = num1;
							num1 = num50 + 1;
							strArrays[num50] = "You get to bring me one! You do know they only like cold water, right?";
							flag = true;
							str1 = "\n(Caught in Tundra)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2468:
					{
						if (!gotFish)
						{
							int num51 = num1;
							num1 = num51 + 1;
							strArrays[num51] = "There's a really really rare type of pixie that's born with so many wings that it can't actually fly!";
							int num52 = num1;
							num1 = num52 + 1;
							strArrays[num52] = "It swims with the fishes in the lakes surrounded by that blue colored grass.";
							int num53 = num1;
							num1 = num53 + 1;
							strArrays[num53] = "My fish tank needs a lamp, so I want you to catch me that pixie!";
							flag = true;
							str1 = "\n(Caught in Hallow)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2469:
					{
						if (!gotFish)
						{
							int num54 = num1;
							num1 = num54 + 1;
							strArrays[num54] = "I saw a fish that had eight legs! Nope! Not happening!";
							int num55 = num1;
							num1 = num55 + 1;
							strArrays[num55] = "You're fishing it for me, so it's not alive when I hold it!";
							int num56 = num1;
							num1 = num56 + 1;
							strArrays[num56] = "That's the last time I go fishing so deep in the cavern!";
							flag = true;
							str1 = "\n(Caught in Underground & Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2470:
					{
						if (!gotFish)
						{
							int num57 = num1;
							num1 = num57 + 1;
							strArrays[num57] = string.Concat("You ever wonder why the lakes on the surface of the snowy areas of ", Main.worldName, " never ice over? I don't.");
							int num58 = num1;
							num1 = num58 + 1;
							strArrays[num58] = string.Concat("The fish, however, do! A fish made out of ice would make a great offering to the mighty and amazing ", str, "!");
							int num59 = num1;
							num1 = num59 + 1;
							strArrays[num59] = "Go, my loyal subject, and bring me this Tundra Trout with haste!";
							flag = true;
							str1 = "\n(Caught in Surface Tundra)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2471:
					{
						if (!gotFish)
						{
							int num60 = num1;
							num1 = num60 + 1;
							strArrays[num60] = "Unicorns and rainbows are absolutely great! They're everywhere, even in the water.";
							int num61 = num1;
							num1 = num61 + 1;
							strArrays[num61] = "No, really, I actually saw a unicorn fish in the Hallowed lake!";
							int num62 = num1;
							num1 = num62 + 1;
							strArrays[num62] = "Your job is to reel it up and let me have it as a pet!";
							flag = true;
							str1 = "\n(Caught in Hallow)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2472:
					{
						if (!gotFish)
						{
							int num63 = num1;
							num1 = num63 + 1;
							strArrays[num63] = "Those demons in the underworld really like voodoo dolls, but I think there's a doll out there who was blasted with way too much magic!";
							int num64 = num1;
							num1 = num64 + 1;
							strArrays[num64] = "It turned into a fish and it does stuff on its own. I dare you to go down and get me one!";
							int num65 = num1;
							num1 = num65 + 1;
							strArrays[num65] = "I'd watch out for the boiling lava, because it burns you to death and that won't get me my fish!";
							flag = true;
							str1 = "\n(Caught in Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2473:
					{
						if (!gotFish)
						{
							int num66 = num1;
							num1 = num66 + 1;
							strArrays[num66] = "I know something youuuuu don't! Fine, I'll tell you, there's a terrifying creature that flies among the stars! I'm not making this up!";
							int num67 = num1;
							num1 = num67 + 1;
							strArrays[num67] = "It's called a Wyvern! But, but, you knew that already, right? Well what you don't know is that they are born and raised as tadpoles!";
							int num68 = num1;
							num1 = num68 + 1;
							strArrays[num68] = "So, they're actually like.. well, a frog! Hop to it and get me one!";
							flag = true;
							str1 = "\n(Caught in Sky Lakes)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2474:
					{
						if (!gotFish)
						{
							int num69 = num1;
							num1 = num69 + 1;
							strArrays[num69] = "You won't believe it! I caught a fish in the forest at night that was already dead! Then it tried to eat me! I threw it away and ran!";
							int num70 = num1;
							num1 = num70 + 1;
							strArrays[num70] = "Now I want to stick it in someone's dresser to see what happens, so go fish it back up for me will ya?!";
							flag = true;
							str1 = "\n(Caught in Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2475:
					{
						if (!gotFish)
						{
							int num71 = num1;
							num1 = num71 + 1;
							strArrays[num71] = "I found this spectacular place draped in giant glowing mushrooms! Everything was blue! I was picking some of the mushrooms I found next to a glistening blue lake, when one of the mushrooms snapped at me and swam away! I want to give it a taste of its own medicine, and give it a good chompin'! What I mean is, you gotta get it for me!";
							flag = true;
							str1 = "\n(Caught in Glowing Mushroom Fields)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2476:
					{
						if (!gotFish)
						{
							int num72 = num1;
							num1 = num72 + 1;
							strArrays[num72] = "Did you know there's magical islands that float up high in the sky? Bet you didn't! They say angels live in the sky, and I believe those angels have fins and gills and swim around! I believe you must catch one for me!";
							flag = true;
							str1 = "\n(Caught in Sky Lakes)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2477:
					{
						if (!gotFish)
						{
							int num73 = num1;
							num1 = num73 + 1;
							strArrays[num73] = string.Concat("Ow! Don't get near me! I got stung by a Bloody Man-O-War! In case you're not smart enough to know what that is, it's the most menacing jellyfish in all of ", Main.worldName, "! Go to that rotten crimson and catch it if you dare! ");
							flag = true;
							str1 = "\n(Caught in Crimson)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2478:
					{
						if (!gotFish)
						{
							int num74 = num1;
							num1 = num74 + 1;
							strArrays[num74] = string.Concat("Normally I could care less if I see fishbones floating in the water underground, but this one was swimming! What, you thought that only human skeletons still flailed about in ", Main.worldName, "? Get it for me so I can stick it in someone's bed!");
							flag = true;
							str1 = "\n(Caught in Underground & Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2479:
					{
						if (!gotFish)
						{
							int num75 = num1;
							num1 = num75 + 1;
							strArrays[num75] = "Out in the forest, I was fishing right? Well guess what! A bunny hopped up to me! Then another one hopped up, and another... suddenly I'm surrounded by bunnies! One even swam up to me from the water, but it had no legs! I fell outta my chair in surprise and all the bunnies scurried off! I want that bunny fish as a pet, so you better catch it for me! Pronto!";
							flag = true;
							str1 = "\n(Caught in Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2480:
					{
						if (!gotFish)
						{
							int num76 = num1;
							num1 = num76 + 1;
							strArrays[num76] = "Yarr matey! Shiver me timbers! Avast, scallywags! There's a pirate captain who once had a pet fish named Cap'n Tunabeard, but during a big storm the fishbowl fell overboard! It has a hook for a tail, and an eyepatch and everything! You need to fetch me that fish, so I can be as cool as a pirate! Obviously it's out in the ocean somewhere! Duh!";
							flag = true;
							str1 = "\n(Caught in Ocean)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2481:
					{
						if (!gotFish)
						{
							int num77 = num1;
							num1 = num77 + 1;
							strArrays[num77] = "I saw this bright orange and colorful fish by the ocean, and it was looking around frantically as though it was seeking a lost family member! Go catch it for me, so that another one will show up looking frantically for him instead!";
							flag = true;
							str1 = "\n(Caught in Ocean)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2482:
					{
						if (!gotFish)
						{
							int num78 = num1;
							num1 = num78 + 1;
							strArrays[num78] = "I hear in the underworld, that the King of all demons is actually a fish! Just imagine the absolute power I would have if you caught it for me!";
							flag = true;
							str1 = "\n(Caught in Caverns)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2483:
					{
						if (!gotFish)
						{
							int num79 = num1;
							num1 = num79 + 1;
							strArrays[num79] = "Those Derplings in the jungle are the most scary creatures I've ever seen! Good thing is, sometimes they don't have legs! These ones live in the water and are a lot less scary! Catch me one now so I can see what they taste like without being scared half to death!";
							flag = true;
							str1 = "\n(Caught in Jungle Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2484:
					{
						if (!gotFish)
						{
							int num80 = num1;
							num1 = num80 + 1;
							strArrays[num80] = "There's a legend of a mighty being known as the Fishron! It's part pig, part dragon, and part FISH! I hear it hangs around in the frozen subterranean lakes of the coldest part of the world! I'm not going there, so YOU go catch it and makes sure it lands in my hands! I'm so excited!";
							flag = true;
							str1 = "\n(Caught in Underground Tundra)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2485:
					{
						if (!gotFish)
						{
							int num81 = num1;
							num1 = num81 + 1;
							strArrays[num81] = "A really long fish that looks like a sword's sheath swims in the murky waters of the corruption! It looks a lot like ebonstone, so don't let it fool you! That's right, you. You're catching it, not me!";
							flag = true;
							str1 = "\n(Caught in Corruption)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2486:
					{
						if (!gotFish)
						{
							int num82 = num1;
							num1 = num82 + 1;
							strArrays[num82] = "Watch your step when wading through jungle waters! Why? No, not because I care about you being eaten by piranhas. I care because you'll step on one of my favorite kinds of fish, the Mud Fish! I also care a lot that you're going to grab me one as a pet!";
							flag = true;
							str1 = "\n(Caught in Jungle)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2487:
					{
						if (!gotFish)
						{
							int num83 = num1;
							num1 = num83 + 1;
							strArrays[num83] = "In the forest, the slimes are kinda gross. Slimefish are even more so! I don't want to swim with slimes, so yoink one out of the water for me!";
							flag = true;
							str1 = "\n(Caught Anywhere)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
					case 2488:
					{
						if (!gotFish)
						{
							int num84 = num1;
							num1 = num84 + 1;
							strArrays[num84] = "Piranhas and sharks are ugly! Soooo ugly! Did you know there's a fish that looks very pretty and still can eat your face off? I would pay 2 platinum to see that happen, by the way... To the point, though, you catchy for me. Just make sure I have it before you lose your face!";
							flag = true;
							str1 = "\n(Caught Jungle Surface)";
							break;
						}
						else
						{
							strArrays = strArrays1;
							break;
						}
					}
				}
			}
			else
			{
				switch (Main.rand.Next(5))
				{
					case 0:
					{
						strArrays[0] = "I don't have anything for you to do right now.";
						break;
					}
					case 1:
					{
						strArrays[0] = "You have entertained me enough for today, go.";
						break;
					}
					case 2:
					{
						strArrays[0] = string.Concat("You are done, the grand ", str, " dismisses you!");
						break;
					}
					case 3:
					{
						strArrays[0] = "Only one fish a day, please go away!";
						break;
					}
					case 4:
					{
						strArrays[0] = "I haven't even used the last fish you gave me.  I don't need another.";
						break;
					}
				}
			}
			string str2 = strArrays[0];
			for (int i = 1; i < (int)strArrays.Length; i++)
			{
				if (strArrays[i] != null)
				{
					str2 = string.Concat(str2, " ", strArrays[i]);
				}
			}
			if (str1.Length > 0)
			{
				str2 = string.Concat(str2, "\n", str1);
			}
			if (flag)
			{
				Main.npcChatCornerItem = Main.anglerQuestItemNetIDs[Main.anglerQuest];
			}
			return str2;
		}

		public static string deathMsg(int plr = -1, int npc = -1, int proj = -1, int other = -1)
		{
			if (Lang.lang <= 1)
			{
				string str = "";
				int num = Main.rand.Next(26);
				string str1 = "";
				if (num == 0)
				{
					str1 = " was slain";
				}
				else if (num == 1)
				{
					str1 = " was eviscerated";
				}
				else if (num == 2)
				{
					str1 = " was murdered";
				}
				else if (num == 3)
				{
					str1 = "'s face was torn off";
				}
				else if (num == 4)
				{
					str1 = "'s entrails were ripped out";
				}
				else if (num == 5)
				{
					str1 = " was destroyed";
				}
				else if (num == 6)
				{
					str1 = "'s skull was crushed";
				}
				else if (num == 7)
				{
					str1 = " got massacred";
				}
				else if (num == 8)
				{
					str1 = " got impaled";
				}
				else if (num == 9)
				{
					str1 = " was torn in half";
				}
				else if (num == 10)
				{
					str1 = " was decapitated";
				}
				else if (num == 11)
				{
					str1 = " let their arms get torn off";
				}
				else if (num == 12)
				{
					str1 = " watched their innards become outards";
				}
				else if (num == 13)
				{
					str1 = " was brutally dissected";
				}
				else if (num == 14)
				{
					str1 = "'s extremities were detached";
				}
				else if (num == 15)
				{
					str1 = "'s body was mangled";
				}
				else if (num == 16)
				{
					str1 = "'s vital organs were ruptured";
				}
				else if (num == 17)
				{
					str1 = " was turned into a pile of flesh";
				}
				else if (num == 18)
				{
					str1 = string.Concat(" was removed from ", Main.worldName);
				}
				else if (num == 19)
				{
					str1 = " got snapped in half";
				}
				else if (num == 20)
				{
					str1 = " was cut down the middle";
				}
				else if (num == 21)
				{
					str1 = " was chopped up";
				}
				else if (num == 22)
				{
					str1 = "'s plead for death was answered";
				}
				else if (num == 23)
				{
					str1 = "'s meat was ripped off the bone";
				}
				else if (num == 24)
				{
					str1 = "'s flailing about was finally stopped";
				}
				else if (num == 25)
				{
					str1 = " had their head removed";
				}
				if (plr >= 0 && plr < 255)
				{
					if (proj < 0 || !(Main.projectile[proj].name != ""))
					{
						string[] strArrays = new string[] { str1, " by ", Main.player[plr].name, "'s ", Main.player[plr].inventory[Main.player[plr].selectedItem].name, "." };
						str = string.Concat(strArrays);
					}
					else
					{
						string[] strArrays1 = new string[] { str1, " by ", Main.player[plr].name, "'s ", Main.projectile[proj].name, "." };
						str = string.Concat(strArrays1);
					}
				}
				else if (npc >= 0 && Main.npc[npc].displayName != "")
				{
					str = string.Concat(str1, " by ", Main.npc[npc].displayName, ".");
				}
				else if (proj >= 0 && Main.projectile[proj].name != "")
				{
					str = string.Concat(str1, " by ", Main.projectile[proj].name, ".");
				}
				else if (other >= 0)
				{
					if (other == 0)
					{
						str = (Main.rand.Next(2) != 0 ? " didn't bounce." : " fell to their death.");
					}
					else if (other == 1)
					{
						int num1 = Main.rand.Next(4);
						if (num1 == 0)
						{
							str = " forgot to breathe.";
						}
						else if (num1 == 1)
						{
							str = " is sleeping with the fish.";
						}
						else if (num1 == 2)
						{
							str = " drowned.";
						}
						else if (num1 == 3)
						{
							str = " is shark food.";
						}
					}
					else if (other == 2)
					{
						int num2 = Main.rand.Next(4);
						if (num2 == 0)
						{
							str = " got melted.";
						}
						else if (num2 == 1)
						{
							str = " was incinerated.";
						}
						else if (num2 == 2)
						{
							str = " tried to swim in lava.";
						}
						else if (num2 == 3)
						{
							str = " likes to play in magma.";
						}
					}
					else if (other == 3)
					{
						str = string.Concat(str1, ".");
					}
					else if (other == 4)
					{
						str = " was slain.";
					}
					else if (other == 5)
					{
						int num3 = Main.rand.Next(4);
						if (num3 == 0)
						{
							str = " shattered into pieces";
						}
						else if (num3 == 1)
						{
							str = " cant be put back together again.";
						}
						else if (num3 == 2)
						{
							str = " needs to be swept up.";
						}
						else if (num3 == 3)
						{
							str = " just became another dirt pile.";
						}
					}
				}
				return str;
			}
			if (Lang.lang == 2)
			{
				string str2 = "";
				int num4 = Main.rand.Next(15);
				string str3 = "";
				if (num4 == 0)
				{
					str3 = " wurde durch";
				}
				else if (num4 == 1)
				{
					str3 = " wurde vernichtet";
				}
				else if (num4 == 2)
				{
					str3 = " wurde ermordet";
				}
				else if (num4 == 3)
				{
					str3 = " wurde zerstoert";
				}
				else if (num4 == 4)
				{
					str3 = " wurde massakriert";
				}
				else if (num4 == 5)
				{
					str3 = " wurde aufgespiesst";
				}
				else if (num4 == 6)
				{
					str3 = " wurde in zwei Haelften gerissen";
				}
				else if (num4 == 7)
				{
					str3 = " wurde gekoepft";
				}
				else if (num4 == 8)
				{
					str3 = " liess sich die Arme wegreissen";
				}
				else if (num4 == 9)
				{
					str3 = " sah die eigenen Innereien herausquellen";
				}
				else if (num4 == 10)
				{
					str3 = " wurde brutal seziert";
				}
				else if (num4 == 11)
				{
					str3 = " wurde in Hackfleisch verwandelt";
				}
				else if (num4 != 12)
				{
					str3 = (num4 != 13 ? " liess sich den Kopf wegreissen" : " wurde um die Haelfte gekuerzt");
				}
				else
				{
					str3 = " wurde laengs gefaltet";
				}
				if (plr >= 0 && plr < 255 || npc >= 0 && Main.npc[npc].displayName != "" || proj >= 0 && Main.projectile[proj].name != "")
				{
					str2 = string.Concat(str3, ".");
				}
				else if (other >= 0)
				{
					if (other == 0)
					{
						str2 = (Main.rand.Next(2) != 0 ? " ist nicht gesprungen." : " stuerzte in den Tod.");
					}
					else if (other == 1)
					{
						int num5 = Main.rand.Next(4);
						if (num5 == 0)
						{
							str2 = " hat vergessen zu atmen.";
						}
						else if (num5 == 1)
						{
							str2 = " hat jetzt ein feuchtes Grab bei den Fischen.";
						}
						else if (num5 == 2)
						{
							str2 = " ist ertrunken.";
						}
						else if (num5 == 3)
						{
							str2 = " ist jetzt Fischfutter.";
						}
					}
					else if (other == 2)
					{
						int num6 = Main.rand.Next(4);
						if (num6 == 0)
						{
							str2 = " ist geschmolzen.";
						}
						else if (num6 == 1)
						{
							str2 = " wurde eingeaeschert.";
						}
						else if (num6 == 2)
						{
							str2 = " versuchte, in Lava zu baden.";
						}
						else if (num6 == 3)
						{
							str2 = " spielt gern mit Magma.";
						}
					}
					else if (other == 3)
					{
						str2 = string.Concat(str3, ".");
					}
				}
				return str2;
			}
			if (Lang.lang == 3)
			{
				string str4 = "";
				int num7 = Main.rand.Next(13);
				string str5 = "";
				if (num7 == 0)
				{
					str5 = " è stato ucciso";
				}
				else if (num7 == 1)
				{
					str5 = " è stato sventrato";
				}
				else if (num7 == 2)
				{
					str5 = " è stato assassinato";
				}
				else if (num7 == 3)
				{
					str5 = " è stato distrutto";
				}
				else if (num7 == 4)
				{
					str5 = " è stato massacrato";
				}
				else if (num7 == 5)
				{
					str5 = " è stato trafitto";
				}
				else if (num7 == 6)
				{
					str5 = " è stato diviso in due";
				}
				else if (num7 == 7)
				{
					str5 = " è stato decapitato";
				}
				else if (num7 == 8)
				{
					str5 = " ha visto uscire le sue interiora ";
				}
				else if (num7 == 9)
				{
					str5 = " è stato brutalmente sezionato";
				}
				else if (num7 != 10)
				{
					str5 = (num7 != 11 ? " è stato tagliato a metà" : " è stato spezzato a metà");
				}
				else
				{
					str5 = " è diventato un mucchio di carne";
				}
				if (plr >= 0 && plr < 255 || npc >= 0 && Main.npc[npc].displayName != "" || proj >= 0 && Main.projectile[proj].name != "")
				{
					str4 = string.Concat(str5, ".");
				}
				else if (other >= 0)
				{
					if (other == 0)
					{
						str4 = (Main.rand.Next(2) != 0 ? " non poteva rimbalzare." : " sente la sua morte.");
					}
					else if (other == 1)
					{
						int num8 = Main.rand.Next(4);
						if (num8 == 0)
						{
							str4 = " ha dimenticato di respirare.";
						}
						else if (num8 == 1)
						{
							str4 = " sta dormendo con i pesci.";
						}
						else if (num8 == 2)
						{
							str4 = " è affogato.";
						}
						else if (num8 == 3)
						{
							str4 = " è un pasto dello squalo.";
						}
					}
					else if (other == 2)
					{
						int num9 = Main.rand.Next(4);
						if (num9 == 0)
						{
							str4 = " si è sciolto.";
						}
						else if (num9 == 1)
						{
							str4 = " si è incenerito.";
						}
						else if (num9 == 2)
						{
							str4 = " ha provato a nuotare nella lava.";
						}
						else if (num9 == 3)
						{
							str4 = " piace giocare nel magma.";
						}
					}
					else if (other == 3)
					{
						str4 = string.Concat(str5, ".");
					}
				}
				return str4;
			}
			if (Lang.lang != 4)
			{
				if (Lang.lang != 5)
				{
					return "";
				}
				string str6 = "";
				string str7 = " fue asesinado";
				if (plr >= 0 && plr < 255 || npc >= 0 && Main.npc[npc].displayName != "" || proj >= 0 && Main.projectile[proj].name != "")
				{
					str6 = string.Concat(str7, ".");
				}
				else if (other >= 0)
				{
					if (other == 0)
					{
						str6 = (Main.rand.Next(2) != 0 ? " no saltó a tiempo." : " le ha llegado la hora.");
					}
					else if (other == 1)
					{
						int num10 = Main.rand.Next(4);
						if (num10 == 0)
						{
							str6 = " se olvidó de respirar.";
						}
						else if (num10 == 1)
						{
							str6 = " duerme con los peces.";
						}
						else if (num10 == 2)
						{
							str6 = " se ha ahogado.";
						}
						else if (num10 == 3)
						{
							str6 = " es pasto de los tiburones.";
						}
					}
					else if (other == 2)
					{
						int num11 = Main.rand.Next(4);
						if (num11 == 0)
						{
							str6 = " se ha calcinado.";
						}
						else if (num11 == 1)
						{
							str6 = " se ha chamuscado.";
						}
						else if (num11 == 2)
						{
							str6 = " ha intentado nadar en lava.";
						}
						else if (num11 == 3)
						{
							str6 = " le gusta jugar con el magma.";
						}
					}
					else if (other == 3)
					{
						str6 = string.Concat(str7, ".");
					}
				}
				return str6;
			}
			string str8 = "";
			int num12 = Main.rand.Next(14);
			string str9 = "";
			if (num12 == 0)
			{
				str9 = " s'est fait éviscérer";
			}
			else if (num12 == 1)
			{
				str9 = " s'est fait assassiner";
			}
			else if (num12 == 2)
			{
				str9 = " s'est fait détruire";
			}
			else if (num12 == 3)
			{
				str9 = " s'est fait massacrer";
			}
			else if (num12 == 4)
			{
				str9 = " s'est fait empaler";
			}
			else if (num12 == 5)
			{
				str9 = " s'est fait couper en deux";
			}
			else if (num12 == 6)
			{
				str9 = " s'est fait arracher la tête";
			}
			else if (num12 == 7)
			{
				str9 = " s'est fait déchiqueter les bras";
			}
			else if (num12 == 8)
			{
				str9 = " a vu ses entrailles tomber à ses pieds";
			}
			else if (num12 == 9)
			{
				str9 = " s'est fait brutalement découper";
			}
			else if (num12 == 10)
			{
				str9 = " a fini en chair à pâtée";
			}
			else if (num12 != 11)
			{
				str9 = (num12 != 12 ? " a perdu la tête" : " s'est fait couper en tranches");
			}
			else
			{
				str9 = " s'est fait couper en deux";
			}
			if (plr >= 0 && plr < 255 || npc >= 0 && Main.npc[npc].displayName != "" || proj >= 0 && Main.projectile[proj].name != "")
			{
				str8 = string.Concat(str9, ".");
			}
			else if (other >= 0)
			{
				if (other == 0)
				{
					str8 = (Main.rand.Next(2) != 0 ? " ne bouge plus." : " a cassé sa pipe.");
				}
				else if (other == 1)
				{
					int num13 = Main.rand.Next(4);
					if (num13 == 0)
					{
						str8 = " a cessé de respirer.";
					}
					else if (num13 == 1)
					{
						str8 = " mange les pissenlits par la racine.";
					}
					else if (num13 == 2)
					{
						str8 = " a coulé à pic.";
					}
					else if (num13 == 3)
					{
						str8 = " nourrit les requins.";
					}
				}
				else if (other == 2)
				{
					int num14 = Main.rand.Next(4);
					if (num14 == 0)
					{
						str8 = " a fondu.";
					}
					else if (num14 == 1)
					{
						str8 = " s'est fait incinérer.";
					}
					else if (num14 == 2)
					{
						str8 = " a tenté de nager dans la lave.";
					}
					else if (num14 == 3)
					{
						str8 = " aime barboter dans le magma.";
					}
				}
				else if (other == 3)
				{
					str8 = string.Concat(str9, ".");
				}
			}
			return str8;
		}

		public static string dialog(int l, bool english = false)
		{
			string str = NPC.firstNPCName(18);
			string str1 = NPC.firstNPCName(17);
			string str2 = NPC.firstNPCName(19);
			string str3 = NPC.firstNPCName(20);
			string str4 = NPC.firstNPCName(38);
			string str5 = NPC.firstNPCName(54);
			string str6 = NPC.firstNPCName(22);
			NPC.firstNPCName(108);
			string str7 = NPC.firstNPCName(107);
			string str8 = NPC.firstNPCName(124);
			string str9 = NPC.firstNPCName(160);
			NPC.firstNPCName(178);
			NPC.firstNPCName(207);
			string str10 = NPC.firstNPCName(208);
			string str11 = NPC.firstNPCName(209);
			NPC.firstNPCName(227);
			NPC.firstNPCName(228);
			string str12 = NPC.firstNPCName(229);
			string str13 = NPC.firstNPCName(353);
			NPC.firstNPCName(368);
			string str14 = NPC.firstNPCName(369);
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
					case 1:
					{
						return "I hope a scrawny kid like you isn't all that is standing between us and Cthulhu's Eye.";
					}
					case 2:
					{
						return "Look at that shoddy armor you're wearing. Better buy some more healing potions.";
					}
					case 3:
					{
						return "I feel like an evil presence is watching me.";
					}
					case 4:
					{
						return "Sword beats paper! Get one today.";
					}
					case 5:
					{
						return "You want apples? You want carrots? You want pineapples? We got torches.";
					}
					case 6:
					{
						return "Lovely morning, wouldn't you say? Was there something you needed?";
					}
					case 7:
					{
						return "Night will be upon us soon, friend. Make your choices while you can.";
					}
					case 8:
					{
						return "You have no idea how much Dirt Blocks sell for overseas.";
					}
					case 9:
					{
						return string.Concat("Ah, they will tell tales of ", Main.player[Main.myPlayer].name, " some day... good ones I'm sure.");
					}
					case 10:
					{
						return "Check out my dirt blocks; they are extra dirty.";
					}
					case 11:
					{
						return "Boy, that sun is hot! I do have some perfectly ventilated armor.";
					}
					case 12:
					{
						return "The sun is high, but my prices are not.";
					}
					case 13:
					{
						string[] strArrays = new string[] { "Oh, great. I can hear ", str8, " and ", str, " arguing from here." };
						return string.Concat(strArrays);
					}
					case 14:
					{
						return "Have you seen Chith...Shith.. Chat... The big eye?";
					}
					case 15:
					{
						return string.Concat("Hey, this house is secure, right? Right? ", Main.player[Main.myPlayer].name, "?");
					}
					case 16:
					{
						return "Not even a blood moon can stop capitalism. Let's do some business.";
					}
					case 17:
					{
						return "Keep your eye on the prize, buy a lense!";
					}
					case 18:
					{
						return "Kosh, kapleck Mog. Oh sorry, that's klingon for 'Buy something or die.'";
					}
					case 19:
					{
						return string.Concat(Main.player[Main.myPlayer].name, " is it? I've heard good things, friend!");
					}
					case 20:
					{
						return "I hear there's a secret treasure... oh never mind.";
					}
					case 21:
					{
						return "Angel Statue you say? I'm sorry, I'm not a junk dealer.";
					}
					case 22:
					{
						return "The last guy who was here left me some junk... er I mean... treasures!";
					}
					case 23:
					{
						return "I wonder if the moon is made of cheese...huh, what? Oh yes, buy something!";
					}
					case 24:
					{
						return "Did you say gold?  I'll take that off of ya.";
					}
					case 25:
					{
						return "You better not get blood on me.";
					}
					case 26:
					{
						return "Hurry up and stop bleeding.";
					}
					case 27:
					{
						return "If you're going to die, do it outside.";
					}
					case 28:
					{
						return "What is that supposed to mean?!";
					}
					case 29:
					{
						return "I don't think I like your tone.";
					}
					case 30:
					{
						return "Why are you even here? If you aren't bleeding, you don't need to be here. Get out.";
					}
					case 31:
					{
						return "WHAT?!";
					}
					case 32:
					{
						return "Have you seen that old man pacing around the dungeon? He looks troubled.";
					}
					case 33:
					{
						return string.Concat("I wish ", str4, " would be more careful.  I'm getting tired of having to sew his limbs back on every day.");
					}
					case 34:
					{
						return string.Concat("Hey, has ", str2, " mentioned needing to go to the doctor for any reason? Just wondering.");
					}
					case 35:
					{
						return string.Concat("I need to have a serious talk with ", str6, ". How many times a week can you come in with severe lava burns?");
					}
					case 36:
					{
						return "I think you look better this way.";
					}
					case 37:
					{
						return "Eww... What happened to your face?";
					}
					case 38:
					{
						return "MY GOODNESS! I'm good, but I'm not THAT good.";
					}
					case 39:
					{
						return "Dear friends we are gathered here today to bid farewell... Oh, you'll be fine.";
					}
					case 40:
					{
						return "You left your arm over there. Let me get that for you...";
					}
					case 41:
					{
						return "Quit being such a baby! I've seen worse.";
					}
					case 42:
					{
						return "That's gonna need stitches!";
					}
					case 43:
					{
						return "Trouble with those bullies again?";
					}
					case 44:
					{
						return "Hold on, I've got some cartoon bandages around here somewhere.";
					}
					case 45:
					{
						return string.Concat("Walk it off, ", Main.player[Main.myPlayer].name, ", you'll be fine. Sheesh.");
					}
					case 46:
					{
						return "Does it hurt when you do that? Don't do that.";
					}
					case 47:
					{
						return "You look half digested. Have you been chasing slimes again?";
					}
					case 48:
					{
						return "Turn your head and cough.";
					}
					case 49:
					{
						return "That's not the biggest I've ever seen... Yes, I've seen bigger wounds for sure.";
					}
					case 50:
					{
						return "Would you like a lollipop?";
					}
					case 51:
					{
						return "Show me where it hurts.";
					}
					case 52:
					{
						return "I'm sorry, but you can't afford me.";
					}
					case 53:
					{
						return "I'm gonna need more gold than that.";
					}
					case 54:
					{
						return "I don't work for free you know.";
					}
					case 55:
					{
						return "I don't give happy endings.";
					}
					case 56:
					{
						return "I can't do anymore for you without plastic surgery.";
					}
					case 57:
					{
						return "Quit wasting my time.";
					}
					case 58:
					{
						return string.Concat("I heard there is a doll that looks very similar to ", str6, " somewhere in the underworld.  I'd like to put a few rounds in it.");
					}
					case 59:
					{
						return string.Concat("Make it quick! I've got a date with ", str, " in an hour.");
					}
					case 60:
					{
						return string.Concat("I want what ", str, " is sellin'. What do you mean, she doesn't sell anything?");
					}
					case 61:
					{
						return string.Concat(str3, " is a looker.  Too bad she's such a prude.");
					}
					case 62:
					{
						return string.Concat("Don't bother with ", str4, ", I've got all you need right here.");
					}
					case 63:
					{
						return string.Concat("What's ", str4, "'s problem? Does he even realize we sell completely different stuff?");
					}
					case 64:
					{
						return string.Concat("Man, it's a good night not to talk to anybody, don't you think, ", Main.player[Main.myPlayer].name, "?");
					}
					case 65:
					{
						return "I love nights like tonight.  There is never a shortage of things to kill!";
					}
					case 66:
					{
						return "I see you're eyeballin' the Minishark.. You really don't want to know how it was made.";
					}
					case 67:
					{
						return "Hey, this ain't a movie, pal. Ammo is extra.";
					}
					case 68:
					{
						return "Keep your hands off my gun, buddy!";
					}
					case 69:
					{
						return "Have you tried using purification powder on the ebonstone of the corruption?";
					}
					case 70:
					{
						return string.Concat("I wish ", str2, " would stop flirting with me. Doesn't he realize I'm 500 years old?");
					}
					case 71:
					{
						return string.Concat("Why does ", str1, " keep trying to sell me an angel statues? Everyone knows that they don't do anything.");
					}
					case 72:
					{
						return "Have you seen the old man walking around the dungeon? He doesn't look well at all...";
					}
					case 73:
					{
						return "I sell what I want! If you don't like it, too bad.";
					}
					case 74:
					{
						return "Why do you have to be so confrontational during a time like this?";
					}
					case 75:
					{
						return "I don't want you to buy my stuff. I want you to want to buy my stuff, ok?";
					}
					case 76:
					{
						return "Dude, is it just me or is there like a million zombies out tonight?";
					}
					case 77:
					{
						return "You must cleanse the world of this corruption.";
					}
					case 78:
					{
						return "Be safe; Terraria needs you!";
					}
					case 79:
					{
						return "The sands of time are flowing. And well, you are not aging very gracefully.";
					}
					case 80:
					{
						return "What's this about me having more 'bark' than bite?";
					}
					case 81:
					{
						return "So two goblins walk into a bar, and one says to the other, 'Want to get a Goblet of beer?!";
					}
					case 82:
					{
						return "I cannot let you enter until you free me of my curse.";
					}
					case 83:
					{
						return "Come back at night if you wish to enter.";
					}
					case 84:
					{
						return "My master cannot be summoned under the light of day.";
					}
					case 85:
					{
						return "You are far too weak to defeat my curse.  Come back when you aren't so worthless.";
					}
					case 86:
					{
						return "You pathetic fool.  You cannot hope to face my master as you are now.";
					}
					case 87:
					{
						return "I hope you have like six friends standing around behind you.";
					}
					case 88:
					{
						return "Please, no, stranger. You'll only get yourself killed.";
					}
					case 89:
					{
						return "You just might be strong enough to free me from my curse...";
					}
					case 90:
					{
						return "Stranger, do you possess the strength to defeat my master?";
					}
					case 91:
					{
						return "Please! Battle my captor and free me! I beg you!";
					}
					case 92:
					{
						return "Defeat my master, and I will grant you passage into the Dungeon.";
					}
					case 93:
					{
						return "Trying to get past that ebonrock, eh?  Why not introduce it to one of these explosives!";
					}
					case 94:
					{
						return "Hey, have you seen a clown around?";
					}
					case 95:
					{
						return "There was a bomb sitting right here, and now I can't seem to find it...";
					}
					case 96:
					{
						return "I've got something for them zombies alright!";
					}
					case 97:
					{
						return string.Concat("Even ", str2, " wants what I'm selling!");
					}
					case 98:
					{
						return "Would you rather have a bullet hole or a grenade hole? That's what I thought.";
					}
					case 99:
					{
						return string.Concat("I'm sure ", str, " will help if you accidentally lose a limb to these.");
					}
					case 100:
					{
						return "Why purify the world when you can just blow it up?";
					}
					case 101:
					{
						return "If you throw this one in the bathtub and close all the windows, it'll clear your sinuses and pop your ears!";
					}
					case 102:
					{
						return "Wanna play Fuse Chicken?";
					}
					case 103:
					{
						return "Hey, could you sign this Griefing Waiver?";
					}
					case 104:
					{
						return "NO SMOKING IN HERE!!";
					}
					case 105:
					{
						return "Explosives are da' bomb these days.  Buy some now!";
					}
					case 106:
					{
						return "It's a good day to die!";
					}
					case 107:
					{
						return "I wonder what happens if I... (BOOM!)... Oh, sorry, did you need that leg?";
					}
					case 108:
					{
						return "Dynamite, my own special cure-all for what ails ya.";
					}
					case 109:
					{
						return "Check out my goods; they have explosive prices!";
					}
					case 110:
					{
						return "I keep having vague memories of tying up a woman and throwing her in a dungeon.";
					}
					case 111:
					{
						return "... we have a problem! Its a blood moon out there!";
					}
					case 112:
					{
						return string.Concat("T'were I younger, I would ask ", str, " out. I used to be quite the lady killer.");
					}
					case 113:
					{
						return "That Red Hat of yours looks familiar...";
					}
					case 114:
					{
						return "Thanks again for freeing me from my curse. Felt like something jumped up and bit me.";
					}
					case 115:
					{
						return "Mama always said I would make a great tailor.";
					}
					case 116:
					{
						return "Life's like a box of clothes; you never know what you are gonna wear!";
					}
					case 117:
					{
						return "Of course embroidery is hard! If it wasn't hard, no one would do it! That's what makes it great.";
					}
					case 118:
					{
						return "I know everything they is to know about the clothierin' business.";
					}
					case 119:
					{
						return "Being cursed was lonely, so I once made a friend out of leather. I named him Wilson.";
					}
					case 120:
					{
						return "Thank you for freeing me, human.  I was tied up and left here by the other goblins.  You could say that we didn't get along very well.";
					}
					case 121:
					{
						return "I can't believe they tied me up and left me here just for pointing out that they weren't going east!";
					}
					case 122:
					{
						return "Now that I'm an outcast, can I throw away the spiked balls? My pockets hurt.";
					}
					case 123:
					{
						return "Looking for a gadgets expert? I'm your goblin!";
					}
					case 124:
					{
						return "Thanks for your help. Now, I have to finish pacing around aimlessly here. I'm sure we'll meet again.";
					}
					case 125:
					{
						return "I thought you'd be taller.";
					}
					case 126:
					{
						return string.Concat("Hey...what's ", str8, " up to? Have you...have you talked to her, by chance?");
					}
					case 127:
					{
						return "Hey, does your hat need a motor? I think I have a motor that would fit exactly in that hat.";
					}
					case 128:
					{
						return "Yo, I heard you like rockets and running boots, so I put some rockets in your running boots.";
					}
					case 129:
					{
						return "Silence is golden. Duct tape is silver.";
					}
					case 130:
					{
						return "YES, gold is stronger than iron. What are they teaching these humans nowadays?";
					}
					case 131:
					{
						return "You know, that mining helmet-flipper combination was a much better idea on paper.";
					}
					case 132:
					{
						return "Goblins are surprisingly easy to anger. In fact, they could start a war over cloth!";
					}
					case 133:
					{
						return "To be honest, most goblins aren't exactly rocket scientists. Well, some are.";
					}
					case 134:
					{
						return "Do you know why we all carry around these spiked balls? Because I don't.";
					}
					case 135:
					{
						return "I just finished my newest creation! This version doesn't explode violently if you breathe on it too hard.";
					}
					case 136:
					{
						return "Goblin thieves aren't very good at their job. They can't even steal from an unlocked chest!";
					}
					case 137:
					{
						return "Thanks for saving me, friend!  This bondage was starting to chafe.";
					}
					case 138:
					{
						return "Ohh, my hero!";
					}
					case 139:
					{
						return "Oh, how heroic! Thank you for saving me, young lady!";
					}
					case 140:
					{
						return "Oh, how heroic! Thank you for saving me, young man!";
					}
					case 141:
					{
						return "Now that we know each other, I can move in with you, right?";
					}
					case 142:
					{
						return string.Concat("Well, hi there, ", str6, "! What can I do for you today?");
					}
					case 143:
					{
						return string.Concat("Well, hi there, ", str4, "! What can I do for you today?");
					}
					case 144:
					{
						return string.Concat("Well, hi there, ", str7, "! What can I do for you today?");
					}
					case 145:
					{
						return string.Concat("Well, hi there, ", str, "! What can I do for you today?");
					}
					case 146:
					{
						return string.Concat("Well, hi there, ", str8, "! What can I do for you today?");
					}
					case 147:
					{
						return string.Concat("Well, hi there, ", str3, "! What can I do for you today?");
					}
					case 148:
					{
						return "Want me to pull a coin from behind your ear? No? Ok.";
					}
					case 149:
					{
						return "Do you want some magic candy? No? Ok.";
					}
					case 150:
					{
						return "I make a rather enchanting hot chocolate if you'd be inter...No? Ok.";
					}
					case 151:
					{
						return "Are you here for a peek at my crystal ball?";
					}
					case 152:
					{
						return "Ever wanted an enchanted ring that turns rocks into slimes? Well neither did I.";
					}
					case 153:
					{
						return "Someone once told me friendship is magic. That's ridiculous. You can't turn people into frogs with friendship.";
					}
					case 154:
					{
						return "I can see your future now... You will buy a lot of items from me!";
					}
					case 155:
					{
						return "I once tried to bring an Angel Statue to life. It didn't do anything.";
					}
					case 156:
					{
						return "Thanks!  It was just a matter of time before I ended up like the rest of the skeletons down here.";
					}
					case 157:
					{
						return "Hey, watch where you're going! I was over there a little while ago!";
					}
					case 158:
					{
						return "Hold on, I've almost got wifi going down here.";
					}
					case 159:
					{
						return "But I was almost done putting blinking lights up here!";
					}
					case 160:
					{
						return "DON'T MOVE. I DROPPED MY CONTACT.";
					}
					case 161:
					{
						return "All I want is for the switch to make the... What?!";
					}
					case 162:
					{
						return "Oh, let me guess. Didn't buy enough wire. Idiot.";
					}
					case 163:
					{
						return "Just-could you just... Please? Ok? Ok. Ugh.";
					}
					case 164:
					{
						return "I don't appreciate the way you're looking at me. I am WORKING right now.";
					}
					case 165:
					{
						string[] strArrays1 = new string[] { "Hey, ", Main.player[Main.myPlayer].name, ", did you just come from ", str7, "'s? Did he say anything about me by chance?" };
						return string.Concat(strArrays1);
					}
					case 166:
					{
						return string.Concat(str2, " keeps talking about pressing my pressure plate. I told him it was for stepping on.");
					}
					case 167:
					{
						return "Always buy more wire than you need!";
					}
					case 168:
					{
						return "Did you make sure your device was plugged in?";
					}
					case 169:
					{
						return "Oh, you know what this house needs? More blinking lights.";
					}
					case 170:
					{
						return "You can tell a Blood Moon is out when the sky turns red. There is something about it that causes monsters to swarm.";
					}
					case 171:
					{
						return "Hey, buddy, do you know where any deathweed is? Oh, no reason; just wondering, is all.";
					}
					case 172:
					{
						return "If you were to look up, you'd see that the moon is red right now.";
					}
					case 173:
					{
						return "You should stay indoors at night. It is very dangerous to be wandering around in the dark.";
					}
					case 174:
					{
						return string.Concat("Greetings, ", Main.player[Main.myPlayer].name, ". Is there something I can help you with?");
					}
					case 175:
					{
						return "I am here to give you advice on what to do next.  It is recommended that you talk with me anytime you get stuck.";
					}
					case 176:
					{
						return "They say there is a person who will tell you how to survive in this land... oh wait. That's me.";
					}
					case 177:
					{
						return "You can use your pickaxe to dig through dirt, and your axe to chop down trees. Just place your cursor over the tile and click!";
					}
					case 178:
					{
						return "If you want to survive, you will need to create weapons and shelter. Start by chopping down trees and gathering wood.";
					}
					case 179:
					{
						return string.Concat("Press ", Main.cInv, " to access your crafting menu. When you have enough wood, create a workbench. This will allow you to create more complicated things, as long as you are standing close to it.");
					}
					case 180:
					{
						return "You can build a shelter by placing wood or other blocks in the world. Don't forget to create and place walls.";
					}
					case 181:
					{
						return "Once you have a wooden sword, you might try to gather some gel from the slimes. Combine wood and gel to make a torch!";
					}
					case 182:
					{
						return "To interact with backgrounds, use a hammer!";
					}
					case 183:
					{
						return "You should do some mining to find metal ore. You can craft very useful things with it.";
					}
					case 184:
					{
						return "Now that you have some ore, you will need to turn it into a bar in order to make items with it. This requires a furnace!";
					}
					case 185:
					{
						return "You can create a furnace out of torches, wood, and stone. Make sure you are standing near a work bench.";
					}
					case 186:
					{
						return "You will need an anvil to make most things out of metal bars.";
					}
					case 187:
					{
						return "Anvils can be crafted out of iron, or purchased from a merchant.";
					}
					case 188:
					{
						return "Underground are crystal hearts which can be used to increase your max life. You can smash them with a pickaxe.";
					}
					case 189:
					{
						return "If you gather 5 fallen stars, they can be combined to create an item that will increase your magic capacity.";
					}
					case 190:
					{
						return "Stars fall all over the world at night. They can be used for all sorts of usefull things. If you see one, be sure to grab it because they disappear after sunrise.";
					}
					case 191:
					{
						return "There are many different ways you can attract people to move in to our town. They will of course need a home to live in.";
					}
					case 192:
					{
						return "In order for a room to be considered a home, it needs to have a door, a chair, a table, and a light source.  Make sure the house has walls as well.";
					}
					case 193:
					{
						return "Two people will not live in the same home. Also, if their home is destroyed, they will look for a new place to live.";
					}
					case 194:
					{
						return "You can use the housing interface to assign and view housing. Open your inventory and click the house icon.";
					}
					case 195:
					{
						return "If you want a merchant to move in, you will need to gather plenty of money. 50 silver coins should do the trick!";
					}
					case 196:
					{
						return "For a nurse to move in, you might want to increase your maximum life.";
					}
					case 197:
					{
						return "If you had a gun, I bet an arms dealer might show up to sell you some ammo!";
					}
					case 198:
					{
						return "You should prove yourself by defeating a strong monster. That will get the attention of a dryad.";
					}
					case 199:
					{
						return "Make sure to explore the dungeon thoroughly. There may be prisoners held deep within.";
					}
					case 200:
					{
						return "Perhaps the old man by the dungeon would like to join us now that his curse has been lifted.";
					}
					case 201:
					{
						return "Hang on to any bombs you might find. A demolitionist may want to have a look at them.";
					}
					case 202:
					{
						return "Are goblins really so different from us that we couldn't live together peacefully?";
					}
					case 203:
					{
						return "I heard there was a powerful wizard who lives in these parts.  Make sure to keep an eye out for him next time you go underground.";
					}
					case 204:
					{
						return "If you combine lenses at a demon altar, you might be able to find a way to summon a powerful monster. You will want to wait until night before using it, though.";
					}
					case 205:
					{
						return "You can create worm bait with rotten chunks and vile powder. Make sure you are in a corrupt area before using it.";
					}
					case 206:
					{
						return "Demonic altars can usually be found in the corruption. You will need to be near them to craft some items.";
					}
					case 207:
					{
						return "You can make a grappling hook from a hook and 3 chains. Skeletons found deep underground usually carry hooks, and chains can be made from iron bars.";
					}
					case 208:
					{
						return "If you see a pot, be sure to smash it open. They contain all sorts of useful supplies.";
					}
					case 209:
					{
						return "There is treasure hidden all over the world. Some amazing things can be found deep underground!";
					}
					case 210:
					{
						return "Smashing a shadow orb will sometimes cause a meteor to fall out of the sky. Shadow orbs can usually be found in the chasms around corrupt areas.";
					}
					case 211:
					{
						return "You should focus on gathering more life crystals to increase your maximum life.";
					}
					case 212:
					{
						return "Your current equipment simply won't do. You need to make better armor.";
					}
					case 213:
					{
						return "I think you are ready for your first major battle. Gather some lenses from the eyeballs at night and take them to a demon altar.";
					}
					case 214:
					{
						return "You will want to increase your life before facing your next challenge. Fifteen hearts should be enough.";
					}
					case 215:
					{
						return "The ebonstone in the corruption can be purified using some powder from a dryad, or it can be destroyed with explosives.";
					}
					case 216:
					{
						return "Your next step should be to explore the corrupt chasms.  Find and destroy any shadow orb you find.";
					}
					case 217:
					{
						return "There is a old dungeon not far from here. Now would be a good time to go check it out.";
					}
					case 218:
					{
						return "You should make an attempt to max out your available life. Try to gather twenty hearts.";
					}
					case 219:
					{
						return "There are many treasures to be discovered in the jungle, if you are willing to dig deep enough.";
					}
					case 220:
					{
						return "The underworld is made of a material called hellstone. It's perfect for making weapons and armor.";
					}
					case 221:
					{
						return "When you are ready to challenge the keeper of the underworld, you will have to make a living sacrifice. Everything you need for it can be found in the underworld.";
					}
					case 222:
					{
						return "Make sure to smash any demon altar you can find. Something good is bound to happen if you do!";
					}
					case 223:
					{
						return "Souls can sometimes be gathered from fallen creatures in places of extreme light or dark.";
					}
					case 224:
					{
						return "Ho ho ho, and a bottle of... Egg Nog!";
					}
					case 225:
					{
						return "Care to bake me some cookies?";
					}
					case 226:
					{
						return "What? You thought I wasn't real?";
					}
					case 227:
					{
						return "I managed to sew your face back on. Be more careful next time.";
					}
					case 228:
					{
						return "That's probably going to leave a scar.";
					}
					case 229:
					{
						return "All better. I don't want to see you jumping off anymore cliffs.";
					}
					case 230:
					{
						return "That didn't hurt too bad, now did it?";
					}
					case 231:
					{
						return "As if living underground wasn't bad enough, jerks like you come in while I'm sleeping and steal my children.";
					}
					case 232:
					{
						return string.Concat("Between you and me, ", str3, " is the only one I trust. She is the only one here who hasn't tried to eat me or use me in a potion.");
					}
					case 233:
					{
						return "I tried to lick myself the other day to see what the big deal was, everything started glowing blue.";
					}
					case 234:
					{
						return "Everytime I see the color blue, it makes me depressed and lazy.";
					}
					case 235:
					{
						return "You haven't seen any pigs around here have you? My brother lost his leg to one.";
					}
					case 236:
					{
						return "Everyone in this town feels a bit off. I woke up to the clothier chewing on my foot last night.";
					}
					case 237:
					{
						return string.Concat("I'll give you a discount on your wears if you can convince ", str9, " to come over for a...sizing.");
					}
					case 238:
					{
						return string.Concat("I feel like ", str9, " is a bit misunderstood, he really is a fun guy.");
					}
					case 240:
					{
						return "I don't know the 'Truffle Shuffle,' so stop asking!";
					}
					case 241:
					{
						return "There's been such a huge rumor that's being spread about me, 'If you can't beat him, eat him!'";
					}
					case 242:
					{
						return "Oy, whatchu got in you jiminy fluffer?";
					}
					case 243:
					{
						return "Should I become an air pirate? I've considered becoming an air pirate.";
					}
					case 244:
					{
						return "Be it what it would, a jetpack would suit you nicely!";
					}
					case 245:
					{
						return "I'm feeling a bit peevish as of late, so enough with your palaver you ragamuffin!";
					}
					case 246:
					{
						return string.Concat("I'm mighty curious about that ", str11, " fellow. By what manner of consumption does he maintain such locomotion?");
					}
					case 247:
					{
						return "That captain fellow seems to me to be 'pretty well over the bay' if you know what I mean!";
					}
					case 248:
					{
						return "Show me some gears!";
					}
					case 249:
					{
						return "I like your... gear. Does it come in brass?";
					}
					case 250:
					{
						return "Once you enter hallowed land, you will see a rainbow in the sky. I can help you with painting that if you want.";
					}
					case 251:
					{
						return string.Concat("Check out ", str10, ". Now that's a girl who can paint the town red!");
					}
					case 252:
					{
						return "I know the difference between turquoise and blue-green. But I won't tell you.";
					}
					case 253:
					{
						return "I'm all out of titanium white, so don't even ask.";
					}
					case 254:
					{
						return "Try swirly pink and purple, it works, I swear!";
					}
					case 255:
					{
						return "No, no, no... There's TONS of different grays! Don't get me started...";
					}
					case 256:
					{
						return "I hope it doesn't rain again until this paint dries. That would be a disaster!";
					}
					case 257:
					{
						return "I bring you the richest colors in exchange for your riches!";
					}
					case 258:
					{
						return "My dear, what you're wearing is much too drab. You absolutely must take a lesson in dyeing your tired attire!";
					}
					case 259:
					{
						return "The only kind of wood I would bother dyeing is RICH Mahogany. Dyeing any other wood is such a waste.";
					}
					case 260:
					{
						return string.Concat("You must do something about ", str12, ".  Everytime he comes over here, it takes me a week to get the smell off!");
					}
					case 261:
					{
						return "Which doctor am I? The Witch Doctor am I.";
					}
					case 262:
					{
						return "The heart of magic is nature. The nature of hearts is magic.";
					}
					case 263:
					{
						return string.Concat(str, " may help heal your body, but I can make you embody healing.");
					}
					case 264:
					{
						return string.Concat("Choose wisely, ", Main.player[Main.myPlayer].name, ", my commodities are volatile and my dark arts, mysterious.");
					}
					case 265:
					{
						return "We have to talk. It's... it's about parties.";
					}
					case 266:
					{
						return "I can't decide what I like more: parties, or after-parties.";
					}
					case 267:
					{
						return "We should set up a blinkroot party, and we should also set up an after-party.";
					}
					case 268:
					{
						return string.Concat("Wow, ", Main.player[Main.myPlayer].name, ", meeting an adventurous man like you makes me want to party!");
					}
					case 269:
					{
						return "Put up a disco ball and then I'll show you how to party.";
					}
					case 270:
					{
						return "I went to Sweden once, they party hard, why aren't you like that?";
					}
					case 271:
					{
						return string.Concat("My name's ", str10, " but people call me party pooper. Yeah I don't know, it sounds cool though.");
					}
					case 272:
					{
						return "Do you party? Sometimes? Hm, okay then we can talk...";
					}
					case 273:
					{
						return "I'm no landlubber, but it's better to have lubbed and lost than never to have lubbed at all.";
					}
					case 274:
					{
						return "Yo ho ho and a bottle of....blinkroots!";
					}
					case 275:
					{
						return "YAR!  Funny ye should be mentionin' parrots b'cause...um...What t'were we talkin' 'bout?";
					}
					case 276:
					{
						return string.Concat(Main.player[Main.myPlayer].name, ", Ye be one o' the finest lookin' lassies this here captain's seen in many a fortnight!");
					}
					case 277:
					{
						return "Stay off me booty, ya scallywag!";
					}
					case 278:
					{
						return "What in blazes are ye talkin' about? Moby Dick is mine!";
					}
					case 279:
					{
						return "*Yarr Blarr Harrdarr*";
					}
					case 280:
					{
						return "And then Unit 492-8 said, 'Who do you think I am, Unit 472-6?' HA. HA. HA.";
					}
					case 281:
					{
						return "My expedition efficiency was critically reduced when a projectile impacted my locomotive actuator.";
					}
					case 282:
					{
						return "This sentence is false , or is it?";
					}
					case 283:
					{
						return "So that 'punk' lookin' chick is an inventor, eh? I think I could show her a thing or two!";
					}
					case 284:
					{
						return string.Concat("Sure, me and ", str12, " are pals, but I hate it when his parrot does his business on me. That stuff's corrosive!");
					}
					case 285:
					{
						return "I built myself a taste mechanism, so I can drink some ale!";
					}
					case 286:
					{
						return "Sometimes I come off a bit... Get it? a bit?";
					}
					case 287:
					{
						return "'Short back and sides' is it?";
					}
					case 288:
					{
						return "Those highlights really bring out your eyes!";
					}
					case 289:
					{
						return "My hands are sticky from all that... wax.";
					}
					case 290:
					{
						return "Tea? Coffee? Or is it just orange juice again?";
					}
					case 291:
					{
						return "Doll, we seriously need to fix those split ends.";
					}
					case 292:
					{
						return "Gurrllll! You are my favorite gossip ever.";
					}
					case 293:
					{
						return "Which aftershave can I interest you in today, sir?";
					}
					case 294:
					{
						return "Sit down for a second and I'll have you steppin' razor.";
					}
					case 295:
					{
						return "Either you have style, or you get styled.";
					}
					case 296:
					{
						return "For you I think we'll do something... low maintenance.";
					}
					case 297:
					{
						return "I tried using one of the Dye Master's products once. Ends fried. Disaster.";
					}
					case 298:
					{
						return "Oh you poor, poor thing. Just... just sit down here. It'll be okay. Shhhh.";
					}
					case 299:
					{
						return "Check my fresh.";
					}
					case 300:
					{
						return string.Concat("Hello sir, I'm ", str13, ", and I'll be your barber today.");
					}
					case 301:
					{
						return "Just a little off the top?  That's no fun...";
					}
					case 302:
					{
						return string.Concat("I hope you like what I did to ", str10, "'s hair!");
					}
					case 303:
					{
						return string.Concat("There is nothing I can do for ", str4, "'s singed head. He's a lost cause.");
					}
					case 304:
					{
						return "Tipping IS optional, but remember I have access to scissors and your head.";
					}
					case 305:
					{
						return "This is a cut-throat razer by the way.";
					}
					case 306:
					{
						return "You better stay outta my hair tonight, hun. I just sharpened my scissors, and I'm looking for an excuse to use them!";
					}
					case 307:
					{
						string[] strArrays2 = new string[] { "Mhmm, I heard from ", str10, " that ", str8, "'s friend ", str, " spent her boyfriend's last paycheck on shoes." };
						return string.Concat(strArrays2);
					}
					case 308:
					{
						return string.Concat("One time I put a wig on ", str11, " just so I could cut his hair. I think he kinda liked it!");
					}
					case 309:
					{
						return string.Concat("I tried to visit ", str13, " one time. She just looked at me and said 'nope.'");
					}
					case 310:
					{
						return "I think it is about time I got my hair did!";
					}
					case 311:
					{
						return "Did you even try to brush your hair today?";
					}
					case 312:
					{
						return "So a pixie cut, would you like to keep some lady burns?";
					}
					case 313:
					{
						return "I have no problem cleaning up ears and eyebrows, but I draw the line at nose hair.";
					}
					case 314:
					{
						return "Alright, you sit and marinate. I'll be back to rinse your color out in 25 minutes...";
					}
					case 315:
					{
						return "Thanks hun! Now I can finally do my hair.";
					}
					case 316:
					{
						return "I would have given you a free cut if you'd come earlier.";
					}
					case 317:
					{
						return "Don't go exploring with scissors, they said. You won't get trapped in a spider's web, they said!";
					}
					case 318:
					{
						return "Ew, my hair, there's spider web all over it!";
					}
					case 319:
					{
						return string.Concat("Meet me behind ", str6, "'s house in about three hours, I think I have something you will find very appealing.");
					}
					case 320:
					{
						return string.Concat("That ", str1, ", he really has no appreciation for a really good deal.");
					}
					case 321:
					{
						return string.Concat("I sell only what I can get. ", str5, " keeps hounding me for exotic clothing.");
					}
					case 322:
					{
						return "Hmm, you look like you could use an Angel Statue! They slice, and dice, and make everything nice!";
					}
					case 323:
					{
						return "I don't refund for \"buyer's remorse...\" Or for any other reason, really.";
					}
					case 324:
					{
						return "Buy now and get free shipping!";
					}
					case 325:
					{
						return "I sell wares from places that might not even exist!";
					}
					case 326:
					{
						return "You want two penny farthings!? Make it one and we have a deal.";
					}
					case 327:
					{
						return "Combination hookah and coffee maker! Also makes julienne fries!";
					}
					case 328:
					{
						return "Come and have a look! One pound fish! Very, very good! One pound fish!";
					}
					case 329:
					{
						return "If you're looking for junk, you've come to the wrong place.";
					}
					case 330:
					{
						return "A thrift shop?  No, I am only selling the highest quality items on the market.";
					}
					case 331:
					{
						return "Smashing a crimson heart will sometimes cause a meteor to fall out of the sky. crimson hearts can usually be found in the chasms around crimtane areas.";
					}
					case 332:
					{
						return "Have you tried using purification powder on the crimstone of the crimson?";
					}
					case 333:
					{
						return "You must cleanse the world of this crimson.";
					}
					case 334:
					{
						return "Psst! I might have a job for you. Don't think you can say no, either!";
					}
					case 335:
					{
						return "I want a fish and you're going to find me one! Ask me about it!";
					}
					case 336:
					{
						return "Hey! Just the sacrifi- I mean competent fishing master that I've been looking for! ";
					}
					case 337:
					{
						return string.Concat(str14, " wants YOU as the official ", Main.worldName, " errand monkey!");
					}
					case 338:
					{
						return "Whaaaat?! Can't you see I'm winding up fishing line??";
					}
					case 339:
					{
						return "I have enough fish! I don't need your help right now!";
					}
					case 340:
					{
						return string.Concat("There's no chefs in all of ", Main.worldName, ", so I have to cook all this fish myself! ");
					}
					case 341:
					{
						return "Hey! Watch it! I'm setting up traps for my biggest prank ever! No one will see it coming! Don't you dare tell anyone!";
					}
					case 342:
					{
						return "Let a kid give you some advice, never touch your tongue to an ice block! Wait, forget what I said, I totally want to see you do it!";
					}
					case 343:
					{
						return "Ever heard of a barking fish?! I haven't, I'm just wondering if you did!";
					}
					case 344:
					{
						return string.Concat(Main.worldName, " is filled to the brim with the most outlandish kinds of fish!");
					}
					case 345:
					{
						return "I'm bummed out! There's probably been fish that have gone extinct before I even was born, and that's not fair!";
					}
					case 346:
					{
						return "I don't have a mommy or a daddy, but I have a lot of fish! It's close enough!";
					}
					case 347:
					{
						return string.Concat("Heh heh, you shoulda seen the look on ", str3, "'s face when I stuck that piranha tooth in the chair!");
					}
					case 348:
					{
						return "I have a request for you! No, I don't care that there's a zombie apocalypse right now!";
					}
					case 349:
					{
						return "Hurry up and listen! I need you to catch something for me right now!";
					}
					case 350:
					{
						return "I hate blood moons! I stay up all night because of all the scary noises!";
					}
					case 351:
					{
						return "Blood moon is the worst time to fish! The fish bite, yes, but so do the zombies!";
					}
					case 352:
					{
						return "There's a bajillion monsters running around out there right now!";
					}
					case 353:
					{
						return "Thanks, I guess, for saving me or whatever. You'd be a great helper minion!";
					}
					case 354:
					{
						return "Wha? Who might you be? I totally wasn't just drowning or anything!";
					}
					case 355:
					{
						return "You saved me! You're awful nice, I could use you... er, I mean, totally hire you to do some awesome stuff for me!";
					}
					case 356:
					{
						return "Got any spare bones for sale? I'm looking to replace my broken hip... again.";
					}
					case 357:
					{
						return "Excellent! Someone's finally come by to take some of these maggots off my hands.";
					}
					case 358:
					{
						return "There's no illness or condition that can't be cured by some of my Slime Oil! Trust me, it works, just look at my lively figure!";
					}
					case 359:
					{
						return "You've got a real backbone coming way down here, how 'bout ya buy somethin?";
					}
					case 360:
					{
						return "You would not believe some of the things people throw at me... Wanna buy some of it?";
					}
					case 361:
					{
						return "I'd lend you a hand, but last time I did that, I didn't get it back for a month";
					}
					case 362:
					{
						return "Stay away from the spiders. They'll suck out your insides and leave you a hollow shell of a man. Trust me on this one.";
					}
					case 363:
					{
						return "The only things constant in this world are death and taxes, I've got both!";
					}
					case 364:
					{
						return "You again? Suppose you want more money!?";
					}
					case 365:
					{
						return "Must everyone open and shut doors so incredibly noisily around here?!";
					}
					case 366:
					{
						return "I see you're free of time, as usual. Can't imagine what work life would be for your kind of folk.";
					}
					case 367:
					{
						return "Yes, yes, yes! -- I'll give you your share in just a moment. I'd think you to be a bit more patient, what with me doing all the work and all.";
					}
					case 368:
					{
						return "What does a man have to do to be left alone in this place? Go bugger someone less busy!";
					}
					case 369:
					{
						return "...two barrels of molasses, plus -- Oh, nevermind that, you're here. Here's your money.";
					}
					case 370:
					{
						return "Just between you and me... I have no idea why they're bothering to pay the rent";
					}
					case 371:
					{
						return string.Concat("Tried to get ", str3, " to pay me with favors once, now I have fungus growing in strange places.");
					}
					case 372:
					{
						return string.Concat("Go tell ", str2, " to stop offering to pay me with ammo, I don't even own a gun.");
					}
					case 373:
					{
						return string.Concat("Why don't YOU try collecting money from ", str4, " and not losing a hand or foot or...");
					}
					case 374:
					{
						return string.Concat("I just came from ", str1, "'s. He wanted to know if I took credit cards.");
					}
					case 380:
					{
						return "Here's your cut of the taxes that I've taken from our surplus population!";
					}
					case 381:
					{
						return "Here you are again, taking all my coin! Just grab it and begone from my sight!";
					}
					case 382:
					{
						return "Bah! Here, take your shillings and get out of my sight!";
					}
					case 383:
					{
						return "This is all you're gonna get for now, not a penny more! Take it and spend it wisely.";
					}
					case 390:
					{
						return "...And people call me greedy? No, I have nothing else for you.";
					}
					case 391:
					{
						return "Oh, so you just see me as a coin sign, eh? 'Cus every time you see me, you ask me.";
					}
					case 392:
					{
						return "Don't you ever stop just to say 'Hi?'";
					}
					case 393:
					{
						return "Bah! You again? You just grabbed some of my coin just moments ago, so bugger off and come back later!";
					}
					case 394:
					{
						return "I just gave you half a crown five minutes ago! Scram!";
					}
					case 395:
					{
						return "Reaching into my moneybags again already!? And you call ME greedy.";
					}
					case 396:
					{
						return "You just received your pay, and not a farthing more! Get out!";
					}
					case 397:
					{
						return "Money doesn't grow on trees, so don't overpick my fruit! Bah! ";
					}
					case 398:
					{
						return "You already managed to spend every pence I paid you!? Bah, I'm not a charity, go kill a slime!";
					}
					case 399:
					{
						return "Not so fast! You got your money, now begone! ";
					}
					case 400:
					{
						return "Begging so soon?! Don't look at me like I'll have a change of heart overnight! ";
					}
					case 401:
					{
						return "Make sure to smash any crimson altar you can find. Something good is bound to happen if you do!";
					}
					case 402:
					{
						return "Crimson altars can usually be found in the crimson. You will need to be near them to craft some items.";
					}
					case 403:
					{
						return "You can create a bloody spine with vertebrae. Make sure you are in a crimtane area before using it.";
					}
				}
			}
			else if (Lang.lang == 2)
			{
				switch (l)
				{
					case 1:
					{
						return "Ich hoffe, du duennes Hemd bist nicht das Einzige, was zwischen Chtulus Auge und uns steht.";
					}
					case 2:
					{
						return "Was fuer eine schaebige Ruestung du traegst. Kaufe lieber ein paar Heiltraenke.";
					}
					case 3:
					{
						return "Ich habe das Gefuehl, dass mich eine boese Kraft beobachtet.";
					}
					case 4:
					{
						return "Schwert schlaegt Papier! Hol dir noch heute eins.";
					}
					case 5:
					{
						return "Du moechtest Aepfel? Du willst Karotten? Ananas? Wir haben Fackeln.";
					}
					case 6:
					{
						return "Ein schoener Morgen, nicht wahr? War da noch was, was du brauchst?";
					}
					case 7:
					{
						return "Die Nacht wird bald hereinbrechen. Entscheide dich, solange du kannst.";
					}
					case 8:
					{
						return "Du hast keine Ahnung, wie gut sich Dreckbloecke nach Uebersee verkaufen.";
					}
					case 9:
					{
						return string.Concat("Ach, eines Tages werden sie Geschichten ueber", Main.player[Main.myPlayer].name, " erzaehlen ... sicher gute");
					}
					case 10:
					{
						return "Schau dir mal meine Schmutzbloecke an; die sind wirklich super-dreckig.";
					}
					case 11:
					{
						return "Junge, Junge, wie die Sonne brennt! Ich hab da eine tolle klimatisierte Ruestung.";
					}
					case 12:
					{
						return "Die Sonne steht zwar hoch, meine Preise sind's aber nicht.";
					}
					case 13:
					{
						string[] strArrays3 = new string[] { "Toll. Ich kann ", str8, " und ", str, " von hier aus diskutieren hoeren." };
						return string.Concat(strArrays3);
					}
					case 14:
					{
						return "Hast du Chith ... Shith.. Chat... Das grosse Auge gesehen?";
					}
					case 15:
					{
						return string.Concat("Heh, dieses Haus ist doch wohl sicher? Oder? ", Main.player[Main.myPlayer].name, "?");
					}
					case 16:
					{
						return "Nicht mal ein Blutmond kann den Kapitalismus stoppen. Lass uns also Geschaefte machen.";
					}
					case 17:
					{
						return "Achte auf den Preis, kaufe eine Linse!";
					}
					case 18:
					{
						return "Kosh, kapleck Mog. Oha, sorry. Das ist klingonisch fuer: Kauf oder stirb!";
					}
					case 19:
					{
						return string.Concat(Main.player[Main.myPlayer].name, " ist es? Ich habe nur Gutes ueber dich gehoert!");
					}
					case 20:
					{
						return "Ich hoerte, es gibt einen geheimen Schatz ... oh, vergiss es!";
					}
					case 21:
					{
						return "Engelsstatue, sagst du? Tut mir Leid, ich bin kein Nippesverkaeufer.";
					}
					case 22:
					{
						return "Der letzte Typ, der hier war, hinterliess mir einigen Nippes, aeh, ... Schaetze!";
					}
					case 23:
					{
						return "Ich frage mich, ob der Mond aus Kaese ist ... huch, was? Oh, ja, kauf etwas!";
					}
					case 24:
					{
						return "Hast du Gold gesagt? Ich nehm dir das ab.";
					}
					case 25:
					{
						return "Blute mich bloss nicht voll!";
					}
					case 26:
					{
						return "Mach schon und hoer mit dem Bluten auf!";
					}
					case 27:
					{
						return "Wenn du stirbst, dann bitte draussen.";
					}
					case 28:
					{
						return "Was soll das heissen?!";
					}
					case 29:
					{
						return "Irgendwie gefaellt mir dein Ton nicht.";
					}
					case 30:
					{
						return "Warum bist du ueberhaupt hier? Wenn du nicht blutest, gehoerst du nicht her. Raus jetzt!";
					}
					case 31:
					{
						return "WAS?!";
					}
					case 32:
					{
						return "Hast du den Greis um den Dungeon schreiten sehen? Der scheint Probleme zu haben.";
					}
					case 33:
					{
						return string.Concat("Ich wuenschte, ", str4, " waere vorsichtiger. Es nervt mich, taeglich seine Glieder zusammennaehen zu muessen.");
					}
					case 34:
					{
						return string.Concat("Heh, hat ", str2, " den Grund fuer einen notwendigen Arztbesuch erwaehnt? Ich wundere mich nur.");
					}
					case 35:
					{
						return string.Concat("Ich muss mal ein ernsthaftes Wort mit  ", str6, " reden. Wie oft kann man in einer Woche mit schweren Lava-Verbrennungen hereinkommen?");
					}
					case 36:
					{
						return "Ich finde, du siehst so besser aus.";
					}
					case 37:
					{
						return "Aehhh ... Was ist denn mit deinem Gesicht passiert?";
					}
					case 38:
					{
						return "MEINE GUeTE! Ich bin gut, aber ich bin nicht SO gut.";
					}
					case 39:
					{
						return "Liebe Freunde, wir sind zusammengekommen, um Aufwiedersehen zu sagen ... Ach, es wird schon werden.";
					}
					case 40:
					{
						return "Du hast deinen Arm da drueben gelassen. Lass ihn mich holen ...";
					}
					case 41:
					{
						return "Hoer schon auf, wie ein Baby zu plaerren! Ich habe Schlimmeres gesehen.";
					}
					case 42:
					{
						return "Das geht nicht ohne ein paar Stiche!";
					}
					case 43:
					{
						return "Schon wieder Aerger mit diesen Rabauken?";
					}
					case 44:
					{
						return "Halt aus. Ich hab hier irgendwo ein paar huebsch bedruckte Pflaster.";
					}
					case 45:
					{
						return string.Concat("Hoer schon auf, ", Main.player[Main.myPlayer].name, ", du ueberstehst das schon. Mist.");
					}
					case 46:
					{
						return "Tut es weh, wenn ich das mache? Tu das nicht.";
					}
					case 47:
					{
						return "Du siehst halb verdaut aus. Hast du schon wieder Schleimis gejagt?";
					}
					case 48:
					{
						return "Drehe deinen Kopf und huste!";
					}
					case 49:
					{
						return "Ich habe schon Schlimmeres gesehen ... ja, ganz sicher habe ich schon groessere Wunden gesehen.";
					}
					case 50:
					{
						return "Moechtest du einen Lollipop?";
					}
					case 51:
					{
						return "Zeig mir, wo es schmerzt.";
					}
					case 52:
					{
						return "Tut mir Leid, aber du kannst mich dir gar nicht leisten.";
					}
					case 53:
					{
						return "Dafuer brauche ich mehr Gold.";
					}
					case 54:
					{
						return "Ich arbeite schliesslich nicht umsonst.";
					}
					case 55:
					{
						return "Ich verschenke keine Happy-Ends.";
					}
					case 56:
					{
						return "Ich kann nicht mehr fuer dich tun ohne Schoenheitsoperation.";
					}
					case 57:
					{
						return "Verschwende meine Zeit nicht laenger!";
					}
					case 58:
					{
						return string.Concat("Ich habe gehoert, es gibt eine Puppe in der Unterwelt, die ", str6, " sehr aehnlich sieht. Ich wuerde gern ein bisschen schiessen.");
					}
					case 59:
					{
						return string.Concat("Mach schnell! Ich habe in einer Stunde ein Date mit ", str, ".");
					}
					case 60:
					{
						return string.Concat("Ich moechte das, was ", str, "  verkauft. Was heisst, sie verkauft nichts?");
					}
					case 61:
					{
						return string.Concat(str3, " ist ein Huebscher. Zu dumm, dass sie so pruede ist.");
					}
					case 62:
					{
						return string.Concat("Halte dich nicht mit ", str4, " auf, ich habe alles, was du brauchst hier.");
					}
					case 63:
					{
						return string.Concat("Was ist eigentlich mit ", str4, " los? Kriegt der mal mit, dass wir ganz andere Sachen verkaufen?");
					}
					case 64:
					{
						return string.Concat("Das ist eine gute Nacht, um mit niemandem zu sprechen, denkst du nicht, ", Main.player[Main.myPlayer].name, "?");
					}
					case 65:
					{
						return "Ich liebe Naechte wie diese. Es gibt immer genug zu toeten!";
					}
					case 66:
					{
						return "Wie ich sehe, starrst du den Minihai an ... Du solltest lieber nicht fragen, wie der entstand.";
					}
					case 67:
					{
						return "Moment, das ist kein Film, Freundchen. Munition geht extra.";
					}
					case 68:
					{
						return "Haende weg von meinem Gewehr, Kumpel!";
					}
					case 69:
					{
						return "Hast du versucht, das Reinigungspulver auf dem Ebenstein des Verderbens auszuprobieren?";
					}
					case 70:
					{
						return string.Concat("Ich wuenschte,  ", str2, " wuerde die Flirterei lassen. Versteht er nicht, dass ich 500 Jahre alt bin?");
					}
					case 71:
					{
						return string.Concat("Warum versucht ", str1, " , mir Engelsstatuen zu verkaufen? Jeder weiss, dass sie nutzlos sind.");
					}
					case 72:
					{
						return "Hast du den Greis um den Dungeon herumgehen sehen? Der sieht gar nicht gut aus ...";
					}
					case 73:
					{
						return "Ich verkaufe, was ich will! Dein Pech, wenn du es nicht magst.";
					}
					case 74:
					{
						return "Warum bist du in einer Zeit wie dieser so aggressiv?";
					}
					case 75:
					{
						return "Ich moechte nicht, dass du meine Sachen kaufst, sondern dass du dir wuenschst, sie zu kaufen.";
					}
					case 76:
					{
						return "Kommt es mir nur so vor oder sind heute Nacht eine Million Zombies draussen?";
					}
					case 77:
					{
						return "Du musst die Welt von diesem Verderben befreien.";
					}
					case 78:
					{
						return "Verlass dich darauf, Terraria braucht dich!";
					}
					case 79:
					{
						return "Der Zahn der Zeit nagt und du alterst nicht gerade wuerdevoll.";
					}
					case 80:
					{
						return "Was soll das heissen: Ich belle mehr als ich beisse?";
					}
					case 81:
					{
						return "Zwei Goblins kommen in einen Stoffladen. Sagt der eine zum anderen: Sitzt du gerne auf Gobelin?";
					}
					case 82:
					{
						return "Ich kann dich nicht hineinlassen, bevor du mich von meinem Fluch befreit hast.";
					}
					case 83:
					{
						return "Komm in der Nacht wieder, wenn du hinein willst.";
					}
					case 84:
					{
						return "Mein Meister kann nicht bei Tageslicht herbeigerufen werden.";
					}
					case 85:
					{
						return "Du bist viel zu schwach, um meinen Fluch zu brechen. Komm wieder, wenn du was aus dir gemacht hast.";
					}
					case 86:
					{
						return "Du armseliger Wicht. So kannst du meinem Meister nicht gegenuebertreten.";
					}
					case 87:
					{
						return "Ich hoffe, du hast mindestens sechs Freunde, die hinter dir stehen.";
					}
					case 88:
					{
						return "Bitte nicht, Fremdling. Du bringst dich nur selbst um.";
					}
					case 89:
					{
						return "Du koenntest tatsaechlich stark genug sein, um meinen Fluch aufzuheben ...";
					}
					case 90:
					{
						return "Fremdling, hast du die Kraft, meinen Meister zu besiegen?";
					}
					case 91:
					{
						return "Bitte! Bezwinge meinen Kerkermeister und befreie mich! Ich flehe dich an!";
					}
					case 92:
					{
						return "Besiege meinen Meister und ich gewaehre dir den Zutritt in den Dungeon.";
					}
					case 93:
					{
						return "Du versuchst, den Ebenstein in den Griff zu kriegen? Warum fuehrst du ihn nicht  mit diesen Explosiva zusammen?";
					}
					case 94:
					{
						return "Heh, hast du hier in der Gegend einen Clown gesehen?";
					}
					case 95:
					{
						return "Genau hier war doch eine Bombe und jetzt kann ich sie nicht finden ...";
					}
					case 96:
					{
						return "Ich habe etwas fuer diese Zombies!";
					}
					case 97:
					{
						return string.Concat("Sogar ", str2, " ist scharf auf meine Waren!");
					}
					case 98:
					{
						return "Haettest du lieber das Einschussloch eines Gewehrs oder einer Granate? Das dachte ich mir.";
					}
					case 99:
					{
						return string.Concat("Ich bin sicher, dass ", str, " dir helfen wird, wenn du versehentlich ein Glied verlierst.");
					}
					case 100:
					{
						return "Warum willst du die Welt reinigen, wenn du sie einfach in die Luft jagen kannst?";
					}
					case 101:
					{
						return "Wenn du das hier in die Badewanne schmeisst und alle Fenster schliesst, durchpustet es deine Nasenhoehlen und  dir fliegen die Ohren weg!";
					}
					case 102:
					{
						return "Moechtest du mal Grillhaehnchen spielen?";
					}
					case 103:
					{
						return "Koenntest du hier unterschreiben, dass du nicht jammern wirst?";
					}
					case 104:
					{
						return "RAUCHEN IST HIER NICHT ERLAUBT!!";
					}
					case 105:
					{
						return "Explosiva sind zur Zeit der Knaller. Kaufe dir jetzt welche!";
					}
					case 106:
					{
						return "Ein schoener Tag, um zu sterben!";
					}
					case 107:
					{
						return "Ich frage mich, was passiert, wenn ich ... (BUMM!) ... Oha, sorry, brauchtest du dieses Bein noch?";
					}
					case 108:
					{
						return "Dynamit, mein ganz spezielles Heilmittelchen - fuer alles, was schmerzt.";
					}
					case 109:
					{
						return "Schau dir meine Waren an - mit hochexplosiven Preisen!";
					}
					case 110:
					{
						return "Ich erinnere mich vage an eine Frau, die ich fesselte und in den Dungeon warf.";
					}
					case 111:
					{
						return "... wir haben ein Problem! Es ist Blutmond!";
					}
					case 112:
					{
						return string.Concat("Wenn ich juenger waere, wuerde ich mit ", str, " ausgehen wollen. Ich war mal ein Womanizer.");
					}
					case 113:
					{
						return "Dein roter Hut kommt mir bekannt vor ...";
					}
					case 114:
					{
						return "Danke nochmals, dass du mich vom Fluch befreit hast. Es fuehlte sich an, als wenn mich etwas angesprungen und gebissen hat.";
					}
					case 115:
					{
						return "Mama sagte immer, dass ich einen guten Schneider abgeben wuerde.";
					}
					case 116:
					{
						return "Das Leben ist wie ein Kleiderschrank; du weisst nie, was du tragen wirst!";
					}
					case 117:
					{
						return "Natuerlich ist die Stickerei schwierig! Wenn es nicht schwierig waere, wuerde es niemand machen! Das macht es so grossartig.";
					}
					case 118:
					{
						return "Ich weiss alles, was man ueber das Kleidergeschaeft wissen muss.";
					}
					case 119:
					{
						return "Das Leben mit dem Fluch war einsam, deshalb fertigte ich mir aus Leder einen Freund. Ich nannte ihn Wilson.";
					}
					case 120:
					{
						return "Danke fuer die Befreiung, Mensch. Ich wurde gefesselt und von den anderen Goblins hier zurueckgelassen. Man kann sagen, dass wir nicht besonders gut miteinander auskamen.";
					}
					case 121:
					{
						return "Ich kann nicht glauben, dass sie mich fesselten und hier liessen, nur um anzuzeigen, dass sie nicht nach Osten gehen.";
					}
					case 122:
					{
						return "Nun da ich zu den Verstossenen gehoere, darf ich doch meine Stachelkugeln wegwerfen? Es piekt durch die Taschen.";
					}
					case 123:
					{
						return "Suchst du einen Bastelexperten? Dann bin ich dein Goblin!";
					}
					case 124:
					{
						return "Danke fuer deine Hilfe. Jetzt muss ich erst mal aufhoeren, hier ziellos herumzuschreiten. Wir begegnen uns sicher wieder.";
					}
					case 125:
					{
						return "Ich hielt dich fuer groesser.";
					}
					case 126:
					{
						return string.Concat("Heh ... was macht ", str8, " so? Hast du ... hast du vielleicht mit ihr gesprochen?");
					}
					case 127:
					{
						return "Waer ein Motor fuer deinen Hut nicht schick? Ich glaube, ich habe einen Motor, der genau hineinpasst.";
					}
					case 128:
					{
						return "Ja, ich hab schon gehoert, dass du Raketen und Laufstiefel magst. Deshalb habe ich ein paar Raketen in deine Laufstiefel montiert.";
					}
					case 129:
					{
						return "Schweigen ist Gold. Klebeband ist Silber.";
					}
					case 130:
					{
						return "Ja! Gold ist staerker als Eisen. Was bringt man den Menschen heutzutage eigentlich bei?";
					}
					case 131:
					{
						return "Diese Helm-Flossen-Kombination sah auf dem Papier viel besser aus.";
					}
					case 132:
					{
						return "Goblins kann man erstaunlich leicht auf die Palme bringen. Die wuerden sogar wegen Kleidern einen Krieg anfangen.";
					}
					case 133:
					{
						return "Um die Wahrheit zu sagen, Goblins sind nicht gerade Genies oder Astroforscher. Aber einige schon.";
					}
					case 134:
					{
						return "Weisst du eigentlich, warum wir alle diese Stachelkugeln mit uns herumtragen? Ich weiss es jedenfalls nicht.";
					}
					case 135:
					{
						return "Meine neuste Erfindung ist fertig! Diese Version explodiert nicht, wenn du sie  heftig anhauchst.";
					}
					case 136:
					{
						return "Goblin-Diebe sind nicht besonders gut in ihrem Job. Sie koennen nicht mal aus einer unverschlossenen Truhe klauen.";
					}
					case 137:
					{
						return "Danke fuer die Rettung, mein Freund! Die Fesseln fingen an, zu scheuern.";
					}
					case 138:
					{
						return "Oh, mein Held!";
					}
					case 139:
					{
						return "Oh, wie heroisch! Danke fuer die Rettung, Lady!";
					}
					case 140:
					{
						return "Oh, wie heroisch! Danke fuer die Rettung, mein Herr!";
					}
					case 141:
					{
						return "Nun da wir uns kennen, kann ich doch bei dir einziehen?";
					}
					case 142:
					{
						return string.Concat("Hallo, ", str6, "! Was kann ich heute fuer dich tun?");
					}
					case 143:
					{
						return string.Concat("Hallo, ", str4, "! Was kann ich heute fuer dich tun?");
					}
					case 144:
					{
						return string.Concat("Hallo, ", str7, "! Was kann ich heute fuer dich tun?");
					}
					case 145:
					{
						return string.Concat("Hallo, ", str, "! Was kann ich heute fuer dich tun?");
					}
					case 146:
					{
						return string.Concat("Hallo, ", str8, "! Was kann ich heute fuer dich tun?");
					}
					case 147:
					{
						return string.Concat("Hallo, ", str3, "! Was kann ich heute fuer dich tun?");
					}
					case 148:
					{
						return "Moechtest du, dass ich eine Muenze hinter deinem Ohr hervorziehe? Nein? Gut.";
					}
					case 149:
					{
						return "Moechtest du vielleicht magische Suessigkeiten? Nein? Gut.";
					}
					case 150:
					{
						return "Ich braue eine heisse Zauber-Schokolade, wenn du inter ... Nein? Gut.";
					}
					case 151:
					{
						return "Bist du hier, um einen Blick in meine Kristallkugel zu werfen?";
					}
					case 152:
					{
						return "Hast du dir je einen verzauberten Ring gewuenscht, der Steine in Schleimis verwandelt? Ich auch nicht.";
					}
					case 153:
					{
						return "Jemand sagte mir mal, Freundschaft sei magisch. Das ist laecherlich. Du kannst mit Freundschaft nicht Menschen in Froesche verwandeln.";
					}
					case 154:
					{
						return "Jetzt kann ich deine Zukunft sehen ... Du wirst mir eine Menge Items abkaufen!";
					}
					case 155:
					{
						return "Ich habe mal versucht, eine Engelsstatue zu beleben. Hat ueberhaupt nichts gebracht!";
					}
					case 156:
					{
						return "Danke! Es waere nur eine Frage Zeit gewesen, bis aus mir eines der Skelette hier geworden waere.";
					}
					case 157:
					{
						return "Pass auf, wo du hingehst! Ich war vor einer Weile dort drueben.";
					}
					case 158:
					{
						return "Warte, ich habe es fast geschafft, hier unten Wifi zu installieren.";
					}
					case 159:
					{
						return "Aber ich habe es fast geschafft, hier oben blinkende Lichter anzubringen.";
					}
					case 160:
					{
						return "BEWEGE DICH NICHT. ICH HABE MEINE KONTAKTLINSE VERLOREN.";
					}
					case 161:
					{
						return "Ich moechte nur den Schalter ... Was?!";
					}
					case 162:
					{
						return "Oh, lass mich raten. Nicht genuegend Kabel gekauft, Idiot.";
					}
					case 163:
					{
						return "Koenntest du vielleicht ... bitte? Ja? Gut. Uff!";
					}
					case 164:
					{
						return "Mir gefaellt nicht, wie du mich anschaust. Ich ARBEITE gerade.";
					}
					case 165:
					{
						string[] strArrays4 = new string[] { "Sag, ", Main.player[Main.myPlayer].name, ", kommst du gerade von ", str7, "? Hat er vielleicht etwas ueber mich gesagt?" };
						return string.Concat(strArrays4);
					}
					case 166:
					{
						return string.Concat(str2, " spricht immer davon, auf meine Druckplatten zu druecken. Ich habe ihm gesagt, die ist zum Drauftreten.");
					}
					case 167:
					{
						return "Kaufe immer etwas mehr Kabel als benoetigt!";
					}
					case 168:
					{
						return "Hast du dich vergewissert, dass dein Geraet angeschlossen ist?";
					}
					case 169:
					{
						return "Oh, weisst du was dieses Haus noch braucht? Mehr blinkende Lichter.";
					}
					case 170:
					{
						return "Du erkennst den Blutmond an der Rotfaerbung des Himmels. Irgendetwas daran laesst Monster ausschwaermen.";
					}
					case 171:
					{
						return "Weisst du vielleicht, wo Todeskraut ist? Nein, es hat keinen Grund. Ich frag  mich das bloss.";
					}
					case 172:
					{
						return "Wenn du mal hochschauen wuerdest, wuerdest du bemerken, dass der Mond rot ist.";
					}
					case 173:
					{
						return "Du solltest in der Nacht drinnen bleiben. Es ist sehr gefaehrlich, in der Dunkelheit umherzustreifen.";
					}
					case 174:
					{
						return string.Concat("Sei gegruesst, ", Main.player[Main.myPlayer].name, ". Gibt es etwas, das ich fuer dich tun kann?");
					}
					case 175:
					{
						return "Ich bin hier, um dir zu raten, was du als Naechstes tust. Du solltest immer zu mir kommen, wenn du feststeckst.";
					}
					case 176:
					{
						return "Man sagt, es gibt jemanden, der dir erklaert, wie man in diesem Land ueberlebt ... oh, Moment. Das bin ja ich.";
					}
					case 177:
					{
						return "Du kannst deine Spitzhacke zum Graben im Dreck verwenden und deine Axt zum Holz faellen. Bewege einfach deinen Zeiger ueber das Feld und klicke!";
					}
					case 178:
					{
						return "Wenn du ueberleben willst, musst du Waffen und Zufluchten bauen.  Faelle dazu Baeume und sammele das Holz.";
					}
					case 179:
					{
						return "Druecke ESC zum Aufrufen des Handwerksmenues. Wenn du genuegend Holz hast, stelle eine Werkbank zusammen. Damit kannst du komplexere Sachen herstellen, solange du nahe genug bei ihr   stehst. ";
					}
					case 180:
					{
						return "Du kannst durch Platzieren von Holz oder anderen Bloecken in der Welt eine Zuflucht bauen. Vergiss dabei nicht, auch Waende zu bauen und aufzustellen.";
					}
					case 181:
					{
						return "Wenn du einmal ein Holzschwert hast, kannst du versuchen, etwas Glibber von den Schleimis zu sammeln. Kombiniere Holz und Glibber zur Herstellung einer Fackel.";
					}
					case 182:
					{
						return "Zum Interagieren mit Hintergruenden und platzierten Objekten verwende einen Hammer!";
					}
					case 183:
					{
						return "Du solltest ein bisschen Bergbau betreiben, um Gold zu finden. Du kannst sehr nuetzliche Dinge damit herstellen.";
					}
					case 184:
					{
						return "Jetzt, da du etwas Gold hast, musst du es in einen Barren verwandeln, um damit Items zu erschaffen. Dazu brauchst du einen Hochofen!";
					}
					case 185:
					{
						return "Du kannst einen Hochofen aus Fackeln, Holz und Steinen herstellen. Achte dabei darauf, dass du neben einer Werkbank stehst.";
					}
					case 186:
					{
						return "Zum Herstellen der meisten Sachen aus einem Metallbarren wirst du einen Amboss brauchen.";
					}
					case 187:
					{
						return "Ambosse koennen aus Eisen hergestellt oder von einem Haendler gekauft werden.";
					}
					case 188:
					{
						return "Unterirdisch finden sich Kristallherzen, die verwendet werden koennen, um deine maximale Lebensspanne zu erhoehen. Um sie zu erhalten, benoetigst du einen Hammer.";
					}
					case 189:
					{
						return "Wenn du 10 Sternschnuppen gesammelt hast, koennen sie zur Herstellung eines Items kombiniert werden. Dieses Item erhoeht deine magische Faehigkeit.";
					}
					case 190:
					{
						return "Sterne fallen nachts auf der ganzen Welt herunter. Sie koennen fuer alle moeglichen nuetzlichen Dinge verwendet werden. Wenn du einen erspaeht hast, dann greif ihn dir schnell - sie verschwinden nach Sonnenaufgang.";
					}
					case 191:
					{
						return "Es gibt viele Moeglichkeiten, wie du Menschen dazu bewegen kannst, in unsere Stadt zu ziehen. Sie brauchen zuallererst ein Zuhause.";
					}
					case 192:
					{
						return "Damit ein Raum wie ein Heim wirkt, braucht es eine Tuer, einen Stuhl, einen Tisch und eine Lichtquelle. Achte darauf, dass das Haus auch Waende hat.";
					}
					case 193:
					{
						return "Zwei Menschen werden nicht im selben Haus leben wollen. Ausserdem brauchen sie ein neues Zuhause, wenn ihr Heim zerstoert wurde.";
					}
					case 194:
					{
						return "Du kannst das Behausungsinterface verwenden, um ein Haus zuzuweisen und anzuschauen. Oeffne dein Inventar und klicke auf das Haus-Symbol.";
					}
					case 195:
					{
						return "Wenn du willst, dass ein Haendler einzieht, brauchst du eine Menge Geld. 50 Silbermuenzen sollten aber reichen.";
					}
					case 196:
					{
						return "Damit eine Krankenschwester einzieht, solltest du deine maximale Lebensspanne erhoehen.";
					}
					case 197:
					{
						return "Wenn du ein Gewehr hast, sollte ein Waffenhaendler auftauchen, um dir Munition zu verkaufen.";
					}
					case 198:
					{
						return "Du solltest dich selbst testen, indem du ein starkes Monster besiegst. Das wird die Aufmerksamkeit eines Dryaden erregen.";
					}
					case 199:
					{
						return "Erforsche den Dungeon wirklich sorgfaeltig. Tief unten koennte sich ein Gefangener befinden.";
					}
					case 200:
					{
						return "Vielleicht hat der Greis vom Dungeon Lust, bei uns mitzumachen - jetzt da sein Fluch aufgehoben wurde.";
					}
					case 201:
					{
						return "Behalte alle Bomben, die du findest. Ein Sprengmeister moechte vielleicht einen Blick darauf werfen.";
					}
					case 202:
					{
						return "Sind Goblins wirklich so anders als wir, dass wir nicht in Frieden zusammenleben koennen?";
					}
					case 203:
					{
						return "Ich hoerte, dass ein maechtiger Zauberer in diesen Gebieten lebt. Achte bei deiner naechsten unterirdischen Expedition auf ihn.";
					}
					case 204:
					{
						return "Wenn du Linsen an einem Daemonenaltar kombinieren moechtest, solltest du einen Weg finden koennen, ein maechtiges Monster herbeizurufen. Du solltest jedoch bis zur Nacht warten, bevor du es verwendest.";
					}
					case 205:
					{
						return "Du kannst einen Wurmkoeder mit Verfaultem und Ekelpulver erzeugen. Achte aber darauf, dass du dich vor der Verwendung in einem verderbten Gebiet befindest.";
					}
					case 206:
					{
						return "Daemonenaltaere sind gewoehnlich im Verderben zu finden. Du musst aber nahe bei ihnen stehen, um Items herstellen zu koennen.";
					}
					case 207:
					{
						return "Du kannst einen Enterhaken aus einem Haken und 3 Ketten herstellen.  Die Skelette tief unter der Erde tragen gewoehnlich Haken bei sich. Die Ketten dazu koennen aus Eisenbarren gefertigt werden.";
					}
					case 208:
					{
						return "Wenn du einen Topf siehst, so schlage ihn auf. Toepfe enthalten alle moeglichen Sorten von nuetzlichem Zubehoer.";
					}
					case 209:
					{
						return "Verborgene Schaetze sind auf der ganzen Welt zu finden! Einige erstaunliche Dinge sind auch tief unter der Erde aufzuspueren!";
					}
					case 210:
					{
						return "Beim Zerschlagen einer Schattenkugel faellt mitunter ein Meteor vom Himmel. Schattenkugeln koennen normalerweise in den Schluchten bei verderbten Gebieten gefunden werden.";
					}
					case 211:
					{
						return "Du solltest dich darauf konzentrieren, mehr Kristallherzen zur Erhoehung deiner maximalen Lebensspanne zu sammeln.";
					}
					case 212:
					{
						return "Deine jetzige Ausruestung wird einfach nicht ausreichen. Du musst eine bessere Ruestung fertigen.";
					}
					case 213:
					{
						return "Ich denke, du bist bereit fuer deinen ersten grossen Kampf. Sammele in der Nacht ein paar Linsen von den Augaepfeln und bringe sie zum Daemonenaltar.";
					}
					case 214:
					{
						return "Du solltest dein Leben verlaengern, bevor du die naechste Herausforderung annimmst. 15 Herzen sollten ausreichen.";
					}
					case 215:
					{
						return "Der Ebenstein im Verderben kann durch Verwendung von etwas Pulver des Dryaden gereinigt werden oder er kann durch Explosiva zerstoert werden.";
					}
					case 216:
					{
						return "Dein naechster Schritt ist, die verderbten Schluchten zu untersuchen. Suche nach Schattenkugeln und zerstoere sie!";
					}
					case 217:
					{
						return "Nicht weit von hier gibt es einen alten Dungeon. Jetzt waere ein guter Zeitpunkt, um ihn zu untersuchen.";
					}
					case 218:
					{
						return "Du solltest versuchen, deine Lebensspanne auf das Maximum anzuheben. Versuche, 20 Herzen zu finden.";
					}
					case 219:
					{
						return "Im Dschungel lassen sich viele Schaetze finden, wenn du bereit bist, tief genug zu graben.";
					}
					case 220:
					{
						return "Die Unterwelt entstand aus einem Material, welches sich Hoellenstein nennt. Es ist perfekt geeignet fuer die Produktion von Waffen und Ruestungen.";
					}
					case 221:
					{
						return "Wenn du bereit bist, den Waechter der Unterwelt herauszufordern, musst du ein Opfer bringen. Alles was du brauchst, findest du in der Unterwelt.";
					}
					case 222:
					{
						return "Zerschlage jeden Daemonenaltar, den du findest. Etwas Gutes wird sich ereignen!";
					}
					case 223:
					{
						return "Seelen koennen manchmal von gefallenen Kreaturen an Orten extremen Lichts oder Finsternis aufgesammelt werden.";
					}
					case 224:
					{
						return "Ho ho ho, und eine Flasche ... Egg Nog!";
					}
					case 225:
					{
						return "Pflege zu backen mir ein paar Kekse?";
					}
					case 226:
					{
						return "Was? Sie dachte, ich wäre nicht real?";
					}
					case 227:
					{
						return "Es gelang mir, dein Gesicht wieder annähen. Vorsichtiger sein beim nächsten Mal.";
					}
					case 228:
					{
						return "Das ist wahrscheinlich eine Narbe hinterlassen.";
					}
					case 229:
					{
						return "Alle besser. Ich will nicht, dass du springen mehr Klippen.";
					}
					case 230:
					{
						return "Das tat nicht weh zu schlecht, jetzt hat es getan?";
					}
					case 231:
					{
						return "Als ob im Untergrund leben nicht schon schlimm genug, wie Sie in Zuckungen, während ich schlafe kommen und stehlen meine Kinder.";
					}
					case 232:
					{
						return string.Concat("Zwischen Ihnen und mir, ", str3, " ist der einzige, der ich vertraue. Sie ist die einzige hier, die nicht versucht hat, mich zu essen oder benutzen Sie mich in einem Trank.");
					}
					case 233:
					{
						return "Ich versuchte, mich lecken den anderen Tag zu sehen, was die große Sache war, begann alles leuchtend blaue.";
					}
					case 234:
					{
						return "Jedesmal, wenn ich die Farbe Blau sehen, es macht mich depressiv und faul.";
					}
					case 235:
					{
						return "Sie haben nicht gesehen, alle Schweine hier haben Sie? Mein Bruder verlor sein Bein zu eins.";
					}
					case 236:
					{
						return "Jeder in dieser Stadt fühlt sich ein bisschen aus. Ich wachte auf der Tuchmacher Kauen auf meinen Fuß letzte Nacht.";
					}
					case 237:
					{
						return string.Concat("Ich gebe Ihnen einen Rabatt auf Ihre trägt, wenn Sie ", str9, " überzeugen können, zu kommen für eine ... Sizing.");
					}
					case 238:
					{
						return string.Concat("Ich fühle mich wie ", str9, " ein wenig missverstanden wird, er ist wirklich ein lustiger Kerl.");
					}
					case 240:
					{
						return "Ich weiß nicht, die Truffle Shuffle, so aufhören zu fragen!";
					}
					case 241:
					{
						return "Es ist schon so ein großes Gerücht, das über mich verbreitet ist: 'Wenn du sie nicht schlagen ihn, ihn essen!'";
					}
					case 242:
					{
						return "Oy, was Sie in Ihrem jiminy fluffer haben?";
					}
					case 243:
					{
						return "Sollte ich eine Luft Pirat zu werden? Ich habe als zu einem Luft-Pirat.";
					}
					case 244:
					{
						return "Sei es, wie es wäre, ein Jetpack würden Sie gut zu entsprechen!";
					}
					case 245:
					{
						return "Ich fühle mich ein bisschen ärgerlich wie der spät, so genug mit Ihren Palaver Sie Lump!";
					}
					case 246:
					{
						return string.Concat("Ich bin mächtig neugierig auf dieser ", str11, " Kerl. Durch welche Art und Weise der Verbrauch hat er beibehalten, wie Fortbewegung?");
					}
					case 247:
					{
						return "Dass Kapitän Kerl scheint mir zu sein, 'ziemlich gut über die Bucht', wenn Sie wissen was ich meine!";
					}
					case 248:
					{
						return "Zeigen Sie mir ein paar Gänge!";
					}
					case 249:
					{
						return "Ich mag deine ... Gang. Ist es in Messing kommen?";
					}
					case 250:
					{
						return "Sobald Sie geheiligten Land zu betreten, sehen Sie einen Regenbogen in den Himmel. Ich kann Ihnen mit der Malerei, dass, wenn Sie wollen helfen.";
					}
					case 251:
					{
						return string.Concat("Schauen Sie sich ", str10, ". Nun, das ist ein Mädchen, das die Stadt rot malen kann!");
					}
					case 252:
					{
						return "Ich kenne den Unterschied zwischen türkis und blau-grün. Aber ich werde Ihnen nicht sagen.";
					}
					case 253:
					{
						return "Ich bin ganz aus Titan weiß, also nicht einmal fragen.";
					}
					case 254:
					{
						return "Versuchen swirly rosa und lila, es funktioniert, ich schwöre!";
					}
					case 255:
					{
						return "Nein, nein, nein ... Es gibt Unmengen an verschiedenen Grautönen! Verstehen Sie mich nicht begonnen ...";
					}
					case 256:
					{
						return "Ich hoffe, dass es nicht wieder zu regnen, bis diese Farbe trocknet. Das wäre eine Katastrophe!";
					}
					case 257:
					{
						return "Ich bringe euch die reichsten Farben im Austausch für Ihr Reichtum!";
					}
					case 258:
					{
						return "Mein Lieber, was du trägst ist viel zu eintönig. Sie müssen unbedingt eine Lektion in Färben Sie Ihre müden Kleidung zu nehmen!";
					}
					case 259:
					{
						return "Die einzige Art von Holz I Färben stören würde, ist Mahagoni. Färben andere Holz ist so eine Verschwendung. ";
					}
					case 260:
					{
						return string.Concat("Sie müssen etwas über ", str12, " zu tun.  Jedes Mal, wenn er kommt hierher, dauert es mir eine Woche, um den Geruch zu steigen!");
					}
					case 261:
					{
						return "Welcher Arzt bin ich? Der Witch Doctor ich bin.";
					}
					case 262:
					{
						return "Das Herz der Magie ist die Natur. Die Natur der Herzen ist Magie.";
					}
					case 263:
					{
						return string.Concat(str, " kann helfen, Ihren Körper zu heilen, aber ich kann Sie verkörpern Heilung.");
					}
					case 264:
					{
						return string.Concat("Wählen Sie mit Bedacht, ", Main.player[Main.myPlayer].name, ", meine Rohstoffe sind volatil und meine dunklen Künste, geheimnisvoll.");
					}
					case 265:
					{
						return "Wir müssen reden. Es ist ... es geht um Parteien.";
					}
					case 266:
					{
						return "Ich kann mich nicht entscheiden, was ich mehr mag: Partys oder After-Partys.";
					}
					case 267:
					{
						return "Wir sollten ein blinkroot Partei, und wir sollten auch die Einrichtung eines nach der Party.";
					}
					case 268:
					{
						return string.Concat("Wow, ", Main.player[Main.myPlayer].name, ", Treffen Sie eine abenteuerliche Mann wie Sie macht mich wollen Party!");
					}
					case 269:
					{
						return "Biete eine Disco-Kugel und dann werde ich Ihnen zeigen, wie man feiert.";
					}
					case 270:
					{
						return "Ich ging nach Schweden einmal, sie Partei schwer, warum bist du nicht so?";
					}
					case 271:
					{
						return string.Concat("Mein Name ist ", str10, " aber die Leute nennen mich Partei Popper. Ja, ich weiß es nicht, es klingt aber kühl");
					}
					case 272:
					{
						return "Haben Sie Party? Manchmal? Hm, okay, dann können wir reden ...";
					}
					case 273:
					{
						return "Ich bin kein Liebhaber Land, aber es ist besser, geliebt und verloren haben, als nie, überhaupt zu lieben.";
					}
					case 274:
					{
						return "Yo ho ho und eine Flasche... Blinkroots!";
					}
					case 275:
					{
						return "YAR! Lustige sollten Sie erwähnen, Papageien, weil ... ähm ... Was haben wir hier reden?";
					}
					case 276:
					{
						return string.Concat(Main.player[Main.myPlayer].name, ", Sie können eine der schönsten Blick lassies diese hier Kapitän in vielen vierzehn Tagen gesehen hat sein!");
					}
					case 277:
					{
						return "Bleib weg von mir Beute, scallywag ye!";
					}
					case 278:
					{
						return "Was zum Teufel redest du? Moby Dick ist mein!";
					}
					case 279:
					{
						return "*Yarr Blarr Harrdarr*";
					}
					case 280:
					{
						return "Und dann Einheit 492-8 sagte: Wer glaubst du denkst, ich bin, Referat 472-6? HA. HA. HA.";
					}
					case 281:
					{
						return "Meine Expedition Effizienz kritisch wurde reduziert, wenn ein Projektil beeinflusst meine Lok Antrieb.";
					}
					case 282:
					{
						return "Dieser Satz ist falsch, oder ist es?";
					}
					case 283:
					{
						return "Damit 'punk' suchen Küken ein Erfinder ist, eh? Ich glaube, ich könnte ihr zeigen, eine Sache oder zwei!";
					}
					case 284:
					{
						return string.Concat("Sicher, mir und ", str12, " sind Kumpels, aber ich hasse es, wenn seinem Papagei macht sein Geschäft auf mich. Das Zeug ist ätzend!");
					}
					case 285:
					{
						return "Ich baute mir einen Vorgeschmack Mechanismus, so kann ich einige Bier trinken!";
					}
					case 286:
					{
						return "Manchmal komme ich aus ein bisschen ... Holen Sie sich das? ein bisschen?";
					}
				}
			}
			else if (Lang.lang == 3)
			{
				switch (l)
				{
					case 1:
					{
						return "Spero che tra noi e l'Occhio di Cthulhu non ci sia solo un bimbo scarno come te.";
					}
					case 2:
					{
						return "Guarda la pessima armatura che indossi. Faresti meglio a comprare più pozioni curative.";
					}
					case 3:
					{
						return "Ho la sensazione che una presenza malvagia mi stia guardando.";
					}
					case 4:
					{
						return "Spada batte carta! Prendine una oggi.";
					}
					case 5:
					{
						return "Desideri mele? Carote? Ananas? Abbiamo delle fiaccole.";
					}
					case 6:
					{
						return "Bella mattina, no? C'era qualcosa di cui avevi bisogno?";
					}
					case 7:
					{
						return "Presto si farà notte, amico. Fai le tue scelte finché puoi.";
					}
					case 8:
					{
						return "Non immagini quanti blocchi di terra si vendono oltreoceano.";
					}
					case 9:
					{
						return string.Concat("Ah, racconteranno storie di ", Main.player[Main.myPlayer].name, " un giorno... belle storie ovviamente.");
					}
					case 10:
					{
						return "Guarda i miei blocchi di terra: sono super terrosi.";
					}
					case 11:
					{
						return "Ragazzo, quel sole scotta! Ho un'armatura perfettamente ventilata.";
					}
					case 12:
					{
						return "Il sole è alto, ma i miei prezzi no.";
					}
					case 13:
					{
						string[] strArrays5 = new string[] { "Fantastico. Sento ", str8, " e ", str, " discutere da qui." };
						return string.Concat(strArrays5);
					}
					case 14:
					{
						return "Hai visto Chith... Shith... Chat... Il grande occhio?";
					}
					case 15:
					{
						return string.Concat("Ehi, questa casa è sicura, no? Giusto? ", Main.player[Main.myPlayer].name, "?");
					}
					case 16:
					{
						return "Nemmeno una luna di sangue può arrestare il capitalismo. Facciamo un po' di affari.";
					}
					case 17:
					{
						return "Tieni d'occhio il premio, compra una lente!";
					}
					case 18:
					{
						return "Kosh, kapleck Mog. Oh scusa, in klingon significa 'Compra qualcosa o muori.'";
					}
					case 19:
					{
						return string.Concat("Sei, ", Main.player[Main.myPlayer].name, ", vero? Ho sentito belle cose su di te!");
					}
					case 20:
					{
						return "Sento che c'è un tesoro segreto... non importa.";
					}
					case 21:
					{
						return "Una statua d'angelo, dici? Scusa, non tratto cianfrusaglie.";
					}
					case 22:
					{
						return "L'ultimo ragazzo venuto qui mi lasciò delle cianfrusaglie... o meglio... tesori!";
					}
					case 23:
					{
						return "Mi chiedo se la luna sia fatta di formaggio... Uhm, cosa? Oh sì, compra qualcosa!";
					}
					case 24:
					{
						return "Hai detto oro? Te lo tolgo io.";
					}
					case 25:
					{
						return "Niente sangue su di me.";
					}
					case 26:
					{
						return "Sbrigati e smettila di sanguinare.";
					}
					case 27:
					{
						return "Se stai per morire, fallo fuori.";
					}
					case 28:
					{
						return "Cosa vorresti insinuare?!";
					}
					case 29:
					{
						return "Quel tuo tono non mi piace.";
					}
					case 30:
					{
						return "Che ci fai qui? Se non sanguini, non devi stare qui. Via.";
					}
					case 31:
					{
						return "COSA?!";
					}
					case 32:
					{
						return "Hai visto il vecchio che gira intorno alla segreta? Sembra agitato.";
					}
					case 33:
					{
						return string.Concat("Vorrei che ", str4, " fosse più attento.  Mi sto stancando di dovergli ricucire gli arti ogni giorno.");
					}
					case 34:
					{
						return string.Concat("Ehi, ", str2, " ha detto di dover andare dal dottore per qualche ragione? Solo per chiedere.");
					}
					case 35:
					{
						return string.Concat("Devo parlare seriamente con ", str6, ". Quante volte a settimana si può venire con gravi ustioni da lava?");
					}
					case 36:
					{
						return "Penso che tu stia meglio così.";
					}
					case 37:
					{
						return "Ehm... Che ti è successo alla faccia?";
					}
					case 38:
					{
						return "SANTO CIELO! Sono brava, ma non fino a questo punto.";
					}
					case 39:
					{
						return "Cari amici, siamo qui riuniti, oggi, per congedarci... Oh, ti riprenderai.";
					}
					case 40:
					{
						return "Hai lasciato il braccio laggiù. Te lo prendo io...";
					}
					case 41:
					{
						return "Smettila di fare il bambino! Ho visto di peggio.";
					}
					case 42:
					{
						return "Serviranno dei punti!";
					}
					case 43:
					{
						return "Di nuovo problemi con quei bulli?";
					}
					case 44:
					{
						return "Aspetta, ho i cerotti con i cartoni animati da qualche parte.";
					}
					case 45:
					{
						return string.Concat("Cammina, ", Main.player[Main.myPlayer].name, " starai bene. Fiuu.");
					}
					case 46:
					{
						return "Ti fa male quando lo fai? Non farlo.";
					}
					case 47:
					{
						return "Sembri mezzo digerito. Hai di nuovo inseguito gli slime?";
					}
					case 48:
					{
						return "Gira la testa e tossisci.";
					}
					case 49:
					{
						return "Non è la più grande ferita che abbia mai visto... Ne ho viste certamente di più grandi.";
					}
					case 50:
					{
						return "Vuoi un lecca-lecca?";
					}
					case 51:
					{
						return "Dimmi dove ti fa male.";
					}
					case 52:
					{
						return "Scusa, ma non puoi permetterti di avermi.";
					}
					case 53:
					{
						return "Avrò bisogno di più soldi.";
					}
					case 54:
					{
						return "Sai che non lavoro gratis.";
					}
					case 55:
					{
						return "Non faccio lieti fini.";
					}
					case 56:
					{
						return "Non posso fare più nulla per te senza chirurgia plastica.";
					}
					case 57:
					{
						return "Smettila di sprecare il mio tempo.";
					}
					case 58:
					{
						return string.Concat("Ho sentito che c'è una bambola molto simile a ", str6, " nel sottomondo. Vorrei metterci dei proiettili.");
					}
					case 59:
					{
						return string.Concat("Veloce! Ho un appuntamento con ", str, " tra un'ora.");
					}
					case 60:
					{
						return string.Concat("Voglio quello che vende ", str, ". In che senso, non vende niente?");
					}
					case 61:
					{
						return string.Concat(str3, " è uno spettacolo. Peccato sia così bigotta.");
					}
					case 62:
					{
						return string.Concat("Lascia stare ", str4, ", ho tutto ciò che ti serve qui.");
					}
					case 63:
					{
						return string.Concat("Qual è il problema di ", str4, "? Almeno lo sa che vendiamo oggetti diversi?");
					}
					case 64:
					{
						return string.Concat("Beh, è una bella notte per non parlare con nessuno, non credi, ", Main.player[Main.myPlayer].name, "?");
					}
					case 65:
					{
						return "Mi piacciono le notti come questa. Non mancano mai cose da demolire!";
					}
					case 66:
					{
						return "Vedo che stai addocchiando il Minishark... Meglio che non ti dica di cosa è fatto.";
					}
					case 67:
					{
						return "Ehi, non è un film, amico. Le munizioni sono extra.";
					}
					case 68:
					{
						return "Giù le mani dalla mia pistola, amico!";
					}
					case 69:
					{
						return "Hai provato a usare la polvere purificatrice sulla pietra d'ebano della distruzione?";
					}
					case 70:
					{
						return string.Concat("Vorrei che ", str2, " la smettesse di flirtare con me. Non sa che ho 500 anni?");
					}
					case 71:
					{
						return string.Concat("Perché ", str1, " continua a vendermi statue d'angelo? Lo sanno tutti che non servono a nulla.");
					}
					case 72:
					{
						return "Hai visto il vecchio che gira intorno alla segreta? Non ha per niente un bell'aspetto...";
					}
					case 73:
					{
						return "Vendo ciò che voglio! Se non ti piace, pazienza.";
					}
					case 74:
					{
						return "Perché devi essere così conflittuale in un momento come questo?";
					}
					case 75:
					{
						return "Non voglio che tu compri la mia roba. Voglio che tu desideri comprarla, ok?";
					}
					case 76:
					{
						return "Amico, sbaglio o ci sono tipo un milione di zombi in giro, stanotte?";
					}
					case 77:
					{
						return "Devi purificare il mondo da questa empietà.";
					}
					case 78:
					{
						return "Sii cauto: Terraria ha bisogno di te!";
					}
					case 79:
					{
						return "Il tempo vola e tu, ahimé, non stai invecchiando molto bene.";
					}
					case 80:
					{
						return "Cos'è questa storia di me che abbaio, ma non mordo?";
					}
					case 81:
					{
						return "Due goblin entrano in un bar e uno dice all'altro: 'Vuoi un calice di birra?!' ";
					}
					case 82:
					{
						return "Non posso farti entrare finché non mi libererai dalla maledizione.";
					}
					case 83:
					{
						return "Torna di notte se vuoi entrare.";
					}
					case 84:
					{
						return "Il mio capo non può essere convocato di giorno.";
					}
					case 85:
					{
						return "Sei decisamente troppo debole per sconfiggere la mia maledizione. Torna quando sarai più forte.";
					}
					case 86:
					{
						return "Tu, pazzo patetico. Non puoi sperare di affrontare il mio padrone ora come ora.";
					}
					case 87:
					{
						return "Spero che tu abbia almeno sei amici dietro di te.";
					}
					case 88:
					{
						return "No, ti prego, straniero. Finirai per essere ucciso.";
					}
					case 89:
					{
						return "Potresti essere abbastanza forte da liberarmi dalla mia maledizione...";
					}
					case 90:
					{
						return "Straniero, hai la forza per sconfiggere il mio padrone?";
					}
					case 91:
					{
						return "Ti prego! Sconfiggi chi mi ha catturato e liberami, ti supplico!";
					}
					case 92:
					{
						return "Sconfiggi il mio padrone e ti farò passare nella segreta.";
					}
					case 93:
					{
						return "Stai provando a superare quella pietra d'ebano, eh? Perché non metterci questi esplosivi!";
					}
					case 94:
					{
						return "Ehi, hai visto un clown in giro?";
					}
					case 95:
					{
						return "C'era una bomba qui e ora non riesco a trovarla...";
					}
					case 96:
					{
						return "Ho qualcosa per quegli zombi, altroché!";
					}
					case 97:
					{
						return string.Concat("Persino ", str2, " vuole ciò che sto vendendo!");
					}
					case 98:
					{
						return "Preferisci avere un buco da proiettile o granata? Ecco ciò che pensavo.";
					}
					case 99:
					{
						return string.Concat("Sono sicuro che ", str, " ti aiuterà se per caso perderai un arto.");
					}
					case 100:
					{
						return "Perché purificare il mondo quando potresti farlo saltare in aria?";
					}
					case 101:
					{
						return "Se verserai questo nella vasca da bagno e chiuderai tutte le finestre, ti pulirà le cavità nasali e ti sturerà le orecchie.";
					}
					case 102:
					{
						return "Vuoi giocare a Esplodi-Pollo?";
					}
					case 103:
					{
						return "Ehi, potresti firmare questa rinuncia al dolore?";
					}
					case 104:
					{
						return "VIETATO FUMARE QUI DENTRO!!";
					}
					case 105:
					{
						return "Gli esplosivi vanno a ruba di questi tempi. Comprane un po'!";
					}
					case 106:
					{
						return "È un buon giorno per morire!";
					}
					case 107:
					{
						return "Mi chiedo cosa succederà se io... (BUM!) ... Oh, scusa, ti serviva quella gamba?";
					}
					case 108:
					{
						return "La dinamite, la mia cura speciale per tutto ciò che ti affligge.";
					}
					case 109:
					{
						return "Guarda i miei prodotti: hanno prezzi esplosivi!";
					}
					case 110:
					{
						return "Continuo ad avere vaghi ricordi di aver legato una donna e averla gettata in una segreta.";
					}
					case 111:
					{
						return "... abbiamo un problema! C'è una luna di sangue là fuori!";
					}
					case 112:
					{
						return "Fossi più giovane, chiederei a NURSE di uscire. Avevo un successone con le ragazze.";
					}
					case 113:
					{
						return "Quel tuo cappello rosso mi sembra familiare...";
					}
					case 114:
					{
						return "Grazie ancora per avermi liberato dalla maledizione. Sentivo come qualcosa che saltava e mi mordeva.";
					}
					case 115:
					{
						return "Mia mamma mi diceva sempre che sarei stato un grande sarto.";
					}
					case 116:
					{
						return "La vita è come una scatola di vestiti; non sai mai ciò che indosserai!";
					}
					case 117:
					{
						return "Ricamare è difficile! Se non fosse così, nessuno lo farebbe! È ciò che lo rende fantastico.";
					}
					case 118:
					{
						return "So tutto ciò che c'è da sapere riguardo alle attività di sartoria.";
					}
					case 119:
					{
						return "Nella maledizione ero solo, perciò una volta mi creai un amico di pelle. Lo chiamai Wilson.";
					}
					case 120:
					{
						return "Grazie per avermi liberato, umano. Sono stato legato e lasciato qui da altri goblin. Si potrebbe dire che non andavamo proprio d'accordo.";
					}
					case 121:
					{
						return "Non posso credere che mi hanno legato e lasciato qui soltanto per far notare che non andavano verso est!";
					}
					case 122:
					{
						return "Ora che sono un escluso, posso buttar via le palle chiodate? Mi fanno male le tasche.";
					}
					case 123:
					{
						return "Cerchi un esperto di gadget? Sono il tuo goblin!";
					}
					case 124:
					{
						return "Grazie per l'aiuto. Ora devo smetterla di gironzolare senza scopo qui attorno. Sono sicuro che ci incontreremo di nuovo.";
					}
					case 125:
					{
						return "Pensavo fossi più alto.";
					}
					case 126:
					{
						return string.Concat("Ehi... cosa sta combinando ", str8, "? Hai... hai parlato con lei, per caso?");
					}
					case 127:
					{
						return "Ehi, il tuo cappello ha bisogno di un motore? Credo di averne uno perfettamente adatto.";
					}
					case 128:
					{
						return "Ciao, ho sentito che ti piacciono i razzi e gli stivali da corsa, così ho messo dei missili nei tuoi stivali.";
					}
					case 129:
					{
						return "Il silenzio è d'oro. Il nastro adesivo è d'argento.";
					}
					case 130:
					{
						return "SÌ, l'oro è più forte del ferro. Cosa insegnano al giorno d'oggi a questi umani?";
					}
					case 131:
					{
						return "Sai, quella combinazione casco da minatore-pinne era un'idea molto migliore sulla carta.";
					}
					case 132:
					{
						return "I goblin si irritano molto facilmente. Potrebbero persino scatenare una guerra per i tessuti!";
					}
					case 133:
					{
						return "A dire il vero, la maggior parte dei goblin non sono ingegneri aerospaziali. Beh, alcuni sì.";
					}
					case 134:
					{
						return "Sai perché noi tutti ci portiamo dietro queste palle chiodate? Perché io non lo faccio.";
					}
					case 135:
					{
						return "Ho appena finito la mia ultima creazione! Questa versione non esplode violentemente se ci si respira troppo forte sopra.";
					}
					case 136:
					{
						return "I ladri goblin non sono molto furbi. Non sanno nemmeno rubare da una cassa aperta!";
					}
					case 137:
					{
						return "Grazie per avermi salvato, amico! Questi legacci iniziavano a irritarmi.";
					}
					case 138:
					{
						return "Ohh, mio eroe!";
					}
					case 139:
					{
						return "Oh, eroica! Grazie per avermi salvato, ragazza!";
					}
					case 140:
					{
						return "Oh, eroico!  Grazie per avermi salvato, ragazzo!";
					}
					case 141:
					{
						return "Ora che ci conosciamo, posso trasferirmi da te?";
					}
					case 142:
					{
						return string.Concat("Bene, ciao, ", str6, "! Cosa posso fare per te oggi?");
					}
					case 143:
					{
						return string.Concat("Bene, ciao, ", str4, "! Cosa posso fare per te oggi?");
					}
					case 144:
					{
						return string.Concat("Bene, ciao, ", str7, "! Cosa posso fare per te oggi?");
					}
					case 145:
					{
						return string.Concat("Bene, ciao, ", str, "! Cosa posso fare per te oggi?");
					}
					case 146:
					{
						return string.Concat("Bene, ciao, ", str8, "! Cosa posso fare per te oggi?");
					}
					case 147:
					{
						return string.Concat("Bene, ciao, ", str3, "! Cosa posso fare per te oggi?");
					}
					case 148:
					{
						return "Vuoi che tiri fuori una moneta da dietro il tuo orecchio? No? Ok.";
					}
					case 149:
					{
						return "Vuoi dei dolci magici? No? Ok.";
					}
					case 150:
					{
						return "Posso preparare una cioccalata calda proprio deliziosa se sei inter...No? Ok.";
					}
					case 151:
					{
						return "Sei qui per dare un'ochiata alla mia sfera di cristallo?";
					}
					case 152:
					{
						return "Mai desiderato un anello incantato che trasforma le rocce in slime? Neanch'io.";
					}
					case 153:
					{
						return "Una volta qualcuno mi disse che l'amicizia è magica. Sciocchezze. Non puoi trasformare le persone in rane con l'amicizia.";
					}
					case 154:
					{
						return "Ora vedo il tuo futuro... Comprerai molti prodotti da me!";
					}
					case 155:
					{
						return "Una volta ho provato a dare la vita a una statua d'angelo. Invano.";
					}
					case 156:
					{
						return "Grazie! Era solo questione di tempo prima che facessi la stessa fine degli scheletri laggiù.";
					}
					case 157:
					{
						return "Ehi, guarda dove stai andando! Ero laggiù un attimo fa!";
					}
					case 158:
					{
						return "Resisti, sono quasi riuscita a portare fin qui il wifi.";
					}
					case 159:
					{
						return "Ma ero quasi riuscita a mettere luci intermettenti quassù!";
					}
					case 160:
					{
						return "NON MUOVERTI. MI È CADUTA UNA LENTE A CONTATTO.";
					}
					case 161:
					{
						return "Tutto ciò che voglio è che l'interruttore faccia... Cosa?!";
					}
					case 162:
					{
						return "Oh, fammi indovinare. Non hai comprato abbastanza filo metallico. Idiota.";
					}
					case 163:
					{
						return "Soltanto-potresti soltanto... Per favore? Ok? Ok. Puah.";
					}
					case 164:
					{
						return "Non apprezzo il modo in cui mi guardi. Sto LAVORANDO ora.";
					}
					case 165:
					{
						string[] strArrays6 = new string[] { "Ehi, ", Main.player[Main.myPlayer].name, ", sei appena stato da ", str7, "? Ha detto qualcosa di me, per caso?" };
						return string.Concat(strArrays6);
					}
					case 166:
					{
						return string.Concat(str2, " continua a dire di aver schiacciato la mia piastra a pressione. Gli ho spiegato che serve proprio a quello.");
					}
					case 167:
					{
						return "Compra sempre più filo metallico di quello necessario!";
					}
					case 168:
					{
						return "Ti sei assicurato che il tuo dispositivo fosse collegato?";
					}
					case 169:
					{
						return "Oh, sai di cosa ha bisogno questa casa? Di più luci intermittenti.";
					}
					case 170:
					{
						return "Si può dire che appare una luna di sangue quando il cielo si fa rosso.  C'è qualcosa in lei che ridesta i mostri.";
					}
					case 171:
					{
						return "Ehi, amico, sai dov'è un po' di erba della morte? Scusa, me lo stavo solo chiedendo, tutto qua.";
					}
					case 172:
					{
						return "Se dovessi alzare lo sguardo, vedresti che la luna è rossa ora.";
					}
					case 173:
					{
						return "Dovresti stare dentro di notte. Sai, è molto pericoloso girare al buio.";
					}
					case 174:
					{
						return string.Concat("Saluti, ", Main.player[Main.myPlayer].name, ". Come posso esserti utile?");
					}
					case 175:
					{
						return "Sono qui per darti consigli su cosa fare dopo. Ti consiglio di parlare con me ogni volta che sarai nei guai.";
					}
					case 176:
					{
						return "Si dice ci sia una persona che ti dirà come sopravvivere in questa terra... Aspetta. Sono io.";
					}
					case 177:
					{
						return "Puoi utilizzare il piccone per scavare nell'immondizia e l'ascia per abbattere gli alberi. Posiziona il cursore  sulla mattonella e clicca!";
					}
					case 178:
					{
						return "Se vuoi sopravvivere, dovrai creare armi e un riparo. Inizia abbattendo gli alberi e raccogliendo legna.";
					}
					case 179:
					{
						return "Clicca su ESC per accedere al menu artigianato. Quando avrai abbastanza legna, crea un banco di lavoro. Così potrai creare oggetti più sofisticati, finché sarai vicino ad esso.";
					}
					case 180:
					{
						return "Puoi costruirti un riparo con legna o altri blocchi nel mondo. Non dimenticare di creare e sistemare le pareti.";
					}
					case 181:
					{
						return "Una volta che possiederai una spada di legno, puoi provare a raccogliere gel dagli slime. Metti assieme legna e gel per creare una fiaccola!";
					}
					case 182:
					{
						return "Per interagire con gli ambienti e gli oggetti posizionati, usa un martello!";
					}
					case 183:
					{
						return "Devi praticare un po' di estrazione per trovare minerale metallico. Puoi crearci oggetti molto utili.";
					}
					case 184:
					{
						return "Ora che hai un po' di minerale, dovrai trasformarlo in una sbarra per poterci fare degli oggetti. Per questo serve un forno!";
					}
					case 185:
					{
						return "Puoi creare una forno con fiaccole, legna e pietra. Assicurati di essere vicino a un banco di lavoro.";
					}
					case 186:
					{
						return "Avrai bisogno di un'incudine per creare la maggior parte degli oggetti dalle sbarre metalliche.";
					}
					case 187:
					{
						return "Le incudini possono essere create con del ferro o acquistate da un mercante.";
					}
					case 188:
					{
						return "Sottoterra vi sono cuori di cristallo che possono essere utilizzati per allungare la tua vita massima. Dovrai avere un martello per ottenerli.";
					}
					case 189:
					{
						return "Se raccoglierai 10 stelle cadenti, potrai combinarle per creare un oggetto che aumenterà le tue abilità magiche.";
					}
					case 190:
					{
						return "Le stelle cadono sul mondo di notte. Possono essere utilizzate per ogni tipo di oggetto utile.  Se ne vedi una, cerca di afferrarla, poiché scomparirà dopo l'alba.";
					}
					case 191:
					{
						return "Ci sono diversi modi per convincere le persone a trasferirsi nella tua città. Di sicuro dovranno avere una casa in cui vivere.";
					}
					case 192:
					{
						return "Perché una stanza sia considerata una casa, ha bisogno di una porta, una sedia, un tavolo e una fonte luminosa. Assicurati che la casa abbia anche delle pareti.";
					}
					case 193:
					{
						return "Due persone non possono vivere nella stessa casa. Inoltre, se la loro casa verrà distrutta, cercheranno un nuovo posto in cui vivere.";
					}
					case 194:
					{
						return "Puoi utilizzare l'interfaccia abitazioni per visualizzare e assegnare gli alloggi. Apri l'inventario e clicca sull'icona della casa.";
					}
					case 195:
					{
						return "Se vuoi che un mercante si trasferisca, dovrai raccogliere molto denaro. Servono 50 monete d'argento!";
					}
					case 196:
					{
						return "Se vuoi che un'infermiera si traferisca, dovrai essere intenzionato ad allungare la tua vita massima.";
					}
					case 197:
					{
						return "Se avessi una pistola, scommetto che potrebbe apparire un mercante d'armi per venderti munizioni!";
					}
					case 198:
					{
						return "Dovresti metterti alla prova sconfiggendo un mostro forte. Così attirerai l'attenzione di una driade.";
					}
					case 199:
					{
						return "Esplora attentamente tutta la segreta. Potrebbero esserci prigionieri nelle zone più profonde.";
					}
					case 200:
					{
						return "Forse il vecchio della segreta vorrebbe unirsi a noi, ora che la maledizione è terminata.";
					}
					case 201:
					{
						return "Arraffa tutte le bombe che potresti trovare. Un esperto in demolizioni potrebbe volerci dare un'occhiata.";
					}
					case 202:
					{
						return "I goblin sono così diversi da noi che non possiamo convivere in maniera pacifica?";
					}
					case 203:
					{
						return "Ho sentito che c'era un potente stregone da queste parti. Tienilo d'occhio la prossima volta che scenderai sottoterra.";
					}
					case 204:
					{
						return "Se combinerai le lenti a un altare demoniaco, potresti trovare un modo per chiamare un mostro potente. Ma aspetta che si faccia buio prima di utilizzarlo.";
					}
					case 205:
					{
						return "Puoi creare un'esca di vermi con pezzi marci e polvere disgustosa. Assicurati di essere in una zona distrutta prima di utilizzarla.";
					}
					case 206:
					{
						return "Gli altari demoniaci si trovano generalmente nella distruzione. Dovrai essere vicino ad essi per creare oggetti.";
					}
					case 207:
					{
						return "Puoi creare un rampino con un uncino e tre catene. Gli scheletri sottoterra di solito trasportano gli uncini, mentre le catene possono essere ricavate dalle sbarre di ferro.";
					}
					case 208:
					{
						return "Se vedi un vaso, demoliscilo e aprilo. Contiene una serie di utili provviste.";
					}
					case 209:
					{
						return "Vi sono tesori nascosti in tutto il mondo. Alcuni oggetti fantastici si possono trovare nelle zone sotterranee più profonde.";
					}
					case 210:
					{
						return "Demolire un'orbita d'ombra provocherà a volte la caduta di un meteorite dal cielo. Le orbite d'ombra si possono generalmente trovare negli abissi attorno alle zone distrutte.";
					}
					case 211:
					{
						return "Dovresti cercare di raccogliere più cuori di cristallo per allungare la tua vita massima.";
					}
					case 212:
					{
						return "La tua attrezzatura attuale non è sufficiente. Hai bisogno di un'armatura migliore.";
					}
					case 213:
					{
						return "Credo tu sia pronto per la tua prima grande battaglia. Raccogli lenti dai bulbi oculari di notte e portale a un altare demoniaco.";
					}
					case 214:
					{
						return "Allunga la tua vita prima di affrontare la prossima sfida. Quindici cuori dovrebbero bastare.";
					}
					case 215:
					{
						return "La pietra d'ebano nella distruzione può essere purificata con polvere di driade o distrutta con esplosivi.";
					}
					case 216:
					{
						return "La prossima tappa consiste nell'esplorazione degli abissi distrutti. Trova e distruggi ogni orbita d'ombra che incontrerai.";
					}
					case 217:
					{
						return "C'è una vecchia segreta non lontano da qui. Sarebbe il momento giusto per visitarla.";
					}
					case 218:
					{
						return "Dovresti tentare di massimizzare la vita disponibile. Prova a raccogliere venti cuori.";
					}
					case 219:
					{
						return "Ci sono molti tesori da scroprire nella giungla, se sei disposto a scavare abbastanza in profondità.";
					}
					case 220:
					{
						return "Il sottomondo è composto da un materiale detto pietra infernale, perfetto per creare armi e armatura.";
					}
					case 221:
					{
						return "Quando sarai pronto a sfidare il custode del sottomondo, dovrai fare un enorme sacrificio. Tutto ciò che ti serve si trova nel mondo di sotto.";
					}
					case 222:
					{
						return "Assicurati di demolire ogni altare demoniaco che incontri. Se lo farai, ti succederà qualcosa di bello!";
					}
					case 223:
					{
						return "A volte è possibile riunire le anime delle creature morte in luoghi estremamente luminosi o bui.";
					}
					case 224:
					{
						return "Ho ho ho e una bottiglia di ... Egg Nog!";
					}
					case 225:
					{
						return "Cura di cuocere dei biscotti me?";
					}
					case 226:
					{
						return "Che cosa? Credevi che non era reale?";
					}
					case 227:
					{
						return "Sono riuscito a cucire la tua faccia di nuovo. Essere più attento la prossima volta.";
					}
					case 228:
					{
						return "Che probabilmente lascerà una cicatrice.";
					}
					case 229:
					{
						return "Tutti i migliori. Non voglio vederti saltare fuori più scogliere.";
					}
					case 230:
					{
						return "Che non ha fatto male troppo male, ora lo ha fatto?";
					}
					case 231:
					{
						return "Come se vivere sottoterra non bastasse, cretini come si arriva in mentre dormo e rubato i miei figli.";
					}
					case 232:
					{
						return string.Concat("Tra me e te, ", str3, " è l'unico di cui mi fido. Lei è l'unico qui che non ha cercato di mangiare me o utilizzare in una pozione.");
					}
					case 233:
					{
						return "Ho provato a leccare me l'altro giorno per vedere che cosa il grosso problema era, tutto ha cominciato blu incandescente. ";
					}
					case 234:
					{
						return "Ogni volta che vedo il colore blu, mi rende depresso e pigro.";
					}
					case 235:
					{
						return "Non hai visto tutti i suini da queste parti hanno di te? Mio fratello ha perso la gamba a uno.";
					}
					case 236:
					{
						return "Ognuno in questa città si sente un po 'fuori. Mi sono svegliato al clothier masticare sul mio piede ieri sera.";
					}
					case 237:
					{
						return string.Concat("Ti darò uno sconto sul tuo capo se si può convincere ", str9, " di venire per un ... dimensionamento.");
					}
					case 238:
					{
						return string.Concat("Mi sento come ", str9, " è un po 'incompreso, lui è davvero un tipo divertente.");
					}
					case 240:
					{
						return "Non so il 'Tartufo Shuffle', così smettere di chiedere! ";
					}
					case 241:
					{
						return "C'è stato un enorme diceria che viene diffuso su di me, 'Se non lo puoi battere, lui mangiare!'";
					}
					case 242:
					{
						return "Oy, che cosa avete nel vostro Fluffer Grillo Parlante?";
					}
					case 243:
					{
						return "Devo diventare un pirata dell'aria? Ho pensato di diventare un pirata dell'aria.";
					}
					case 244:
					{
						return "Che si tratti di cosa sarebbe, un jetpack che si adattano bene!";
					}
					case 245:
					{
						return "Mi sento un po 'scontroso come di ritardo, in modo sufficiente con il tuo chiacchiere si ragamuffin!";
					}
					case 246:
					{
						return string.Concat("Sono possente curioso di quel ", str11, " compagno. Con che tipo di consumo fa a mantenere tale locomozione?");
					}
					case 247:
					{
						return "Quel tipo capitano mi sembra di essere 'abbastanza bene sulla baia' se sai cosa voglio dire! ";
					}
					case 248:
					{
						return "Mostrami alcuni ingranaggi! ";
					}
					case 249:
					{
						return "Mi piace il tuo ... ingranaggio. Le viene in ottone?";
					}
					case 250:
					{
						return "Una volta che si entra in terra consacrata, si vedrà un arcobaleno nel cielo. Io posso aiutarti con la pittura che, se si vuole.";
					}
					case 251:
					{
						return string.Concat("Scopri ", str10, ". Ora che è una ragazza che può dipingere di rosso la città!");
					}
					case 252:
					{
						return "Conosco la differenza tra il turchese e blu-verde. Ma io non lo dirò.";
					}
					case 253:
					{
						return "Sono tutti fuori di bianco di titanio, quindi non hanno nemmeno chiedere.";
					}
					case 254:
					{
						return "Prova swirly rosa e viola, funziona, lo giuro!";
					}
					case 255:
					{
						return "No, no, no ... Ci sono tonnellate di diversi grigi! Non fatemi parlare ...";
					}
					case 256:
					{
						return "Spero che non piova di nuovo fino a quando questa vernice si asciuga. Sarebbe un disastro! ";
					}
					case 257:
					{
						return "Vi porto i colori più ricchi in cambio della tua ricchezza!";
					}
					case 258:
					{
						return "Mio caro, quello che indossi è troppo triste. È assolutamente necessario prendere una lezione di tintura vostro abbigliamento stanco!";
					}
					case 259:
					{
						return "L'unico tipo di legno io mi preoccuperei di tintura è mogano ricco. Tintura qualsiasi altro legno è un tale spreco.";
					}
					case 260:
					{
						return string.Concat("Devi fare qualcosa per ", str12, ".  Ogni volta che viene qui, mi ci vuole una settimana per ottenere l'odore di sconto!");
					}
					case 261:
					{
						return "Quale dottore sono io? Il Witch Doctor sono.";
					}
					case 262:
					{
						return "Il cuore della magia è la natura. La natura del cuore è magia.";
					}
					case 263:
					{
						return string.Concat(str, " può aiutare a guarire il corpo, ma posso farti incarnano guarigione.");
					}
					case 264:
					{
						return string.Concat("Scegli con saggezza, ", Main.player[Main.myPlayer].name, ", le mie materie prime sono volatili e la mia arte oscura, misteriosa.");
					}
					case 265:
					{
						return "Dobbiamo parlare. E '... si tratta di feste.";
					}
					case 266:
					{
						return "Non riesco a decidere quello che mi piace di più: feste, o post-feste.";
					}
					case 267:
					{
						return "Dovremmo creare un gruppo di blinkroot, e dovremmo anche istituito una festa dopo.";
					}
					case 268:
					{
						return string.Concat("Wow, ", Main.player[Main.myPlayer].name, ", incontrare un uomo avventuroso come te mi fa venire voglia di festa!");
					}
					case 269:
					{
						return "Mettere su una palla da discoteca e poi ti faccio vedere come far festa.";
					}
					case 270:
					{
						return "Sono andato alla Svezia una volta, party hard, perche 'non ti piace?";
					}
					case 271:
					{
						return string.Concat("Il mio nome di ", str10, " ma le persone mi chiamano partito popper. Si. Non lo so, suona freddo comunque.");
					}
					case 272:
					{
						return "Ti partito? A volte? Hm, ok allora possiamo parlare...";
					}
					case 273:
					{
						return "Io non sono un amante del territorio, ma è meglio aver amato e perso che non amare affatto.";
					}
					case 274:
					{
						return "Yo ho ho e una bottiglia di ...blinkroots!";
					}
					case 275:
					{
						return "YAR!  Divertente si dovrebbe essere accennando pappagalli perché ... ehm ... cosa stavamo parlando?";
					}
					case 276:
					{
						return string.Concat(Main.player[Main.myPlayer].name, ", Siete di una delle più belle fanciulle che cercano questo qui capitano visto in molti una quindicina di giorni!");
					}
					case 277:
					{
						return "Rimanere fuori mi bottino, si scallywag!";
					}
					case 278:
					{
						return "Cosa diamine stai parlando? Moby Dick è mio!";
					}
					case 279:
					{
						return "*Yarr Blarr Harrdarr*";
					}
					case 280:
					{
						return "E poi Unità 492-8 disse: 'Chi pensi che io sono, Unità 472-6?' HA. HA. HA.";
					}
					case 281:
					{
						return "Il mio rendimento spedizione è stata criticamente ridotta quando un proiettile influenzato la mia locomotiva attuatore.";
					}
					case 282:
					{
						return "Questa frase è falsa, o è?";
					}
					case 283:
					{
						return "Così che il 'punk' cercando pulcino è un inventore, eh? Penso che avrei potuto mostrare una cosa o due!";
					}
					case 284:
					{
						return string.Concat("Certo, io e ", str12, " sono amici, ma odio quando il suo pappagallo fa il suo lavoro su di me. Corrosiva che roba!");
					}
					case 285:
					{
						return "Io stesso ho costruito un meccanismo di gusto, così posso bere qualche birra!";
					}
					case 286:
					{
						return "A volte mi si stacca un po '... Capito? un po '?";
					}
				}
			}
			else if (Lang.lang == 4)
			{
				switch (l)
				{
					case 1:
					{
						return "Rassurez-moi, on ne doit pas compter que sur vous pour nous protéger de l'œil de Cthulhu.";
					}
					case 2:
					{
						return "Regardez-moi cette armure bas de gamme que vous avez sur le dos. Vous avez intérêt à acheter davantage de potions de soin.";
					}
					case 3:
					{
						return "Je sens une présence maléfique m'observer.";
					}
					case 4:
					{
						return "L'épée est plus forte que la plume. Achetez-en une dès aujourd'hui.";
					}
					case 5:
					{
						return "Vous voulez des pommes ? Vous voulez des poires ? Vous voulez des scoubidous ? Nous avons des torches.";
					}
					case 6:
					{
						return "Quelle belle matinée, n'est-ce pas ? Vous voulez quelque chose?";
					}
					case 7:
					{
						return "La nuit va bientôt tomber, alors faites votre choix tant qu'il est encore temps.";
					}
					case 8:
					{
						return "Vous n'avez pas idée du nombre de blocs de terre qui sont vendus à l'étranger.";
					}
					case 9:
					{
						return string.Concat("Un jour, des légendes étonnantes circuleront sur ", Main.player[Main.myPlayer].name, ".");
					}
					case 10:
					{
						return "Jetez un œil à mes blocs de terre, c'est de la terre de premier choix.";
					}
					case 11:
					{
						return "Voyez comme le soleil tape. J'ai des armures parfaitement ventilées.";
					}
					case 12:
					{
						return "Le soleil est haut dans le ciel, mais mes prix sont bas.";
					}
					case 13:
					{
						string[] strArrays7 = new string[] { "Oh, génial ! J'entends ", str8, " et ", str, " se disputer d'ici." };
						return string.Concat(strArrays7);
					}
					case 14:
					{
						return "Avez-vous vu Chult... Cthuch... Le truc avec le gros œil?";
					}
					case 15:
					{
						return string.Concat("Cette maison est sûre, n'est-ce pas ? Hein, ", Main.player[Main.myPlayer].name, "?");
					}
					case 16:
					{
						return "Même la Lune de Sang ne peut arrêter le capitalisme. Alors, faisons affaires.";
					}
					case 17:
					{
						return "Pour garder un œil sur les prix, achetez une lentille.";
					}
					case 18:
					{
						return "Kosh, kapleck Mog. Oh désolé, ça veut dire « Achetez-moi quelque chose ou allez au diable » en klingon.";
					}
					case 19:
					{
						return string.Concat("Vous êtes ", Main.player[Main.myPlayer].name, ", n'est-ce pas ? J'ai entendu de bonnes choses à votre sujet.");
					}
					case 20:
					{
						return "J'ai entendu dire qu'il y avait un trésor caché... Bon, laissez tomber.";
					}
					case 21:
					{
						return "Une statue d'ange, dites-vous ? Désolé, ce n'est pas une boutique de souvenirs ici.";
					}
					case 22:
					{
						return "Le dernier type qui est venu m'a vendu quelques sales... Je veux dire, de vrais trésors.";
					}
					case 23:
					{
						return "Je me demande si la lune est un gros fromage... Hein, quoi ? Oh , bien sûr, achetez ce que vous voulez!";
					}
					case 24:
					{
						return "Vous avez dit or ? Je vais vous en débarrasser.";
					}
					case 25:
					{
						return "Faites attention de ne pas me mettre du sang partout.";
					}
					case 26:
					{
						return "Dépêchez-vous et arrêtez de saigner.";
					}
					case 27:
					{
						return "Si vous comptez mourir, faites-le dehors.";
					}
					case 28:
					{
						return "Qu'est-ce que ça veut dire ?";
					}
					case 29:
					{
						return "Je n'aime pas beaucoup votre ton.";
					}
					case 30:
					{
						return "Qu'est-ce que vous faites là ? Si vous ne saignez pas, sortez d'ici. Dehors !";
					}
					case 31:
					{
						return "Quoi ?";
					}
					case 32:
					{
						return "Vous avez vu ce vieil homme qui se pressait autour du donjon ? Il semblait avoir des ennuis.";
					}
					case 33:
					{
						return string.Concat("J'aimerais bien que ", str4, " fasse plus attention. J'en ai assez de lui faire des points de suture chaque jour.");
					}
					case 34:
					{
						return string.Concat("Je me demande si ", str2, " a dit qu'il avait besoin d'un docteur.");
					}
					case 35:
					{
						return string.Concat("Il va falloir que je discute sérieusement avec ", str6, ". Combien de fois par semaine allez-vous revenir ici avec des brûlures au second degré ?");
					}
					case 36:
					{
						return "Vous avez meilleure mine comme ça.";
					}
					case 37:
					{
						return "Que vous est-il arrivé au visage ?";
					}
					case 38:
					{
						return "Bon sang, je suis une bonne infirmière, mais pas à ce point.";
					}
					case 39:
					{
						return "Mes chers amis, nous sommes rassemblés aujourd'hui pour faire nos adieux... Bon, tout se passera bien.";
					}
					case 40:
					{
						return "Vous avez laissé votre bras là-bas. Laissez-moi arranger ça.";
					}
					case 41:
					{
						return "Arrêtez de vous comporter comme une mauviette. J'ai déjà vu bien pire.";
					}
					case 42:
					{
						return "Cela va demander quelques points de suture.";
					}
					case 43:
					{
						return "Encore des soucis avec ces brutes ?";
					}
					case 44:
					{
						return "Attendez, je dois avoir quelques pansements pour enfants quelque part.";
					}
					case 45:
					{
						return string.Concat("Allez faire quelques pas, ", Main.player[Main.myPlayer].name, ", ça devrait aller. Allez, ouste !");
					}
					case 46:
					{
						return "Ça vous fait mal quand vous faites ça ? Eh bien, ne le faites pas.";
					}
					case 47:
					{
						return "On dirait qu'on a commencé à vous digérer. Vous avez encore chassé des slimes ?";
					}
					case 48:
					{
						return "Tournez votre tête et toussez.";
					}
					case 49:
					{
						return "Ce n'est pas la plus grave blessure que j'ai vue... Oui, j'ai déjà vu des blessures bien plus graves que ça.";
					}
					case 50:
					{
						return "Vous voulez une sucette ?";
					}
					case 51:
					{
						return "Montrez-moi où vous avez mal.";
					}
					case 52:
					{
						return "Je suis désolée, mais vous n'avez pas les moyens.";
					}
					case 53:
					{
						return "Il va me falloir plus d'or que cela.";
					}
					case 54:
					{
						return "Je ne travaille pas gratuitement, vous savez.";
					}
					case 55:
					{
						return "Je ne vous garantis pas le résultat.";
					}
					case 56:
					{
						return "Je ne peux rien faire de plus pour vous sans chirurgie esthétique.";
					}
					case 57:
					{
						return "Arrêtez de me faire perdre mon temps.";
					}
					case 58:
					{
						return string.Concat("J'ai entendu dire qu'il y aurait une poupée qui ressemblerait beaucoup à ", str6, " dans le monde inférieur. J'aimerais bien lui coller quelques pruneaux.");
					}
					case 59:
					{
						return string.Concat("Dépêchez-vous, j'ai un rencard avec ", str, " d'ici une heure.");
					}
					case 60:
					{
						return string.Concat("Je veux ce que vend", str, ". Comment ça, elle ne vend rien !");
					}
					case 61:
					{
						return string.Concat(str3, " est vraiment canon. Dommage qu'elle soit aussi prude.");
					}
					case 62:
					{
						return string.Concat("Ne vous embêtez pas avec ", str4, ", j'ai tout ce qu'il vous faut ici.");
					}
					case 63:
					{
						return string.Concat("C'est quoi le problème de ", str4, " ? Est-ce qu'il réalise seulement que l'on vend du matériel complètement différent ?");
					}
					case 64:
					{
						return string.Concat("Eh bien, c'est la nuit idéale pour ne pas parler à n'importe qui, n'est-ce pas, ", Main.player[Main.myPlayer].name, " ?");
					}
					case 65:
					{
						return "J'adore les nuits comme celle-ci, car il y a toujours des choses à tuer.";
					}
					case 66:
					{
						return "Je vois que vous êtes en train de zieuter le minishark... Mieux vaut ne pas savoir comment c'est fabriqué.";
					}
					case 67:
					{
						return "Eh, c'est pas du cinéma. Les munitions sont superflues.";
					}
					case 68:
					{
						return "Retirez les mains de mon flingue.";
					}
					case 69:
					{
						return "Avez-vous essayé d'utiliser de la poudre de purification sur la pierre d'ébène de corruption ?";
					}
					case 70:
					{
						return string.Concat("Ce serait bien si ", str2, " cessait de me courtiser. J'ai quand même 500 ans, mais ça n'a pas l'air de lui faire peur.");
					}
					case 71:
					{
						return string.Concat("Pourquoi ", str1, " essaie-t-il toujours de me vendre des statues d'ange ? Tout le monde sait qu'elles sont sans intérêt.");
					}
					case 72:
					{
						return "Avez-vous vu le vieil homme en train de marcher autour du donjon ? Il n'avait vraiment pas l'air bien.";
					}
					case 73:
					{
						return "Je vends ce que je veux, et si cela ne vous plaît pas, tant pis pour vous.";
					}
					case 74:
					{
						return "Pourquoi adopter un comportement aussi conflictuel en cette période ?";
					}
					case 75:
					{
						return "Je ne veux pas que vous achetiez mes marchandises, je veux que vous vouliez acheter mes marchandises, vous saisissez la nuance ?";
					}
					case 76:
					{
						return "Dites, c'est moi ou il y a un million de zombies qui déambulent cette nuit ?";
					}
					case 77:
					{
						return "Je veux que vous purifiiez le monde de la corruption.";
					}
					case 78:
					{
						return "Soyez prudent, Terraria a besoin de vous.";
					}
					case 79:
					{
						return "Les sables du temps s'écoulent et il faut bien avouer que vous vieillissez plutôt mal.";
					}
					case 80:
					{
						return "Comment ça, j'aboie plus que je ne mords ?";
					}
					case 81:
					{
						return "C'est l'histoire de deux gobelins qui entrent dans une taverne et l'un dit à l'autre : « Tu veux un gobelet de bière ? »";
					}
					case 82:
					{
						return "Je ne peux pas vous laisser entrer tant que vous ne m'aurez pas débarrassé de ma malédiction.";
					}
					case 83:
					{
						return "Revenez à la nuit tombée si vous voulez entrer.";
					}
					case 84:
					{
						return "Mon maître ne peut pas être invoqué à la lumière du jour.";
					}
					case 85:
					{
						return "Vous êtes bien trop faible pour me débarrasser de ma malédiction. Revenez quand vous serez de taille.";
					}
					case 86:
					{
						return "C'est pathétique ! Vous n'espérez quand même pas affronter mon maître pour l'instant dans votre état.";
					}
					case 87:
					{
						return "J'espère que vous avez au moins six amis pour vous épauler.";
					}
					case 88:
					{
						return "Je vous en prie, ne faites pas ça. Vous allez vous faire tuer.";
					}
					case 89:
					{
						return "Votre puissance semble suffisante pour me débarrasser de ma malédiction.";
					}
					case 90:
					{
						return "Disposez-vous de la force nécessaire pour vaincre mon maître ?";
					}
					case 91:
					{
						return "S'il vous plaît, je vous en conjure, affrontez mon ravisseur et libérez-moi.";
					}
					case 92:
					{
						return "Terrassez mon maître et je vous ouvrirai la voie du donjon.";
					}
					case 93:
					{
						return "Vous essayez d'écouler cette pierre d'ébène, hein ? Pourquoi ne pas l'intégrer à l'un de ces explosifs ?";
					}
					case 94:
					{
						return "Dites donc, vous n'auriez pas vu un clown dans le coin ?";
					}
					case 95:
					{
						return "Il y avait une bombe juste là et je n'arrive plus à remettre la main dessus.";
					}
					case 96:
					{
						return "J'ai quelque chose dont les zombies raffolent.";
					}
					case 97:
					{
						return string.Concat("Même ", str2, " raffole de mes marchandises.");
					}
					case 98:
					{
						return "Vous préférez un trou de balle ou un trou de grenade ? C'est bien ce que je pensais.";
					}
					case 99:
					{
						return string.Concat(str, " vous aidera si jamais vous perdez un membre avec ça.");
					}
					case 100:
					{
						return "Pourquoi purifier le monde alors que vous pouvez tout faire sauter ?";
					}
					case 101:
					{
						return "Si vous lancez ça dans votre baignoire et que vous fermez les fenêtres, ça vous débouchera les sinus et les oreilles en moins de deux.";
					}
					case 102:
					{
						return "Vous voulez jouer au poulet-fusée ?";
					}
					case 103:
					{
						return "Pourriez-vous signer cette clause de non-responsabilité ?";
					}
					case 104:
					{
						return "INTERDICTION FORMELLE DE FUMER.";
					}
					case 105:
					{
						return "Les explosifs, c'est de la bombe en ce moment. Achetez-en dès maintenant.";
					}
					case 106:
					{
						return "C'est un bon jour pour mourir.";
					}
					case 107:
					{
						return "Je me demande ce qui va se passer si je... (BOUM !)... Désolé, vous aviez besoin de cette jambe ?";
					}
					case 108:
					{
						return "La dynamite, c'est mon remède spécial à tous vos petits problèmes.";
					}
					case 109:
					{
						return "Jetez un œil à mes marchandises, mes prix sont explosifs.";
					}
					case 110:
					{
						return "J'ai encore le vague souvenir d'avoir attaché une femme et de l'avoir balancée dans un donjon.";
					}
					case 111:
					{
						return "Il y a un problème, c'est la lune de sang.";
					}
					case 112:
					{
						return string.Concat("Si j'avais été plus jeune, j'aurais proposé un rencard à ", str, ". J'étais un bourreau des cœurs dans le temps.");
					}
					case 113:
					{
						return "Ce chapeau rouge que vous portez me dit quelque chose.";
					}
					case 114:
					{
						return "Merci de m'avoir débarrassé de cette malédiction. J'avais l'impression que quelque chose m'avait mordu et ne me lâchait plus.";
					}
					case 115:
					{
						return "Ma mère m'a toujours dit que je ferais un bon tailleur.";
					}
					case 116:
					{
						return "La vie est comme le chapeau d'un magicien, on ne sait jamais ce qui va en sortir.";
					}
					case 117:
					{
						return "La broderie, c'est très difficile. Si ça ne l'était pas, personne n'en ferait. C'est ce qui la rend si intéressante.";
					}
					case 118:
					{
						return "Le commerce du prêt-à-porter n'a aucun secret pour moi.";
					}
					case 119:
					{
						return "Quand on est maudit, ça n’aide pas à se faire des amis. Alors un jour, je m'en suis fait un avec un morceau de cuir et je l'ai appelé Wilson.";
					}
					case 120:
					{
						return "Merci de m'avoir libéré, humain. J'ai été attaché et laissé ici par les autres gobelins. On peut dire qu'on ne s'entendait pas très bien, eux et moi.";
					}
					case 121:
					{
						return "Je n'arrive pas à croire qu'ils m'aient attaché et planté ici juste pour montrer qu'ils ne voulaient pas aller vers l'est.";
					}
					case 122:
					{
						return "Puisque je suis devenu un paria, puis-je jeter mes boules piquantes ? Mes poches me font mal.";
					}
					case 123:
					{
						return "Vous cherchez un expert en gadgets ? Je suis votre gobelin.";
					}
					case 124:
					{
						return "Merci de votre aide. À présent, je dois continuer à errer sans but dans les environs. Je suis sûr qu'on se reverra.";
					}
					case 125:
					{
						return "Je ne vous imaginais pas comme ça.";
					}
					case 126:
					{
						return string.Concat("Et comment va ", str8, "? Lui auriez-vous parlé, par hasard ?");
					}
					case 127:
					{
						return "Est-ce que votre chapeau a besoin d'un moteur ? Je crois en avoir un en stock qui ferait parfaitement l'affaire.";
					}
					case 128:
					{
						return "J'ai entendu dire que vous aimiez les bottes de course et les roquettes, du coup, j'ai installé des roquettes dans vos bottes de course.";
					}
					case 129:
					{
						return "Le silence est d'or, mais le chatterton reste très efficace.";
					}
					case 130:
					{
						return "Oui, l'or est plus précieux que le fer. Mais qu'est-ce qu'ils vous apprennent chez les humains ?";
					}
					case 131:
					{
						return "C'est vrai que ce casque de mineur combiné à une palme rendait mieux sur le papier.";
					}
					case 132:
					{
						return "Les gobelins sont étonnamment soupe au lait. Ils pourraient déclencher une guerre pour un mot de travers.";
					}
					case 133:
					{
						return "Il faut bien avouer que les gobelins n'ont pas inventé la poudre, mais il y a des exceptions à la règle.";
					}
					case 134:
					{
						return "Savez-vous pourquoi on trimballe toujours ces boules piquantes ? Parce que moi, je n'en sais fichtre rien.";
					}
					case 135:
					{
						return "Je viens de mettre la touche finale à ma dernière invention. Et ce modèle n'explosera pas si vous soufflez trop fort dessus.";
					}
					case 136:
					{
						return "Les voleurs gobelins sont des vrais manchots. Ils ne sont même pas capables de dérober le contenu d'un coffre non verrouillé.";
					}
					case 137:
					{
						return "Merci de m'avoir secouru. Ces liens commençaient à m'irriter la peau.";
					}
					case 138:
					{
						return "Mon héros !";
					}
					case 139:
					{
						return "Quel héroïsme ! Merci de m'avoir sauvé, belle dame.";
					}
					case 140:
					{
						return "Quel héroïsme ! Merci de m'avoir sauvé, fringant jeune homme.";
					}
					case 141:
					{
						return "Maintenant que nous avons fait connaissance, je peux venir avec vous, n'est-ce pas ?";
					}
					case 142:
					{
						return string.Concat("Bonjour, ", str6, "! Que puis-je pour vous, aujourd'hui ?");
					}
					case 143:
					{
						return string.Concat("Bonjour, ", str4, "! Que puis-je pour vous, aujourd'hui ?");
					}
					case 144:
					{
						return string.Concat("Bonjour, ", str7, "! Que puis-je pour vous, aujourd'hui ?");
					}
					case 145:
					{
						return string.Concat("Bonjour, ", str, "! Que puis-je pour vous, aujourd'hui ?");
					}
					case 146:
					{
						return string.Concat("Bonjour, ", str8, "! Que puis-je pour vous, aujourd'hui ?");
					}
					case 147:
					{
						return string.Concat("Bonjour, ", str3, "! Que puis-je pour vous, aujourd'hui ?");
					}
					case 148:
					{
						return "Voulez-vous que je fasse apparaître une pièce de monnaie de derrière votre oreille ? Non ? Bon.";
					}
					case 149:
					{
						return "Est-ce qu'un berlingot magique vous ferait plaisir ? Non ? Bon.";
					}
					case 150:
					{
						return "Je peux concocter un merveilleux chocolat chaud magique, si cela vous intéresse... Non ? OK.";
					}
					case 151:
					{
						return "Souhaitez-vous jeter un œil à ma boule de cristal ?";
					}
					case 152:
					{
						return "N'avez-vous jamais rêvé de posséder un anneau magique qui transformerait les rochers en vase ? Moi non plus, à vrai dire.";
					}
					case 153:
					{
						return "Un jour, quelqu'un m'a dit que l'amitié était quelque chose de magique. C'est n'importe quoi. On ne peut pas transformer quelqu'un en grenouille avec l'amitié.";
					}
					case 154:
					{
						return "À présent, votre avenir m'apparaît clairement... Vous allez m'acheter de nombreux objets.";
					}
					case 155:
					{
						return "Une fois, j'ai tenté de ramener une statue d'ange à la vie. Il ne s'est rien passé.";
					}
					case 156:
					{
						return "Merci. C'était moins une, j'ai failli terminer comme tous ces squelettes.";
					}
					case 157:
					{
						return "Attention où vous mettez les pieds. J'étais encore là-bas il y a peu.";
					}
					case 158:
					{
						return "Attendez, je suis en train de perdre ma connexion Wi-Fi par ici.";
					}
					case 159:
					{
						return "Mais j'avais presque terminé d'installer des stroboscopes ici.";
					}
					case 160:
					{
						return "Que personne ne bouge ! J'ai perdu une lentille.";
					}
					case 161:
					{
						return "Tout ce que je veux, c'est que l'interrupteur... Quoi ?";
					}
					case 162:
					{
						return "Je parie que vous n'avez pas acheté assez de câbles. Décidément, vous n'êtes vraiment pas une lumière.";
					}
					case 163:
					{
						return "Est-ce que vous pourriez juste... S'il vous plaît ? OK ? OK.";
					}
					case 164:
					{
						return "Je n'aime pas trop la façon dont vous me regardez. Je suis en train de travailler, moi.";
					}
					case 165:
					{
						string[] strArrays8 = new string[] { "Au fait, ", Main.player[Main.myPlayer].name, ", vous venez de voir  ", str7, " ? Est-ce qu'il aurait parlé de moi, par hasard ?" };
						return string.Concat(strArrays8);
					}
					case 166:
					{
						return string.Concat(str2, " parle toujours de pressuriser mes plaques de pression. Je lui ai dit que c'était pour marcher dessus.");
					}
					case 167:
					{
						return "Il faut toujours acheter plus de câbles que prévu.";
					}
					case 168:
					{
						return "Vous vous êtes assuré que votre matériel était bien branché ?";
					}
					case 169:
					{
						return "Vous savez ce qu'il faudrait à cette maison ? Plus de stroboscopes.";
					}
					case 170:
					{
						return "La lune de sang se remarque lorsque le ciel vire au rouge et quelque chose fait que les monstres pullulent.";
					}
					case 171:
					{
						return "Dites donc, vous savez où je peux trouver de la mauvaise herbe morte. Non, pour rien, je me demandais, c'est tout.";
					}
					case 172:
					{
						return "Si vous regardiez en l'air, vous verriez que là,  la lune est toute rouge.";
					}
					case 173:
					{
						return "La nuit, vous devriez rester à l'intérieur. C'est très dangereux de se balader dans le noir.";
					}
					case 174:
					{
						return string.Concat("Bienvenue, ", Main.player[Main.myPlayer].name, ". Je peux faire quelque chose pour vous ?");
					}
					case 175:
					{
						return "Je suis là pour vous conseiller et vous aider dans vos prochaines actions. Vous devriez venir me parler au moindre problème.";
					}
					case 176:
					{
						return "On dit qu'il y a une personne capable de vous aider à survivre sur ces terres... Oh, attendez, c'est moi.";
					}
					case 177:
					{
						return "Vous pouvez utiliser votre pioche pour creuser dans la terre, et votre hache pour abattre des arbres. Placez simplement le curseur à l'emplacement souhaité et cliquez.";
					}
					case 178:
					{
						return "Si vous voulez survivre, vous allez devoir fabriquer des armes et un abri. Commencez par abattre des arbres et récolter du bois.";
					}
					case 179:
					{
						return "Appuyez sur ÉCHAP pour accéder au menu d'artisanat. Lorsque vous avez assez de bois, créez un établi. Tant que vous vous tiendrez à proximité, il vous permettra de fabriquer des objets plus complexes.";
					}
					case 180:
					{
						return "Vous pouvez construire un abri en plaçant du bois ou d'autres blocs dans le monde. N'oubliez pas de créer des murs et de les placer.";
					}
					case 181:
					{
						return "Une fois que vous aurez une épée de bois, vous pourriez essayer de récupérer du gel grâce aux slimes. Combinez ensuite le bois et le gel pour faire une torche.";
					}
					case 182:
					{
						return "Pour interagir avec les arrière-plans et les objets placés, utilisez un marteau.";
					}
					case 183:
					{
						return "Vous devriez creuser pour trouver du minerai. Cela vous permet de fabriquer des objets très utiles.";
					}
					case 184:
					{
						return "Maintenant que vous avez du minerai, vous allez devoir le transformer en lingot pour pouvoir en faire des objets. Il vous faut un fourneau.";
					}
					case 185:
					{
						return "Vous pouvez fabriquer un fourneau avec des torches, du bois et de la pierre. Assurez-vous de vous tenir près d'un établi.";
					}
					case 186:
					{
						return "Vous aurez besoin d'une enclume pour pouvoir fabriquer la plupart des choses à partir des lingots de métal.";
					}
					case 187:
					{
						return "Une enclume peut être fabriquée avec du fer ou bien achetée chez les marchands.";
					}
					case 188:
					{
						return "Le souterrain est un cœur de cristal utilisé pour augmenter votre maximum de vie. Il vous faudra un marteau pour pouvoir en extraire.";
					}
					case 189:
					{
						return "Si vous récupérez dix étoiles filantes, elles peuvent être combinées pour fabriquer un objet qui augmentera votre capacité de magie.";
					}
					case 190:
					{
						return "Les étoiles tombent sur le monde durant la nuit. Elles peuvent être utilisées pour toutes sortes de choses utiles. Si vous en voyez une, dépêchez-vous de la ramasser, car elles disparaissent l'aube venue.";
					}
					case 191:
					{
						return "Il existe de nombreux moyens pour attirer du monde dans notre ville. Bien sûr, une fois sur place, ces nouveaux arrivants auront besoin d'une maison pour s'abriter.";
					}
					case 192:
					{
						return "Pour qu'une pièce puisse être considérée comme un foyer, elle doit comporter une porte, une chaise, une table et une source de lumière. Assurez-vous que la maison dispose également de murs.";
					}
					case 193:
					{
						return "Deux personnes distinctes ne vivront pas dans le même foyer. De plus, si leur foyer est détruit, ils chercheront un nouveau lieu où habiter.";
					}
					case 194:
					{
						return "Vous pouvez utiliser l'interface de logement pour attribuer des logements et les visualiser. Ouvrez votre inventaire et cliquez sur l'icône de maison.";
					}
					case 195:
					{
						return "Si vous souhaitez qu'un marchand emménage, vous devrez avoir une quantité d'argent suffisante. 50 pièces d'argent devraient suffire.";
					}
					case 196:
					{
						return "Pour qu'une infirmière emménage, vous pourriez augmenter votre maximum de vie.";
					}
					case 197:
					{
						return "Si vous avez un mousquet, il se peut qu'un marchand d'armes fasse son apparition pour vous vendre des munitions.";
					}
					case 198:
					{
						return "Vous devriez montrer de quoi vous êtes capable en triomphant d'un monstre. Cela attirera l'attention d'une dryade.";
					}
					case 199:
					{
						return "Assurez-vous d'explorer minutieusement les donjons. Il pourrait y avoir des prisonniers retenus captifs dans les profondeurs.";
					}
					case 200:
					{
						return "Peut-être que le vieil homme du donjon voudra se joindre à nous maintenant que sa malédiction a été levée.";
					}
					case 201:
					{
						return "Récupérez toutes les bombes que vous pourrez trouver. Un démolisseur voudra sûrement y jeter un œil.";
					}
					case 202:
					{
						return "Les gobelins sont-ils si différents de nous pour que nous ne puissions pas vivre ensemble de manière paisible ?";
					}
					case 203:
					{
						return "J'ai entendu dire qu'un puissant magicien vivait dans les environs. Assurez-vous de le trouver la prochaine fois que vous irez dans le souterrain.";
					}
					case 204:
					{
						return "Si vous combinez des lentilles à un autel de démon, vous pourrez trouver un moyen d'invoquer un monstre très puissant. Cependant, il vous faudra attendre la tombée de la nuit avant de pouvoir l'utiliser.";
					}
					case 205:
					{
						return "Vous pouvez fabriquer de la nourriture pour ver avec des morceaux pourris et de la poudre infecte. Assurez-vous de vous trouver dans une zone corrompue avant de l'utiliser.";
					}
					case 206:
					{
						return "Les autels démoniaques peuvent généralement être trouvés dans la corruption. Il vous faudra vous tenir près d'eux pour fabriquer certains objets.";
					}
					case 207:
					{
						return "Vous pouvez fabriquer un grappin avec un crochet et trois chaînes. Les squelettes trouvés dans les profondeurs portent souvent des crochets sur eux. Les chaînes peuvent être fabriquées à l'aide de lingots de fer.";
					}
					case 208:
					{
						return "Si vous voyez des pots, détruisez-les pour les ouvrir, car ils contiennent souvent des objets très utiles.";
					}
					case 209:
					{
						return "Des trésors sont disséminés un peu partout dans le monde et vous pouvez trouver des objets fantastiques dans les profondeurs.";
					}
					case 210:
					{
						return "Lorsqu'on écrase un orbe d'ombre, il arrive qu'une météorite tombe du ciel. Les orbes d'ombre peuvent généralement être trouvés dans les gouffres des zones corrompues.";
					}
					case 211:
					{
						return "Vous devriez vous employer à récolter davantage de cœurs de cristal pour augmenter votre maximum de vie.";
					}
					case 212:
					{
						return "Votre équipement actuel ne suffira pas. Il vous faut une meilleure armure.";
					}
					case 213:
					{
						return "Je crois que vous pouvez maintenant prendre part à votre première grande bataille. De nuit, rassemblez des lentilles récupérées à la mort des démons et portez-les sur un autel de démon.";
					}
					case 214:
					{
						return "Vous devriez augmenter votre vie avant votre prochaine épreuve. Quinze cœurs devraient suffire.";
					}
					case 215:
					{
						return "La pierre d'ébène dans la corruption peut être purifiée en utilisant de la poudre issue d'une dryade, ou bien peut être détruite avec des explosifs.";
					}
					case 216:
					{
						return "Votre prochaine épreuve sera d'explorer les gouffres corrompus. Trouvez et détruisez tous les orbes d'ombre que vous trouverez.";
					}
					case 217:
					{
						return "Il existe un vieux donjon situé pas très loin d'ici. Vous devriez aller y faire un tour dès maintenant.";
					}
					case 218:
					{
						return "Vous devriez essayer d'augmenter votre vie maximum. Essayez de rassembler vingt cœurs.";
					}
					case 219:
					{
						return "Si vous pouvez creuser assez profondément, il y a de nombreux trésors à découvrir dans la jungle.";
					}
					case 220:
					{
						return "Le monde inférieur est fait d'un matériau appelé pierre de l'enfer. Ce matériau est parfait pour la fabrication d'armes et d'armures.";
					}
					case 221:
					{
						return "Lorsque vous voudrez affronter le gardien du monde inférieur, vous devrez faire le sacrifice d'un être vivant. Tout ce dont vous avez besoin pour cela se trouve dans le monde inférieur.";
					}
					case 222:
					{
						return "Assurez-vous d'écraser tous les autels de démon que vous trouverez. Vous pourrez en tirer quelque chose de bénéfique.";
					}
					case 223:
					{
						return "Des âmes peuvent être parfois récupérées des créatures déchues dans des lieux de lumière ou d'ombre extrême.";
					}
					case 224:
					{
						return "Ho ho ho et une bouteille de ... Egg Nog!";
					}
					case 225:
					{
						return "Soins pour cuire des biscuits moi?";
					}
					case 226:
					{
						return "Qu'est-ce? Vous pensiez que je n'étais pas réel?";
					}
					case 227:
					{
						return "J'ai réussi à coudre votre visage sur le dos. Soyez plus prudent la prochaine fois.";
					}
					case 228:
					{
						return "Cela va probablement laisser une cicatrice.";
					}
					case 229:
					{
						return "Toutes les meilleures. Je ne veux pas vous voir sauter plus falaises.";
					}
					case 230:
					{
						return "Cela n'a pas fait trop de mal, maintenant c'est fait?";
					}
					case 231:
					{
						return "Comme si vivre souterrain n'était pas assez, saccades comme vous venez pendant que je dors et volé mes enfants.";
					}
					case 232:
					{
						return string.Concat("Entre vous et moi, ", str3, " est le seul en qui j'ai confiance. Elle est la seule personne ici qui n'a pas essayé de me manger ou m'utiliser dans une potion.");
					}
					case 233:
					{
						return "J'ai essayé de me lécher l'autre jour pour voir ce que le gros problème était, tout a commencé bleu éclatant.";
					}
					case 234:
					{
						return "Chaque fois que je vois la couleur bleue, ça me rend dépressif et paresseux.";
					}
					case 235:
					{
						return "Vous n'avez pas vu des porcs par ici vous? Mon frère a perdu sa jambe à un.";
					}
					case 236:
					{
						return "Tout le monde dans cette ville se sent un peu à l'écart. Je me suis réveillé au drapier à mâcher sur mon pied hier soir.";
					}
					case 237:
					{
						return string.Concat("Je vais vous donner un rabais sur votre usures si vous pouvez convaincre ", str9, " à venir pour un ... dimensionnement.");
					}
					case 238:
					{
						return string.Concat("Je me sens comme ", str9, " est un peu mal compris, il est vraiment un gars amusant.");
					}
					case 240:
					{
						return "Je ne sais pas le «Truffle Shuffle» pour cesser de demander!";
					}
					case 241:
					{
						return "Il ya eu une énorme rumeur qui a été répandu sur moi: «Si vous ne pouvez pas le battre, le manger!»";
					}
					case 242:
					{
						return "Oy, qu'est-ce que vous avez dans votre fluffer Jiminy?";
					}
					case 243:
					{
						return "Devrais-je devenir un pirate air? J'ai envisagé de devenir un pirate air.";
					}
					case 244:
					{
						return "Que ce soit ce que ce serait, un jetpack qui vous conviendrait bien!";
					}
					case 245:
					{
						return "Je me sens un peu maussade de la fin, assez pour vous avec votre palabre gueux!";
					}
					case 246:
					{
						return string.Concat("Je suis curieux de savoir ce puissant ", str11, " camarade. Par ce mode de consommation-t-il maintenir cette locomotion?");
					}
					case 247:
					{
						return "Ce garçon de capitaine me semble être «assez bien sur la baie» si vous voyez ce que je veux dire!";
					}
					case 248:
					{
						return "Montrez-moi certains engins!";
					}
					case 249:
					{
						return "J'aime votre ... engrenages. Cela vient-il en laiton?";
					}
					case 250:
					{
						return "Une fois que vous entrez dans la terre sainte, et vous verrez un arc en ciel dans le ciel. Je peux vous aider avec de la peinture qui, si vous voulez.";
					}
					case 251:
					{
						return string.Concat("Découvrez ", str10, ". Maintenant, c'est une fille qui peut peindre la ville rouge!");
					}
					case 252:
					{
						return "Je connais la différence entre turquoise et bleu-vert. Mais je ne vais pas vous le dire.";
					}
					case 253:
					{
						return "Je suis tout de blanc de titane, alors ne vous demande même pas.";
					}
					case 254:
					{
						return "Essayez tourbillonnant rose et violet, cela fonctionne, je le jure!";
					}
					case 255:
					{
						return "Non, non, non ... Il ya des tonnes de différents gris! Ne me lancez pas ...";
					}
					case 256:
					{
						return "J'espère qu'il ne pleuve pas à nouveau jusqu'à ce que cette peinture sèche. Ce serait une catastrophe!";
					}
					case 257:
					{
						return "Je vous apporte les couleurs les plus riches en échange de vos richesses!";
					}
					case 258:
					{
						return "Mon cher, ce que vous portez est beaucoup trop terne. Vous devez absolument prendre une leçon de teinture de votre tenue vestimentaire fatigué!";
					}
					case 259:
					{
						return "Le seul type de bois je dérange teinture est acajou. Teinture tout autre bois est un tel gaspillage.";
					}
					case 260:
					{
						return string.Concat("Vous devez faire quelque chose pour ", str12, ".  Chaque fois qu'il vient ici, il me faut une semaine pour obtenir l'odeur off!");
					}
					case 261:
					{
						return "Quel médecin suis-je? Le sorcier je suis.";
					}
					case 262:
					{
						return "Le cœur de la magie est la nature. La nature des cœurs est magique.";
					}
					case 263:
					{
						return string.Concat(str, " peut aider à guérir votre corps, mais je peux vous faire incarner la guérison.");
					}
					case 264:
					{
						return string.Concat("Choisissez judicieusement, ", Main.player[Main.myPlayer].name, ", mes produits sont volatils et ma magie noire, mystérieuse.");
					}
					case 265:
					{
						return "Nous devons parler. C'est ... il s'agit de parties.";
					}
					case 266:
					{
						return "Je ne peux pas décider ce que je veux de plus: les parties, ou l'après que les parties.";
					}
					case 267:
					{
						return "Nous devons mettre en place une partie blinkroot, et nous devrions également mettre en place une après la fête.";
					}
					case 268:
					{
						return string.Concat("Wow, ", Main.player[Main.myPlayer].name, ", rencontrer un homme aventureux comme vous me donne envie de faire la fête!");
					}
					case 269:
					{
						return "Mettre en place une boule disco et puis je vais vous montrer comment faire la fête.";
					}
					case 270:
					{
						return "Je suis allé en Suède une fois, ils la fête dure, pourquoi n'êtes-vous pas comme ça?";
					}
					case 271:
					{
						return string.Concat("Je m'appelle ", str10, " mais les gens m'appellent Party Pooper. Ouais, je ne sais pas, c'est assez cool si");
					}
					case 272:
					{
						return "Pensez-vous parti? Parfois? Hm, ok alors nous pouvons parler ...";
					}
					case 273:
					{
						return "Je ne suis pas amoureux de la terre, mais c'est mieux d'avoir aimé et perdu que ne jamais aimer du tout.";
					}
					case 274:
					{
						return "Yo ho ho et une bouteille de ...blinkroots!";
					}
					case 275:
					{
						return "YAR!  C'est drôle que vous devriez être mentionnez perroquets parce que ... euh ... quoi parlions-nous sur?";
					}
					case 276:
					{
						return string.Concat(Main.player[Main.myPlayer].name, ", Vous être l'une des plus belles gamines qui cherchent ce ici le capitaine a vu dans beaucoup de quinze jours!");
					}
					case 277:
					{
						return "Restez en dehors de moi butin, vous voyou!";
					}
					case 278:
					{
						return "Quel en flammes êtes-vous parlez? Moby Dick est le mien!";
					}
					case 279:
					{
						return "*Yarr Blarr Harrdarr*";
					}
					case 280:
					{
						return "Et puis Unit 492-8 dit: «Qui pensez-vous que je suis, Unité 472-6?» HA. HA. HA.";
					}
					case 281:
					{
						return "Mon efficacité de l'expédition a été gravement réduite lorsqu'un projectile impact sur ma actionneur de locomotive.";
					}
					case 282:
					{
						return "Cette phrase est fausse, ou est-il?";
					}
					case 283:
					{
						return "Alors que «punk» poussin de lookin est un inventeur, hein? Je pense que je pourrais lui montrer une chose ou deux!";
					}
					case 284:
					{
						return string.Concat("Bien sûr, ", str12, " et moi sommes copains, mais je déteste quand son perroquet fait ses affaires sur moi. Le corrosif de ce genre de choses!");
					}
					case 285:
					{
						return "Je me suis construit un mécanisme de goût, donc je peux boire un soda!";
					}
					case 286:
					{
						return "Parfois, je me dégage un peu ... Get it? un peu?";
					}
				}
			}
			else if (Lang.lang == 5)
			{
				switch (l)
				{
					case 1:
					{
						return "Espero que un canijo como tú no sea lo único que se interpone entre nosotros y el Ojo de Cthulhu.";
					}
					case 2:
					{
						return "Vaya un arma más mal hecha que llevas. Te conviene comprar más pociones curativas.";
					}
					case 3:
					{
						return "Siento como si una presencia maligna me observara.";
					}
					case 4:
					{
						return "¡La espada siempre gana! Cómprate una ahora.";
					}
					case 5:
					{
						return "¿Quieres manzanas? ¿Zanahorias? ¿Unas piñas? Tenemos antorchas.";
					}
					case 6:
					{
						return "Una mañana estupenda, ¿verdad? ¿No necesitas nada?";
					}
					case 7:
					{
						return "La noche caerá pronto, amigo. Haz tus compras mientras puedas.";
					}
					case 8:
					{
						return "Ni te imaginas lo bien que se venden los Bloques de tierra en el extranjero.";
					}
					case 9:
					{
						return string.Concat("Oh, algún día narrarán las aventuras de ", Main.player[Main.myPlayer].name, "... y seguro que acaban bien.");
					}
					case 10:
					{
						return "Echa un vistazo a estos Bloques de tierra; tienen extra de tierra.";
					}
					case 11:
					{
						return "¡Oye, cómo pega el sol! Pero yo tengo una armadura totalmente ventilada.";
					}
					case 12:
					{
						return "El sol está alto, al contrario que mis precios.";
					}
					case 13:
					{
						string[] strArrays9 = new string[] { "¡Vaya! Desde aquí se oye cómo discuten ", str8, " y ", str, "." };
						return string.Concat(strArrays9);
					}
					case 14:
					{
						return "¿Has visto a Chith... esto... Shith... eh... Chat...? Vamos, ¿al gran Ojo?";
					}
					case 15:
					{
						return string.Concat("Oye, esta casa es segura, ¿verdad? ¿Verdad? ", Main.player[Main.myPlayer].name, "...");
					}
					case 16:
					{
						return "Ni siquiera una luna sangrienta detendría el capitalismo. Así que vamos a hacer negocios.";
					}
					case 17:
					{
						return "¡Fíjate bien en el premio, compra una lente!";
					}
					case 18:
					{
						return "Kosh, kapleck Mog. Lo siento, hablaba en klingon... quiere decir \"Compra algo o muere\".";
					}
					case 19:
					{
						return string.Concat("¿Eres tú, ", Main.player[Main.myPlayer].name, "? ¡Me han hablado bien de ti, amigo!");
					}
					case 20:
					{
						return "Dicen que aquí hay un tesoro escondido... oh, olvídalo...";
					}
					case 21:
					{
						return "¿La estatua de un ángel? Lo siento pero no vendo cosas de segunda mano.";
					}
					case 22:
					{
						return "El último tipo que estuvo aquí me dejó algunos trastos viejos... ¡bueno, en realidad eran tesoros!";
					}
					case 23:
					{
						return "Me pregunto si la luna estará hecha de queso... Eh... esto. ¡Ah, claro, compre aquí!";
					}
					case 24:
					{
						return "¿Has dicho oro? Me lo quedo.";
					}
					case 25:
					{
						return "Será mejor que no me manches de sangre.";
					}
					case 26:
					{
						return "Date prisa... y deja ya de sangrar.";
					}
					case 27:
					{
						return "Si te vas a morir, hazlo fuera por favor.";
					}
					case 28:
					{
						return "¿Y eso qué quiere decir?";
					}
					case 29:
					{
						return "No me gusta el tono que empleas.";
					}
					case 30:
					{
						return "¿Por qué sigues aquí? Si no te estás desangrando, aquí no pintas nada. Lárgate.";
					}
					case 31:
					{
						return "¡CÓMO!";
					}
					case 32:
					{
						return "¿Has visto a ese anciano deambulando por la mazmorra? Parece que tiene problemas.";
					}
					case 33:
					{
						return string.Concat("Ojalá ", str4, " tuviera más cuidado. Ya me estoy hartando de tener que coserle las extremidades todos los días.");
					}
					case 34:
					{
						return string.Concat("Oye, por curiosidad, ¿ha dicho ", str2, " por qué tiene que ir al médico?");
					}
					case 35:
					{
						return string.Concat("Debo hablar en serio con ", str6, ". ¿Cuántas veces crees que puedes venir en una semana con quemaduras de lava graves?");
					}
					case 36:
					{
						return "Creo que así estarás mejor.";
					}
					case 37:
					{
						return "Eh... ¿Qué te ha pasado en la cara?";
					}
					case 38:
					{
						return "¡DIOS MÍO! Soy buena, pero no tanto.";
					}
					case 39:
					{
						return "Queridos amigos, nos hemos reunido hoy aquí para decir adiós a... Vaya, te vas a poner bien.";
					}
					case 40:
					{
						return "Te dejaste el brazo por ahí. Deja que te ayude...";
					}
					case 41:
					{
						return "¡Deja de comportarte como un bebé! He visto cosas peores.";
					}
					case 42:
					{
						return "¡Voy a tener que darte puntos!";
					}
					case 43:
					{
						return "¿Ya te has vuelto a meter en líos?";
					}
					case 44:
					{
						return "Aguanta, por aquí tengo unas tiritas infantiles chulísimas.";
					}
					case 45:
					{
						return string.Concat("Anda ya, ", Main.player[Main.myPlayer].name, ", te pondrás bien. Serás nenaza...");
					}
					case 46:
					{
						return "¿Así que te duele cuando haces eso? ... Pues no lo hagas.";
					}
					case 47:
					{
						return "Parece un corte de digestión. ¿Has estado cazando babosas otra vez?";
					}
					case 48:
					{
						return "Gira la cabeza y tose.";
					}
					case 49:
					{
						return "No es de las peores heridas que he visto... Sin duda, he visto heridas más grandes que esta.";
					}
					case 50:
					{
						return "¿Quieres una piruleta, chiquitín?";
					}
					case 51:
					{
						return "A ver... ¿dónde te duele?";
					}
					case 52:
					{
						return "Lo siento, pero no puedes pagarme.";
					}
					case 53:
					{
						return "Vas a necesitar más oro del que traes.";
					}
					case 54:
					{
						return "Oye, yo no trabajo gratis.";
					}
					case 55:
					{
						return "No tengo una varita mágica.";
					}
					case 56:
					{
						return "Esto es todo lo que puedo hacer por ti... necesitas cirugía plástica.";
					}
					case 57:
					{
						return "No me hagas perder el tiempo.";
					}
					case 58:
					{
						return string.Concat("Dicen que en alguna parte del Inframundo hay una muñeca que se parece mucho a", str6, " Me gustaría dejarme caer por ahí.");
					}
					case 59:
					{
						return string.Concat("¡Date prisa! Tengo una cita con ", str, " dentro de una hora.");
					}
					case 60:
					{
						return string.Concat("Quiero lo que vende ", str, ". ¿Cómo dices? ¿Que no vende nada?");
					}
					case 61:
					{
						return string.Concat(str3, " es una monada. Es una lástima que sea tan mojigata.");
					}
					case 62:
					{
						return string.Concat("Olvídate de ", str4, ", yo tengo todo lo que necesitas aquí y ahora.");
					}
					case 63:
					{
						return string.Concat("¿Qué mosca le ha picado a ", str4, "? ¿Aún no sabe que vendemos cosas totalmente distintas?");
					}
					case 64:
					{
						return string.Concat("Oye, hace una noche magnífica para no hablar con nadie, ¿no crees, ", Main.player[Main.myPlayer].name, "?");
					}
					case 65:
					{
						return "Me encantan estas noches. ¡Siempre encuentras algo que matar!";
					}
					case 66:
					{
						return "Sé que le has echado el ojo al Minitiburón. Será mejor que no sepas de qué está hecho.";
					}
					case 67:
					{
						return "Eh, amigo, que esto no es una película. La munición va aparte.";
					}
					case 68:
					{
						return "¡Aparta esas manos de mi pistola, colega!";
					}
					case 69:
					{
						return "¿Has probado a usar polvos de purificación sobre la piedra de ébano corrupta?";
					}
					case 70:
					{
						return string.Concat("Ojalá ", str2, " dejara de flirtear conmigo. ¿No se da cuenta de que tengo 500 años?");
					}
					case 71:
					{
						return string.Concat("¿Por qué se empeña ", str1, " en intentar venderme una estatua de ángel? Todo el mundo sabe que no hacen nada.");
					}
					case 72:
					{
						return "¿Has visto a ese anciano deambulando por la mazmorra? No tiene muy buen aspecto...";
					}
					case 73:
					{
						return "¡Yo vendo lo que quiero! Si no te gusta, mala suerte.";
					}
					case 74:
					{
						return "¿Por qué tienes que ser tan polémico en estos tiempos que corren?";
					}
					case 75:
					{
						return "No quiero que compres mis artículos. Quiero que desees comprar mis artículos, ¿entiendes?";
					}
					case 76:
					{
						return "Tío, ¿soy yo o esta noche han salido de juerga un millón de zombis?";
					}
					case 77:
					{
						return "Debes erradicar la corrupción de este mundo.";
					}
					case 78:
					{
						return "Ponte a salvo; ¡Terraria te necesita!";
					}
					case 79:
					{
						return "Fluyen las arenas del tiempo. Y la verdad... no estás envejeciendo con mucha elegancia.";
					}
					case 80:
					{
						return "¿Qué tiene que ver conmigo eso de perro ladrador?";
					}
					case 81:
					{
						return "Entra un duende en un bar y dice el dueño: \"A ver, quiero control, ¿eh?\". Y dice el duende: \"No, sin trol, sin trol\".";
					}
					case 82:
					{
						return "No puedo dejarte entrar hasta que me liberes de esta maldición.";
					}
					case 83:
					{
						return "Si quieres entrar, vuelve por la noche.";
					}
					case 84:
					{
						return "No se puede invocar al maestro a la luz del día.";
					}
					case 85:
					{
						return "Eres demasiado débil para romper esta maldición. Vuelve cuando seas de más utilidad.";
					}
					case 86:
					{
						return "Eres patético. No esperes presentarte ante el maestro tal como eres.";
					}
					case 87:
					{
						return "Espero que hayas venido con varios amigos...";
					}
					case 88:
					{
						return "Extraño, no, por favor. Esto es un suicidio.";
					}
					case 89:
					{
						return "Debes ser lo bastante fuerte para poder librarme de esta maldición...";
					}
					case 90:
					{
						return "Extraño, ¿te crees con fuerzas para derrotar al maestro?";
					}
					case 91:
					{
						return "¡Por favor! ¡Lucha con mi raptor y libérame! ¡Te lo suplico!";
					}
					case 92:
					{
						return "Derrota al maestro y te garantizaré la entrada a la Mazmorra.";
					}
					case 93:
					{
						return "¿Conque intentando dominar esa piedra de ébano, eh? ¿Por qué no la metes en uno de estos explosivos?";
					}
					case 94:
					{
						return "Eh, ¿has visto a un payaso por aquí?";
					}
					case 95:
					{
						return "Había una bomba aquí mismo, y ahora no soy capaz de encontrarla...";
					}
					case 96:
					{
						return "¡Yo les daré a esos zombis lo que necesitan!";
					}
					case 97:
					{
						return string.Concat("¡Incluso ", str2, " quiere lo que vendo!");
					}
					case 98:
					{
						return "Y pensé: ¿Qué prefieres? ¿Un agujero de bala o de granada?";
					}
					case 99:
					{
						return string.Concat("Seguro que ", str, " te ayudará si pierdes una extremidad con uno de estos por accidente.");
					}
					case 100:
					{
						return "¿Por qué purificar el mundo cuando puedes volarlo en pedazos?";
					}
					case 101:
					{
						return "¡Si los lanzas a la bañera y cierras todas las ventanas, te despejará la nariz y los oídos!";
					}
					case 102:
					{
						return "¿Quieres jugar con fuego, gallina?";
					}
					case 103:
					{
						return "Oye, ¿firmarías esta renuncia de daños y perjuicios?";
					}
					case 104:
					{
						return "¡AQUÍ NO SE PUEDE FUMAR!";
					}
					case 105:
					{
						return "Los explosivos están de moda hoy en día. ¡Llévate algunos!";
					}
					case 106:
					{
						return "¡Es un buen día para morir!";
					}
					case 107:
					{
						return "Y qué pasa si... (¡BUM!)... Oh, lo siento, ¿usabas mucho esa pierna?";
					}
					case 108:
					{
						return "Dinamita, mi propia panacea para todos los males.";
					}
					case 109:
					{
						return "Echa un vistazo a este género; ¡los precios son una bomba!";
					}
					case 110:
					{
						return "Recuerdo vagamente haber atado a una mujer y haberla arrojado a una mazmorra.";
					}
					case 111:
					{
						return "¡Tenemos un problema! ¡Hoy tenemos luna sangrienta!";
					}
					case 112:
					{
						return string.Concat("Si fuera más joven, invitaría a ", str, " a salir. Yo antes era todo un galán.");
					}
					case 113:
					{
						return "Ese sombrero rojo me resulta familiar...";
					}
					case 114:
					{
						return "Gracias otra vez por librarme de esta maldición. Sentí como si algo me hubiera saltado encima y me hubiera mordido.";
					}
					case 115:
					{
						return "Mamá siempre dijo que yo sería un buen sastre.";
					}
					case 116:
					{
						return "La vida es como un cajón de la ropa; ¡nunca sabes qué te vas a poner!";
					}
					case 117:
					{
						return "¡Desde luego bordar es una tarea difícil! ¡Si no fuera así, nadie lo haría! Eso es lo que la hace tan genial.";
					}
					case 118:
					{
						return "Sé todo lo que hay que saber sobre el negocio de la confección.";
					}
					case 119:
					{
						return "La maldición me ha convertido en un ser solitario; una vez me hice amigo de un muñeco de cuero. Lo llamaba Wilson.";
					}
					case 120:
					{
						return "Gracias por liberarme, humano. Otros duendes me ataron y me dejaron aquí. Te puedes imaginar que no nos llevamos muy bien.";
					}
					case 121:
					{
						return "¡No puedo creer que me ataran y me dejaran aquí solo por decirles que no se dirigían al este!";
					}
					case 122:
					{
						return "Ahora que soy un proscrito, ¿puedo tirar ya estas bolas de pinchos? Tengo los bolsillos destrozados.";
					}
					case 123:
					{
						return "¿Buscas un experto en artilugios? ¡Yo soy tu duende!";
					}
					case 124:
					{
						return "Gracias por tu ayuda. Tengo que dejar de vagar por ahí sin rumbo. Seguro que nos volvemos a ver.";
					}
					case 125:
					{
						return "Creía que eras más alto.";
					}
					case 126:
					{
						return string.Concat("Oye... ¿Qué trama ", str8, "? ¿Tú... has hablado con ella, por un casual?");
					}
					case 127:
					{
						return "Eh, ¿quieres un motor para tu sombrero? Creo que tengo un motor que quedaría de perlas en ese sombrero.";
					}
					case 128:
					{
						return "Ey, he oído que te gustan los cohetes y las bota de correr, ¿por qué no te pongo unos cohetes en las botas?";
					}
					case 129:
					{
						return "El silencio es oro. Lo que daría por un poco de cinta adhesiva...";
					}
					case 130:
					{
						return "Pues claro, el oro es más resistente que el hierro. ¿Pero qué os enseñan estos humanos de hoy?";
					}
					case 131:
					{
						return "En fin, la idea de un casco de minero con alas quedaba mucho mejor sobre el papel.";
					}
					case 132:
					{
						return "Los duendes tienen un increíble predisposición al enfado. ¡De hecho, podrían declarar una guerra por una discusión sobre ropa!";
					}
					case 133:
					{
						return "Sinceramente, la mayoría de los duendes no son precisamente ingenieros de cohetes. Bueno, algunos sí.";
					}
					case 134:
					{
						return "¿Tú sabes por qué llevamos estas bolas con pinchos? Porque yo no.";
					}
					case 135:
					{
						return "¡Acabo de terminar mi última creación! Esta versión no explota con violencia si respiras encima con fuerza.";
					}
					case 136:
					{
						return "Los duendes ladrones no son muy buenos en lo suyo. ¡Ni siquiera saben robar un cofre abierto!";
					}
					case 137:
					{
						return "¡Gracias por salvarme, amigo! Estas ataduras me estaban haciendo rozaduras.";
					}
					case 138:
					{
						return "¡Oh, mi héroe!";
					}
					case 139:
					{
						return "¡Oh, qué heroico! ¡Gracias por salvarme, jovencita!";
					}
					case 140:
					{
						return "¡Oh, qué heroico por su parte! ¡Gracias por salvarme, jovencito!";
					}
					case 141:
					{
						return "Ahora que nos conocemos, ¿me puedo ir a vivir contigo, verdad?";
					}
					case 142:
					{
						return string.Concat("¡Eh, hola, ", str6, " ! ¿Qué puedo hacer hoy por ti?");
					}
					case 143:
					{
						return string.Concat("¡Eh, hola, ", str4, "! ¿Qué puedo hacer hoy por ti?");
					}
					case 144:
					{
						return string.Concat("¡Eh, hola, ", str7, "! ¿Qué puedo hacer hoy por ti?");
					}
					case 145:
					{
						return string.Concat("¡Eh, hola, ", str, "! ¿Qué puedo hacer hoy por ti?");
					}
					case 146:
					{
						return string.Concat("¡Eh, hola, ", str8, "! ¿Qué puedo hacer hoy por ti?");
					}
					case 147:
					{
						return string.Concat("¡Eh, hola, ", str3, "! ¿Qué puedo hacer hoy por ti?");
					}
					case 148:
					{
						return "¿Quieres que saque una moneda de detrás de tu oreja? ¿No? Está bien.";
					}
					case 149:
					{
						return "¿Quieres un caramelo mágico? ¿No? Vale.";
					}
					case 150:
					{
						return "Si te gusta, mejor te hago un delicioso chocolate calentito... ¿Tampoco? Vale, está bien.";
					}
					case 151:
					{
						return "¿Has venido a echar un ojo a mi bola de cristal?";
					}
					case 152:
					{
						return "¿Nunca has deseado tener un anillo mágico que convierta las piedras en babosas? La verdad es que yo tampoco.";
					}
					case 153:
					{
						return "Una vez me dijeron que la amistad es algo mágico. ¡Ridículo! No puedes convertir a nadie en rana con la amistad.";
					}
					case 154:
					{
						return "Veo tu futuro... ¡Vas a comprarme un montón de artículos!";
					}
					case 155:
					{
						return "En cierta ocasión intenté devolverle la vida a una estatua de ángel. Pero no pasó nada.";
					}
					case 156:
					{
						return "¡Gracias! Era cuestión de tiempo que acabar como los demás esqueletos de ahí abajo.";
					}
					case 157:
					{
						return "¡Eh, mira por donde vas! ¡Llevo ahí desde hace... un rato!";
					}
					case 158:
					{
						return "Espera un momento, más abajo tengo wifi.";
					}
					case 159:
					{
						return "¡Casi había acabado de poner luces intermitentes aquí arriba!";
					}
					case 160:
					{
						return "NO TE MUEVAS. DEJÉ CAER MI LENTE DE CONTACTO.";
					}
					case 161:
					{
						return "Lo único que quiero es que el conmutador haga... ¿Qué?";
					}
					case 162:
					{
						return "A ver si lo adivino. No has comprado suficiente cable. ¡Serás tonto!";
					}
					case 163:
					{
						return "¿Podrías...? Solo... ¿Por favor...? ¿Vale? Está bien. Arrg.";
					}
					case 164:
					{
						return "No me gusta cómo me miras. Ahora estoy TRABAJANDO.";
					}
					case 165:
					{
						string[] strArrays10 = new string[] { "Eh, ", Main.player[Main.myPlayer].name, "¿acabas de llegar de la casa de ", str7, "? ¿Por casualidad no te hablaría de mí?" };
						return string.Concat(strArrays10);
					}
					case 166:
					{
						return string.Concat(str2, " sigue insistiendo en pulir mi chapa de presión. Ya le he dicho que funciona pisándola.");
					}
					case 167:
					{
						return "¡Siempre compras más cable del que necesitas!";
					}
					case 168:
					{
						return "¿Has comprobado que ese dispositivo esté enchufado?";
					}
					case 169:
					{
						return "Oh, ¿sabes lo que necesita esta casa? Más luces intermitentes.";
					}
					case 170:
					{
						return "Sabrás que se avecina una luna sangrienta cuando el cielo se tiña de rojo. Hay algo en ella que hace que los monstruos ataquen en grupo.";
					}
					case 171:
					{
						return "Eh, amigo, ¿sabes dónde hay por aquí malahierba? Oh, no es por nada, solo preguntaba, nada más.";
					}
					case 172:
					{
						return "Si miraras hacia arriba, verías que ahora mismo la luna está roja.";
					}
					case 173:
					{
						return "Deberías quedarte en casa por la noche. Es muy peligroso andar por ahí en la oscuridad.";
					}
					case 174:
					{
						return string.Concat("Saludos, ", Main.player[Main.myPlayer].name, ". ¿Te puedo ayudar en algo?");
					}
					case 175:
					{
						return "Estoy aquí para aconsejarte sobre lo que debes ir haciendo. Te aconsejo que hables conmigo cuando estés atascado.";
					}
					case 176:
					{
						return "Dicen que hay una persona que te dirá cómo sobrevivir en esta tierra... oh, espera, sí soy yo.";
					}
					case 177:
					{
						return "Puedes usar el pico para cavar en la tierra y el hacha para talar árboles. Sitúa el cursor sobre el ladrillo y haz clic.";
					}
					case 178:
					{
						return "Si quieres sobrevivir, tendrás que crear armas y un refugio. Empieza talando árboles y recogiendo madera.";
					}
					case 179:
					{
						return "Pulsa ESC para acceder al menú de producción. Cuando tengas suficiente madera, crea un banco de trabajo, de este modo podrás crear otros objetos más elaborados siempre que permanezcas cerca del banco.";
					}
					case 180:
					{
						return "Puedes construir un refugio juntando madera y otros bloques que hay por el mundo. No olvides levantar y colocar paredes.";
					}
					case 181:
					{
						return "En cuanto tengas una espada de madera, puedes intentar recoger la baba de las babosas. Mezcla madera y baba para hacer una antorcha.";
					}
					case 182:
					{
						return "Para interactuar con el entorno y colocar objetos usa un martillo.";
					}
					case 183:
					{
						return "Deberías cavar una mina para encontrar mena de oro, con ella puedes crear objetos muy útiles.";
					}
					case 184:
					{
						return "Ahora que tienes un poco de oro, tendrás que convertirlo en un lingote para poder hacer objetos con él. Para ello necesitas un horno.";
					}
					case 185:
					{
						return "Puedes construir un horno con antorchas, madera y piedra. Asegúrate de no alejarte del banco de trabajo.";
					}
					case 186:
					{
						return "Necesitarás un yunque para crear objetos con los lingotes de metal.";
					}
					case 187:
					{
						return "Los yunques se pueden hacer de hierro o bien comprarse a un mercader.";
					}
					case 188:
					{
						return "En el Subsuelo hay corazones de cristal que puedes usar para aumentar al máximo tu vida. Para recogerlos, necesitarás un martillo.";
					}
					case 189:
					{
						return "Si recoges 10 estrellas caídas, podrás combinarlas para crear un objeto que aumente tu poder mágico.";
					}
					case 190:
					{
						return "Las estrellas caen del cielo a la tierra por la noche. Se pueden utilizar para toda clase de objetos útiles. Si ves una, date prisa en cogerla ya que desaparecen al amanecer.";
					}
					case 191:
					{
						return "Hay muchas formas de hacer que los demás se muden a nuestra ciudad. Por supuesto, necesitarán una casa en la que vivir.";
					}
					case 192:
					{
						return "Para que una habitación pueda ser considerada un hogar, debe tener una puerta, una silla, una mesa y una fuente de luz. No te olvides de las paredes de la casa.";
					}
					case 193:
					{
						return "En la misma casa no pueden vivir dos personas. Además, si se destruye una casa, esa persona deberá buscar un nuevo lugar donde vivir.";
					}
					case 194:
					{
						return "En la interfaz de vivienda puedes ver y asignar viviendas. Abre tu inventario y haz clic en el icono de casa.";
					}
					case 195:
					{
						return "Si quieres que un mercader se mude a una casa, deberás recoger una gran cantidad de dinero. Bastarán con 50 monedas de plata.";
					}
					case 196:
					{
						return "Para que se mude una enfermera, tendrías que aumentar al máximo tu nivel de vida.";
					}
					case 197:
					{
						return "Si tuvieras alguna pistola, seguro que aparecería algún traficante de armas para venderte municiones.";
					}
					case 198:
					{
						return "Deberías ponerte a prueba y derrotar a un monstruo corpulento. Eso llamaría la atención de una dríada.";
					}
					case 199:
					{
						return "Asegúrate de explorar la mazmorra a fondo. Podría haber prisioneros retenidos en la parte más profunda.";
					}
					case 200:
					{
						return "Quizás el anciano de la mazmorra quiera unirse a nosotros ahora que su maldición ha desaparecido.";
					}
					case 201:
					{
						return "Guarda bien las bombas que encuentres. Algún dinamitero querrá echarles un vistazo.";
					}
					case 202:
					{
						return "¿En realidad los duendes son tan distintos a nosotros que no podríamos vivir juntos en paz?";
					}
					case 203:
					{
						return "He oído que por esta región vive un poderoso mago. Estate muy atento por si lo ves la próxima vez que viajes al Subsuelo.";
					}
					case 204:
					{
						return "Si juntas varios lentes en un altar demoníaco, probablemente encuentres la forma de invocar a un monstruo poderoso. Aunque te conviene esperar hasta la noche para hacerlo.";
					}
					case 205:
					{
						return "Puedes hacer cebo de gusanos con trozos podridos y polvo vil. Asegúrate de estar en una zona corrompida antes de usarlo.";
					}
					case 206:
					{
						return "Los altares demoníacos se suelen encontrar en La Corrupción. Deberás estar cerca de los altares para crear objetos nuevos.";
					}
					case 207:
					{
						return "Puedes hacerte un garfio extensible con un garfio y 3 cadenas. Los esqueletos se encuentran en las profundidades del Subsuelo y suelen llevar garfios; se pueden hacer cadenas con lingotes de hierro.";
					}
					case 208:
					{
						return "Si ves un jarron, ábrelo aunque sea a golpes. Contienen toda clase de suministros de utilidad.";
					}
					case 209:
					{
						return "Hay un tesoro escondido por el mundo. ¡En las profundidades del Subsuelo se pueden encontrar objetos maravillosos!";
					}
					case 210:
					{
						return "Romper un orbe de las sombras a veces provoca la caída de un meteorito del cielo. Los orbes de las sombras se suelen encontrar en los abismos que rodean las zonas corrompidas";
					}
					case 211:
					{
						return "Deberías dedicarte a recoger más corazones de cristal para aumentar tu nivel de vida hasta el máximo.";
					}
					case 212:
					{
						return "El equipo que llevas sencillamente no sirve. Debes mejorar tu armadura.";
					}
					case 213:
					{
						return "Creo que ya estás listo para tu primer gran batalla. Recoge de noche algunas lentes de los ojos y llévalas a un altar demoníaco.";
					}
					case 214:
					{
						return "Te conviene aumentar tu nivel de vida antes de enfrentarte al siguiente desafío. Con 15 corazones bastará.";
					}
					case 215:
					{
						return "La piedra de ébano que se encuentra en La Corrupción se puede purificar usando un poco de polvo de una dríada, o bien puedes destruirla con explosivos.";
					}
					case 216:
					{
						return "El siguiente paso debería ser explorar los abismos corrompidos. Encuentra y destruye todos los orbes de las sombras que encuentres.";
					}
					case 217:
					{
						return "No muy lejos de aquí hay una antigua mazmorra. Ahora sería un buen momento para ir a echar un vistazo.";
					}
					case 218:
					{
						return "Deberías intentar aumentar al máximo el nivel de vida que te queda. Prueba con 20 corazones.";
					}
					case 219:
					{
						return "Hay muchos tesoros por descubrir en la selva si estás dispuesto a cavar a suficiente profundidad.";
					}
					case 220:
					{
						return "El Inframundo se compone de un material llamado piedra infernal, perfecta para hacer armas y armaduras.";
					}
					case 221:
					{
						return "Cuando estés preparado para desafiar al guardián del Inframundo, tendrás que hacer un sacrificio viviente. Todo lo que necesitas para hacerlo lo encontrarás en el Inframundo.";
					}
					case 222:
					{
						return "No dejes de destruir todos los altares demoníacos que encuentres. ¡Algo bueno te sucederá si lo haces!";
					}
					case 223:
					{
						return "A veces las almas se congregan en las criaturas caídas, en lugares de extrema luminosidad u oscuridad.";
					}
					case 224:
					{
						return "Ho ho ho y una botella de ... Ponche de huevo!";
					}
					case 225:
					{
						return "Cuidado que me galletitas?";
					}
					case 226:
					{
						return "¿Qué? Pensaste que no era real?";
					}
					case 227:
					{
						return "Me las arreglé para coser la cara de nuevo. Tener más cuidado la próxima vez.";
					}
					case 228:
					{
						return "Que probablemente va a dejar una cicatriz.";
					}
					case 229:
					{
						return "Todos los mejores. No quiero verte saltar ya los acantilados.";
					}
					case 230:
					{
						return "Que no le dolía demasiado malo, ya lo hizo?";
					}
					case 231:
					{
						return "Como si vivir bajo tierra no fuera suficientemente malo, idiotas como tú vienes mientras duermo y robar mis hijos.";
					}
					case 232:
					{
						return string.Concat("Entre tú y yo, ", str3, " es el único en quien confío. Ella es el único aquí que no se ha probado a comer o me utilice en una poción.");
					}
					case 233:
					{
						return "Traté de lamer mi mismo el otro día para ver lo que era la gran cosa, todo empezó azul brillante.";
					}
					case 234:
					{
						return "Cada vez que veo el color azul, que me hace deprimido y perezoso.";
					}
					case 235:
					{
						return "Usted no ha visto ningún cerdo de por aquí tienen ustedes? Mi hermano perdió la pierna a uno.";
					}
					case 236:
					{
						return "Todo el mundo en esta ciudad se siente un poco fuera. Me desperté a la fabricante de ropa de mascar en mi pie anoche.";
					}
					case 237:
					{
						return string.Concat("Te voy a dar un descuento en su desgastes si se puede convencer a ", str9, " venir a un ... tamaño.");
					}
					case 238:
					{
						return string.Concat("Me siento como ", str9, " es un poco incomprendido, que realmente es un tipo divertido.");
					}
					case 240:
					{
						return "No sé la Truffle Shuffle, así que deja de preguntar!";
					}
					case 241:
					{
						return "Ha habido un enorme rumor de tal manera que está siendo difundida por mí, 'Si no puedes vencerlo, comérselo!";
					}
					case 242:
					{
						return "Oy, ¿qué tienes en tu fluffer jiminy?";
					}
					case 243:
					{
						return "Debería convertirse en un pirata del aire? He pensado en convertirse en un pirata del aire.";
					}
					case 244:
					{
						return "Ya se trate de lo que sería, un jetpack que se adapte muy bien!";
					}
					case 245:
					{
						return "Me siento un poco mal humor en los últimos tiempos, por lo que basta con su palabrería que ragamuffin!";
					}
					case 246:
					{
						return string.Concat("Estoy muy curioso acerca de ese tipo ", str11, ". ¿Con qué tipo de consumo no se mantiene como la locomoción?");
					}
					case 247:
					{
						return "Ese tipo capitán me parece ser bastante bien a la bahía si sabes lo que quiero decir!";
					}
					case 248:
					{
						return "Muéstrame algunas artes!";
					}
					case 249:
					{
						return "Me gusta su ... engranajes. ¿Viene en bronce?";
					}
					case 250:
					{
						return "Una vez que ingrese la tierra santificada, verá un arco iris en el cielo. Te puedo ayudar con la pintura que, si lo desea.";
					}
					case 251:
					{
						return string.Concat("Echa un vistazo a ", str10, ". Eso sí que es una chica que es capaz de pintar la ciudad de rojo!");
					}
					case 252:
					{
						return "Conozco la diferencia entre turquesa y azul-verde. Pero no voy a decirte.";
					}
					case 253:
					{
						return "Estoy de blanco de titanio, por lo que ni siquiera preguntar.";
					}
					case 254:
					{
						return "Pruebe swirly rosa y púrpura, que funciona, lo juro!";
					}
					case 255:
					{
						return "No, no, no ... Hay toneladas de diferentes grises! No me refiero a ...";
					}
					case 256:
					{
						return "Espero que no llueva otra vez hasta que esta pintura seca. Eso sería un desastre!";
					}
					case 257:
					{
						return "Les traigo los colores más ricos a cambio de sus riquezas!";
					}
					case 258:
					{
						return "Querida, lo que llevas puesto es demasiado monótono. Es absolutamente necesario tomar una lección en el teñido de su traje cansado!";
					}
					case 259:
					{
						return "El único tipo de madera me molesta es teñido de caoba. Teñido cualquier otra madera es un desperdicio.";
					}
					case 260:
					{
						return string.Concat("Tienes que hacer algo con ", str12, ".  Cada vez que venga por aquí, me lleva una semana para conseguir el olor de descuento!");
					}
					case 261:
					{
						return "¿Qué médico soy yo? El médico brujo que soy.";
					}
					case 262:
					{
						return "El corazón de la magia es la naturaleza. La naturaleza de los corazones es magia.";
					}
					case 263:
					{
						return string.Concat(str, " puede ayudar a sanar su cuerpo, pero puedo hacer que encarnan la curación.");
					}
					case 264:
					{
						return string.Concat("Elija con cuidado, ", Main.player[Main.myPlayer].name, ", mis productos son volátiles y mi arte oscuro, misterioso.");
					}
					case 265:
					{
						return "Tenemos que hablar. Es ... se trata de los partidos.";
					}
					case 266:
					{
						return "No puedo decidir lo que me gusta más: las partes, o después de los partidos.";
					}
					case 267:
					{
						return "Debemos crear un grupo de blinkroot, y también hay que establecer un después de la fiesta.";
					}
					case 268:
					{
						return string.Concat("Wow, ", Main.player[Main.myPlayer].name, ", encontrarse con un hombre aventurero como tú me da ganas de fiesta!");
					}
					case 269:
					{
						return "Ponga una bola de discoteca y luego te voy a mostrar cómo divertirse.";
					}
					case 270:
					{
						return "Fui a Suecia una vez, el partido duro, ¿por qué no te parece?";
					}
					case 271:
					{
						return string.Concat("Mi nombre es ", str10, " pero la gente me llama partido popper. Sí. No sé, suena guay");
					}
					case 272:
					{
						return "¿Es usted parte? A veces? Hm, bien entonces podemos hablar ...";
					}
					case 273:
					{
						return "No soy un amante de la tierra, pero es mejor haber amado y perdido que nunca de amar a todos.";
					}
					case 274:
					{
						return "Yo ho ho y una botella de ...blinkroots!";
					}
					case 275:
					{
						return "YAR!  Es curioso que lo mencionaremos loros porque ... um ... ¿De qué estábamos hablando?";
					}
					case 276:
					{
						return string.Concat(Main.player[Main.myPlayer].name, ", Vosotros sois una de las mejores jovencitas buscan esto aquí capitán ha visto en muchas de quince días!");
					}
					case 277:
					{
						return "Manténgase fuera de mí botín, que Canalla!";
					}
					case 278:
					{
						return "Lo que en llamas estás hablando? Moby Dick es la mía!";
					}
					case 279:
					{
						return "*Yarr Blarr Harrdarr*";
					}
					case 280:
					{
						return "Y entonces Unidad 492-8 dijo: Quién te crees que soy, Unidad 472-6? HA. HA. HA.";
					}
					case 281:
					{
						return "Mi eficiencia expedición se redujo crítica cuando un proyectil impactó mi locomotora actuador.";
					}
					case 282:
					{
						return "Esta oración es falsa, ¿o no?";
					}
					case 283:
					{
						return "Así que 'punk chick buscando es un inventor, eh? Creo que ella pudiera mostrarle una cosa o dos!";
					}
					case 284:
					{
						return string.Concat("Claro, ", str12, " y yo somos amigos, pero no me gusta cuando su loro hace su negocio en mí. Corrosiva es esa cosa!");
					}
					case 285:
					{
						return "Yo mismo construí un mecanismo gusto, así que me puedo beber un poco de cerveza!";
					}
					case 286:
					{
						return "A veces salgo un poco ... ¿Lo entiendes? un poco?";
					}
				}
			}
			if (english || Lang.lang <= 1)
			{
				return "";
			}
			return Lang.dialog(l, true);
		}

		public static string DyeTraderQuestChat(bool gotDye = false)
		{
			string str = NPC.firstNPCName(207);
			string str1 = "";
			if (!gotDye)
			{
				switch (Main.rand.Next(3))
				{
					case 0:
					{
						str1 = "Oh no no, this will not do.  For these money is no good, you must return to me with a rare specimen of a plant!";
						break;
					}
					case 1:
					{
						str1 = string.Concat("You think you can pull a fast one on ", str, ", I don't think so! I only take the rarest of flowers for these special bottles!");
						break;
					}
					case 2:
					{
						str1 = "These dye bottles? Sorry dear friend, these don't take coin. I only take the most precious and rare of flora in exchange for one of this!";
						break;
					}
				}
			}
			else
			{
				switch (Main.rand.Next(3))
				{
					case 0:
					{
						str1 = "Brilliant, my dear! You have brought me an exquisite sample of the world's beautiful colors and aroma. In exchange, you may take this special bottle of dye.";
						break;
					}
					case 1:
					{
						str1 = "You bring me a beautiful, rare flower... yes, yes? Take this bottle of special dye for your troubles, friend!";
						break;
					}
					case 2:
					{
						str1 = string.Concat("Fantabulous, wonderful friend! With this delicate specimen, I may mix the most amazing dyes ", Main.worldName, " has ever seen! You may take this one right away!");
						break;
					}
				}
			}
			return str1;
		}

		public static string evilGood()
		{
			if (Lang.lang <= 1)
			{
				string str = "";
				int num = WorldGen.tGood;
				int num1 = WorldGen.tEvil;
				int num2 = WorldGen.tBlood;
				if (num > 0 && num1 > 0 && num2 > 0)
				{
					object[] objArray = new object[] { Main.worldName, " is ", num, "% hallow, ", num1, "% corrupt, and ", num2, "% crimson." };
					str = string.Concat(objArray);
				}
				else if (num > 0 && num1 > 0)
				{
					object[] objArray1 = new object[] { Main.worldName, " is ", num, "% hallow and ", num1, "% corrupt." };
					str = string.Concat(objArray1);
				}
				else if (num > 0 && num2 > 0)
				{
					object[] objArray2 = new object[] { Main.worldName, " is ", num, "% hallow and ", num2, "% crimson." };
					str = string.Concat(objArray2);
				}
				else if (num1 > 0 && num2 > 0)
				{
					object[] objArray3 = new object[] { Main.worldName, " is ", num1, "% corrupt and ", num2, "% crimson." };
					str = string.Concat(objArray3);
				}
				else if (num1 > 0)
				{
					object[] objArray4 = new object[] { Main.worldName, " is ", num1, "% corrupt." };
					str = string.Concat(objArray4);
				}
				else if (num2 <= 0)
				{
					if (num <= 0)
					{
						str = string.Concat(Main.worldName, " is completely pure. You have done an amazing job!");
						return str;
					}
					object[] objArray5 = new object[] { Main.worldName, " is ", num, "% hallow." };
					str = string.Concat(objArray5);
				}
				else
				{
					object[] objArray6 = new object[] { Main.worldName, " is ", num2, "% crimson." };
					str = string.Concat(objArray6);
				}
				if ((double)num * 1.2 >= (double)(num1 + num2) && (double)num * 0.8 <= (double)(num1 + num2))
				{
					str = string.Concat(str, " The world is in balance.");
				}
				else if (num >= num1 + num2)
				{
					str = string.Concat(str, " We are living in a fairy tale.");
				}
				else if (num1 + num2 <= num + 20)
				{
					str = (num1 + num2 <= 10 ? string.Concat(str, " You are so close!") : string.Concat(str, " You have a lot of work to do."));
				}
				else
				{
					str = string.Concat(str, " Things are grim indeed...");
				}
				return str;
			}
			if (Lang.lang == 2)
			{
				string str1 = "";
				if (WorldGen.tGood == 0)
				{
					object[] objArray7 = new object[] { Main.worldName, " ist zu ", WorldGen.tEvil, "% verderbt." };
					str1 = string.Concat(objArray7);
				}
				else if (WorldGen.tEvil != 0)
				{
					object[] objArray8 = new object[] { Main.worldName, " ist zu ", WorldGen.tGood, "% gesegnet und zu ", WorldGen.tEvil, "% verderbt." };
					str1 = string.Concat(objArray8);
				}
				else
				{
					object[] objArray9 = new object[] { Main.worldName, " ist zu ", WorldGen.tGood, "% gesegnet." };
					str1 = string.Concat(objArray9);
				}
				if (WorldGen.tGood <= WorldGen.tEvil)
				{
					str1 = (WorldGen.tEvil <= WorldGen.tGood || WorldGen.tEvil <= 20 ? string.Concat(str1, " Streng dich mehr an!") : string.Concat(str1, " Es steht nicht gut."));
				}
				else
				{
					str1 = string.Concat(str1, " Gute Arbeit, weiter so!");
				}
				return str1;
			}
			if (Lang.lang == 3)
			{
				string str2 = "";
				if (WorldGen.tGood == 0)
				{
					object[] objArray10 = new object[] { Main.worldName, " è distrutto al ", WorldGen.tEvil, "%." };
					str2 = string.Concat(objArray10);
				}
				else if (WorldGen.tEvil != 0)
				{
					object[] objArray11 = new object[] { Main.worldName, " è santo al ", WorldGen.tGood, "% e distrutto al ", WorldGen.tEvil, "%." };
					str2 = string.Concat(objArray11);
				}
				else
				{
					object[] objArray12 = new object[] { Main.worldName, " è santo al ", WorldGen.tGood, "%." };
					str2 = string.Concat(objArray12);
				}
				if (WorldGen.tGood <= WorldGen.tEvil)
				{
					str2 = (WorldGen.tEvil <= WorldGen.tGood || WorldGen.tEvil <= 20 ? string.Concat(str2, " Dovresti impegnarti di più.") : string.Concat(str2, " Le cose vanno male."));
				}
				else
				{
					str2 = string.Concat(str2, " Continua così!");
				}
				return str2;
			}
			if (Lang.lang == 4)
			{
				string str3 = "";
				if (WorldGen.tGood == 0)
				{
					object[] objArray13 = new object[] { Main.worldName, " est corrompu à ", WorldGen.tEvil, "%." };
					str3 = string.Concat(objArray13);
				}
				else if (WorldGen.tEvil != 0)
				{
					object[] objArray14 = new object[] { Main.worldName, " est purifié à ", WorldGen.tGood, "% et corrompu à ", WorldGen.tEvil, "%." };
					str3 = string.Concat(objArray14);
				}
				else
				{
					object[] objArray15 = new object[] { Main.worldName, " est purifié à ", WorldGen.tGood, "%." };
					str3 = string.Concat(objArray15);
				}
				if (WorldGen.tGood <= WorldGen.tEvil)
				{
					str3 = (WorldGen.tEvil <= WorldGen.tGood || WorldGen.tEvil <= 20 ? string.Concat(str3, " Essayez encore.") : string.Concat(str3, " En effet, c'est pas la joie."));
				}
				else
				{
					str3 = string.Concat(str3, " Continuez comme ça.");
				}
				return str3;
			}
			if (Lang.lang != 5)
			{
				return "";
			}
			string str4 = "";
			if (WorldGen.tGood == 0)
			{
				object[] objArray16 = new object[] { Main.worldName, " ha sido corrompido por ", WorldGen.tEvil, "%." };
				str4 = string.Concat(objArray16);
			}
			else if (WorldGen.tEvil != 0)
			{
				object[] objArray17 = new object[] { Main.worldName, " ha sido bendecido por ", WorldGen.tGood, "% y corrompido por ", WorldGen.tEvil, "%." };
				str4 = string.Concat(objArray17);
			}
			else
			{
				object[] objArray18 = new object[] { Main.worldName, " ha sido bendecido por ", WorldGen.tGood, "%." };
				str4 = string.Concat(objArray18);
			}
			if (WorldGen.tGood <= WorldGen.tEvil)
			{
				str4 = (WorldGen.tEvil <= WorldGen.tGood || WorldGen.tEvil <= 20 ? string.Concat(str4, " Deberías esforzarte más.") : string.Concat(str4, " Es bastante desalentador."));
			}
			else
			{
				str4 = string.Concat(str4, " ¡Sigue haciéndolo bien!");
			}
			return str4;
		}

		public static string itemName(int l, bool english = false)
		{
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
					case -48:
					{
						return "Platinum Bow";
					}
					case -47:
					{
						return "Platinum Hammer";
					}
					case -46:
					{
						return "Platinum Axe";
					}
					case -45:
					{
						return "Platinum Shortsword";
					}
					case -44:
					{
						return "Platinum Broadsword";
					}
					case -43:
					{
						return "Platinum Pickaxe";
					}
					case -42:
					{
						return "Tungsten Bow";
					}
					case -41:
					{
						return "Tungsten Hammer";
					}
					case -40:
					{
						return "Tungsten Axe";
					}
					case -39:
					{
						return "Tungsten Shortsword";
					}
					case -38:
					{
						return "Tungsten Broadsword";
					}
					case -37:
					{
						return "Tungsten Pickaxe";
					}
					case -36:
					{
						return "Lead Bow";
					}
					case -35:
					{
						return "Lead Hammer";
					}
					case -34:
					{
						return "Lead Axe";
					}
					case -33:
					{
						return "Lead Shortsword";
					}
					case -32:
					{
						return "Lead Broadsword";
					}
					case -31:
					{
						return "Lead Pickaxe";
					}
					case -30:
					{
						return "Tin Bow";
					}
					case -29:
					{
						return "Tin Hammer";
					}
					case -28:
					{
						return "Tin Axe";
					}
					case -27:
					{
						return "Tin Shortsword";
					}
					case -26:
					{
						return "Tin Broadsword";
					}
					case -25:
					{
						return "Tin Pickaxe";
					}
					case -24:
					{
						return "Yellow Phasesaber";
					}
					case -23:
					{
						return "White Phasesaber";
					}
					case -22:
					{
						return "Purple Phasesaber";
					}
					case -21:
					{
						return "Green Phasesaber";
					}
					case -20:
					{
						return "Red Phasesaber";
					}
					case -19:
					{
						return "Blue Phasesaber";
					}
					case -18:
					{
						return "Copper Bow";
					}
					case -17:
					{
						return "Copper Hammer";
					}
					case -16:
					{
						return "Copper Axe";
					}
					case -15:
					{
						return "Copper Shortsword";
					}
					case -14:
					{
						return "Copper Broadsword";
					}
					case -13:
					{
						return "Copper Pickaxe";
					}
					case -12:
					{
						return "Silver Bow";
					}
					case -11:
					{
						return "Silver Hammer";
					}
					case -10:
					{
						return "Silver Axe";
					}
					case -9:
					{
						return "Silver Shortsword";
					}
					case -8:
					{
						return "Silver Broadsword";
					}
					case -7:
					{
						return "Silver Pickaxe";
					}
					case -6:
					{
						return "Gold Bow";
					}
					case -5:
					{
						return "Gold Hammer";
					}
					case -4:
					{
						return "Gold Axe";
					}
					case -3:
					{
						return "Gold Shortsword";
					}
					case -2:
					{
						return "Gold Broadsword";
					}
					case -1:
					{
						return "Gold Pickaxe";
					}
					case 1:
					{
						return "Iron Pickaxe";
					}
					case 2:
					{
						return "Dirt Block";
					}
					case 3:
					{
						return "Stone Block";
					}
					case 4:
					{
						return "Iron Broadsword";
					}
					case 5:
					{
						return "Mushroom";
					}
					case 6:
					{
						return "Iron Shortsword";
					}
					case 7:
					{
						return "Iron Hammer";
					}
					case 8:
					{
						return "Torch";
					}
					case 9:
					{
						return "Wood";
					}
					case 10:
					{
						return "Iron Axe";
					}
					case 11:
					{
						return "Iron Ore";
					}
					case 12:
					{
						return "Copper Ore";
					}
					case 13:
					{
						return "Gold Ore";
					}
					case 14:
					{
						return "Silver Ore";
					}
					case 15:
					{
						return "Copper Watch";
					}
					case 16:
					{
						return "Silver Watch";
					}
					case 17:
					{
						return "Gold Watch";
					}
					case 18:
					{
						return "Depth Meter";
					}
					case 19:
					{
						return "Gold Bar";
					}
					case 20:
					{
						return "Copper Bar";
					}
					case 21:
					{
						return "Silver Bar";
					}
					case 22:
					{
						return "Iron Bar";
					}
					case 23:
					{
						return "Gel";
					}
					case 24:
					{
						return "Wooden Sword";
					}
					case 25:
					{
						return "Wooden Door";
					}
					case 26:
					{
						return "Stone Wall";
					}
					case 27:
					{
						return "Acorn";
					}
					case 28:
					{
						return "Lesser Healing Potion";
					}
					case 29:
					{
						return "Life Crystal";
					}
					case 30:
					{
						return "Dirt Wall";
					}
					case 31:
					{
						return "Bottle";
					}
					case 32:
					{
						return "Wooden Table";
					}
					case 33:
					{
						return "Furnace";
					}
					case 34:
					{
						return "Wooden Chair";
					}
					case 35:
					{
						return "Iron Anvil";
					}
					case 36:
					{
						return "Work Bench";
					}
					case 37:
					{
						return "Goggles";
					}
					case 38:
					{
						return "Lens";
					}
					case 39:
					{
						return "Wooden Bow";
					}
					case 40:
					{
						return "Wooden Arrow";
					}
					case 41:
					{
						return "Flaming Arrow";
					}
					case 42:
					{
						return "Shuriken";
					}
					case 43:
					{
						return "Suspicious Looking Eye";
					}
					case 44:
					{
						return "Demon Bow";
					}
					case 45:
					{
						return "War Axe of the Night";
					}
					case 46:
					{
						return "Light's Bane";
					}
					case 47:
					{
						return "Unholy Arrow";
					}
					case 48:
					{
						return "Chest";
					}
					case 49:
					{
						return "Band of Regeneration";
					}
					case 50:
					{
						return "Magic Mirror";
					}
					case 51:
					{
						return "Jester's Arrow";
					}
					case 52:
					{
						return "Angel Statue";
					}
					case 53:
					{
						return "Cloud in a Bottle";
					}
					case 54:
					{
						return "Hermes Boots";
					}
					case 55:
					{
						return "Enchanted Boomerang";
					}
					case 56:
					{
						return "Demonite Ore";
					}
					case 57:
					{
						return "Demonite Bar";
					}
					case 58:
					{
						return "Heart";
					}
					case 59:
					{
						return "Corrupt Seeds";
					}
					case 60:
					{
						return "Vile Mushroom";
					}
					case 61:
					{
						return "Ebonstone Block";
					}
					case 62:
					{
						return "Grass Seeds";
					}
					case 63:
					{
						return "Sunflower";
					}
					case 64:
					{
						return "Vilethorn";
					}
					case 65:
					{
						return "Starfury";
					}
					case 66:
					{
						return "Purification Powder";
					}
					case 67:
					{
						return "Vile Powder";
					}
					case 68:
					{
						return "Rotten Chunk";
					}
					case 69:
					{
						return "Worm Tooth";
					}
					case 70:
					{
						return "Worm Food";
					}
					case 71:
					{
						return "Copper Coin";
					}
					case 72:
					{
						return "Silver Coin";
					}
					case 73:
					{
						return "Gold Coin";
					}
					case 74:
					{
						return "Platinum Coin";
					}
					case 75:
					{
						return "Fallen Star";
					}
					case 76:
					{
						return "Copper Greaves";
					}
					case 77:
					{
						return "Iron Greaves";
					}
					case 78:
					{
						return "Silver Greaves";
					}
					case 79:
					{
						return "Gold Greaves";
					}
					case 80:
					{
						return "Copper Chainmail";
					}
					case 81:
					{
						return "Iron Chainmail";
					}
					case 82:
					{
						return "Silver Chainmail";
					}
					case 83:
					{
						return "Gold Chainmail";
					}
					case 84:
					{
						return "Grappling Hook";
					}
					case 85:
					{
						return "Chain";
					}
					case 86:
					{
						return "Shadow Scale";
					}
					case 87:
					{
						return "Piggy Bank";
					}
					case 88:
					{
						return "Mining Helmet";
					}
					case 89:
					{
						return "Copper Helmet";
					}
					case 90:
					{
						return "Iron Helmet";
					}
					case 91:
					{
						return "Silver Helmet";
					}
					case 92:
					{
						return "Gold Helmet";
					}
					case 93:
					{
						return "Wood Wall";
					}
					case 94:
					{
						return "Wood Platform";
					}
					case 95:
					{
						return "Flintlock Pistol";
					}
					case 96:
					{
						return "Musket";
					}
					case 97:
					{
						return "Musket Ball";
					}
					case 98:
					{
						return "Minishark";
					}
					case 99:
					{
						return "Iron Bow";
					}
					case 100:
					{
						return "Shadow Greaves";
					}
					case 101:
					{
						return "Shadow Scalemail";
					}
					case 102:
					{
						return "Shadow Helmet";
					}
					case 103:
					{
						return "Nightmare Pickaxe";
					}
					case 104:
					{
						return "The Breaker";
					}
					case 105:
					{
						return "Candle";
					}
					case 106:
					{
						return "Copper Chandelier";
					}
					case 107:
					{
						return "Silver Chandelier";
					}
					case 108:
					{
						return "Gold Chandelier";
					}
					case 109:
					{
						return "Mana Crystal";
					}
					case 110:
					{
						return "Lesser Mana Potion";
					}
					case 111:
					{
						return "Band of Starpower";
					}
					case 112:
					{
						return "Flower of Fire";
					}
					case 113:
					{
						return "Magic Missile";
					}
					case 114:
					{
						return "Dirt Rod";
					}
					case 115:
					{
						return "Shadow Orb";
					}
					case 116:
					{
						return "Meteorite";
					}
					case 117:
					{
						return "Meteorite Bar";
					}
					case 118:
					{
						return "Hook";
					}
					case 119:
					{
						return "Flamarang";
					}
					case 120:
					{
						return "Molten Fury";
					}
					case 121:
					{
						return "Fiery Greatsword";
					}
					case 122:
					{
						return "Molten Pickaxe";
					}
					case 123:
					{
						return "Meteor Helmet";
					}
					case 124:
					{
						return "Meteor Suit";
					}
					case 125:
					{
						return "Meteor Leggings";
					}
					case 126:
					{
						return "Bottled Water";
					}
					case 127:
					{
						return "Space Gun";
					}
					case 128:
					{
						return "Rocket Boots";
					}
					case 129:
					{
						return "Gray Brick";
					}
					case 130:
					{
						return "Gray Brick Wall";
					}
					case 131:
					{
						return "Red Brick";
					}
					case 132:
					{
						return "Red Brick Wall";
					}
					case 133:
					{
						return "Clay Block";
					}
					case 134:
					{
						return "Blue Brick";
					}
					case 135:
					{
						return "Blue Brick Wall";
					}
					case 136:
					{
						return "Chain Lantern";
					}
					case 137:
					{
						return "Green Brick";
					}
					case 138:
					{
						return "Green Brick Wall";
					}
					case 139:
					{
						return "Pink Brick";
					}
					case 140:
					{
						return "Pink Brick Wall";
					}
					case 141:
					{
						return "Gold Brick";
					}
					case 142:
					{
						return "Gold Brick Wall";
					}
					case 143:
					{
						return "Silver Brick";
					}
					case 144:
					{
						return "Silver Brick Wall";
					}
					case 145:
					{
						return "Copper Brick";
					}
					case 146:
					{
						return "Copper Brick Wall";
					}
					case 147:
					{
						return "Spike";
					}
					case 148:
					{
						return "Water Candle";
					}
					case 149:
					{
						return "Book";
					}
					case 150:
					{
						return "Cobweb";
					}
					case 151:
					{
						return "Necro Helmet";
					}
					case 152:
					{
						return "Necro Breastplate";
					}
					case 153:
					{
						return "Necro Greaves";
					}
					case 154:
					{
						return "Bone";
					}
					case 155:
					{
						return "Muramasa";
					}
					case 156:
					{
						return "Cobalt Shield";
					}
					case 157:
					{
						return "Aqua Scepter";
					}
					case 158:
					{
						return "Lucky Horseshoe";
					}
					case 159:
					{
						return "Shiny Red Balloon";
					}
					case 160:
					{
						return "Harpoon";
					}
					case 161:
					{
						return "Spiky Ball";
					}
					case 162:
					{
						return "Ball O' Hurt";
					}
					case 163:
					{
						return "Blue Moon";
					}
					case 164:
					{
						return "Handgun";
					}
					case 165:
					{
						return "Water Bolt";
					}
					case 166:
					{
						return "Bomb";
					}
					case 167:
					{
						return "Dynamite";
					}
					case 168:
					{
						return "Grenade";
					}
					case 169:
					{
						return "Sand Block";
					}
					case 170:
					{
						return "Glass";
					}
					case 171:
					{
						return "Sign";
					}
					case 172:
					{
						return "Ash Block";
					}
					case 173:
					{
						return "Obsidian";
					}
					case 174:
					{
						return "Hellstone";
					}
					case 175:
					{
						return "Hellstone Bar";
					}
					case 176:
					{
						return "Mud Block";
					}
					case 177:
					{
						return "Sapphire";
					}
					case 178:
					{
						return "Ruby";
					}
					case 179:
					{
						return "Emerald";
					}
					case 180:
					{
						return "Topaz";
					}
					case 181:
					{
						return "Amethyst";
					}
					case 182:
					{
						return "Diamond";
					}
					case 183:
					{
						return "Glowing Mushroom";
					}
					case 184:
					{
						return "Star";
					}
					case 185:
					{
						return "Ivy Whip";
					}
					case 186:
					{
						return "Breathing Reed";
					}
					case 187:
					{
						return "Flipper";
					}
					case 188:
					{
						return "Healing Potion";
					}
					case 189:
					{
						return "Mana Potion";
					}
					case 190:
					{
						return "Blade of Grass";
					}
					case 191:
					{
						return "Thorn Chakram";
					}
					case 192:
					{
						return "Obsidian Brick";
					}
					case 193:
					{
						return "Obsidian Skull";
					}
					case 194:
					{
						return "Mushroom Grass Seeds";
					}
					case 195:
					{
						return "Jungle Grass Seeds";
					}
					case 196:
					{
						return "Wooden Hammer";
					}
					case 197:
					{
						return "Star Cannon";
					}
					case 198:
					{
						return "Blue Phaseblade";
					}
					case 199:
					{
						return "Red Phaseblade";
					}
					case 200:
					{
						return "Green Phaseblade";
					}
					case 201:
					{
						return "Purple Phaseblade";
					}
					case 202:
					{
						return "White Phaseblade";
					}
					case 203:
					{
						return "Yellow Phaseblade";
					}
					case 204:
					{
						return "Meteor Hamaxe";
					}
					case 205:
					{
						return "Empty Bucket";
					}
					case 206:
					{
						return "Water Bucket";
					}
					case 207:
					{
						return "Lava Bucket";
					}
					case 208:
					{
						return "Jungle Rose";
					}
					case 209:
					{
						return "Stinger";
					}
					case 210:
					{
						return "Vine";
					}
					case 211:
					{
						return "Feral Claws";
					}
					case 212:
					{
						return "Anklet of the Wind";
					}
					case 213:
					{
						return "Staff of Regrowth";
					}
					case 214:
					{
						return "Hellstone Brick";
					}
					case 215:
					{
						return "Whoopie Cushion";
					}
					case 216:
					{
						return "Shackle";
					}
					case 217:
					{
						return "Molten Hamaxe";
					}
					case 218:
					{
						return "Flamelash";
					}
					case 219:
					{
						return "Phoenix Blaster";
					}
					case 220:
					{
						return "Sunfury";
					}
					case 221:
					{
						return "Hellforge";
					}
					case 222:
					{
						return "Clay Pot";
					}
					case 223:
					{
						return "Nature's Gift";
					}
					case 224:
					{
						return "Bed";
					}
					case 225:
					{
						return "Silk";
					}
					case 226:
					{
						return "Lesser Restoration Potion";
					}
					case 227:
					{
						return "Restoration Potion";
					}
					case 228:
					{
						return "Jungle Hat";
					}
					case 229:
					{
						return "Jungle Shirt";
					}
					case 230:
					{
						return "Jungle Pants";
					}
					case 231:
					{
						return "Molten Helmet";
					}
					case 232:
					{
						return "Molten Breastplate";
					}
					case 233:
					{
						return "Molten Greaves";
					}
					case 234:
					{
						return "Meteor Shot";
					}
					case 235:
					{
						return "Sticky Bomb";
					}
					case 236:
					{
						return "Black Lens";
					}
					case 237:
					{
						return "Sunglasses";
					}
					case 238:
					{
						return "Wizard Hat";
					}
					case 239:
					{
						return "Top Hat";
					}
					case 240:
					{
						return "Tuxedo Shirt";
					}
					case 241:
					{
						return "Tuxedo Pants";
					}
					case 242:
					{
						return "Summer Hat";
					}
					case 243:
					{
						return "Bunny Hood";
					}
					case 244:
					{
						return "Plumber's Hat";
					}
					case 245:
					{
						return "Plumber's Shirt";
					}
					case 246:
					{
						return "Plumber's Pants";
					}
					case 247:
					{
						return "Hero's Hat";
					}
					case 248:
					{
						return "Hero's Shirt";
					}
					case 249:
					{
						return "Hero's Pants";
					}
					case 250:
					{
						return "Fish Bowl";
					}
					case 251:
					{
						return "Archaeologist's Hat";
					}
					case 252:
					{
						return "Archaeologist's Jacket";
					}
					case 253:
					{
						return "Archaeologist's Pants";
					}
					case 254:
					{
						return "Black Thread";
					}
					case 255:
					{
						return "Green Thread";
					}
					case 256:
					{
						return "Ninja Hood";
					}
					case 257:
					{
						return "Ninja Shirt";
					}
					case 258:
					{
						return "Ninja Pants";
					}
					case 259:
					{
						return "Leather";
					}
					case 260:
					{
						return "Red Hat";
					}
					case 261:
					{
						return "Goldfish";
					}
					case 262:
					{
						return "Robe";
					}
					case 263:
					{
						return "Robot Hat";
					}
					case 264:
					{
						return "Gold Crown";
					}
					case 265:
					{
						return "Hellfire Arrow";
					}
					case 266:
					{
						return "Sandgun";
					}
					case 267:
					{
						return "Guide Voodoo Doll";
					}
					case 268:
					{
						return "Diving Helmet";
					}
					case 269:
					{
						return "Familiar Shirt";
					}
					case 270:
					{
						return "Familiar Pants";
					}
					case 271:
					{
						return "Familiar Wig";
					}
					case 272:
					{
						return "Demon Scythe";
					}
					case 273:
					{
						return "Night's Edge";
					}
					case 274:
					{
						return "Dark Lance";
					}
					case 275:
					{
						return "Coral";
					}
					case 276:
					{
						return "Cactus";
					}
					case 277:
					{
						return "Trident";
					}
					case 278:
					{
						return "Silver Bullet";
					}
					case 279:
					{
						return "Throwing Knife";
					}
					case 280:
					{
						return "Spear";
					}
					case 281:
					{
						return "Blowpipe";
					}
					case 282:
					{
						return "Glowstick";
					}
					case 283:
					{
						return "Seed";
					}
					case 284:
					{
						return "Wooden Boomerang";
					}
					case 285:
					{
						return "Aglet";
					}
					case 286:
					{
						return "Sticky Glowstick";
					}
					case 287:
					{
						return "Poisoned Knife";
					}
					case 288:
					{
						return "Obsidian Skin Potion";
					}
					case 289:
					{
						return "Regeneration Potion";
					}
					case 290:
					{
						return "Swiftness Potion";
					}
					case 291:
					{
						return "Gills Potion";
					}
					case 292:
					{
						return "Ironskin Potion";
					}
					case 293:
					{
						return "Mana Regeneration Potion";
					}
					case 294:
					{
						return "Magic Power Potion";
					}
					case 295:
					{
						return "Featherfall Potion";
					}
					case 296:
					{
						return "Spelunker Potion";
					}
					case 297:
					{
						return "Invisibility Potion";
					}
					case 298:
					{
						return "Shine Potion";
					}
					case 299:
					{
						return "Night Owl Potion";
					}
					case 300:
					{
						return "Battle Potion";
					}
					case 301:
					{
						return "Thorns Potion";
					}
					case 302:
					{
						return "Water Walking Potion";
					}
					case 303:
					{
						return "Archery Potion";
					}
					case 304:
					{
						return "Hunter Potion";
					}
					case 305:
					{
						return "Gravitation Potion";
					}
					case 306:
					{
						return "Gold Chest";
					}
					case 307:
					{
						return "Daybloom Seeds";
					}
					case 308:
					{
						return "Moonglow Seeds";
					}
					case 309:
					{
						return "Blinkroot Seeds";
					}
					case 310:
					{
						return "Deathweed Seeds";
					}
					case 311:
					{
						return "Waterleaf Seeds";
					}
					case 312:
					{
						return "Fireblossom Seeds";
					}
					case 313:
					{
						return "Daybloom";
					}
					case 314:
					{
						return "Moonglow";
					}
					case 315:
					{
						return "Blinkroot";
					}
					case 316:
					{
						return "Deathweed";
					}
					case 317:
					{
						return "Waterleaf";
					}
					case 318:
					{
						return "Fireblossom";
					}
					case 319:
					{
						return "Shark Fin";
					}
					case 320:
					{
						return "Feather";
					}
					case 321:
					{
						return "Tombstone";
					}
					case 322:
					{
						return "Mime Mask";
					}
					case 323:
					{
						return "Antlion Mandible";
					}
					case 324:
					{
						return "Illegal Gun Parts";
					}
					case 325:
					{
						return "The Doctor's Shirt";
					}
					case 326:
					{
						return "The Doctor's Pants";
					}
					case 327:
					{
						return "Golden Key";
					}
					case 328:
					{
						return "Shadow Chest";
					}
					case 329:
					{
						return "Shadow Key";
					}
					case 330:
					{
						return "Obsidian Brick Wall";
					}
					case 331:
					{
						return "Jungle Spores";
					}
					case 332:
					{
						return "Loom";
					}
					case 333:
					{
						return "Piano";
					}
					case 334:
					{
						return "Dresser";
					}
					case 335:
					{
						return "Bench";
					}
					case 336:
					{
						return "Bathtub";
					}
					case 337:
					{
						return "Red Banner";
					}
					case 338:
					{
						return "Green Banner";
					}
					case 339:
					{
						return "Blue Banner";
					}
					case 340:
					{
						return "Yellow Banner";
					}
					case 341:
					{
						return "Lamp Post";
					}
					case 342:
					{
						return "Tiki Torch";
					}
					case 343:
					{
						return "Barrel";
					}
					case 344:
					{
						return "Chinese Lantern";
					}
					case 345:
					{
						return "Cooking Pot";
					}
					case 346:
					{
						return "Safe";
					}
					case 347:
					{
						return "Skull Lantern";
					}
					case 348:
					{
						return "Trash Can";
					}
					case 349:
					{
						return "Candelabra";
					}
					case 350:
					{
						return "Pink Vase";
					}
					case 351:
					{
						return "Mug";
					}
					case 352:
					{
						return "Keg";
					}
					case 353:
					{
						return "Ale";
					}
					case 354:
					{
						return "Bookcase";
					}
					case 355:
					{
						return "Throne";
					}
					case 356:
					{
						return "Bowl";
					}
					case 357:
					{
						return "Bowl of Soup";
					}
					case 358:
					{
						return "Toilet";
					}
					case 359:
					{
						return "Grandfather Clock";
					}
					case 360:
					{
						return "Armor Statue";
					}
					case 361:
					{
						return "Goblin Battle Standard";
					}
					case 362:
					{
						return "Tattered Cloth";
					}
					case 363:
					{
						return "Sawmill";
					}
					case 364:
					{
						return "Cobalt Ore";
					}
					case 365:
					{
						return "Mythril Ore";
					}
					case 366:
					{
						return "Adamantite Ore";
					}
					case 367:
					{
						return "Pwnhammer";
					}
					case 368:
					{
						return "Excalibur";
					}
					case 369:
					{
						return "Hallowed Seeds";
					}
					case 370:
					{
						return "Ebonsand Block";
					}
					case 371:
					{
						return "Cobalt Hat";
					}
					case 372:
					{
						return "Cobalt Helmet";
					}
					case 373:
					{
						return "Cobalt Mask";
					}
					case 374:
					{
						return "Cobalt Breastplate";
					}
					case 375:
					{
						return "Cobalt Leggings";
					}
					case 376:
					{
						return "Mythril Hood";
					}
					case 377:
					{
						return "Mythril Helmet";
					}
					case 378:
					{
						return "Mythril Hat";
					}
					case 379:
					{
						return "Mythril Chainmail";
					}
					case 380:
					{
						return "Mythril Greaves";
					}
					case 381:
					{
						return "Cobalt Bar";
					}
					case 382:
					{
						return "Mythril Bar";
					}
					case 383:
					{
						return "Cobalt Chainsaw";
					}
					case 384:
					{
						return "Mythril Chainsaw";
					}
					case 385:
					{
						return "Cobalt Drill";
					}
					case 386:
					{
						return "Mythril Drill";
					}
					case 387:
					{
						return "Adamantite Chainsaw";
					}
					case 388:
					{
						return "Adamantite Drill";
					}
					case 389:
					{
						return "Dao of Pow";
					}
					case 390:
					{
						return "Mythril Halberd";
					}
					case 391:
					{
						return "Adamantite Bar";
					}
					case 392:
					{
						return "Glass Wall";
					}
					case 393:
					{
						return "Compass";
					}
					case 394:
					{
						return "Diving Gear";
					}
					case 395:
					{
						return "GPS";
					}
					case 396:
					{
						return "Obsidian Horseshoe";
					}
					case 397:
					{
						return "Obsidian Shield";
					}
					case 398:
					{
						return "Tinkerer's Workshop";
					}
					case 399:
					{
						return "Cloud in a Balloon";
					}
					case 400:
					{
						return "Adamantite Headgear";
					}
					case 401:
					{
						return "Adamantite Helmet";
					}
					case 402:
					{
						return "Adamantite Mask";
					}
					case 403:
					{
						return "Adamantite Breastplate";
					}
					case 404:
					{
						return "Adamantite Leggings";
					}
					case 405:
					{
						return "Spectre Boots";
					}
					case 406:
					{
						return "Adamantite Glaive";
					}
					case 407:
					{
						return "Toolbelt";
					}
					case 408:
					{
						return "Pearlsand Block";
					}
					case 409:
					{
						return "Pearlstone Block";
					}
					case 410:
					{
						return "Mining Shirt";
					}
					case 411:
					{
						return "Mining Pants";
					}
					case 412:
					{
						return "Pearlstone Brick";
					}
					case 413:
					{
						return "Iridescent Brick";
					}
					case 414:
					{
						return "Mudstone Block";
					}
					case 415:
					{
						return "Cobalt Brick";
					}
					case 416:
					{
						return "Mythril Brick";
					}
					case 417:
					{
						return "Pearlstone Brick Wall";
					}
					case 418:
					{
						return "Iridescent Brick Wall";
					}
					case 419:
					{
						return "Mudstone Brick Wall";
					}
					case 420:
					{
						return "Cobalt Brick Wall";
					}
					case 421:
					{
						return "Mythril Brick Wall";
					}
					case 422:
					{
						return "Holy Water";
					}
					case 423:
					{
						return "Unholy Water";
					}
					case 424:
					{
						return "Silt Block";
					}
					case 425:
					{
						return "Fairy Bell";
					}
					case 426:
					{
						return "Breaker Blade";
					}
					case 427:
					{
						return "Blue Torch";
					}
					case 428:
					{
						return "Red Torch";
					}
					case 429:
					{
						return "Green Torch";
					}
					case 430:
					{
						return "Purple Torch";
					}
					case 431:
					{
						return "White Torch";
					}
					case 432:
					{
						return "Yellow Torch";
					}
					case 433:
					{
						return "Demon Torch";
					}
					case 434:
					{
						return "Clockwork Assault Rifle";
					}
					case 435:
					{
						return "Cobalt Repeater";
					}
					case 436:
					{
						return "Mythril Repeater";
					}
					case 437:
					{
						return "Dual Hook";
					}
					case 438:
					{
						return "Star Statue";
					}
					case 439:
					{
						return "Sword Statue";
					}
					case 440:
					{
						return "Slime Statue";
					}
					case 441:
					{
						return "Goblin Statue";
					}
					case 442:
					{
						return "Shield Statue";
					}
					case 443:
					{
						return "Bat Statue";
					}
					case 444:
					{
						return "Fish Statue";
					}
					case 445:
					{
						return "Bunny Statue";
					}
					case 446:
					{
						return "Skeleton Statue";
					}
					case 447:
					{
						return "Reaper Statue";
					}
					case 448:
					{
						return "Woman Statue";
					}
					case 449:
					{
						return "Imp Statue";
					}
					case 450:
					{
						return "Gargoyle Statue";
					}
					case 451:
					{
						return "Gloom Statue";
					}
					case 452:
					{
						return "Hornet Statue";
					}
					case 453:
					{
						return "Bomb Statue";
					}
					case 454:
					{
						return "Crab Statue";
					}
					case 455:
					{
						return "Hammer Statue";
					}
					case 456:
					{
						return "Potion Statue";
					}
					case 457:
					{
						return "Spear Statue";
					}
					case 458:
					{
						return "Cross Statue";
					}
					case 459:
					{
						return "Jellyfish Statue";
					}
					case 460:
					{
						return "Bow Statue";
					}
					case 461:
					{
						return "Boomerang Statue";
					}
					case 462:
					{
						return "Boot Statue";
					}
					case 463:
					{
						return "Chest Statue";
					}
					case 464:
					{
						return "Bird Statue";
					}
					case 465:
					{
						return "Axe Statue";
					}
					case 466:
					{
						return "Corrupt Statue";
					}
					case 467:
					{
						return "Tree Statue";
					}
					case 468:
					{
						return "Anvil Statue";
					}
					case 469:
					{
						return "Pickaxe Statue";
					}
					case 470:
					{
						return "Mushroom Statue";
					}
					case 471:
					{
						return "Eyeball Statue";
					}
					case 472:
					{
						return "Pillar Statue";
					}
					case 473:
					{
						return "Heart Statue";
					}
					case 474:
					{
						return "Pot Statue";
					}
					case 475:
					{
						return "Sunflower Statue";
					}
					case 476:
					{
						return "King Statue";
					}
					case 477:
					{
						return "Queen Statue";
					}
					case 478:
					{
						return "Piranha Statue";
					}
					case 479:
					{
						return "Planked Wall";
					}
					case 480:
					{
						return "Wooden Beam";
					}
					case 481:
					{
						return "Adamantite Repeater";
					}
					case 482:
					{
						return "Adamantite Sword";
					}
					case 483:
					{
						return "Cobalt Sword";
					}
					case 484:
					{
						return "Mythril Sword";
					}
					case 485:
					{
						return "Moon Charm";
					}
					case 486:
					{
						return "Ruler";
					}
					case 487:
					{
						return "Crystal Ball";
					}
					case 488:
					{
						return "Disco Ball";
					}
					case 489:
					{
						return "Sorcerer Emblem";
					}
					case 490:
					{
						return "Warrior Emblem";
					}
					case 491:
					{
						return "Ranger Emblem";
					}
					case 492:
					{
						return "Demon Wings";
					}
					case 493:
					{
						return "Angel Wings";
					}
					case 494:
					{
						return "Magical Harp";
					}
					case 495:
					{
						return "Rainbow Rod";
					}
					case 496:
					{
						return "Ice Rod";
					}
					case 497:
					{
						return "Neptune's Shell";
					}
					case 498:
					{
						return "Mannequin";
					}
					case 499:
					{
						return "Greater Healing Potion";
					}
					case 500:
					{
						return "Greater Mana Potion";
					}
					case 501:
					{
						return "Pixie Dust";
					}
					case 502:
					{
						return "Crystal Shard";
					}
					case 503:
					{
						return "Clown Hat";
					}
					case 504:
					{
						return "Clown Shirt";
					}
					case 505:
					{
						return "Clown Pants";
					}
					case 506:
					{
						return "Flamethrower";
					}
					case 507:
					{
						return "Bell";
					}
					case 508:
					{
						return "Harp";
					}
					case 509:
					{
						return "Wrench";
					}
					case 510:
					{
						return "Wire Cutter";
					}
					case 511:
					{
						return "Active Stone Block";
					}
					case 512:
					{
						return "Inactive Stone Block";
					}
					case 513:
					{
						return "Lever";
					}
					case 514:
					{
						return "Laser Rifle";
					}
					case 515:
					{
						return "Crystal Bullet";
					}
					case 516:
					{
						return "Holy Arrow";
					}
					case 517:
					{
						return "Magic Dagger";
					}
					case 518:
					{
						return "Crystal Storm";
					}
					case 519:
					{
						return "Cursed Flames";
					}
					case 520:
					{
						return "Soul of Light";
					}
					case 521:
					{
						return "Soul of Night";
					}
					case 522:
					{
						return "Cursed Flame";
					}
					case 523:
					{
						return "Cursed Torch";
					}
					case 524:
					{
						return "Adamantite Forge";
					}
					case 525:
					{
						return "Mythril Anvil";
					}
					case 526:
					{
						return "Unicorn Horn";
					}
					case 527:
					{
						return "Dark Shard";
					}
					case 528:
					{
						return "Light Shard";
					}
					case 529:
					{
						return "Red Pressure Plate";
					}
					case 530:
					{
						return "Wire";
					}
					case 531:
					{
						return "Spell Tome";
					}
					case 532:
					{
						return "Star Cloak";
					}
					case 533:
					{
						return "Megashark";
					}
					case 534:
					{
						return "Shotgun";
					}
					case 535:
					{
						return "Philosopher's Stone";
					}
					case 536:
					{
						return "Titan Glove";
					}
					case 537:
					{
						return "Cobalt Naginata";
					}
					case 538:
					{
						return "Switch";
					}
					case 539:
					{
						return "Dart Trap";
					}
					case 540:
					{
						return "Boulder";
					}
					case 541:
					{
						return "Green Pressure Plate";
					}
					case 542:
					{
						return "Gray Pressure Plate";
					}
					case 543:
					{
						return "Brown Pressure Plate";
					}
					case 544:
					{
						return "Mechanical Eye";
					}
					case 545:
					{
						return "Cursed Arrow";
					}
					case 546:
					{
						return "Cursed Bullet";
					}
					case 547:
					{
						return "Soul of Fright";
					}
					case 548:
					{
						return "Soul of Might";
					}
					case 549:
					{
						return "Soul of Sight";
					}
					case 550:
					{
						return "Gungnir";
					}
					case 551:
					{
						return "Hallowed Plate Mail";
					}
					case 552:
					{
						return "Hallowed Greaves";
					}
					case 553:
					{
						return "Hallowed Helmet";
					}
					case 554:
					{
						return "Cross Necklace";
					}
					case 555:
					{
						return "Mana Flower";
					}
					case 556:
					{
						return "Mechanical Worm";
					}
					case 557:
					{
						return "Mechanical Skull";
					}
					case 558:
					{
						return "Hallowed Headgear";
					}
					case 559:
					{
						return "Hallowed Mask";
					}
					case 560:
					{
						return "Slime Crown";
					}
					case 561:
					{
						return "Light Disc";
					}
					case 562:
					{
						return "Music Box (Overworld Day)";
					}
					case 563:
					{
						return "Music Box (Eerie)";
					}
					case 564:
					{
						return "Music Box (Night)";
					}
					case 565:
					{
						return "Music Box (Title)";
					}
					case 566:
					{
						return "Music Box (Underground)";
					}
					case 567:
					{
						return "Music Box (Boss 1)";
					}
					case 568:
					{
						return "Music Box (Jungle)";
					}
					case 569:
					{
						return "Music Box (Corruption)";
					}
					case 570:
					{
						return "Music Box (Underground Corruption)";
					}
					case 571:
					{
						return "Music Box (The Hallow)";
					}
					case 572:
					{
						return "Music Box (Boss 2)";
					}
					case 573:
					{
						return "Music Box (Underground Hallow)";
					}
					case 574:
					{
						return "Music Box (Boss 3)";
					}
					case 575:
					{
						return "Soul of Flight";
					}
					case 576:
					{
						return "Music Box";
					}
					case 577:
					{
						return "Demonite Brick";
					}
					case 578:
					{
						return "Hallowed Repeater";
					}
					case 579:
					{
						return "Drax";
					}
					case 580:
					{
						return "Explosives";
					}
					case 581:
					{
						return "Inlet Pump";
					}
					case 582:
					{
						return "Outlet Pump";
					}
					case 583:
					{
						return "1 Second Timer";
					}
					case 584:
					{
						return "3 Second Timer";
					}
					case 585:
					{
						return "5 Second Timer";
					}
					case 586:
					{
						return "Candy Cane Block";
					}
					case 587:
					{
						return "Candy Cane Wall";
					}
					case 588:
					{
						return "Santa Hat";
					}
					case 589:
					{
						return "Santa Shirt";
					}
					case 590:
					{
						return "Santa Pants";
					}
					case 591:
					{
						return "Green Candy Cane Block";
					}
					case 592:
					{
						return "Green Candy Cane Wall";
					}
					case 593:
					{
						return "Snow Block";
					}
					case 594:
					{
						return "Snow Brick";
					}
					case 595:
					{
						return "Snow Brick Wall";
					}
					case 596:
					{
						return "Blue Light";
					}
					case 597:
					{
						return "Red Light";
					}
					case 598:
					{
						return "Green Light";
					}
					case 599:
					{
						return "Blue Present";
					}
					case 600:
					{
						return "Green Present";
					}
					case 601:
					{
						return "Yellow Present";
					}
					case 602:
					{
						return "Snow Globe";
					}
					case 603:
					{
						return "Carrot";
					}
					case 604:
					{
						return "Adamantite Beam";
					}
					case 605:
					{
						return "Adamantite Beam Wall";
					}
					case 606:
					{
						return "Demonite Brick Wall";
					}
					case 607:
					{
						return "Sandstone Brick";
					}
					case 608:
					{
						return "Sandstone Brick Wall";
					}
					case 609:
					{
						return "Ebonstone Brick";
					}
					case 610:
					{
						return "Ebonstone Brick Wall";
					}
					case 611:
					{
						return "Red Stucco";
					}
					case 612:
					{
						return "Yellow Stucco";
					}
					case 613:
					{
						return "Green Stucco";
					}
					case 614:
					{
						return "Gray Stucco";
					}
					case 615:
					{
						return "Red Stucco Wall";
					}
					case 616:
					{
						return "Yellow Stucco Wall";
					}
					case 617:
					{
						return "Green Stucco Wall";
					}
					case 618:
					{
						return "Gray Stucco Wall";
					}
					case 619:
					{
						return "Ebonwood";
					}
					case 620:
					{
						return "Rich Mahogany";
					}
					case 621:
					{
						return "Pearlwood";
					}
					case 622:
					{
						return "Ebonwood Wall";
					}
					case 623:
					{
						return "Rich Mahogany Wall";
					}
					case 624:
					{
						return "Pearlwood Wall";
					}
					case 625:
					{
						return "Ebonwood Chest";
					}
					case 626:
					{
						return "Rich Mahogany Chest";
					}
					case 627:
					{
						return "Pearlwood Chest";
					}
					case 628:
					{
						return "Ebonwood Chair";
					}
					case 629:
					{
						return "Rich Mahogany Chair";
					}
					case 630:
					{
						return "Pearlwood Chair";
					}
					case 631:
					{
						return "Ebonwood Platform";
					}
					case 632:
					{
						return "Rich Mahogany Platform";
					}
					case 633:
					{
						return "Pearlwood Platform";
					}
					case 634:
					{
						return "Bone Platform";
					}
					case 635:
					{
						return "Ebonwood Work Bench";
					}
					case 636:
					{
						return "Rich Mahogany Work Bench";
					}
					case 637:
					{
						return "Pearlwood Work Bench";
					}
					case 638:
					{
						return "Ebonwood Table";
					}
					case 639:
					{
						return "Rich Mahogany Table";
					}
					case 640:
					{
						return "Pearlwood Table";
					}
					case 641:
					{
						return "Ebonwood Piano";
					}
					case 642:
					{
						return "Rich Mahogany Piano";
					}
					case 643:
					{
						return "Pearlwood Piano";
					}
					case 644:
					{
						return "Ebonwood Bed";
					}
					case 645:
					{
						return "Rich Mahogany Bed";
					}
					case 646:
					{
						return "Pearlwood Bed";
					}
					case 647:
					{
						return "Ebonwood Dresser";
					}
					case 648:
					{
						return "Rich Mahogany Dresser";
					}
					case 649:
					{
						return "Pearlwood Dresser";
					}
					case 650:
					{
						return "Ebonwood Door";
					}
					case 651:
					{
						return "Rich Mahogany Door";
					}
					case 652:
					{
						return "Pearlwood Door";
					}
					case 653:
					{
						return "Ebonwood Sword";
					}
					case 654:
					{
						return "Ebonwood Hammer";
					}
					case 655:
					{
						return "Ebonwood Bow";
					}
					case 656:
					{
						return "Rich Mahogany Sword";
					}
					case 657:
					{
						return "Rich Mahogany Hammer";
					}
					case 658:
					{
						return "Rich Mahogany Bow";
					}
					case 659:
					{
						return "Pearlwood Sword";
					}
					case 660:
					{
						return "Pearlwood Hammer";
					}
					case 661:
					{
						return "Pearlwood Bow";
					}
					case 662:
					{
						return "Rainbow Brick";
					}
					case 663:
					{
						return "Rainbow Brick Wall";
					}
					case 664:
					{
						return "Ice Block";
					}
					case 665:
					{
						return "Red's Wings";
					}
					case 666:
					{
						return "Red's Helmet";
					}
					case 667:
					{
						return "Red's Breastplate";
					}
					case 668:
					{
						return "Red's Leggings";
					}
					case 669:
					{
						return "Fish";
					}
					case 670:
					{
						return "Ice Boomerang";
					}
					case 671:
					{
						return "Keybrand";
					}
					case 672:
					{
						return "Cutlass";
					}
					case 673:
					{
						return "Boreal Wood Work Bench";
					}
					case 674:
					{
						return "True Excalibur";
					}
					case 675:
					{
						return "True Night's Edge";
					}
					case 676:
					{
						return "Frostbrand";
					}
					case 677:
					{
						return "Boreal Wood Table";
					}
					case 678:
					{
						return "Red Potion";
					}
					case 679:
					{
						return "Tactical Shotgun";
					}
					case 680:
					{
						return "Ivy Chest";
					}
					case 681:
					{
						return "Ice Chest";
					}
					case 682:
					{
						return "Marrow";
					}
					case 683:
					{
						return "Unholy Trident";
					}
					case 684:
					{
						return "Frost Helmet";
					}
					case 685:
					{
						return "Frost Breastplate";
					}
					case 686:
					{
						return "Frost Leggings";
					}
					case 687:
					{
						return "Tin Helmet";
					}
					case 688:
					{
						return "Tin Chainmail";
					}
					case 689:
					{
						return "Tin Greaves";
					}
					case 690:
					{
						return "Lead Helmet";
					}
					case 691:
					{
						return "Lead Chainmail";
					}
					case 692:
					{
						return "Lead Greaves";
					}
					case 693:
					{
						return "Tungsten Helmet";
					}
					case 694:
					{
						return "Tungsten Chainmail";
					}
					case 695:
					{
						return "Tungsten Greaves";
					}
					case 696:
					{
						return "Platinum Helmet";
					}
					case 697:
					{
						return "Platinum Chainmail";
					}
					case 698:
					{
						return "Platinum Greaves";
					}
					case 699:
					{
						return "Tin Ore";
					}
					case 700:
					{
						return "Lead Ore";
					}
					case 701:
					{
						return "Tungsten Ore";
					}
					case 702:
					{
						return "Platinum Ore";
					}
					case 703:
					{
						return "Tin Bar";
					}
					case 704:
					{
						return "Lead Bar";
					}
					case 705:
					{
						return "Tungsten Bar";
					}
					case 706:
					{
						return "Platinum Bar";
					}
					case 707:
					{
						return "Tin Watch";
					}
					case 708:
					{
						return "Tungsten Watch";
					}
					case 709:
					{
						return "Platinum Watch";
					}
					case 710:
					{
						return "Tin Chandelier";
					}
					case 711:
					{
						return "Tungsten Chandelier";
					}
					case 712:
					{
						return "Platinum Chandelier";
					}
					case 713:
					{
						return "Platinum Candle";
					}
					case 714:
					{
						return "Platinum Candelabra";
					}
					case 715:
					{
						return "Platinum Crown";
					}
					case 716:
					{
						return "Lead Anvil";
					}
					case 717:
					{
						return "Tin Brick";
					}
					case 718:
					{
						return "Tungsten Brick";
					}
					case 719:
					{
						return "Platinum Brick";
					}
					case 720:
					{
						return "Tin Brick Wall";
					}
					case 721:
					{
						return "Tungsten Brick Wall";
					}
					case 722:
					{
						return "Platinum Brick Wall";
					}
					case 723:
					{
						return "Beam Sword";
					}
					case 724:
					{
						return "Ice Blade";
					}
					case 725:
					{
						return "Ice Bow";
					}
					case 726:
					{
						return "Frost Staff";
					}
					case 727:
					{
						return "Wood Helmet";
					}
					case 728:
					{
						return "Wood Breastplate";
					}
					case 729:
					{
						return "Wood Greaves";
					}
					case 730:
					{
						return "Ebonwood Helmet";
					}
					case 731:
					{
						return "Ebonwood Breastplate";
					}
					case 732:
					{
						return "Ebonwood Greaves";
					}
					case 733:
					{
						return "Rich Mahogany Helmet";
					}
					case 734:
					{
						return "Rich Mahogany Breastplate";
					}
					case 735:
					{
						return "Rich Mahogany Greaves";
					}
					case 736:
					{
						return "Pearlwood Helmet";
					}
					case 737:
					{
						return "Pearlwood Breastplate";
					}
					case 738:
					{
						return "Pearlwood Greaves";
					}
					case 739:
					{
						return "Amethyst Staff";
					}
					case 740:
					{
						return "Topaz Staff";
					}
					case 741:
					{
						return "Sapphire Staff";
					}
					case 742:
					{
						return "Emerald Staff";
					}
					case 743:
					{
						return "Ruby Staff";
					}
					case 744:
					{
						return "Diamond Staff";
					}
					case 745:
					{
						return "Grass Wall";
					}
					case 746:
					{
						return "Jungle Wall";
					}
					case 747:
					{
						return "Flower Wall";
					}
					case 748:
					{
						return "Jetpack";
					}
					case 749:
					{
						return "Butterfly Wings";
					}
					case 750:
					{
						return "Cactus Wall";
					}
					case 751:
					{
						return "Cloud";
					}
					case 752:
					{
						return "Cloud Wall";
					}
					case 753:
					{
						return "Seaweed";
					}
					case 754:
					{
						return "Rune Hat";
					}
					case 755:
					{
						return "Rune Robe";
					}
					case 756:
					{
						return "Mushroom Spear";
					}
					case 757:
					{
						return "Terra Blade";
					}
					case 758:
					{
						return "Grenade Launcher";
					}
					case 759:
					{
						return "Rocket Launcher";
					}
					case 760:
					{
						return "Proximity Mine Launcher";
					}
					case 761:
					{
						return "Fairy Wings";
					}
					case 762:
					{
						return "Slime Block";
					}
					case 763:
					{
						return "Flesh Block";
					}
					case 764:
					{
						return "Mushroom Wall";
					}
					case 765:
					{
						return "Rain Cloud";
					}
					case 766:
					{
						return "Bone Block";
					}
					case 767:
					{
						return "Frozen Slime Block";
					}
					case 768:
					{
						return "Bone Block Wall";
					}
					case 769:
					{
						return "Slime Block Wall";
					}
					case 770:
					{
						return "Flesh Block Wall";
					}
					case 771:
					{
						return "Rocket I";
					}
					case 772:
					{
						return "Rocket II";
					}
					case 773:
					{
						return "Rocket III";
					}
					case 774:
					{
						return "Rocket IV";
					}
					case 775:
					{
						return "Asphalt Block";
					}
					case 776:
					{
						return "Cobalt Pickaxe";
					}
					case 777:
					{
						return "Mythril Pickaxe";
					}
					case 778:
					{
						return "Adamantite Pickaxe";
					}
					case 779:
					{
						return "Clentaminator";
					}
					case 780:
					{
						return "Green Solution";
					}
					case 781:
					{
						return "Blue Solution";
					}
					case 782:
					{
						return "Purple Solution";
					}
					case 783:
					{
						return "Dark Blue Solution";
					}
					case 784:
					{
						return "Red Solution";
					}
					case 785:
					{
						return "Harpy Wings";
					}
					case 786:
					{
						return "Bone Wings";
					}
					case 787:
					{
						return "Hammush";
					}
					case 788:
					{
						return "Nettle Burst";
					}
					case 789:
					{
						return "Ankh Banner";
					}
					case 790:
					{
						return "Snake Banner";
					}
					case 791:
					{
						return "Omega Banner";
					}
					case 792:
					{
						return "Crimson Helmet";
					}
					case 793:
					{
						return "Crimson Scalemail";
					}
					case 794:
					{
						return "Crimson Greaves";
					}
					case 795:
					{
						return "Blood Butcherer";
					}
					case 796:
					{
						return "Tendon Bow";
					}
					case 797:
					{
						return "Flesh Grinder";
					}
					case 798:
					{
						return "Deathbringer Pickaxe";
					}
					case 799:
					{
						return "Blood Lust Cluster";
					}
					case 800:
					{
						return "The Undertaker";
					}
					case 801:
					{
						return "The Meatball";
					}
					case 802:
					{
						return "The Rotted Fork";
					}
					case 803:
					{
						return "Eskimo Hood";
					}
					case 804:
					{
						return "Eskimo Coat";
					}
					case 805:
					{
						return "Eskimo Pants";
					}
					case 806:
					{
						return "Living Wood Chair";
					}
					case 807:
					{
						return "Cactus Chair";
					}
					case 808:
					{
						return "Bone Chair";
					}
					case 809:
					{
						return "Flesh Chair";
					}
					case 810:
					{
						return "Mushroom Chair";
					}
					case 811:
					{
						return "Bone Work Bench";
					}
					case 812:
					{
						return "Cactus Work Bench";
					}
					case 813:
					{
						return "Flesh Work Bench";
					}
					case 814:
					{
						return "Mushroom Work Bench";
					}
					case 815:
					{
						return "Slime Work Bench";
					}
					case 816:
					{
						return "Cactus Door";
					}
					case 817:
					{
						return "Flesh Door";
					}
					case 818:
					{
						return "Mushroom Door";
					}
					case 819:
					{
						return "Living Wood Door";
					}
					case 820:
					{
						return "Bone Door";
					}
					case 821:
					{
						return "Flame Wings";
					}
					case 822:
					{
						return "Frozen Wings";
					}
					case 823:
					{
						return "Spectre Wings";
					}
					case 824:
					{
						return "Sunplate Block";
					}
					case 825:
					{
						return "Disc Wall";
					}
					case 826:
					{
						return "Skyware Chair";
					}
					case 827:
					{
						return "Bone Table";
					}
					case 828:
					{
						return "Flesh Table";
					}
					case 829:
					{
						return "Living Wood Table";
					}
					case 830:
					{
						return "Skyware Table";
					}
					case 831:
					{
						return "Living Wood Chest";
					}
					case 832:
					{
						return "Living Wood Wand";
					}
					case 833:
					{
						return "Purple Ice Block";
					}
					case 834:
					{
						return "Pink Ice Block";
					}
					case 835:
					{
						return "Red Ice Block";
					}
					case 836:
					{
						return "Crimstone Block";
					}
					case 837:
					{
						return "Skyware Door";
					}
					case 838:
					{
						return "Skyware Chest";
					}
					case 839:
					{
						return "Steampunk Hat";
					}
					case 840:
					{
						return "Steampunk Shirt";
					}
					case 841:
					{
						return "Steampunk Pants";
					}
					case 842:
					{
						return "Bee Hat";
					}
					case 843:
					{
						return "Bee Shirt";
					}
					case 844:
					{
						return "Bee Pants";
					}
					case 845:
					{
						return "World Banner";
					}
					case 846:
					{
						return "Sun Banner";
					}
					case 847:
					{
						return "Gravity Banner";
					}
					case 848:
					{
						return "Pharaoh's Mask";
					}
					case 849:
					{
						return "Actuator";
					}
					case 850:
					{
						return "Blue Wrench";
					}
					case 851:
					{
						return "Green Wrench";
					}
					case 852:
					{
						return "Blue Pressure Plate";
					}
					case 853:
					{
						return "Yellow Pressure Plate";
					}
					case 854:
					{
						return "Discount Card";
					}
					case 855:
					{
						return "Lucky Coin";
					}
					case 856:
					{
						return "Unicorn on a Stick";
					}
					case 857:
					{
						return "Sandstorm in a Bottle";
					}
					case 858:
					{
						return "Boreal Wood Sofa";
					}
					case 859:
					{
						return "Beach Ball";
					}
					case 860:
					{
						return "Charm of Myths";
					}
					case 861:
					{
						return "Moon Shell";
					}
					case 862:
					{
						return "Star Veil";
					}
					case 863:
					{
						return "Water Walking Boots";
					}
					case 864:
					{
						return "Tiara";
					}
					case 865:
					{
						return "Princess Dress";
					}
					case 866:
					{
						return "Pharaoh's Robe";
					}
					case 867:
					{
						return "Green Cap";
					}
					case 868:
					{
						return "Mushroom Cap";
					}
					case 869:
					{
						return "Tam O' Shanter";
					}
					case 870:
					{
						return "Mummy Mask";
					}
					case 871:
					{
						return "Mummy Shirt";
					}
					case 872:
					{
						return "Mummy Pants";
					}
					case 873:
					{
						return "Cowboy Hat";
					}
					case 874:
					{
						return "Cowboy Jacket";
					}
					case 875:
					{
						return "Cowboy Pants";
					}
					case 876:
					{
						return "Pirate Hat";
					}
					case 877:
					{
						return "Pirate Shirt";
					}
					case 878:
					{
						return "Pirate Pants";
					}
					case 879:
					{
						return "Viking Helmet";
					}
					case 880:
					{
						return "Crimtane Ore";
					}
					case 881:
					{
						return "Cactus Sword";
					}
					case 882:
					{
						return "Cactus Pickaxe";
					}
					case 883:
					{
						return "Ice Brick";
					}
					case 884:
					{
						return "Ice Brick Wall";
					}
					case 885:
					{
						return "Adhesive Bandage";
					}
					case 886:
					{
						return "Armor Polish";
					}
					case 887:
					{
						return "Bezoar";
					}
					case 888:
					{
						return "Blindfold";
					}
					case 889:
					{
						return "Fast Clock";
					}
					case 890:
					{
						return "Megaphone";
					}
					case 891:
					{
						return "Nazar";
					}
					case 892:
					{
						return "Vitamins";
					}
					case 893:
					{
						return "Trifold Map";
					}
					case 894:
					{
						return "Cactus Helmet";
					}
					case 895:
					{
						return "Cactus Breastplate";
					}
					case 896:
					{
						return "Cactus Leggings";
					}
					case 897:
					{
						return "Power Glove";
					}
					case 898:
					{
						return "Lightning Boots";
					}
					case 899:
					{
						return "Sun Stone";
					}
					case 900:
					{
						return "Moon Stone";
					}
					case 901:
					{
						return "Armor Bracing";
					}
					case 902:
					{
						return "Medicated Bandage";
					}
					case 903:
					{
						return "The Plan";
					}
					case 904:
					{
						return "Countercurse Mantra";
					}
					case 905:
					{
						return "Coin Gun";
					}
					case 906:
					{
						return "Lava Charm";
					}
					case 907:
					{
						return "Obsidian Water Walking Boots";
					}
					case 908:
					{
						return "Lava Waders";
					}
					case 909:
					{
						return "Pure Water Fountain";
					}
					case 910:
					{
						return "Desert Water Fountain";
					}
					case 911:
					{
						return "Shadewood";
					}
					case 912:
					{
						return "Shadewood Door";
					}
					case 913:
					{
						return "Shadewood Platform";
					}
					case 914:
					{
						return "Shadewood Chest";
					}
					case 915:
					{
						return "Shadewood Chair";
					}
					case 916:
					{
						return "Shadewood Work Bench";
					}
					case 917:
					{
						return "Shadewood Table";
					}
					case 918:
					{
						return "Shadewood Dresser";
					}
					case 919:
					{
						return "Shadewood Piano";
					}
					case 920:
					{
						return "Shadewood Bed";
					}
					case 921:
					{
						return "Shadewood Sword";
					}
					case 922:
					{
						return "Shadewood Hammer";
					}
					case 923:
					{
						return "Shadewood Bow";
					}
					case 924:
					{
						return "Shadewood Helmet";
					}
					case 925:
					{
						return "Shadewood Breastplate";
					}
					case 926:
					{
						return "Shadewood Greaves";
					}
					case 927:
					{
						return "Shadewood Wall";
					}
					case 928:
					{
						return "Cannon";
					}
					case 929:
					{
						return "Cannonball";
					}
					case 930:
					{
						return "Flare Gun";
					}
					case 931:
					{
						return "Flare";
					}
					case 932:
					{
						return "Bone Wand";
					}
					case 933:
					{
						return "Leaf Wand";
					}
					case 934:
					{
						return "Flying Carpet";
					}
					case 935:
					{
						return "Avenger Emblem";
					}
					case 936:
					{
						return "Mechanical Glove";
					}
					case 937:
					{
						return "Land Mine";
					}
					case 938:
					{
						return "Paladin's Shield";
					}
					case 939:
					{
						return "Web Slinger";
					}
					case 940:
					{
						return "Jungle Water Fountain";
					}
					case 941:
					{
						return "Icy Water Fountain";
					}
					case 942:
					{
						return "Corrupt Water Fountain";
					}
					case 943:
					{
						return "Crimson Water Fountain";
					}
					case 944:
					{
						return "Hallowed Water Fountain";
					}
					case 945:
					{
						return "Blood Water Fountain";
					}
					case 946:
					{
						return "Umbrella";
					}
					case 947:
					{
						return "Chlorophyte Ore";
					}
					case 948:
					{
						return "Steampunk Wings";
					}
					case 949:
					{
						return "Snowball";
					}
					case 950:
					{
						return "Ice Skates";
					}
					case 951:
					{
						return "Snowball Launcher";
					}
					case 952:
					{
						return "Web Covered Chest";
					}
					case 953:
					{
						return "Climbing Claws";
					}
					case 954:
					{
						return "Ancient Iron Helmet";
					}
					case 955:
					{
						return "Ancient Gold Helmet";
					}
					case 956:
					{
						return "Ancient Shadow Helmet";
					}
					case 957:
					{
						return "Ancient Shadow Scalemail";
					}
					case 958:
					{
						return "Ancient Shadow Greaves";
					}
					case 959:
					{
						return "Ancient Necro Helmet";
					}
					case 960:
					{
						return "Ancient Cobalt Helmet";
					}
					case 961:
					{
						return "Ancient Cobalt Breastplate";
					}
					case 962:
					{
						return "Ancient Cobalt Leggings";
					}
					case 963:
					{
						return "Black Belt";
					}
					case 964:
					{
						return "Boomstick";
					}
					case 965:
					{
						return "Rope";
					}
					case 966:
					{
						return "Campfire";
					}
					case 967:
					{
						return "Marshmallow";
					}
					case 968:
					{
						return "Marshmallow on a Stick";
					}
					case 969:
					{
						return "Cooked Marshmallow";
					}
					case 970:
					{
						return "Red Rocket";
					}
					case 971:
					{
						return "Green Rocket";
					}
					case 972:
					{
						return "Blue Rocket";
					}
					case 973:
					{
						return "Yellow Rocket";
					}
					case 974:
					{
						return "Ice Torch";
					}
					case 975:
					{
						return "Shoe Spikes";
					}
					case 976:
					{
						return "Tiger Climbing Gear";
					}
					case 977:
					{
						return "Tabi";
					}
					case 978:
					{
						return "Pink Eskimo Hood";
					}
					case 979:
					{
						return "Pink Eskimo Coat";
					}
					case 980:
					{
						return "Pink Eskimo Pants";
					}
					case 981:
					{
						return "Pink Thread";
					}
					case 982:
					{
						return "Mana Regeneration Band";
					}
					case 983:
					{
						return "Sandstorm in a Balloon";
					}
					case 984:
					{
						return "Master Ninja Gear";
					}
					case 985:
					{
						return "Rope Coil";
					}
					case 986:
					{
						return "Blowgun";
					}
					case 987:
					{
						return "Blizzard in a Bottle";
					}
					case 988:
					{
						return "Frostburn Arrow";
					}
					case 989:
					{
						return "Enchanted Sword";
					}
					case 990:
					{
						return "Pickaxe Axe";
					}
					case 991:
					{
						return "Cobalt Waraxe";
					}
					case 992:
					{
						return "Mythril Waraxe";
					}
					case 993:
					{
						return "Adamantite Waraxe";
					}
					case 994:
					{
						return "Eater's Bone";
					}
					case 995:
					{
						return "Blend-O-Matic";
					}
					case 996:
					{
						return "Meat Grinder";
					}
					case 997:
					{
						return "Extractinator";
					}
					case 998:
					{
						return "Solidifier";
					}
					case 999:
					{
						return "Amber";
					}
					case 1000:
					{
						return "Confetti Gun";
					}
					case 1001:
					{
						return "Chlorophyte Mask";
					}
					case 1002:
					{
						return "Chlorophyte Helmet";
					}
					case 1003:
					{
						return "Chlorophyte Headgear";
					}
					case 1004:
					{
						return "Chlorophyte Plate Mail";
					}
					case 1005:
					{
						return "Chlorophyte Greaves";
					}
					case 1006:
					{
						return "Chlorophyte Bar";
					}
					case 1007:
					{
						return "Red Dye";
					}
					case 1008:
					{
						return "Orange Dye";
					}
					case 1009:
					{
						return "Yellow Dye";
					}
					case 1010:
					{
						return "Lime Dye";
					}
					case 1011:
					{
						return "Green Dye";
					}
					case 1012:
					{
						return "Teal Dye";
					}
					case 1013:
					{
						return "Cyan Dye";
					}
					case 1014:
					{
						return "Sky Blue Dye";
					}
					case 1015:
					{
						return "Blue Dye";
					}
					case 1016:
					{
						return "Purple Dye";
					}
					case 1017:
					{
						return "Violet Dye";
					}
					case 1018:
					{
						return "Pink Dye";
					}
					case 1019:
					{
						return "Red and Black Dye";
					}
					case 1020:
					{
						return "Orange and Black Dye";
					}
					case 1021:
					{
						return "Yellow and Black Dye";
					}
					case 1022:
					{
						return "Lime and Black Dye";
					}
					case 1023:
					{
						return "Green and Black Dye";
					}
					case 1024:
					{
						return "Teal and Black Dye";
					}
					case 1025:
					{
						return "Cyan and Black Dye";
					}
					case 1026:
					{
						return "Sky Blue and Black Dye";
					}
					case 1027:
					{
						return "Blue and Black Dye";
					}
					case 1028:
					{
						return "Purple and Black Dye";
					}
					case 1029:
					{
						return "Violet and Black Dye";
					}
					case 1030:
					{
						return "Pink and Black Dye";
					}
					case 1031:
					{
						return "Flame Dye";
					}
					case 1032:
					{
						return "Flame and Black Dye";
					}
					case 1033:
					{
						return "Green Flame Dye";
					}
					case 1034:
					{
						return "Green Flame and Black Dye";
					}
					case 1035:
					{
						return "Blue Flame Dye";
					}
					case 1036:
					{
						return "Blue Flame and Black Dye";
					}
					case 1037:
					{
						return "Silver Dye";
					}
					case 1038:
					{
						return "Bright Red Dye";
					}
					case 1039:
					{
						return "Bright Orange Dye";
					}
					case 1040:
					{
						return "Bright Yellow Dye";
					}
					case 1041:
					{
						return "Bright Lime Dye";
					}
					case 1042:
					{
						return "Bright Green Dye";
					}
					case 1043:
					{
						return "Bright Teal Dye";
					}
					case 1044:
					{
						return "Bright Cyan Dye";
					}
					case 1045:
					{
						return "Bright Sky Blue Dye";
					}
					case 1046:
					{
						return "Bright Blue Dye";
					}
					case 1047:
					{
						return "Bright Purple Dye";
					}
					case 1048:
					{
						return "Bright Violet Dye";
					}
					case 1049:
					{
						return "Bright Pink Dye";
					}
					case 1050:
					{
						return "Black Dye";
					}
					case 1051:
					{
						return "Red and Silver Dye";
					}
					case 1052:
					{
						return "Orange and Silver Dye";
					}
					case 1053:
					{
						return "Yellow and Silver Dye";
					}
					case 1054:
					{
						return "Lime and Silver Dye";
					}
					case 1055:
					{
						return "Green and Silver Dye";
					}
					case 1056:
					{
						return "Teal and Silver Dye";
					}
					case 1057:
					{
						return "Cyan and Silver Dye";
					}
					case 1058:
					{
						return "Sky Blue and Silver Dye";
					}
					case 1059:
					{
						return "Blue and Silver Dye";
					}
					case 1060:
					{
						return "Purple and Silver Dye";
					}
					case 1061:
					{
						return "Violet and Silver Dye";
					}
					case 1062:
					{
						return "Pink and Silver Dye";
					}
					case 1063:
					{
						return "Intense Flame Dye";
					}
					case 1064:
					{
						return "Intense Green Flame Dye";
					}
					case 1065:
					{
						return "Intense Blue Flame Dye";
					}
					case 1066:
					{
						return "Rainbow Dye";
					}
					case 1067:
					{
						return "Intense Rainbow Dye";
					}
					case 1068:
					{
						return "Yellow Gradient Dye";
					}
					case 1069:
					{
						return "Cyan Gradient Dye";
					}
					case 1070:
					{
						return "Violet Gradient Dye";
					}
					case 1071:
					{
						return "Paintbrush";
					}
					case 1072:
					{
						return "Paint Roller";
					}
					case 1073:
					{
						return "Red Paint";
					}
					case 1074:
					{
						return "Orange Paint";
					}
					case 1075:
					{
						return "Yellow Paint";
					}
					case 1076:
					{
						return "Lime Paint";
					}
					case 1077:
					{
						return "Green Paint";
					}
					case 1078:
					{
						return "Teal Paint";
					}
					case 1079:
					{
						return "Cyan Paint";
					}
					case 1080:
					{
						return "Sky Blue Paint";
					}
					case 1081:
					{
						return "Blue Paint";
					}
					case 1082:
					{
						return "Purple Paint";
					}
					case 1083:
					{
						return "Violet Paint";
					}
					case 1084:
					{
						return "Pink Paint";
					}
					case 1085:
					{
						return "Deep Red Paint";
					}
					case 1086:
					{
						return "Deep Orange Paint";
					}
					case 1087:
					{
						return "Deep Yellow Paint";
					}
					case 1088:
					{
						return "Deep Lime Paint";
					}
					case 1089:
					{
						return "Deep Green Paint";
					}
					case 1090:
					{
						return "Deep Teal Paint";
					}
					case 1091:
					{
						return "Deep Cyan Paint";
					}
					case 1092:
					{
						return "Deep Sky Blue Paint";
					}
					case 1093:
					{
						return "Deep Blue Paint";
					}
					case 1094:
					{
						return "Deep Purple Paint";
					}
					case 1095:
					{
						return "Deep Violet Paint";
					}
					case 1096:
					{
						return "Deep Pink Paint";
					}
					case 1097:
					{
						return "Black Paint";
					}
					case 1098:
					{
						return "White Paint";
					}
					case 1099:
					{
						return "Gray Paint";
					}
					case 1100:
					{
						return "Paint Scraper";
					}
					case 1101:
					{
						return "Lihzahrd Brick";
					}
					case 1102:
					{
						return "Lihzahrd Brick Wall";
					}
					case 1103:
					{
						return "Slush Block";
					}
					case 1104:
					{
						return "Palladium Ore";
					}
					case 1105:
					{
						return "Orichalcum Ore";
					}
					case 1106:
					{
						return "Titanium Ore";
					}
					case 1107:
					{
						return "Teal Mushroom";
					}
					case 1108:
					{
						return "Green Mushroom";
					}
					case 1109:
					{
						return "Sky Blue Flower";
					}
					case 1110:
					{
						return "Yellow Marigold";
					}
					case 1111:
					{
						return "Blue Berries";
					}
					case 1112:
					{
						return "Lime Kelp";
					}
					case 1113:
					{
						return "Pink Prickly Pear";
					}
					case 1114:
					{
						return "Orange Bloodroot";
					}
					case 1115:
					{
						return "Red Husk";
					}
					case 1116:
					{
						return "Cyan Husk";
					}
					case 1117:
					{
						return "Violet Husk";
					}
					case 1118:
					{
						return "Purple Mucos";
					}
					case 1119:
					{
						return "Black Ink";
					}
					case 1120:
					{
						return "Dye Vat";
					}
					case 1121:
					{
						return "Bee Gun";
					}
					case 1122:
					{
						return "Possessed Hatchet";
					}
					case 1123:
					{
						return "Bee Keeper";
					}
					case 1124:
					{
						return "Hive";
					}
					case 1125:
					{
						return "Honey Block";
					}
					case 1126:
					{
						return "Hive Wall";
					}
					case 1127:
					{
						return "Crispy Honey Block";
					}
					case 1128:
					{
						return "Honey Bucket";
					}
					case 1129:
					{
						return "Hive Wand";
					}
					case 1130:
					{
						return "Beenade";
					}
					case 1131:
					{
						return "Gravity Globe";
					}
					case 1132:
					{
						return "Honey Comb";
					}
					case 1133:
					{
						return "Abeemination";
					}
					case 1134:
					{
						return "Bottled Honey";
					}
					case 1135:
					{
						return "Rain Hat";
					}
					case 1136:
					{
						return "Rain Coat";
					}
					case 1137:
					{
						return "Lihzahrd Door";
					}
					case 1138:
					{
						return "Dungeon Door";
					}
					case 1139:
					{
						return "Lead Door";
					}
					case 1140:
					{
						return "Iron Door";
					}
					case 1141:
					{
						return "Temple Key";
					}
					case 1142:
					{
						return "Lihzahrd Chest";
					}
					case 1143:
					{
						return "Lihzahrd Chair";
					}
					case 1144:
					{
						return "Lihzahrd Table";
					}
					case 1145:
					{
						return "Lihzahrd Work Bench";
					}
					case 1146:
					{
						return "Super Dart Trap";
					}
					case 1147:
					{
						return "Flame Trap";
					}
					case 1148:
					{
						return "Spiky Ball Trap";
					}
					case 1149:
					{
						return "Spear Trap";
					}
					case 1150:
					{
						return "Wooden Spike";
					}
					case 1151:
					{
						return "Lihzahrd Pressure Plate";
					}
					case 1152:
					{
						return "Lihzahrd Statue";
					}
					case 1153:
					{
						return "Lihzahrd Watcher Statue";
					}
					case 1154:
					{
						return "Lihzahrd Guardian Statue";
					}
					case 1155:
					{
						return "Wasp Gun";
					}
					case 1156:
					{
						return "Piranha Gun";
					}
					case 1157:
					{
						return "Pygmy Staff";
					}
					case 1158:
					{
						return "Pygmy Necklace";
					}
					case 1159:
					{
						return "Tiki Mask";
					}
					case 1160:
					{
						return "Tiki Shirt";
					}
					case 1161:
					{
						return "Tiki Pants";
					}
					case 1162:
					{
						return "Leaf Wings";
					}
					case 1163:
					{
						return "Blizzard in a Balloon";
					}
					case 1164:
					{
						return "Bundle of Balloons";
					}
					case 1165:
					{
						return "Bat Wings";
					}
					case 1166:
					{
						return "Bone Sword";
					}
					case 1167:
					{
						return "Hercules Beetle";
					}
					case 1168:
					{
						return "Smoke Bomb";
					}
					case 1169:
					{
						return "Bone Key";
					}
					case 1170:
					{
						return "Nectar";
					}
					case 1171:
					{
						return "Tiki Totem";
					}
					case 1172:
					{
						return "Lizard Egg";
					}
					case 1173:
					{
						return "Grave Marker";
					}
					case 1174:
					{
						return "Cross Grave Marker";
					}
					case 1175:
					{
						return "Headstone";
					}
					case 1176:
					{
						return "Gravestone";
					}
					case 1177:
					{
						return "Obelisk";
					}
					case 1178:
					{
						return "Leaf Blower";
					}
					case 1179:
					{
						return "Chlorophyte Bullet";
					}
					case 1180:
					{
						return "Parrot Cracker";
					}
					case 1181:
					{
						return "Strange Glowing Mushroom";
					}
					case 1182:
					{
						return "Seedling";
					}
					case 1183:
					{
						return "Wisp in a Bottle";
					}
					case 1184:
					{
						return "Palladium Bar";
					}
					case 1185:
					{
						return "Palladium Sword";
					}
					case 1186:
					{
						return "Palladium Pike";
					}
					case 1187:
					{
						return "Palladium Repeater";
					}
					case 1188:
					{
						return "Palladium Pickaxe";
					}
					case 1189:
					{
						return "Palladium Drill";
					}
					case 1190:
					{
						return "Palladium Chainsaw";
					}
					case 1191:
					{
						return "Orichalcum Bar";
					}
					case 1192:
					{
						return "Orichalcum Sword";
					}
					case 1193:
					{
						return "Orichalcum Halberd";
					}
					case 1194:
					{
						return "Orichalcum Repeater";
					}
					case 1195:
					{
						return "Orichalcum Pickaxe";
					}
					case 1196:
					{
						return "Orichalcum Drill";
					}
					case 1197:
					{
						return "Orichalcum Chainsaw";
					}
					case 1198:
					{
						return "Titanium Bar";
					}
					case 1199:
					{
						return "Titanium Sword";
					}
					case 1200:
					{
						return "Titanium Trident";
					}
					case 1201:
					{
						return "Titanium Repeater";
					}
					case 1202:
					{
						return "Titanium Pickaxe";
					}
					case 1203:
					{
						return "Titanium Drill";
					}
					case 1204:
					{
						return "Titanium Chainsaw";
					}
					case 1205:
					{
						return "Palladium Mask";
					}
					case 1206:
					{
						return "Palladium Helmet";
					}
					case 1207:
					{
						return "Palladium Headgear";
					}
					case 1208:
					{
						return "Palladium Breastplate";
					}
					case 1209:
					{
						return "Palladium Leggings";
					}
					case 1210:
					{
						return "Orichalcum Mask";
					}
					case 1211:
					{
						return "Orichalcum Helmet";
					}
					case 1212:
					{
						return "Orichalcum Headgear";
					}
					case 1213:
					{
						return "Orichalcum Breastplate";
					}
					case 1214:
					{
						return "Orichalcum Leggings";
					}
					case 1215:
					{
						return "Titanium Mask";
					}
					case 1216:
					{
						return "Titanium Helmet";
					}
					case 1217:
					{
						return "Titanium Headgear";
					}
					case 1218:
					{
						return "Titanium Breastplate";
					}
					case 1219:
					{
						return "Titanium Leggings";
					}
					case 1220:
					{
						return "Orichalcum Anvil";
					}
					case 1221:
					{
						return "Titanium Forge";
					}
					case 1222:
					{
						return "Palladium Waraxe";
					}
					case 1223:
					{
						return "Orichalcum Waraxe";
					}
					case 1224:
					{
						return "Titanium Waraxe";
					}
					case 1225:
					{
						return "Hallowed Bar";
					}
					case 1226:
					{
						return "Chlorophyte Claymore";
					}
					case 1227:
					{
						return "Chlorophyte Saber";
					}
					case 1228:
					{
						return "Chlorophyte Partisan";
					}
					case 1229:
					{
						return "Chlorophyte Shotbow";
					}
					case 1230:
					{
						return "Chlorophyte Pickaxe";
					}
					case 1231:
					{
						return "Chlorophyte Drill";
					}
					case 1232:
					{
						return "Chlorophyte Chainsaw";
					}
					case 1233:
					{
						return "Chlorophyte Greataxe";
					}
					case 1234:
					{
						return "Chlorophyte Warhammer";
					}
					case 1235:
					{
						return "Chlorophyte Arrow";
					}
					case 1236:
					{
						return "Amethyst Hook";
					}
					case 1237:
					{
						return "Topaz Hook";
					}
					case 1238:
					{
						return "Sapphire Hook";
					}
					case 1239:
					{
						return "Emerald Hook";
					}
					case 1240:
					{
						return "Ruby Hook";
					}
					case 1241:
					{
						return "Diamond Hook";
					}
					case 1242:
					{
						return "Amber Mosquito";
					}
					case 1243:
					{
						return "Umbrella Hat";
					}
					case 1244:
					{
						return "Nimbus Rod";
					}
					case 1245:
					{
						return "Orange Torch";
					}
					case 1246:
					{
						return "Crimsand Block";
					}
					case 1247:
					{
						return "Bee Cloak";
					}
					case 1248:
					{
						return "Eye of the Golem";
					}
					case 1249:
					{
						return "Honey Balloon";
					}
					case 1250:
					{
						return "Blue Horseshoe Balloon";
					}
					case 1251:
					{
						return "White Horseshoe Balloon";
					}
					case 1252:
					{
						return "Yellow Horseshoe Balloon";
					}
					case 1253:
					{
						return "Frozen Turtle Shell";
					}
					case 1254:
					{
						return "Sniper Rifle";
					}
					case 1255:
					{
						return "Venus Magnum";
					}
					case 1256:
					{
						return "Crimson Rod";
					}
					case 1257:
					{
						return "Crimtane Bar";
					}
					case 1258:
					{
						return "Stynger";
					}
					case 1259:
					{
						return "Flower Pow";
					}
					case 1260:
					{
						return "Rainbow Gun";
					}
					case 1261:
					{
						return "Stynger Bolt";
					}
					case 1262:
					{
						return "Chlorophyte Jackhammer";
					}
					case 1263:
					{
						return "Teleporter";
					}
					case 1264:
					{
						return "Flower of Frost";
					}
					case 1265:
					{
						return "Uzi";
					}
					case 1266:
					{
						return "Magnet Sphere";
					}
					case 1267:
					{
						return "Purple Stained Glass";
					}
					case 1268:
					{
						return "Yellow Stained Glass";
					}
					case 1269:
					{
						return "Blue Stained Glass";
					}
					case 1270:
					{
						return "Green Stained Glass";
					}
					case 1271:
					{
						return "Red Stained Glass";
					}
					case 1272:
					{
						return "Multicolored Stained Glass";
					}
					case 1273:
					{
						return "Skeletron Hand";
					}
					case 1274:
					{
						return "Skull";
					}
					case 1275:
					{
						return "Balla Hat";
					}
					case 1276:
					{
						return "Gangsta Hat";
					}
					case 1277:
					{
						return "Sailor Hat";
					}
					case 1278:
					{
						return "Eye Patch";
					}
					case 1279:
					{
						return "Sailor Shirt";
					}
					case 1280:
					{
						return "Sailor Pants";
					}
					case 1281:
					{
						return "Skeletron Mask";
					}
					case 1282:
					{
						return "Amethyst Robe";
					}
					case 1283:
					{
						return "Topaz Robe";
					}
					case 1284:
					{
						return "Sapphire Robe";
					}
					case 1285:
					{
						return "Emerald Robe";
					}
					case 1286:
					{
						return "Ruby Robe";
					}
					case 1287:
					{
						return "Diamond Robe";
					}
					case 1288:
					{
						return "White Tuxedo Shirt";
					}
					case 1289:
					{
						return "White Tuxedo Pants";
					}
					case 1290:
					{
						return "Panic Necklace";
					}
					case 1291:
					{
						return "Life Fruit";
					}
					case 1292:
					{
						return "Lihzahrd Altar";
					}
					case 1293:
					{
						return "Lihzahrd Power Cell";
					}
					case 1294:
					{
						return "Picksaw";
					}
					case 1295:
					{
						return "Heat Ray";
					}
					case 1296:
					{
						return "Staff of Earth";
					}
					case 1297:
					{
						return "Golem Fist";
					}
					case 1298:
					{
						return "Water Chest";
					}
					case 1299:
					{
						return "Binoculars";
					}
					case 1300:
					{
						return "Rifle Scope";
					}
					case 1301:
					{
						return "Destroyer Emblem";
					}
					case 1302:
					{
						return "High Velocity Bullet";
					}
					case 1303:
					{
						return "Jellyfish Necklace";
					}
					case 1304:
					{
						return "Zombie Arm";
					}
					case 1305:
					{
						return "The Axe";
					}
					case 1306:
					{
						return "Ice Sickle";
					}
					case 1307:
					{
						return "Clothier Voodoo Doll";
					}
					case 1308:
					{
						return "Poison Staff";
					}
					case 1309:
					{
						return "Slime Staff";
					}
					case 1310:
					{
						return "Poison Dart";
					}
					case 1311:
					{
						return "Eye Spring";
					}
					case 1312:
					{
						return "Toy Sled";
					}
					case 1313:
					{
						return "Book of Skulls";
					}
					case 1314:
					{
						return "KO Cannon";
					}
					case 1315:
					{
						return "Pirate Map";
					}
					case 1316:
					{
						return "Turtle Helmet";
					}
					case 1317:
					{
						return "Turtle Scale Mail";
					}
					case 1318:
					{
						return "Turtle Leggings";
					}
					case 1319:
					{
						return "Snowball Cannon";
					}
					case 1320:
					{
						return "Bone Pickaxe";
					}
					case 1321:
					{
						return "Magic Quiver";
					}
					case 1322:
					{
						return "Magma Stone";
					}
					case 1323:
					{
						return "Obsidian Rose";
					}
					case 1324:
					{
						return "Bananarang";
					}
					case 1325:
					{
						return "Chain Knife";
					}
					case 1326:
					{
						return "Rod of Discord";
					}
					case 1327:
					{
						return "Death Sickle";
					}
					case 1328:
					{
						return "Turtle Shell";
					}
					case 1329:
					{
						return "Tissue Sample";
					}
					case 1330:
					{
						return "Vertebrae";
					}
					case 1331:
					{
						return "Bloody Spine";
					}
					case 1332:
					{
						return "Ichor";
					}
					case 1333:
					{
						return "Ichor Torch";
					}
					case 1334:
					{
						return "Ichor Arrow";
					}
					case 1335:
					{
						return "Ichor Bullet";
					}
					case 1336:
					{
						return "Golden Shower";
					}
					case 1337:
					{
						return "Bunny Cannon";
					}
					case 1338:
					{
						return "Explosive Bunny";
					}
					case 1339:
					{
						return "Vial of Venom";
					}
					case 1340:
					{
						return "Flask of Venom";
					}
					case 1341:
					{
						return "Venom Arrow";
					}
					case 1342:
					{
						return "Venom Bullet";
					}
					case 1343:
					{
						return "Fire Gauntlet";
					}
					case 1344:
					{
						return "Cog";
					}
					case 1345:
					{
						return "Confetti";
					}
					case 1346:
					{
						return "Nanites";
					}
					case 1347:
					{
						return "Explosive Powder";
					}
					case 1348:
					{
						return "Gold Dust";
					}
					case 1349:
					{
						return "Party Bullet";
					}
					case 1350:
					{
						return "Nano Bullet";
					}
					case 1351:
					{
						return "Exploding Bullet";
					}
					case 1352:
					{
						return "Golden Bullet";
					}
					case 1353:
					{
						return "Flask of Cursed Flames";
					}
					case 1354:
					{
						return "Flask of Fire";
					}
					case 1355:
					{
						return "Flask of Gold";
					}
					case 1356:
					{
						return "Flask of Ichor";
					}
					case 1357:
					{
						return "Flask of Nanites";
					}
					case 1358:
					{
						return "Flask of Party";
					}
					case 1359:
					{
						return "Flask of Poison";
					}
					case 1360:
					{
						return "Eye of Cthulhu Trophy";
					}
					case 1361:
					{
						return "Eater of Worlds Trophy";
					}
					case 1362:
					{
						return "Brain of Cthulhu Trophy";
					}
					case 1363:
					{
						return "Skeletron Trophy";
					}
					case 1364:
					{
						return "Queen Bee Trophy";
					}
					case 1365:
					{
						return "Wall of Flesh Trophy";
					}
					case 1366:
					{
						return "Destroyer Trophy";
					}
					case 1367:
					{
						return "Skeletron Prime Trophy";
					}
					case 1368:
					{
						return "Retinazer Trophy";
					}
					case 1369:
					{
						return "Spazmatism Trophy";
					}
					case 1370:
					{
						return "Plantera Trophy";
					}
					case 1371:
					{
						return "Golem Trophy";
					}
					case 1372:
					{
						return "Blood Moon Rising";
					}
					case 1373:
					{
						return "The Hanged Man";
					}
					case 1374:
					{
						return "Glory of the Fire";
					}
					case 1375:
					{
						return "Bone Warp";
					}
					case 1376:
					{
						return "Wall Skeleton";
					}
					case 1377:
					{
						return "Hanging Skeleton";
					}
					case 1378:
					{
						return "Blue Slab Wall";
					}
					case 1379:
					{
						return "Blue Tiled Wall";
					}
					case 1380:
					{
						return "Pink Slab Wall";
					}
					case 1381:
					{
						return "Pink Tiled Wall";
					}
					case 1382:
					{
						return "Green Slab Wall";
					}
					case 1383:
					{
						return "Green Tiled Wall";
					}
					case 1384:
					{
						return "Blue Brick Platform";
					}
					case 1385:
					{
						return "Pink Brick Platform";
					}
					case 1386:
					{
						return "Green Brick Platform";
					}
					case 1387:
					{
						return "Metal Shelf";
					}
					case 1388:
					{
						return "Brass Shelf";
					}
					case 1389:
					{
						return "Wood Shelf";
					}
					case 1390:
					{
						return "Brass Lantern";
					}
					case 1391:
					{
						return "Caged Lantern";
					}
					case 1392:
					{
						return "Carriage Lantern";
					}
					case 1393:
					{
						return "Alchemy Lantern";
					}
					case 1394:
					{
						return "Diabolist Lamp";
					}
					case 1395:
					{
						return "Oil Rag Sconse";
					}
					case 1396:
					{
						return "Blue Dungeon Chair";
					}
					case 1397:
					{
						return "Blue Dungeon Table";
					}
					case 1398:
					{
						return "Blue Dungeon Work Bench";
					}
					case 1399:
					{
						return "Green Dungeon Chair";
					}
					case 1400:
					{
						return "Green Dungeon Table";
					}
					case 1401:
					{
						return "Green Dungeon Work Bench";
					}
					case 1402:
					{
						return "Pink Dungeon Chair";
					}
					case 1403:
					{
						return "Pink Dungeon Table";
					}
					case 1404:
					{
						return "Pink Dungeon Work Bench";
					}
					case 1405:
					{
						return "Blue Dungeon Candle";
					}
					case 1406:
					{
						return "Green Dungeon Candle";
					}
					case 1407:
					{
						return "Pink Dungeon Candle";
					}
					case 1408:
					{
						return "Blue Dungeon Vase";
					}
					case 1409:
					{
						return "Green Dungeon Vase";
					}
					case 1410:
					{
						return "Pink Dungeon Vase";
					}
					case 1411:
					{
						return "Blue Dungeon Door";
					}
					case 1412:
					{
						return "Green Dungeon Door";
					}
					case 1413:
					{
						return "Pink Dungeon Door";
					}
					case 1414:
					{
						return "Blue Dungeon Bookcase";
					}
					case 1415:
					{
						return "Green Dungeon Bookcase";
					}
					case 1416:
					{
						return "Pink Dungeon Bookcase";
					}
					case 1417:
					{
						return "Catacomb";
					}
					case 1418:
					{
						return "Dungeon Shelf";
					}
					case 1419:
					{
						return "Skellington J Skellingsworth";
					}
					case 1420:
					{
						return "The Cursed Man";
					}
					case 1421:
					{
						return "The Eye Sees the End";
					}
					case 1422:
					{
						return "Something Evil is Watching You";
					}
					case 1423:
					{
						return "The Twins Have Awoken";
					}
					case 1424:
					{
						return "The Screamer";
					}
					case 1425:
					{
						return "Goblins Playing Poker";
					}
					case 1426:
					{
						return "Dryadisque";
					}
					case 1427:
					{
						return "Sunflowers";
					}
					case 1428:
					{
						return "Terrarian Gothic";
					}
					case 1429:
					{
						return "Beanie";
					}
					case 1430:
					{
						return "Imbuing Station";
					}
					case 1431:
					{
						return "Star in a Bottle";
					}
					case 1432:
					{
						return "Empty Bullet";
					}
					case 1433:
					{
						return "Impact";
					}
					case 1434:
					{
						return "Powered by Birds";
					}
					case 1435:
					{
						return "The Destroyer";
					}
					case 1436:
					{
						return "The Persistency of Eyes";
					}
					case 1437:
					{
						return "Unicorn Crossing the Hallows";
					}
					case 1438:
					{
						return "Great Wave";
					}
					case 1439:
					{
						return "Starry Night";
					}
					case 1440:
					{
						return "Guide Picasso";
					}
					case 1441:
					{
						return "The Guardian's Gaze";
					}
					case 1442:
					{
						return "Father of Someone";
					}
					case 1443:
					{
						return "Nurse Lisa";
					}
					case 1444:
					{
						return "Shadowbeam Staff";
					}
					case 1445:
					{
						return "Inferno Fork";
					}
					case 1446:
					{
						return "Spectre Staff";
					}
					case 1447:
					{
						return "Wooden Fence";
					}
					case 1448:
					{
						return "Lead Fence";
					}
					case 1449:
					{
						return "Bubble Machine";
					}
					case 1450:
					{
						return "Bubble Wand";
					}
					case 1451:
					{
						return "Marching Bones Banner";
					}
					case 1452:
					{
						return "Necromantic Sign";
					}
					case 1453:
					{
						return "Rusted Company Standard";
					}
					case 1454:
					{
						return "Ragged Brotherhood Sigil";
					}
					case 1455:
					{
						return "Molten Legion Flag";
					}
					case 1456:
					{
						return "Diabolic Sigil";
					}
					case 1457:
					{
						return "Obsidian Platform";
					}
					case 1458:
					{
						return "Obsidian Door";
					}
					case 1459:
					{
						return "Obsidian Chair";
					}
					case 1460:
					{
						return "Obsidian Table";
					}
					case 1461:
					{
						return "Obsidian Work Bench";
					}
					case 1462:
					{
						return "Obsidian Vase";
					}
					case 1463:
					{
						return "Obsidian Bookcase";
					}
					case 1464:
					{
						return "Hellbound Banner";
					}
					case 1465:
					{
						return "Hell Hammer Banner";
					}
					case 1466:
					{
						return "Helltower Banner";
					}
					case 1467:
					{
						return "Lost Hopes of Man Banner";
					}
					case 1468:
					{
						return "Obsidian Watcher Banner";
					}
					case 1469:
					{
						return "Lava Erupts Banner";
					}
					case 1470:
					{
						return "Blue Dungeon Bed";
					}
					case 1471:
					{
						return "Green Dungeon Bed";
					}
					case 1472:
					{
						return "Pink Dungeon Bed";
					}
					case 1473:
					{
						return "Obsidian Bed";
					}
					case 1474:
					{
						return "Waldo";
					}
					case 1475:
					{
						return "Darkness";
					}
					case 1476:
					{
						return "Dark Soul Reaper";
					}
					case 1477:
					{
						return "Land";
					}
					case 1478:
					{
						return "Trapped Ghost";
					}
					case 1479:
					{
						return "Demon's Eye";
					}
					case 1480:
					{
						return "Finding Gold";
					}
					case 1481:
					{
						return "First Encounter";
					}
					case 1482:
					{
						return "Good Morning";
					}
					case 1483:
					{
						return "Underground Reward";
					}
					case 1484:
					{
						return "Through the Window";
					}
					case 1485:
					{
						return "Place Above the Clouds";
					}
					case 1486:
					{
						return "Do Not Step on the Grass";
					}
					case 1487:
					{
						return "Cold Waters in the White Land";
					}
					case 1488:
					{
						return "Lightless Chasms";
					}
					case 1489:
					{
						return "The Land of Deceiving Looks";
					}
					case 1490:
					{
						return "Daylight";
					}
					case 1491:
					{
						return "Secret of the Sands";
					}
					case 1492:
					{
						return "Deadland Comes Alive";
					}
					case 1493:
					{
						return "Evil Presence";
					}
					case 1494:
					{
						return "Sky Guardian";
					}
					case 1495:
					{
						return "American Explosive";
					}
					case 1496:
					{
						return "Discover";
					}
					case 1497:
					{
						return "Hand Earth";
					}
					case 1498:
					{
						return "Old Miner";
					}
					case 1499:
					{
						return "Skelehead";
					}
					case 1500:
					{
						return "Facing the Cerebral Mastermind";
					}
					case 1501:
					{
						return "Lake of Fire";
					}
					case 1502:
					{
						return "Trio Super Heroes";
					}
					case 1503:
					{
						return "Spectre Hood";
					}
					case 1504:
					{
						return "Spectre Robe";
					}
					case 1505:
					{
						return "Spectre Pants";
					}
					case 1506:
					{
						return "Spectre Pickaxe";
					}
					case 1507:
					{
						return "Spectre Hamaxe";
					}
					case 1508:
					{
						return "Ectoplasm";
					}
					case 1509:
					{
						return "Gothic Chair";
					}
					case 1510:
					{
						return "Gothic Table";
					}
					case 1511:
					{
						return "Gothic Work Bench";
					}
					case 1512:
					{
						return "Gothic Bookcase";
					}
					case 1513:
					{
						return "Paladin's Hammer";
					}
					case 1514:
					{
						return "SWAT Helmet";
					}
					case 1515:
					{
						return "Bee Wings";
					}
					case 1516:
					{
						return "Giant Harpy Feather";
					}
					case 1517:
					{
						return "Bone Feather";
					}
					case 1518:
					{
						return "Fire Feather";
					}
					case 1519:
					{
						return "Ice Feather";
					}
					case 1520:
					{
						return "Broken Bat Wing";
					}
					case 1521:
					{
						return "Tattered Bee Wing";
					}
					case 1522:
					{
						return "Large Amethyst";
					}
					case 1523:
					{
						return "Large Topaz";
					}
					case 1524:
					{
						return "Large Sapphire";
					}
					case 1525:
					{
						return "Large Emerald";
					}
					case 1526:
					{
						return "Large Ruby";
					}
					case 1527:
					{
						return "Large Diamond";
					}
					case 1528:
					{
						return "Jungle Chest";
					}
					case 1529:
					{
						return "Corruption Chest";
					}
					case 1530:
					{
						return "Crimson Chest";
					}
					case 1531:
					{
						return "Hallowed Chest";
					}
					case 1532:
					{
						return "Frozen Chest";
					}
					case 1533:
					{
						return "Jungle Key";
					}
					case 1534:
					{
						return "Corruption Key";
					}
					case 1535:
					{
						return "Crimson Key";
					}
					case 1536:
					{
						return "Hallowed Key";
					}
					case 1537:
					{
						return "Frozen Key";
					}
					case 1538:
					{
						return "Imp Face";
					}
					case 1539:
					{
						return "Ominous Presence";
					}
					case 1540:
					{
						return "Shining Moon";
					}
					case 1541:
					{
						return "Living Gore";
					}
					case 1542:
					{
						return "Flowing Magma";
					}
					case 1543:
					{
						return "Spectre Paintbrush";
					}
					case 1544:
					{
						return "Spectre Paint Roller";
					}
					case 1545:
					{
						return "Spectre Paint Scraper";
					}
					case 1546:
					{
						return "Shroomite Headgear";
					}
					case 1547:
					{
						return "Shroomite Mask";
					}
					case 1548:
					{
						return "Shroomite Helmet";
					}
					case 1549:
					{
						return "Shroomite Breastplate";
					}
					case 1550:
					{
						return "Shroomite Leggings";
					}
					case 1551:
					{
						return "Autohammer";
					}
					case 1552:
					{
						return "Shroomite Bar";
					}
					case 1553:
					{
						return "S.D.M.G.";
					}
					case 1554:
					{
						return "Cenx's Tiara";
					}
					case 1555:
					{
						return "Cenx's Breastplate";
					}
					case 1556:
					{
						return "Cenx's Leggings";
					}
					case 1557:
					{
						return "Crowno's Mask";
					}
					case 1558:
					{
						return "Crowno's Breastplate";
					}
					case 1559:
					{
						return "Crowno's Leggings";
					}
					case 1560:
					{
						return "Will's Helmet";
					}
					case 1561:
					{
						return "Will's Breastplate";
					}
					case 1562:
					{
						return "Will's Leggings";
					}
					case 1563:
					{
						return "Jim's Helmet";
					}
					case 1564:
					{
						return "Jim's Breastplate";
					}
					case 1565:
					{
						return "Jim's Leggings";
					}
					case 1566:
					{
						return "Aaron's Helmet";
					}
					case 1567:
					{
						return "Aaron's Breastplate";
					}
					case 1568:
					{
						return "Aaron's Leggings";
					}
					case 1569:
					{
						return "Vampire Knives";
					}
					case 1570:
					{
						return "Broken Hero Sword";
					}
					case 1571:
					{
						return "Scourge of the Corruptor";
					}
					case 1572:
					{
						return "Staff of the Frost Hydra";
					}
					case 1573:
					{
						return "The Creation of the Guide";
					}
					case 1574:
					{
						return "The Merchant";
					}
					case 1575:
					{
						return "Crowno Devours His Lunch";
					}
					case 1576:
					{
						return "Rare Enchantment";
					}
					case 1577:
					{
						return "Glorious Night";
					}
					case 1578:
					{
						return "Sweetheart Necklace";
					}
					case 1579:
					{
						return "Flurry Boots";
					}
					case 1580:
					{
						return "D-Town's Helmet";
					}
					case 1581:
					{
						return "D-Town's Breastplate";
					}
					case 1582:
					{
						return "D-Town's Leggings";
					}
					case 1583:
					{
						return "D-Town's Wings";
					}
					case 1584:
					{
						return "Will's Wings";
					}
					case 1585:
					{
						return "Crowno's Wings";
					}
					case 1586:
					{
						return "Cenx's Wings";
					}
					case 1587:
					{
						return "Cenx's Dress";
					}
					case 1588:
					{
						return "Cenx's Dress Pants";
					}
					case 1589:
					{
						return "Palladium Column";
					}
					case 1590:
					{
						return "Palladium Column Wall";
					}
					case 1591:
					{
						return "Bubblegum Block";
					}
					case 1592:
					{
						return "Bubblegum Block Wall";
					}
					case 1593:
					{
						return "Titanstone Block";
					}
					case 1594:
					{
						return "Titanstone Block Wall";
					}
					case 1595:
					{
						return "Magic Cuffs";
					}
					case 1596:
					{
						return "Music Box (Snow)";
					}
					case 1597:
					{
						return "Music Box (Space)";
					}
					case 1598:
					{
						return "Music Box (Crimson)";
					}
					case 1599:
					{
						return "Music Box (Boss 4)";
					}
					case 1600:
					{
						return "Music Box (Alt Overworld Day)";
					}
					case 1601:
					{
						return "Music Box (Rain)";
					}
					case 1602:
					{
						return "Music Box (Ice)";
					}
					case 1603:
					{
						return "Music Box (Desert)";
					}
					case 1604:
					{
						return "Music Box (Ocean)";
					}
					case 1605:
					{
						return "Music Box (Dungeon)";
					}
					case 1606:
					{
						return "Music Box (Plantera)";
					}
					case 1607:
					{
						return "Music Box (Boss 5)";
					}
					case 1608:
					{
						return "Music Box (Temple)";
					}
					case 1609:
					{
						return "Music Box (Eclipse)";
					}
					case 1610:
					{
						return "Music Box (Mushrooms)";
					}
					case 1611:
					{
						return "Butterfly Dust";
					}
					case 1612:
					{
						return "Ankh Charm";
					}
					case 1613:
					{
						return "Ankh Shield";
					}
					case 1614:
					{
						return "Blue Flare";
					}
					case 1615:
					{
						return "Angler Fish Banner";
					}
					case 1616:
					{
						return "Angry Nimbus Banner";
					}
					case 1617:
					{
						return "Anomura Fungus Banner";
					}
					case 1618:
					{
						return "Antlion Banner";
					}
					case 1619:
					{
						return "Arapaima Banner";
					}
					case 1620:
					{
						return "Armored Skeleton Banner";
					}
					case 1621:
					{
						return "Cave Bat Banner";
					}
					case 1622:
					{
						return "Bird Banner";
					}
					case 1623:
					{
						return "Black Recluse Banner";
					}
					case 1624:
					{
						return "Blood Feeder Banner";
					}
					case 1625:
					{
						return "Blood Jelly Banner";
					}
					case 1626:
					{
						return "Blood Crawler Banner";
					}
					case 1627:
					{
						return "Bone Serpent Banner";
					}
					case 1628:
					{
						return "Bunny Banner";
					}
					case 1629:
					{
						return "Chaos Elemental Banner";
					}
					case 1630:
					{
						return "Mimic Banner";
					}
					case 1631:
					{
						return "Clown Banner";
					}
					case 1632:
					{
						return "Corrupt Bunny Banner";
					}
					case 1633:
					{
						return "Corrupt Goldfish Banner";
					}
					case 1634:
					{
						return "Crab Banner";
					}
					case 1635:
					{
						return "Crimera Banner";
					}
					case 1636:
					{
						return "Crimson Axe Banner";
					}
					case 1637:
					{
						return "Cursed Hammer Banner";
					}
					case 1638:
					{
						return "Demon Banner";
					}
					case 1639:
					{
						return "Demon Eye Banner";
					}
					case 1640:
					{
						return "Derpling Banner";
					}
					case 1641:
					{
						return "Eater of Souls Banner";
					}
					case 1642:
					{
						return "Enchanted Sword Banner";
					}
					case 1643:
					{
						return "Zombie Eskimo Banner";
					}
					case 1644:
					{
						return "Face Monster Banner";
					}
					case 1645:
					{
						return "Floaty Gross Banner";
					}
					case 1646:
					{
						return "Flying Fish Banner";
					}
					case 1647:
					{
						return "Flying Snake Banner";
					}
					case 1648:
					{
						return "Frankenstein Banner";
					}
					case 1649:
					{
						return "Fungi Bulb Banner";
					}
					case 1650:
					{
						return "Fungo Fish Banner";
					}
					case 1651:
					{
						return "Gastropod Banner";
					}
					case 1652:
					{
						return "Goblin Thief Banner";
					}
					case 1653:
					{
						return "Goblin Sorcerer Banner";
					}
					case 1654:
					{
						return "Goblin Peon Banner";
					}
					case 1655:
					{
						return "Goblin Scout Banner";
					}
					case 1656:
					{
						return "Goblin Warrior Banner";
					}
					case 1657:
					{
						return "Goldfish Banner";
					}
					case 1658:
					{
						return "Harpy Banner";
					}
					case 1659:
					{
						return "Hellbat Banner";
					}
					case 1660:
					{
						return "Herpling Banner";
					}
					case 1661:
					{
						return "Hornet Banner";
					}
					case 1662:
					{
						return "Ice Elemental Banner";
					}
					case 1663:
					{
						return "Icy Merman Banner";
					}
					case 1664:
					{
						return "Fire Imp Banner";
					}
					case 1665:
					{
						return "Blue Jellyfish Banner";
					}
					case 1666:
					{
						return "Jungle Creeper Banner";
					}
					case 1667:
					{
						return "Lihzahrd Banner";
					}
					case 1668:
					{
						return "Man Eater Banner";
					}
					case 1669:
					{
						return "Meteor Head Banner";
					}
					case 1670:
					{
						return "Moth Banner";
					}
					case 1671:
					{
						return "Mummy Banner";
					}
					case 1672:
					{
						return "Mushi Ladybug Banner";
					}
					case 1673:
					{
						return "Parrot Banner";
					}
					case 1674:
					{
						return "Pigron Banner";
					}
					case 1675:
					{
						return "Piranha Banner";
					}
					case 1676:
					{
						return "Pirate Deckhand Banner";
					}
					case 1677:
					{
						return "Pixie Banner";
					}
					case 1678:
					{
						return "Raincoat Zombie Banner";
					}
					case 1679:
					{
						return "Reaper Banner";
					}
					case 1680:
					{
						return "Shark Banner";
					}
					case 1681:
					{
						return "Skeleton Banner";
					}
					case 1682:
					{
						return "Dark Caster Mage Banner";
					}
					case 1683:
					{
						return "Blue Slime Banner";
					}
					case 1684:
					{
						return "Snow Flinx Banner";
					}
					case 1685:
					{
						return "Wall Creeper Banner";
					}
					case 1686:
					{
						return "Spore Zombie Banner";
					}
					case 1687:
					{
						return "Swamp Thing Banner";
					}
					case 1688:
					{
						return "Giant Tortoise Banner";
					}
					case 1689:
					{
						return "Toxic Sludge Banner";
					}
					case 1690:
					{
						return "Umbrella Slime Banner";
					}
					case 1691:
					{
						return "Unicorn Banner";
					}
					case 1692:
					{
						return "Vampire Banner";
					}
					case 1693:
					{
						return "Vulture Banner";
					}
					case 1694:
					{
						return "Nymph Banner";
					}
					case 1695:
					{
						return "Werewolf Banner";
					}
					case 1696:
					{
						return "Wolf Banner";
					}
					case 1697:
					{
						return "World Feeder Banner";
					}
					case 1698:
					{
						return "Worm Banner";
					}
					case 1699:
					{
						return "Wraith Banner";
					}
					case 1700:
					{
						return "Wyvern Banner";
					}
					case 1701:
					{
						return "Zombie Banner";
					}
					case 1702:
					{
						return "Glass Platform";
					}
					case 1703:
					{
						return "Glass Chair";
					}
					case 1704:
					{
						return "Golden Chair";
					}
					case 1705:
					{
						return "Golden Toilet";
					}
					case 1706:
					{
						return "Bar Stool";
					}
					case 1707:
					{
						return "Honey Chair";
					}
					case 1708:
					{
						return "Steampunk Chair";
					}
					case 1709:
					{
						return "Glass Door";
					}
					case 1710:
					{
						return "Golden Door";
					}
					case 1711:
					{
						return "Honey Door";
					}
					case 1712:
					{
						return "Steampunk Door";
					}
					case 1713:
					{
						return "Glass Table";
					}
					case 1714:
					{
						return "Banquet Table";
					}
					case 1715:
					{
						return "Bar";
					}
					case 1716:
					{
						return "Golden Table";
					}
					case 1717:
					{
						return "Honey Table";
					}
					case 1718:
					{
						return "Steampunk Table";
					}
					case 1719:
					{
						return "Glass Bed";
					}
					case 1720:
					{
						return "Golden Bed";
					}
					case 1721:
					{
						return "Honey Bed";
					}
					case 1722:
					{
						return "Steampunk Bed";
					}
					case 1723:
					{
						return "Living Wood Wall";
					}
					case 1724:
					{
						return "Fart in a Jar";
					}
					case 1725:
					{
						return "Pumpkin";
					}
					case 1726:
					{
						return "Pumpkin Wall";
					}
					case 1727:
					{
						return "Hay";
					}
					case 1728:
					{
						return "Hay Wall";
					}
					case 1729:
					{
						return "Spooky Wood";
					}
					case 1730:
					{
						return "Spooky Wood Wall";
					}
					case 1731:
					{
						return "Pumpkin Helmet";
					}
					case 1732:
					{
						return "Pumpkin Breastplate";
					}
					case 1733:
					{
						return "Pumpkin Leggings";
					}
					case 1734:
					{
						return "Candy Apple";
					}
					case 1735:
					{
						return "Soul Cake";
					}
					case 1736:
					{
						return "Nurse Hat";
					}
					case 1737:
					{
						return "Nurse Shirt";
					}
					case 1738:
					{
						return "Nurse Pants";
					}
					case 1739:
					{
						return "Wizard's Hat";
					}
					case 1740:
					{
						return "Guy Fawkes Mask";
					}
					case 1741:
					{
						return "Dye Trader Robe";
					}
					case 1742:
					{
						return "Steampunk Goggles";
					}
					case 1743:
					{
						return "Cyborg Helmet";
					}
					case 1744:
					{
						return "Cyborg Shirt";
					}
					case 1745:
					{
						return "Cyborg Pants";
					}
					case 1746:
					{
						return "Creeper Mask";
					}
					case 1747:
					{
						return "Creeper Shirt";
					}
					case 1748:
					{
						return "Creeper Pants";
					}
					case 1749:
					{
						return "Cat Mask";
					}
					case 1750:
					{
						return "Cat Shirt";
					}
					case 1751:
					{
						return "Cat Pants";
					}
					case 1752:
					{
						return "Ghost Mask";
					}
					case 1753:
					{
						return "Ghost Shirt";
					}
					case 1754:
					{
						return "Pumpkin Mask";
					}
					case 1755:
					{
						return "Pumpkin Shirt";
					}
					case 1756:
					{
						return "Pumpkin Pants";
					}
					case 1757:
					{
						return "Robot Mask";
					}
					case 1758:
					{
						return "Robot Shirt";
					}
					case 1759:
					{
						return "Robot Pants";
					}
					case 1760:
					{
						return "Unicorn Mask";
					}
					case 1761:
					{
						return "Unicorn Shirt";
					}
					case 1762:
					{
						return "Unicorn Pants";
					}
					case 1763:
					{
						return "Vampire Mask";
					}
					case 1764:
					{
						return "Vampire Shirt";
					}
					case 1765:
					{
						return "Vampire Pants";
					}
					case 1766:
					{
						return "Witch Hat";
					}
					case 1767:
					{
						return "Leprechaun Hat";
					}
					case 1768:
					{
						return "Leprechaun Shirt";
					}
					case 1769:
					{
						return "Leprechaun Pants";
					}
					case 1770:
					{
						return "Pixie Shirt";
					}
					case 1771:
					{
						return "Pixie Pants";
					}
					case 1772:
					{
						return "Princess Hat";
					}
					case 1773:
					{
						return "Princess Dress";
					}
					case 1774:
					{
						return "Goodie Bag";
					}
					case 1775:
					{
						return "Witch Dress";
					}
					case 1776:
					{
						return "Witch Boots";
					}
					case 1777:
					{
						return "Bride of Frankenstein Mask";
					}
					case 1778:
					{
						return "Bride of Frankenstein Dress";
					}
					case 1779:
					{
						return "Karate Tortoise Mask";
					}
					case 1780:
					{
						return "Karate Tortoise Shirt";
					}
					case 1781:
					{
						return "Karate Tortoise Pants";
					}
					case 1782:
					{
						return "Candy Corn Rifle";
					}
					case 1783:
					{
						return "Candy Corn";
					}
					case 1784:
					{
						return "Jack 'O Lantern Launcher";
					}
					case 1785:
					{
						return "Explosive Jack 'O Lantern";
					}
					case 1786:
					{
						return "Sickle";
					}
					case 1787:
					{
						return "Pumpkin Pie";
					}
					case 1788:
					{
						return "Scarecrow Hat";
					}
					case 1789:
					{
						return "Scarecrow Shirt";
					}
					case 1790:
					{
						return "Scarecrow Pants";
					}
					case 1791:
					{
						return "Cauldron";
					}
					case 1792:
					{
						return "Pumpkin Chair";
					}
					case 1793:
					{
						return "Pumpkin Door";
					}
					case 1794:
					{
						return "Pumpkin Table";
					}
					case 1795:
					{
						return "Pumpkin Work Bench";
					}
					case 1796:
					{
						return "Pumpkin Platform";
					}
					case 1797:
					{
						return "Tattered Fairy Wings";
					}
					case 1798:
					{
						return "Spider Egg";
					}
					case 1799:
					{
						return "Magical Pumpkin Seed";
					}
					case 1800:
					{
						return "Bat Hook";
					}
					case 1801:
					{
						return "Bat Scepter";
					}
					case 1802:
					{
						return "Raven Staff";
					}
					case 1803:
					{
						return "Jungle Key Mold";
					}
					case 1804:
					{
						return "Corruption Key Mold";
					}
					case 1805:
					{
						return "Crimson Key Mold";
					}
					case 1806:
					{
						return "Hallowed Key Mold";
					}
					case 1807:
					{
						return "Frozen Key Mold";
					}
					case 1808:
					{
						return "Hanging Jack 'O Lantern";
					}
					case 1809:
					{
						return "Rotten Egg";
					}
					case 1810:
					{
						return "Unlucky Yarn";
					}
					case 1811:
					{
						return "Black Fairy Dust";
					}
					case 1812:
					{
						return "Jackelier";
					}
					case 1813:
					{
						return "Jack 'O Lantern";
					}
					case 1814:
					{
						return "Spooky Chair";
					}
					case 1815:
					{
						return "Spooky Door";
					}
					case 1816:
					{
						return "Spooky Table";
					}
					case 1817:
					{
						return "Spooky Work Bench";
					}
					case 1818:
					{
						return "Spooky Platform";
					}
					case 1819:
					{
						return "Reaper Hood";
					}
					case 1820:
					{
						return "Reaper Robe";
					}
					case 1821:
					{
						return "Fox Mask";
					}
					case 1822:
					{
						return "Fox Shirt";
					}
					case 1823:
					{
						return "Fox Pants";
					}
					case 1824:
					{
						return "Cat Ears";
					}
					case 1825:
					{
						return "Bloody Machete";
					}
					case 1826:
					{
						return "The Horseman's Blade";
					}
					case 1827:
					{
						return "Bladed Glove";
					}
					case 1828:
					{
						return "Pumpkin Seed";
					}
					case 1829:
					{
						return "Spooky Hook";
					}
					case 1830:
					{
						return "Spooky Wings";
					}
					case 1831:
					{
						return "Spooky Twig";
					}
					case 1832:
					{
						return "Spooky Helmet";
					}
					case 1833:
					{
						return "Spooky Breastplate";
					}
					case 1834:
					{
						return "Spooky Leggings";
					}
					case 1835:
					{
						return "Stake Launcher";
					}
					case 1836:
					{
						return "Stake";
					}
					case 1837:
					{
						return "Cursed Sapling";
					}
					case 1838:
					{
						return "Space Creature Mask";
					}
					case 1839:
					{
						return "Space Creature Shirt";
					}
					case 1840:
					{
						return "Space Creature Pants";
					}
					case 1841:
					{
						return "Wolf Mask";
					}
					case 1842:
					{
						return "Wolf Shirt";
					}
					case 1843:
					{
						return "Wolf Pants";
					}
					case 1844:
					{
						return "Pumpkin Moon Medallion";
					}
					case 1845:
					{
						return "Necromantic Scroll";
					}
					case 1846:
					{
						return "Jacking Skeletron";
					}
					case 1847:
					{
						return "Bitter Harvest";
					}
					case 1848:
					{
						return "Blood Moon Countess";
					}
					case 1849:
					{
						return "Hallow's Eve";
					}
					case 1850:
					{
						return "Morbid Curiosity";
					}
					case 1851:
					{
						return "Treasure Hunter Shirt";
					}
					case 1852:
					{
						return "Treasure Hunter Pants";
					}
					case 1853:
					{
						return "Dryad Coverings";
					}
					case 1854:
					{
						return "Dryad Loincloth";
					}
					case 1855:
					{
						return "Mourning Wood Trophy";
					}
					case 1856:
					{
						return "Pumpking Trophy";
					}
					case 1857:
					{
						return "Jack 'O Lantern Mask";
					}
					case 1858:
					{
						return "Sniper Scope";
					}
					case 1859:
					{
						return "Heart Lantern";
					}
					case 1860:
					{
						return "Jellyfish Diving Gear";
					}
					case 1861:
					{
						return "Arctic Diving Gear";
					}
					case 1862:
					{
						return "Frostspark Boots";
					}
					case 1863:
					{
						return "Fart in a Balloon";
					}
					case 1864:
					{
						return "Papyrus Scarab";
					}
					case 1865:
					{
						return "Celestial Stone";
					}
					case 1866:
					{
						return "Hoverboard";
					}
					case 1867:
					{
						return "Candy Cane";
					}
					case 1868:
					{
						return "Sugar Plum";
					}
					case 1869:
					{
						return "Present";
					}
					case 1870:
					{
						return "Red Ryder";
					}
					case 1871:
					{
						return "Festive Wings";
					}
					case 1872:
					{
						return "Pine Tree Block";
					}
					case 1873:
					{
						return "Christmas Tree";
					}
					case 1874:
					{
						return "Star Topper 1";
					}
					case 1875:
					{
						return "Star Topper 2";
					}
					case 1876:
					{
						return "Star Topper 3";
					}
					case 1877:
					{
						return "Bow Topper";
					}
					case 1878:
					{
						return "White Garland";
					}
					case 1879:
					{
						return "White and Red Garland";
					}
					case 1880:
					{
						return "Red Garland";
					}
					case 1881:
					{
						return "Red and Green Garland";
					}
					case 1882:
					{
						return "Green Garland";
					}
					case 1883:
					{
						return "Green and White Garland";
					}
					case 1884:
					{
						return "Multicolored Bulb";
					}
					case 1885:
					{
						return "Red Bulb";
					}
					case 1886:
					{
						return "Yellow Bulb";
					}
					case 1887:
					{
						return "Green Bulb";
					}
					case 1888:
					{
						return "Red and Green Bulb";
					}
					case 1889:
					{
						return "Yellow and Green Bulb";
					}
					case 1890:
					{
						return "Red and Yellow Bulb";
					}
					case 1891:
					{
						return "White Bulb";
					}
					case 1892:
					{
						return "White and Red Bulb";
					}
					case 1893:
					{
						return "White and Yellow Bulb";
					}
					case 1894:
					{
						return "White and Green Bulb";
					}
					case 1895:
					{
						return "Multicolored Lights";
					}
					case 1896:
					{
						return "Red Lights";
					}
					case 1897:
					{
						return "Green Lights";
					}
					case 1898:
					{
						return "Blue Lights";
					}
					case 1899:
					{
						return "Yellow Lights";
					}
					case 1900:
					{
						return "Red and Yellow Lights";
					}
					case 1901:
					{
						return "Red and Green Lights";
					}
					case 1902:
					{
						return "Yellow and Green Lights";
					}
					case 1903:
					{
						return "Blue and Green Lights";
					}
					case 1904:
					{
						return "Red and Blue Lights";
					}
					case 1905:
					{
						return "Blue and Yellow Lights";
					}
					case 1906:
					{
						return "Giant Bow";
					}
					case 1907:
					{
						return "Reindeer Antlers";
					}
					case 1908:
					{
						return "Holly";
					}
					case 1909:
					{
						return "Candy Cane Sword";
					}
					case 1910:
					{
						return "Elf Melter";
					}
					case 1911:
					{
						return "Christmas Pudding";
					}
					case 1912:
					{
						return "Eggnog";
					}
					case 1913:
					{
						return "Star Anise";
					}
					case 1914:
					{
						return "Reindeer Bells";
					}
					case 1915:
					{
						return "Candy Cane Hook";
					}
					case 1916:
					{
						return "Christmas Hook";
					}
					case 1917:
					{
						return "Candy Cane Pickaxe";
					}
					case 1918:
					{
						return "Fruitcake Chakram";
					}
					case 1919:
					{
						return "Sugar Cookie";
					}
					case 1920:
					{
						return "Gingerbread Cookie";
					}
					case 1921:
					{
						return "Hand Warmer";
					}
					case 1922:
					{
						return "Coal";
					}
					case 1923:
					{
						return "Toolbox";
					}
					case 1924:
					{
						return "Pine Door";
					}
					case 1925:
					{
						return "Pine Chair";
					}
					case 1926:
					{
						return "Pine Table";
					}
					case 1927:
					{
						return "Dog Whistle";
					}
					case 1928:
					{
						return "Christmas Tree Sword";
					}
					case 1929:
					{
						return "Chain Gun";
					}
					case 1930:
					{
						return "Razorpine";
					}
					case 1931:
					{
						return "Blizzard Staff";
					}
					case 1932:
					{
						return "Mrs. Claus Hat";
					}
					case 1933:
					{
						return "Mrs. Claus Shirt";
					}
					case 1934:
					{
						return "Mrs. Claus Heels";
					}
					case 1935:
					{
						return "Parka Hood";
					}
					case 1936:
					{
						return "Parka Coat";
					}
					case 1937:
					{
						return "Parka Pants";
					}
					case 1938:
					{
						return "Snow Hat";
					}
					case 1939:
					{
						return "Ugly Sweater";
					}
					case 1940:
					{
						return "Tree Mask";
					}
					case 1941:
					{
						return "Tree Shirt";
					}
					case 1942:
					{
						return "Tree Trunks";
					}
					case 1943:
					{
						return "Elf Hat";
					}
					case 1944:
					{
						return "Elf Shirt";
					}
					case 1945:
					{
						return "Elf Pants";
					}
					case 1946:
					{
						return "Snowman Cannon";
					}
					case 1947:
					{
						return "North Pole";
					}
					case 1948:
					{
						return "Christmas Tree Wallpaper";
					}
					case 1949:
					{
						return "Ornament Wallpaper";
					}
					case 1950:
					{
						return "Candy Cane Wallpaper";
					}
					case 1951:
					{
						return "Festive Wallpaper";
					}
					case 1952:
					{
						return "Stars Wallpaper";
					}
					case 1953:
					{
						return "Squiggles Wallpaper";
					}
					case 1954:
					{
						return "Snowflake Wallpaper";
					}
					case 1955:
					{
						return "Krampus Horn Wallpaper";
					}
					case 1956:
					{
						return "Bluegreen Wallpaper";
					}
					case 1957:
					{
						return "Grinch Finger Wallpaper";
					}
					case 1958:
					{
						return "Naughty Present";
					}
					case 1959:
					{
						return "Baby Grinch's Mischief Whistle";
					}
					case 1960:
					{
						return "Ice Queen Trophy";
					}
					case 1961:
					{
						return "Santa-NK1 Trophy";
					}
					case 1962:
					{
						return "Everscream Trophy";
					}
					case 1963:
					{
						return "Music Box (Pumpkin Moon)";
					}
					case 1964:
					{
						return "Music Box (Alt Underground)";
					}
					case 1965:
					{
						return "Music Box (Frost Moon)";
					}
					case 1966:
					{
						return "Brown Paint";
					}
					case 1967:
					{
						return "Shadow Paint";
					}
					case 1968:
					{
						return "Negative Paint";
					}
					case 1969:
					{
						return "Team Dye";
					}
					case 1970:
					{
						return "Amethyst Gemspark Block";
					}
					case 1971:
					{
						return "Topaz Gemspark Block";
					}
					case 1972:
					{
						return "Sapphire Gemspark Block";
					}
					case 1973:
					{
						return "Emerald Gemspark Block";
					}
					case 1974:
					{
						return "Ruby Gemspark Block";
					}
					case 1975:
					{
						return "Diamond Gemspark Block";
					}
					case 1976:
					{
						return "Amber Gemspark Block";
					}
					case 1977:
					{
						return "Life Hair Dye";
					}
					case 1978:
					{
						return "Mana Hair Dye";
					}
					case 1979:
					{
						return "Depth Hair Dye";
					}
					case 1980:
					{
						return "Money Hair Dye";
					}
					case 1981:
					{
						return "Time Hair Dye";
					}
					case 1982:
					{
						return "Team Hair Dye";
					}
					case 1983:
					{
						return "Biome Hair Dye";
					}
					case 1984:
					{
						return "Party Hair Dye";
					}
					case 1985:
					{
						return "Rainbow Hair Dye";
					}
					case 1986:
					{
						return "Speed Hair Dye";
					}
					case 1987:
					{
						return "Angel Halo";
					}
					case 1988:
					{
						return "Fez";
					}
					case 1989:
					{
						return "Womannequin";
					}
					case 1990:
					{
						return "Hair Dye Remover";
					}
					case 1991:
					{
						return "Bug Net";
					}
					case 1992:
					{
						return "Firefly";
					}
					case 1993:
					{
						return "Firefly in a Bottle";
					}
					case 1994:
					{
						return "Monarch Butterfly";
					}
					case 1995:
					{
						return "Purple Emperor Butterfly";
					}
					case 1996:
					{
						return "Red Admiral Butterfly";
					}
					case 1997:
					{
						return "Ulysses Butterfly";
					}
					case 1998:
					{
						return "Sulphur Butterfly";
					}
					case 1999:
					{
						return "Tree Nymph Butterfly";
					}
					case 2000:
					{
						return "Zebra Swallowtail Butterfly";
					}
					case 2001:
					{
						return "Julia Butterfly";
					}
					case 2002:
					{
						return "Worm";
					}
					case 2003:
					{
						return "Mouse";
					}
					case 2004:
					{
						return "Lightning Bug";
					}
					case 2005:
					{
						return "Lightning Bug in a Bottle";
					}
					case 2006:
					{
						return "Snail";
					}
					case 2007:
					{
						return "Glowing Snail";
					}
					case 2008:
					{
						return "Fancy Gray Wallpaper";
					}
					case 2009:
					{
						return "Ice Floe Wallpaper";
					}
					case 2010:
					{
						return "Music Wallpaper";
					}
					case 2011:
					{
						return "Purple Rain Wallpaper";
					}
					case 2012:
					{
						return "Rainbow Wallpaper";
					}
					case 2013:
					{
						return "Sparkle Stone Wallpaper";
					}
					case 2014:
					{
						return "Starlit Heaven Wallpaper";
					}
					case 2015:
					{
						return "Bird";
					}
					case 2016:
					{
						return "Blue Jay";
					}
					case 2017:
					{
						return "Cardinal";
					}
					case 2018:
					{
						return "Squirrel";
					}
					case 2019:
					{
						return "Bunny";
					}
					case 2020:
					{
						return "Cactus Bookcase";
					}
					case 2021:
					{
						return "Ebonwood Bookcase";
					}
					case 2022:
					{
						return "Flesh Bookcase";
					}
					case 2023:
					{
						return "Honey Bookcase";
					}
					case 2024:
					{
						return "Steampunk Bookcase";
					}
					case 2025:
					{
						return "Glass Bookcase";
					}
					case 2026:
					{
						return "Rich Mahogany Bookcase";
					}
					case 2027:
					{
						return "Pearlwood Bookcase";
					}
					case 2028:
					{
						return "Spooky Bookcase";
					}
					case 2029:
					{
						return "Skyware Bookcase";
					}
					case 2030:
					{
						return "Lihzahrd Bookcase";
					}
					case 2031:
					{
						return "Frozen Bookcase";
					}
					case 2032:
					{
						return "Cactus Lantern";
					}
					case 2033:
					{
						return "Ebonwood Lantern";
					}
					case 2034:
					{
						return "Flesh Lantern";
					}
					case 2035:
					{
						return "Honey Lantern";
					}
					case 2036:
					{
						return "Steampunk Lantern";
					}
					case 2037:
					{
						return "Glass Lantern";
					}
					case 2038:
					{
						return "Rich Mahogany Lantern";
					}
					case 2039:
					{
						return "Pearlwood Lantern";
					}
					case 2040:
					{
						return "Frozen Lantern";
					}
					case 2041:
					{
						return "Lihzahrd Lantern";
					}
					case 2042:
					{
						return "Skyware Lantern";
					}
					case 2043:
					{
						return "Spooky Lantern";
					}
					case 2044:
					{
						return "Frozen Door";
					}
					case 2045:
					{
						return "Cactus Candle";
					}
					case 2046:
					{
						return "Ebonwood Candle";
					}
					case 2047:
					{
						return "Flesh Candle";
					}
					case 2048:
					{
						return "Glass Candle";
					}
					case 2049:
					{
						return "Frozen Candle";
					}
					case 2050:
					{
						return "Rich Mahogany Candle";
					}
					case 2051:
					{
						return "Pearlwood Candle";
					}
					case 2052:
					{
						return "Lihzahrd Candle";
					}
					case 2053:
					{
						return "Skyware Candle";
					}
					case 2054:
					{
						return "Pumpkin Candle";
					}
					case 2055:
					{
						return "Cactus Chandelier";
					}
					case 2056:
					{
						return "Ebonwood Chandelier";
					}
					case 2057:
					{
						return "Flesh Chandelier";
					}
					case 2058:
					{
						return "Honey Chandelier";
					}
					case 2059:
					{
						return "Frozen Chandelier";
					}
					case 2060:
					{
						return "Rich Mahogany Chandelier";
					}
					case 2061:
					{
						return "Pearlwood Chandelier";
					}
					case 2062:
					{
						return "Lihzahrd Chandelier";
					}
					case 2063:
					{
						return "Skyware Chandelier";
					}
					case 2064:
					{
						return "Spooky Chandelier";
					}
					case 2065:
					{
						return "Glass Chandelier";
					}
					case 2066:
					{
						return "Cactus Bed";
					}
					case 2067:
					{
						return "Flesh Bed";
					}
					case 2068:
					{
						return "Frozen Bed";
					}
					case 2069:
					{
						return "Lihzahrd Bed";
					}
					case 2070:
					{
						return "Skyware Bed";
					}
					case 2071:
					{
						return "Spooky Bed";
					}
					case 2072:
					{
						return "Cactus Bathtub";
					}
					case 2073:
					{
						return "Ebonwood Bathtub";
					}
					case 2074:
					{
						return "Flesh Bathtub";
					}
					case 2075:
					{
						return "Glass Bathtub";
					}
					case 2076:
					{
						return "Frozen Bathtub";
					}
					case 2077:
					{
						return "Rich Mahogany Bathtub";
					}
					case 2078:
					{
						return "Pearlwood Bathtub";
					}
					case 2079:
					{
						return "Lihzahrd Bathtub";
					}
					case 2080:
					{
						return "Skyware Bathtub";
					}
					case 2081:
					{
						return "Spooky Bathtub";
					}
					case 2082:
					{
						return "Cactus Lamp";
					}
					case 2083:
					{
						return "Ebonwood Lamp";
					}
					case 2084:
					{
						return "Flesh Lamp";
					}
					case 2085:
					{
						return "Glass Lamp";
					}
					case 2086:
					{
						return "Frozen Lamp";
					}
					case 2087:
					{
						return "Rich Mahogany Lamp";
					}
					case 2088:
					{
						return "Pearlwood Lamp";
					}
					case 2089:
					{
						return "Lihzahrd Lamp";
					}
					case 2090:
					{
						return "Skyware Lamp";
					}
					case 2091:
					{
						return "Spooky Lamp";
					}
					case 2092:
					{
						return "Cactus Candelabra";
					}
					case 2093:
					{
						return "Ebonwood Candelabra";
					}
					case 2094:
					{
						return "Flesh Candelabra";
					}
					case 2095:
					{
						return "Honey Candelabra";
					}
					case 2096:
					{
						return "Steampunk Candelabra";
					}
					case 2097:
					{
						return "Glass Candelabra";
					}
					case 2098:
					{
						return "Rich Mahogany Candelabra";
					}
					case 2099:
					{
						return "Pearlwood Candelabra";
					}
					case 2100:
					{
						return "Frozen Candelabra";
					}
					case 2101:
					{
						return "Lihzahrd Candelabra";
					}
					case 2102:
					{
						return "Skyware Candelabra";
					}
					case 2103:
					{
						return "Spooky Candelabra";
					}
					case 2104:
					{
						return "Brain of Cthulhu Mask";
					}
					case 2105:
					{
						return "Wall of Flesh Mask";
					}
					case 2106:
					{
						return "Twin Mask";
					}
					case 2107:
					{
						return "Skeletron Prime Mask";
					}
					case 2108:
					{
						return "Queen Bee Mask";
					}
					case 2109:
					{
						return "Plantera Mask";
					}
					case 2110:
					{
						return "Golem Mask";
					}
					case 2111:
					{
						return "Eater of Worlds Mask";
					}
					case 2112:
					{
						return "Eye of Cthulhu Mask";
					}
					case 2113:
					{
						return "Destroyer Mask";
					}
					case 2114:
					{
						return "Blacksmith Rack";
					}
					case 2115:
					{
						return "Carpentry Rack";
					}
					case 2116:
					{
						return "Helmet Rack";
					}
					case 2117:
					{
						return "Spear Rack";
					}
					case 2118:
					{
						return "Sword Rack";
					}
					case 2119:
					{
						return "Stone Slab";
					}
					case 2120:
					{
						return "Sandstone Slab";
					}
					case 2121:
					{
						return "Frog";
					}
					case 2122:
					{
						return "Mallard Duck";
					}
					case 2123:
					{
						return "Duck";
					}
					case 2124:
					{
						return "Honey Bathtub";
					}
					case 2125:
					{
						return "Steampunk Bathtub";
					}
					case 2126:
					{
						return "Living Wood Bathtub";
					}
					case 2127:
					{
						return "Shadewood Bathtub";
					}
					case 2128:
					{
						return "Bone Bathtub";
					}
					case 2129:
					{
						return "Honey Lamp";
					}
					case 2130:
					{
						return "Steampunk Lamp";
					}
					case 2131:
					{
						return "Living Wood Lamp";
					}
					case 2132:
					{
						return "Shadewood Lamp";
					}
					case 2133:
					{
						return "Golden Lamp";
					}
					case 2134:
					{
						return "Bone Lamp";
					}
					case 2135:
					{
						return "Living Wood Bookcase";
					}
					case 2136:
					{
						return "Shadewood Bookcase";
					}
					case 2137:
					{
						return "Golden Bookcase";
					}
					case 2138:
					{
						return "Bone Bookcase";
					}
					case 2139:
					{
						return "Living Wood Bed";
					}
					case 2140:
					{
						return "Bone Bed";
					}
					case 2141:
					{
						return "Living Wood Chandelier";
					}
					case 2142:
					{
						return "Shadewood Chandelier";
					}
					case 2143:
					{
						return "Golden Chandelier";
					}
					case 2144:
					{
						return "Bone Chandelier";
					}
					case 2145:
					{
						return "Living Wood Lantern";
					}
					case 2146:
					{
						return "Shadewood Lantern";
					}
					case 2147:
					{
						return "Golden Lantern";
					}
					case 2148:
					{
						return "Bone Lantern";
					}
					case 2149:
					{
						return "Living Wood Candelabra";
					}
					case 2150:
					{
						return "Shadewood Candelabra";
					}
					case 2151:
					{
						return "Golden Candelabra";
					}
					case 2152:
					{
						return "Bone Candelabra";
					}
					case 2153:
					{
						return "Living Wood Candle";
					}
					case 2154:
					{
						return "Shadewood Candle";
					}
					case 2155:
					{
						return "Golden Candle";
					}
					case 2156:
					{
						return "Black Scorpion";
					}
					case 2157:
					{
						return "Scorpion";
					}
					case 2158:
					{
						return "Bubble Wallpaper";
					}
					case 2159:
					{
						return "Copper Pipe Wallpaper";
					}
					case 2160:
					{
						return "Ducky Wallpaper";
					}
					case 2161:
					{
						return "Frost Core";
					}
					case 2162:
					{
						return "Bunny Cage";
					}
					case 2163:
					{
						return "Squirrel Cage";
					}
					case 2164:
					{
						return "Mallard Duck Cage";
					}
					case 2165:
					{
						return "Duck Cage";
					}
					case 2166:
					{
						return "Bird Cage";
					}
					case 2167:
					{
						return "Blue Jay Cage";
					}
					case 2168:
					{
						return "Cardinal Cage";
					}
					case 2169:
					{
						return "Waterfall Wall";
					}
					case 2170:
					{
						return "Lavafall Wall";
					}
					case 2171:
					{
						return "Crimson Seeds";
					}
					case 2172:
					{
						return "Heavy Work Bench";
					}
					case 2173:
					{
						return "Copper Plating";
					}
					case 2174:
					{
						return "Snail Cage";
					}
					case 2175:
					{
						return "Glowing Snail Cage";
					}
					case 2176:
					{
						return "Shroomite Digging Claw";
					}
					case 2177:
					{
						return "Ammo Box";
					}
					case 2178:
					{
						return "Monarch Butterfly Jar";
					}
					case 2179:
					{
						return "Purple Emperor Butterfly Jar";
					}
					case 2180:
					{
						return "Red Admiral Butterfly Jar";
					}
					case 2181:
					{
						return "Ulysses Butterfly Jar";
					}
					case 2182:
					{
						return "Sulphur Butterfly Jar";
					}
					case 2183:
					{
						return "Tree Nymph Butterfly Jar";
					}
					case 2184:
					{
						return "Zebra Swallowtail Butterfly Jar";
					}
					case 2185:
					{
						return "Julia Butterfly Jar";
					}
					case 2186:
					{
						return "Scorpion Cage";
					}
					case 2187:
					{
						return "Black Scorpion Cage";
					}
					case 2188:
					{
						return "Venom Staff";
					}
					case 2189:
					{
						return "Spectre Mask";
					}
					case 2190:
					{
						return "Frog Cage";
					}
					case 2191:
					{
						return "Mouse Cage";
					}
					case 2192:
					{
						return "Bone Welder";
					}
					case 2193:
					{
						return "Flesh Cloning Vat";
					}
					case 2194:
					{
						return "Glass Kiln";
					}
					case 2195:
					{
						return "Lihzahrd Furnace";
					}
					case 2196:
					{
						return "Living Loom";
					}
					case 2197:
					{
						return "Sky Mill";
					}
					case 2198:
					{
						return "Ice Machine";
					}
					case 2199:
					{
						return "Beetle Helmet";
					}
					case 2200:
					{
						return "Beetle Scale Mail";
					}
					case 2201:
					{
						return "Beetle Shell";
					}
					case 2202:
					{
						return "Beetle Leggings";
					}
					case 2203:
					{
						return "Steampunk Boiler";
					}
					case 2204:
					{
						return "Honey Dispenser";
					}
					case 2205:
					{
						return "Penguin";
					}
					case 2206:
					{
						return "Penguin Cage";
					}
					case 2207:
					{
						return "Worm Cage";
					}
					case 2208:
					{
						return "Terrarium";
					}
					case 2209:
					{
						return "Super Mana Potion";
					}
					case 2210:
					{
						return "Ebonwood Fence";
					}
					case 2211:
					{
						return "Rich Mahogany Fence";
					}
					case 2212:
					{
						return "Pearlwood Fence";
					}
					case 2213:
					{
						return "Shadewood Fence";
					}
					case 2214:
					{
						return "Brick Layer";
					}
					case 2215:
					{
						return "Extendo Grip";
					}
					case 2216:
					{
						return "Paint Sprayer";
					}
					case 2217:
					{
						return "Portable Cement Mixer";
					}
					case 2218:
					{
						return "Beetle Husk";
					}
					case 2219:
					{
						return "Celestial Magnet";
					}
					case 2220:
					{
						return "Celestial Emblem";
					}
					case 2221:
					{
						return "Celestial Cuffs";
					}
					case 2222:
					{
						return "Peddler's Hat";
					}
					case 2223:
					{
						return "Pulse Bow";
					}
					case 2224:
					{
						return "Large Dynasty Lantern";
					}
					case 2225:
					{
						return "Dynasty Lamp";
					}
					case 2226:
					{
						return "Dynasty Lantern";
					}
					case 2227:
					{
						return "Large Dynasty Candle";
					}
					case 2228:
					{
						return "Dynasty Chair";
					}
					case 2229:
					{
						return "Dynasty Work Bench";
					}
					case 2230:
					{
						return "Dynasty Chest";
					}
					case 2231:
					{
						return "Dynasty Bed";
					}
					case 2232:
					{
						return "Dynasty Bathtub";
					}
					case 2233:
					{
						return "Dynasty Bookcase";
					}
					case 2234:
					{
						return "Dynasty Cup";
					}
					case 2235:
					{
						return "Dynasty Bowl";
					}
					case 2236:
					{
						return "Dynasty Candle";
					}
					case 2237:
					{
						return "Dynasty Clock";
					}
					case 2238:
					{
						return "Golden Clock";
					}
					case 2239:
					{
						return "Glass Clock";
					}
					case 2240:
					{
						return "Honey Clock";
					}
					case 2241:
					{
						return "Steampunk Clock";
					}
					case 2242:
					{
						return "Fancy Dishes";
					}
					case 2243:
					{
						return "Glass Bowl";
					}
					case 2244:
					{
						return "Wine Glass";
					}
					case 2245:
					{
						return "Living Wood Piano";
					}
					case 2246:
					{
						return "Flesh Piano";
					}
					case 2247:
					{
						return "Frozen Piano";
					}
					case 2248:
					{
						return "Frozen Table";
					}
					case 2249:
					{
						return "Honey Chest";
					}
					case 2250:
					{
						return "Steampunk Chest";
					}
					case 2251:
					{
						return "Honey Work Bench";
					}
					case 2252:
					{
						return "Frozen Work Bench";
					}
					case 2253:
					{
						return "Steampunk Work Bench";
					}
					case 2254:
					{
						return "Glass Piano";
					}
					case 2255:
					{
						return "Honey Piano";
					}
					case 2256:
					{
						return "Steampunk Piano";
					}
					case 2257:
					{
						return "Honey Cup";
					}
					case 2258:
					{
						return "Chalice";
					}
					case 2259:
					{
						return "Dynasty Table";
					}
					case 2260:
					{
						return "Dynasty Wood";
					}
					case 2261:
					{
						return "Red Dynasty Shingles";
					}
					case 2262:
					{
						return "Blue Dynasty Shingles";
					}
					case 2263:
					{
						return "White Dynasty Wall";
					}
					case 2264:
					{
						return "Blue Dynasty Wall";
					}
					case 2265:
					{
						return "Dynasty Door";
					}
					case 2266:
					{
						return "Sake";
					}
					case 2267:
					{
						return "Pad Thai";
					}
					case 2268:
					{
						return "Pho";
					}
					case 2269:
					{
						return "Revolver";
					}
					case 2270:
					{
						return "Gatligator";
					}
					case 2271:
					{
						return "Arcane Rune Wall";
					}
					case 2272:
					{
						return "Water Gun";
					}
					case 2273:
					{
						return "Katana";
					}
					case 2274:
					{
						return "Ultrabright Torch";
					}
					case 2275:
					{
						return "Magic Hat";
					}
					case 2276:
					{
						return "Diamond Ring";
					}
					case 2277:
					{
						return "Gi";
					}
					case 2278:
					{
						return "Kimono";
					}
					case 2279:
					{
						return "Gypsy Robe";
					}
					case 2280:
					{
						return "Beetle Wings";
					}
					case 2281:
					{
						return "Tiger Skin";
					}
					case 2282:
					{
						return "Leopard Skin";
					}
					case 2283:
					{
						return "Zebra Skin";
					}
					case 2284:
					{
						return "Crimson Cloak";
					}
					case 2285:
					{
						return "Mysterious Cape";
					}
					case 2286:
					{
						return "Red Cape";
					}
					case 2287:
					{
						return "Winter Cape";
					}
					case 2288:
					{
						return "Frozen Chair";
					}
					case 2289:
					{
						return "Wood Fishing Pole";
					}
					case 2290:
					{
						return "Bass";
					}
					case 2291:
					{
						return "Reinforced Fishing Pole";
					}
					case 2292:
					{
						return "Fiberglass Fishing Pole";
					}
					case 2293:
					{
						return "Fisher of Souls";
					}
					case 2294:
					{
						return "Golden Fishing Rod";
					}
					case 2295:
					{
						return "Mechanic's Rod";
					}
					case 2296:
					{
						return "Sitting Duck's Fishing Pole";
					}
					case 2297:
					{
						return "Trout";
					}
					case 2298:
					{
						return "Salmon";
					}
					case 2299:
					{
						return "Atlantic Cod";
					}
					case 2300:
					{
						return "Tuna";
					}
					case 2301:
					{
						return "Red Snapper";
					}
					case 2302:
					{
						return "Neon Tetra";
					}
					case 2303:
					{
						return "Armored Cavefish";
					}
					case 2304:
					{
						return "Damselfish";
					}
					case 2305:
					{
						return "Crimson Tigerfish";
					}
					case 2306:
					{
						return "Frost Minnow";
					}
					case 2307:
					{
						return "Princess Fish";
					}
					case 2308:
					{
						return "Golden Carp";
					}
					case 2309:
					{
						return "Specular Fish";
					}
					case 2310:
					{
						return "Prismite";
					}
					case 2311:
					{
						return "Variegated Lardfish";
					}
					case 2312:
					{
						return "Flarefin Koi";
					}
					case 2313:
					{
						return "Double Cod";
					}
					case 2314:
					{
						return "Honeyfin";
					}
					case 2315:
					{
						return "Obsidifish";
					}
					case 2316:
					{
						return "Shrimp";
					}
					case 2317:
					{
						return "Chaos Fish";
					}
					case 2318:
					{
						return "Ebonkoi";
					}
					case 2319:
					{
						return "Hemopiranha";
					}
					case 2320:
					{
						return "Rockfish";
					}
					case 2321:
					{
						return "Stinkfish";
					}
					case 2322:
					{
						return "Mining Potion";
					}
					case 2323:
					{
						return "Heartreach Potion";
					}
					case 2324:
					{
						return "Calming Potion";
					}
					case 2325:
					{
						return "Builder Potion";
					}
					case 2326:
					{
						return "Titan Potion";
					}
					case 2327:
					{
						return "Flipper Potion";
					}
					case 2328:
					{
						return "Summoning Potion";
					}
					case 2329:
					{
						return "Dangersense Potion";
					}
					case 2330:
					{
						return "Purple Clubberfish";
					}
					case 2331:
					{
						return "Obsidian Swordfish";
					}
					case 2332:
					{
						return "Swordfish";
					}
					case 2333:
					{
						return "Iron Fence";
					}
					case 2334:
					{
						return "Wooden Crate";
					}
					case 2335:
					{
						return "Iron Crate";
					}
					case 2336:
					{
						return "Golden Crate";
					}
					case 2337:
					{
						return "Old Shoe";
					}
					case 2338:
					{
						return "Seaweed";
					}
					case 2339:
					{
						return "Tin Can";
					}
					case 2340:
					{
						return "Minecart Track";
					}
					case 2341:
					{
						return "Reaver Shark";
					}
					case 2342:
					{
						return "Sawtooth Shark";
					}
					case 2343:
					{
						return "Minecart";
					}
					case 2344:
					{
						return "Ammo Reservation Potion";
					}
					case 2345:
					{
						return "Lifeforce Potion";
					}
					case 2346:
					{
						return "Endurance Potion";
					}
					case 2347:
					{
						return "Rage Potion";
					}
					case 2348:
					{
						return "Inferno Potion";
					}
					case 2349:
					{
						return "Wrath Potion";
					}
					case 2350:
					{
						return "Recall Potion";
					}
					case 2351:
					{
						return "Teleportation Potion";
					}
					case 2352:
					{
						return "Love Potion";
					}
					case 2353:
					{
						return "Stink Potion";
					}
					case 2354:
					{
						return "Fishing Potion";
					}
					case 2355:
					{
						return "Sonar Potion";
					}
					case 2356:
					{
						return "Crate Potion";
					}
					case 2357:
					{
						return "Shiverthorn Seeds";
					}
					case 2358:
					{
						return "Shiverthorn";
					}
					case 2359:
					{
						return "Warmth Potion";
					}
					case 2360:
					{
						return "Fish Hook";
					}
					case 2361:
					{
						return "Bee Headgear";
					}
					case 2362:
					{
						return "Bee Breastplate";
					}
					case 2363:
					{
						return "Bee Greaves";
					}
					case 2364:
					{
						return "Hornet Staff";
					}
					case 2365:
					{
						return "Imp Staff";
					}
					case 2366:
					{
						return "Queen Spider Staff";
					}
					case 2367:
					{
						return "Angler Hat";
					}
					case 2368:
					{
						return "Angler Vest";
					}
					case 2369:
					{
						return "Angler Pants";
					}
					case 2370:
					{
						return "Spider Mask";
					}
					case 2371:
					{
						return "Spider Breastplate";
					}
					case 2372:
					{
						return "Spider Greaves";
					}
					case 2373:
					{
						return "High Test Fishing Line";
					}
					case 2374:
					{
						return "Angler Earring";
					}
					case 2375:
					{
						return "Tackle Box";
					}
					case 2376:
					{
						return "Blue Dungeon Piano";
					}
					case 2377:
					{
						return "Green Dungeon Piano";
					}
					case 2378:
					{
						return "Pink Dungeon Piano";
					}
					case 2379:
					{
						return "Golden Piano";
					}
					case 2380:
					{
						return "Obsidian Piano";
					}
					case 2381:
					{
						return "Bone Piano";
					}
					case 2382:
					{
						return "Cactus Piano";
					}
					case 2383:
					{
						return "Spooky Piano";
					}
					case 2384:
					{
						return "Skyware Piano";
					}
					case 2385:
					{
						return "Lihzahrd Piano";
					}
					case 2386:
					{
						return "Blue Dungeon Dresser";
					}
					case 2387:
					{
						return "Green Dungeon Dresser";
					}
					case 2388:
					{
						return "Pink Dungeon Dresser";
					}
					case 2389:
					{
						return "Golden Dresser";
					}
					case 2390:
					{
						return "Obsidian Dresser";
					}
					case 2391:
					{
						return "Bone Dresser";
					}
					case 2392:
					{
						return "Cactus Dresser";
					}
					case 2393:
					{
						return "Spooky Dresser";
					}
					case 2394:
					{
						return "Skyware Dresser";
					}
					case 2395:
					{
						return "Honey Dresser";
					}
					case 2396:
					{
						return "Lihzahrd Dresser";
					}
					case 2397:
					{
						return "Sofa";
					}
					case 2398:
					{
						return "Ebonwood Sofa";
					}
					case 2399:
					{
						return "Rich Mahogany Sofa";
					}
					case 2400:
					{
						return "Pearlwood Sofa";
					}
					case 2401:
					{
						return "Shadewood Sofa";
					}
					case 2402:
					{
						return "Blue Dungeon Sofa";
					}
					case 2403:
					{
						return "Green Dungeon Sofa";
					}
					case 2404:
					{
						return "Pink Dungeon Sofa";
					}
					case 2405:
					{
						return "Golden Sofa";
					}
					case 2406:
					{
						return "Obsidian Sofa";
					}
					case 2407:
					{
						return "Bone Sofa";
					}
					case 2408:
					{
						return "Cactus Sofa";
					}
					case 2409:
					{
						return "Spooky Sofa";
					}
					case 2410:
					{
						return "Skyware Sofa";
					}
					case 2411:
					{
						return "Honey Sofa";
					}
					case 2412:
					{
						return "Steampunk Sofa";
					}
					case 2413:
					{
						return "Mushroom Sofa";
					}
					case 2414:
					{
						return "Glass Sofa";
					}
					case 2415:
					{
						return "Pumpkin Sofa";
					}
					case 2416:
					{
						return "Lihzahrd Sofa";
					}
					case 2417:
					{
						return "Seashell Hairpin";
					}
					case 2418:
					{
						return "Mermaid Adornment";
					}
					case 2419:
					{
						return "Mermaid Tail";
					}
					case 2420:
					{
						return "Zephyr Fish";
					}
					case 2421:
					{
						return "Fleshcatcher";
					}
					case 2422:
					{
						return "Hotline Fishing Hook";
					}
					case 2423:
					{
						return "Frog Leg";
					}
					case 2424:
					{
						return "Anchor";
					}
					case 2425:
					{
						return "Cooked Fish";
					}
					case 2426:
					{
						return "Cooked Shrimp";
					}
					case 2427:
					{
						return "Sashimi";
					}
					case 2428:
					{
						return "Fuzzy Carrot";
					}
					case 2429:
					{
						return "Scaly Truffle";
					}
					case 2430:
					{
						return "Slimy Saddle";
					}
					case 2431:
					{
						return "Bee Wax";
					}
					case 2432:
					{
						return "Copper Plating Wall";
					}
					case 2433:
					{
						return "Stone Slab Wall";
					}
					case 2434:
					{
						return "Sail";
					}
					case 2435:
					{
						return "Coralstone Block";
					}
					case 2436:
					{
						return "Blue Jellyfish";
					}
					case 2437:
					{
						return "Green Jellyfish";
					}
					case 2438:
					{
						return "Pink Jellyfish";
					}
					case 2439:
					{
						return "Blue Jellyfish Jar";
					}
					case 2440:
					{
						return "Green Jellyfish Jar";
					}
					case 2441:
					{
						return "Pink Jellyfish Jar";
					}
					case 2442:
					{
						return "Life Preserver";
					}
					case 2443:
					{
						return "Ship's Wheel";
					}
					case 2444:
					{
						return "Compass Rose";
					}
					case 2445:
					{
						return "Wall Anchor";
					}
					case 2446:
					{
						return "Goldfish Trophy";
					}
					case 2447:
					{
						return "Bunnyfish Trophy";
					}
					case 2448:
					{
						return "Swordfish Trophy";
					}
					case 2449:
					{
						return "Sharkteeth Trophy";
					}
					case 2450:
					{
						return "Batfish";
					}
					case 2451:
					{
						return "Bumblebee Tuna";
					}
					case 2452:
					{
						return "Catfish";
					}
					case 2453:
					{
						return "Cloudfish";
					}
					case 2454:
					{
						return "Cursedfish";
					}
					case 2455:
					{
						return "Dirtfish";
					}
					case 2456:
					{
						return "Dynamite Fish";
					}
					case 2457:
					{
						return "Eater of Plankton";
					}
					case 2458:
					{
						return "Fallen Starfish";
					}
					case 2459:
					{
						return "The Fish of Cthulhu";
					}
					case 2460:
					{
						return "Fishotron";
					}
					case 2461:
					{
						return "Harpyfish";
					}
					case 2462:
					{
						return "Hungerfish";
					}
					case 2463:
					{
						return "Ichorfish";
					}
					case 2464:
					{
						return "Jewelfish";
					}
					case 2465:
					{
						return "Mirage Fish";
					}
					case 2466:
					{
						return "Mutant Flinxfin";
					}
					case 2467:
					{
						return "Pengfish";
					}
					case 2468:
					{
						return "Pixiefish";
					}
					case 2469:
					{
						return "Spiderfish";
					}
					case 2470:
					{
						return "Tundra Trout";
					}
					case 2471:
					{
						return "Unicorn Fish";
					}
					case 2472:
					{
						return "Guide Voodoo Fish";
					}
					case 2473:
					{
						return "Wyverntail";
					}
					case 2474:
					{
						return "Zombie Fish";
					}
					case 2475:
					{
						return "Amanitia Fungifin";
					}
					case 2476:
					{
						return "Angelfish";
					}
					case 2477:
					{
						return "Bloody Manowar";
					}
					case 2478:
					{
						return "Bonefish";
					}
					case 2479:
					{
						return "Bunnyfish";
					}
					case 2480:
					{
						return "Cap'n Tunabeard";
					}
					case 2481:
					{
						return "Clownfish";
					}
					case 2482:
					{
						return "Demonic Hellfish";
					}
					case 2483:
					{
						return "Derpfish";
					}
					case 2484:
					{
						return "Fishron";
					}
					case 2485:
					{
						return "Infected Scabbardfish";
					}
					case 2486:
					{
						return "Mudfish";
					}
					case 2487:
					{
						return "Slimefish";
					}
					case 2488:
					{
						return "Tropical Barracuda";
					}
					case 2489:
					{
						return "King Slime Trophy";
					}
					case 2490:
					{
						return "Ship in a Bottle";
					}
					case 2491:
					{
						return "Hardy Saddle";
					}
					case 2492:
					{
						return "Pressure Plate Track";
					}
					case 2493:
					{
						return "King Slime Mask";
					}
					case 2494:
					{
						return "Fin Wings";
					}
					case 2495:
					{
						return "Treasure Map";
					}
					case 2496:
					{
						return "Seaweed Planter";
					}
					case 2497:
					{
						return "Pillagin Me Pixels";
					}
					case 2498:
					{
						return "Fish Costume Mask";
					}
					case 2499:
					{
						return "Fish Costume Shirt";
					}
					case 2500:
					{
						return "Fish Costume Finskirt";
					}
					case 2501:
					{
						return "Ginger Beard";
					}
					case 2502:
					{
						return "Honeyed Goggles";
					}
					case 2503:
					{
						return "Boreal Wood";
					}
					case 2504:
					{
						return "Palm Wood";
					}
					case 2505:
					{
						return "Boreal Wood Wall";
					}
					case 2506:
					{
						return "Palm Wood Wall";
					}
					case 2507:
					{
						return "Boreal Wood Fence";
					}
					case 2508:
					{
						return "Palm Wood Fence";
					}
					case 2509:
					{
						return "Boreal Wood Helmet";
					}
					case 2510:
					{
						return "Boreal Wood Breastplate";
					}
					case 2511:
					{
						return "Boreal Wood Greaves";
					}
					case 2512:
					{
						return "Palm Wood Helmet";
					}
					case 2513:
					{
						return "Palm Wood Breastplate";
					}
					case 2514:
					{
						return "Palm Wood Greaves";
					}
					case 2515:
					{
						return "Palm Wood Bow";
					}
					case 2516:
					{
						return "Palm Wood Hammer";
					}
					case 2517:
					{
						return "Palm Wood Sword";
					}
					case 2518:
					{
						return "Palm Wood Platform";
					}
					case 2519:
					{
						return "Palm Wood Bathtub";
					}
					case 2520:
					{
						return "Palm Wood Bed";
					}
					case 2521:
					{
						return "Palm Wood Bench";
					}
					case 2522:
					{
						return "Palm Wood Candelabra";
					}
					case 2523:
					{
						return "Palm Wood Candle";
					}
					case 2524:
					{
						return "Palm Wood Chair";
					}
					case 2525:
					{
						return "Palm Wood Chandelier";
					}
					case 2526:
					{
						return "Palm Wood Chest";
					}
					case 2527:
					{
						return "Palm Wood Sofa";
					}
					case 2528:
					{
						return "Palm Wood Door";
					}
					case 2529:
					{
						return "Palm Wood Dresser";
					}
					case 2530:
					{
						return "Palm Wood Lantern";
					}
					case 2531:
					{
						return "Palm Wood Piano";
					}
					case 2532:
					{
						return "Palm Wood Table";
					}
					case 2533:
					{
						return "Palm Wood Lamp";
					}
					case 2534:
					{
						return "Palm Wood Work Bench";
					}
					case 2535:
					{
						return "Optic Staff";
					}
					case 2536:
					{
						return "Palm Wood Bookcase";
					}
					case 2537:
					{
						return "Mushroom Bathtub";
					}
					case 2538:
					{
						return "Mushroom Bed";
					}
					case 2539:
					{
						return "Mushroom Bench";
					}
					case 2540:
					{
						return "Mushroom Bookcase";
					}
					case 2541:
					{
						return "Mushroom Candelabra";
					}
					case 2542:
					{
						return "Mushroom Candle";
					}
					case 2543:
					{
						return "Mushroom Chandelier";
					}
					case 2544:
					{
						return "Mushroom Chest";
					}
					case 2545:
					{
						return "Mushroom Dresser";
					}
					case 2546:
					{
						return "Mushroom Lantern";
					}
					case 2547:
					{
						return "Mushroom Lamp";
					}
					case 2548:
					{
						return "Mushroom Piano";
					}
					case 2549:
					{
						return "Mushroom Platform";
					}
					case 2550:
					{
						return "Mushroom Table";
					}
					case 2551:
					{
						return "Spider Staff";
					}
					case 2552:
					{
						return "Boreal Wood Bathtub";
					}
					case 2553:
					{
						return "Boreal Wood Bed";
					}
					case 2554:
					{
						return "Boreal Wood Bookcase";
					}
					case 2555:
					{
						return "Boreal Wood Candelabra";
					}
					case 2556:
					{
						return "Boreal Wood Candle";
					}
					case 2557:
					{
						return "Boreal Wood Chair";
					}
					case 2558:
					{
						return "Boreal Wood Chandelier";
					}
					case 2559:
					{
						return "Boreal Wood Chest";
					}
					case 2560:
					{
						return "Boreal Wood Clock";
					}
					case 2561:
					{
						return "Boreal Wood Door";
					}
					case 2562:
					{
						return "Boreal Wood Dresser";
					}
					case 2563:
					{
						return "Boreal Wood Lamp";
					}
					case 2564:
					{
						return "Boreal Wood Lantern";
					}
					case 2565:
					{
						return "Boreal Wood Piano";
					}
					case 2566:
					{
						return "Boreal Wood Platform";
					}
					case 2567:
					{
						return "Slime Bathtub";
					}
					case 2568:
					{
						return "Slime Bed";
					}
					case 2569:
					{
						return "Slime Bookcase";
					}
					case 2570:
					{
						return "Slime Candelabra";
					}
					case 2571:
					{
						return "Slime Candle";
					}
					case 2572:
					{
						return "Slime Chair";
					}
					case 2573:
					{
						return "Slime Chandelier";
					}
					case 2574:
					{
						return "Slime Chest";
					}
					case 2575:
					{
						return "Slime Clock";
					}
					case 2576:
					{
						return "Slime Door";
					}
					case 2577:
					{
						return "Slime Dresser";
					}
					case 2578:
					{
						return "Slime Lamp";
					}
					case 2579:
					{
						return "Slime Lantern";
					}
					case 2580:
					{
						return "Slime Piano";
					}
					case 2581:
					{
						return "Slime Platform";
					}
					case 2582:
					{
						return "Slime Sofa";
					}
					case 2583:
					{
						return "Slime Table";
					}
					case 2584:
					{
						return "Pirate Staff";
					}
					case 2585:
					{
						return "Slime Hook";
					}
					case 2586:
					{
						return "Sticky Grenade";
					}
					case 2587:
					{
						return "Tartar Sauce";
					}
					case 2588:
					{
						return "Duke Fishron Mask";
					}
					case 2589:
					{
						return "Duke Fishron Trophy";
					}
					case 2590:
					{
						return "Molotov Cocktail";
					}
					case 2591:
					{
						return "Bone Clock";
					}
					case 2592:
					{
						return "Cactus Clock";
					}
					case 2593:
					{
						return "Ebonwood Clock";
					}
					case 2594:
					{
						return "Frozen Clock";
					}
					case 2595:
					{
						return "Lihzahrd Clock";
					}
					case 2596:
					{
						return "Living Wood Clock";
					}
					case 2597:
					{
						return "Rich Mahogany Clock";
					}
					case 2598:
					{
						return "Flesh Clock";
					}
					case 2599:
					{
						return "Mushroom Clock";
					}
					case 2600:
					{
						return "Obsidian Clock";
					}
					case 2601:
					{
						return "Palm Wood Clock";
					}
					case 2602:
					{
						return "Pearlwood Clock";
					}
					case 2603:
					{
						return "Pumpkin Clock";
					}
					case 2604:
					{
						return "Shadewood Clock";
					}
					case 2605:
					{
						return "Spooky Clock";
					}
					case 2606:
					{
						return "Skyware Clock";
					}
					case 2607:
					{
						return "Spider Fang";
					}
					case 2608:
					{
						return "Falcon Blade";
					}
					case 2609:
					{
						return "Fishron Wings";
					}
					case 2610:
					{
						return "Slime Gun";
					}
					case 2611:
					{
						return "Flairon";
					}
					case 2612:
					{
						return "Green Dungeon Chest";
					}
					case 2613:
					{
						return "Pink Dungeon Chest";
					}
					case 2614:
					{
						return "Blue Dungeon Chest";
					}
					case 2615:
					{
						return "Bone Chest";
					}
					case 2616:
					{
						return "Cactus Chest";
					}
					case 2617:
					{
						return "Flesh Chest";
					}
					case 2618:
					{
						return "Obsidian Chest";
					}
					case 2619:
					{
						return "Pumpkin Chest";
					}
					case 2620:
					{
						return "Spooky Chest";
					}
					case 2621:
					{
						return "Tempest Staff";
					}
					case 2622:
					{
						return "Razorblade Typhoon";
					}
					case 2623:
					{
						return "Bubble Gun";
					}
					case 2624:
					{
						return "Tsunami";
					}
					case 2625:
					{
						return "Seashell";
					}
					case 2626:
					{
						return "Starfish";
					}
					case 2627:
					{
						return "Steampunk Platform";
					}
					case 2628:
					{
						return "Skyware Platform";
					}
					case 2629:
					{
						return "Living Wood Platform";
					}
					case 2630:
					{
						return "Honey Platform";
					}
					case 2631:
					{
						return "Skyware Work Bench";
					}
					case 2632:
					{
						return "Glass Work Bench";
					}
					case 2633:
					{
						return "Living Wood Work Bench";
					}
					case 2634:
					{
						return "Flesh Sofa";
					}
					case 2635:
					{
						return "Frozen Sofa";
					}
					case 2636:
					{
						return "Living Wood Sofa";
					}
					case 2637:
					{
						return "Pumpkin Dresser";
					}
					case 2638:
					{
						return "Steampunk Dresser";
					}
					case 2639:
					{
						return "Glass Dresser";
					}
					case 2640:
					{
						return "Flesh Dresser";
					}
					case 2641:
					{
						return "Pumpkin Lantern";
					}
					case 2642:
					{
						return "Obsidian Lantern";
					}
					case 2643:
					{
						return "Pumpkin Lamp";
					}
					case 2644:
					{
						return "Obsidian Lamp";
					}
					case 2645:
					{
						return "Blue Dungeon Lamp";
					}
					case 2646:
					{
						return "Green Dungeon Lamp";
					}
					case 2647:
					{
						return "Pink Dungeon Lamp";
					}
					case 2648:
					{
						return "Honey Candle";
					}
					case 2649:
					{
						return "Steampunk Candle";
					}
					case 2650:
					{
						return "Spooky Candle";
					}
					case 2651:
					{
						return "Obsidian Candle";
					}
					case 2652:
					{
						return "Blue Dungeon Chandelier";
					}
					case 2653:
					{
						return "Green Dungeon Chandelier";
					}
					case 2654:
					{
						return "Pink Dungeon Chandelier";
					}
					case 2655:
					{
						return "Steampunk Chandelier";
					}
					case 2656:
					{
						return "Pumpkin Chandelier";
					}
					case 2657:
					{
						return "Obsidian Chandelier";
					}
					case 2658:
					{
						return "Blue Dungeon Bathtub";
					}
					case 2659:
					{
						return "Green Dungeon Bathtub";
					}
					case 2660:
					{
						return "Pink Dungeon Bathtub";
					}
					case 2661:
					{
						return "Pumpkin Bathtub";
					}
					case 2662:
					{
						return "Obsidian Bathtub";
					}
					case 2663:
					{
						return "Golden Bathtub";
					}
					case 2664:
					{
						return "Blue Dungeon Candelabra";
					}
					case 2665:
					{
						return "Green Dungeon Candelabra";
					}
					case 2666:
					{
						return "Pink Dungeon Candelabra";
					}
					case 2667:
					{
						return "Obsidian Candelabra";
					}
					case 2668:
					{
						return "Pumpkin Candelabra";
					}
					case 2669:
					{
						return "Pumpkin Bed";
					}
					case 2670:
					{
						return "Pumpkin Bookcase";
					}
					case 2671:
					{
						return "Pumpkin Piano";
					}
					case 2672:
					{
						return "Shark Statue";
					}
					case 2673:
					{
						return "Truffle Worm";
					}
					case 2674:
					{
						return "Apprentice Bait";
					}
					case 2675:
					{
						return "Journeyman Bait";
					}
					case 2676:
					{
						return "Master Bait";
					}
					case 2677:
					{
						return "Amber Gemspark Wall";
					}
					case 2678:
					{
						return "Offline Amber Gemspark Wall";
					}
					case 2679:
					{
						return "Amethyst Gemspark Wall";
					}
					case 2680:
					{
						return "Offline Amethyst Gemspark Wall";
					}
					case 2681:
					{
						return "Diamond Gemspark Wall";
					}
					case 2682:
					{
						return "Offline Diamond Gemspark Wall";
					}
					case 2683:
					{
						return "Emerald Gemspark Wall";
					}
					case 2684:
					{
						return "Offline Emerald Gemspark Wall";
					}
					case 2685:
					{
						return "Ruby Gemspark Wall";
					}
					case 2686:
					{
						return "Offline Ruby Gemspark Wall";
					}
					case 2687:
					{
						return "Sapphire Gemspark Wall";
					}
					case 2688:
					{
						return "Offline Sapphire Gemspark Wall";
					}
					case 2689:
					{
						return "Topaz Gemspark Wall";
					}
					case 2690:
					{
						return "Offline Topaz Gemspark Wall";
					}
					case 2691:
					{
						return "Tin Plating Wall";
					}
					case 2692:
					{
						return "Tin Plating";
					}
					case 2693:
					{
						return "Waterfall Block";
					}
					case 2694:
					{
						return "Lavafall Block";
					}
					case 2695:
					{
						return "Confetti Block";
					}
					case 2696:
					{
						return "Confetti Wall";
					}
					case 2697:
					{
						return "Midnight Confetti Block";
					}
					case 2698:
					{
						return "Midnight Confetti Wall";
					}
					case 2699:
					{
						return "Weapon Rack";
					}
					case 2700:
					{
						return "Fireworks Box";
					}
					case 2701:
					{
						return "Living Fire Block";
					}
					case 2702:
					{
						return "'0' Statue";
					}
					case 2703:
					{
						return "'1' Statue";
					}
					case 2704:
					{
						return "'2' Statue";
					}
					case 2705:
					{
						return "'3' Statue";
					}
					case 2706:
					{
						return "'4' Statue";
					}
					case 2707:
					{
						return "'5' Statue";
					}
					case 2708:
					{
						return "'6' Statue";
					}
					case 2709:
					{
						return "'7' Statue";
					}
					case 2710:
					{
						return "'8' Statue";
					}
					case 2711:
					{
						return "'9' Statue";
					}
					case 2712:
					{
						return "'A' Statue";
					}
					case 2713:
					{
						return "'B' Statue";
					}
					case 2714:
					{
						return "'C' Statue";
					}
					case 2715:
					{
						return "'D' Statue";
					}
					case 2716:
					{
						return "'E' Statue";
					}
					case 2717:
					{
						return "'F' Statue";
					}
					case 2718:
					{
						return "'G' Statue";
					}
					case 2719:
					{
						return "'H' Statue";
					}
					case 2720:
					{
						return "'I' Statue";
					}
					case 2721:
					{
						return "'J' Statue";
					}
					case 2722:
					{
						return "'K' Statue";
					}
					case 2723:
					{
						return "'L' Statue";
					}
					case 2724:
					{
						return "'M' Statue";
					}
					case 2725:
					{
						return "'N' Statue";
					}
					case 2726:
					{
						return "'O' Statue";
					}
					case 2727:
					{
						return "'P' Statue";
					}
					case 2728:
					{
						return "'Q' Statue";
					}
					case 2729:
					{
						return "'R' Statue";
					}
					case 2730:
					{
						return "'S' Statue";
					}
					case 2731:
					{
						return "'T' Statue";
					}
					case 2732:
					{
						return "'U' Statue";
					}
					case 2733:
					{
						return "'V' Statue";
					}
					case 2734:
					{
						return "'W' Statue";
					}
					case 2735:
					{
						return "'X' Statue";
					}
					case 2736:
					{
						return "'Y' Statue";
					}
					case 2737:
					{
						return "'Z' Statue";
					}
					case 2738:
					{
						return "Firework Fountain";
					}
					case 2739:
					{
						return "Booster Track";
					}
					case 2740:
					{
						return "Grasshopper";
					}
					case 2741:
					{
						return "Grasshopper Cage";
					}
					case 2742:
					{
						return "Music Box (Underground Crimson)";
					}
					case 2743:
					{
						return "Cactus Table";
					}
					case 2744:
					{
						return "Cactus Platform";
					}
					case 2745:
					{
						return "Boreal Wood Sword";
					}
					case 2746:
					{
						return "Boreal Wood Hammer";
					}
					case 2747:
					{
						return "Boreal Wood Bow";
					}
					case 2748:
					{
						return "Glass Chest";
					}
					case 2749:
					{
						return "Xeno Staff";
					}
					case 2750:
					{
						return "Meteor Staff";
					}
					case 2751:
					{
						return "Living Cursed Fire Block";
					}
					case 2752:
					{
						return "Living Demon Fire Block";
					}
					case 2753:
					{
						return "Living Frost Fire Block";
					}
					case 2754:
					{
						return "Living Ichor Block";
					}
					case 2755:
					{
						return "Living Ultrabright Fire Block";
					}
					case 2756:
					{
						return "Gender Change Potion";
					}
					case 2757:
					{
						return "Vortex Helmet";
					}
					case 2758:
					{
						return "Vortex Breastplate";
					}
					case 2759:
					{
						return "Vortex Leggings";
					}
					case 2760:
					{
						return "Nebula Helmet";
					}
					case 2761:
					{
						return "Nebula Breastplate";
					}
					case 2762:
					{
						return "Nebula Leggings";
					}
					case 2763:
					{
						return "Solar Flare Helmet";
					}
					case 2764:
					{
						return "Solar Flare Breastplate";
					}
					case 2765:
					{
						return "Solar Flare Leggings";
					}
					case 2766:
					{
						return "Solar Tablet Fragment";
					}
					case 2767:
					{
						return "Solar Tablet";
					}
					case 2768:
					{
						return "Drill Containment Unit";
					}
					case 2769:
					{
						return "Cosmic Car Key";
					}
					case 2770:
					{
						return "Mothron Wings";
					}
					case 2771:
					{
						return "Brain Scrambler";
					}
					case 2772:
					{
						return "Vortex Axe";
					}
					case 2773:
					{
						return "Vortex Chainsaw";
					}
					case 2774:
					{
						return "Vortex Drill";
					}
					case 2775:
					{
						return "Vortex Hammer";
					}
					case 2776:
					{
						return "Vortex Pickaxe";
					}
					case 2777:
					{
						return "Nebula Axe";
					}
					case 2778:
					{
						return "Nebula Chainsaw";
					}
					case 2779:
					{
						return "Nebula Drill";
					}
					case 2780:
					{
						return "Nebula Hammer";
					}
					case 2781:
					{
						return "Nebula Pickaxe";
					}
					case 2782:
					{
						return "Solar Flare Axe";
					}
					case 2783:
					{
						return "Solar Flare Chainsaw";
					}
					case 2784:
					{
						return "Solar Flare Drill";
					}
					case 2785:
					{
						return "Solar Flare Hammer";
					}
					case 2786:
					{
						return "Solar Flare Pickaxe";
					}
					case 2787:
					{
						return "Honeyfall Block";
					}
					case 2788:
					{
						return "Honeyfall Wall";
					}
					case 2789:
					{
						return "Chlorophyte Brick Wall";
					}
					case 2790:
					{
						return "Crimtane Brick Wall";
					}
					case 2791:
					{
						return "Shroomite Plating Wall";
					}
					case 2792:
					{
						return "Chlorophyte Brick";
					}
					case 2793:
					{
						return "Crimtane Brick";
					}
					case 2794:
					{
						return "Shroomite Plating";
					}
					case 2795:
					{
						return "Laser Machinegun";
					}
					case 2796:
					{
						return "Electrosphere Launcher";
					}
					case 2797:
					{
						return "Xenopopper";
					}
					case 2798:
					{
						return "Laser Drill";
					}
					case 2799:
					{
						return "Mechanical Ruler";
					}
					case 2800:
					{
						return "Anti-Gravity Hook";
					}
					case 2801:
					{
						return "Moon Mask";
					}
					case 2802:
					{
						return "Sun Mask";
					}
					case 2803:
					{
						return "Martian Costume Mask";
					}
					case 2804:
					{
						return "Martian Costume Shirt";
					}
					case 2805:
					{
						return "Martian Costume Pants";
					}
					case 2806:
					{
						return "Martian Uniform Helmet";
					}
					case 2807:
					{
						return "Martian Uniform Torso";
					}
					case 2808:
					{
						return "Martian Uniform Pants";
					}
					case 2809:
					{
						return "Martian Astro Clock";
					}
					case 2810:
					{
						return "Martian Bathtub";
					}
					case 2811:
					{
						return "Martian Bed";
					}
					case 2812:
					{
						return "Martian Hover Chair";
					}
					case 2813:
					{
						return "Martian Chandelier";
					}
					case 2814:
					{
						return "Martian Chest";
					}
					case 2815:
					{
						return "Martian Door";
					}
					case 2816:
					{
						return "Martian Dresser";
					}
					case 2817:
					{
						return "Martian Holobookcase";
					}
					case 2818:
					{
						return "Martian Hover Candle";
					}
					case 2819:
					{
						return "Martian Lamppost";
					}
					case 2820:
					{
						return "Martian Lantern";
					}
					case 2821:
					{
						return "Martian Piano";
					}
					case 2822:
					{
						return "Martian Platform";
					}
					case 2823:
					{
						return "Martian Sofa";
					}
					case 2824:
					{
						return "Martian Table";
					}
					case 2825:
					{
						return "Martian Table Lamp";
					}
					case 2826:
					{
						return "Martian Work Bench";
					}
					case 2827:
					{
						return "Wooden Sink";
					}
					case 2828:
					{
						return "Ebonwood Sink";
					}
					case 2829:
					{
						return "Rich Mahogany Sink";
					}
					case 2830:
					{
						return "Pearlwood Sink";
					}
					case 2831:
					{
						return "Bone Sink";
					}
					case 2832:
					{
						return "Flesh Sink";
					}
					case 2833:
					{
						return "Living Wood Sink";
					}
					case 2834:
					{
						return "Skyware Sink";
					}
					case 2835:
					{
						return "Shadewood Sink";
					}
					case 2836:
					{
						return "Lihzahrd Sink";
					}
					case 2837:
					{
						return "Blue Dungeon Sink";
					}
					case 2838:
					{
						return "Green Dungeon Sink";
					}
					case 2839:
					{
						return "Pink Dungeon Sink";
					}
					case 2840:
					{
						return "Obsidian Sink";
					}
					case 2841:
					{
						return "Metal Sink";
					}
					case 2842:
					{
						return "Glass Sink";
					}
					case 2843:
					{
						return "Golden Sink";
					}
					case 2844:
					{
						return "Honey Sink";
					}
					case 2845:
					{
						return "Steampunk Sink";
					}
					case 2846:
					{
						return "Pumpkin Sink";
					}
					case 2847:
					{
						return "Spooky Sink";
					}
					case 2848:
					{
						return "Frozen Sink";
					}
					case 2849:
					{
						return "Dynasty Sink";
					}
					case 2850:
					{
						return "Palm Wood Sink";
					}
					case 2851:
					{
						return "Mushroom Sink";
					}
					case 2852:
					{
						return "Boreal Wood Sink";
					}
					case 2853:
					{
						return "Slime Sink";
					}
					case 2854:
					{
						return "Cactus Sink";
					}
					case 2855:
					{
						return "Martian Sink";
					}
					case 2856:
					{
						return "Solar Cultist Hood";
					}
					case 2857:
					{
						return "Lunar Cultist Hood";
					}
					case 2858:
					{
						return "Solar Cultist Robe";
					}
					case 2859:
					{
						return "Lunar Cultist Robe";
					}
					case 2860:
					{
						return "Martian Conduit Plating";
					}
					case 2861:
					{
						return "Martian Conduit Wall";
					}
					case 2862:
					{
						return "HiTek Sunglasses";
					}
					case 2863:
					{
						return "Martian Hair Dye";
					}
					case 2864:
					{
						return "Martian Dye";
					}
					case 2865:
					{
						return "Castle Marsberg";
					}
					case 2866:
					{
						return "Martia Lisa";
					}
					case 2867:
					{
						return "The Truth Is Up There";
					}
					case 2868:
					{
						return "Smoke Block";
					}
					case 2869:
					{
						return "Living Flame Dye";
					}
					case 2870:
					{
						return "Living Rainbow Dye";
					}
					case 2871:
					{
						return "Shadow Dye";
					}
					case 2872:
					{
						return "Negative Dye";
					}
					case 2873:
					{
						return "Living Ocean Dye";
					}
					case 2874:
					{
						return "Brown Dye";
					}
					case 2875:
					{
						return "Brown and Black Dye";
					}
					case 2876:
					{
						return "Bright Brown Dye";
					}
					case 2877:
					{
						return "Brown and Silver Dye";
					}
					case 2878:
					{
						return "Wisp Dye";
					}
					case 2879:
					{
						return "Pixie Dye";
					}
					case 2880:
					{
						return "Influx Waver";
					}
					case 2881:
					{
						return "Phasic Warp Ejector";
					}
					case 2882:
					{
						return "Charged Blaster Cannon";
					}
					case 2883:
					{
						return "Chlorophyte Dye";
					}
					case 2884:
					{
						return "Unicorn Wisp Dye";
					}
					case 2885:
					{
						return "Infernal Wisp Dye";
					}
					case 2886:
					{
						return "Vicious Powder";
					}
					case 2887:
					{
						return "Vicious Mushroom";
					}
					case 2888:
					{
						return "The Bee's Knees";
					}
					case 2889:
					{
						return "Gold Bird";
					}
					case 2890:
					{
						return "Gold Bunny";
					}
					case 2891:
					{
						return "Gold Butterfly";
					}
					case 2892:
					{
						return "Gold Frog";
					}
					case 2893:
					{
						return "Gold Grasshopper";
					}
					case 2894:
					{
						return "Gold Mouse";
					}
					case 2895:
					{
						return "Gold Worm";
					}
					case 2896:
					{
						return "Sticky Dynamite";
					}
					case 2897:
					{
						return "Angry Trapper Banner";
					}
					case 2898:
					{
						return "Armored Viking Banner";
					}
					case 2899:
					{
						return "Black Slime Banner";
					}
					case 2900:
					{
						return "Blue Armored Bones Banner";
					}
					case 2901:
					{
						return "Blue Cultist Archer Banner";
					}
					case 2902:
					{
						return "Blue Cultist Caster Banner";
					}
					case 2903:
					{
						return "Blue Cultist Fighter Banner";
					}
					case 2904:
					{
						return "Bone Lee Banner";
					}
					case 2905:
					{
						return "Clinger Banner";
					}
					case 2906:
					{
						return "Cochineal Beetle Banner";
					}
					case 2907:
					{
						return "Corrupt Penguin Banner";
					}
					case 2908:
					{
						return "Corrupt Slime Banner";
					}
					case 2909:
					{
						return "Corruptor Banner";
					}
					case 2910:
					{
						return "Crimslime Banner";
					}
					case 2911:
					{
						return "Cursed Skull Banner";
					}
					case 2912:
					{
						return "Cyan Beetle Banner";
					}
					case 2913:
					{
						return "Devourer Banner";
					}
					case 2914:
					{
						return "Diabolist Banner";
					}
					case 2915:
					{
						return "Doctor Bones Banner";
					}
					case 2916:
					{
						return "Dungeon Slime Banner";
					}
					case 2917:
					{
						return "Dungeon Spirit Banner";
					}
					case 2918:
					{
						return "Elf Archer Banner";
					}
					case 2919:
					{
						return "Elf Copter Banner";
					}
					case 2920:
					{
						return "Eyezor Banner";
					}
					case 2921:
					{
						return "Flocko Banner";
					}
					case 2922:
					{
						return "Ghost Banner";
					}
					case 2923:
					{
						return "Giant Bat Banner";
					}
					case 2924:
					{
						return "Giant Cursed Skull Banner";
					}
					case 2925:
					{
						return "Giant Flying Fox Banner";
					}
					case 2926:
					{
						return "Gingerbread Man Banner";
					}
					case 2927:
					{
						return "Goblin Archer Banner";
					}
					case 2928:
					{
						return "Green Slime Banner";
					}
					case 2929:
					{
						return "Headless Horseman Banner";
					}
					case 2930:
					{
						return "Hell Armored Bones Banner";
					}
					case 2931:
					{
						return "Hellhound Banner";
					}
					case 2932:
					{
						return "Hoppin' Jack Banner";
					}
					case 2933:
					{
						return "Ice Bat Banner";
					}
					case 2934:
					{
						return "Ice Golem Banner";
					}
					case 2935:
					{
						return "Ice Slime Banner";
					}
					case 2936:
					{
						return "Ichor Sticker Banner";
					}
					case 2937:
					{
						return "Illuminant Bat Banner";
					}
					case 2938:
					{
						return "Illuminant Slime Banner";
					}
					case 2939:
					{
						return "Jungle Bat Banner";
					}
					case 2940:
					{
						return "Jungle Slime Banner";
					}
					case 2941:
					{
						return "Krampus Banner";
					}
					case 2942:
					{
						return "Lac Beetle Banner";
					}
					case 2943:
					{
						return "Lava Bat Banner";
					}
					case 2944:
					{
						return "Lava Slime Banner";
					}
					case 2945:
					{
						return "Martian Brainscrambler Banner";
					}
					case 2946:
					{
						return "Martian Drone Banner";
					}
					case 2947:
					{
						return "Martian Engineer Banner";
					}
					case 2948:
					{
						return "Martian Gigazapper Banner";
					}
					case 2949:
					{
						return "Martian Gray Grunt Banner";
					}
					case 2950:
					{
						return "Martian Officer Banner";
					}
					case 2951:
					{
						return "Martian Ray Gunner Banner";
					}
					case 2952:
					{
						return "Martian Scutlix Gunner Banner";
					}
					case 2953:
					{
						return "Martian Tesla Turret Banner";
					}
					case 2954:
					{
						return "Mister Stabby Banner";
					}
					case 2955:
					{
						return "Mother Slime Banner";
					}
					case 2956:
					{
						return "Necromancer Banner";
					}
					case 2957:
					{
						return "Nutcracker Banner";
					}
					case 2958:
					{
						return "Paladin Banner";
					}
					case 2959:
					{
						return "Penguin Banner";
					}
					case 2960:
					{
						return "Pinky Banner";
					}
					case 2961:
					{
						return "Poltergeist Banner";
					}
					case 2962:
					{
						return "Possessed Armor Banner";
					}
					case 2963:
					{
						return "Present Mimic Banner";
					}
					case 2964:
					{
						return "Purple Slime Banner";
					}
					case 2965:
					{
						return "Ragged Caster Banner";
					}
					case 2966:
					{
						return "Rainbow Slime Banner";
					}
					case 2967:
					{
						return "Raven Banner";
					}
					case 2968:
					{
						return "Red Slime Banner";
					}
					case 2969:
					{
						return "Rune Wizard Banner";
					}
					case 2970:
					{
						return "Rusty Armored Bones Banner";
					}
					case 2971:
					{
						return "Scarecrow Banner";
					}
					case 2972:
					{
						return "Scutlix Banner";
					}
					case 2973:
					{
						return "Skeleton Archer Banner";
					}
					case 2974:
					{
						return "Skeleton Commando Banner";
					}
					case 2975:
					{
						return "Skeleton Sniper Banner";
					}
					case 2976:
					{
						return "Slimer Banner";
					}
					case 2977:
					{
						return "Snatcher Banner";
					}
					case 2978:
					{
						return "Snow Balla Banner";
					}
					case 2979:
					{
						return "Snowman Gangsta Banner";
					}
					case 2980:
					{
						return "Spiked Ice Slime Banner";
					}
					case 2981:
					{
						return "Spiked Jungle Slime Banner";
					}
					case 2982:
					{
						return "Splinterling Banner";
					}
					case 2983:
					{
						return "Squid Banner";
					}
					case 2984:
					{
						return "Tactical Skeleton Banner";
					}
					case 2985:
					{
						return "The Groom Banner";
					}
					case 2986:
					{
						return "Tim Banner";
					}
					case 2987:
					{
						return "Undead Miner Banner";
					}
					case 2988:
					{
						return "Undead Viking Banner";
					}
					case 2989:
					{
						return "White Cultist Archer Banner";
					}
					case 2990:
					{
						return "White Cultist Caster Banner";
					}
					case 2991:
					{
						return "White Cultist Fighter Banner";
					}
					case 2992:
					{
						return "Yellow Slime Banner";
					}
					case 2993:
					{
						return "Yeti Banner";
					}
					case 2994:
					{
						return "Zombie Elf Banner";
					}
					case 2995:
					{
						return "Sparky";
					}
					case 2996:
					{
						return "Vine Rope";
					}
					case 2997:
					{
						return "Wormhole Potion";
					}
					case 2998:
					{
						return "Summoner Emblem";
					}
					case 2999:
					{
						return "Bewitching Table";
					}
					case 3000:
					{
						return "Alchemy Table";
					}
					case 3001:
					{
						return "Strange Brew";
					}
					case 3002:
					{
						return "Spelunker Glowstick";
					}
					case 3003:
					{
						return "Bone Arrow";
					}
					case 3004:
					{
						return "Bone Torch";
					}
					case 3005:
					{
						return "Vine Rope Coil";
					}
					case 3006:
					{
						return "Life Drain";
					}
					case 3007:
					{
						return "Dart Pistol";
					}
					case 3008:
					{
						return "Dart Rifle";
					}
					case 3009:
					{
						return "Crystal Dart";
					}
					case 3010:
					{
						return "Cursed Dart";
					}
					case 3011:
					{
						return "Ichor Dart";
					}
					case 3012:
					{
						return "Chain Guillotines";
					}
					case 3013:
					{
						return "Fetid Baghnakhs";
					}
					case 3014:
					{
						return "Clinger Staff";
					}
					case 3015:
					{
						return "Putrid Scent";
					}
					case 3016:
					{
						return "Flesh Knuckles";
					}
					case 3017:
					{
						return "Flower Boots";
					}
					case 3018:
					{
						return "Seedler";
					}
					case 3019:
					{
						return "Hellwing Bow";
					}
					case 3020:
					{
						return "Tendon Hook";
					}
					case 3021:
					{
						return "Thorn Hook";
					}
					case 3022:
					{
						return "Illuminant Hook";
					}
					case 3023:
					{
						return "Worm Hook";
					}
					case 3024:
					{
						return "Skiphs's Blood";
					}
					case 3025:
					{
						return "Purple Ooze Dye";
					}
					case 3026:
					{
						return "Reflective Silver Dye";
					}
					case 3027:
					{
						return "Reflective Gold Dye";
					}
					case 3028:
					{
						return "Blue Acid Dye";
					}
					case 3029:
					{
						return "Daedalus Stormbow";
					}
					case 3030:
					{
						return "Flying Knife";
					}
					case 3031:
					{
						return "Bottomless Water Bucket";
					}
					case 3032:
					{
						return "Super Absorbant Sponge";
					}
					case 3033:
					{
						return "Gold Ring";
					}
					case 3034:
					{
						return "Coin Ring";
					}
					case 3035:
					{
						return "Greedy Ring";
					}
					case 3036:
					{
						return "Fish Finder";
					}
					case 3037:
					{
						return "Weather Radio";
					}
					case 3038:
					{
						return "Hades Dye";
					}
					case 3039:
					{
						return "Twilight Dye";
					}
					case 3040:
					{
						return "Acid Dye";
					}
					case 3041:
					{
						return "Glowing Mushroom Dye";
					}
					case 3042:
					{
						return "Phase Dye";
					}
					case 3043:
					{
						return "Magic Lantern";
					}
					case 3044:
					{
						return "Music Box (Lunar Boss)";
					}
					case 3045:
					{
						return "Rainbow Torch";
					}
					case 3046:
					{
						return "Cursed Campfire";
					}
					case 3047:
					{
						return "Demon Campfire";
					}
					case 3048:
					{
						return "Frozen Campfire";
					}
					case 3049:
					{
						return "Ichor Campfire";
					}
					case 3050:
					{
						return "Rainbow Campfire";
					}
					case 3051:
					{
						return "Crystal Vile Shard";
					}
					case 3052:
					{
						return "Shadowflame Bow";
					}
					case 3053:
					{
						return "Shadowflame Hex Doll";
					}
					case 3054:
					{
						return "Shadowflame Knife";
					}
					case 3055:
					{
						return "Acorns";
					}
					case 3056:
					{
						return "Cold Snap";
					}
					case 3057:
					{
						return "Cursed Saint";
					}
					case 3058:
					{
						return "Snowfellas";
					}
					case 3059:
					{
						return "The Season";
					}
					case 3060:
					{
						return "Bone Rattle";
					}
					case 3061:
					{
						return "Architect Gizmo Pack";
					}
					case 3062:
					{
						return "Crimson Heart";
					}
					case 3063:
					{
						return "Meowmere";
					}
					case 3064:
					{
						return "Enchanted Sundial";
					}
					case 3065:
					{
						return "Star Wrath";
					}
					case 3066:
					{
						return "Smooth Marble Block";
					}
					case 3067:
					{
						return "Hellstone Brick Wall";
					}
					case 3068:
					{
						return "Guide to Plant Fiber Cordage";
					}
					case 3069:
					{
						return "Wand of Sparking";
					}
					case 3070:
					{
						return "Gold Bird Cage";
					}
					case 3071:
					{
						return "Gold Bunny Cage";
					}
					case 3072:
					{
						return "Gold Butterfly Jar";
					}
					case 3073:
					{
						return "Gold Frog Cage";
					}
					case 3074:
					{
						return "Gold Grasshopper Cage";
					}
					case 3075:
					{
						return "Gold Mouse Cage";
					}
					case 3076:
					{
						return "Gold Worm Cage";
					}
					case 3077:
					{
						return "Silk Rope";
					}
					case 3078:
					{
						return "Web Rope";
					}
					case 3079:
					{
						return "Silk Rope Coil";
					}
					case 3080:
					{
						return "Web Rope Coil";
					}
					case 3081:
					{
						return "Marble Block";
					}
					case 3082:
					{
						return "Marble Wall";
					}
					case 3083:
					{
						return "Smooth Marble Wall";
					}
					case 3084:
					{
						return "Radar";
					}
					case 3085:
					{
						return "Golden Lock Box";
					}
					case 3086:
					{
						return "Granite Block";
					}
					case 3087:
					{
						return "Smooth Granite Block";
					}
					case 3088:
					{
						return "Granite Wall";
					}
					case 3089:
					{
						return "Smooth Granite Wall";
					}
					case 3090:
					{
						return "Royal Gel";
					}
					case 3091:
					{
						return "Key of Night";
					}
					case 3092:
					{
						return "Key of Light";
					}
					case 3093:
					{
						return "Herb Bag";
					}
					case 3094:
					{
						return "Javelin";
					}
					case 3095:
					{
						return "Tally Counter";
					}
					case 3096:
					{
						return "Sextant";
					}
					case 3097:
					{
						return "Shield of Cthulhu";
					}
					case 3098:
					{
						return "Butcher's Chainsaw";
					}
					case 3099:
					{
						return "Stopwatch";
					}
					case 3100:
					{
						return "Meteorite Brick";
					}
					case 3101:
					{
						return "Meteorite Brick Wall";
					}
					case 3102:
					{
						return "Metal Detector";
					}
					case 3103:
					{
						return "Endless Quiver";
					}
					case 3104:
					{
						return "Endless Musket Pouch";
					}
					case 3105:
					{
						return "Toxic Flask";
					}
					case 3106:
					{
						return "Psycho Knife";
					}
					case 3107:
					{
						return "Nail Gun";
					}
					case 3108:
					{
						return "Nail";
					}
					case 3109:
					{
						return "Night Vision Helmet";
					}
					case 3110:
					{
						return "Celestial Shell";
					}
					case 3111:
					{
						return "Pink Gel";
					}
					case 3112:
					{
						return "Bouncy Glowstick";
					}
					case 3113:
					{
						return "Pink Slime Block";
					}
					case 3114:
					{
						return "Pink Torch";
					}
					case 3115:
					{
						return "Bouncy Bomb";
					}
					case 3116:
					{
						return "Bouncy Grenade";
					}
					case 3117:
					{
						return "Peace Candle";
					}
					case 3118:
					{
						return "Lifeform Analyzer";
					}
					case 3119:
					{
						return "DPS Meter";
					}
					case 3120:
					{
						return "Fisherman's Pocket Guide";
					}
					case 3121:
					{
						return "Goblin Tech";
					}
					case 3122:
					{
						return "R.E.K. 3000";
					}
					case 3123:
					{
						return "PDA";
					}
					case 3124:
					{
						return "Cell Phone";
					}
					case 3125:
					{
						return "Granite Chest";
					}
					case 3126:
					{
						return "Meteorite Clock";
					}
					case 3127:
					{
						return "Marble Clock";
					}
					case 3128:
					{
						return "Granite Clock";
					}
					case 3129:
					{
						return "Meteorite Door";
					}
					case 3130:
					{
						return "Marble Door";
					}
					case 3131:
					{
						return "Granite Door";
					}
					case 3132:
					{
						return "Meteorite Dresser";
					}
					case 3133:
					{
						return "Marble Dresser";
					}
					case 3134:
					{
						return "Granite Dresser";
					}
					case 3135:
					{
						return "Meteorite Lamp";
					}
					case 3136:
					{
						return "Marble Lamp";
					}
					case 3137:
					{
						return "Granite Lamp";
					}
					case 3138:
					{
						return "Meteorite Lantern";
					}
					case 3139:
					{
						return "Marble Lantern";
					}
					case 3140:
					{
						return "Granite Lantern";
					}
					case 3141:
					{
						return "Meteorite Piano";
					}
					case 3142:
					{
						return "Marble Piano";
					}
					case 3143:
					{
						return "Granite Piano";
					}
					case 3144:
					{
						return "Meteorite Platform";
					}
					case 3145:
					{
						return "Marble Platform";
					}
					case 3146:
					{
						return "Granite Platform";
					}
					case 3147:
					{
						return "Meteorite Sink";
					}
					case 3148:
					{
						return "Marble Sink";
					}
					case 3149:
					{
						return "Granite Sink";
					}
					case 3150:
					{
						return "Meteorite Sofa";
					}
					case 3151:
					{
						return "Marble Sofa";
					}
					case 3152:
					{
						return "Granite Sofa";
					}
					case 3153:
					{
						return "Meteorite Table";
					}
					case 3154:
					{
						return "Marble Table";
					}
					case 3155:
					{
						return "Granite Table";
					}
					case 3156:
					{
						return "Meteorite Work Bench";
					}
					case 3157:
					{
						return "Marble Work Bench";
					}
					case 3158:
					{
						return "Granite Work Bench";
					}
					case 3159:
					{
						return "Meteorite Bathtub";
					}
					case 3160:
					{
						return "Marble Bathtub";
					}
					case 3161:
					{
						return "Granite Bathtub";
					}
					case 3162:
					{
						return "Meteorite Bed";
					}
					case 3163:
					{
						return "Marble Bed";
					}
					case 3164:
					{
						return "Granite Bed";
					}
					case 3165:
					{
						return "Meteorite Bookcase";
					}
					case 3166:
					{
						return "Marble Bookcase";
					}
					case 3167:
					{
						return "Granite Bookcase";
					}
					case 3168:
					{
						return "Meteorite Candelabra";
					}
					case 3169:
					{
						return "Marble Candelabra";
					}
					case 3170:
					{
						return "Granite Candelabra";
					}
					case 3171:
					{
						return "Meteorite Candle";
					}
					case 3172:
					{
						return "Marble Candle";
					}
					case 3173:
					{
						return "Granite Candle";
					}
					case 3174:
					{
						return "Meteorite Chair";
					}
					case 3175:
					{
						return "Marble Chair";
					}
					case 3176:
					{
						return "Granite Chair";
					}
					case 3177:
					{
						return "Meteorite Chandelier";
					}
					case 3178:
					{
						return "Marble Chandelier";
					}
					case 3179:
					{
						return "Granite Chandelier";
					}
					case 3180:
					{
						return "Meteorite Chest";
					}
					case 3181:
					{
						return "Marble Chest";
					}
					case 3182:
					{
						return "Magic Water Dropper";
					}
					case 3183:
					{
						return "Golden Bug Net";
					}
					case 3184:
					{
						return "Magic Lava Dropper";
					}
					case 3185:
					{
						return "Magic Honey Dropper";
					}
					case 3186:
					{
						return "Empty Dropper";
					}
					case 3187:
					{
						return "Gladiator Helmet";
					}
					case 3188:
					{
						return "Gladiator Breastplate";
					}
					case 3189:
					{
						return "Gladiator Leggings";
					}
					case 3190:
					{
						return "Reflective Dye";
					}
					case 3191:
					{
						return "Enchanted Nightcrawler";
					}
					case 3192:
					{
						return "Grubby";
					}
					case 3193:
					{
						return "Sluggy";
					}
					case 3194:
					{
						return "Buggy";
					}
					case 3195:
					{
						return "Grub Soup";
					}
					case 3196:
					{
						return "Bomb Fish";
					}
					case 3197:
					{
						return "Frost Daggerfish";
					}
					case 3198:
					{
						return "Sharpening Station";
					}
					case 3199:
					{
						return "Ice Mirror";
					}
					case 3200:
					{
						return "Sailfish Boots";
					}
					case 3201:
					{
						return "Tsunami in a Bottle";
					}
					case 3202:
					{
						return "Target Dummy";
					}
					case 3203:
					{
						return "Corrupt Crate";
					}
					case 3204:
					{
						return "Crimson Crate";
					}
					case 3205:
					{
						return "Dungeon Crate";
					}
					case 3206:
					{
						return "Sky Crate";
					}
					case 3207:
					{
						return "Hallowed Crate";
					}
					case 3208:
					{
						return "Jungle Crate";
					}
					case 3209:
					{
						return "Crystal Serpent";
					}
					case 3210:
					{
						return "Toxikarp";
					}
					case 3211:
					{
						return "Bladetongue";
					}
					case 3212:
					{
						return "Shark Tooth Necklace";
					}
					case 3213:
					{
						return "Money Trough";
					}
					case 3214:
					{
						return "Bubble";
					}
					case 3215:
					{
						return "Daybloom Planter Box";
					}
					case 3216:
					{
						return "Moonglow Planter Box";
					}
					case 3217:
					{
						return "Deathweed Planter Box";
					}
					case 3218:
					{
						return "Deathweed Planter Box";
					}
					case 3219:
					{
						return "Blinkroot Planter Box";
					}
					case 3220:
					{
						return "Waterleaf Planter Box";
					}
					case 3221:
					{
						return "Shiverthorn Planter Box";
					}
					case 3222:
					{
						return "Fireblossom Planter Box";
					}
					case 3223:
					{
						return "Brain of Confusion";
					}
					case 3224:
					{
						return "Worm Scarf";
					}
					case 3225:
					{
						return "Balloon Pufferfish";
					}
					case 3226:
					{
						return "Lazure's Valkyrie Circlet";
					}
					case 3227:
					{
						return "Lazure's Valkyrie Cloak";
					}
					case 3228:
					{
						return "Lazure's Barrier Platform";
					}
					case 3229:
					{
						return "Golden Cross Grave Marker";
					}
					case 3230:
					{
						return "Golden Tombstone";
					}
					case 3231:
					{
						return "Golden Grave Marker";
					}
					case 3232:
					{
						return "Golden Gravestone";
					}
					case 3233:
					{
						return "Golden Headstone";
					}
					case 3234:
					{
						return "Crystal Block";
					}
					case 3235:
					{
						return "Music Box (Martian Madness)";
					}
					case 3236:
					{
						return "Music Box (Pirate Invasion)";
					}
					case 3237:
					{
						return "Music Box (Hell)";
					}
					case 3238:
					{
						return "Crystal Block Wall";
					}
					case 3239:
					{
						return "Trap Door";
					}
					case 3240:
					{
						return "Tall Gate";
					}
					case 3241:
					{
						return "Sharkron Balloon";
					}
					case 3242:
					{
						return "Tax Collector's Hat";
					}
					case 3243:
					{
						return "Tax Collector's Suit";
					}
					case 3244:
					{
						return "Tax Collector's Pants";
					}
					case 3245:
					{
						return "Bone Glove";
					}
					case 3246:
					{
						return "Clothier's Jacket";
					}
					case 3247:
					{
						return "Clothier's Pants";
					}
					case 3248:
					{
						return "Dye Trader's Turban";
					}
					case 3249:
					{
						return "Deadly Sphere Staff";
					}
					case 3250:
					{
						return "Green Horseshoe Balloon";
					}
					case 3251:
					{
						return "Amber Horseshoe Balloon";
					}
					case 3252:
					{
						return "Pink Horseshoe Balloon";
					}
					case 3253:
					{
						return "Lava Lamp";
					}
					case 3254:
					{
						return "Enchanted Nightcrawler Cage";
					}
					case 3255:
					{
						return "Buggy Cage";
					}
					case 3256:
					{
						return "Grubby Cage";
					}
					case 3257:
					{
						return "Sluggy Cage";
					}
					case 3258:
					{
						return "Slap Hand";
					}
					case 3259:
					{
						return "Twilight Hair Dye";
					}
					case 3260:
					{
						return "Blessed Apple";
					}
					case 3261:
					{
						return "Spectre Bar";
					}
					case 3262:
					{
						return "Code 1";
					}
					case 3263:
					{
						return "Buccaneer Bandana";
					}
					case 3264:
					{
						return "Buccaneer Tunic";
					}
					case 3265:
					{
						return "Buccaneer Pantaloons";
					}
					case 3266:
					{
						return "Obsidian Outlaw Hat";
					}
					case 3267:
					{
						return "Obsidian Longcoat";
					}
					case 3268:
					{
						return "Obsidian Pants";
					}
					case 3269:
					{
						return "Medusa Head";
					}
					case 3270:
					{
						return "Item Frame";
					}
					case 3271:
					{
						return "Sandstone Block";
					}
					case 3272:
					{
						return "Hardened Sand Block";
					}
					case 3273:
					{
						return "Sandstone Wall";
					}
					case 3274:
					{
						return "Hardened Ebonsand Block";
					}
					case 3275:
					{
						return "Hardened Crimsand Block";
					}
					case 3276:
					{
						return "Ebonsandstone Block";
					}
					case 3277:
					{
						return "Crimsandstone Block";
					}
					case 3278:
					{
						return "Wooden Yoyo";
					}
					case 3279:
					{
						return "Malaise";
					}
					case 3280:
					{
						return "Artery";
					}
					case 3281:
					{
						return "Amazon";
					}
					case 3282:
					{
						return "Cascade";
					}
					case 3283:
					{
						return "Chik";
					}
					case 3284:
					{
						return "Code 2";
					}
					case 3285:
					{
						return "Rally";
					}
					case 3286:
					{
						return "Yelets";
					}
					case 3287:
					{
						return "Red's Throw";
					}
					case 3288:
					{
						return "Valkyrie Yoyo";
					}
					case 3289:
					{
						return "Amarok";
					}
					case 3290:
					{
						return "Hel-Fire";
					}
					case 3291:
					{
						return "Kraken";
					}
					case 3292:
					{
						return "The Eye of Cthulhu";
					}
					case 3293:
					{
						return "Red String";
					}
					case 3294:
					{
						return "Orange String";
					}
					case 3295:
					{
						return "Yellow String";
					}
					case 3296:
					{
						return "Lime String";
					}
					case 3297:
					{
						return "Green String";
					}
					case 3298:
					{
						return "Teal String";
					}
					case 3299:
					{
						return "Cyan String";
					}
					case 3300:
					{
						return "Sky Blue String";
					}
					case 3301:
					{
						return "Blue String";
					}
					case 3302:
					{
						return "Purple String";
					}
					case 3303:
					{
						return "Violet String";
					}
					case 3304:
					{
						return "Pink String";
					}
					case 3305:
					{
						return "Brown String";
					}
					case 3306:
					{
						return "White String";
					}
					case 3307:
					{
						return "Rainbow String";
					}
					case 3308:
					{
						return "Black String";
					}
					case 3309:
					{
						return "Black Counterweight";
					}
					case 3310:
					{
						return "Blue Counterweight";
					}
					case 3311:
					{
						return "Green Counterweight";
					}
					case 3312:
					{
						return "Purple Counterweight";
					}
					case 3313:
					{
						return "Red Counterweight";
					}
					case 3314:
					{
						return "Yellow Counterweight";
					}
					case 3315:
					{
						return "Format:C";
					}
					case 3316:
					{
						return "Gradient";
					}
					case 3317:
					{
						return "Valor";
					}
					case 3318:
					{
						return "King Slime Treasure Bag";
					}
					case 3319:
					{
						return "Eye of Cthulhu Treasure Bag";
					}
					case 3320:
					{
						return "Eater of Worlds Treasure Bag";
					}
					case 3321:
					{
						return "Queen Bee Treasure Bag";
					}
					case 3322:
					{
						return "Brain of Cthulhu Treasure Bag";
					}
					case 3323:
					{
						return "Skeletron Treasure Bag";
					}
					case 3324:
					{
						return "Wall of Flesh Treasure Bag";
					}
					case 3325:
					{
						return "The Destroyer Treasure Bag";
					}
					case 3326:
					{
						return "The Twins Treasure Bag";
					}
					case 3327:
					{
						return "Skeletron Prime Treasure Bag";
					}
					case 3328:
					{
						return "Plantera Treasure Bag";
					}
					case 3329:
					{
						return "Golem Treasure Bag";
					}
					case 3330:
					{
						return "Duke Fishron Treasure Bag";
					}
					case 3331:
					{
						return "Lunatic Cultist Treasure Bag";
					}
					case 3332:
					{
						return "Moon Lord Treasure Bag";
					}
					case 3333:
					{
						return "Hive Pack";
					}
					case 3334:
					{
						return "Yoyo Glove";
					}
					case 3335:
					{
						return "Demon Heart";
					}
					case 3336:
					{
						return "Spore Sac";
					}
					case 3337:
					{
						return "Shiny Stone";
					}
					case 3338:
					{
						return "Hardened Pearlsand Block";
					}
					case 3339:
					{
						return "Pearlsandstone Block";
					}
					case 3340:
					{
						return "Hardened Sand Wall";
					}
					case 3341:
					{
						return "Hardened Ebonsand Wall";
					}
					case 3342:
					{
						return "Hardened Crimsand Wall";
					}
					case 3343:
					{
						return "Hardened Pearlsand Wall";
					}
					case 3344:
					{
						return "Ebonsandstone Wall";
					}
					case 3345:
					{
						return "Crimsandstone Wall";
					}
					case 3346:
					{
						return "Pearlsandstone Wall";
					}
					case 3347:
					{
						return "Desert Fossil";
					}
					case 3348:
					{
						return "Desert Fossil Wall";
					}
					case 3349:
					{
						return "Exotic Scimitar";
					}
					case 3350:
					{
						return "Paintball Gun";
					}
					case 3351:
					{
						return "Classy Cane";
					}
					case 3352:
					{
						return "Stylish Scissors";
					}
					case 3353:
					{
						return "Mechanical Cart";
					}
					case 3354:
					{
						return "Mechanical Wheel Piece";
					}
					case 3355:
					{
						return "Mechanical Wagon Piece";
					}
					case 3356:
					{
						return "Mechanical Battery Piece";
					}
					case 3357:
					{
						return "Ancient Cultist Trophy";
					}
					case 3358:
					{
						return "Martian Saucer Trophy";
					}
					case 3359:
					{
						return "Flying Dutchman Trophy";
					}
					case 3360:
					{
						return "Living Mahogany Wand";
					}
					case 3361:
					{
						return "Rich Mahogany Leaf Wand";
					}
					case 3362:
					{
						return "Fallen Tuxedo Shirt";
					}
					case 3363:
					{
						return "Fallen Tuxedo Pants";
					}
					case 3364:
					{
						return "Fireplace";
					}
					case 3365:
					{
						return "Chimney";
					}
					case 3366:
					{
						return "Yoyo Bag";
					}
					case 3367:
					{
						return "Shrimpy Truffle";
					}
					case 3368:
					{
						return "Arkhalis";
					}
					case 3369:
					{
						return "Confetti Cannon";
					}
					case 3370:
					{
						return "Music Box (The Towers)";
					}
					case 3371:
					{
						return "Music Box (Goblin Invasion)";
					}
					case 3372:
					{
						return "Ancient Cultist Mask";
					}
					case 3373:
					{
						return "Moon Lord Mask";
					}
					case 3374:
					{
						return "Fossil Helmet";
					}
					case 3375:
					{
						return "Fossil Plate";
					}
					case 3376:
					{
						return "Fossil Greaves";
					}
					case 3377:
					{
						return "Amber Staff";
					}
					case 3378:
					{
						return "Bone Javelin";
					}
					case 3379:
					{
						return "Bone Throwing Knife";
					}
					case 3380:
					{
						return "Sturdy Fossil";
					}
					case 3381:
					{
						return "Stardust Helmet";
					}
					case 3382:
					{
						return "Stardust Plate";
					}
					case 3383:
					{
						return "Stardust Leggings";
					}
					case 3384:
					{
						return "Portal Gun";
					}
					case 3385:
					case 3386:
					case 3387:
					case 3388:
					{
						return "Strange Plant";
					}
					case 3389:
					{
						return "Terrarian";
					}
					case 3390:
					{
						return "Goblin Summoner Banner";
					}
					case 3391:
					{
						return "Salamander Banner";
					}
					case 3392:
					{
						return "Giant Shelly Banner";
					}
					case 3393:
					{
						return "Crawdad Banner";
					}
					case 3394:
					{
						return "Fritz Banner";
					}
					case 3395:
					{
						return "Creature From The Deep Banner";
					}
					case 3396:
					{
						return "Dr. Man Fly Banner";
					}
					case 3397:
					{
						return "Mothron Banner";
					}
					case 3398:
					{
						return "Severed Hand Banner";
					}
					case 3399:
					{
						return "The Possessed Banner";
					}
					case 3400:
					{
						return "Butcher Banner";
					}
					case 3401:
					{
						return "Psycho Banner";
					}
					case 3402:
					{
						return "Deadly Sphere Banner";
					}
					case 3403:
					{
						return "Nailhead Banner";
					}
					case 3404:
					{
						return "Poisonous Spore Banner";
					}
					case 3405:
					{
						return "Medusa Banner";
					}
					case 3406:
					{
						return "Hoplite Banner";
					}
					case 3407:
					{
						return "Granite Elemental Banner";
					}
					case 3408:
					{
						return "Grolem Banner";
					}
					case 3409:
					{
						return "Blood Zombie Banner";
					}
					case 3410:
					{
						return "Drippler Banner";
					}
					case 3411:
					{
						return "Tomb Crawler Banner";
					}
					case 3412:
					{
						return "Dune Splicer Banner";
					}
					case 3413:
					{
						return "Antlion Swarmer Banner";
					}
					case 3414:
					{
						return "Antlion Charger Banner";
					}
					case 3415:
					{
						return "Ghoul Banner";
					}
					case 3416:
					{
						return "Lamia Banner";
					}
					case 3417:
					{
						return "Desert Spirit Banner";
					}
					case 3418:
					{
						return "Basilisk Banner";
					}
					case 3419:
					{
						return "Ravager Scorpion Banner";
					}
					case 3420:
					{
						return "Stargazer Banner";
					}
					case 3421:
					{
						return "Milkyway Weaver Banner";
					}
					case 3422:
					{
						return "Flow Invader Banner";
					}
					case 3423:
					{
						return "Twinkle Popper Banner";
					}
					case 3424:
					{
						return "Small Star Cell Banner";
					}
					case 3425:
					{
						return "Star Cell Banner";
					}
					case 3426:
					{
						return "Corite Banner";
					}
					case 3427:
					{
						return "Sroller Banner";
					}
					case 3428:
					{
						return "Crawltipede Banner";
					}
					case 3429:
					{
						return "Drakomire Rider Banner";
					}
					case 3430:
					{
						return "Drakomire Banner";
					}
					case 3431:
					{
						return "Selenian Banner";
					}
					case 3432:
					{
						return "Predictor Banner";
					}
					case 3433:
					{
						return "Brain Suckler Banner";
					}
					case 3434:
					{
						return "Nebula Floater Banner";
					}
					case 3435:
					{
						return "Evolution Beast Banner";
					}
					case 3436:
					{
						return "Alien Larva Banner";
					}
					case 3437:
					{
						return "Alien Queen Banner";
					}
					case 3438:
					{
						return "Alien Hornet Banner";
					}
					case 3439:
					{
						return "Vortexian Banner";
					}
					case 3440:
					{
						return "Storm Diver Banner";
					}
					case 3441:
					{
						return "Pirate Captain Banner";
					}
					case 3442:
					{
						return "Pirate Deadeye Banner";
					}
					case 3443:
					{
						return "Pirate Corsair Banner";
					}
					case 3444:
					{
						return "Pirate Crossbower Banner";
					}
					case 3445:
					{
						return "Martian Walker Banner";
					}
					case 3446:
					{
						return "Red Devil Banner";
					}
					case 3447:
					{
						return "Pink Jellyfish Banner";
					}
					case 3448:
					{
						return "Green Jellyfish Banner";
					}
					case 3449:
					{
						return "Dark Mummy Banner";
					}
					case 3450:
					{
						return "Light Mummy Banner";
					}
					case 3451:
					{
						return "Angry Bones Banner";
					}
					case 3452:
					{
						return "Ice Tortoise Banner";
					}
					case 3453:
					{
						return "Damage Booster";
					}
					case 3454:
					{
						return "Life Booster";
					}
					case 3455:
					{
						return "Mana Booster";
					}
					case 3456:
					{
						return "Vortex Fragment";
					}
					case 3457:
					{
						return "Nebula Fragment";
					}
					case 3458:
					{
						return "Solar Fragment";
					}
					case 3459:
					{
						return "Stardust Fragment";
					}
					case 3460:
					{
						return "Luminite";
					}
					case 3461:
					{
						return "Luminite Brick";
					}
					case 3462:
					{
						return "Stardust Axe";
					}
					case 3463:
					{
						return "Stardust Chainsaw";
					}
					case 3464:
					{
						return "Stardust Drill";
					}
					case 3465:
					{
						return "Stardust Hammer";
					}
					case 3466:
					{
						return "Stardust Pickaxe";
					}
					case 3467:
					{
						return "Luminite Bar";
					}
					case 3468:
					{
						return "Solar Wings";
					}
					case 3469:
					{
						return "Vortex Booster";
					}
					case 3470:
					{
						return "Nebula Mantle";
					}
					case 3471:
					{
						return "Stardust Wings";
					}
					case 3472:
					{
						return "Luminite Brick Wall";
					}
					case 3473:
					{
						return "Solar Eruption";
					}
					case 3474:
					{
						return "Stardust Cell Staff";
					}
					case 3475:
					{
						return "Vortex Beater";
					}
					case 3476:
					{
						return "Nebula Arcanum";
					}
					case 3477:
					{
						return "Blood Water";
					}
					case 3478:
					{
						return "Wedding Veil";
					}
					case 3479:
					{
						return "Wedding Dress";
					}
					case 3480:
					{
						return "Platinum Bow";
					}
					case 3481:
					{
						return "Platinum Hammer";
					}
					case 3482:
					{
						return "Platinum Axe";
					}
					case 3483:
					{
						return "Platinum Shortsword";
					}
					case 3484:
					{
						return "Platinum Broadsword";
					}
					case 3485:
					{
						return "Platinum Pickaxe";
					}
					case 3486:
					{
						return "Tungsten Bow";
					}
					case 3487:
					{
						return "Tungsten Hammer";
					}
					case 3488:
					{
						return "Tungsten Axe";
					}
					case 3489:
					{
						return "Tungsten Shortsword";
					}
					case 3490:
					{
						return "Tungsten Broadsword";
					}
					case 3491:
					{
						return "Tungsten Pickaxe";
					}
					case 3492:
					{
						return "Lead Bow";
					}
					case 3493:
					{
						return "Lead Hammer";
					}
					case 3494:
					{
						return "Lead Axe";
					}
					case 3495:
					{
						return "Lead Shortsword";
					}
					case 3496:
					{
						return "Lead Broadsword";
					}
					case 3497:
					{
						return "Lead Pickaxe";
					}
					case 3498:
					{
						return "Tin Bow";
					}
					case 3499:
					{
						return "Tin Hammer";
					}
					case 3500:
					{
						return "Tin Axe";
					}
					case 3501:
					{
						return "Tin Shortsword";
					}
					case 3502:
					{
						return "Tin Broadsword";
					}
					case 3503:
					{
						return "Tin Pickaxe";
					}
					case 3504:
					{
						return "Copper Bow";
					}
					case 3505:
					{
						return "Copper Hammer";
					}
					case 3506:
					{
						return "Copper Axe";
					}
					case 3507:
					{
						return "Copper Shortsword";
					}
					case 3508:
					{
						return "Copper Broadsword";
					}
					case 3509:
					{
						return "Copper Pickaxe";
					}
					case 3510:
					{
						return "Silver Bow";
					}
					case 3511:
					{
						return "Silver Hammer";
					}
					case 3512:
					{
						return "Silver Axe";
					}
					case 3513:
					{
						return "Silver Shortsword";
					}
					case 3514:
					{
						return "Silver Broadsword";
					}
					case 3515:
					{
						return "Silver Pickaxe";
					}
					case 3516:
					{
						return "Gold Bow";
					}
					case 3517:
					{
						return "Gold Hammer";
					}
					case 3518:
					{
						return "Gold Axe";
					}
					case 3519:
					{
						return "Gold Shortsword";
					}
					case 3520:
					{
						return "Gold Broadsword";
					}
					case 3521:
					{
						return "Gold Pickaxe";
					}
					case 3522:
					{
						return "Solar Flare Hamaxe";
					}
					case 3523:
					{
						return "Vortex Hamaxe";
					}
					case 3524:
					{
						return "Nebula Hamaxe";
					}
					case 3525:
					{
						return "Stardust Hamaxe";
					}
					case 3526:
					{
						return "Solar Dye";
					}
					case 3527:
					{
						return "Nebula Dye";
					}
					case 3528:
					{
						return "Vortex Dye";
					}
					case 3529:
					{
						return "Stardust Dye";
					}
					case 3530:
					{
						return "Void Dye";
					}
					case 3531:
					{
						return "Stardust Dragon Staff";
					}
					case 3532:
					{
						return "Bacon";
					}
					case 3533:
					{
						return "Shifting Sands Dye";
					}
					case 3534:
					{
						return "Mirage Dye";
					}
					case 3535:
					{
						return "Shifting Pearlsands Dye";
					}
					case 3536:
					{
						return "Vortex Monolith";
					}
					case 3537:
					{
						return "Nebula Monolith";
					}
					case 3538:
					{
						return "Stardust Monolith";
					}
					case 3539:
					{
						return "Solar Monolith";
					}
					case 3540:
					{
						return "Phantasm";
					}
					case 3541:
					{
						return "Last Prism";
					}
					case 3542:
					{
						return "Nebula Blaze";
					}
					case 3543:
					{
						return "Daybreak";
					}
					case 3544:
					{
						return "Super Healing Potion";
					}
					case 3545:
					{
						return "Detonator";
					}
					case 3546:
					{
						return "Celebration";
					}
					case 3547:
					{
						return "Bouncy Dynamite";
					}
					case 3548:
					{
						return "Happy Grenade";
					}
					case 3549:
					{
						return "Ancient Manipulator";
					}
					case 3550:
					{
						return "Flame and Silver Dye";
					}
					case 3551:
					{
						return "Green Flame and Silver Dye";
					}
					case 3552:
					{
						return "Blue Flame and Silver Dye";
					}
					case 3553:
					{
						return "Reflective Copper Dye";
					}
					case 3554:
					{
						return "Reflective Obsidian Dye";
					}
					case 3555:
					{
						return "Reflective Metal Dye";
					}
					case 3556:
					{
						return "Midnight Rainbow Dye";
					}
					case 3557:
					{
						return "Black and White Dye";
					}
					case 3558:
					{
						return "Bright Silver Dye";
					}
					case 3559:
					{
						return "Silver and Black Dye";
					}
					case 3560:
					{
						return "Red Acid Dye";
					}
					case 3561:
					{
						return "Gel Dye";
					}
					case 3562:
					{
						return "Pink Gel Dye";
					}
					case 3563:
					{
						return "Red Squirrel";
					}
					case 3564:
					{
						return "Gold Squirrel";
					}
					case 3565:
					{
						return "Red Squirrel Cage";
					}
					case 3566:
					{
						return "Gold Squirrel Cage";
					}
					case 3567:
					{
						return "Luminite Bullet";
					}
					case 3568:
					{
						return "Luminite Arrow";
					}
					case 3569:
					{
						return "Lunar Portal Staff";
					}
					case 3570:
					{
						return "Lunar Flare";
					}
					case 3571:
					{
						return "Rainbow Crystal Staff";
					}
					case 3572:
					{
						return "Lunar Hook";
					}
					case 3573:
					{
						return "Solar Fragment Block";
					}
					case 3574:
					{
						return "Vortex Fragment Block";
					}
					case 3575:
					{
						return "Nebula Fragment Block";
					}
					case 3576:
					{
						return "Stardust Fragment Block";
					}
					case 3577:
					{
						return "Suspicious Looking Tentacle";
					}
					case 3578:
					{
						return "Yoraiz0r's Uniform";
					}
					case 3579:
					{
						return "Yoraiz0r's Skirt";
					}
					case 3580:
					{
						return "Yoraiz0r's Spell";
					}
					case 3581:
					{
						return "Yoraiz0r's Scowl";
					}
					case 3582:
					{
						return "Jim's Wings";
					}
					case 3583:
					{
						return "Yoraiz0r's Recolored Goggles";
					}
					case 3584:
					{
						return "Living Leaf Wall";
					}
					case 3585:
					{
						return "Skiphs's Mask";
					}
					case 3586:
					{
						return "Skiphs's Skin";
					}
					case 3587:
					{
						return "Skiphs's Bear Butt";
					}
					case 3588:
					{
						return "Skiphs's Paws";
					}
					case 3589:
					{
						return "Loki's Helmet";
					}
					case 3590:
					{
						return "Loki's Breastplate";
					}
					case 3591:
					{
						return "Loki's Greaves";
					}
					case 3592:
					{
						return "Loki's Wings";
					}
					case 3593:
					{
						return "Sand Slime Banner";
					}
					case 3594:
					{
						return "Sea Snail Banner";
					}
					case 3595:
					{
						return "Moon Lord Trophy";
					}
					case 3596:
					{
						return "Not a Kid, nor a Squid";
					}
					case 3597:
					{
						return "Burning Hades Dye";
					}
					case 3598:
					{
						return "Grim Dye";
					}
					case 3599:
					{
						return "Loki's Dye";
					}
					case 3600:
					{
						return "Shadowflame Hades Dye";
					}
					case 3601:
					{
						return "Celestial Sigil";
					}
				}
			}
			else if (Lang.lang == 2)
			{
				int num = l;
				switch (num)
				{
					case -24:
					{
						return "Gelbes Laserschwert";
					}
					case -23:
					{
						return "Weisses Laserschwert";
					}
					case -22:
					{
						return "Lila Laserschwert";
					}
					case -21:
					{
						return "Gruenes Laserschwert";
					}
					case -20:
					{
						return "Rotes Laserschwert";
					}
					case -19:
					{
						return "Blaues Laserschwert";
					}
					case -18:
					{
						return "Kupferbogen";
					}
					case -17:
					{
						return "Kupferhammer";
					}
					case -16:
					{
						return "Kupferaxt";
					}
					case -15:
					{
						return "Kupferkurzschwert";
					}
					case -14:
					{
						return "Kupferbreitschwert";
					}
					case -13:
					{
						return "Kupferspitzhacke";
					}
					case -12:
					{
						return "Silberbogen";
					}
					case -11:
					{
						return "Silberhammer";
					}
					case -10:
					{
						return "Silberaxt";
					}
					case -9:
					{
						return "Silberkurzschwert";
					}
					case -8:
					{
						return "Silberbreitschwert";
					}
					case -7:
					{
						return "Silberspitzhacke";
					}
					case -6:
					{
						return "Goldbogen";
					}
					case -5:
					{
						return "Goldhammer";
					}
					case -4:
					{
						return "Goldaxt";
					}
					case -3:
					{
						return "Goldkurzschwert";
					}
					case -2:
					{
						return "Goldbreitschwert";
					}
					case -1:
					{
						return "Goldspitzhacke";
					}
					case 0:
					{
						break;
					}
					case 1:
					{
						return "Eisenspitzhacke";
					}
					case 2:
					{
						return "Dreckblock";
					}
					case 3:
					{
						return "Steinblock";
					}
					case 4:
					{
						return "Eisenbreitschwert";
					}
					case 5:
					{
						return "Pilz";
					}
					case 6:
					{
						return "Eisenkurzschwert";
					}
					case 7:
					{
						return "Eisenhammer";
					}
					case 8:
					{
						return "Fackel";
					}
					case 9:
					{
						return "Holz";
					}
					case 10:
					{
						return "Eisenaxt";
					}
					case 11:
					{
						return "Eisenerz";
					}
					case 12:
					{
						return "Kupfererz";
					}
					case 13:
					{
						return "Golderz";
					}
					case 14:
					{
						return "Silbererz";
					}
					case 15:
					{
						return "Kupferuhr";
					}
					case 16:
					{
						return "Silberuhr";
					}
					case 17:
					{
						return "Golduhr";
					}
					case 18:
					{
						return "Taucheruhr";
					}
					case 19:
					{
						return "Goldbarren";
					}
					case 20:
					{
						return "Kupferbarren";
					}
					case 21:
					{
						return "Silberbarren";
					}
					case 22:
					{
						return "Eisenbarren";
					}
					case 23:
					{
						return "Glibber";
					}
					case 24:
					{
						return "Holzschwert";
					}
					case 25:
					{
						return "Holztuer";
					}
					case 26:
					{
						return "Steinwand";
					}
					case 27:
					{
						return "Eichel";
					}
					case 28:
					{
						return "Schwacher Heiltrank";
					}
					case 29:
					{
						return "Lebenskristall";
					}
					case 30:
					{
						return "Dreckwand";
					}
					case 31:
					{
						return "Flasche";
					}
					case 32:
					{
						return "Holztisch";
					}
					case 33:
					{
						return "Ofen";
					}
					case 34:
					{
						return "Holzstuhl";
					}
					case 35:
					{
						return "Eisenamboss";
					}
					case 36:
					{
						return "Werkbank";
					}
					case 37:
					{
						return "Schutzbrille";
					}
					case 38:
					{
						return "Linse";
					}
					case 39:
					{
						return "Holzbogen";
					}
					case 40:
					{
						return "Holzpfeil";
					}
					case 41:
					{
						return "Flammenpfeil";
					}
					case 42:
					{
						return "Shuriken";
					}
					case 43:
					{
						return "Verdaechtig ausschauendes Auge";
					}
					case 44:
					{
						return "Daemonenbogen";
					}
					case 45:
					{
						return "Kriegsaxt der Nacht";
					}
					case 46:
					{
						return "Schrecken des Tages";
					}
					case 47:
					{
						return "Unheiliger Pfeil";
					}
					case 48:
					{
						return "Truhe";
					}
					case 49:
					{
						return "Wiederbelebungsband";
					}
					case 50:
					{
						return "Magischer Spiegel";
					}
					case 51:
					{
						return "Dominopfeil";
					}
					case 52:
					{
						return "Engelsstatue";
					}
					case 53:
					{
						return "Wolke in einer Flasche";
					}
					case 54:
					{
						return "Hermes-Stiefel";
					}
					case 55:
					{
						return "Verzauberter Bumerang";
					}
					case 56:
					{
						return "Daemoniterz";
					}
					case 57:
					{
						return "Daemonitbarren";
					}
					case 58:
					{
						return "Herz";
					}
					case 59:
					{
						return "Verderbte Saat";
					}
					case 60:
					{
						return "Ekelpilz";
					}
					case 61:
					{
						return "Ebensteinblock";
					}
					case 62:
					{
						return "Grassaat";
					}
					case 63:
					{
						return "Sonnenblume";
					}
					case 64:
					{
						return "Ekeldorn";
					}
					case 65:
					{
						return "Sternenwut";
					}
					case 66:
					{
						return "Reinigungspulver";
					}
					case 67:
					{
						return "Ekelpulver";
					}
					case 68:
					{
						return "Verfaultes";
					}
					case 69:
					{
						return "Wurmzahn";
					}
					case 70:
					{
						return "Wurmkoeder";
					}
					case 71:
					{
						return "Kupfermuenze";
					}
					case 72:
					{
						return "Silbermuenze";
					}
					case 73:
					{
						return "Goldmuenze";
					}
					case 74:
					{
						return "Platinmuenze";
					}
					case 75:
					{
						return "Sternschnuppe";
					}
					case 76:
					{
						return "Kupferbeinschuetzer";
					}
					case 77:
					{
						return "Eisenbeinschuetzer";
					}
					case 78:
					{
						return "Silberbeinschuetzer";
					}
					case 79:
					{
						return "Goldbeinschuetzer";
					}
					case 80:
					{
						return "Kupferkettenhemd";
					}
					case 81:
					{
						return "Eisenkettenhemd";
					}
					case 82:
					{
						return "Silberkettenhemd";
					}
					case 83:
					{
						return "Goldkettenhemd";
					}
					case 84:
					{
						return "Enterhaken";
					}
					case 85:
					{
						return "Eisenkette";
					}
					case 86:
					{
						return "Schattenschuppe";
					}
					case 87:
					{
						return "Sparschwein";
					}
					case 88:
					{
						return "Bergmannshelm";
					}
					case 89:
					{
						return "Kupferhelm";
					}
					case 90:
					{
						return "Eisenhelm";
					}
					case 91:
					{
						return "Silberhelm";
					}
					case 92:
					{
						return "Goldhelm";
					}
					case 93:
					{
						return "Holzwand";
					}
					case 94:
					{
						return "Holzklappe";
					}
					case 95:
					{
						return "Steinschlosspistole";
					}
					case 96:
					{
						return "Muskete";
					}
					case 97:
					{
						return "Musketenkugel";
					}
					case 98:
					{
						return "Minihai";
					}
					case 99:
					{
						return "Eisenbogen";
					}
					case 100:
					{
						return "Schattenbeinschuetzer";
					}
					case 101:
					{
						return "Schattenschuppenhemd";
					}
					case 102:
					{
						return "Schattenhelm";
					}
					case 103:
					{
						return "Albtraum-Spitzhacke";
					}
					case 104:
					{
						return "Zerschmetterer";
					}
					case 105:
					{
						return "Kerze";
					}
					case 106:
					{
						return "Kupferkronleuchter";
					}
					case 107:
					{
						return "Silberkronleuchter";
					}
					case 108:
					{
						return "Goldkronleuchter";
					}
					case 109:
					{
						return "Mana-Kristall";
					}
					case 110:
					{
						return "Schwacher Manatrank";
					}
					case 111:
					{
						return "Sternenkraftband";
					}
					case 112:
					{
						return "Feuerblume";
					}
					case 113:
					{
						return "Magische Rakete";
					}
					case 114:
					{
						return "Dreckrute";
					}
					case 115:
					{
						return "Lichtkugel";
					}
					case 116:
					{
						return "Meteorit";
					}
					case 117:
					{
						return "Meteoritenbarren";
					}
					case 118:
					{
						return "Haken";
					}
					case 119:
					{
						return "Flamarang";
					}
					case 120:
					{
						return "Geschmolzene Wut";
					}
					case 121:
					{
						return "Feuriges Grossschwert";
					}
					case 122:
					{
						return "Geschmolzene Spitzhacke";
					}
					case 123:
					{
						return "Meteorhelm";
					}
					case 124:
					{
						return "Meteoranzug";
					}
					case 125:
					{
						return "Meteor Leggings";
					}
					case 126:
					{
						return "Flaschenwasser";
					}
					case 127:
					{
						return "Raum Gun";
					}
					case 128:
					{
						return "Raketenstiefel";
					}
					case 129:
					{
						return "Grauer Ziegel";
					}
					case 130:
					{
						return "Graue Ziegelsteinwand";
					}
					case 131:
					{
						return "Roter Ziegel";
					}
					case 132:
					{
						return "Rote Ziegelwand";
					}
					case 133:
					{
						return "Lehmblock";
					}
					case 134:
					{
						return "Blauer Ziegel";
					}
					case 135:
					{
						return "Blaue Ziegelwand";
					}
					case 136:
					{
						return "Haengelaterne";
					}
					case 137:
					{
						return "Gruener Ziegel";
					}
					case 138:
					{
						return "Gruene Ziegelwand";
					}
					case 139:
					{
						return "Rosa Ziegel";
					}
					case 140:
					{
						return "Rosa Ziegelwand";
					}
					case 141:
					{
						return "Goldziegel";
					}
					case 142:
					{
						return "Goldziegelwand";
					}
					case 143:
					{
						return "Silberziegel";
					}
					case 144:
					{
						return "Silberziegelwand";
					}
					case 145:
					{
						return "Kupferziegel";
					}
					case 146:
					{
						return "Kupferziegelwand";
					}
					case 147:
					{
						return "Stachel";
					}
					case 148:
					{
						return "Wasserkerze";
					}
					case 149:
					{
						return "Buch";
					}
					case 150:
					{
						return "Spinnennetz";
					}
					case 151:
					{
						return "Necrohelm";
					}
					case 152:
					{
						return "Necro-Brustplatte";
					}
					case 153:
					{
						return "Necro-Beinschuetzer";
					}
					case 154:
					{
						return "Knochen";
					}
					case 155:
					{
						return "Muramasa";
					}
					case 156:
					{
						return "Kobaltschild";
					}
					case 157:
					{
						return "Aqua-Zepter";
					}
					case 158:
					{
						return "Glueckshufeisen";
					}
					case 159:
					{
						return "Leuchtend roter Ballon";
					}
					case 160:
					{
						return "Harpune";
					}
					case 161:
					{
						return "Stachelball";
					}
					case 162:
					{
						return "Ball des Schmerzes";
					}
					case 163:
					{
						return "Blauer Mond";
					}
					case 164:
					{
						return "Pistole";
					}
					case 165:
					{
						return "Wasserbolzen";
					}
					case 166:
					{
						return "Bombe";
					}
					case 167:
					{
						return "Dynamit";
					}
					case 168:
					{
						return "Granate";
					}
					case 169:
					{
						return "Sandblock";
					}
					case 170:
					{
						return "Glas";
					}
					case 171:
					{
						return "Spruchschild";
					}
					case 172:
					{
						return "Aschenblock";
					}
					case 173:
					{
						return "Obsidian";
					}
					case 174:
					{
						return "HOeLLENSTEIN";
					}
					case 175:
					{
						return "HOeLLENSTEIN-Barren";
					}
					case 176:
					{
						return "Matschblock";
					}
					case 177:
					{
						return "Saphir";
					}
					case 178:
					{
						return "Rubin";
					}
					case 179:
					{
						return "Smaragd";
					}
					case 180:
					{
						return "Topas";
					}
					case 181:
					{
						return "Amethyst";
					}
					case 182:
					{
						return "Diamant";
					}
					case 183:
					{
						return "Gluehender Pilz";
					}
					case 184:
					{
						return "Stern";
					}
					case 185:
					{
						return "Efeupeitsche";
					}
					case 186:
					{
						return "Schnorchelschilf";
					}
					case 187:
					{
						return "Flosse";
					}
					case 188:
					{
						return "Heiltrank";
					}
					case 189:
					{
						return "Manatrank";
					}
					case 190:
					{
						return "Grasklinge";
					}
					case 191:
					{
						return "Dornen-Chakram";
					}
					case 192:
					{
						return "Obsidianziegel";
					}
					case 193:
					{
						return "Obsidianschaedel";
					}
					case 194:
					{
						return "Pilzgras-Saat";
					}
					case 195:
					{
						return "Dschungelgras-Saat";
					}
					case 196:
					{
						return "Holzhammer";
					}
					case 197:
					{
						return "Sternenkanone";
					}
					case 198:
					{
						return "Blaue Laserklinge";
					}
					case 199:
					{
						return "Rote Laserklinge";
					}
					case 200:
					{
						return "Gruene Laserklinge";
					}
					case 201:
					{
						return "Lila Laserklinge";
					}
					case 202:
					{
						return "Weisse Laserklinge";
					}
					case 203:
					{
						return "Gelbe Laserklinge";
					}
					case 204:
					{
						return "Meteor-Hamaxt";
					}
					case 205:
					{
						return "Leerer Eimer";
					}
					case 206:
					{
						return "Wassereimer";
					}
					case 207:
					{
						return "Lavaeimer";
					}
					case 208:
					{
						return "Dschungelrose";
					}
					case 209:
					{
						return "Hornissenstachel";
					}
					case 210:
					{
						return "Weinrebe";
					}
					case 211:
					{
						return "Wilde Klauen";
					}
					case 212:
					{
						return "Fusskette des Windes";
					}
					case 213:
					{
						return "Stab des Nachwachsens";
					}
					case 214:
					{
						return "Hoellensteinziegel";
					}
					case 215:
					{
						return "Furzkissen";
					}
					case 216:
					{
						return "Fessel";
					}
					case 217:
					{
						return "Geschmolzene Hamaxt";
					}
					case 218:
					{
						return "Flammenpeitsche";
					}
					case 219:
					{
						return "Phoenix-Blaster";
					}
					case 220:
					{
						return "Sonnenwut";
					}
					case 221:
					{
						return "Hoellenschmiede";
					}
					case 222:
					{
						return "Tontopf";
					}
					case 223:
					{
						return "Geschenk der Natur";
					}
					case 224:
					{
						return "Bett";
					}
					case 225:
					{
						return "Seide";
					}
					case 226:
					{
						return "Schwacher Wiederherstellungstrank";
					}
					case 227:
					{
						return "Wiederherstellungstrank";
					}
					case 228:
					{
						return "Dschungelhut";
					}
					case 229:
					{
						return "Dschungelhemd";
					}
					case 230:
					{
						return "Dschungelhosen";
					}
					case 231:
					{
						return "Geschmolzener Helm";
					}
					case 232:
					{
						return "Geschmolzene Brustplatte";
					}
					case 233:
					{
						return "Geschmolzene Beinschuetzer";
					}
					case 234:
					{
						return "Meteorenschuss";
					}
					case 235:
					{
						return "Haftbombe";
					}
					case 236:
					{
						return "Schwarze Linsen";
					}
					case 237:
					{
						return "Sonnenbrille";
					}
					case 238:
					{
						return "Zaubererhut";
					}
					case 239:
					{
						return "Zylinderhut";
					}
					case 240:
					{
						return "Smokinghemd";
					}
					case 241:
					{
						return "Smokinghosen";
					}
					case 242:
					{
						return "Sommerhut";
					}
					case 243:
					{
						return "Hasenkapuze";
					}
					case 244:
					{
						return "Klempnerhut";
					}
					case 245:
					{
						return "Klempnerhemd";
					}
					case 246:
					{
						return "Klempnerhosen";
					}
					case 247:
					{
						return "Heldenhut";
					}
					case 248:
					{
						return "Heldenhemd";
					}
					case 249:
					{
						return "Heldenhosen";
					}
					case 250:
					{
						return "Fischglas";
					}
					case 251:
					{
						return "Archaeologenhut";
					}
					case 252:
					{
						return "Archaeologenjacke";
					}
					case 253:
					{
						return "Archaeologenhosen";
					}
					case 254:
					{
						return "Schwarzer Farbstoff";
					}
					case 255:
					{
						return "Gruener Farbstoff";
					}
					case 256:
					{
						return "Ninja-Kapuze";
					}
					case 257:
					{
						return "Ninjahemd";
					}
					case 258:
					{
						return "Ninjahosen";
					}
					case 259:
					{
						return "Leder";
					}
					case 260:
					{
						return "Roter Hut";
					}
					case 261:
					{
						return "Goldfisch";
					}
					case 262:
					{
						return "Robe";
					}
					case 263:
					{
						return "Roboterhut";
					}
					case 264:
					{
						return "Goldkrone";
					}
					case 265:
					{
						return "Hoellenfeuer-Pfeil";
					}
					case 266:
					{
						return "Sandgewehr";
					}
					case 267:
					{
						return "Fremdenfuehrer-Voodoo-Puppe";
					}
					case 268:
					{
						return "Taucherhelm";
					}
					case 269:
					{
						return "Vertrautes Hemd";
					}
					case 270:
					{
						return "Vertraute Hosen";
					}
					case 271:
					{
						return "Vertraute Frisur";
					}
					case 272:
					{
						return "Daemonensense";
					}
					case 273:
					{
						return "Klinge der Nacht";
					}
					case 274:
					{
						return "Dunkle Lanze";
					}
					case 275:
					{
						return "Koralle";
					}
					case 276:
					{
						return "Kaktus";
					}
					case 277:
					{
						return "Dreizack";
					}
					case 278:
					{
						return "Silberkugel";
					}
					case 279:
					{
						return "Wurfmesser";
					}
					case 280:
					{
						return "Speer";
					}
					case 281:
					{
						return "Blasrohr";
					}
					case 282:
					{
						return "Leuchtstab";
					}
					case 283:
					{
						return "Saat";
					}
					case 284:
					{
						return "Holzbumerang";
					}
					case 285:
					{
						return "Schnuersenkelkappe";
					}
					case 286:
					{
						return "Klebriger Leuchtstab";
					}
					case 287:
					{
						return "Giftmesser";
					}
					case 288:
					{
						return "Obsidianhaut-Trank";
					}
					case 289:
					{
						return "Wiederbelebungstrank";
					}
					case 290:
					{
						return "Flinkheitstrank";
					}
					case 291:
					{
						return "Kiementrank";
					}
					case 292:
					{
						return "Eisenhaut-Trank";
					}
					case 293:
					{
						return "Mana-Wiederherstellungstrank";
					}
					case 294:
					{
						return "Magiekraft-Trank";
					}
					case 295:
					{
						return "Federsturz-Trank";
					}
					case 296:
					{
						return "Hoehlenforschertrank";
					}
					case 297:
					{
						return "Unsichtbarkeitstrank";
					}
					case 298:
					{
						return "Strahlentrank";
					}
					case 299:
					{
						return "Nachteulentrank";
					}
					case 300:
					{
						return "Kampftrank";
					}
					case 301:
					{
						return "Dornentrank";
					}
					case 302:
					{
						return "Wasserlauftrank";
					}
					case 303:
					{
						return "Bogenschiessrank";
					}
					case 304:
					{
						return "Jaegertrank";
					}
					case 305:
					{
						return "Gravitationstrank";
					}
					case 306:
					{
						return "Goldtruhe";
					}
					case 307:
					{
						return "Tagesblumensaat";
					}
					case 308:
					{
						return "Mondscheinsaat";
					}
					case 309:
					{
						return "Leuchtwurzel-Saat";
					}
					case 310:
					{
						return "Todeskraut-Saat";
					}
					case 311:
					{
						return "Wasserblatt-Saat";
					}
					case 312:
					{
						return "Feuerblueten-Saat";
					}
					case 313:
					{
						return "Tagesblume";
					}
					case 314:
					{
						return "Mondglanz";
					}
					case 315:
					{
						return "Leuchtwurzel";
					}
					case 316:
					{
						return "Todeskraut";
					}
					case 317:
					{
						return "Wasserblatt";
					}
					case 318:
					{
						return "Feuerbluete";
					}
					case 319:
					{
						return "Haifinne";
					}
					case 320:
					{
						return "Feder";
					}
					case 321:
					{
						return "Grabstein";
					}
					case 322:
					{
						return "Imitatormaske";
					}
					case 323:
					{
						return "Ameisenloewenkiefer";
					}
					case 324:
					{
						return "Illegale Gewehrteile";
					}
					case 325:
					{
						return "Hemd des Arztes";
					}
					case 326:
					{
						return "Hosen des Arztes";
					}
					case 327:
					{
						return "Goldener Schluessel";
					}
					case 328:
					{
						return "Schattentruhe";
					}
					case 329:
					{
						return "Schattenschluessel";
					}
					case 330:
					{
						return "Obsidianziegelwand";
					}
					case 331:
					{
						return "Dschungelsporen";
					}
					case 332:
					{
						return "Webstuhl";
					}
					case 333:
					{
						return "Piano";
					}
					case 334:
					{
						return "Kommode";
					}
					case 335:
					{
						return "Sitzbank";
					}
					case 336:
					{
						return "Badewanne";
					}
					case 337:
					{
						return "Rotes Dekoband";
					}
					case 338:
					{
						return "Gruenes Dekoband";
					}
					case 339:
					{
						return "Blaues Dekoband";
					}
					case 340:
					{
						return "Gelbes Dekoband";
					}
					case 341:
					{
						return "Laternenpfahl";
					}
					case 342:
					{
						return "Petroleumfackel";
					}
					case 343:
					{
						return "Fass";
					}
					case 344:
					{
						return "Chinesische Laterne";
					}
					case 345:
					{
						return "Kochtopf";
					}
					case 346:
					{
						return "Tresor";
					}
					case 347:
					{
						return "Schaedellaterne";
					}
					case 348:
					{
						return "Muelleimer";
					}
					case 349:
					{
						return "Kandelaber";
					}
					case 350:
					{
						return "Rosa Vase";
					}
					case 351:
					{
						return "Masskrug";
					}
					case 352:
					{
						return "Gaerbottich";
					}
					case 353:
					{
						return "Bier";
					}
					case 354:
					{
						return "Buecherregal";
					}
					case 355:
					{
						return "Thron";
					}
					case 356:
					{
						return "Schuessel";
					}
					case 357:
					{
						return "Schuessel mit Suppe";
					}
					case 358:
					{
						return "Toilette";
					}
					case 359:
					{
						return "Standuhr";
					}
					case 360:
					{
						return "Ruestungsstatue";
					}
					case 361:
					{
						return "Goblin-Kampfstandarte";
					}
					case 362:
					{
						return "Zerfetzter Stoff";
					}
					case 363:
					{
						return "Saegewerk";
					}
					case 364:
					{
						return "Kobalterz";
					}
					case 365:
					{
						return "Mithrilerz";
					}
					case 366:
					{
						return "Adamantiterz";
					}
					case 367:
					{
						return "Pwnhammer";
					}
					case 368:
					{
						return "Excalibur";
					}
					case 369:
					{
						return "Gesegnete Saat";
					}
					case 370:
					{
						return "Ebensandblock";
					}
					case 371:
					{
						return "Kobalthut";
					}
					case 372:
					{
						return "Kobalthelm";
					}
					case 373:
					{
						return "Kobalt-Maske";
					}
					case 374:
					{
						return "Kobalt-Brustplatte";
					}
					case 375:
					{
						return "Kobalt-Gamaschen";
					}
					case 376:
					{
						return "Mithril-Kapuze";
					}
					case 377:
					{
						return "Mithril-Helm";
					}
					case 378:
					{
						return "Mithrilhut";
					}
					case 379:
					{
						return "Mithril-Kettenhemd";
					}
					case 380:
					{
						return "Mithril-Beinschuetzer";
					}
					case 381:
					{
						return "Kobaltbarren";
					}
					case 382:
					{
						return "Mithrilbarren";
					}
					case 383:
					{
						return "Kobalt-Kettensaege";
					}
					case 384:
					{
						return "Mithril-Kettensaege";
					}
					case 385:
					{
						return "Kobaltbohrer";
					}
					case 386:
					{
						return "Mithrilbohrer";
					}
					case 387:
					{
						return "Adamantit-Kettensaege";
					}
					case 388:
					{
						return "Adamantitbohrer";
					}
					case 389:
					{
						return "Dao von Pow";
					}
					case 390:
					{
						return "Mithril-Hellebarde";
					}
					case 391:
					{
						return "Adamantitbarren";
					}
					case 392:
					{
						return "Glaswand";
					}
					case 393:
					{
						return "Kompass";
					}
					case 394:
					{
						return "Tauchausruestung";
					}
					case 395:
					{
						return "GPS";
					}
					case 396:
					{
						return "Obsidian-Hufeisen";
					}
					case 397:
					{
						return "Obsidianschild";
					}
					case 398:
					{
						return "Tueftler-Werkstatt";
					}
					case 399:
					{
						return "Wolke in einem Ballon";
					}
					case 400:
					{
						return "Adamantitkopfschutz";
					}
					case 401:
					{
						return "Adamantithelm";
					}
					case 402:
					{
						return "Adamantitmaske";
					}
					case 403:
					{
						return "Adamantitbrustplatte";
					}
					case 404:
					{
						return "Adamantitgamaschen";
					}
					case 405:
					{
						return "Geisterstiefel";
					}
					case 406:
					{
						return "Adamantitgleve";
					}
					case 407:
					{
						return "Werkzeugguertel";
					}
					case 408:
					{
						return "Perlsandblock";
					}
					case 409:
					{
						return "Perlsteinblock";
					}
					case 410:
					{
						return "Bergbauhemd";
					}
					case 411:
					{
						return "Bergbauhosen";
					}
					case 412:
					{
						return "Perlsteinziegel";
					}
					case 413:
					{
						return "Schillernder Ziegel";
					}
					case 414:
					{
						return "Schlammsteinblock";
					}
					case 415:
					{
						return "Kobaltziegel";
					}
					case 416:
					{
						return "Mithrilziegel";
					}
					case 417:
					{
						return "Perlsteinziegelwand";
					}
					case 418:
					{
						return "Schillernde Ziegelwand";
					}
					case 419:
					{
						return "Schlammsteinziegelwand";
					}
					case 420:
					{
						return "Kobaltziegelwand";
					}
					case 421:
					{
						return "Mithrilziegelwand";
					}
					case 422:
					{
						return "Heiliges Wasser";
					}
					case 423:
					{
						return "Unheiliges Wasser";
					}
					case 424:
					{
						return "Schlickblock";
					}
					case 425:
					{
						return "Feenglocke";
					}
					case 426:
					{
						return "Schmetterklinge";
					}
					case 427:
					{
						return "Blaue Fackel";
					}
					case 428:
					{
						return "Rote Fackel";
					}
					case 429:
					{
						return "Gruene Fackel";
					}
					case 430:
					{
						return "Lila Fackel";
					}
					case 431:
					{
						return "Weisse Fackel";
					}
					case 432:
					{
						return "Gelbe Fackel";
					}
					case 433:
					{
						return "Daemonenfackel";
					}
					case 434:
					{
						return "Automatiksturmwaffe";
					}
					case 435:
					{
						return "Kobaltrepetierer";
					}
					case 436:
					{
						return "Mithrilrepetierer";
					}
					case 437:
					{
						return "Dual-Haken";
					}
					case 438:
					{
						return "Sternstatue";
					}
					case 439:
					{
						return "Schwertstatue";
					}
					case 440:
					{
						return "Schleimistatue";
					}
					case 441:
					{
						return "Goblinstatue";
					}
					case 442:
					{
						return "Schildstatue";
					}
					case 443:
					{
						return "Fledermausstatue";
					}
					case 444:
					{
						return "Fischstatue";
					}
					case 445:
					{
						return "Haeschenstatue";
					}
					case 446:
					{
						return "Skelettstatue";
					}
					case 447:
					{
						return "Sensenmannstatue";
					}
					case 448:
					{
						return "Frauenstatue";
					}
					case 449:
					{
						return "Impstatue";
					}
					case 450:
					{
						return "Wasserspeier-Statue";
					}
					case 451:
					{
						return "Vanitasstatue";
					}
					case 452:
					{
						return "Hornissenstatue";
					}
					case 453:
					{
						return "Bombenstatue";
					}
					case 454:
					{
						return "Krabbenstatue";
					}
					case 455:
					{
						return "Hammerstatue";
					}
					case 456:
					{
						return "Trankstatue";
					}
					case 457:
					{
						return "Speerstatue";
					}
					case 458:
					{
						return "Kreuzstatue";
					}
					case 459:
					{
						return "Quallenstatue";
					}
					case 460:
					{
						return "Bogenstatue";
					}
					case 461:
					{
						return "Bumerangstatue";
					}
					case 462:
					{
						return "Stiefelstatue";
					}
					case 463:
					{
						return "Truhenstatue";
					}
					case 464:
					{
						return "Vogelstatue";
					}
					case 465:
					{
						return "Axtstatue";
					}
					case 466:
					{
						return "Verderbnisstatue";
					}
					case 467:
					{
						return "Baumstatue";
					}
					case 468:
					{
						return "Amboss-Statue";
					}
					case 469:
					{
						return "Spitzhackenstatue";
					}
					case 470:
					{
						return "Pilzstatue";
					}
					case 471:
					{
						return "Augapfelstatue";
					}
					case 472:
					{
						return "Saeulenstatue";
					}
					case 473:
					{
						return "Herzstatue";
					}
					case 474:
					{
						return "Topfstatue";
					}
					case 475:
					{
						return "Sonnenblumenstatue";
					}
					case 476:
					{
						return "Koenigstatue";
					}
					case 477:
					{
						return "Koeniginstatue";
					}
					case 478:
					{
						return "Pirahnastatue";
					}
					case 479:
					{
						return "Plankenwand";
					}
					case 480:
					{
						return "Holzbalken";
					}
					case 481:
					{
						return "Adamantitrepetierer";
					}
					case 482:
					{
						return "Adamantitschwert";
					}
					case 483:
					{
						return "Kobaltschwert";
					}
					case 484:
					{
						return "Mithrilschwert";
					}
					case 485:
					{
						return "Mondzauber";
					}
					case 486:
					{
						return "Massgitter";
					}
					case 487:
					{
						return "Kristallkugel";
					}
					case 488:
					{
						return "Diskokugel";
					}
					case 489:
					{
						return "Hexeremblem";
					}
					case 490:
					{
						return "Kriegeremblem";
					}
					case 491:
					{
						return "Waldlaeufer-Emblem";
					}
					case 492:
					{
						return "Daemonenfluegel";
					}
					case 493:
					{
						return "Engelsfluegel";
					}
					case 494:
					{
						return "Magische Harfe";
					}
					case 495:
					{
						return "Regenbogenrute";
					}
					case 496:
					{
						return "Eisrute";
					}
					case 497:
					{
						return "Neptuns Muschel";
					}
					case 498:
					{
						return "Mannequin";
					}
					case 499:
					{
						return "Grosser Heiltrank";
					}
					case 500:
					{
						return "Grosser Manatrank";
					}
					case 501:
					{
						return "Pixie-Staub";
					}
					case 502:
					{
						return "Kristallscherbe";
					}
					case 503:
					{
						return "Clownshut";
					}
					case 504:
					{
						return "Clownshemd";
					}
					case 505:
					{
						return "Clownshosen";
					}
					case 506:
					{
						return "Flammenwerfer";
					}
					case 507:
					{
						return "Glocke";
					}
					case 508:
					{
						return "Harfe";
					}
					case 509:
					{
						return "Schraubenschluessel";
					}
					case 510:
					{
						return "Kabelcutter";
					}
					case 511:
					{
						return "Aktiver Steinblock";
					}
					case 512:
					{
						return "Inaktiver Steinblock";
					}
					case 513:
					{
						return "Hebel";
					}
					case 514:
					{
						return "Lasergewehr";
					}
					case 515:
					{
						return "Kristallgeschoss";
					}
					case 516:
					{
						return "Heiliger Pfeil";
					}
					case 517:
					{
						return "Magischer Dolch";
					}
					case 518:
					{
						return "Kristallsturm";
					}
					case 519:
					{
						return "Verfluchte Flammen";
					}
					case 520:
					{
						return "Seele des Lichts";
					}
					case 521:
					{
						return "Seele der Nacht";
					}
					case 522:
					{
						return "Verfluchte Flamme";
					}
					case 523:
					{
						return "Verfluchte Fackel";
					}
					case 524:
					{
						return "Adamantitschmiede";
					}
					case 525:
					{
						return "Mithrilamboss";
					}
					case 526:
					{
						return "Horn des Einhorns";
					}
					case 527:
					{
						return "Dunkle Scherbe";
					}
					case 528:
					{
						return "Lichtscherbe";
					}
					case 529:
					{
						return "Rote Druckplatte";
					}
					case 530:
					{
						return "Kabel";
					}
					case 531:
					{
						return "Buch der Flueche";
					}
					case 532:
					{
						return "Sternenumhang";
					}
					case 533:
					{
						return "Maxihai";
					}
					case 534:
					{
						return "Schrotflinte";
					}
					case 535:
					{
						return "Stein der Weisen";
					}
					case 536:
					{
						return "Titanhandschuh";
					}
					case 537:
					{
						return "Kobalt-Naginata";
					}
					case 538:
					{
						return "Schalter";
					}
					case 539:
					{
						return "Pfeilfalle";
					}
					case 540:
					{
						return "Felsbrocken";
					}
					case 541:
					{
						return "Gruene Druckplatte";
					}
					case 542:
					{
						return "Graue Druckplatte";
					}
					case 543:
					{
						return "Braune Druckplatte";
					}
					case 544:
					{
						return "Mechanisches Auge";
					}
					case 545:
					{
						return "Verfluchter Pfeil";
					}
					case 546:
					{
						return "Verfluchte Kugel";
					}
					case 547:
					{
						return "Seele des Schreckens";
					}
					case 548:
					{
						return "Seele der Macht";
					}
					case 549:
					{
						return "Seele der Einsicht";
					}
					case 550:
					{
						return "Gungnir";
					}
					case 551:
					{
						return "Gesegneter Plattenpanzer";
					}
					case 552:
					{
						return "Geheiligte Beinschuetzer";
					}
					case 553:
					{
						return "Gesegneter Helm";
					}
					case 554:
					{
						return "Kreuzhalskette";
					}
					case 555:
					{
						return "Mana-Blume";
					}
					case 556:
					{
						return "Mechanischer Wurm";
					}
					case 557:
					{
						return "Mechanischer Schaedel";
					}
					case 558:
					{
						return "Gesegneter Kopfschutz";
					}
					case 559:
					{
						return "Gesegnete Maske";
					}
					case 560:
					{
						return "Schleimikrone";
					}
					case 561:
					{
						return "Lichtscheibe";
					}
					case 562:
					{
						return "Musikbox (Tag auf der Oberwelt)";
					}
					case 563:
					{
						return "Musikbox (Gespenstisch)";
					}
					case 564:
					{
						return "Musikbox (Nacht)";
					}
					case 565:
					{
						return "Musikbox (Titel)";
					}
					case 566:
					{
						return "Musikbox (Unterirdisch)";
					}
					case 567:
					{
						return "Musikbox (Boss 1)";
					}
					case 568:
					{
						return "Musikbox (Dschungel)";
					}
					case 569:
					{
						return "Musikbox (Verderben)";
					}
					case 570:
					{
						return "Musikbox(Unterirdisches Verderben)";
					}
					case 571:
					{
						return "Musikbox (Das Gesegnete)";
					}
					case 572:
					{
						return "Musikbox (Boss 2)";
					}
					case 573:
					{
						return "Musikbox (Unterirdisches Gesegnetes)";
					}
					case 574:
					{
						return "Musikbox (Boss 3)";
					}
					case 575:
					{
						return "Seele des Flugs";
					}
					case 576:
					{
						return "Musikbox";
					}
					case 577:
					{
						return "Daemonitziegel";
					}
					case 578:
					{
						return "Gesegneter Repetierer";
					}
					case 579:
					{
						return "Drax";
					}
					case 580:
					{
						return "Explosiva";
					}
					case 581:
					{
						return "Einlasspumpe";
					}
					case 582:
					{
						return "Auslasspumpe";
					}
					case 583:
					{
						return "1-Sekunden-Timer";
					}
					case 584:
					{
						return "3-Sekunden-Timer";
					}
					case 585:
					{
						return "5-Sekunden-Timer";
					}
					case 586:
					{
						return "Candy Cane-Block";
					}
					case 587:
					{
						return "Candy Cane Wand";
					}
					case 588:
					{
						return "Weihnachtsmütze";
					}
					case 589:
					{
						return "Santa Shirt";
					}
					case 590:
					{
						return "von Santa Pants";
					}
					case 591:
					{
						return "Grüne Candy Cane-Block";
					}
					case 592:
					{
						return "Grüne Candy Cane Wand";
					}
					case 593:
					{
						return "Schnee-Block";
					}
					case 594:
					{
						return "Schnee Brick";
					}
					case 595:
					{
						return "Schnee Brick Wall";
					}
					case 596:
					{
						return "Blue Light";
					}
					case 597:
					{
						return "Rotlicht";
					}
					case 598:
					{
						return "Green Light";
					}
					case 599:
					{
						return "blaue Gegenwart";
					}
					case 600:
					{
						return "grüne Gegenwart";
					}
					case 601:
					{
						return "Yellow Gegenwart";
					}
					case 602:
					{
						return "Snow Globe";
					}
					case 603:
					{
						return "Karotte";
					}
					default:
					{
						switch (num)
						{
							case 3480:
							{
								return "Platinum Bow";
							}
							case 3481:
							{
								return "Platinum Hammer";
							}
							case 3482:
							{
								return "Platinum Axe";
							}
							case 3483:
							{
								return "Platinum Shortsword";
							}
							case 3484:
							{
								return "Platinum Broadsword";
							}
							case 3485:
							{
								return "Platinum Pickaxe";
							}
							case 3486:
							{
								return "Tungsten Bow";
							}
							case 3487:
							{
								return "Tungsten Hammer";
							}
							case 3488:
							{
								return "Tungsten Axe";
							}
							case 3489:
							{
								return "Tungsten Shortsword";
							}
							case 3490:
							{
								return "Tungsten Broadsword";
							}
							case 3491:
							{
								return "Tungsten Pickaxe";
							}
							case 3492:
							{
								return "Lead Bow";
							}
							case 3493:
							{
								return "Lead Hammer";
							}
							case 3494:
							{
								return "Lead Axe";
							}
							case 3495:
							{
								return "Lead Shortsword";
							}
							case 3496:
							{
								return "Lead Broadsword";
							}
							case 3497:
							{
								return "Lead Pickaxe";
							}
							case 3498:
							{
								return "Tin Bow";
							}
							case 3499:
							{
								return "Tin Hammer";
							}
							case 3500:
							{
								return "Tin Axe";
							}
							case 3501:
							{
								return "Tin Shortsword";
							}
							case 3502:
							{
								return "Tin Broadsword";
							}
							case 3503:
							{
								return "Tin Pickaxe";
							}
							case 3504:
							{
								return "Kupferbogen";
							}
							case 3505:
							{
								return "Kupferhammer";
							}
							case 3506:
							{
								return "Kupferaxt";
							}
							case 3507:
							{
								return "Kupferkurzschwert";
							}
							case 3508:
							{
								return "Kupferbreitschwert";
							}
							case 3509:
							{
								return "Kupferspitzhacke";
							}
							case 3510:
							{
								return "Silberbogen";
							}
							case 3511:
							{
								return "Silberhammer";
							}
							case 3512:
							{
								return "Silberaxt";
							}
							case 3513:
							{
								return "Silberkurzschwert";
							}
							case 3514:
							{
								return "Silberbreitschwert";
							}
							case 3515:
							{
								return "Silberspitzhacke";
							}
							case 3516:
							{
								return "Goldbogen";
							}
							case 3517:
							{
								return "Goldhammer";
							}
							case 3518:
							{
								return "Goldaxt";
							}
							case 3519:
							{
								return "Goldkurzschwert";
							}
							case 3520:
							{
								return "Goldbreitschwert";
							}
							case 3521:
							{
								return "Goldspitzhacke";
							}
						}
						break;
					}
				}
			}
			else if (Lang.lang == 3)
			{
				int num1 = l;
				switch (num1)
				{
					case -24:
					{
						return "Spada laser gialla";
					}
					case -23:
					{
						return "Spada laser bianca";
					}
					case -22:
					{
						return "Spada laser viola";
					}
					case -21:
					{
						return "Spada laser verde";
					}
					case -20:
					{
						return "Spada laser rossa";
					}
					case -19:
					{
						return "Spada laser blu";
					}
					case -18:
					{
						return "Arco di rame";
					}
					case -17:
					{
						return "Martello di rame";
					}
					case -16:
					{
						return "Ascia di rame";
					}
					case -15:
					{
						return "Spada corta di rame";
					}
					case -14:
					{
						return "Spadone di rame";
					}
					case -13:
					{
						return "Piccone di rame";
					}
					case -12:
					{
						return "Arco d'argento";
					}
					case -11:
					{
						return "Martello d'argento";
					}
					case -10:
					{
						return "Ascia d'argento";
					}
					case -9:
					{
						return "Spada corta d'argento";
					}
					case -8:
					{
						return "Spadone d'argento";
					}
					case -7:
					{
						return "Piccone d'argento";
					}
					case -6:
					{
						return "Arco d'oro";
					}
					case -5:
					{
						return "Martello d'oro";
					}
					case -4:
					{
						return "Ascia d'oro";
					}
					case -3:
					{
						return "Spada corta d'oro";
					}
					case -2:
					{
						return "Spadone d'oro";
					}
					case -1:
					{
						return "Piccone d'oro";
					}
					case 0:
					{
						break;
					}
					case 1:
					{
						return "Piccone di ferro";
					}
					case 2:
					{
						return "Blocco di terra";
					}
					case 3:
					{
						return "Blocco di pietra";
					}
					case 4:
					{
						return "Spadone di ferro";
					}
					case 5:
					{
						return "Fungo";
					}
					case 6:
					{
						return "Spada corta di ferro";
					}
					case 7:
					{
						return "Martello di ferro";
					}
					case 8:
					{
						return "Fiaccola";
					}
					case 9:
					{
						return "Legno";
					}
					case 10:
					{
						return "Ascia di ferro";
					}
					case 11:
					{
						return "Minerale di ferro";
					}
					case 12:
					{
						return "Minerale di rame";
					}
					case 13:
					{
						return "Minerale d'oro";
					}
					case 14:
					{
						return "Minerale d'argento";
					}
					case 15:
					{
						return "Orologio di rame";
					}
					case 16:
					{
						return "Orologio d'argento";
					}
					case 17:
					{
						return "Orologio d'oro";
					}
					case 18:
					{
						return "Misuratore di profondità";
					}
					case 19:
					{
						return "Sbarra d'oro";
					}
					case 20:
					{
						return "Sbarra di rame";
					}
					case 21:
					{
						return "Sbarra d'argento";
					}
					case 22:
					{
						return "Sbarra di ferro";
					}
					case 23:
					{
						return "Gel";
					}
					case 24:
					{
						return "Spada di legno";
					}
					case 25:
					{
						return "Porta di legno";
					}
					case 26:
					{
						return "Muro di pietra";
					}
					case 27:
					{
						return "Ghianda";
					}
					case 28:
					{
						return "Pozione curativa inferiore";
					}
					case 29:
					{
						return "Cristallo di vita";
					}
					case 30:
					{
						return "Muro di terra";
					}
					case 31:
					{
						return "Bottiglia";
					}
					case 32:
					{
						return "Tavolo di legno";
					}
					case 33:
					{
						return "Forno";
					}
					case 34:
					{
						return "Sedia di legno";
					}
					case 35:
					{
						return "Incudine di ferro";
					}
					case 36:
					{
						return "Banco di lavoro";
					}
					case 37:
					{
						return "Occhiali protettivi";
					}
					case 38:
					{
						return "Lenti";
					}
					case 39:
					{
						return "Arco di legno";
					}
					case 40:
					{
						return "Freccia di legno";
					}
					case 41:
					{
						return "Freccia infuocata";
					}
					case 42:
					{
						return "Shuriken";
					}
					case 43:
					{
						return "Occhio diffidente";
					}
					case 44:
					{
						return "Arco demoniaco";
					}
					case 45:
					{
						return "Ascia da guerra della notte";
					}
					case 46:
					{
						return "Flagello di luce";
					}
					case 47:
					{
						return "Freccia empia";
					}
					case 48:
					{
						return "Cassa";
					}
					case 49:
					{
						return "Benda di rigenerazione";
					}
					case 50:
					{
						return "Specchio magico";
					}
					case 51:
					{
						return "Freccia del giullare";
					}
					case 52:
					{
						return "Statua dell'angelo";
					}
					case 53:
					{
						return "Nuvola in bottiglia";
					}
					case 54:
					{
						return "Stivali di Ermes";
					}
					case 55:
					{
						return "Boomerang incantato";
					}
					case 56:
					{
						return "Minerale demoniaco";
					}
					case 57:
					{
						return "Sbarra demoniaca";
					}
					case 58:
					{
						return "Cuore";
					}
					case 59:
					{
						return "Semi distrutti";
					}
					case 60:
					{
						return "Fungo disgustoso";
					}
					case 61:
					{
						return "Blocco pietra d'ebano";
					}
					case 62:
					{
						return "Semi d'erba";
					}
					case 63:
					{
						return "Girasole";
					}
					case 64:
					{
						return "Spina vile";
					}
					case 65:
					{
						return "Furia stellare";
					}
					case 66:
					{
						return "Polvere purificatrice";
					}
					case 67:
					{
						return "Polvere disgustosa";
					}
					case 68:
					{
						return "Ceppo marcio";
					}
					case 69:
					{
						return "Dente di verme";
					}
					case 70:
					{
						return "Esca di verme";
					}
					case 71:
					{
						return "Moneta di rame";
					}
					case 72:
					{
						return "Moneta d'argento";
					}
					case 73:
					{
						return "Moneta d'oro";
					}
					case 74:
					{
						return "Moneta di platino";
					}
					case 75:
					{
						return "Stella cadente";
					}
					case 76:
					{
						return "Gambali di rame";
					}
					case 77:
					{
						return "Gambali di ferro";
					}
					case 78:
					{
						return "Gambali d'argento";
					}
					case 79:
					{
						return "Gambali d'oro";
					}
					case 80:
					{
						return "Maglia metallica di rame";
					}
					case 81:
					{
						return "Maglia metallica di ferro";
					}
					case 82:
					{
						return "Maglia metallica d'argento";
					}
					case 83:
					{
						return "Maglia metallica d'oro";
					}
					case 84:
					{
						return "Rampino";
					}
					case 85:
					{
						return "Catena di ferro";
					}
					case 86:
					{
						return "Scaglia d'ombra";
					}
					case 87:
					{
						return "Salvadanaio";
					}
					case 88:
					{
						return "Casco da minatore";
					}
					case 89:
					{
						return "Casco di rame";
					}
					case 90:
					{
						return "Casco di ferro";
					}
					case 91:
					{
						return "Casco d'argento";
					}
					case 92:
					{
						return "Casco d'oro";
					}
					case 93:
					{
						return "Muro di legno";
					}
					case 94:
					{
						return "Piattaforma di legno";
					}
					case 95:
					{
						return "Pistola a pietra focaia";
					}
					case 96:
					{
						return "Moschetto";
					}
					case 97:
					{
						return "Palla di moschetto";
					}
					case 98:
					{
						return "Minishark";
					}
					case 99:
					{
						return "Arco di ferro";
					}
					case 100:
					{
						return "Gambali ombra";
					}
					case 101:
					{
						return "Armatura a scaglie ombra";
					}
					case 102:
					{
						return "Casco ombra";
					}
					case 103:
					{
						return "Piccone dell'incubo";
					}
					case 104:
					{
						return "Il Distruttore";
					}
					case 105:
					{
						return "Candela";
					}
					case 106:
					{
						return "Lampadario di rame";
					}
					case 107:
					{
						return "Lampadario d'argento";
					}
					case 108:
					{
						return "Lampadario d'oro";
					}
					case 109:
					{
						return "Cristallo mana";
					}
					case 110:
					{
						return "Pozione mana inferiore";
					}
					case 111:
					{
						return "Benda della forza stellare";
					}
					case 112:
					{
						return "Fiore di fuoco";
					}
					case 113:
					{
						return "Missile magico";
					}
					case 114:
					{
						return "Bastone di terra";
					}
					case 115:
					{
						return "Orbita di luce";
					}
					case 116:
					{
						return "Meteorite";
					}
					case 117:
					{
						return "Sbarra di meteorite";
					}
					case 118:
					{
						return "Uncino";
					}
					case 119:
					{
						return "Flamarang";
					}
					case 120:
					{
						return "Furia fusa";
					}
					case 121:
					{
						return "Spadone di fuoco";
					}
					case 122:
					{
						return "Piccone fuso";
					}
					case 123:
					{
						return "Casco meteorite";
					}
					case 124:
					{
						return "Tunica di meteorite";
					}
					case 125:
					{
						return "Meteora pantaloni";
					}
					case 126:
					{
						return "Acqua imbottigliata";
					}
					case 127:
					{
						return "Spazio pistola";
					}
					case 128:
					{
						return "Stivali razzo";
					}
					case 129:
					{
						return "Mattone grigio";
					}
					case 130:
					{
						return "Muro grigio";
					}
					case 131:
					{
						return "Mattone rosso";
					}
					case 132:
					{
						return "Muro rosso";
					}
					case 133:
					{
						return "Blocco d'argilla";
					}
					case 134:
					{
						return "Mattone blu";
					}
					case 135:
					{
						return "Muro blu";
					}
					case 136:
					{
						return "Lanterna con catena";
					}
					case 137:
					{
						return "Mattone verde";
					}
					case 138:
					{
						return "Muro verde";
					}
					case 139:
					{
						return "Mattone rosa";
					}
					case 140:
					{
						return "Muro rosa";
					}
					case 141:
					{
						return "Mattone dorato";
					}
					case 142:
					{
						return "Muro dorato";
					}
					case 143:
					{
						return "Mattone argentato";
					}
					case 144:
					{
						return "Muro argentato";
					}
					case 145:
					{
						return "Mattone di rame";
					}
					case 146:
					{
						return "Muro di rame";
					}
					case 147:
					{
						return "Spina";
					}
					case 148:
					{
						return "Candela d'acqua";
					}
					case 149:
					{
						return "Libro";
					}
					case 150:
					{
						return "Ragnatela";
					}
					case 151:
					{
						return "Casco funebre";
					}
					case 152:
					{
						return "Pettorale funebre";
					}
					case 153:
					{
						return "Gambali funebri";
					}
					case 154:
					{
						return "Osso";
					}
					case 155:
					{
						return "Muramasa";
					}
					case 156:
					{
						return "Scudo di cobalto";
					}
					case 157:
					{
						return "Scettro d'acqua";
					}
					case 158:
					{
						return "Ferro di cavallo fortunato";
					}
					case 159:
					{
						return "Palloncino rosso splendente";
					}
					case 160:
					{
						return "Arpione";
					}
					case 161:
					{
						return "Palla chiodata";
					}
					case 162:
					{
						return "Palla del dolore";
					}
					case 163:
					{
						return "Luna blu";
					}
					case 164:
					{
						return "Pistola";
					}
					case 165:
					{
						return "Dardo d'acqua";
					}
					case 166:
					{
						return "Bomba";
					}
					case 167:
					{
						return "Dinamite";
					}
					case 168:
					{
						return "Granata";
					}
					case 169:
					{
						return "Blocco di sabbia";
					}
					case 170:
					{
						return "Vetro";
					}
					case 171:
					{
						return "Cartello";
					}
					case 172:
					{
						return "Blocco di cenere";
					}
					case 173:
					{
						return "Ossidiana";
					}
					case 174:
					{
						return "Pietra infernale";
					}
					case 175:
					{
						return "Sbarra di pietra infernale";
					}
					case 176:
					{
						return "Blocco di fango";
					}
					case 177:
					{
						return "Zaffiro";
					}
					case 178:
					{
						return "Rubino";
					}
					case 179:
					{
						return "Smeraldo";
					}
					case 180:
					{
						return "Topazio";
					}
					case 181:
					{
						return "Ametista";
					}
					case 182:
					{
						return "Diamante";
					}
					case 183:
					{
						return "Fungo luminoso";
					}
					case 184:
					{
						return "Stella";
					}
					case 185:
					{
						return "Frusta di edera";
					}
					case 186:
					{
						return "Canna per la respirazione";
					}
					case 187:
					{
						return "Pinna";
					}
					case 188:
					{
						return "Pozione curativa";
					}
					case 189:
					{
						return "Pozione mana";
					}
					case 190:
					{
						return "Spada di erba";
					}
					case 191:
					{
						return "Artiglio di Chakram";
					}
					case 192:
					{
						return "Mattone di ossidiana";
					}
					case 193:
					{
						return "Teschio di ossidiana";
					}
					case 194:
					{
						return "Semi di fungo";
					}
					case 195:
					{
						return "Semi dell'erba della giungla";
					}
					case 196:
					{
						return "Martello di legno";
					}
					case 197:
					{
						return "Cannone stellare";
					}
					case 198:
					{
						return "Spada laser blu";
					}
					case 199:
					{
						return "Spada laser rossa";
					}
					case 200:
					{
						return "Spada laser verde";
					}
					case 201:
					{
						return "Spada laser viola";
					}
					case 202:
					{
						return "Spada laser bianca";
					}
					case 203:
					{
						return "Spada laser gialla";
					}
					case 204:
					{
						return "Maglio di meteorite";
					}
					case 205:
					{
						return "Secchio vuoto";
					}
					case 206:
					{
						return "Secchio d'acqua";
					}
					case 207:
					{
						return "Secchio di lava";
					}
					case 208:
					{
						return "Rosa della giungla";
					}
					case 209:
					{
						return "Artiglio";
					}
					case 210:
					{
						return "Vite";
					}
					case 211:
					{
						return "Artigli bestiali";
					}
					case 212:
					{
						return "Cavigliera del vento";
					}
					case 213:
					{
						return "Bastone della ricrescita";
					}
					case 214:
					{
						return "Mattone di pietra infernale";
					}
					case 215:
					{
						return "Cuscino rumoroso";
					}
					case 216:
					{
						return "Grillo";
					}
					case 217:
					{
						return "Maglio fuso";
					}
					case 218:
					{
						return "Lanciatore di fiamma";
					}
					case 219:
					{
						return "Blaster della fenice";
					}
					case 220:
					{
						return "Furia del sole";
					}
					case 221:
					{
						return "Creazione degli inferi";
					}
					case 222:
					{
						return "Vaso di argilla";
					}
					case 223:
					{
						return "Dono della natura";
					}
					case 224:
					{
						return "Letto";
					}
					case 225:
					{
						return "Seta";
					}
					case 226:
					{
						return "Pozione di ripristino inferiore";
					}
					case 227:
					{
						return "Pozione di ripristino";
					}
					case 228:
					{
						return "Cappello della giungla";
					}
					case 229:
					{
						return "Camicia della giungla";
					}
					case 230:
					{
						return "Pantaloni della giungla";
					}
					case 231:
					{
						return "Casco fuso";
					}
					case 232:
					{
						return "Pettorale fuso";
					}
					case 233:
					{
						return "Gambali fusi";
					}
					case 234:
					{
						return "Sparo di meteorite";
					}
					case 235:
					{
						return "Bomba appiccicosa";
					}
					case 236:
					{
						return "Lenti nere";
					}
					case 237:
					{
						return "Occhiali da sole";
					}
					case 238:
					{
						return "Cappello dello stregone";
					}
					case 239:
					{
						return "Cilindro";
					}
					case 240:
					{
						return "Camicia da smoking";
					}
					case 241:
					{
						return "Pantaloni smoking";
					}
					case 242:
					{
						return "Cappello estivo";
					}
					case 243:
					{
						return "Cappuccio da coniglio";
					}
					case 244:
					{
						return "Cappello da idraulico";
					}
					case 245:
					{
						return "Camicia da idraulico";
					}
					case 246:
					{
						return "Pantaloni da idraulico";
					}
					case 247:
					{
						return "Cappello da eroe";
					}
					case 248:
					{
						return "Camicia da eroe";
					}
					case 249:
					{
						return "Pantaloni da eroe";
					}
					case 250:
					{
						return "Boccia dei pesci rossi";
					}
					case 251:
					{
						return "Cappello da archeologo";
					}
					case 252:
					{
						return "Giacca da archeologo";
					}
					case 253:
					{
						return "Pantaloni da archeologo";
					}
					case 254:
					{
						return "Tintura nera";
					}
					case 255:
					{
						return "Tintura verde";
					}
					case 256:
					{
						return "Cappuccio ninja";
					}
					case 257:
					{
						return "Camicia ninja";
					}
					case 258:
					{
						return "Pantaloni ninja";
					}
					case 259:
					{
						return "Pelle";
					}
					case 260:
					{
						return "Cappello rosso";
					}
					case 261:
					{
						return "Pesce rosso";
					}
					case 262:
					{
						return "Mantello";
					}
					case 263:
					{
						return "Cappello da robot";
					}
					case 264:
					{
						return "Corona d'oro";
					}
					case 265:
					{
						return "Freccia di fuoco infernale";
					}
					case 266:
					{
						return "Pistola di sabbia";
					}
					case 267:
					{
						return "Bambola voodoo guida";
					}
					case 268:
					{
						return "Casco da palombaro";
					}
					case 269:
					{
						return "Camicia comune";
					}
					case 270:
					{
						return "Pantaloni comuni";
					}
					case 271:
					{
						return "Parrucca comune";
					}
					case 272:
					{
						return "Falce demoniaca";
					}
					case 273:
					{
						return "Confine della notte";
					}
					case 274:
					{
						return "Lancia oscura";
					}
					case 275:
					{
						return "Corallo";
					}
					case 276:
					{
						return "Cactus";
					}
					case 277:
					{
						return "Tridente";
					}
					case 278:
					{
						return "Proiettile d'argento";
					}
					case 279:
					{
						return "Coltello da lancio";
					}
					case 280:
					{
						return "Lancia";
					}
					case 281:
					{
						return "Cerbottana";
					}
					case 282:
					{
						return "Bastone luminoso";
					}
					case 283:
					{
						return "Seme";
					}
					case 284:
					{
						return "Boomerang di legno";
					}
					case 285:
					{
						return "Aghetto";
					}
					case 286:
					{
						return "Bastone luminoso appiccicoso";
					}
					case 287:
					{
						return "Coltello avvelenato";
					}
					case 288:
					{
						return "Pozione pelle di ossidiana";
					}
					case 289:
					{
						return "Pozione rigeneratrice";
					}
					case 290:
					{
						return "Pozione della rapidità";
					}
					case 291:
					{
						return "Pozione branchie";
					}
					case 292:
					{
						return "Pozione pelle di ferro";
					}
					case 293:
					{
						return "Pozione rigenerazione mana";
					}
					case 294:
					{
						return "Pozione potenza magica";
					}
					case 295:
					{
						return "Pozione caduta dolce";
					}
					case 296:
					{
						return "Pozione speleologo";
					}
					case 297:
					{
						return "Pozione invisibilità";
					}
					case 298:
					{
						return "Pozione splendore";
					}
					case 299:
					{
						return "Pozione civetta";
					}
					case 300:
					{
						return "Pozione battaglia";
					}
					case 301:
					{
						return "Pozione spine";
					}
					case 302:
					{
						return "Pozione per camminare sull'acqua";
					}
					case 303:
					{
						return "Pozione arciere";
					}
					case 304:
					{
						return "Pozione cacciatore";
					}
					case 305:
					{
						return "Pozione gravità";
					}
					case 306:
					{
						return "Cassa d'oro";
					}
					case 307:
					{
						return "Semi Fiordigiorno";
					}
					case 308:
					{
						return "Semi Splendiluna";
					}
					case 309:
					{
						return "Semi Lampeggiaradice";
					}
					case 310:
					{
						return "Semi Erbamorte";
					}
					case 311:
					{
						return "Semi Acquafoglia";
					}
					case 312:
					{
						return "Semi Fiordifuoco";
					}
					case 313:
					{
						return "Fiordigiorno";
					}
					case 314:
					{
						return "Splendiluna";
					}
					case 315:
					{
						return "Lampeggiaradice";
					}
					case 316:
					{
						return "Erbamorte";
					}
					case 317:
					{
						return "Acquafoglia";
					}
					case 318:
					{
						return "Fiordifuoco";
					}
					case 319:
					{
						return "Pinna di squalo";
					}
					case 320:
					{
						return "Piuma";
					}
					case 321:
					{
						return "Lapide";
					}
					case 322:
					{
						return "Maschera sosia";
					}
					case 323:
					{
						return "Mandibola di formicaleone";
					}
					case 324:
					{
						return "Parti di pistola illegale";
					}
					case 325:
					{
						return "Camicia da medico";
					}
					case 326:
					{
						return "Pantaloni da medico";
					}
					case 327:
					{
						return "Chiave dorata";
					}
					case 328:
					{
						return "Cassa ombra";
					}
					case 329:
					{
						return "Chiave ombra";
					}
					case 330:
					{
						return "Muro di ossidiana";
					}
					case 331:
					{
						return "Spore della giungla";
					}
					case 332:
					{
						return "Telaio";
					}
					case 333:
					{
						return "Pianoforte";
					}
					case 334:
					{
						return "Cassettone";
					}
					case 335:
					{
						return "Panca";
					}
					case 336:
					{
						return "Vasca da bagno";
					}
					case 337:
					{
						return "Stendardo rosso";
					}
					case 338:
					{
						return "Stendardo verde";
					}
					case 339:
					{
						return "Stendardo blu";
					}
					case 340:
					{
						return "Stendardo giallo";
					}
					case 341:
					{
						return "Lampione";
					}
					case 342:
					{
						return "Torcia tiki";
					}
					case 343:
					{
						return "Barile";
					}
					case 344:
					{
						return "Lanterna cinese";
					}
					case 345:
					{
						return "Pentola";
					}
					case 346:
					{
						return "Caveau";
					}
					case 347:
					{
						return "Lanterna-teschio";
					}
					case 348:
					{
						return "Bidone";
					}
					case 349:
					{
						return "Candelabro";
					}
					case 350:
					{
						return "Vaso rosa";
					}
					case 351:
					{
						return "Boccale";
					}
					case 352:
					{
						return "Barilotto";
					}
					case 353:
					{
						return "Birra";
					}
					case 354:
					{
						return "Scaffale";
					}
					case 355:
					{
						return "Trono";
					}
					case 356:
					{
						return "Ciotola";
					}
					case 357:
					{
						return "Ciotola di zuppa";
					}
					case 358:
					{
						return "Toilette";
					}
					case 359:
					{
						return "Pendola";
					}
					case 360:
					{
						return "Statua armatura";
					}
					case 361:
					{
						return "Insegna di battaglia dei goblin";
					}
					case 362:
					{
						return "Abito a brandelli";
					}
					case 363:
					{
						return "Segheria";
					}
					case 364:
					{
						return "Minerale cobalto";
					}
					case 365:
					{
						return "Minerale mitrilio";
					}
					case 366:
					{
						return "Minerale adamantio";
					}
					case 367:
					{
						return "Martellone";
					}
					case 368:
					{
						return "Excalibur";
					}
					case 369:
					{
						return "Semi consacrati";
					}
					case 370:
					{
						return "Blocco sabbia d'ebano";
					}
					case 371:
					{
						return "Cappello di cobalto";
					}
					case 372:
					{
						return "Casco di cobalto";
					}
					case 373:
					{
						return "Maschera di cobalto";
					}
					case 374:
					{
						return "Corrazza di cobalto";
					}
					case 375:
					{
						return "Calzamaglia di cobalto";
					}
					case 376:
					{
						return "Cappuccio di mitrilio";
					}
					case 377:
					{
						return "Casco di mitrilio";
					}
					case 378:
					{
						return "Cappello di mitrilio";
					}
					case 379:
					{
						return "Maglia metallica di mitrilio";
					}
					case 380:
					{
						return "Gambali di mitrilio";
					}
					case 381:
					{
						return "Sbarra di cobalto";
					}
					case 382:
					{
						return "Sbarra di mitrilio";
					}
					case 383:
					{
						return "Motosega di cobalto";
					}
					case 384:
					{
						return "Motosega di mitrilio";
					}
					case 385:
					{
						return "Perforatrice di cobalto";
					}
					case 386:
					{
						return "Perforatrice di mitrilio";
					}
					case 387:
					{
						return "Motosega di adamantio";
					}
					case 388:
					{
						return "Perforatrice di adamantio";
					}
					case 389:
					{
						return "Frustona";
					}
					case 390:
					{
						return "Alabarda di mitrilio";
					}
					case 391:
					{
						return "Sbarra di adamantio";
					}
					case 392:
					{
						return "Muro di vetro";
					}
					case 393:
					{
						return "Bussola";
					}
					case 394:
					{
						return "Muta da sub";
					}
					case 395:
					{
						return "GPS";
					}
					case 396:
					{
						return "Ferro di cavallo di ossidiana";
					}
					case 397:
					{
						return "Scudo di ossidiana";
					}
					case 398:
					{
						return "Laboratorio dell'inventore";
					}
					case 399:
					{
						return "Nuvola in un palloncino";
					}
					case 400:
					{
						return "Copricapo di adamantio";
					}
					case 401:
					{
						return "Casco di adamantio";
					}
					case 402:
					{
						return "Maschera di adamantio";
					}
					case 403:
					{
						return "Corrazza di adamantio";
					}
					case 404:
					{
						return "Calzamaglia di adamantio";
					}
					case 405:
					{
						return "Stivali da fantasma";
					}
					case 406:
					{
						return "Alabarda di adamantio";
					}
					case 407:
					{
						return "Cintura porta attrezzi";
					}
					case 408:
					{
						return "Blocco sabbiaperla";
					}
					case 409:
					{
						return "Blocco pietraperla";
					}
					case 410:
					{
						return "Camicia da minatore";
					}
					case 411:
					{
						return "Pantaloni da minatore";
					}
					case 412:
					{
						return "Mattone pietraperla";
					}
					case 413:
					{
						return "Mattone iridescente";
					}
					case 414:
					{
						return "Blocco pietrafango";
					}
					case 415:
					{
						return "Mattone cobalto";
					}
					case 416:
					{
						return "Mattone mitrilio";
					}
					case 417:
					{
						return "Muro di pietraperla";
					}
					case 418:
					{
						return "Muro di mattoni iridescenti";
					}
					case 419:
					{
						return "Muro di pietrafango";
					}
					case 420:
					{
						return "Muro di mattoni di cobalto";
					}
					case 421:
					{
						return "Muro di mattoni di mitrilio";
					}
					case 422:
					{
						return "Acquasanta";
					}
					case 423:
					{
						return "Acqua profana";
					}
					case 424:
					{
						return "Blocco insabbiato";
					}
					case 425:
					{
						return "Campana della fata";
					}
					case 426:
					{
						return "Lama del distruttore";
					}
					case 427:
					{
						return "Torcia blu";
					}
					case 428:
					{
						return "Torcia rossa";
					}
					case 429:
					{
						return "Torcia verde";
					}
					case 430:
					{
						return "Torcia viola";
					}
					case 431:
					{
						return "Torcia bianca";
					}
					case 432:
					{
						return "Torcia gialla";
					}
					case 433:
					{
						return "Torcia demoniaca";
					}
					case 434:
					{
						return "Fucile d'assalto automatico";
					}
					case 435:
					{
						return "Balestra automatica di cobalto";
					}
					case 436:
					{
						return "Balestra automatica di mitrilio";
					}
					case 437:
					{
						return "Gancio doppio";
					}
					case 438:
					{
						return "Statua stella";
					}
					case 439:
					{
						return "Statua spada";
					}
					case 440:
					{
						return "Statua slime";
					}
					case 441:
					{
						return "Statua goblin";
					}
					case 442:
					{
						return "Statua scudo";
					}
					case 443:
					{
						return "Statua pipistrello";
					}
					case 444:
					{
						return "Statua pesce";
					}
					case 445:
					{
						return "Statua coniglio";
					}
					case 446:
					{
						return "Statua scheletro";
					}
					case 447:
					{
						return "Statua mietitore";
					}
					case 448:
					{
						return "Statua donna";
					}
					case 449:
					{
						return "Statua diavoletto";
					}
					case 450:
					{
						return "Statua gargoyle";
					}
					case 451:
					{
						return "Statua tenebre";
					}
					case 452:
					{
						return "Statua calabrone";
					}
					case 453:
					{
						return "Statua bomba";
					}
					case 454:
					{
						return "Statua granchio";
					}
					case 455:
					{
						return "Statua martello";
					}
					case 456:
					{
						return "Statua pozione";
					}
					case 457:
					{
						return "Statua arpione";
					}
					case 458:
					{
						return "Statua croce";
					}
					case 459:
					{
						return "Statua medusa";
					}
					case 460:
					{
						return "Statua arco";
					}
					case 461:
					{
						return "Statua boomerang";
					}
					case 462:
					{
						return "Statua stivali";
					}
					case 463:
					{
						return "Statua cassa";
					}
					case 464:
					{
						return "Statua Uucello";
					}
					case 465:
					{
						return "Statua ascia";
					}
					case 466:
					{
						return "Statua distruzione";
					}
					case 467:
					{
						return "Statua albero";
					}
					case 468:
					{
						return "Staua incudine";
					}
					case 469:
					{
						return "Statua piccone";
					}
					case 470:
					{
						return "Statua fungo";
					}
					case 471:
					{
						return "Statua bulbo oculare";
					}
					case 472:
					{
						return "Statua colonna";
					}
					case 473:
					{
						return "Statua cuore";
					}
					case 474:
					{
						return "Statua pentola";
					}
					case 475:
					{
						return "Statua girasole";
					}
					case 476:
					{
						return "Statua re";
					}
					case 477:
					{
						return "Statua regina";
					}
					case 478:
					{
						return "Statua piranha";
					}
					case 479:
					{
						return "Muro impalcato";
					}
					case 480:
					{
						return "Trave di legno";
					}
					case 481:
					{
						return "Mietitore di adamantio";
					}
					case 482:
					{
						return "Spada di adamantio";
					}
					case 483:
					{
						return "Spada di cobalto";
					}
					case 484:
					{
						return "Spada di mitrilio";
					}
					case 485:
					{
						return "Amuleto della luna";
					}
					case 486:
					{
						return "Righello";
					}
					case 487:
					{
						return "Sfera di cristallo";
					}
					case 488:
					{
						return "Palla disco";
					}
					case 489:
					{
						return "Emblema dell'incantatore";
					}
					case 490:
					{
						return "Emblema del guerriero";
					}
					case 491:
					{
						return "Emblema del guardiaboschi";
					}
					case 492:
					{
						return "Ali del demone";
					}
					case 493:
					{
						return "Ali dell'angelo";
					}
					case 494:
					{
						return "Arpa magica";
					}
					case 495:
					{
						return "Bastone dell'arcobaleno";
					}
					case 496:
					{
						return "Bastone di ghiaccio";
					}
					case 497:
					{
						return "Conchiglia di Nettuno";
					}
					case 498:
					{
						return "Manichino";
					}
					case 499:
					{
						return "Pozione curativa superiore";
					}
					case 500:
					{
						return "Pozione mana superiore";
					}
					case 501:
					{
						return "Polvere di fata";
					}
					case 502:
					{
						return "Frammento di cristallo";
					}
					case 503:
					{
						return "Cappello da clown";
					}
					case 504:
					{
						return "Camicia da clown";
					}
					case 505:
					{
						return "Pantaloni da clown";
					}
					case 506:
					{
						return "Lanciafiamme";
					}
					case 507:
					{
						return "Campana";
					}
					case 508:
					{
						return "Arpa";
					}
					case 509:
					{
						return "Chiave inglese";
					}
					case 510:
					{
						return "Tagliacavi";
					}
					case 511:
					{
						return "Blocco di pietra attivo";
					}
					case 512:
					{
						return "Blocco di pietra non attivo";
					}
					case 513:
					{
						return "Leva";
					}
					case 514:
					{
						return "Fucile laser";
					}
					case 515:
					{
						return "Proiettile di cristallo";
					}
					case 516:
					{
						return "Freccia sacra";
					}
					case 517:
					{
						return "Pugnale magico";
					}
					case 518:
					{
						return "Tempesta di cristallo";
					}
					case 519:
					{
						return "Fiamme maledette";
					}
					case 520:
					{
						return "Anima della luce";
					}
					case 521:
					{
						return "Anima della notte";
					}
					case 522:
					{
						return "Fiamma maledetta";
					}
					case 523:
					{
						return "Torcia maledetta";
					}
					case 524:
					{
						return "Fornace di adamantio";
					}
					case 525:
					{
						return "Incudine di mitrilio";
					}
					case 526:
					{
						return "Corno di unicorno";
					}
					case 527:
					{
						return "Frammento oscuro";
					}
					case 528:
					{
						return "Frammento di luce";
					}
					case 529:
					{
						return "Piastra a pressione rossa";
					}
					case 530:
					{
						return "Cavo";
					}
					case 531:
					{
						return "Tomo incantato";
					}
					case 532:
					{
						return "Mantello stellato";
					}
					case 533:
					{
						return "Megashark";
					}
					case 534:
					{
						return "Fucile";
					}
					case 535:
					{
						return "Pietra filosofale";
					}
					case 536:
					{
						return "Guanto del Titano";
					}
					case 537:
					{
						return "Naginata di cobalto";
					}
					case 538:
					{
						return "Interruttore";
					}
					case 539:
					{
						return "Trappola dardi";
					}
					case 540:
					{
						return "Masso";
					}
					case 541:
					{
						return "Piastra a pressione verde";
					}
					case 542:
					{
						return "Piastra a pressione grigia";
					}
					case 543:
					{
						return "Piastra a pressione marrone";
					}
					case 544:
					{
						return "Occhio meccanico";
					}
					case 545:
					{
						return "Freccia maledetta";
					}
					case 546:
					{
						return "Proiettile maledetto";
					}
					case 547:
					{
						return "Anima del terrore";
					}
					case 548:
					{
						return "Anima del potere";
					}
					case 549:
					{
						return "Anima della visione";
					}
					case 550:
					{
						return "Gungnir";
					}
					case 551:
					{
						return "Armatura sacra";
					}
					case 552:
					{
						return "Gambali sacri";
					}
					case 553:
					{
						return "Casco sacro";
					}
					case 554:
					{
						return "Collana con croce";
					}
					case 555:
					{
						return "Fiore di mana";
					}
					case 556:
					{
						return "Verme meccanico";
					}
					case 557:
					{
						return "Teschio meccanico";
					}
					case 558:
					{
						return "Copricapo sacro";
					}
					case 559:
					{
						return "Maschera sacra";
					}
					case 560:
					{
						return "Corona slime";
					}
					case 561:
					{
						return "Disco di luce";
					}
					case 562:
					{
						return "Musica (Giornata mondiale)";
					}
					case 563:
					{
						return "Musica (Mistero)";
					}
					case 564:
					{
						return "Musica (Notte)";
					}
					case 565:
					{
						return "Musica (Titolo)";
					}
					case 566:
					{
						return "Musica (Sottosuolo)";
					}
					case 567:
					{
						return "Musica (Boss 1)";
					}
					case 568:
					{
						return "Musica (Giungla)";
					}
					case 569:
					{
						return "Musica (Distruzione)";
					}
					case 570:
					{
						return "Musica (Distruzione sotterranea)";
					}
					case 571:
					{
						return "Musica (Il sacro)";
					}
					case 572:
					{
						return "Musica (Boss 2)";
					}
					case 573:
					{
						return "Musica (Sacro sotterraneo)";
					}
					case 574:
					{
						return "Musica (Boss 3)";
					}
					case 575:
					{
						return "Anima del volo";
					}
					case 576:
					{
						return "Musica";
					}
					case 577:
					{
						return "Mattone demoniaco";
					}
					case 578:
					{
						return "Balestra automatica sacra";
					}
					case 579:
					{
						return "Perforascia";
					}
					case 580:
					{
						return "Esplosivi";
					}
					case 581:
					{
						return "Pompa interna";
					}
					case 582:
					{
						return "Pompa esterna";
					}
					case 583:
					{
						return "Timer 2 secondo";
					}
					case 584:
					{
						return "Timer 3 secondi";
					}
					case 585:
					{
						return "Timer 5 secondi";
					}
					case 586:
					{
						return "Candy Cane Block";
					}
					case 587:
					{
						return "Candy Cane parete";
					}
					case 588:
					{
						return "Cappello da Babbo Natale";
					}
					case 589:
					{
						return "S. Shirt";
					}
					case 590:
					{
						return "Pantaloni di Santa";
					}
					case 591:
					{
						return "Blocco verde Candy Cane";
					}
					case 592:
					{
						return "Green Candy Cane Wall";
					}
					case 593:
					{
						return "Blocca neve";
					}
					case 594:
					{
						return "neve Brick";
					}
					case 595:
					{
						return "Neve Muro di mattoni";
					}
					case 596:
					{
						return "azzurro";
					}
					case 597:
					{
						return "Red Light";
					}
					case 598:
					{
						return "verde chiaro";
					}
					case 599:
					{
						return "Presente blu";
					}
					case 600:
					{
						return "Presente verde";
					}
					case 601:
					{
						return "Presente giallo";
					}
					case 602:
					{
						return "Snow Globe";
					}
					case 603:
					{
						return "Carota";
					}
					default:
					{
						switch (num1)
						{
							case 3480:
							{
								return "Platinum Bow";
							}
							case 3481:
							{
								return "Platinum Hammer";
							}
							case 3482:
							{
								return "Platinum Axe";
							}
							case 3483:
							{
								return "Platinum Shortsword";
							}
							case 3484:
							{
								return "Platinum Broadsword";
							}
							case 3485:
							{
								return "Platinum Pickaxe";
							}
							case 3486:
							{
								return "Tungsten Bow";
							}
							case 3487:
							{
								return "Tungsten Hammer";
							}
							case 3488:
							{
								return "Tungsten Axe";
							}
							case 3489:
							{
								return "Tungsten Shortsword";
							}
							case 3490:
							{
								return "Tungsten Broadsword";
							}
							case 3491:
							{
								return "Tungsten Pickaxe";
							}
							case 3492:
							{
								return "Lead Bow";
							}
							case 3493:
							{
								return "Lead Hammer";
							}
							case 3494:
							{
								return "Lead Axe";
							}
							case 3495:
							{
								return "Lead Shortsword";
							}
							case 3496:
							{
								return "Lead Broadsword";
							}
							case 3497:
							{
								return "Lead Pickaxe";
							}
							case 3498:
							{
								return "Tin Bow";
							}
							case 3499:
							{
								return "Tin Hammer";
							}
							case 3500:
							{
								return "Tin Axe";
							}
							case 3501:
							{
								return "Tin Shortsword";
							}
							case 3502:
							{
								return "Tin Broadsword";
							}
							case 3503:
							{
								return "Tin Pickaxe";
							}
							case 3504:
							{
								return "Arco di rame";
							}
							case 3505:
							{
								return "Martello di rame";
							}
							case 3506:
							{
								return "Ascia di rame";
							}
							case 3507:
							{
								return "Spada corta di rame";
							}
							case 3508:
							{
								return "Spadone di rame";
							}
							case 3509:
							{
								return "Piccone di rame";
							}
							case 3510:
							{
								return "Arco d'argento";
							}
							case 3511:
							{
								return "Martello d'argento";
							}
							case 3512:
							{
								return "Ascia d'argento";
							}
							case 3513:
							{
								return "Spada corta d'argento";
							}
							case 3514:
							{
								return "Spadone d'argento";
							}
							case 3515:
							{
								return "Piccone d'argento";
							}
							case 3516:
							{
								return "Arco d'oro";
							}
							case 3517:
							{
								return "Martello d'oro";
							}
							case 3518:
							{
								return "Ascia d'oro";
							}
							case 3519:
							{
								return "Spada corta d'oro";
							}
							case 3520:
							{
								return "Spadone d'oro";
							}
							case 3521:
							{
								return "Piccone d'oro";
							}
						}
						break;
					}
				}
			}
			else if (Lang.lang == 4)
			{
				int num2 = l;
				switch (num2)
				{
					case -24:
					{
						return "Sabre laser jaune";
					}
					case -23:
					{
						return "Sabre laser blanc";
					}
					case -22:
					{
						return "Sabre laser violet";
					}
					case -21:
					{
						return "Sabre laser vert";
					}
					case -20:
					{
						return "Sabre laser rouge";
					}
					case -19:
					{
						return "Sabre laser bleu";
					}
					case -18:
					{
						return "Arc en cuivre";
					}
					case -17:
					{
						return "Marteau en cuivre";
					}
					case -16:
					{
						return "Hache en cuivre";
					}
					case -15:
					{
						return "Épée courte en cuivre";
					}
					case -14:
					{
						return "Épée longue en cuivre";
					}
					case -13:
					{
						return "Pioche en cuivre";
					}
					case -12:
					{
						return "Arc en argent";
					}
					case -11:
					{
						return "Marteau en argent";
					}
					case -10:
					{
						return "Hache en argent";
					}
					case -9:
					{
						return "Épée courte en argent";
					}
					case -8:
					{
						return "Épée longue en argent";
					}
					case -7:
					{
						return "Pioche en argent";
					}
					case -6:
					{
						return "Arc en or";
					}
					case -5:
					{
						return "Marteau en or";
					}
					case -4:
					{
						return "Hache en or";
					}
					case -3:
					{
						return "Épée courte en or";
					}
					case -2:
					{
						return "Épée longue en or";
					}
					case -1:
					{
						return "Pioche en or";
					}
					case 0:
					{
						break;
					}
					case 1:
					{
						return "Pioche en fer";
					}
					case 2:
					{
						return "Bloc de terre";
					}
					case 3:
					{
						return "Bloc de pierre";
					}
					case 4:
					{
						return "Épée longue en fer";
					}
					case 5:
					{
						return "Champignon";
					}
					case 6:
					{
						return "Épée courte en fer";
					}
					case 7:
					{
						return "Marteau en fer";
					}
					case 8:
					{
						return "Torche";
					}
					case 9:
					{
						return "Bois";
					}
					case 10:
					{
						return "Hache en fer";
					}
					case 11:
					{
						return "Minerai de fer";
					}
					case 12:
					{
						return "Minerai de cuivre";
					}
					case 13:
					{
						return "Minerai d'or";
					}
					case 14:
					{
						return "Minerai d'argent";
					}
					case 15:
					{
						return "Montre en cuivre";
					}
					case 16:
					{
						return "Montre en argent";
					}
					case 17:
					{
						return "Montre en or";
					}
					case 18:
					{
						return "Altimètre";
					}
					case 19:
					{
						return "Lingot d'or";
					}
					case 20:
					{
						return "Lingot de cuivre";
					}
					case 21:
					{
						return "Lingot d'argent";
					}
					case 22:
					{
						return "Lingot de fer";
					}
					case 23:
					{
						return "Gel";
					}
					case 24:
					{
						return "Épée en bois";
					}
					case 25:
					{
						return "Porte en bois";
					}
					case 26:
					{
						return "Mur en pierre";
					}
					case 27:
					{
						return "Gland";
					}
					case 28:
					{
						return "Faible potion de soin";
					}
					case 29:
					{
						return "Cristal de vie";
					}
					case 30:
					{
						return "Mur en terre";
					}
					case 31:
					{
						return "Bouteille";
					}
					case 32:
					{
						return "Table en bois";
					}
					case 33:
					{
						return "Four";
					}
					case 34:
					{
						return "Chaise en bois";
					}
					case 35:
					{
						return "Enclume";
					}
					case 36:
					{
						return "Établi";
					}
					case 37:
					{
						return "Lunettes";
					}
					case 38:
					{
						return "Lentille";
					}
					case 39:
					{
						return "Arc en bois";
					}
					case 40:
					{
						return "Flèche en bois";
					}
					case 41:
					{
						return "Flèche enflammée";
					}
					case 42:
					{
						return "Shuriken";
					}
					case 43:
					{
						return "Œil observateur suspicieux";
					}
					case 44:
					{
						return "Arc démoniaque";
					}
					case 45:
					{
						return "Hache de guerre de la nuit";
					}
					case 46:
					{
						return "Fléau de lumière";
					}
					case 47:
					{
						return "Flèche impie";
					}
					case 48:
					{
						return "Coffre";
					}
					case 49:
					{
						return "Anneau de régénération";
					}
					case 50:
					{
						return "Miroir magique";
					}
					case 51:
					{
						return "Flèche du bouffon";
					}
					case 52:
					{
						return "Statue d'ange";
					}
					case 53:
					{
						return "Nuage en bouteille";
					}
					case 54:
					{
						return "Bottes d'Hermès";
					}
					case 55:
					{
						return "Boomerang enchanté";
					}
					case 56:
					{
						return "Barre de démonite";
					}
					case 57:
					{
						return "Lingot de démonite";
					}
					case 58:
					{
						return "Pilier";
					}
					case 59:
					{
						return "Graines corrompues";
					}
					case 60:
					{
						return "Champignon infect";
					}
					case 61:
					{
						return "Bloc d'ébonite";
					}
					case 62:
					{
						return "Graines d'herbe";
					}
					case 63:
					{
						return "Tournesols";
					}
					case 64:
					{
						return "Vileronce";
					}
					case 65:
					{
						return "Furie stellaire";
					}
					case 66:
					{
						return "Poudre de purification";
					}
					case 67:
					{
						return "Poudre infecte";
					}
					case 68:
					{
						return "Morceau pourri";
					}
					case 69:
					{
						return "Dent de ver";
					}
					case 70:
					{
						return "Nourriture pour ver";
					}
					case 71:
					{
						return "Pièce de cuivre";
					}
					case 72:
					{
						return "Pièce d'argent";
					}
					case 73:
					{
						return "Pièce d'or";
					}
					case 74:
					{
						return "Pièce de platine";
					}
					case 75:
					{
						return "Étoile filante";
					}
					case 76:
					{
						return "Jambières en cuivre";
					}
					case 77:
					{
						return "Jambières en fer";
					}
					case 78:
					{
						return "Jambières en argent";
					}
					case 79:
					{
						return "Jambière en or";
					}
					case 80:
					{
						return "Cotte de mailles en cuivre";
					}
					case 81:
					{
						return "Cotte de mailles en fer";
					}
					case 82:
					{
						return "Cotte de mailles en argent";
					}
					case 83:
					{
						return "Cotte de mailles en or";
					}
					case 84:
					{
						return "Grappin";
					}
					case 85:
					{
						return "Chaîne en fer";
					}
					case 86:
					{
						return "Écaille sombre";
					}
					case 87:
					{
						return "Tirelire";
					}
					case 88:
					{
						return "Casque de mineur";
					}
					case 89:
					{
						return "Casque en cuivre";
					}
					case 90:
					{
						return "Casque en fer";
					}
					case 91:
					{
						return "Casque en argent";
					}
					case 92:
					{
						return "Casque en or";
					}
					case 93:
					{
						return "Mur en bois";
					}
					case 94:
					{
						return "Plateforme en bois";
					}
					case 95:
					{
						return "Pistolet à silex";
					}
					case 96:
					{
						return "Mousquet";
					}
					case 97:
					{
						return "Balle de mousquet";
					}
					case 98:
					{
						return "Minishark";
					}
					case 99:
					{
						return "Arc en fer";
					}
					case 100:
					{
						return "Jambières de l'ombre";
					}
					case 101:
					{
						return "Armure d'écailles de l'ombre";
					}
					case 102:
					{
						return "Casque de l'ombre";
					}
					case 103:
					{
						return "Pioche cauchemardesque";
					}
					case 104:
					{
						return "Le briseur";
					}
					case 105:
					{
						return "Bougie";
					}
					case 106:
					{
						return "Chandelier en cuivre";
					}
					case 107:
					{
						return "Chandelier en argent";
					}
					case 108:
					{
						return "Chandelier en or";
					}
					case 109:
					{
						return "Cristal de mana";
					}
					case 110:
					{
						return "Potion de mana inférieure";
					}
					case 111:
					{
						return "Anneau de pouvoir stellaire";
					}
					case 112:
					{
						return "Fleur de feu";
					}
					case 113:
					{
						return "Missile magique";
					}
					case 114:
					{
						return "Bâtonnet de terre";
					}
					case 115:
					{
						return "Orbe de lumière";
					}
					case 116:
					{
						return "Météorite";
					}
					case 117:
					{
						return "Barre de météorite";
					}
					case 118:
					{
						return "Crochet";
					}
					case 119:
					{
						return "Flamarang";
					}
					case 120:
					{
						return "Furie en fusion";
					}
					case 121:
					{
						return "Grande épée ardente";
					}
					case 122:
					{
						return "Pioche en fusion";
					}
					case 123:
					{
						return "Casque de météore";
					}
					case 124:
					{
						return "Costume de météore";
					}
					case 125:
					{
						return "Leggings de météores";
					}
					case 126:
					{
						return "Eau en bouteille";
					}
					case 127:
					{
						return "Arme d'espace";
					}
					case 128:
					{
						return "Bottes roquettes";
					}
					case 129:
					{
						return "Brique grise";
					}
					case 130:
					{
						return "Mur en briques grises";
					}
					case 131:
					{
						return "Brique rouge";
					}
					case 132:
					{
						return "Mur de briques rouges";
					}
					case 133:
					{
						return "Bloc d'argile";
					}
					case 134:
					{
						return "Brique bleue";
					}
					case 135:
					{
						return "Mur en briques bleues";
					}
					case 136:
					{
						return "Lanterne à chaîne";
					}
					case 137:
					{
						return "Brique verte";
					}
					case 138:
					{
						return "Mur de briques vertes";
					}
					case 139:
					{
						return "Brique rose";
					}
					case 140:
					{
						return "Mur de briques roses";
					}
					case 141:
					{
						return "Brique dorée";
					}
					case 142:
					{
						return "Mur de briques dorées";
					}
					case 143:
					{
						return "Brique argentée";
					}
					case 144:
					{
						return "Mur de briques argentées";
					}
					case 145:
					{
						return "Brique cuivrée";
					}
					case 146:
					{
						return "Mur de briques cuivrées";
					}
					case 147:
					{
						return "Pointe";
					}
					case 148:
					{
						return "Bougie d'eau";
					}
					case 149:
					{
						return "Livre";
					}
					case 150:
					{
						return "Toile d'araignée";
					}
					case 151:
					{
						return "Casque nécro";
					}
					case 152:
					{
						return "Plastron nécro";
					}
					case 153:
					{
						return "Jambières nécro";
					}
					case 154:
					{
						return "Os";
					}
					case 155:
					{
						return "Muramasa";
					}
					case 156:
					{
						return "Bouclier de cobalt";
					}
					case 157:
					{
						return "Sceptre aquatique";
					}
					case 158:
					{
						return "Fer à cheval porte-bonheur";
					}
					case 159:
					{
						return "Ballon rouge brillant";
					}
					case 160:
					{
						return "Harpon";
					}
					case 161:
					{
						return "Balle hérissée";
					}
					case 162:
					{
						return "Ball O' Hurt";
					}
					case 163:
					{
						return "Lune bleue";
					}
					case 164:
					{
						return "Pistolet";
					}
					case 165:
					{
						return "Trait d'eau";
					}
					case 166:
					{
						return "Bombe";
					}
					case 167:
					{
						return "Dynamite";
					}
					case 168:
					{
						return "Grenade";
					}
					case 169:
					{
						return "Bloc de sable";
					}
					case 170:
					{
						return "Verre";
					}
					case 171:
					{
						return "Panneau";
					}
					case 172:
					{
						return "Bloc de cendre";
					}
					case 173:
					{
						return "Obsidienne";
					}
					case 174:
					{
						return "Pierre de l'enfer";
					}
					case 175:
					{
						return "Barre de pierre de l'enfer";
					}
					case 176:
					{
						return "Bloc de boue";
					}
					case 177:
					{
						return "Saphir";
					}
					case 178:
					{
						return "Rubis";
					}
					case 179:
					{
						return "Émeraude";
					}
					case 180:
					{
						return "Topaze";
					}
					case 181:
					{
						return "Améthyste";
					}
					case 182:
					{
						return "Diamant";
					}
					case 183:
					{
						return "Champignon lumineux";
					}
					case 184:
					{
						return "Étoile";
					}
					case 185:
					{
						return "Grappin à lianes";
					}
					case 186:
					{
						return "Tuba";
					}
					case 187:
					{
						return "Palmes";
					}
					case 188:
					{
						return "Potion de soins";
					}
					case 189:
					{
						return "Potion de mana";
					}
					case 190:
					{
						return "Lame de l'herbe";
					}
					case 191:
					{
						return "Chakram d'épines";
					}
					case 192:
					{
						return "Brique d'obsidienne";
					}
					case 193:
					{
						return "Crâne d'obsidienne";
					}
					case 194:
					{
						return "Graines de champignon";
					}
					case 195:
					{
						return "Graines de la jungle";
					}
					case 196:
					{
						return "Marteau en bois";
					}
					case 197:
					{
						return "Canon à étoiles";
					}
					case 198:
					{
						return "Sabre laser bleu";
					}
					case 199:
					{
						return "Sabre laser rouge";
					}
					case 200:
					{
						return "Sabre laser vert";
					}
					case 201:
					{
						return "Sabre laser violet";
					}
					case 202:
					{
						return "Sabre laser blanc";
					}
					case 203:
					{
						return "Sabre laser jaune";
					}
					case 204:
					{
						return "Martache en météorite";
					}
					case 205:
					{
						return "Seau vide";
					}
					case 206:
					{
						return "Seau d'eau";
					}
					case 207:
					{
						return "Seau de lave";
					}
					case 208:
					{
						return "Rose de la jungle";
					}
					case 209:
					{
						return "Dard";
					}
					case 210:
					{
						return "Vigne";
					}
					case 211:
					{
						return "Griffes sauvages";
					}
					case 212:
					{
						return "Bracelet du vent";
					}
					case 213:
					{
						return "Crosse de repousse";
					}
					case 214:
					{
						return "Brique de pierre de l'enfer";
					}
					case 215:
					{
						return "Coussin péteur";
					}
					case 216:
					{
						return "Manille";
					}
					case 217:
					{
						return "Martache en fusion";
					}
					case 218:
					{
						return "Mèche enflammée";
					}
					case 219:
					{
						return "Blaster phénix";
					}
					case 220:
					{
						return "Furie solaire";
					}
					case 221:
					{
						return "Forge infernale";
					}
					case 222:
					{
						return "Pot d'argile";
					}
					case 223:
					{
						return "Don de la nature";
					}
					case 224:
					{
						return "Lit";
					}
					case 225:
					{
						return "Soie";
					}
					case 226:
					{
						return "Potion de restauration inférieure";
					}
					case 227:
					{
						return "Potion de restauration";
					}
					case 228:
					{
						return "Casque de la jungle";
					}
					case 229:
					{
						return "Plastron de la jungle";
					}
					case 230:
					{
						return "Jambières de la jungle";
					}
					case 231:
					{
						return "Casque en fusion";
					}
					case 232:
					{
						return "Plastron en fusion";
					}
					case 233:
					{
						return "Jambières en fusion";
					}
					case 234:
					{
						return "Balle météore";
					}
					case 235:
					{
						return "Bombe collante";
					}
					case 236:
					{
						return "Lentille noire";
					}
					case 237:
					{
						return "Lunettes de soleil";
					}
					case 238:
					{
						return "Chapeau de magicien";
					}
					case 239:
					{
						return "Haut de forme";
					}
					case 240:
					{
						return "Veste de smoking";
					}
					case 241:
					{
						return "Pantalon de smoking";
					}
					case 242:
					{
						return "Chapeau d'été";
					}
					case 243:
					{
						return "Capuche de lapin";
					}
					case 244:
					{
						return "Casquette de plombier";
					}
					case 245:
					{
						return "Veste de plombier";
					}
					case 246:
					{
						return "Pantalon de plombier";
					}
					case 247:
					{
						return "Capuche de héros";
					}
					case 248:
					{
						return "Veste de héros";
					}
					case 249:
					{
						return "Pantalon de héros";
					}
					case 250:
					{
						return "Bocal à poissons";
					}
					case 251:
					{
						return "Chapeau d'archéologue";
					}
					case 252:
					{
						return "Veste d'archéologue";
					}
					case 253:
					{
						return "Pantalon d'archéologue";
					}
					case 254:
					{
						return "Teinture noire";
					}
					case 255:
					{
						return "Teinture verte";
					}
					case 256:
					{
						return "Cagoule de ninja";
					}
					case 257:
					{
						return "Veste de ninja";
					}
					case 258:
					{
						return "Pantalon de ninja";
					}
					case 259:
					{
						return "Cuir";
					}
					case 260:
					{
						return "Chapeau rouge";
					}
					case 261:
					{
						return "Poisson doré";
					}
					case 262:
					{
						return "Robe";
					}
					case 263:
					{
						return "Chapeau de robot";
					}
					case 264:
					{
						return "Couronne d'or";
					}
					case 265:
					{
						return "Flèche du feu de l'enfer";
					}
					case 266:
					{
						return "Canon à sable";
					}
					case 267:
					{
						return "Poupée vaudou du guide";
					}
					case 268:
					{
						return "Casque de plongée";
					}
					case 269:
					{
						return "Chemise familière";
					}
					case 270:
					{
						return "Pantalon familier";
					}
					case 271:
					{
						return "Perruque familière";
					}
					case 272:
					{
						return "Faux de démon";
					}
					case 273:
					{
						return "Fil des Ténèbres";
					}
					case 274:
					{
						return "Lance sombre";
					}
					case 275:
					{
						return "Corail";
					}
					case 276:
					{
						return "Cactus";
					}
					case 277:
					{
						return "Trident";
					}
					case 278:
					{
						return "Balle d'argent";
					}
					case 279:
					{
						return "Couteau de lancer";
					}
					case 280:
					{
						return "Lance";
					}
					case 281:
					{
						return "Sarbacane";
					}
					case 282:
					{
						return "Bâton lumineux";
					}
					case 283:
					{
						return "Graine";
					}
					case 284:
					{
						return "Boomerang en bois";
					}
					case 285:
					{
						return "Embout de lacet";
					}
					case 286:
					{
						return "Bâton lumineux collant";
					}
					case 287:
					{
						return "Couteau empoisonné";
					}
					case 288:
					{
						return "Potion de peau d'obsidienne";
					}
					case 289:
					{
						return "Potion de régénération";
					}
					case 290:
					{
						return "Potion de rapidité";
					}
					case 291:
					{
						return "Potion de branchies";
					}
					case 292:
					{
						return "Potion de peau de fer";
					}
					case 293:
					{
						return "Potion de régénération de mana";
					}
					case 294:
					{
						return "Potion de pouvoir magique";
					}
					case 295:
					{
						return "Potion de poids plume";
					}
					case 296:
					{
						return "Potion de spéléologue";
					}
					case 297:
					{
						return "Potion d'invisibilité";
					}
					case 298:
					{
						return "Potion de brillance";
					}
					case 299:
					{
						return "Potion de vision nocturne";
					}
					case 300:
					{
						return "Potion de bataille";
					}
					case 301:
					{
						return "Potion d'épines";
					}
					case 302:
					{
						return "Potion de marche sur l'eau";
					}
					case 303:
					{
						return "Potion de tir à l'arc";
					}
					case 304:
					{
						return "Potion du chasseur";
					}
					case 305:
					{
						return "Potion de gravité";
					}
					case 306:
					{
						return "Coffre d'or";
					}
					case 307:
					{
						return "Graines de floraison du jour";
					}
					case 308:
					{
						return "Graines de lueur de lune";
					}
					case 309:
					{
						return "Graines de racine clignotante";
					}
					case 310:
					{
						return "Graines de mauvaise herbe morte";
					}
					case 311:
					{
						return "Graines de feuilles de l'eau";
					}
					case 312:
					{
						return "Graines de fleur de feu";
					}
					case 313:
					{
						return "Floraison du jour";
					}
					case 314:
					{
						return "Lueur de lune";
					}
					case 315:
					{
						return "Racine clignotante";
					}
					case 316:
					{
						return "Mauvaise herbe morte";
					}
					case 317:
					{
						return "Feuille de l'eau";
					}
					case 318:
					{
						return "Fleur de feu";
					}
					case 319:
					{
						return "Aileron de requin";
					}
					case 320:
					{
						return "Plume";
					}
					case 321:
					{
						return "Pierre tombale";
					}
					case 322:
					{
						return "Masque du mime";
					}
					case 323:
					{
						return "Mandibule de fourmilion";
					}
					case 324:
					{
						return "Pièces détachées";
					}
					case 325:
					{
						return "Veste du docteur";
					}
					case 326:
					{
						return "Pantalon du docteur";
					}
					case 327:
					{
						return "Clé dorée";
					}
					case 328:
					{
						return "Coffre sombre";
					}
					case 329:
					{
						return "Clé sombre";
					}
					case 330:
					{
						return "Mur de briques d'obsidienne";
					}
					case 331:
					{
						return "Spores de la jungle";
					}
					case 332:
					{
						return "Métier à tisser";
					}
					case 333:
					{
						return "Piano";
					}
					case 334:
					{
						return "Commode";
					}
					case 335:
					{
						return "Banc";
					}
					case 336:
					{
						return "Baignoire";
					}
					case 337:
					{
						return "Bannière rouge";
					}
					case 338:
					{
						return "Bannière verte";
					}
					case 339:
					{
						return "Bannière bleue";
					}
					case 340:
					{
						return "Bannière jaune";
					}
					case 341:
					{
						return "Lampadaire";
					}
					case 342:
					{
						return "Torche de tiki";
					}
					case 343:
					{
						return "Baril";
					}
					case 344:
					{
						return "Lanterne chinoise";
					}
					case 345:
					{
						return "Marmite";
					}
					case 346:
					{
						return "Coffre-fort";
					}
					case 347:
					{
						return "Lanterne crâne";
					}
					case 348:
					{
						return "Poubelle";
					}
					case 349:
					{
						return "Candélabre";
					}
					case 350:
					{
						return "Vase rose";
					}
					case 351:
					{
						return "Chope";
					}
					case 352:
					{
						return "Tonnelet";
					}
					case 353:
					{
						return "Bière";
					}
					case 354:
					{
						return "Bibliothèque";
					}
					case 355:
					{
						return "Trône";
					}
					case 356:
					{
						return "Bol";
					}
					case 357:
					{
						return "Bol de soupe";
					}
					case 358:
					{
						return "Toilettes";
					}
					case 359:
					{
						return "Horloge de grand-père";
					}
					case 360:
					{
						return "Statue d'armure";
					}
					case 361:
					{
						return "Étendard de bataille gobelin";
					}
					case 362:
					{
						return "Vêtements en lambeaux";
					}
					case 363:
					{
						return "Scierie";
					}
					case 364:
					{
						return "Minerai de cobalt";
					}
					case 365:
					{
						return "Minerai de mythril";
					}
					case 366:
					{
						return "Minerai d'adamantine";
					}
					case 367:
					{
						return "Pwnhammer";
					}
					case 368:
					{
						return "Excalibur";
					}
					case 369:
					{
						return "Graines sacrées";
					}
					case 370:
					{
						return "Bloc de sable d'ébène";
					}
					case 371:
					{
						return "Chapeau de cobalt";
					}
					case 372:
					{
						return "Casque de cobalt";
					}
					case 373:
					{
						return "Masque de cobalt";
					}
					case 374:
					{
						return "Plastron de cobalt";
					}
					case 375:
					{
						return "Jambières de cobalt";
					}
					case 376:
					{
						return "Capuche de mythril";
					}
					case 377:
					{
						return "Casque de mythril";
					}
					case 378:
					{
						return "Chapeau de mythril";
					}
					case 379:
					{
						return "Cotte de mailles de mythril";
					}
					case 380:
					{
						return "Jambières de mythril";
					}
					case 381:
					{
						return "Barre de cobalt";
					}
					case 382:
					{
						return "Barre de mythril";
					}
					case 383:
					{
						return "Tronçonneuse de cobalt";
					}
					case 384:
					{
						return "Tronçonneuse de mythril";
					}
					case 385:
					{
						return "Perceuse de cobalt";
					}
					case 386:
					{
						return "Perceuse de mythril";
					}
					case 387:
					{
						return "Tronçonneuse d'adamantine";
					}
					case 388:
					{
						return "Perceuse d'adamantine";
					}
					case 389:
					{
						return "Dao de Pow";
					}
					case 390:
					{
						return "Hallebarde de mythril";
					}
					case 391:
					{
						return "Barre d'amantine";
					}
					case 392:
					{
						return "Mur de verre";
					}
					case 393:
					{
						return "Boussole";
					}
					case 394:
					{
						return "Équipement de plongée";
					}
					case 395:
					{
						return "GPS";
					}
					case 396:
					{
						return "Fer à cheval d'obsidienne";
					}
					case 397:
					{
						return "Bouclier d'obsidienne";
					}
					case 398:
					{
						return "Atelier du bricoleur";
					}
					case 399:
					{
						return "Nuage dans un ballon";
					}
					case 400:
					{
						return "Coiffe d'adamantine";
					}
					case 401:
					{
						return "Casque d'adamantine";
					}
					case 402:
					{
						return "Masque d'adamantine";
					}
					case 403:
					{
						return "Plastron d'adamantine";
					}
					case 404:
					{
						return "Jambières en adamantine";
					}
					case 405:
					{
						return "Bottes spectrales";
					}
					case 406:
					{
						return "Glaive d'adamantine";
					}
					case 407:
					{
						return "Ceinture d'outils";
					}
					case 408:
					{
						return "Bloc de sable de perle";
					}
					case 409:
					{
						return "Bloc de pierre de perle";
					}
					case 410:
					{
						return "Veste de mineur";
					}
					case 411:
					{
						return "Pantalon de mineur";
					}
					case 412:
					{
						return "Brique de pierre de perle";
					}
					case 413:
					{
						return "Brique iridescente";
					}
					case 414:
					{
						return "Bloc de pierre de terre";
					}
					case 415:
					{
						return "Brique de cobalt";
					}
					case 416:
					{
						return "Brique de mythril";
					}
					case 417:
					{
						return "Mur de briques de pierre de perle";
					}
					case 418:
					{
						return "Mur de briques iridescentes";
					}
					case 419:
					{
						return "Mur de briques de pierre de terre";
					}
					case 420:
					{
						return "Mur de briques de cobalt";
					}
					case 421:
					{
						return "Mur de briques de mythril";
					}
					case 422:
					{
						return "Eau bénite";
					}
					case 423:
					{
						return "Eau impie";
					}
					case 424:
					{
						return "Bloc de limon";
					}
					case 425:
					{
						return "Clochette de fée";
					}
					case 426:
					{
						return "Lame du briseur";
					}
					case 427:
					{
						return "Torche bleue";
					}
					case 428:
					{
						return "Torche rouge";
					}
					case 429:
					{
						return "Torche verte";
					}
					case 430:
					{
						return "Torche violette";
					}
					case 431:
					{
						return "Torche blanche";
					}
					case 432:
					{
						return "Torche jaune";
					}
					case 433:
					{
						return "Torche du démon";
					}
					case 434:
					{
						return "Fusil d'assaut mécanique";
					}
					case 435:
					{
						return "Arbalète en cobalt";
					}
					case 436:
					{
						return "Arbalète en mythril";
					}
					case 437:
					{
						return "Crochet Double";
					}
					case 438:
					{
						return "Statue d'étoile";
					}
					case 439:
					{
						return "Statue d'épée";
					}
					case 440:
					{
						return "Statue de slime";
					}
					case 441:
					{
						return "Statue de gobelin";
					}
					case 442:
					{
						return "Statue de bouclier";
					}
					case 443:
					{
						return "Statue de chauve-souris";
					}
					case 444:
					{
						return "Statue de poisson";
					}
					case 445:
					{
						return "Statue de lapin";
					}
					case 446:
					{
						return "Statue de squelette";
					}
					case 447:
					{
						return "Statue de faucheur";
					}
					case 448:
					{
						return "Statue de femme";
					}
					case 449:
					{
						return "Statue de diablotin";
					}
					case 450:
					{
						return "Statue de gargouille";
					}
					case 451:
					{
						return "Statue de morosité";
					}
					case 452:
					{
						return "Statue de frelon";
					}
					case 453:
					{
						return "Statue de bombe";
					}
					case 454:
					{
						return "Statue de crabe";
					}
					case 455:
					{
						return "Statue de marteau";
					}
					case 456:
					{
						return "Statue de potion";
					}
					case 457:
					{
						return "Statue de lance";
					}
					case 458:
					{
						return "Statue de croix";
					}
					case 459:
					{
						return "Statue de méduse";
					}
					case 460:
					{
						return "Statue d'arc";
					}
					case 461:
					{
						return "Statue de boomerang";
					}
					case 462:
					{
						return "Statue de botte";
					}
					case 463:
					{
						return "Statue de coffre";
					}
					case 464:
					{
						return "Statue d'oiseau";
					}
					case 465:
					{
						return "Statue de hache";
					}
					case 466:
					{
						return "Statue corrompue";
					}
					case 467:
					{
						return "Statue d'arbre";
					}
					case 468:
					{
						return "Statue d'enclume";
					}
					case 469:
					{
						return "Statue de pioche";
					}
					case 470:
					{
						return "Statue de champignon";
					}
					case 471:
					{
						return "Statue d'œil";
					}
					case 472:
					{
						return "Statue de pilier";
					}
					case 473:
					{
						return "Statue de cœur";
					}
					case 474:
					{
						return "Statue de pot";
					}
					case 475:
					{
						return "Statue de tournesol";
					}
					case 476:
					{
						return "Statue de roi";
					}
					case 477:
					{
						return "Statue de reine";
					}
					case 478:
					{
						return "Statue de piranha";
					}
					case 479:
					{
						return "Mur de planches";
					}
					case 480:
					{
						return "Poutre de bois";
					}
					case 481:
					{
						return "Arbalète d'adamantine";
					}
					case 482:
					{
						return "Épée d'adamantine";
					}
					case 483:
					{
						return "Épée de cobalt";
					}
					case 484:
					{
						return "Épée de mythril";
					}
					case 485:
					{
						return "Sortilège lunaire";
					}
					case 486:
					{
						return "Règle";
					}
					case 487:
					{
						return "Boule de cristal";
					}
					case 488:
					{
						return "Boule à facettes";
					}
					case 489:
					{
						return "Emblème sorcier";
					}
					case 490:
					{
						return "Emblème guerrier";
					}
					case 491:
					{
						return "Emblème ranger";
					}
					case 492:
					{
						return "Ailes de démon";
					}
					case 493:
					{
						return "Ailes d'ange";
					}
					case 494:
					{
						return "Harpe magique";
					}
					case 495:
					{
						return "Bâton d'arc-en-ciel";
					}
					case 496:
					{
						return "Bâton de glace";
					}
					case 497:
					{
						return "Coquillage de Neptune";
					}
					case 498:
					{
						return "Mannequin";
					}
					case 499:
					{
						return "Potion de soins supérieure";
					}
					case 500:
					{
						return "Potion de mana supérieure";
					}
					case 501:
					{
						return "Poudre de fée";
					}
					case 502:
					{
						return "Éclat de cristal";
					}
					case 503:
					{
						return "Chapeau de clown";
					}
					case 504:
					{
						return "Veste de clown";
					}
					case 505:
					{
						return "Pantalon de clown";
					}
					case 506:
					{
						return "Lance-flammes";
					}
					case 507:
					{
						return "Cloche";
					}
					case 508:
					{
						return "Harpe";
					}
					case 509:
					{
						return "Clé à molette";
					}
					case 510:
					{
						return "Pince coupante";
					}
					case 511:
					{
						return "Bloc de pierre actif";
					}
					case 512:
					{
						return "Bloc de pierre inactif";
					}
					case 513:
					{
						return "Levier";
					}
					case 514:
					{
						return "Fusil laser";
					}
					case 515:
					{
						return "Balle de cristal";
					}
					case 516:
					{
						return "Flèche bénite";
					}
					case 517:
					{
						return "Dague magique";
					}
					case 518:
					{
						return "Tempête de cristal";
					}
					case 519:
					{
						return "Flammes maudites";
					}
					case 520:
					{
						return "Âme de lumière";
					}
					case 521:
					{
						return "Âme de la nuit";
					}
					case 522:
					{
						return "Flamme maudite";
					}
					case 523:
					{
						return "Torche maudite";
					}
					case 524:
					{
						return "Forge en adamantine";
					}
					case 525:
					{
						return "Enclume en mythril";
					}
					case 526:
					{
						return "Corne de licorne";
					}
					case 527:
					{
						return "Éclat sombre";
					}
					case 528:
					{
						return "Éclat de lumière";
					}
					case 529:
					{
						return "Plaque de pression rouge";
					}
					case 530:
					{
						return "Câble";
					}
					case 531:
					{
						return "Livre de sorts";
					}
					case 532:
					{
						return "Cape stellaire";
					}
					case 533:
					{
						return "Mégashark";
					}
					case 534:
					{
						return "Fusil à pompe";
					}
					case 535:
					{
						return "Pierre du philosophe";
					}
					case 536:
					{
						return "Gant du titan";
					}
					case 537:
					{
						return "Naginata en cobalt";
					}
					case 538:
					{
						return "Interrupteur";
					}
					case 539:
					{
						return "Piège à fléchette";
					}
					case 540:
					{
						return "Rocher";
					}
					case 541:
					{
						return "Plaque de pression verte";
					}
					case 542:
					{
						return "Plaque de pression grise";
					}
					case 543:
					{
						return "Plaque de pression marron";
					}
					case 544:
					{
						return "Œil mécanique";
					}
					case 545:
					{
						return "Flèche maudite";
					}
					case 546:
					{
						return "Balle maudite";
					}
					case 547:
					{
						return "Âme d'effroi";
					}
					case 548:
					{
						return "Âme de pouvoir";
					}
					case 549:
					{
						return "Âme de vision";
					}
					case 550:
					{
						return "Gungnir";
					}
					case 551:
					{
						return "Armure de plaques sacrée";
					}
					case 552:
					{
						return "Jambières sacrées";
					}
					case 553:
					{
						return "Casque sacré";
					}
					case 554:
					{
						return "Pendentif en croix";
					}
					case 555:
					{
						return "Fleur de mana";
					}
					case 556:
					{
						return "Ver mécanique";
					}
					case 557:
					{
						return "Crâne mécanique";
					}
					case 558:
					{
						return "Coiffe sacrée";
					}
					case 559:
					{
						return "Masque sacré";
					}
					case 560:
					{
						return "Couronne de slime";
					}
					case 561:
					{
						return "Disque de lumière";
					}
					case 562:
					{
						return "Boîte à musique (Jour du monde supérieur)";
					}
					case 563:
					{
						return "Boîte à musique (Surnaturel)";
					}
					case 564:
					{
						return "Boîte à musique (Nuit)";
					}
					case 565:
					{
						return "Boîte à musique (Titre)";
					}
					case 566:
					{
						return "Boîte à musique (Souterrain)";
					}
					case 567:
					{
						return "Boîte à musique (Boss 1)";
					}
					case 568:
					{
						return "Boîte à musique (Jungle)";
					}
					case 569:
					{
						return "Boîte à musique(Corruption)";
					}
					case 570:
					{
						return "Boîte à musique (Corruption du souterrain)";
					}
					case 571:
					{
						return "Boîte à musique (La purification)";
					}
					case 572:
					{
						return "Boîte à musique (Boss 2)";
					}
					case 573:
					{
						return "Boîte à musique (Purification du souterrain)";
					}
					case 574:
					{
						return "Boîte à musique (Boss 3)";
					}
					case 575:
					{
						return "Âme du vol";
					}
					case 576:
					{
						return "Boîte à musique";
					}
					case 577:
					{
						return "Brique de démonite";
					}
					case 578:
					{
						return "Arbalète bénie";
					}
					case 579:
					{
						return "Hâche-marteau";
					}
					case 580:
					{
						return "Explosifs";
					}
					case 581:
					{
						return "Poste de pompage";
					}
					case 582:
					{
						return "Sortie de pompage";
					}
					case 583:
					{
						return "Minuteur d'une seconde";
					}
					case 584:
					{
						return "Minuteur de 3 secondes";
					}
					case 585:
					{
						return "Minuteur de 5 secondes";
					}
					case 586:
					{
						return "Bloc Candy Cane";
					}
					case 587:
					{
						return "Candy Cane mur";
					}
					case 588:
					{
						return "Santa Hat";
					}
					case 589:
					{
						return "Père shirt";
					}
					case 590:
					{
						return "Pantalon de Santa";
					}
					case 591:
					{
						return "Bloc vert Candy Cane";
					}
					case 592:
					{
						return "Vert Candy Cane mur";
					}
					case 593:
					{
						return "neige bloc";
					}
					case 594:
					{
						return "brique de neige";
					}
					case 595:
					{
						return "Mur de briques de neige";
					}
					case 596:
					{
						return "Blue Light";
					}
					case 597:
					{
						return "Red Light";
					}
					case 598:
					{
						return "Green Light";
					}
					case 599:
					{
						return "présent Bleu";
					}
					case 600:
					{
						return "présent vert";
					}
					case 601:
					{
						return "présent jaune";
					}
					case 602:
					{
						return "Globe de neige";
					}
					case 603:
					{
						return "Carotte";
					}
					default:
					{
						switch (num2)
						{
							case 3480:
							{
								return "Platinum Bow";
							}
							case 3481:
							{
								return "Platinum Hammer";
							}
							case 3482:
							{
								return "Platinum Axe";
							}
							case 3483:
							{
								return "Platinum Shortsword";
							}
							case 3484:
							{
								return "Platinum Broadsword";
							}
							case 3485:
							{
								return "Platinum Pickaxe";
							}
							case 3486:
							{
								return "Tungsten Bow";
							}
							case 3487:
							{
								return "Tungsten Hammer";
							}
							case 3488:
							{
								return "Tungsten Axe";
							}
							case 3489:
							{
								return "Tungsten Shortsword";
							}
							case 3490:
							{
								return "Tungsten Broadsword";
							}
							case 3491:
							{
								return "Tungsten Pickaxe";
							}
							case 3492:
							{
								return "Lead Bow";
							}
							case 3493:
							{
								return "Lead Hammer";
							}
							case 3494:
							{
								return "Lead Axe";
							}
							case 3495:
							{
								return "Lead Shortsword";
							}
							case 3496:
							{
								return "Lead Broadsword";
							}
							case 3497:
							{
								return "Lead Pickaxe";
							}
							case 3498:
							{
								return "Tin Bow";
							}
							case 3499:
							{
								return "Tin Hammer";
							}
							case 3500:
							{
								return "Tin Axe";
							}
							case 3501:
							{
								return "Tin Shortsword";
							}
							case 3502:
							{
								return "Tin Broadsword";
							}
							case 3503:
							{
								return "Tin Pickaxe";
							}
							case 3504:
							{
								return "Arc en cuivre";
							}
							case 3505:
							{
								return "Marteau en cuivre";
							}
							case 3506:
							{
								return "Hache en cuivre";
							}
							case 3507:
							{
								return "Épée courte en cuivre";
							}
							case 3508:
							{
								return "Épée longue en cuivre";
							}
							case 3509:
							{
								return "Pioche en cuivre";
							}
							case 3510:
							{
								return "Arc en argent";
							}
							case 3511:
							{
								return "Marteau en argent";
							}
							case 3512:
							{
								return "Hache en argent";
							}
							case 3513:
							{
								return "Épée courte en argent";
							}
							case 3514:
							{
								return "Épée longue en argent";
							}
							case 3515:
							{
								return "Pioche en argent";
							}
							case 3516:
							{
								return "Arc en or";
							}
							case 3517:
							{
								return "Marteau en or";
							}
							case 3518:
							{
								return "Hache en or";
							}
							case 3519:
							{
								return "Épée courte en or";
							}
							case 3520:
							{
								return "Épée longue en or";
							}
							case 3521:
							{
								return "Pioche en or";
							}
						}
						break;
					}
				}
			}
			else if (Lang.lang == 5)
			{
				int num3 = l;
				switch (num3)
				{
					case -24:
					{
						return "Sable de luz amarillo";
					}
					case -23:
					{
						return "Sable de luz blanco";
					}
					case -22:
					{
						return "Sable de luz morado";
					}
					case -21:
					{
						return "Sable de luz verde";
					}
					case -20:
					{
						return "Sable de luz rojo";
					}
					case -19:
					{
						return "Sable de luz azul";
					}
					case -18:
					{
						return "Arco de cobre";
					}
					case -17:
					{
						return "Martillo de cobre";
					}
					case -16:
					{
						return "Hacha de cobre";
					}
					case -15:
					{
						return "Espada corta de cobre";
					}
					case -14:
					{
						return "Espada larga de cobre";
					}
					case -13:
					{
						return "Pico de cobre";
					}
					case -12:
					{
						return "Arco de plata";
					}
					case -11:
					{
						return "Martillo de plata";
					}
					case -10:
					{
						return "Hacha de plata";
					}
					case -9:
					{
						return "Espada corta de plata";
					}
					case -8:
					{
						return "Espada larga de plata";
					}
					case -7:
					{
						return "Pico de plata";
					}
					case -6:
					{
						return "Arco de oro";
					}
					case -5:
					{
						return "Martillo de oro";
					}
					case -4:
					{
						return "Hacha de oro";
					}
					case -3:
					{
						return "Espada corta de oro";
					}
					case -2:
					{
						return "Espada larga de oro";
					}
					case -1:
					{
						return "Pico de oro";
					}
					case 0:
					{
						break;
					}
					case 1:
					{
						return "Pico de hierro";
					}
					case 2:
					{
						return "Bloque de tierra";
					}
					case 3:
					{
						return "Bloque de piedra";
					}
					case 4:
					{
						return "Espada larga de hierro";
					}
					case 5:
					{
						return "Champiñón";
					}
					case 6:
					{
						return "Espada corta de hierro";
					}
					case 7:
					{
						return "Martillo de hierro";
					}
					case 8:
					{
						return "Antorcha";
					}
					case 9:
					{
						return "Madera";
					}
					case 10:
					{
						return "Hacha de hierro";
					}
					case 11:
					{
						return "Mineral de hierro";
					}
					case 12:
					{
						return "Mineral de cobre";
					}
					case 13:
					{
						return "Mineral de oro";
					}
					case 14:
					{
						return "Mineral de plata";
					}
					case 15:
					{
						return "Reloj de cobre";
					}
					case 16:
					{
						return "Reloj de plata";
					}
					case 17:
					{
						return "Reloj de oro";
					}
					case 18:
					{
						return "Medidor de profundidad";
					}
					case 19:
					{
						return "Lingote de oro";
					}
					case 20:
					{
						return "Lingote de cobre";
					}
					case 21:
					{
						return "Lingote de plata";
					}
					case 22:
					{
						return "Lingote de hierro";
					}
					case 23:
					{
						return "Baba";
					}
					case 24:
					{
						return "Espada de madera";
					}
					case 25:
					{
						return "Puerta de madera";
					}
					case 26:
					{
						return "Pared de piedra";
					}
					case 27:
					{
						return "Bellota";
					}
					case 28:
					{
						return "Poción curativa menor";
					}
					case 29:
					{
						return "Cristal de vida";
					}
					case 30:
					{
						return "Pared de tierra";
					}
					case 31:
					{
						return "Botella";
					}
					case 32:
					{
						return "Mesa de madera";
					}
					case 33:
					{
						return "Horno";
					}
					case 34:
					{
						return "Silla de madera";
					}
					case 35:
					{
						return "Yunque de hierro";
					}
					case 36:
					{
						return "Banco de trabajo";
					}
					case 37:
					{
						return "Gafas de protección";
					}
					case 38:
					{
						return "Lentes";
					}
					case 39:
					{
						return "Arco de madera";
					}
					case 40:
					{
						return "Flecha de madera";
					}
					case 41:
					{
						return "Flecha ardiente";
					}
					case 42:
					{
						return "Cuchillas ninja";
					}
					case 43:
					{
						return "Ojo de mirada desconfiada";
					}
					case 44:
					{
						return "Arco demoníaco";
					}
					case 45:
					{
						return "Hacha de la noche";
					}
					case 46:
					{
						return "Espada de la luz";
					}
					case 47:
					{
						return "Flecha infame";
					}
					case 48:
					{
						return "Cofre";
					}
					case 49:
					{
						return "Banda de regeneración";
					}
					case 50:
					{
						return "Espejo mágico";
					}
					case 51:
					{
						return "Flecha de bufón";
					}
					case 52:
					{
						return "Estatua de ángel";
					}
					case 53:
					{
						return "Nube embotellada";
					}
					case 54:
					{
						return "Botas de Hermes";
					}
					case 55:
					{
						return "Bumerán encantado";
					}
					case 56:
					{
						return "Mineral endemoniado";
					}
					case 57:
					{
						return "Lingote endemoniado";
					}
					case 58:
					{
						return "Corazón";
					}
					case 59:
					{
						return "Semillas corrompidas";
					}
					case 60:
					{
						return "Champiñón vil";
					}
					case 61:
					{
						return "Bloque de piedra de ébano";
					}
					case 62:
					{
						return "Semillas de césped";
					}
					case 63:
					{
						return "Girasol";
					}
					case 64:
					{
						return "Lanzador de espina vil";
					}
					case 65:
					{
						return "Furia de estrellas";
					}
					case 66:
					{
						return "Polvo de purificación";
					}
					case 67:
					{
						return "Polvo vil";
					}
					case 68:
					{
						return "Trozo podrido";
					}
					case 69:
					{
						return "Diente de gusano";
					}
					case 70:
					{
						return "Cebo de gusanos";
					}
					case 71:
					{
						return "Moneda de cobre";
					}
					case 72:
					{
						return "Moneda de plata";
					}
					case 73:
					{
						return "Moneda de oro";
					}
					case 74:
					{
						return "Moneda de platino";
					}
					case 75:
					{
						return "Estrella caída";
					}
					case 76:
					{
						return "Grebas de cobre";
					}
					case 77:
					{
						return "Grebas de hierro";
					}
					case 78:
					{
						return "Grebas de plata";
					}
					case 79:
					{
						return "Grebas de oro";
					}
					case 80:
					{
						return "Cota de malla de cobre";
					}
					case 81:
					{
						return "Cota de malla de hierro";
					}
					case 82:
					{
						return "Cota de malla de plata";
					}
					case 83:
					{
						return "Cota de malla de oro";
					}
					case 84:
					{
						return "Garfio extensible";
					}
					case 85:
					{
						return "Cadena de hierro";
					}
					case 86:
					{
						return "Escama de las sombras";
					}
					case 87:
					{
						return "Hucha";
					}
					case 88:
					{
						return "Casco de minero";
					}
					case 89:
					{
						return "Casco de cobre";
					}
					case 90:
					{
						return "Casco de hierro";
					}
					case 91:
					{
						return "Casco de plata";
					}
					case 92:
					{
						return "Casco de oro";
					}
					case 93:
					{
						return "Pared de madera";
					}
					case 94:
					{
						return "Plataforma de madera";
					}
					case 95:
					{
						return "Pistola de pedernal";
					}
					case 96:
					{
						return "Mosquetón";
					}
					case 97:
					{
						return "Bala de mosquetón";
					}
					case 98:
					{
						return "Minitiburón";
					}
					case 99:
					{
						return "Arco de hierro";
					}
					case 100:
					{
						return "Grebas de las sombras";
					}
					case 101:
					{
						return "Cota de escamas de las sombras";
					}
					case 102:
					{
						return "Casco de las sombras";
					}
					case 103:
					{
						return "Pico de pesadilla";
					}
					case 104:
					{
						return "La despedazadora";
					}
					case 105:
					{
						return "Vela";
					}
					case 106:
					{
						return "Lámpara araña de cobre";
					}
					case 107:
					{
						return "Lámpara araña de plata";
					}
					case 108:
					{
						return "Lámpara araña de oro";
					}
					case 109:
					{
						return "Cristal de maná";
					}
					case 110:
					{
						return "Poción de maná menor";
					}
					case 111:
					{
						return "Banda de polvo de estrellas";
					}
					case 112:
					{
						return "Flor de fuego";
					}
					case 113:
					{
						return "Misil mágico";
					}
					case 114:
					{
						return "Varita de tierra";
					}
					case 115:
					{
						return "Orbe de Luz";
					}
					case 116:
					{
						return "Meteorito";
					}
					case 117:
					{
						return "Lingote de meteorito";
					}
					case 118:
					{
						return "Garfio";
					}
					case 119:
					{
						return "Bumerán de llamas";
					}
					case 120:
					{
						return "Furia fundida";
					}
					case 121:
					{
						return "Gran espada ardiente";
					}
					case 122:
					{
						return "Pico fundido";
					}
					case 123:
					{
						return "Casco de meteorito";
					}
					case 124:
					{
						return "Cota de meteorito";
					}
					case 125:
					{
						return "Polainas de meteoritos";
					}
					case 126:
					{
						return "Agua embotellada";
					}
					case 127:
					{
						return "Espacio de arma de fuego";
					}
					case 128:
					{
						return "Botas cohete";
					}
					case 129:
					{
						return "Ladrillo gris";
					}
					case 130:
					{
						return "Pared de ladrillo gris";
					}
					case 131:
					{
						return "Ladrillo rojo";
					}
					case 132:
					{
						return "Pared de ladrillo rojo";
					}
					case 133:
					{
						return "Bloque de arcilla";
					}
					case 134:
					{
						return "Ladrillo azul";
					}
					case 135:
					{
						return "Pared de ladrillo azul";
					}
					case 136:
					{
						return "Farolillo";
					}
					case 137:
					{
						return "Ladrillo verde";
					}
					case 138:
					{
						return "Pared de ladrillo verde";
					}
					case 139:
					{
						return "Ladrillo rosa";
					}
					case 140:
					{
						return "Pared de ladrillo rosa";
					}
					case 141:
					{
						return "Ladrillo dorado";
					}
					case 142:
					{
						return "Pared de ladrillo dorado";
					}
					case 143:
					{
						return "Ladrillo plateado";
					}
					case 144:
					{
						return "Pared de ladrillo plateado";
					}
					case 145:
					{
						return "Ladrillo cobrizo";
					}
					case 146:
					{
						return "Pared de ladrillo cobrizo";
					}
					case 147:
					{
						return "Púa";
					}
					case 148:
					{
						return "Vela de agua";
					}
					case 149:
					{
						return "Libro";
					}
					case 150:
					{
						return "Telaraña";
					}
					case 151:
					{
						return "Casco de los muertos";
					}
					case 152:
					{
						return "Peto de los muertos";
					}
					case 153:
					{
						return "Grebas de los muertos";
					}
					case 154:
					{
						return "Hueso";
					}
					case 155:
					{
						return "Catana Muramasa";
					}
					case 156:
					{
						return "Escudo de cobalto";
					}
					case 157:
					{
						return "Cetro de agua";
					}
					case 158:
					{
						return "Herradura de la suerte";
					}
					case 159:
					{
						return "Globo rojo brillante";
					}
					case 160:
					{
						return "Arpón";
					}
					case 161:
					{
						return "Bola con pinchos";
					}
					case 162:
					{
						return "Flagelo con bola";
					}
					case 163:
					{
						return "Luna azul";
					}
					case 164:
					{
						return "Pistola";
					}
					case 165:
					{
						return "Rayo de agua";
					}
					case 166:
					{
						return "Bomba";
					}
					case 167:
					{
						return "Dinamita";
					}
					case 168:
					{
						return "Granada";
					}
					case 169:
					{
						return "Bloque de arena";
					}
					case 170:
					{
						return "Cristal";
					}
					case 171:
					{
						return "Cartel";
					}
					case 172:
					{
						return "Bloque de ceniza";
					}
					case 173:
					{
						return "Obsidiana";
					}
					case 174:
					{
						return "Piedra infernal";
					}
					case 175:
					{
						return "Lingote de piedra infernal";
					}
					case 176:
					{
						return "Bloque de lodo";
					}
					case 177:
					{
						return "Zafiro";
					}
					case 178:
					{
						return "Rubí";
					}
					case 179:
					{
						return "Esmeralda";
					}
					case 180:
					{
						return "Topacio";
					}
					case 181:
					{
						return "Amatista";
					}
					case 182:
					{
						return "Diamante";
					}
					case 183:
					{
						return "Champiñón brillante";
					}
					case 184:
					{
						return "Estrella";
					}
					case 185:
					{
						return "Látigo de hiedra";
					}
					case 186:
					{
						return "Caña para respirar";
					}
					case 187:
					{
						return "Aletas";
					}
					case 188:
					{
						return "Poción curativa";
					}
					case 189:
					{
						return "Poción de maná";
					}
					case 190:
					{
						return "Espada de hierba";
					}
					case 191:
					{
						return "Chakram de espinas";
					}
					case 192:
					{
						return "Ladrillo de obsidiana";
					}
					case 193:
					{
						return "Cráneo de obsidiana";
					}
					case 194:
					{
						return "Semillas de césped para champiñón";
					}
					case 195:
					{
						return "Semillas de césped para selva";
					}
					case 196:
					{
						return "Martillo de madera";
					}
					case 197:
					{
						return "Cañón de estrellas";
					}
					case 198:
					{
						return "Espada de luz azul";
					}
					case 199:
					{
						return "Espada de luz roja";
					}
					case 200:
					{
						return "Espada de luz verde";
					}
					case 201:
					{
						return "Espada de luz morada";
					}
					case 202:
					{
						return "Espada de luz blanca";
					}
					case 203:
					{
						return "Espada de luz amarilla";
					}
					case 204:
					{
						return "Hacha-martillo de meteorito";
					}
					case 205:
					{
						return "Cubo vacío";
					}
					case 206:
					{
						return "Cubo de agua";
					}
					case 207:
					{
						return "Cubo de lava";
					}
					case 208:
					{
						return "Rosa de la selva";
					}
					case 209:
					{
						return "Aguijón";
					}
					case 210:
					{
						return "Enredadera";
					}
					case 211:
					{
						return "Garras de bestia";
					}
					case 212:
					{
						return "Tobillera de viento";
					}
					case 213:
					{
						return "Báculo de regeneración";
					}
					case 214:
					{
						return "Ladrillo de piedra infernal";
					}
					case 215:
					{
						return "Cojín flatulento";
					}
					case 216:
					{
						return "Argolla";
					}
					case 217:
					{
						return "Hacha-martillo fundido";
					}
					case 218:
					{
						return "Látigo de llamas";
					}
					case 219:
					{
						return "Desintegrador Fénix";
					}
					case 220:
					{
						return "Furia solar";
					}
					case 221:
					{
						return "Forjas infernal";
					}
					case 222:
					{
						return "Marmita de arcilla";
					}
					case 223:
					{
						return "Don de la naturaleza";
					}
					case 224:
					{
						return "Cama";
					}
					case 225:
					{
						return "Seda";
					}
					case 226:
					{
						return "Poción de recuperación menor";
					}
					case 227:
					{
						return "Poción de recuperación";
					}
					case 228:
					{
						return "Casco para la selva";
					}
					case 229:
					{
						return "Camisa para la selva";
					}
					case 230:
					{
						return "Pantalones para la selva";
					}
					case 231:
					{
						return "Casco fundido";
					}
					case 232:
					{
						return "Peto fundido";
					}
					case 233:
					{
						return "Grebas fundidas";
					}
					case 234:
					{
						return "proyectil de meteorito";
					}
					case 235:
					{
						return "Bomba lapa";
					}
					case 236:
					{
						return "Lentes negras";
					}
					case 237:
					{
						return "Gafas de sol";
					}
					case 238:
					{
						return "Sombrero de mago";
					}
					case 239:
					{
						return "Sombrero de copa";
					}
					case 240:
					{
						return "Camisa de esmoquin";
					}
					case 241:
					{
						return "Pantalones de esmoquin";
					}
					case 242:
					{
						return "Sombrero veraniego";
					}
					case 243:
					{
						return "Máscara de conejito";
					}
					case 244:
					{
						return "Gorra de fontanero";
					}
					case 245:
					{
						return "Camisa de fontanero";
					}
					case 246:
					{
						return "Pantalones de fontanero";
					}
					case 247:
					{
						return "Gorro de héroe";
					}
					case 248:
					{
						return "Camisa de héroe";
					}
					case 249:
					{
						return "Pantalones de héroe";
					}
					case 250:
					{
						return "Pecera";
					}
					case 251:
					{
						return "Sombrero de arqueólogo";
					}
					case 252:
					{
						return "Chaqueta de arqueólogo";
					}
					case 253:
					{
						return "Pantalones de arqueólogo";
					}
					case 254:
					{
						return "Tinte negro";
					}
					case 255:
					{
						return "Tinte verde";
					}
					case 256:
					{
						return "Gorro de ninja";
					}
					case 257:
					{
						return "Camisa de ninja";
					}
					case 258:
					{
						return "Pantalones de ninja";
					}
					case 259:
					{
						return "Cuero";
					}
					case 260:
					{
						return "Sombrero rojo";
					}
					case 261:
					{
						return "Pececillo";
					}
					case 262:
					{
						return "Vestido";
					}
					case 263:
					{
						return "Sombrero de robot";
					}
					case 264:
					{
						return "Corona de oro";
					}
					case 265:
					{
						return "Flecha de fuego infernal";
					}
					case 266:
					{
						return "Pistola de arena";
					}
					case 267:
					{
						return "Muñeco vudú del Guía";
					}
					case 268:
					{
						return "Casco de buceo";
					}
					case 269:
					{
						return "Camisa informal";
					}
					case 270:
					{
						return "Pantalones informales";
					}
					case 271:
					{
						return "Peluca informal";
					}
					case 272:
					{
						return "Guadaña demoníaca";
					}
					case 273:
					{
						return "Espada de la noche";
					}
					case 274:
					{
						return "Lanza de la oscuridad";
					}
					case 275:
					{
						return "Coral";
					}
					case 276:
					{
						return "Cactus";
					}
					case 277:
					{
						return "Tridente";
					}
					case 278:
					{
						return "Bala de plata";
					}
					case 279:
					{
						return "Cuchillo arrojadizo";
					}
					case 280:
					{
						return "Lanza";
					}
					case 281:
					{
						return "Cerbatana";
					}
					case 282:
					{
						return "Barrita luminosa";
					}
					case 283:
					{
						return "Semilla";
					}
					case 284:
					{
						return "Bumerán de madera";
					}
					case 285:
					{
						return "Herrete";
					}
					case 286:
					{
						return "Barrita luminosa lapa";
					}
					case 287:
					{
						return "Cuchillo envenenado";
					}
					case 288:
					{
						return "Poción de piel obsidiana";
					}
					case 289:
					{
						return "Poción de regeneración";
					}
					case 290:
					{
						return "Poción de rapidez";
					}
					case 291:
					{
						return "Poción de agallas";
					}
					case 292:
					{
						return "Poción de piel de hierro";
					}
					case 293:
					{
						return "Poción de regeneración de maná";
					}
					case 294:
					{
						return "Poción de poder mágico";
					}
					case 295:
					{
						return "Poción de caída de pluma";
					}
					case 296:
					{
						return "Poción de espeleólogo";
					}
					case 297:
					{
						return "Poción de invisibilidad";
					}
					case 298:
					{
						return "Poción de brillo";
					}
					case 299:
					{
						return "Poción de noctámbulo";
					}
					case 300:
					{
						return "Poción de batalla";
					}
					case 301:
					{
						return "Poción de espinas";
					}
					case 302:
					{
						return "Poción caminando sobre el agua";
					}
					case 303:
					{
						return "Poción de tiro con arco";
					}
					case 304:
					{
						return "Poción de cazador";
					}
					case 305:
					{
						return "Poción de gravedad";
					}
					case 306:
					{
						return "Cofre de oro";
					}
					case 307:
					{
						return "Semillas de resplandor del día";
					}
					case 308:
					{
						return "Semillas de luz de luna";
					}
					case 309:
					{
						return "Semillas de raíz de resplandor";
					}
					case 310:
					{
						return "Semillas de malahierba";
					}
					case 311:
					{
						return "Semillas de hoja de agua";
					}
					case 312:
					{
						return "Semillas de resplandor de fuego";
					}
					case 313:
					{
						return "Resplandor del día";
					}
					case 314:
					{
						return "Luz de luna";
					}
					case 315:
					{
						return "Raíz de resplandor";
					}
					case 316:
					{
						return "Malahierba";
					}
					case 317:
					{
						return "Hoja de agua";
					}
					case 318:
					{
						return "Resplandor de fuego";
					}
					case 319:
					{
						return "Aleta de tiburón";
					}
					case 320:
					{
						return "Pluma";
					}
					case 321:
					{
						return "Lápida";
					}
					case 322:
					{
						return "Máscara de mimo";
					}
					case 323:
					{
						return "Mandíbula de hormiga león";
					}
					case 324:
					{
						return "Accesorios de arma ilegales";
					}
					case 325:
					{
						return "Camisa del doctor";
					}
					case 326:
					{
						return "Pantalones del doctor";
					}
					case 327:
					{
						return "Llave dorada";
					}
					case 328:
					{
						return "Cofre de las sombras";
					}
					case 329:
					{
						return "Llave de las sombras";
					}
					case 330:
					{
						return "Pared de ladrillo de obsidiana";
					}
					case 331:
					{
						return "Esporas de la selva";
					}
					case 332:
					{
						return "Telar";
					}
					case 333:
					{
						return "Piano";
					}
					case 334:
					{
						return "Aparador";
					}
					case 335:
					{
						return "Banco";
					}
					case 336:
					{
						return "Bañera";
					}
					case 337:
					{
						return "Estandarte rojo";
					}
					case 338:
					{
						return "Estandarte verde";
					}
					case 339:
					{
						return "Estandarte azul";
					}
					case 340:
					{
						return "Estandarte amarillo";
					}
					case 341:
					{
						return "Farola";
					}
					case 342:
					{
						return "Antorcha Tiki";
					}
					case 343:
					{
						return "Barril";
					}
					case 344:
					{
						return "Farolillo de papel";
					}
					case 345:
					{
						return "Perol";
					}
					case 346:
					{
						return "Caja fuerte";
					}
					case 347:
					{
						return "Cráneo con vela";
					}
					case 348:
					{
						return "Cubo de basura";
					}
					case 349:
					{
						return "Candelabro";
					}
					case 350:
					{
						return "Probeta rosa";
					}
					case 351:
					{
						return "Taza";
					}
					case 352:
					{
						return "Barrica";
					}
					case 353:
					{
						return "Cerveza";
					}
					case 354:
					{
						return "Librería";
					}
					case 355:
					{
						return "Trono";
					}
					case 356:
					{
						return "Cuenco";
					}
					case 357:
					{
						return "Cuenco de sopa";
					}
					case 358:
					{
						return "Retrete";
					}
					case 359:
					{
						return "Reloj de pie";
					}
					case 360:
					{
						return "Estatua de armadura";
					}
					case 361:
					{
						return "Batalla de duendes convencional";
					}
					case 362:
					{
						return "Harapos";
					}
					case 363:
					{
						return "Serrería";
					}
					case 364:
					{
						return "Mineral de cobalto";
					}
					case 365:
					{
						return "Mineral de mithril";
					}
					case 366:
					{
						return "Mineral de adamantita";
					}
					case 367:
					{
						return "Gran martillo";
					}
					case 368:
					{
						return "Excalibur";
					}
					case 369:
					{
						return "Semillas bendecidas";
					}
					case 370:
					{
						return "Bloque de arena de ébano";
					}
					case 371:
					{
						return "Gorro de cobalto";
					}
					case 372:
					{
						return "Casco de cobalto";
					}
					case 373:
					{
						return "Máscara de cobalto";
					}
					case 374:
					{
						return "Peto de cobalto";
					}
					case 375:
					{
						return "Polainas de cobalto";
					}
					case 376:
					{
						return "Caperuza de mithril";
					}
					case 377:
					{
						return "Casco de mithril";
					}
					case 378:
					{
						return "Gorro de mithril";
					}
					case 379:
					{
						return "Cota de malla de mithril";
					}
					case 380:
					{
						return "Grebas de mithril";
					}
					case 381:
					{
						return "Lingote de cobalto";
					}
					case 382:
					{
						return "Lingote de mithril";
					}
					case 383:
					{
						return "Motosierra de cobalto";
					}
					case 384:
					{
						return "Motosierra de mithril";
					}
					case 385:
					{
						return "Taladro de cobalto";
					}
					case 386:
					{
						return "Taladro de mithril";
					}
					case 387:
					{
						return "Motosierra de adamantita";
					}
					case 388:
					{
						return "Taladro de adamantita";
					}
					case 389:
					{
						return "Flagelo Taoísta";
					}
					case 390:
					{
						return "Alabarda de mithril";
					}
					case 391:
					{
						return "Lingote de adamantita";
					}
					case 392:
					{
						return "Cristal de pared";
					}
					case 393:
					{
						return "Brújula";
					}
					case 394:
					{
						return "Equipo de buceo";
					}
					case 395:
					{
						return "GPS";
					}
					case 396:
					{
						return "Herradura de obsidiana";
					}
					case 397:
					{
						return "Escudo de obsidiana";
					}
					case 398:
					{
						return "Taller del reparador";
					}
					case 399:
					{
						return "Globo de nube";
					}
					case 400:
					{
						return "Tocado de adamantita";
					}
					case 401:
					{
						return "Casco de adamantita";
					}
					case 402:
					{
						return "Máscara de adamantita";
					}
					case 403:
					{
						return "Peto de adamantita";
					}
					case 404:
					{
						return "Polainas de adamantita";
					}
					case 405:
					{
						return "Botas de espectro";
					}
					case 406:
					{
						return "Lanza de adamantita";
					}
					case 407:
					{
						return "Cinturón de herramientas";
					}
					case 408:
					{
						return "Bloque de arena de perla";
					}
					case 409:
					{
						return "Bloque de piedra perlada";
					}
					case 410:
					{
						return "Camisa de minero";
					}
					case 411:
					{
						return "Pantalones de minero";
					}
					case 412:
					{
						return "Ladrillo de piedra perlada";
					}
					case 413:
					{
						return "Ladrillo tornasol";
					}
					case 414:
					{
						return "Bloque de lutita";
					}
					case 415:
					{
						return "Ladrillo de cobalto";
					}
					case 416:
					{
						return "Ladrillo de mithril";
					}
					case 417:
					{
						return "Pared de ladrillo de piedra perlada";
					}
					case 418:
					{
						return "Pared de ladrillo tornasol";
					}
					case 419:
					{
						return "Pared de ladrillo de lutita";
					}
					case 420:
					{
						return "Pared de ladrillo de cobalto";
					}
					case 421:
					{
						return "Pared de ladrillo de mithril";
					}
					case 422:
					{
						return "Agua sagrada";
					}
					case 423:
					{
						return "Agua impura";
					}
					case 424:
					{
						return "Bloque de limo";
					}
					case 425:
					{
						return "Campana de hada";
					}
					case 426:
					{
						return "Espada despedazadora";
					}
					case 427:
					{
						return "Antorcha azul";
					}
					case 428:
					{
						return "Antorcha rojo";
					}
					case 429:
					{
						return "Antorcha verde";
					}
					case 430:
					{
						return "Antorcha morada";
					}
					case 431:
					{
						return "Antorcha blanca";
					}
					case 432:
					{
						return "Antorcha amarilla";
					}
					case 433:
					{
						return "Antorcha demoníaca";
					}
					case 434:
					{
						return "Fusil de asalto de precisión";
					}
					case 435:
					{
						return "Repetidor de cobalto";
					}
					case 436:
					{
						return "Repetidor de mithril";
					}
					case 437:
					{
						return "Gancho doble";
					}
					case 438:
					{
						return "Estatua de estrella";
					}
					case 439:
					{
						return "Estatua de espada";
					}
					case 440:
					{
						return "Estatua de babosa";
					}
					case 441:
					{
						return "Estatua de duende";
					}
					case 442:
					{
						return "Estatua de escudo";
					}
					case 443:
					{
						return "Estatua de murciélago";
					}
					case 444:
					{
						return "Estatua de pez";
					}
					case 445:
					{
						return "Estatua de conejito";
					}
					case 446:
					{
						return "Estatua de esqueleto";
					}
					case 447:
					{
						return "Estatua de la Muerte";
					}
					case 448:
					{
						return "Estatua de mujer";
					}
					case 449:
					{
						return "Estatua de diablillo";
					}
					case 450:
					{
						return "Estatua de gárgola";
					}
					case 451:
					{
						return "Estatua de Melancolía";
					}
					case 452:
					{
						return "Estatua de avispón";
					}
					case 453:
					{
						return "Estatua de bomba";
					}
					case 454:
					{
						return "Estatua de cangrejo";
					}
					case 455:
					{
						return "Estatua de martilla";
					}
					case 456:
					{
						return "Estatua de poción";
					}
					case 457:
					{
						return "Estatua de lanza";
					}
					case 458:
					{
						return "Estatua de cruz";
					}
					case 459:
					{
						return "Estatua de medusa";
					}
					case 460:
					{
						return "Estatua de arco";
					}
					case 461:
					{
						return "Estatua de bumerán";
					}
					case 462:
					{
						return "Estatua de bota";
					}
					case 463:
					{
						return "Estatua de cofre";
					}
					case 464:
					{
						return "Estatua de pájaro";
					}
					case 465:
					{
						return "Estatua de hacha";
					}
					case 466:
					{
						return "Estatua de corrupción";
					}
					case 467:
					{
						return "Estatua de árbol";
					}
					case 468:
					{
						return "Estatua de yunque";
					}
					case 469:
					{
						return "Estatua de pico";
					}
					case 470:
					{
						return "Estatua de champiñón";
					}
					case 471:
					{
						return "Estatua de ojo";
					}
					case 472:
					{
						return "Estatua de columna";
					}
					case 473:
					{
						return "Estatua de corazón";
					}
					case 474:
					{
						return "Estatua de marmita";
					}
					case 475:
					{
						return "Estatua de girasol";
					}
					case 476:
					{
						return "Estatua de rey";
					}
					case 477:
					{
						return "Estatua de reina";
					}
					case 478:
					{
						return "Estatua de piraña";
					}
					case 479:
					{
						return "Pared de tablones";
					}
					case 480:
					{
						return "Viga de madera";
					}
					case 481:
					{
						return "Repetidor de adamantita";
					}
					case 482:
					{
						return "Espada de adamantita";
					}
					case 483:
					{
						return "Espada de cobalto";
					}
					case 484:
					{
						return "Espada de mithril";
					}
					case 485:
					{
						return "Hechizo de luna";
					}
					case 486:
					{
						return "Regla";
					}
					case 487:
					{
						return "Bola de cristal";
					}
					case 488:
					{
						return "Bola de discoteca";
					}
					case 489:
					{
						return "Emblema de hechicero";
					}
					case 490:
					{
						return "Emblema de guerrero";
					}
					case 491:
					{
						return "Emblema de guardián";
					}
					case 492:
					{
						return "Alas demoníacas";
					}
					case 493:
					{
						return "Alas de ángel";
					}
					case 494:
					{
						return "Arpa mágica";
					}
					case 495:
					{
						return "Varita multicolor";
					}
					case 496:
					{
						return "Varita helada";
					}
					case 497:
					{
						return "Concha de Neptuno";
					}
					case 498:
					{
						return "Maniquí";
					}
					case 499:
					{
						return "Poción curativa mayor";
					}
					case 500:
					{
						return "Poción de maná mayor";
					}
					case 501:
					{
						return "Polvo de hada";
					}
					case 502:
					{
						return "Fragmento de cristal";
					}
					case 503:
					{
						return "Sombrero de payaso";
					}
					case 504:
					{
						return "Camisa de payaso";
					}
					case 505:
					{
						return "Pantalones de payaso";
					}
					case 506:
					{
						return "Lanzallamas";
					}
					case 507:
					{
						return "Campana";
					}
					case 508:
					{
						return "Arpa";
					}
					case 509:
					{
						return "Llave inglesa";
					}
					case 510:
					{
						return "Alicates";
					}
					case 511:
					{
						return "Bloque de piedra activo";
					}
					case 512:
					{
						return "Bloque de piedra inactivo";
					}
					case 513:
					{
						return "Palanca";
					}
					case 514:
					{
						return "Fusil láser";
					}
					case 515:
					{
						return "Bala de cristal";
					}
					case 516:
					{
						return "Flecha sagrada";
					}
					case 517:
					{
						return "Daga mágica";
					}
					case 518:
					{
						return "Tormenta de cristal";
					}
					case 519:
					{
						return "Llamas malditas";
					}
					case 520:
					{
						return "Alma de luz";
					}
					case 521:
					{
						return "Alma de noche";
					}
					case 522:
					{
						return "Llama maldita";
					}
					case 523:
					{
						return "Antorcha maldita";
					}
					case 524:
					{
						return "Forja de adamantita";
					}
					case 525:
					{
						return "Yunque de mithril";
					}
					case 526:
					{
						return "Cuerno de unicornio";
					}
					case 527:
					{
						return "Fragmento de oscuridad";
					}
					case 528:
					{
						return "Fragmento de luz";
					}
					case 529:
					{
						return "Chapa de presión roja";
					}
					case 530:
					{
						return "Alambre";
					}
					case 531:
					{
						return "Tomo encantado";
					}
					case 532:
					{
						return "Manto de estrellas";
					}
					case 533:
					{
						return "Megatiburón";
					}
					case 534:
					{
						return "Escopeta";
					}
					case 535:
					{
						return "Piedra filosofal";
					}
					case 536:
					{
						return "Guante de Titán";
					}
					case 537:
					{
						return "Naginata de cobalto";
					}
					case 538:
					{
						return "Interruptor";
					}
					case 539:
					{
						return "Trampa de dardos";
					}
					case 540:
					{
						return "Roca";
					}
					case 541:
					{
						return "Chapa de presión verde";
					}
					case 542:
					{
						return "Chapa de presión gris";
					}
					case 543:
					{
						return "Chapa de presión marrón";
					}
					case 544:
					{
						return "Ojo mecánico";
					}
					case 545:
					{
						return "Flecha maldita";
					}
					case 546:
					{
						return "Bala maldita";
					}
					case 547:
					{
						return "Alma de terror";
					}
					case 548:
					{
						return "Alma de poder";
					}
					case 549:
					{
						return "Alma de visión";
					}
					case 550:
					{
						return "Gungnir";
					}
					case 551:
					{
						return "Cota de chapas bendecida";
					}
					case 552:
					{
						return "Grebas bendecidas";
					}
					case 553:
					{
						return "Casco bendecido";
					}
					case 554:
					{
						return "Collar con cruz";
					}
					case 555:
					{
						return "Flor de maná";
					}
					case 556:
					{
						return "Gusano mecánico";
					}
					case 557:
					{
						return "Cráneo mecánico";
					}
					case 558:
					{
						return "Tocado bendecido";
					}
					case 559:
					{
						return "Máscara bendecida";
					}
					case 560:
					{
						return "Corona de babosa";
					}
					case 561:
					{
						return "Disco de luz";
					}
					case 562:
					{
						return "Caja de música (Superficie de día)";
					}
					case 563:
					{
						return "Caja de música (Sobrecogedor)";
					}
					case 564:
					{
						return "Caja de música (Noche)";
					}
					case 565:
					{
						return "Caja de música (Título)";
					}
					case 566:
					{
						return "Caja de música (Subsuelo)";
					}
					case 567:
					{
						return "Caja de música (Jefe 1)";
					}
					case 568:
					{
						return "Caja de música (Selva)";
					}
					case 569:
					{
						return "Caja de música (Corrupción)";
					}
					case 570:
					{
						return "Caja de música (Corrupción en el Subsuelo)";
					}
					case 571:
					{
						return "Caja de música (La Bendición)";
					}
					case 572:
					{
						return "Caja de música (Jefe 2)";
					}
					case 573:
					{
						return "Caja de música (Bendición en el Subsuelo)";
					}
					case 574:
					{
						return "Caja de música (Jefe 3)";
					}
					case 575:
					{
						return "Alma de vuelo";
					}
					case 576:
					{
						return "Caja de música";
					}
					case 577:
					{
						return "Ladrillo endemoniado";
					}
					case 578:
					{
						return "Repetidor bendecido";
					}
					case 579:
					{
						return "Martitaladrahacha";
					}
					case 580:
					{
						return "Explosivos";
					}
					case 581:
					{
						return "Colector de entrada";
					}
					case 582:
					{
						return "Colector de salida";
					}
					case 583:
					{
						return "Temporizador de 1 segundo";
					}
					case 584:
					{
						return "Temporizador de 3 segundos";
					}
					case 585:
					{
						return "Temporizador de 5 segundos";
					}
					case 586:
					{
						return "Bloquear dulces de caña";
					}
					case 587:
					{
						return "Candy Cane pared";
					}
					case 588:
					{
						return "Gorro de Papá Noel";
					}
					case 589:
					{
						return "Santa Camisa";
					}
					case 590:
					{
						return "Pantalones de Santa";
					}
					case 591:
					{
						return "Caramelo verde de caña de bloques";
					}
					case 592:
					{
						return "Verde del bastón de caramelo pared";
					}
					case 593:
					{
						return "Bloque de nieve";
					}
					case 594:
					{
						return "nieve ladrillo";
					}
					case 595:
					{
						return "Snow Brick Wall";
					}
					case 596:
					{
						return "Nieve pared de ladrillo";
					}
					case 597:
					{
						return "azul claro";
					}
					case 598:
					{
						return "luz roja";
					}
					case 599:
					{
						return "Presente azul";
					}
					case 600:
					{
						return "Presente verde";
					}
					case 601:
					{
						return "Presente amarillo";
					}
					case 602:
					{
						return "Bola de Nieve";
					}
					case 603:
					{
						return "Zanahoria";
					}
					default:
					{
						switch (num3)
						{
							case 3480:
							{
								return "Platinum Bow";
							}
							case 3481:
							{
								return "Platinum Hammer";
							}
							case 3482:
							{
								return "Platinum Axe";
							}
							case 3483:
							{
								return "Platinum Shortsword";
							}
							case 3484:
							{
								return "Platinum Broadsword";
							}
							case 3485:
							{
								return "Platinum Pickaxe";
							}
							case 3486:
							{
								return "Tungsten Bow";
							}
							case 3487:
							{
								return "Tungsten Hammer";
							}
							case 3488:
							{
								return "Tungsten Axe";
							}
							case 3489:
							{
								return "Tungsten Shortsword";
							}
							case 3490:
							{
								return "Tungsten Broadsword";
							}
							case 3491:
							{
								return "Tungsten Pickaxe";
							}
							case 3492:
							{
								return "Lead Bow";
							}
							case 3493:
							{
								return "Lead Hammer";
							}
							case 3494:
							{
								return "Lead Axe";
							}
							case 3495:
							{
								return "Lead Shortsword";
							}
							case 3496:
							{
								return "Lead Broadsword";
							}
							case 3497:
							{
								return "Lead Pickaxe";
							}
							case 3498:
							{
								return "Tin Bow";
							}
							case 3499:
							{
								return "Tin Hammer";
							}
							case 3500:
							{
								return "Tin Axe";
							}
							case 3501:
							{
								return "Tin Shortsword";
							}
							case 3502:
							{
								return "Tin Broadsword";
							}
							case 3503:
							{
								return "Tin Pickaxe";
							}
							case 3504:
							{
								return "Arco de cobre";
							}
							case 3505:
							{
								return "Martillo de cobre";
							}
							case 3506:
							{
								return "Hacha de cobre";
							}
							case 3507:
							{
								return "Espada corta de cobre";
							}
							case 3508:
							{
								return "Espada larga de cobre";
							}
							case 3509:
							{
								return "Pico de cobre";
							}
							case 3510:
							{
								return "Arco de plata";
							}
							case 3511:
							{
								return "Martillo de plata";
							}
							case 3512:
							{
								return "Hacha de plata";
							}
							case 3513:
							{
								return "Espada corta de plata";
							}
							case 3514:
							{
								return "Espada larga de plata";
							}
							case 3515:
							{
								return "Pico de plata";
							}
							case 3516:
							{
								return "Arco de oro";
							}
							case 3517:
							{
								return "Martillo de oro";
							}
							case 3518:
							{
								return "Hacha de oro";
							}
							case 3519:
							{
								return "Espada corta de oro";
							}
							case 3520:
							{
								return "Espada larga de oro";
							}
							case 3521:
							{
								return "Pico de oro";
							}
						}
						break;
					}
				}
			}
			if (english || Lang.lang <= 1)
			{
				return "";
			}
			return Lang.itemName(l, true);
		}

		public static string npcName(int l, bool english = false)
		{
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
					case -65:
					{
						return "Hornet";
					}
					case -64:
					{
						return "Hornet";
					}
					case -63:
					{
						return "Hornet";
					}
					case -62:
					{
						return "Hornet";
					}
					case -61:
					{
						return "Hornet";
					}
					case -60:
					{
						return "Hornet";
					}
					case -59:
					{
						return "Hornet";
					}
					case -58:
					{
						return "Hornet";
					}
					case -57:
					{
						return "Hornet";
					}
					case -56:
					{
						return "Hornet";
					}
					case -55:
					{
						return "Zombie";
					}
					case -54:
					{
						return "Zombie";
					}
					case -53:
					{
						return "Skeleton";
					}
					case -52:
					{
						return "Skeleton";
					}
					case -51:
					{
						return "Skeleton";
					}
					case -50:
					{
						return "Skeleton";
					}
					case -49:
					{
						return "Skeleton";
					}
					case -48:
					{
						return "Skeleton";
					}
					case -47:
					{
						return "Skeleton";
					}
					case -46:
					{
						return "Skeleton";
					}
					case -45:
					{
						return "Zombie";
					}
					case -44:
					{
						return "Zombie";
					}
					case -43:
					{
						return "Demon Eye";
					}
					case -42:
					{
						return "Demon Eye";
					}
					case -41:
					{
						return "Demon Eye";
					}
					case -40:
					{
						return "Demon Eye";
					}
					case -39:
					{
						return "Demon Eye";
					}
					case -38:
					{
						return "Demon Eye";
					}
					case -37:
					{
						return "Zombie";
					}
					case -36:
					{
						return "Zombie";
					}
					case -35:
					{
						return "Zombie";
					}
					case -34:
					{
						return "Zombie";
					}
					case -33:
					{
						return "Zombie";
					}
					case -32:
					{
						return "Zombie";
					}
					case -31:
					{
						return "Zombie";
					}
					case -30:
					{
						return "Zombie";
					}
					case -29:
					{
						return "Zombie";
					}
					case -28:
					{
						return "Zombie";
					}
					case -27:
					{
						return "Zombie";
					}
					case -26:
					{
						return "Zombie";
					}
					case -25:
					{
						return "Crimslime";
					}
					case -24:
					{
						return "Crimslime";
					}
					case -23:
					{
						return "Crimera";
					}
					case -22:
					{
						return "Crimera";
					}
					case -21:
					{
						return "Moss Hornet";
					}
					case -20:
					{
						return "Moss Hornet";
					}
					case -19:
					{
						return "Moss Hornet";
					}
					case -18:
					{
						return "Moss Hornet";
					}
					case -17:
					{
						return "Hornet";
					}
					case -16:
					{
						return "Hornet";
					}
					case -15:
					{
						return "Armored Skeleton";
					}
					case -14:
					{
						return "Angry Bones";
					}
					case -13:
					{
						return "Angry Bones";
					}
					case -12:
					{
						return "Eater of Souls";
					}
					case -11:
					{
						return "Eater of Souls";
					}
					case -10:
					{
						return "Jungle Slime";
					}
					case -9:
					{
						return "Yellow Slime";
					}
					case -8:
					{
						return "Red Slime";
					}
					case -7:
					{
						return "Purple Slime";
					}
					case -6:
					{
						return "Black Slime";
					}
					case -5:
					{
						return "Baby Slime";
					}
					case -4:
					{
						return "Pinky";
					}
					case -3:
					{
						return "Green Slime";
					}
					case -2:
					{
						return "Slimer";
					}
					case -1:
					{
						return "Slimeling";
					}
					case 1:
					{
						return "Blue Slime";
					}
					case 2:
					{
						return "Demon Eye";
					}
					case 3:
					{
						return "Zombie";
					}
					case 4:
					{
						return "Eye of Cthulhu";
					}
					case 5:
					{
						return "Servant of Cthulhu";
					}
					case 6:
					{
						return "Eater of Souls";
					}
					case 7:
					{
						return "Devourer";
					}
					case 8:
					{
						return "Devourer";
					}
					case 9:
					{
						return "Devourer";
					}
					case 10:
					{
						return "Giant Worm";
					}
					case 11:
					{
						return "Giant Worm";
					}
					case 12:
					{
						return "Giant Worm";
					}
					case 13:
					{
						return "Eater of Worlds";
					}
					case 14:
					{
						return "Eater of Worlds";
					}
					case 15:
					{
						return "Eater of Worlds";
					}
					case 16:
					{
						return "Mother Slime";
					}
					case 17:
					{
						return "Merchant";
					}
					case 18:
					{
						return "Nurse";
					}
					case 19:
					{
						return "Arms Dealer";
					}
					case 20:
					{
						return "Dryad";
					}
					case 21:
					{
						return "Skeleton";
					}
					case 22:
					{
						return "Guide";
					}
					case 23:
					{
						return "Meteor Head";
					}
					case 24:
					{
						return "Fire Imp";
					}
					case 25:
					{
						return "Burning Sphere";
					}
					case 26:
					{
						return "Goblin Peon";
					}
					case 27:
					{
						return "Goblin Thief";
					}
					case 28:
					{
						return "Goblin Warrior";
					}
					case 29:
					{
						return "Goblin Sorcerer";
					}
					case 30:
					{
						return "Chaos Ball";
					}
					case 31:
					{
						return "Angry Bones";
					}
					case 32:
					{
						return "Dark Caster";
					}
					case 33:
					{
						return "Water Sphere";
					}
					case 34:
					{
						return "Cursed Skull";
					}
					case 35:
					{
						return "Skeletron";
					}
					case 36:
					{
						return "Skeletron";
					}
					case 37:
					{
						return "Old Man";
					}
					case 38:
					{
						return "Demolitionist";
					}
					case 39:
					{
						return "Bone Serpent";
					}
					case 40:
					{
						return "Bone Serpent";
					}
					case 41:
					{
						return "Bone Serpent";
					}
					case 42:
					{
						return "Hornet";
					}
					case 43:
					{
						return "Man Eater";
					}
					case 44:
					{
						return "Undead Miner";
					}
					case 45:
					{
						return "Tim";
					}
					case 46:
					{
						return "Bunny";
					}
					case 47:
					{
						return "Corrupt Bunny";
					}
					case 48:
					{
						return "Harpy";
					}
					case 49:
					{
						return "Cave Bat";
					}
					case 50:
					{
						return "King Slime";
					}
					case 51:
					{
						return "Jungle Bat";
					}
					case 52:
					{
						return "Doctor Bones";
					}
					case 53:
					{
						return "The Groom";
					}
					case 54:
					{
						return "Clothier";
					}
					case 55:
					{
						return "Goldfish";
					}
					case 56:
					{
						return "Snatcher";
					}
					case 57:
					{
						return "Corrupt Goldfish";
					}
					case 58:
					{
						return "Piranha";
					}
					case 59:
					{
						return "Lava Slime";
					}
					case 60:
					{
						return "Hellbat";
					}
					case 61:
					{
						return "Vulture";
					}
					case 62:
					{
						return "Demon";
					}
					case 63:
					{
						return "Blue Jellyfish";
					}
					case 64:
					{
						return "Pink Jellyfish";
					}
					case 65:
					{
						return "Shark";
					}
					case 66:
					{
						return "Voodoo Demon";
					}
					case 67:
					{
						return "Crab";
					}
					case 68:
					{
						return "Dungeon Guardian";
					}
					case 69:
					{
						return "Antlion";
					}
					case 70:
					{
						return "Spike Ball";
					}
					case 71:
					{
						return "Dungeon Slime";
					}
					case 72:
					{
						return "Blazing Wheel";
					}
					case 73:
					{
						return "Goblin Scout";
					}
					case 74:
					{
						return "Bird";
					}
					case 75:
					{
						return "Pixie";
					}
					case 77:
					{
						return "Armored Skeleton";
					}
					case 78:
					{
						return "Mummy";
					}
					case 79:
					{
						return "Dark Mummy";
					}
					case 80:
					{
						return "Light Mummy";
					}
					case 81:
					{
						return "Corrupt Slime";
					}
					case 82:
					{
						return "Wraith";
					}
					case 83:
					{
						return "Cursed Hammer";
					}
					case 84:
					{
						return "Enchanted Sword";
					}
					case 85:
					{
						return "Mimic";
					}
					case 86:
					{
						return "Unicorn";
					}
					case 87:
					{
						return "Wyvern";
					}
					case 88:
					{
						return "Wyvern";
					}
					case 89:
					{
						return "Wyvern";
					}
					case 90:
					{
						return "Wyvern";
					}
					case 91:
					{
						return "Wyvern";
					}
					case 92:
					{
						return "Wyvern";
					}
					case 93:
					{
						return "Giant Bat";
					}
					case 94:
					{
						return "Corruptor";
					}
					case 95:
					{
						return "Digger";
					}
					case 96:
					{
						return "Digger";
					}
					case 97:
					{
						return "Digger";
					}
					case 98:
					{
						return "World Feeder";
					}
					case 99:
					{
						return "World Feeder";
					}
					case 100:
					{
						return "World Feeder";
					}
					case 101:
					{
						return "Clinger";
					}
					case 102:
					{
						return "Angler Fish";
					}
					case 103:
					{
						return "Green Jellyfish";
					}
					case 104:
					{
						return "Werewolf";
					}
					case 105:
					{
						return "Bound Goblin";
					}
					case 106:
					{
						return "Bound Wizard";
					}
					case 107:
					{
						return "Goblin Tinkerer";
					}
					case 108:
					{
						return "Wizard";
					}
					case 109:
					{
						return "Clown";
					}
					case 110:
					{
						return "Skeleton Archer";
					}
					case 111:
					{
						return "Goblin Archer";
					}
					case 112:
					{
						return "Vile Spit";
					}
					case 113:
					{
						return "Wall of Flesh";
					}
					case 114:
					{
						return "Wall of Flesh";
					}
					case 115:
					{
						return "The Hungry";
					}
					case 116:
					{
						return "The Hungry";
					}
					case 117:
					{
						return "Leech";
					}
					case 118:
					{
						return "Leech";
					}
					case 119:
					{
						return "Leech";
					}
					case 120:
					{
						return "Chaos Elemental";
					}
					case 121:
					{
						return "Slimer";
					}
					case 122:
					{
						return "Gastropod";
					}
					case 123:
					{
						return "Bound Mechanic";
					}
					case 124:
					{
						return "Mechanic";
					}
					case 125:
					{
						return "Retinazer";
					}
					case 126:
					{
						return "Spazmatism";
					}
					case 127:
					{
						return "Skeletron Prime";
					}
					case 128:
					{
						return "Prime Cannon";
					}
					case 129:
					{
						return "Prime Saw";
					}
					case 130:
					{
						return "Prime Vice";
					}
					case 131:
					{
						return "Prime Laser";
					}
					case 132:
					{
						return "Zombie";
					}
					case 133:
					{
						return "Wandering Eye";
					}
					case 134:
					{
						return "The Destroyer";
					}
					case 135:
					{
						return "The Destroyer";
					}
					case 136:
					{
						return "The Destroyer";
					}
					case 137:
					{
						return "Illuminant Bat";
					}
					case 138:
					{
						return "Illuminant Slime";
					}
					case 139:
					{
						return "Probe";
					}
					case 140:
					{
						return "Possessed Armor";
					}
					case 141:
					{
						return "Toxic Sludge";
					}
					case 142:
					{
						return "Santa Claus";
					}
					case 143:
					{
						return "Snowman Gangsta";
					}
					case 144:
					{
						return "Mister Stabby";
					}
					case 145:
					{
						return "Snow Balla";
					}
					case 147:
					{
						return "Ice Slime";
					}
					case 148:
					{
						return "Penguin";
					}
					case 149:
					{
						return "Penguin";
					}
					case 150:
					{
						return "Ice Bat";
					}
					case 151:
					{
						return "Lava Bat";
					}
					case 152:
					{
						return "Giant Flying Fox";
					}
					case 153:
					{
						return "Giant Tortoise";
					}
					case 154:
					{
						return "Ice Tortoise";
					}
					case 155:
					{
						return "Wolf";
					}
					case 156:
					{
						return "Red Devil";
					}
					case 157:
					{
						return "Arapaima";
					}
					case 158:
					{
						return "Vampire";
					}
					case 159:
					{
						return "Vampire";
					}
					case 160:
					{
						return "Truffle";
					}
					case 161:
					{
						return "Zombie Eskimo";
					}
					case 162:
					{
						return "Frankenstein";
					}
					case 163:
					{
						return "Black Recluse";
					}
					case 164:
					{
						return "Wall Creeper";
					}
					case 165:
					{
						return "Wall Creeper";
					}
					case 166:
					{
						return "Swamp Thing";
					}
					case 167:
					{
						return "Undead Viking";
					}
					case 168:
					{
						return "Corrupt Penguin";
					}
					case 169:
					{
						return "Ice Elemental";
					}
					case 170:
					{
						return "Pigron";
					}
					case 171:
					{
						return "Pigron";
					}
					case 172:
					{
						return "Rune Wizard";
					}
					case 173:
					{
						return "Crimera";
					}
					case 174:
					{
						return "Herpling";
					}
					case 175:
					{
						return "Angry Trapper";
					}
					case 176:
					{
						return "Moss Hornet";
					}
					case 177:
					{
						return "Derpling";
					}
					case 178:
					{
						return "Steampunker";
					}
					case 179:
					{
						return "Crimson Axe";
					}
					case 180:
					{
						return "Pigron";
					}
					case 181:
					{
						return "Face Monster";
					}
					case 182:
					{
						return "Floaty Gross";
					}
					case 183:
					{
						return "Crimslime";
					}
					case 184:
					{
						return "Spiked Ice Slime";
					}
					case 185:
					{
						return "Snow Flinx";
					}
					case 186:
					{
						return "Zombie";
					}
					case 187:
					{
						return "Zombie";
					}
					case 188:
					{
						return "Zombie";
					}
					case 189:
					{
						return "Zombie";
					}
					case 190:
					{
						return "Demon Eye";
					}
					case 191:
					{
						return "Demon Eye";
					}
					case 192:
					{
						return "Demon Eye";
					}
					case 193:
					{
						return "Demon Eye";
					}
					case 194:
					{
						return "Demon Eye";
					}
					case 195:
					{
						return "Lost Girl";
					}
					case 196:
					{
						return "Nymph";
					}
					case 197:
					{
						return "Armored Viking";
					}
					case 198:
					{
						return "Lihzahrd";
					}
					case 199:
					{
						return "Lihzahrd";
					}
					case 200:
					{
						return "Zombie";
					}
					case 201:
					{
						return "Skeleton";
					}
					case 202:
					{
						return "Skeleton";
					}
					case 203:
					{
						return "Skeleton";
					}
					case 204:
					{
						return "Spiked Jungle Slime";
					}
					case 205:
					{
						return "Moth";
					}
					case 206:
					{
						return "Icy Merman";
					}
					case 207:
					{
						return "Dye Trader";
					}
					case 208:
					{
						return "Party Girl";
					}
					case 209:
					{
						return "Cyborg";
					}
					case 210:
					{
						return "Bee";
					}
					case 211:
					{
						return "Bee";
					}
					case 212:
					{
						return "Pirate Deckhand";
					}
					case 213:
					{
						return "Pirate Corsair";
					}
					case 214:
					{
						return "Pirate Deadeye";
					}
					case 215:
					{
						return "Pirate Crossbower";
					}
					case 216:
					{
						return "Pirate Captain";
					}
					case 217:
					{
						return "Cochineal Beetle";
					}
					case 218:
					{
						return "Cyan Beetle";
					}
					case 219:
					{
						return "Lac Beetle";
					}
					case 220:
					{
						return "Sea Snail";
					}
					case 221:
					{
						return "Squid";
					}
					case 222:
					{
						return "Queen Bee";
					}
					case 223:
					{
						return "Raincoat Zombie";
					}
					case 224:
					{
						return "Flying Fish";
					}
					case 225:
					{
						return "Umbrella Slime";
					}
					case 226:
					{
						return "Flying Snake";
					}
					case 227:
					{
						return "Painter";
					}
					case 228:
					{
						return "Witch Doctor";
					}
					case 229:
					{
						return "Pirate";
					}
					case 230:
					{
						return "Goldfish";
					}
					case 231:
					{
						return "Hornet";
					}
					case 232:
					{
						return "Hornet";
					}
					case 233:
					{
						return "Hornet";
					}
					case 234:
					{
						return "Hornet";
					}
					case 235:
					{
						return "Hornet";
					}
					case 236:
					{
						return "Jungle Creeper";
					}
					case 237:
					{
						return "Jungle Creeper";
					}
					case 238:
					{
						return "Black Recluse";
					}
					case 239:
					{
						return "Blood Crawler";
					}
					case 240:
					{
						return "Blood Crawler";
					}
					case 241:
					{
						return "Blood Feeder";
					}
					case 242:
					{
						return "Blood Jelly";
					}
					case 243:
					{
						return "Ice Golem";
					}
					case 244:
					{
						return "Rainbow Slime";
					}
					case 245:
					{
						return "Golem";
					}
					case 246:
					{
						return "Golem Head";
					}
					case 247:
					{
						return "Golem Fist";
					}
					case 248:
					{
						return "Golem Fist";
					}
					case 249:
					{
						return "Golem Head";
					}
					case 250:
					{
						return "Angry Nimbus";
					}
					case 251:
					{
						return "Eyezor";
					}
					case 252:
					{
						return "Parrot";
					}
					case 253:
					{
						return "Reaper";
					}
					case 254:
					{
						return "Spore Zombie";
					}
					case 255:
					{
						return "Spore Zombie";
					}
					case 256:
					{
						return "Fungo Fish";
					}
					case 257:
					{
						return "Anomura Fungus";
					}
					case 258:
					{
						return "Mushi Ladybug";
					}
					case 259:
					{
						return "Fungi Bulb";
					}
					case 260:
					{
						return "Giant Fungi Bulb";
					}
					case 261:
					{
						return "Fungi Spore";
					}
					case 262:
					{
						return "Plantera";
					}
					case 263:
					{
						return "Plantera's Hook";
					}
					case 264:
					{
						return "Plantera's Tentacle";
					}
					case 265:
					{
						return "Spore";
					}
					case 266:
					{
						return "Brain of Cthulhu";
					}
					case 267:
					{
						return "Creeper";
					}
					case 268:
					{
						return "Ichor Sticker";
					}
					case 269:
					{
						return "Rusty Armored Bones";
					}
					case 270:
					{
						return "Rusty Armored Bones";
					}
					case 271:
					{
						return "Rusty Armored Bones";
					}
					case 272:
					{
						return "Rusty Armored Bones";
					}
					case 273:
					{
						return "Blue Armored Bones";
					}
					case 274:
					{
						return "Blue Armored Bones";
					}
					case 275:
					{
						return "Blue Armored Bones";
					}
					case 276:
					{
						return "Blue Armored Bones";
					}
					case 277:
					{
						return "Hell Armored Bones";
					}
					case 278:
					{
						return "Hell Armored Bones";
					}
					case 279:
					{
						return "Hell Armored Bones";
					}
					case 280:
					{
						return "Hell Armored Bones";
					}
					case 281:
					{
						return "Ragged Caster";
					}
					case 282:
					{
						return "Ragged Caster";
					}
					case 283:
					{
						return "Necromancer";
					}
					case 284:
					{
						return "Necromancer";
					}
					case 285:
					{
						return "Diabolist";
					}
					case 286:
					{
						return "Diabolist";
					}
					case 287:
					{
						return "Bone Lee";
					}
					case 288:
					{
						return "Dungeon Spirit";
					}
					case 289:
					{
						return "Giant Cursed Skull";
					}
					case 290:
					{
						return "Paladin";
					}
					case 291:
					{
						return "Skeleton Sniper";
					}
					case 292:
					{
						return "Tactical Skeleton";
					}
					case 293:
					{
						return "Skeleton Commando";
					}
					case 294:
					{
						return "Angry Bones";
					}
					case 295:
					{
						return "Angry Bones";
					}
					case 296:
					{
						return "Angry Bones";
					}
					case 297:
					{
						return "Blue Jay";
					}
					case 298:
					{
						return "Cardinal";
					}
					case 299:
					{
						return "Squirrel";
					}
					case 300:
					{
						return "Mouse";
					}
					case 301:
					{
						return "Raven";
					}
					case 302:
					{
						return "Slime";
					}
					case 303:
					{
						return "Bunny";
					}
					case 304:
					{
						return "Hoppin' Jack";
					}
					case 305:
					{
						return "Scarecrow";
					}
					case 306:
					{
						return "Scarecrow";
					}
					case 307:
					{
						return "Scarecrow";
					}
					case 308:
					{
						return "Scarecrow";
					}
					case 309:
					{
						return "Scarecrow";
					}
					case 310:
					{
						return "Scarecrow";
					}
					case 311:
					{
						return "Scarecrow";
					}
					case 312:
					{
						return "Scarecrow";
					}
					case 313:
					{
						return "Scarecrow";
					}
					case 314:
					{
						return "Scarecrow";
					}
					case 315:
					{
						return "Headless Horseman";
					}
					case 316:
					{
						return "Ghost";
					}
					case 317:
					{
						return "Demon Eye";
					}
					case 318:
					{
						return "Demon Eye";
					}
					case 319:
					{
						return "Zombie";
					}
					case 320:
					{
						return "Zombie";
					}
					case 321:
					{
						return "Zombie";
					}
					case 322:
					{
						return "Skeleton";
					}
					case 323:
					{
						return "Skeleton";
					}
					case 324:
					{
						return "Skeleton";
					}
					case 325:
					{
						return "Mourning Wood";
					}
					case 326:
					{
						return "Splinterling";
					}
					case 327:
					{
						return "Pumpking";
					}
					case 328:
					{
						return "Pumpking";
					}
					case 329:
					{
						return "Hellhound";
					}
					case 330:
					{
						return "Poltergeist";
					}
					case 331:
					{
						return "Zombie";
					}
					case 332:
					{
						return "Zombie";
					}
					case 333:
					{
						return "Slime";
					}
					case 334:
					{
						return "Slime";
					}
					case 335:
					{
						return "Slime";
					}
					case 336:
					{
						return "Slime";
					}
					case 337:
					{
						return "Bunny";
					}
					case 338:
					{
						return "Zombie Elf";
					}
					case 339:
					{
						return "Zombie Elf";
					}
					case 340:
					{
						return "Zombie Elf";
					}
					case 341:
					{
						return "Present Mimic";
					}
					case 342:
					{
						return "Gingerbread Man";
					}
					case 343:
					{
						return "Yeti";
					}
					case 344:
					{
						return "Everscream";
					}
					case 345:
					{
						return "Ice Queen";
					}
					case 346:
					{
						return "Santa-NK1";
					}
					case 347:
					{
						return "Elf Copter";
					}
					case 348:
					{
						return "Nutcracker";
					}
					case 349:
					{
						return "Nutcracker";
					}
					case 350:
					{
						return "Elf Archer";
					}
					case 351:
					{
						return "Krampus";
					}
					case 352:
					{
						return "Flocko";
					}
					case 353:
					{
						return "Stylist";
					}
					case 354:
					{
						return "Webbed Stylist";
					}
					case 355:
					{
						return "Firefly";
					}
					case 356:
					{
						return "Butterfly";
					}
					case 357:
					{
						return "Worm";
					}
					case 358:
					{
						return "Lightning Bug";
					}
					case 359:
					{
						return "Snail";
					}
					case 360:
					{
						return "Glowing Snail";
					}
					case 361:
					{
						return "Frog";
					}
					case 362:
					{
						return "Duck";
					}
					case 363:
					{
						return "Duck";
					}
					case 364:
					{
						return "Duck";
					}
					case 365:
					{
						return "Duck";
					}
					case 366:
					{
						return "Scorpion";
					}
					case 367:
					{
						return "Scorpion";
					}
					case 368:
					{
						return "Traveling Merchant";
					}
					case 369:
					{
						return "Angler";
					}
					case 370:
					{
						return "Duke Fishron";
					}
					case 371:
					{
						return "Detonating Bubble";
					}
					case 372:
					{
						return "Sharkron";
					}
					case 373:
					{
						return "Sharkron";
					}
					case 374:
					{
						return "Truffle Worm";
					}
					case 375:
					{
						return "Truffle Worm";
					}
					case 376:
					{
						return "Sleeping Angler";
					}
					case 377:
					{
						return "Grasshopper";
					}
					case 378:
					{
						return "Chattering Teeth Bomb";
					}
					case 379:
					{
						return "Blue Cultist Archer";
					}
					case 380:
					{
						return "White Cultist Archer";
					}
					case 381:
					{
						return "Brain Scrambler";
					}
					case 382:
					{
						return "Ray Gunner";
					}
					case 383:
					{
						return "Martian Officer";
					}
					case 384:
					{
						return "Bubble Shield";
					}
					case 385:
					{
						return "Gray Grunt";
					}
					case 386:
					{
						return "Martian Engineer";
					}
					case 387:
					{
						return "Tesla Turret";
					}
					case 388:
					{
						return "Martian Drone";
					}
					case 389:
					{
						return "Gigazapper";
					}
					case 390:
					{
						return "Scutlix Gunner";
					}
					case 391:
					{
						return "Scutlix";
					}
					case 392:
					{
						return "Martian Saucer";
					}
					case 393:
					{
						return "Martian Saucer Turret";
					}
					case 394:
					{
						return "Martian Saucer Cannon";
					}
					case 395:
					{
						return "Martian Saucer";
					}
					case 396:
					{
						return "Moon Lord";
					}
					case 397:
					{
						return "Moon Lord's Hand";
					}
					case 398:
					{
						return "Moon Lord's Core";
					}
					case 399:
					{
						return "Martian Probe";
					}
					case 402:
					{
						return "Milkyway Weaver";
					}
					case 405:
					case 406:
					{
						return "Star Cell";
					}
					case 407:
					{
						return "Flow Invader";
					}
					case 409:
					{
						return "Twinkle Popper";
					}
					case 410:
					{
						return "Twinkle";
					}
					case 411:
					{
						return "Stargazer";
					}
					case 412:
					{
						return "Crawltipede";
					}
					case 413:
					{
						return "Crawltipede";
					}
					case 414:
					{
						return "Crawltipede";
					}
					case 415:
					{
						return "Drakomire";
					}
					case 416:
					{
						return "Drakomire Rider";
					}
					case 417:
					{
						return "Sroller";
					}
					case 418:
					{
						return "Corite";
					}
					case 419:
					{
						return "Selenian";
					}
					case 420:
					{
						return "Nebula Floater";
					}
					case 421:
					{
						return "Brain Suckler";
					}
					case 422:
					{
						return "Vortex Pillar";
					}
					case 423:
					{
						return "Evolution Beast";
					}
					case 424:
					{
						return "Predictor";
					}
					case 425:
					{
						return "Storm Diver";
					}
					case 426:
					{
						return "Alien Queen";
					}
					case 427:
					{
						return "Alien Hornet";
					}
					case 428:
					{
						return "Alien Larva";
					}
					case 429:
					{
						return "Vortexian";
					}
					case 430:
					{
						return "Zombie";
					}
					case 431:
					{
						return "Zombie Eskimo";
					}
					case 432:
					{
						return "Zombie";
					}
					case 433:
					{
						return "Zombie";
					}
					case 434:
					{
						return "Zombie";
					}
					case 435:
					{
						return "Zombie";
					}
					case 436:
					{
						return "Zombie";
					}
					case 437:
					{
						return "Mysterious Tablet";
					}
					case 438:
					{
						return "Lunatic Devote";
					}
					case 439:
					{
						return "Lunatic Cultist";
					}
					case 440:
					{
						return "Luantic Cultist";
					}
					case 442:
					{
						return "Gold Bird";
					}
					case 443:
					{
						return "Gold Bunny";
					}
					case 444:
					{
						return "Gold Butterfly";
					}
					case 445:
					{
						return "Gold Frog";
					}
					case 446:
					{
						return "Gold Grasshopper";
					}
					case 447:
					{
						return "Gold Mouse";
					}
					case 448:
					{
						return "Gold Worm";
					}
					case 449:
					{
						return "Skeleton";
					}
					case 450:
					{
						return "Skeleton";
					}
					case 451:
					{
						return "Skeleton";
					}
					case 452:
					{
						return "Skeleton";
					}
					case 454:
					case 455:
					case 456:
					case 457:
					case 458:
					case 459:
					{
						return "Phantasm Dragon";
					}
					case 460:
					{
						return "Butcher";
					}
					case 461:
					{
						return "Creature from the Deep";
					}
					case 462:
					{
						return "Fritz";
					}
					case 463:
					{
						return "Nailhead";
					}
					case 464:
					{
						return "Crimtane Bunny";
					}
					case 465:
					{
						return "Crimtane Goldfish";
					}
					case 466:
					{
						return "Psycho";
					}
					case 467:
					{
						return "Deadly Sphere";
					}
					case 468:
					{
						return "Dr. Man Fly";
					}
					case 469:
					{
						return "The Possessed";
					}
					case 470:
					{
						return "Vicious Penguin";
					}
					case 471:
					{
						return "Goblin Summoner";
					}
					case 472:
					{
						return "Shadowflame Apparation";
					}
					case 473:
					{
						return "Corrupt Mimic";
					}
					case 474:
					{
						return "Crimson Mimic";
					}
					case 475:
					{
						return "Hallowed Mimic";
					}
					case 476:
					{
						return "Jungle Mimic";
					}
					case 477:
					{
						return "Mothron";
					}
					case 478:
					{
						return "Mothron Egg";
					}
					case 479:
					{
						return "Baby Mothron";
					}
					case 480:
					{
						return "Medusa";
					}
					case 481:
					{
						return "Hoplite";
					}
					case 482:
					{
						return "Granite Golem";
					}
					case 483:
					{
						return "Granite Elemental";
					}
					case 484:
					{
						return "Enchanted Nightcrawler";
					}
					case 485:
					{
						return "Grubby";
					}
					case 486:
					{
						return "Sluggy";
					}
					case 487:
					{
						return "Buggy";
					}
					case 488:
					{
						return "Target Dummy";
					}
					case 489:
					{
						return "Blood Zombie";
					}
					case 490:
					{
						return "Drippler";
					}
					case 493:
					{
						return "Stardust Pillar";
					}
					case 494:
					{
						return "Crawdad";
					}
					case 495:
					{
						return "Crawdad";
					}
					case 496:
					{
						return "Giant Shelly";
					}
					case 497:
					{
						return "Giant Shelly";
					}
					case 498:
					{
						return "Salamander";
					}
					case 499:
					{
						return "Salamander";
					}
					case 500:
					{
						return "Salamander";
					}
					case 501:
					{
						return "Salamander";
					}
					case 502:
					{
						return "Salamander";
					}
					case 503:
					{
						return "Salamander";
					}
					case 504:
					{
						return "Salamander";
					}
					case 505:
					{
						return "Salamander";
					}
					case 506:
					{
						return "Salamander";
					}
					case 507:
					{
						return "Nebula Pillar";
					}
					case 508:
					{
						return "Antlion Charger";
					}
					case 509:
					{
						return "Antlion Swarmer";
					}
					case 510:
					case 511:
					case 512:
					{
						return "Dune Splicer";
					}
					case 513:
					case 514:
					case 515:
					{
						return "Tomb Crawler";
					}
					case 516:
					{
						return "Solar Flare";
					}
					case 517:
					{
						return "Solar Pillar";
					}
					case 518:
					{
						return "Drakanian";
					}
					case 519:
					{
						return "Solar Fragment";
					}
					case 520:
					{
						return "Martian Walker";
					}
					case 521:
					{
						return "Ancient Vision";
					}
					case 522:
					{
						return "Ancient Light";
					}
					case 523:
					{
						return "Ancient Doom";
					}
					case 524:
					{
						return "Ghoul";
					}
					case 525:
					{
						return "Vile Ghoul";
					}
					case 526:
					{
						return "Tainted Ghoul";
					}
					case 527:
					{
						return "Dreamer Ghoul";
					}
					case 528:
					case 529:
					{
						return "Lamia";
					}
					case 530:
					case 531:
					{
						return "Sand Poacher";
					}
					case 532:
					{
						return "Basilisk";
					}
					case 533:
					{
						return "Desert Spirit";
					}
					case 534:
					{
						return "Tortured Soul";
					}
					case 535:
					{
						return "Spiked Slime";
					}
					case 536:
					{
						return "The Bride";
					}
					case 537:
					{
						return "Sand Slime";
					}
					case 538:
					{
						return "Red Squirrel";
					}
					case 539:
					{
						return "Gold Squirrel";
					}
				}
			}
			else if (Lang.lang == 2)
			{
				switch (l)
				{
					case -17:
					{
						return "Riesenhornisse";
					}
					case -16:
					{
						return "Minihornisse";
					}
					case -15:
					{
						return "Mammutskelett";
					}
					case -14:
					{
						return "Grossknochen";
					}
					case -13:
					{
						return "Kleinknochen";
					}
					case -12:
					{
						return "Maxifresser";
					}
					case -11:
					{
						return "Minifresser";
					}
					case -10:
					{
						return "Dschungelschleimi";
					}
					case -9:
					{
						return "Gelbschleimi";
					}
					case -8:
					{
						return "Rotschleimi";
					}
					case -7:
					{
						return "Lila Schleimi";
					}
					case -6:
					{
						return "Schwarzschleimi";
					}
					case -5:
					{
						return "Schleimbaby";
					}
					case -4:
					{
						return "Pinky";
					}
					case -3:
					{
						return "Gruenschleimi";
					}
					case -2:
					{
						return "Flugschleimi";
					}
					case -1:
					{
						return "Schleimling";
					}
					case 1:
					{
						return "Blauschleimi";
					}
					case 2:
					{
						return "Daemonenauge";
					}
					case 3:
					{
						return "Zombie";
					}
					case 4:
					{
						return "Auge von Cthulhu";
					}
					case 5:
					{
						return "Diener von Cthulhu";
					}
					case 6:
					{
						return "Seelenfresser";
					}
					case 7:
					{
						return "Verschlinger";
					}
					case 8:
					{
						return "Verschlinger";
					}
					case 9:
					{
						return "Verschlinger";
					}
					case 10:
					{
						return "Riesenwurm";
					}
					case 11:
					{
						return "Riesenwurm";
					}
					case 12:
					{
						return "Riesenwurm";
					}
					case 13:
					{
						return "Weltenfresser";
					}
					case 14:
					{
						return "Weltenfresser";
					}
					case 15:
					{
						return "Weltenfresser";
					}
					case 16:
					{
						return "Schleimmami";
					}
					case 17:
					{
						return "Haendler";
					}
					case 18:
					{
						return "Krankenschwester";
					}
					case 19:
					{
						return "Waffenhaendler";
					}
					case 20:
					{
						return "Dryade";
					}
					case 21:
					{
						return "Skelett";
					}
					case 22:
					{
						return "Fremdenfuehrer";
					}
					case 23:
					{
						return "Meteorenkopf";
					}
					case 24:
					{
						return "Feuer-Imp";
					}
					case 25:
					{
						return "Flammenkugel";
					}
					case 26:
					{
						return "Goblin-Arbeiter";
					}
					case 27:
					{
						return "Goblin-Dieb";
					}
					case 28:
					{
						return "Goblin-Krieger";
					}
					case 29:
					{
						return "Goblin-Hexer";
					}
					case 30:
					{
						return "Chaoskugel";
					}
					case 31:
					{
						return "Wutknochen";
					}
					case 32:
					{
						return "Duestermagier";
					}
					case 33:
					{
						return "Wasserkugel";
					}
					case 34:
					{
						return "Fluchschaedel";
					}
					case 35:
					{
						return "Skeletron";
					}
					case 36:
					{
						return "Skeletron";
					}
					case 37:
					{
						return "Greis";
					}
					case 38:
					{
						return "Sprengmeister";
					}
					case 39:
					{
						return "Knochenschlange";
					}
					case 40:
					{
						return "Knochenschlange";
					}
					case 41:
					{
						return "Knochenschlange";
					}
					case 42:
					{
						return "Hornisse";
					}
					case 43:
					{
						return "Menschenfresser";
					}
					case 44:
					{
						return "Bergmann-Untoter";
					}
					case 45:
					{
						return "Tim";
					}
					case 46:
					{
						return "Haeschen";
					}
					case 47:
					{
						return "Verderbnishaeschen";
					}
					case 48:
					{
						return "Harpyie";
					}
					case 49:
					{
						return "Hoehlenfledermaus";
					}
					case 50:
					{
						return "Schleimi-Koenig";
					}
					case 51:
					{
						return "Dschungelfledermaus";
					}
					case 52:
					{
						return "Doktor Bones";
					}
					case 53:
					{
						return "Braeutigam";
					}
					case 54:
					{
						return "Kleiderhaendler";
					}
					case 55:
					{
						return "Goldfisch";
					}
					case 56:
					{
						return "Schnapper";
					}
					case 57:
					{
						return "Verderbnisgoldfisch";
					}
					case 58:
					{
						return "Piranha";
					}
					case 59:
					{
						return "Lava-Schleimi";
					}
					case 60:
					{
						return "Hoellenfledermaus";
					}
					case 61:
					{
						return "Geier";
					}
					case 62:
					{
						return "Daemon";
					}
					case 63:
					{
						return "Blauqualle";
					}
					case 64:
					{
						return "Pinkqualle";
					}
					case 65:
					{
						return "Hai";
					}
					case 66:
					{
						return "Voodoo-Daemon";
					}
					case 67:
					{
						return "Krabbe";
					}
					case 68:
					{
						return "Dungeon-Waechter";
					}
					case 69:
					{
						return "Ameisenloewe";
					}
					case 70:
					{
						return "Nagelball";
					}
					case 71:
					{
						return "Dungeon-Schleimi";
					}
					case 72:
					{
						return "Flammenrad";
					}
					case 73:
					{
						return "Goblin-Spaeher";
					}
					case 74:
					{
						return "Vogel";
					}
					case 75:
					{
						return "Pixie";
					}
					case 76:
					{
						return "";
					}
					case 77:
					{
						return "Ruestungsskelett";
					}
					case 78:
					{
						return "Mumie";
					}
					case 79:
					{
						return "Finstermumie";
					}
					case 80:
					{
						return "Lichtmumie";
					}
					case 81:
					{
						return "Verderbnisschleimi";
					}
					case 82:
					{
						return "Monstergeist";
					}
					case 83:
					{
						return "Fluchhammer";
					}
					case 84:
					{
						return "Zauberschwert";
					}
					case 85:
					{
						return "Imitator";
					}
					case 86:
					{
						return "Einhorn";
					}
					case 87:
					{
						return "Lindwurm";
					}
					case 88:
					{
						return "Lindwurm";
					}
					case 89:
					{
						return "Lindwurm";
					}
					case 90:
					{
						return "Lindwurm";
					}
					case 91:
					{
						return "Lindwurm";
					}
					case 92:
					{
						return "Lindwurm";
					}
					case 93:
					{
						return "Riesenfledermaus";
					}
					case 94:
					{
						return "Verderber";
					}
					case 95:
					{
						return "Wuehler";
					}
					case 96:
					{
						return "Wuehler";
					}
					case 97:
					{
						return "Wuehler";
					}
					case 98:
					{
						return "Weltspeiser";
					}
					case 99:
					{
						return "Weltspeiser";
					}
					case 100:
					{
						return "Weltspeiser";
					}
					case 101:
					{
						return "Klette";
					}
					case 102:
					{
						return "Seeteufel";
					}
					case 103:
					{
						return "Gruenqualle";
					}
					case 104:
					{
						return "Werwolf";
					}
					case 105:
					{
						return "Gebundener Goblin";
					}
					case 106:
					{
						return "Gebundener Zauberer";
					}
					case 107:
					{
						return "Goblin-Tueftler";
					}
					case 108:
					{
						return "Zauberer";
					}
					case 109:
					{
						return "Clown";
					}
					case 110:
					{
						return "Skelettbogenschuetze";
					}
					case 111:
					{
						return "Goblin-Bogenschuetze";
					}
					case 112:
					{
						return "Ekelspeichel";
					}
					case 113:
					{
						return "Fleischwand";
					}
					case 114:
					{
						return "Fleischwand";
					}
					case 115:
					{
						return "Fressmaul";
					}
					case 116:
					{
						return "Fressmaul";
					}
					case 117:
					{
						return "Blutegel";
					}
					case 118:
					{
						return "Blutegel";
					}
					case 119:
					{
						return "Blutegel";
					}
					case 120:
					{
						return "Elementarchaos";
					}
					case 121:
					{
						return "Flugschleimi";
					}
					case 122:
					{
						return "Bauchfuessler";
					}
					case 123:
					{
						return "Gebundene Mechanikerin";
					}
					case 124:
					{
						return "Mechanikerin";
					}
					case 125:
					{
						return "Retinator";
					}
					case 126:
					{
						return "Spasmator";
					}
					case 127:
					{
						return "Super-Skeletron";
					}
					case 128:
					{
						return "Super-Kanone";
					}
					case 129:
					{
						return "Super-Saege";
					}
					case 130:
					{
						return "Super-Zange";
					}
					case 131:
					{
						return "Super-Laser";
					}
					case 132:
					{
						return "Zombie";
					}
					case 133:
					{
						return "Wanderauge";
					}
					case 134:
					{
						return "Zerstoerer";
					}
					case 135:
					{
						return "Zerstoerer";
					}
					case 136:
					{
						return "Zerstoerer";
					}
					case 137:
					{
						return "Leuchtledermaus";
					}
					case 138:
					{
						return "Leuchtschleimi";
					}
					case 139:
					{
						return "Sonde";
					}
					case 140:
					{
						return "Geisterruestung";
					}
					case 141:
					{
						return "Giftschlamm";
					}
					case 142:
					{
						return "Weihnachtsmann";
					}
					case 143:
					{
						return "Snowman Gangsta";
					}
					case 144:
					{
						return "Herr Stabby";
					}
					case 145:
					{
						return "Schnee Balla";
					}
				}
			}
			else if (Lang.lang == 3)
			{
				switch (l)
				{
					case -17:
					{
						return "Vespa grande";
					}
					case -16:
					{
						return "Vespa piccola";
					}
					case -15:
					{
						return "Scheletro pesante";
					}
					case -14:
					{
						return "Disossato";
					}
					case -13:
					{
						return "Ossa corte";
					}
					case -12:
					{
						return "Grande mangiatore";
					}
					case -11:
					{
						return "Piccolo mangiatore";
					}
					case -10:
					{
						return "Slime della giungla";
					}
					case -9:
					{
						return "Slime giallo";
					}
					case -8:
					{
						return "Slime rosso";
					}
					case -7:
					{
						return "Slime viola";
					}
					case -6:
					{
						return "Slime nero";
					}
					case -5:
					{
						return "Slime baby";
					}
					case -4:
					{
						return "Mignolo";
					}
					case -3:
					{
						return "Slime verde";
					}
					case -2:
					{
						return "Slimer";
					}
					case -1:
					{
						return "Slimeling";
					}
					case 1:
					{
						return "Slime blu";
					}
					case 2:
					{
						return "Occhio demoniaco";
					}
					case 3:
					{
						return "Zombi";
					}
					case 4:
					{
						return "Occhio di Cthulhu";
					}
					case 5:
					{
						return "Servo di Cthulhu";
					}
					case 6:
					{
						return "Mangiatore di anime";
					}
					case 7:
					{
						return "Divoratore";
					}
					case 8:
					{
						return "Divoratore";
					}
					case 9:
					{
						return "Divoratore";
					}
					case 10:
					{
						return "Verme gigante";
					}
					case 11:
					{
						return "Verme gigante";
					}
					case 12:
					{
						return "Verme gigante";
					}
					case 13:
					{
						return "Mangiatore di mondi";
					}
					case 14:
					{
						return "Mangiatore di mondi";
					}
					case 15:
					{
						return "Mangiatore di mondi";
					}
					case 16:
					{
						return "Slime madre";
					}
					case 17:
					{
						return "Mercante";
					}
					case 18:
					{
						return "Infermiera";
					}
					case 19:
					{
						return "Mercante di armi";
					}
					case 20:
					{
						return "Driade";
					}
					case 21:
					{
						return "Scheletro";
					}
					case 22:
					{
						return "Guida";
					}
					case 23:
					{
						return "Testa di meteorite";
					}
					case 24:
					{
						return "Diavoletto di fuoco";
					}
					case 25:
					{
						return "Sfera infuocata";
					}
					case 26:
					{
						return "Goblin operaio";
					}
					case 27:
					{
						return "Goblin ladro";
					}
					case 28:
					{
						return "Goblin guerriero";
					}
					case 29:
					{
						return "Goblin stregone";
					}
					case 30:
					{
						return "Palla del caos";
					}
					case 31:
					{
						return "Ossa arrabbiate";
					}
					case 32:
					{
						return "Lanciatore oscuro";
					}
					case 33:
					{
						return "Sfera d'acqua";
					}
					case 34:
					{
						return "Teschio maledetto";
					}
					case 35:
					{
						return "Skeletron";
					}
					case 36:
					{
						return "Skeletron";
					}
					case 37:
					{
						return "Vecchio";
					}
					case 38:
					{
						return "Esperto in demolizioni";
					}
					case 39:
					{
						return "Serpente di ossa";
					}
					case 40:
					{
						return "Serpente di ossa";
					}
					case 41:
					{
						return "Serpente di ossa";
					}
					case 42:
					{
						return "Calabrone";
					}
					case 43:
					{
						return "Mangiauomini";
					}
					case 44:
					{
						return "Minatore non-morto";
					}
					case 45:
					{
						return "Tim";
					}
					case 46:
					{
						return "Coniglio";
					}
					case 47:
					{
						return "Coniglio distrutto";
					}
					case 48:
					{
						return "Arpia";
					}
					case 49:
					{
						return "Pipistrello della caverna";
					}
					case 50:
					{
						return "Slime re";
					}
					case 51:
					{
						return "Pipistrello della giungla";
					}
					case 52:
					{
						return "Dottor ossa";
					}
					case 53:
					{
						return "Lo sposo";
					}
					case 54:
					{
						return "Mercante di abiti";
					}
					case 55:
					{
						return "Pesce rosso";
					}
					case 56:
					{
						return "Pianta afferratrice";
					}
					case 57:
					{
						return "Pesce rosso distrutto";
					}
					case 58:
					{
						return "Piranha";
					}
					case 59:
					{
						return "Slime di lava";
					}
					case 60:
					{
						return "Pipistrello dell'inferno";
					}
					case 61:
					{
						return "Avvoltoio";
					}
					case 62:
					{
						return "Demone";
					}
					case 63:
					{
						return "Medusa blu";
					}
					case 64:
					{
						return "Medusa rosa";
					}
					case 65:
					{
						return "Squalo";
					}
					case 66:
					{
						return "Demone voodoo";
					}
					case 67:
					{
						return "Granchio";
					}
					case 68:
					{
						return "Guardiano delle segrete";
					}
					case 69:
					{
						return "Formicaleone";
					}
					case 70:
					{
						return "Sfera con spuntoni";
					}
					case 71:
					{
						return "Slime delle segrete";
					}
					case 72:
					{
						return "Ruota ardente";
					}
					case 73:
					{
						return "Goblin ricognitore";
					}
					case 74:
					{
						return "Uccello";
					}
					case 75:
					{
						return "Folletto";
					}
					case 76:
					{
						return "";
					}
					case 77:
					{
						return "Scheletro corazzato";
					}
					case 78:
					{
						return "Mummia";
					}
					case 79:
					{
						return "Mummia oscura";
					}
					case 80:
					{
						return "Mummia chiara";
					}
					case 81:
					{
						return "Slime distrutto";
					}
					case 82:
					{
						return "Fantasma";
					}
					case 83:
					{
						return "Martello maledetto";
					}
					case 84:
					{
						return "Spada incantata";
					}
					case 85:
					{
						return "Sosia";
					}
					case 86:
					{
						return "Unicorno";
					}
					case 87:
					{
						return "Viverna";
					}
					case 88:
					{
						return "Viverna";
					}
					case 89:
					{
						return "Viverna";
					}
					case 90:
					{
						return "Viverna";
					}
					case 91:
					{
						return "Viverna";
					}
					case 92:
					{
						return "Viverna";
					}
					case 93:
					{
						return "Pipistrello gigante";
					}
					case 94:
					{
						return "Distruttore";
					}
					case 95:
					{
						return "Scavatore";
					}
					case 96:
					{
						return "Scavatore";
					}
					case 97:
					{
						return "Scavatore";
					}
					case 98:
					{
						return "Alimentatore del mondo";
					}
					case 99:
					{
						return "Alimentatore del mondo";
					}
					case 100:
					{
						return "Alimentatore del mondo";
					}
					case 101:
					{
						return "Appiccicoso";
					}
					case 102:
					{
						return "Rana pescatrice";
					}
					case 103:
					{
						return "Medusa verde";
					}
					case 104:
					{
						return "Lupo mannaro";
					}
					case 105:
					{
						return "Goblin legato";
					}
					case 106:
					{
						return "Stregone legato";
					}
					case 107:
					{
						return "Goblin inventore";
					}
					case 108:
					{
						return "Stregone";
					}
					case 109:
					{
						return "Clown";
					}
					case 110:
					{
						return "Scheletro arciere";
					}
					case 111:
					{
						return "Goblin arciere";
					}
					case 112:
					{
						return "Bava disgustosa";
					}
					case 113:
					{
						return "Muro di carne";
					}
					case 114:
					{
						return "Muro di carne";
					}
					case 115:
					{
						return "L'Affamato";
					}
					case 116:
					{
						return "L'Affamato";
					}
					case 117:
					{
						return "Sanguisuga";
					}
					case 118:
					{
						return "Sanguisuga";
					}
					case 119:
					{
						return "Sanguisuga";
					}
					case 120:
					{
						return "Elementale del caos";
					}
					case 121:
					{
						return "Slimer";
					}
					case 122:
					{
						return "Gasteropodo";
					}
					case 123:
					{
						return "Meccanico legata";
					}
					case 124:
					{
						return "Meccanico";
					}
					case 125:
					{
						return "Retinazer";
					}
					case 126:
					{
						return "Spazmatism";
					}
					case 127:
					{
						return "Skeletron primario";
					}
					case 128:
					{
						return "Cannone primario";
					}
					case 129:
					{
						return "Sega primaria";
					}
					case 130:
					{
						return "Morsa primaria";
					}
					case 131:
					{
						return "Laser primario";
					}
					case 132:
					{
						return "Zombi";
					}
					case 133:
					{
						return "Occhio errante";
					}
					case 134:
					{
						return "Il Distruttore";
					}
					case 135:
					{
						return "Il Distruttore";
					}
					case 136:
					{
						return "Il Distruttore";
					}
					case 137:
					{
						return "Pipistrello illuminante";
					}
					case 138:
					{
						return "Slime illuminante";
					}
					case 139:
					{
						return "Sonda";
					}
					case 140:
					{
						return "Armatura posseduta";
					}
					case 141:
					{
						return "Fango tossico";
					}
					case 142:
					{
						return "Babbo Natale";
					}
					case 143:
					{
						return "pupazzo di neve Gangsta";
					}
					case 144:
					{
						return "signor Stabby";
					}
					case 145:
					{
						return "neve Balla";
					}
				}
			}
			else if (Lang.lang == 4)
			{
				switch (l)
				{
					case -17:
					{
						return "Gros frelon";
					}
					case -16:
					{
						return "Petit frelon";
					}
					case -15:
					{
						return "Squelette lourd";
					}
					case -14:
					{
						return "Grand squelette";
					}
					case -13:
					{
						return "Petit squelette";
					}
					case -12:
					{
						return "Grand dévoreur";
					}
					case -11:
					{
						return "Petit dévoreur";
					}
					case -10:
					{
						return "Slime de la jungle";
					}
					case -9:
					{
						return "Slime jaune";
					}
					case -8:
					{
						return "Slime rouge";
					}
					case -7:
					{
						return "Slime violet";
					}
					case -6:
					{
						return "Slime noir";
					}
					case -5:
					{
						return "Bébé slime";
					}
					case -4:
					{
						return "Pinky";
					}
					case -3:
					{
						return "Slime vert";
					}
					case -2:
					{
						return "Slimer";
					}
					case -1:
					{
						return "Slimeling";
					}
					case 1:
					{
						return "Slime bleu";
					}
					case 2:
					{
						return "Œil de démon";
					}
					case 3:
					{
						return "Zombie";
					}
					case 4:
					{
						return "Œil de Cthulhu";
					}
					case 5:
					{
						return "Servant de Cthulhu";
					}
					case 6:
					{
						return "Dévoreur d'âmes";
					}
					case 7:
					{
						return "Dévoreur";
					}
					case 8:
					{
						return "Dévoreur";
					}
					case 9:
					{
						return "Dévoreur";
					}
					case 10:
					{
						return "Ver géant";
					}
					case 11:
					{
						return "Ver géant";
					}
					case 12:
					{
						return "Ver géant";
					}
					case 13:
					{
						return "Dévoreur de mondes";
					}
					case 14:
					{
						return "Dévoreur de mondes";
					}
					case 15:
					{
						return "Dévoreur de mondes";
					}
					case 16:
					{
						return "Mère slime";
					}
					case 17:
					{
						return "Marchand";
					}
					case 18:
					{
						return "Infirmière";
					}
					case 19:
					{
						return "Marchand d'armes";
					}
					case 20:
					{
						return "Dryade";
					}
					case 21:
					{
						return "Squelette";
					}
					case 22:
					{
						return "Guide";
					}
					case 23:
					{
						return "Tête de météorite";
					}
					case 24:
					{
						return "Diablotin de feu";
					}
					case 25:
					{
						return "Sphère brûlante";
					}
					case 26:
					{
						return "Péon gobelin";
					}
					case 27:
					{
						return "Voleur gobelin";
					}
					case 28:
					{
						return "Guerrier gobelin";
					}
					case 29:
					{
						return "Sorcier gobelin";
					}
					case 30:
					{
						return "Boule de chaos";
					}
					case 31:
					{
						return "Squelette furieux";
					}
					case 32:
					{
						return "Magicien noir";
					}
					case 33:
					{
						return "Sphère d'eau";
					}
					case 34:
					{
						return "Crâne maudit";
					}
					case 35:
					{
						return "Squeletron";
					}
					case 36:
					{
						return "Squeletron";
					}
					case 37:
					{
						return "Vieil homme";
					}
					case 38:
					{
						return "Démolisseur";
					}
					case 39:
					{
						return "Serpent d'os";
					}
					case 40:
					{
						return "Serpent d'os";
					}
					case 41:
					{
						return "Serpent d'os";
					}
					case 42:
					{
						return "Frelon";
					}
					case 43:
					{
						return "Mangeur d'hommes";
					}
					case 44:
					{
						return "Mineur mort-vivant";
					}
					case 45:
					{
						return "Tim";
					}
					case 46:
					{
						return "Lapin";
					}
					case 47:
					{
						return "Lapin corrompu";
					}
					case 48:
					{
						return "Harpie";
					}
					case 49:
					{
						return "Chauve-souris";
					}
					case 50:
					{
						return "Roi slime";
					}
					case 51:
					{
						return "Chauve-souris de la jungle";
					}
					case 52:
					{
						return "Docteur Bones";
					}
					case 53:
					{
						return "Le jeune marié";
					}
					case 54:
					{
						return "Tailleur";
					}
					case 55:
					{
						return "Poisson doré";
					}
					case 56:
					{
						return "Ravisseur";
					}
					case 57:
					{
						return "Poisson doré corrompu";
					}
					case 58:
					{
						return "Piranha";
					}
					case 59:
					{
						return "Slime de l'enfer";
					}
					case 60:
					{
						return "Chauve-souris de l'enfer";
					}
					case 61:
					{
						return "Vautour";
					}
					case 62:
					{
						return "Démon";
					}
					case 63:
					{
						return "Méduse bleue";
					}
					case 64:
					{
						return "Méduse rose";
					}
					case 65:
					{
						return "Requin";
					}
					case 66:
					{
						return "Démon vaudou";
					}
					case 67:
					{
						return "Crabe";
					}
					case 68:
					{
						return "Gardien du donjon";
					}
					case 69:
					{
						return "Fourmilion";
					}
					case 70:
					{
						return "Boule piquante";
					}
					case 71:
					{
						return "Slime des donjons";
					}
					case 72:
					{
						return "Roue de feu";
					}
					case 73:
					{
						return "Scout gobelin";
					}
					case 74:
					{
						return "Oiseau";
					}
					case 75:
					{
						return "Lutin";
					}
					case 76:
					{
						return "";
					}
					case 77:
					{
						return "Squelette en armure";
					}
					case 78:
					{
						return "Momie";
					}
					case 79:
					{
						return "Momie de l'ombre";
					}
					case 80:
					{
						return "Momie de lumière";
					}
					case 81:
					{
						return "Slime corrompu";
					}
					case 82:
					{
						return "Spectre";
					}
					case 83:
					{
						return "Marteau maudit";
					}
					case 84:
					{
						return "Épée enchantée";
					}
					case 85:
					{
						return "Imitateur";
					}
					case 86:
					{
						return "Licorne";
					}
					case 87:
					{
						return "Wyverne";
					}
					case 88:
					{
						return "Wyverne";
					}
					case 89:
					{
						return "Wyverne";
					}
					case 90:
					{
						return "Wyverne";
					}
					case 91:
					{
						return "Wyverne";
					}
					case 92:
					{
						return "Wyverne";
					}
					case 93:
					{
						return "Chauve-souris géante";
					}
					case 94:
					{
						return "Corrupteur";
					}
					case 95:
					{
						return "Fouisseur";
					}
					case 96:
					{
						return "Fouisseur";
					}
					case 97:
					{
						return "Fouisseur";
					}
					case 98:
					{
						return "Nourricier";
					}
					case 99:
					{
						return "Nourricier";
					}
					case 100:
					{
						return "Nourricier";
					}
					case 101:
					{
						return "Cracheur";
					}
					case 102:
					{
						return "Baudroie";
					}
					case 103:
					{
						return "Méduse verte";
					}
					case 104:
					{
						return "Loup-garou";
					}
					case 105:
					{
						return "Gobelin attaché";
					}
					case 106:
					{
						return "Magicien attaché";
					}
					case 107:
					{
						return "Gobelin bricoleur";
					}
					case 108:
					{
						return "Magicien";
					}
					case 109:
					{
						return "Clown";
					}
					case 110:
					{
						return "Archer squelette";
					}
					case 111:
					{
						return "Archer gobelin";
					}
					case 112:
					{
						return "Immonde crachat";
					}
					case 113:
					{
						return "Mur de chair";
					}
					case 114:
					{
						return "Mur de chair";
					}
					case 115:
					{
						return "L'affamé";
					}
					case 116:
					{
						return "L'affamé";
					}
					case 117:
					{
						return "Sangsue";
					}
					case 118:
					{
						return "Sangsue";
					}
					case 119:
					{
						return "Sangsue";
					}
					case 120:
					{
						return "Élémentaire du chaos";
					}
					case 121:
					{
						return "Slimer";
					}
					case 122:
					{
						return "Gastropode";
					}
					case 123:
					{
						return "Mécanicienne attachée";
					}
					case 124:
					{
						return "Mécanicienne";
					}
					case 125:
					{
						return "Rétinazer";
					}
					case 126:
					{
						return "Spazmatisme";
					}
					case 127:
					{
						return "Squeletron primaire";
					}
					case 128:
					{
						return "Canon primaire";
					}
					case 129:
					{
						return "Scie primaire";
					}
					case 130:
					{
						return "Étau principal";
					}
					case 131:
					{
						return "Laser principal";
					}
					case 132:
					{
						return "Zombie";
					}
					case 133:
					{
						return "Œil vagabond";
					}
					case 134:
					{
						return "Le destructeur";
					}
					case 135:
					{
						return "Le destructeur";
					}
					case 136:
					{
						return "Le destructeur";
					}
					case 137:
					{
						return "Chauve-souris illuminée";
					}
					case 138:
					{
						return "Slime illuminé";
					}
					case 139:
					{
						return "Sonde";
					}
					case 140:
					{
						return "Armure possédée";
					}
					case 141:
					{
						return "Boue toxique";
					}
					case 142:
					{
						return "Père Noël";
					}
					case 143:
					{
						return "Snowman Gangsta";
					}
					case 144:
					{
						return "Monsieur Stabby";
					}
					case 145:
					{
						return "neige Balla";
					}
				}
			}
			else if (Lang.lang == 5)
			{
				switch (l)
				{
					case -17:
					{
						return "Gran avispa";
					}
					case -16:
					{
						return "Avispa pequeña";
					}
					case -15:
					{
						return "Esqueleto pesado";
					}
					case -14:
					{
						return "Gran deshuesado";
					}
					case -13:
					{
						return "Pequeño deshuesado";
					}
					case -12:
					{
						return "Gran devorador";
					}
					case -11:
					{
						return "Pequeño devorador";
					}
					case -10:
					{
						return "Babosa de selva";
					}
					case -9:
					{
						return "Babosa amarilla";
					}
					case -8:
					{
						return "Babosa roja";
					}
					case -7:
					{
						return "Babosa morada";
					}
					case -6:
					{
						return "Babosa negra";
					}
					case -5:
					{
						return "Bebé babosa";
					}
					case -4:
					{
						return "Babosa rosa";
					}
					case -3:
					{
						return "Babosa verde";
					}
					case -2:
					{
						return "Baboseadora";
					}
					case -1:
					{
						return "Babosas";
					}
					case 1:
					{
						return "Babosa azul";
					}
					case 2:
					{
						return "Ojo demoníaco";
					}
					case 3:
					{
						return "Zombi";
					}
					case 4:
					{
						return "Ojo Cthulhu";
					}
					case 5:
					{
						return "Siervo de Cthulhu";
					}
					case 6:
					{
						return "Devoraalmas";
					}
					case 7:
					{
						return "Gusano devorador";
					}
					case 8:
					{
						return "Gusano devorador";
					}
					case 9:
					{
						return "Gusano devorador";
					}
					case 10:
					{
						return "Gusano gigante";
					}
					case 11:
					{
						return "Gusano gigante";
					}
					case 12:
					{
						return "Gusano gigante";
					}
					case 13:
					{
						return "Devoramundos";
					}
					case 14:
					{
						return "Devoramundos";
					}
					case 15:
					{
						return "Devoramundos";
					}
					case 16:
					{
						return "Mamá babosa";
					}
					case 17:
					{
						return "Mercader";
					}
					case 18:
					{
						return "Enfermera";
					}
					case 19:
					{
						return "Traficante de armas";
					}
					case 20:
					{
						return "Dríada";
					}
					case 21:
					{
						return "Esqueleto";
					}
					case 22:
					{
						return "Guía";
					}
					case 23:
					{
						return "Cabeza meteorito";
					}
					case 24:
					{
						return "Diablillo de fuego";
					}
					case 25:
					{
						return "Esfera ardiente";
					}
					case 26:
					{
						return "Duende Peón";
					}
					case 27:
					{
						return "Duende ladrón";
					}
					case 28:
					{
						return "Duende guerrero";
					}
					case 29:
					{
						return "Duende hechicero";
					}
					case 30:
					{
						return "Bola del caos";
					}
					case 31:
					{
						return "Deshuesado furioso";
					}
					case 32:
					{
						return "Fundidor siniestro";
					}
					case 33:
					{
						return "Esfera de agua";
					}
					case 34:
					{
						return "Cráneo maldito";
					}
					case 35:
					{
						return "Esqueletrón";
					}
					case 36:
					{
						return "Esqueletrón";
					}
					case 37:
					{
						return "Anciano";
					}
					case 38:
					{
						return "Dinamitero";
					}
					case 39:
					{
						return "Esqueleto de serpiente";
					}
					case 40:
					{
						return "Esqueleto de serpiente";
					}
					case 41:
					{
						return "Esqueleto de serpiente";
					}
					case 42:
					{
						return "Avispón";
					}
					case 43:
					{
						return "Devorahombres";
					}
					case 44:
					{
						return "Minero zombi";
					}
					case 45:
					{
						return "Tim";
					}
					case 46:
					{
						return "Conejito";
					}
					case 47:
					{
						return "Conejito corrompido";
					}
					case 48:
					{
						return "Arpía";
					}
					case 49:
					{
						return "Murciélago de cueva";
					}
					case 50:
					{
						return "Babosa rey";
					}
					case 51:
					{
						return "Murciélago de selva";
					}
					case 52:
					{
						return "Doctor Látigo";
					}
					case 53:
					{
						return "El novio zombi";
					}
					case 54:
					{
						return "Buhonero";
					}
					case 55:
					{
						return "Pececillo";
					}
					case 56:
					{
						return "Atrapadora";
					}
					case 57:
					{
						return "Pececillo corrompido";
					}
					case 58:
					{
						return "Piraña";
					}
					case 59:
					{
						return "Babosa de lava";
					}
					case 60:
					{
						return "Murciélago infernal";
					}
					case 61:
					{
						return "Buitre";
					}
					case 62:
					{
						return "Demonio";
					}
					case 63:
					{
						return "Medusa azul";
					}
					case 64:
					{
						return "Medusa rosa";
					}
					case 65:
					{
						return "Tiburón";
					}
					case 66:
					{
						return "Demonio vudú";
					}
					case 67:
					{
						return "Cangrejo";
					}
					case 68:
					{
						return "Guardián de la mazmorra";
					}
					case 69:
					{
						return "Hormiga león";
					}
					case 70:
					{
						return "Bola Gancho";
					}
					case 71:
					{
						return "Babosa de la mazmorra";
					}
					case 72:
					{
						return "Rueda ardiente";
					}
					case 73:
					{
						return "Duende explorador";
					}
					case 74:
					{
						return "Pájaro";
					}
					case 75:
					{
						return "Duendecillo";
					}
					case 76:
					{
						return "";
					}
					case 77:
					{
						return "Esqueleto con armadura";
					}
					case 78:
					{
						return "Momia";
					}
					case 79:
					{
						return "Momia de la oscuridad";
					}
					case 80:
					{
						return "Momia de la luz";
					}
					case 81:
					{
						return "Babosa corrompida";
					}
					case 82:
					{
						return "Espectro";
					}
					case 83:
					{
						return "Martillo maldito";
					}
					case 84:
					{
						return "Espada encantada";
					}
					case 85:
					{
						return "Cofre falso";
					}
					case 86:
					{
						return "Unicornio";
					}
					case 87:
					{
						return "Guiverno";
					}
					case 88:
					{
						return "Guiverno";
					}
					case 89:
					{
						return "Guiverno";
					}
					case 90:
					{
						return "Guiverno";
					}
					case 91:
					{
						return "Guiverno";
					}
					case 92:
					{
						return "Guiverno";
					}
					case 93:
					{
						return "Murciélago gigante";
					}
					case 94:
					{
						return "Corruptor";
					}
					case 95:
					{
						return "Excavador";
					}
					case 96:
					{
						return "Excavador";
					}
					case 97:
					{
						return "Excavador";
					}
					case 98:
					{
						return "Tragamundos";
					}
					case 99:
					{
						return "Tragamundos";
					}
					case 100:
					{
						return "Tragamundos";
					}
					case 101:
					{
						return "Lapa";
					}
					case 102:
					{
						return "Rape";
					}
					case 103:
					{
						return "Medusa verde";
					}
					case 104:
					{
						return "Hombre lobo";
					}
					case 105:
					{
						return "Duende cautivo";
					}
					case 106:
					{
						return "Mago cautivo";
					}
					case 107:
					{
						return "Duende reparador";
					}
					case 108:
					{
						return "Mago";
					}
					case 109:
					{
						return "Payaso";
					}
					case 110:
					{
						return "Esqueleto arquero";
					}
					case 111:
					{
						return "Duende arquero";
					}
					case 112:
					{
						return "Escupitajo vil";
					}
					case 113:
					{
						return "Muro carnoso";
					}
					case 114:
					{
						return "Muro carnoso";
					}
					case 115:
					{
						return "El Famélico";
					}
					case 116:
					{
						return "El Famélico";
					}
					case 117:
					{
						return "Sanguijuela";
					}
					case 118:
					{
						return "Sanguijuela";
					}
					case 119:
					{
						return "Sanguijuela";
					}
					case 120:
					{
						return "Caos elemental";
					}
					case 121:
					{
						return "Baboseadora";
					}
					case 122:
					{
						return "Gasterópodo";
					}
					case 123:
					{
						return "Mecánico cautivo";
					}
					case 124:
					{
						return "Mecánico";
					}
					case 125:
					{
						return "Retinator";
					}
					case 126:
					{
						return "Espasmatizador";
					}
					case 127:
					{
						return "Esqueleto mayor";
					}
					case 128:
					{
						return "Cañón mayor";
					}
					case 129:
					{
						return "Sierra mayor";
					}
					case 130:
					{
						return "Torno mayor";
					}
					case 131:
					{
						return "Láser mayor";
					}
					case 132:
					{
						return "Zombi";
					}
					case 133:
					{
						return "Ojo errante";
					}
					case 134:
					{
						return "El Destructor";
					}
					case 135:
					{
						return "El Destructor";
					}
					case 136:
					{
						return "El Destructor";
					}
					case 137:
					{
						return "Murciélago luminoso";
					}
					case 138:
					{
						return "Babosa luminosa";
					}
					case 139:
					{
						return "Sonda";
					}
					case 140:
					{
						return "Armadura poseída";
					}
					case 141:
					{
						return "Fango tóxico";
					}
					case 142:
					{
						return "Papá Noel";
					}
					case 143:
					{
						return "muñeco de nieve Gangsta";
					}
					case 144:
					{
						return "señor Stabby";
					}
					case 145:
					{
						return "Balla nieve";
					}
				}
			}
			if (english || Lang.lang <= 1)
			{
				return "";
			}
			return Lang.npcName(l, true);
		}

		public static string setBonus(int l, bool english = false)
		{
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
					case 0:
					{
						return "2 defense";
					}
					case 1:
					{
						return "3 defense";
					}
					case 2:
					{
						return "15% increased movement speed";
					}
					case 3:
					{
						return "Space Gun costs 0 mana";
					}
					case 4:
					{
						return "20% chance to not consume ammo";
					}
					case 5:
					{
						return "16% reduced mana usage";
					}
					case 6:
					{
						return "17% extra melee damage";
					}
					case 7:
					{
						return "30% increased mining speed";
					}
					case 8:
					{
						return "14% reduced mana usage";
					}
					case 9:
					{
						return "15% increased melee speed";
					}
					case 10:
					{
						return "20% chance to not consume ammo";
					}
					case 11:
					{
						return "17% reduced mana usage";
					}
					case 12:
					{
						return "5% increased melee critical strike chance";
					}
					case 13:
					{
						return "20% chance to not consume ammo";
					}
					case 14:
					{
						return "19% reduced mana usage";
					}
					case 15:
					{
						return "18% increased melee and movement speed";
					}
					case 16:
					{
						return "25% chance to not consume ammo";
					}
					case 17:
					{
						return "20% reduced mana usage";
					}
					case 18:
					{
						return "19% increased melee and movement speed";
					}
					case 19:
					{
						return "25% chance to not consume ammo";
					}
					case 20:
					{
						return "1 defense";
					}
					case 21:
					{
						return "Greatly increased life regen";
					}
					case 22:
					{
						return "Melee and ranged attacks cause frostburn";
					}
					case 23:
					{
						return "Increases your max number of minions";
					}
					case 24:
					{
						return "Greatly increases life regeneration after striking an enemy";
					}
					case 25:
					{
						return "Flower petals will fall on your target for extra damage";
					}
					case 26:
					{
						return "Become immune after striking an enemy";
					}
					case 27:
					{
						return "Summons a powerful leaf crystal to shoot at nearby enemies";
					}
					case 28:
					{
						return "10% increased magic critical strike chance";
					}
					case 29:
					{
						return "Attackers also take full damage";
					}
					case 30:
					{
						return "Magic damage done to enemies heals the player with lowest health";
					}
					case 31:
					{
						return "Not moving puts you in stealth,\nincreasing ranged ability and reducing chance for enemies to target you";
					}
					case 32:
					{
						return "4 defense";
					}
					case 33:
					{
						return "10% increased damage";
					}
					case 34:
					{
						return "Increases minion damage by 25%";
					}
					case 35:
					{
						return "Magic damage done will hurt extra nearby enemies";
					}
					case 36:
					{
						return "Increases maximum mana by 60";
					}
					case 37:
					{
						return "Beetles protect you from damage";
					}
					case 38:
					{
						return "Beetles increase your melee damage and speed";
					}
					case 39:
					{
						return "Increases minion damage by 10%";
					}
					case 40:
					{
						return "Increases minion damage by 12%";
					}
					case 41:
					{
						return "33% chance to not consume thrown item";
					}
					case 42:
					{
						return "50% chance to not consume thrown item";
					}
					case 43:
					{
						return "Solar shields generate over time protecting you,\nconsume the shield power to dash, damaging enemies";
					}
					case 44:
					{
						return "Double tap DOWN to toggle stealth,\nincreasing ranged ability and reducing chance for enemies to target you but slowing movement speed";
					}
					case 45:
					{
						return "Hurting enemies has a chance to spawn buff boosters,\npick boosters up to get stacking buffs";
					}
					case 46:
					{
						return "Double tap DOWN to direct your guardian to a location";
					}
				}
			}
			else if (Lang.lang == 2)
			{
				switch (l)
				{
					case 0:
					{
						return "2 Abwehr";
					}
					case 1:
					{
						return "3 Abwehr";
					}
					case 2:
					{
						return "Um 15% erhoehtes Bewegungstempo";
					}
					case 3:
					{
						return "Astralpistole kostet 0 Mana";
					}
					case 4:
					{
						return "20%ige Chance, Munition nicht zu verbrauchen";
					}
					case 5:
					{
						return "Um 16% reduzierte Mananutzung";
					}
					case 6:
					{
						return "17% Extra Nahkampfschaden";
					}
					case 7:
					{
						return "Um 20% erhoehtes Abbautempo";
					}
					case 8:
					{
						return "Um 14% reduzierte Mananutzung";
					}
					case 9:
					{
						return "Um 15% erhoehtes Nahkampftempo";
					}
					case 10:
					{
						return "20%ige Chance, Munition nicht zu verbrauchen";
					}
					case 11:
					{
						return "Um 17% reduzierte Mananutzung";
					}
					case 12:
					{
						return "5% Erhoehte kritische Nahkampf-Trefferchance";
					}
					case 13:
					{
						return "20%ige Chance, Munition nicht zu verbrauchen";
					}
					case 14:
					{
						return "Um 19% reduzierte Mananutzung";
					}
					case 15:
					{
						return "18% Erhoehtes Nahkampf-und Bewegungstempo";
					}
					case 16:
					{
						return "25%ige Chance, Munition nicht zu verbrauchen";
					}
					case 17:
					{
						return "Um 20% reduzierte Mananutzung";
					}
					case 18:
					{
						return "19% Erhoehtes Nahkampf-und Bewegungstempo";
					}
					case 19:
					{
						return "25%ige Chance, Munition nicht zu verbrauchen";
					}
					case 20:
					{
						return "4 defense";
					}
				}
			}
			else if (Lang.lang == 3)
			{
				switch (l)
				{
					case 0:
					{
						return "2 difesa";
					}
					case 1:
					{
						return "3 difesa";
					}
					case 2:
					{
						return "Velocità di movimento aumentata del 15%";
					}
					case 3:
					{
						return "La pistola spaziale costa 0 mana";
					}
					case 4:
					{
						return "20% di possibilità di non consumare munizioni";
					}
					case 5:
					{
						return "Consumo mana ridotto del 16%";
					}
					case 6:
					{
						return "17% i danni melee in più";
					}
					case 7:
					{
						return "Velocità di estrazione aumentata del 20%";
					}
					case 8:
					{
						return "Consumo mana ridotto del 14%";
					}
					case 9:
					{
						return "Velocità del corpo a corpo aumentata del 15%";
					}
					case 10:
					{
						return "20% di possibilità di non consumare munizioni";
					}
					case 11:
					{
						return "Consumo mana ridotto del 17%";
					}
					case 12:
					{
						return "5% Possibilità di colpo critico nel corpo a corpo aumentata";
					}
					case 13:
					{
						return "20% di possibilità di non consumare munizioni";
					}
					case 14:
					{
						return "Consumo mana ridotto del 19%";
					}
					case 15:
					{
						return "18% Velocità di corpo a corpo e movimento aumentata";
					}
					case 16:
					{
						return "25% di possibilità di non consumare munizioni";
					}
					case 17:
					{
						return "Consumo mana ridotto del 20%";
					}
					case 18:
					{
						return "19% Velocità di corpo a corpo e movimento aumentata";
					}
					case 19:
					{
						return "25% di possibilità di non consumare munizioni";
					}
				}
			}
			else if (Lang.lang == 4)
			{
				switch (l)
				{
					case 0:
					{
						return "2 de défense";
					}
					case 1:
					{
						return "3 de défense";
					}
					case 2:
					{
						return "Vitesse de déplacement augmentée de 15 %";
					}
					case 3:
					{
						return "Le fusil de l'espace coûte 0 mana";
					}
					case 4:
					{
						return "20 % de chance de n'utiliser aucune munition";
					}
					case 5:
					{
						return "Utilisation de mana réduite de 16 %";
					}
					case 6:
					{
						return "17% de dégâts de mêlée supplémentaires";
					}
					case 7:
					{
						return "Vitesse d'extraction minière augmentée de 20 %";
					}
					case 8:
					{
						return "Utilisation de mana réduite de 14 %";
					}
					case 9:
					{
						return "Vitesse de mêlée augmentée de 15 %";
					}
					case 10:
					{
						return "20 % de chance de n'utiliser aucune munition";
					}
					case 11:
					{
						return "Utilisation de mana réduite de 17 %";
					}
					case 12:
					{
						return "5% Chance de coup critique de mêlée augmentée";
					}
					case 13:
					{
						return "20 % de chance de n'utiliser aucune munition";
					}
					case 14:
					{
						return "Utilisation de mana réduite de 19 %";
					}
					case 15:
					{
						return "18% Vitesse de mouvement et de mêlée augmentée";
					}
					case 16:
					{
						return "25 % de chance de n'utiliser aucune munition";
					}
					case 17:
					{
						return "Utilisation de mana réduite de 20 %";
					}
					case 18:
					{
						return "19% Vitesse de mouvement et de mêlée augmentée";
					}
					case 19:
					{
						return "25 % de chance de n'utiliser aucune munition";
					}
				}
			}
			else if (Lang.lang == 5)
			{
				switch (l)
				{
					case 0:
					{
						return "2 defensa";
					}
					case 1:
					{
						return "3 defensa";
					}
					case 2:
					{
						return "Aumenta en un 15% la velocidad de movimiento";
					}
					case 3:
					{
						return "La pistola espacial no cuesta maná";
					}
					case 4:
					{
						return "Probabilidad del 20% de no gastar munición";
					}
					case 5:
					{
						return "Reduce el uso de maná en un 16%";
					}
					case 6:
					{
						return "17% de daño cuerpo a cuerpo adicional";
					}
					case 7:
					{
						return "Aumenta en un 20% la velocidad de excavación";
					}
					case 8:
					{
						return "Reduce el uso de maná en un 14%";
					}
					case 9:
					{
						return "Aumenta un 15% la velocidad en el cuerpo a cuerpo";
					}
					case 10:
					{
						return "Probabilidad del 20% de no gastar munición";
					}
					case 11:
					{
						return "Reduce el uso de maná en un 17%";
					}
					case 12:
					{
						return "Aumenta la probabilidad de ataque crítico en el cuerpo a cuerpo";
					}
					case 13:
					{
						return "Probabilidad del 20% de no gastar munición";
					}
					case 14:
					{
						return "Reduce el uso de maná en un 19%";
					}
					case 15:
					{
						return "18% Aumenta la velocidad de movimiento y en el cuerpo a cuerpo";
					}
					case 16:
					{
						return "Probabilidad del 25% de no gastar munición";
					}
					case 17:
					{
						return "Reduce el uso de maná en un 20%";
					}
					case 18:
					{
						return "19% Aumenta la velocidad de movimiento y en el cuerpo a cuerpo";
					}
					case 19:
					{
						return "Probabilidad del 25% de no gastar munición";
					}
				}
			}
			if (english || Lang.lang <= 1)
			{
				return "";
			}
			return Lang.setBonus(l, true);
		}

		public static void setLang(bool english = false)
		{
			Main.chTitle = true;
			if (Lang.lang <= 1 || english)
			{
				Lang.misc[0] = "A goblin army has been defeated!";
				Lang.misc[1] = "A goblin army is approaching from the west!";
				Lang.misc[2] = "A goblin army is approaching from the east!";
				Lang.misc[3] = "A goblin army has arrived!";
				Lang.misc[4] = "The Frost Legion has been defeated!";
				Lang.misc[5] = "The Frost Legion is approaching from the west!";
				Lang.misc[6] = "The Frost Legion is approaching from the east!";
				Lang.misc[7] = "The Frost Legion has arrived!";
				Lang.misc[8] = "The Blood Moon is rising...";
				Lang.misc[9] = "You feel an evil presence watching you...";
				Lang.misc[10] = "A horrible chill goes down your spine...";
				Lang.misc[11] = "Screams echo around you...";
				Lang.misc[12] = "Your world has been blessed with Cobalt!";
				Lang.misc[13] = "Your world has been blessed with Mythril!";
				Lang.misc[14] = "Your world has been blessed with Adamantite!";
				Lang.misc[15] = "The ancient spirits of light and dark have been released.";
				Lang.misc[16] = "has awoken!";
				Lang.misc[17] = "has been defeated!";
				Lang.misc[18] = "has arrived!";
				Lang.misc[19] = " was slain...";
				Lang.misc[20] = "A solar eclipse is happening!";
				Lang.misc[21] = "Your world has been blessed with Palladium!";
				Lang.misc[22] = "Your world has been blessed with Orichalcum!";
				Lang.misc[23] = "Your world has been blessed with Titanium!";
				Lang.misc[24] = "The pirates have been defeated!";
				Lang.misc[25] = "Pirates are approaching from the west!";
				Lang.misc[26] = "Pirates are approaching from the east!";
				Lang.misc[27] = "The pirates have arrived!";
				Lang.misc[28] = "You feel vibrations from deep below...";
				Lang.misc[29] = "This is going to be a terrible night...";
				Lang.misc[30] = "The air is getting colder around you...";
				Lang.misc[31] = "The Pumpkin Moon is rising...";
				Lang.misc[32] = "The jungle grows restless...";
				Lang.misc[33] = "Screams are echoing from the dungeon...";
				Lang.misc[34] = "The Frost Moon is rising...";
				Lang.misc[35] = "has departed!";
				Lang.misc[36] = " has left!";
				Lang.misc[37] = "Any";
				Lang.misc[38] = "Pressure Plate";
				Lang.misc[39] = " and increased life regeneration";
				Lang.misc[40] = "Increases life regeneration";
				Lang.misc[41] = "Martians are invading!";
				Lang.misc[42] = "The martians have been defeated!";
				Lang.misc[43] = "Celestial creatures are invading!";
				Lang.misc[44] = "Your mind goes numb...";
				Lang.misc[45] = "You are overwhelmed with pain...";
				Lang.misc[46] = "Otherworldly voices linger around you...";
				Lang.misc[47] = "The Moon Lord has awoken!";
				Lang.misc[48] = "The Twins have awoken!";
				Lang.misc[49] = "You wake up from a strange dream...";
				Lang.misc[50] = "have been defeated!";
				Lang.misc[51] = "Lunar Fragment";
				Lang.misc[52] = "Impending doom approaches...";
				Lang.menu[0] = "Start a new instance of Terraria to join!";
				Lang.menu[1] = "Running on port ";
				Lang.menu[2] = "Disconnect";
				Lang.menu[3] = "Server Requires Password:";
				Lang.menu[4] = "Accept";
				Lang.menu[5] = "Back";
				Lang.menu[6] = "Cancel";
				Lang.menu[7] = "Enter Server Password:";
				Lang.menu[8] = "Starting server...";
				Lang.menu[9] = "Load failed!";
				Lang.menu[10] = "Load Backup";
				Lang.menu[11] = "No backup found";
				Lang.menu[12] = "Single Player";
				Lang.menu[13] = "Multiplayer";
				Lang.menu[14] = "Settings";
				Lang.menu[15] = "Exit";
				Lang.menu[16] = "Create Character";
				Lang.menu[17] = "Delete";
				Lang.menu[18] = "Hair";
				Lang.menu[19] = "Eyes";
				Lang.menu[20] = "Skin";
				Lang.menu[21] = "Clothes";
				Lang.menu[22] = "Male";
				Lang.menu[23] = "Female";
				Lang.menu[24] = "Hardcore";
				Lang.menu[25] = "Mediumcore";
				Lang.menu[26] = "Softcore";
				Lang.menu[27] = "Random";
				Lang.menu[28] = "Create";
				Lang.menu[29] = "Hardcore characters die for good";
				Lang.menu[30] = "Mediumcore characters drop items on death";
				Lang.menu[31] = "Softcore characters drop money on death";
				Lang.menu[32] = "Select difficulty";
				Lang.menu[33] = "Shirt";
				Lang.menu[34] = "Undershirt";
				Lang.menu[35] = "Pants";
				Lang.menu[36] = "Shoes";
				Lang.menu[37] = "Hair";
				Lang.menu[38] = "Hair Color";
				Lang.menu[39] = "Eye Color";
				Lang.menu[40] = "Skin Color";
				Lang.menu[41] = "Shirt Color";
				Lang.menu[42] = "Undershirt Color";
				Lang.menu[43] = "Pants Color";
				Lang.menu[44] = "Shoe Color";
				Lang.menu[45] = "Enter Character Name:";
				Lang.menu[46] = "Delete";
				Lang.menu[47] = "Create World";
				Lang.menu[48] = "Enter World Name:";
				Lang.menu[49] = "Go Windowed";
				Lang.menu[50] = "Go Fullscreen";
				Lang.menu[51] = "Resolution";
				Lang.menu[52] = "Parallax";
				Lang.menu[53] = "Frame Skip Off";
				Lang.menu[54] = "Frame Skip On";
				Lang.menu[55] = "Lighting: Color";
				Lang.menu[56] = "Lighting: White";
				Lang.menu[57] = "Lighting: Retro";
				Lang.menu[58] = "Lighting: Trippy";
				Lang.menu[59] = "Quality: Auto";
				Lang.menu[60] = "Quality: High";
				Lang.menu[61] = "Quality: Medium";
				Lang.menu[62] = "Quality: Low";
				Lang.menu[63] = "Video";
				Lang.menu[64] = "Cursor Color";
				Lang.menu[65] = "Volume";
				Lang.menu[66] = "Controls";
				Lang.menu[67] = "Autosave On";
				Lang.menu[68] = "Autosave Off";
				Lang.menu[69] = "Autopause On";
				Lang.menu[70] = "Autopause Off";
				Lang.menu[71] = "Pickup Text On";
				Lang.menu[72] = "Pickup Text Off";
				Lang.menu[73] = "Fullscreen Resolution";
				Lang.menu[74] = "Up                ";
				Lang.menu[75] = "Down             ";
				Lang.menu[76] = "Left               ";
				Lang.menu[77] = "Right             ";
				Lang.menu[78] = "Jump             ";
				Lang.menu[79] = "Throw            ";
				Lang.menu[80] = "Inventory         ";
				Lang.menu[81] = "Quick Heal       ";
				Lang.menu[82] = "Quick Mana      ";
				Lang.menu[83] = "Quick Buff       ";
				Lang.menu[84] = "Grapple           ";
				Lang.menu[85] = "Auto Select       ";
				Lang.menu[86] = "Reset to Default";
				Lang.menu[87] = "Join";
				Lang.menu[88] = "Host & Play";
				Lang.menu[89] = "Enter Server IP Address:";
				Lang.menu[90] = "Enter Server Port:";
				Lang.menu[91] = "Choose world size:";
				Lang.menu[92] = "Small";
				Lang.menu[93] = "Medium";
				Lang.menu[94] = "Large";
				Lang.menu[95] = "Red:";
				Lang.menu[96] = "Green:";
				Lang.menu[97] = "Blue:";
				Lang.menu[98] = "Sound:";
				Lang.menu[99] = "Music:";
				Lang.menu[100] = "Background On";
				Lang.menu[101] = "Background Off";
				Lang.menu[102] = "Select language";
				Lang.menu[103] = "Language";
				Lang.menu[104] = "Yes";
				Lang.menu[105] = "No";
				Lang.menu[106] = "Toggle Map Style           ";
				Lang.menu[107] = "Toggle Fullscreen           ";
				Lang.menu[108] = "Zoom In                      ";
				Lang.menu[109] = "Zoom Out                    ";
				Lang.menu[110] = "Decrease Transparency     ";
				Lang.menu[111] = "Increase Transparency      ";
				Lang.menu[112] = "Map Enabled";
				Lang.menu[113] = "Map Disabled";
				Lang.menu[114] = "General";
				Lang.menu[115] = "Map Controls";
				Lang.menu[116] = "Multicore Lighting:";
				Lang.menu[117] = "Off";
				Lang.menu[118] = "Close Menu";
				Lang.menu[119] = "Ambient";
				Lang.menu[120] = "Smart Cursor    ";
				Lang.menu[121] = "Smart Cursor Mode Toggle";
				Lang.menu[122] = "Smart Cursor Mode Hold";
				Lang.menu[123] = "Event Progress Bar";
				Lang.menu[124] = "Off";
				Lang.menu[125] = "Timed";
				Lang.menu[126] = "On";
				Lang.menu[127] = "Style";
				Lang.menu[128] = "Placement Preview On";
				Lang.menu[129] = "Placement Preview Off";
				Lang.menu[130] = "Mount             ";
				Lang.menu[131] = "Achievements";
				Lang.menu[132] = "Blood and Gore On";
				Lang.menu[133] = "Blood and Gore Off";
				Lang.menu[134] = "Apply";
				Lang.menu[135] = "Steam Multiplayer Mode:";
				Lang.menu[136] = "Off";
				Lang.menu[137] = "Invite Only";
				Lang.menu[138] = "Friends Only";
				Lang.menu[139] = "Join via Steam";
				Lang.menu[140] = "Join via IP";
				Lang.menu[141] = "Invite Friends";
				Lang.gen[0] = "Generating world terrain";
				Lang.gen[1] = "Adding sand";
				Lang.gen[2] = "Generating hills";
				Lang.gen[3] = "Puttin dirt behind dirt";
				Lang.gen[4] = "Placing rocks in the dirt";
				Lang.gen[5] = "Placing dirt in the rocks";
				Lang.gen[6] = "Adding clay";
				Lang.gen[7] = "Making random holes";
				Lang.gen[8] = "Generating small caves";
				Lang.gen[9] = "Generating large caves";
				Lang.gen[10] = "Generating surface caves";
				Lang.gen[11] = "Generating jungle";
				Lang.gen[12] = "Generating floating islands";
				Lang.gen[13] = "Adding mushroom patches";
				Lang.gen[14] = "Placing mud in the dirt";
				Lang.gen[15] = "Adding silt";
				Lang.gen[16] = "Adding shinies";
				Lang.gen[17] = "Adding webs";
				Lang.gen[18] = "Creating underworld";
				Lang.gen[19] = "Adding water bodies";
				Lang.gen[20] = "Making the world evil";
				Lang.gen[21] = "Generating mountain caves";
				Lang.gen[22] = "Creating beaches";
				Lang.gen[23] = "Adding gems";
				Lang.gen[24] = "Gravitating sand";
				Lang.gen[25] = "Cleaning up dirt backgrounds";
				Lang.gen[26] = "Placing altars";
				Lang.gen[27] = "Settling liquids";
				Lang.gen[28] = "Placing life crystals";
				Lang.gen[29] = "Placing statues";
				Lang.gen[30] = "Hiding treasure";
				Lang.gen[31] = "Hiding more treasure";
				Lang.gen[32] = "Hiding jungle treasure";
				Lang.gen[33] = "Hiding water treasure";
				Lang.gen[34] = "Placing traps";
				Lang.gen[35] = "Placing breakables";
				Lang.gen[36] = "Placing hellforges";
				Lang.gen[37] = "Spreading grass";
				Lang.gen[38] = "Growing cacti";
				Lang.gen[39] = "Planting sunflowers";
				Lang.gen[40] = "Planting trees";
				Lang.gen[41] = "Planting herbs";
				Lang.gen[42] = "Planting weeds";
				Lang.gen[43] = "Growing vines";
				Lang.gen[44] = "Planting flowers";
				Lang.gen[45] = "Planting mushrooms";
				Lang.gen[46] = "Freeing unused resources";
				Lang.gen[47] = "Resetting game objects";
				Lang.gen[48] = "Setting hard mode";
				Lang.gen[49] = "Saving world data:";
				Lang.gen[50] = "Backing up world file";
				Lang.gen[51] = "Loading world data:";
				Lang.gen[52] = "Checking tile alignment:";
				Lang.gen[53] = "Load failed!";
				Lang.gen[54] = "No backup found.";
				Lang.gen[55] = "Finding tile frames:";
				Lang.gen[56] = "Adding snow";
				Lang.gen[57] = "World";
				Lang.gen[58] = "Creating dungeon";
				Lang.gen[59] = "A meteorite has landed!";
				Lang.gen[60] = "Smoothing the world";
				Lang.gen[61] = "Mossification";
				Lang.gen[62] = "Gemification";
				Lang.gen[63] = "Making cave walls";
				Lang.gen[64] = "Growing spider caves";
				Lang.gen[65] = "Clearing map data:";
				Lang.gen[66] = "Saving map data:";
				Lang.gen[67] = "Loading map data:";
				Lang.gen[68] = "Drawing map:";
				Lang.gen[69] = "Creating waterfalls";
				Lang.gen[70] = "Creating jungle ruins";
				Lang.gen[71] = "Creating hornet nests";
				Lang.gen[72] = "Making the world bloody";
				Lang.gen[73] = "Validating world save:";
				Lang.gen[74] = "Slime is falling from the sky!";
				Lang.gen[75] = "Slime has stopped falling from the sky.";
				Lang.gen[76] = "Generating Structures.";
				Lang.gen[77] = "Adding more grass";
				Lang.gen[78] = "Desertification";
				Lang.gen[79] = "Spicing up walls";
				Lang.gen[80] = "Chiseling marble";
				Lang.gen[81] = "Growing granite";
				Lang.inter[0] = "Life:";
				Lang.inter[1] = "Breath";
				Lang.inter[2] = "Mana";
				Lang.inter[3] = "Trash Can";
				Lang.inter[4] = "Inventory";
				Lang.inter[5] = "Hotbar unlocked";
				Lang.inter[6] = "Hotbar locked";
				Lang.inter[7] = "Housing";
				Lang.inter[8] = "Housing Query";
				Lang.inter[9] = "Accessory";
				Lang.inter[10] = "Defense";
				Lang.inter[11] = "Social";
				Lang.inter[12] = "Helmet";
				Lang.inter[13] = "Shirt";
				Lang.inter[14] = "Pants";
				Lang.inter[15] = "platinum";
				Lang.inter[16] = "gold";
				Lang.inter[17] = "silver";
				Lang.inter[18] = "copper";
				Lang.inter[19] = "Reforge";
				Lang.inter[20] = "Place an item here to reforge";
				Lang.inter[21] = "Showing recipes that use";
				Lang.inter[22] = "Required objects:";
				Lang.inter[23] = "None";
				Lang.inter[24] = "Place a material here";
				Lang.inter[25] = "Crafting";
				Lang.inter[26] = "Coins";
				Lang.inter[27] = "Ammo";
				Lang.inter[28] = "Shop";
				Lang.inter[29] = "Loot All";
				Lang.inter[30] = "Deposit All";
				Lang.inter[31] = "Quick Stack";
				Lang.inter[32] = "Piggy Bank";
				Lang.inter[33] = "Safe";
				Lang.inter[34] = "Time";
				Lang.inter[35] = "Save & Exit";
				Lang.inter[36] = "Disconnect";
				Lang.inter[37] = "Items";
				Lang.inter[38] = "You were slain...";
				Lang.inter[39] = "This housing is suitable.";
				Lang.inter[40] = "This is not valid housing.";
				Lang.inter[41] = "This housing is already occupied.";
				Lang.inter[42] = "This housing is corrupted.";
				Lang.inter[43] = "Connection timed out";
				Lang.inter[44] = "Receiving tile data";
				Lang.inter[45] = "Equip";
				Lang.inter[46] = "Cost";
				Lang.inter[47] = "Save";
				Lang.inter[48] = "Edit";
				Lang.inter[49] = "Status";
				Lang.inter[50] = "Curse";
				Lang.inter[51] = "Help";
				Lang.inter[52] = "Close";
				Lang.inter[53] = "Water";
				Lang.inter[54] = "Heal";
				Lang.inter[55] = "This housing does not meet the requirements for a";
				Lang.inter[56] = "Lava";
				Lang.inter[57] = "Dye";
				Lang.inter[58] = "Honey";
				Lang.inter[59] = "Visible";
				Lang.inter[60] = "Hidden";
				Lang.inter[61] = "Rename";
				Lang.inter[62] = "Settings";
				Lang.inter[63] = "Cancel";
				Lang.inter[64] = "Quest";
				Lang.inter[65] = "Quest Item";
				Lang.inter[66] = "Savings";
				Lang.inter[67] = "Take Snapshot";
				Lang.inter[68] = "Settings";
				Lang.inter[69] = "Pin Frame";
				Lang.inter[70] = "Set Frame";
				Lang.inter[71] = "Close";
				Lang.inter[72] = "On";
				Lang.inter[73] = "Off";
				Lang.inter[74] = "Image Packing";
				Lang.inter[75] = "Capture Entities";
				Lang.inter[76] = "Capture Background";
				Lang.inter[77] = "Biome Pick";
				Lang.inter[78] = "Reset Frame";
				Lang.inter[79] = "Equipment";
				Lang.inter[80] = "Housing";
				Lang.inter[81] = "Camera Mode";
				Lang.inter[82] = "Restock";
				Lang.inter[83] = "Frost Moon";
				Lang.inter[84] = "Pumpkin Moon";
				Lang.inter[85] = "Martian Madness";
				Lang.inter[86] = "Pirate Invasion";
				Lang.inter[87] = "Frost Legion";
				Lang.inter[88] = "Goblin Army";
				Lang.inter[89] = "Collect";
				Lang.inter[90] = "Grappling Hook";
				Lang.inter[91] = "Mount";
				Lang.inter[92] = "Pet";
				Lang.inter[93] = "Minecart";
				Lang.inter[94] = "Light Pet";
				Lang.inter[95] = "Time";
				Lang.inter[96] = "Weather";
				Lang.inter[97] = "Fishing";
				Lang.inter[98] = "Position";
				Lang.inter[99] = "Depth";
				Lang.inter[100] = "Creature Count";
				Lang.inter[101] = "Kill Count";
				Lang.inter[102] = "Moon Phase";
				Lang.inter[103] = "Movement Speed";
				Lang.inter[104] = "Treasure";
				Lang.inter[105] = "Rare Creatures";
				Lang.inter[106] = "Damage Per Second";
				Lang.inter[107] = "Strange Plants";
				Lang.inter[108] = "Open Map";
				Lang.inter[109] = "Close Map";
				Lang.inter[110] = "Open Folder";
				Lang.inter[111] = "Take Screenshot";
				Lang.inter[112] = "You must first set a frame";
				Lang.inter[113] = "Only available in windowed mode";
				Lang.inter[114] = "Only available if map is enabled";
				Lang.tip[0] = "Equipped in social slot";
				Lang.tip[1] = "No stats will be gained";
				Lang.tip[2] = " melee damage";
				Lang.tip[3] = " ranged damage";
				Lang.tip[4] = " magic damage";
				Lang.tip[5] = "% critical strike chance";
				Lang.tip[6] = "Insanely fast speed";
				Lang.tip[7] = "Very fast speed";
				Lang.tip[8] = "Fast speed";
				Lang.tip[9] = "Average speed";
				Lang.tip[10] = "Slow speed";
				Lang.tip[11] = "Very slow speed";
				Lang.tip[12] = "Extremely slow speed";
				Lang.tip[13] = "Snail speed";
				Lang.tip[14] = "No knockback";
				Lang.tip[15] = "Extremely weak knockback";
				Lang.tip[16] = "Very weak knockback";
				Lang.tip[17] = "Weak knockback";
				Lang.tip[18] = "Average knockback";
				Lang.tip[19] = "Strong knockback";
				Lang.tip[20] = "Very strong knockback";
				Lang.tip[21] = "Extremely strong knockback";
				Lang.tip[22] = "Insane knockback";
				Lang.tip[23] = "Equipable";
				Lang.tip[24] = "Vanity Item";
				Lang.tip[25] = " defense";
				Lang.tip[26] = "% pickaxe power";
				Lang.tip[27] = "% axe power";
				Lang.tip[28] = "% hammer power";
				Lang.tip[29] = "Restores";
				Lang.tip[30] = "life";
				Lang.tip[31] = "mana";
				Lang.tip[32] = "Uses";
				Lang.tip[33] = "Can be placed";
				Lang.tip[34] = "Ammo";
				Lang.tip[35] = "Consumable";
				Lang.tip[36] = "Material";
				Lang.tip[37] = " minute duration";
				Lang.tip[38] = " second duration";
				Lang.tip[39] = "% damage";
				Lang.tip[40] = "% speed";
				Lang.tip[41] = "% critical strike chance";
				Lang.tip[42] = "% mana cost";
				Lang.tip[43] = "% size";
				Lang.tip[44] = "% velocity";
				Lang.tip[45] = "% knockback";
				Lang.tip[46] = "% movement speed";
				Lang.tip[47] = "% melee speed";
				Lang.tip[48] = "Set bonus:";
				Lang.tip[49] = "Sell price:";
				Lang.tip[50] = "Buy price:";
				Lang.tip[51] = "No value";
				Lang.tip[52] = "Consumes ";
				Lang.tip[53] = " summon damage";
				Lang.tip[54] = " range";
				Lang.tip[55] = " damage";
				Lang.tip[56] = "Marked as favorite";
				Lang.tip[57] = "Quick trash, stacking, and selling will be blocked";
				Lang.tip[58] = " throwing damage";
				Lang.tip[59] = "It has been cursed by a powerful Jungle creature";
				Lang.mp[0] = "Recieve:";
				Lang.mp[1] = "Incorrect password.";
				Lang.mp[2] = "Invalid operation at this state.";
				Lang.mp[3] = "你被封号了";
				Lang.mp[4] = "客户端版本不一致";
				Lang.mp[5] = "已在服务器中";
				Lang.mp[6] = "/playing";
				Lang.mp[7] = "Current players:";
				Lang.mp[8] = "/roll";
				Lang.mp[9] = "rolls a";
				Lang.mp[10] = "您不在队伍中";
				Lang.mp[11] = "has enabled PvP!";
				Lang.mp[12] = "has disabled PvP!";
				Lang.mp[13] = "已退出队伍";
				Lang.mp[14] = "已加入红队";
				Lang.mp[15] = "已加入绿队";
				Lang.mp[16] = "已加入蓝队";
				Lang.mp[17] = "已加入黄队";
				Lang.mp[18] = "Welcome to";
				Lang.mp[19] = "已加入";
				Lang.mp[20] = "已退出";
				Lang.mp[21] = "/players";
				Lang.mp[22] = "已加入粉队";
				Lang.the = "the ";
				Lang.dt[0] = "couldn't find the antidote.";
				Lang.dt[1] = "couldn't put the fire out.";
				Lang.dt[2] = "couldn't breathe.";
				Lang.dt[3] = "couldn't contain the watts.";
				Main.buffName[1] = "Obsidian Skin";
				Main.buffTip[1] = "Immune to lava";
				Main.buffName[2] = "Regeneration";
				Main.buffTip[2] = "Provides life regeneration";
				Main.buffName[3] = "Swiftness";
				Main.buffTip[3] = "25% increased movement speed";
				Main.buffName[4] = "Gills";
				Main.buffTip[4] = "Breathe water instead of air";
				Main.buffName[5] = "Ironskin";
				Main.buffTip[5] = "Increase defense by 8";
				Main.buffName[6] = "Mana Regeneration";
				Main.buffTip[6] = "Increased mana regeneration";
				Main.buffName[7] = "Magic Power";
				Main.buffTip[7] = "20% increased magic damage";
				Main.buffName[8] = "Featherfall";
				Main.buffTip[8] = "Press UP or DOWN to control speed of descent";
				Main.buffName[9] = "Spelunker";
				Main.buffTip[9] = "Shows the location of treasure and ore";
				Main.buffName[10] = "Invisibility";
				Main.buffTip[10] = "Grants invisibility";
				Main.buffName[11] = "Shine";
				Main.buffTip[11] = "Emitting light";
				Main.buffName[12] = "Night Owl";
				Main.buffTip[12] = "Increased night vision";
				Main.buffName[13] = "Battle";
				Main.buffTip[13] = "Increased enemy spawn rate";
				Main.buffName[14] = "Thorns";
				Main.buffTip[14] = "Attackers also take damage";
				Main.buffName[15] = "Water Walking";
				Main.buffTip[15] = "Press DOWN to enter water";
				Main.buffName[16] = "Archery";
				Main.buffTip[16] = "20% increased arrow damage and speed";
				Main.buffName[17] = "Hunter";
				Main.buffTip[17] = "Shows the location of enemies";
				Main.buffName[18] = "Gravitation";
				Main.buffTip[18] = "Press UP to reverse gravity";
				Main.buffName[19] = "Shadow Orb";
				Main.buffTip[19] = "A magical orb that provides light";
				Main.buffName[20] = "Poisoned";
				Main.buffTip[20] = "Slowly losing life";
				Main.buffName[21] = "Potion Sickness";
				Main.buffTip[21] = "Cannot consume anymore healing items";
				Main.buffName[22] = "Darkness";
				Main.buffTip[22] = "Decreased light vision";
				Main.buffName[23] = "Cursed";
				Main.buffTip[23] = "Cannot use any items";
				Main.buffName[24] = "On Fire!";
				Main.buffTip[24] = "Slowly losing life";
				Main.buffName[25] = "Tipsy";
				Main.buffTip[25] = "Increased melee abilities, lowered defense";
				Main.buffName[26] = "Well Fed";
				Main.buffTip[26] = "Minor improvements to all stats";
				Main.buffName[27] = "Fairy";
				Main.buffTip[27] = "A fairy is following you";
				Main.buffName[28] = "Werewolf";
				Main.buffTip[28] = "Physical abilities are increased";
				Main.buffName[29] = "Clairvoyance";
				Main.buffTip[29] = "Magic powers are increased";
				Main.buffName[30] = "Bleeding";
				Main.buffTip[30] = "Cannot regenerate life";
				Main.buffName[31] = "Confused";
				Main.buffTip[31] = "Movement is reversed";
				Main.buffName[32] = "Slow";
				Main.buffTip[32] = "Movement speed is reduced";
				Main.buffName[33] = "Weak";
				Main.buffTip[33] = "Physical abilities are decreased";
				Main.buffName[34] = "Merfolk";
				Main.buffTip[34] = "Can breathe and move easily underwater";
				Main.buffName[35] = "Silenced";
				Main.buffTip[35] = "Cannot use items that require mana";
				Main.buffName[36] = "Broken Armor";
				Main.buffTip[36] = "Defense is cut in half";
				Main.buffName[37] = "Horrified";
				Main.buffTip[37] = "You have seen something nasty, there is no escape.";
				Main.buffName[38] = "The Tongue";
				Main.buffTip[38] = "You are being sucked into the mouth";
				Main.buffName[39] = "Cursed Inferno";
				Main.buffTip[39] = "Losing life";
				Main.buffName[40] = "Pet Bunny";
				Main.buffTip[40] = "I think it wants your carrot";
				Main.buffName[41] = "Baby Penguin";
				Main.buffTip[41] = "I think it wants your fish";
				Main.buffName[42] = "Pet Turtle";
				Main.buffTip[42] = "Happy turtle time!";
				Main.buffName[43] = "Paladin's Shield";
				Main.buffTip[43] = "25% of damage taken will be redirected to another player";
				Main.buffName[44] = "Frostburn";
				Main.buffTip[44] = "It's either really hot or really cold. Either way it REALLY hurts";
				Main.buffName[45] = "Baby Eater";
				Main.buffTip[45] = "A baby Eater of Souls is following you";
				Main.buffName[46] = "Chilled";
				Main.buffTip[46] = "Your movement speed has been reduced";
				Main.buffName[47] = "Frozen";
				Main.buffTip[47] = "You can't move!";
				Main.buffName[48] = "Honey";
				Main.buffTip[48] = "Life regeneration is increased";
				Main.buffName[49] = "Pygmies";
				Main.buffTip[49] = "The pygmies will fight for you";
				Main.buffName[50] = "Baby Skeletron Head";
				Main.buffTip[50] = "Don't even ask...";
				Main.buffName[51] = "Baby Hornet";
				Main.buffTip[51] = "It thinks you are its mother";
				Main.buffName[52] = "Tiki Spirit";
				Main.buffTip[52] = "A friendly spirit is following you";
				Main.buffName[53] = "Pet Lizard";
				Main.buffTip[53] = "Chillin' like a reptilian";
				Main.buffName[54] = "Pet Parrot";
				Main.buffTip[54] = "Polly want's the cracker";
				Main.buffName[55] = "Baby Truffle";
				Main.buffTip[55] = "Isn't this just soooo cute?";
				Main.buffName[56] = "Pet Sapling";
				Main.buffTip[56] = "A little sapling is following you";
				Main.buffName[57] = "Wisp";
				Main.buffTip[57] = "A wisp is following you";
				Main.buffName[58] = "Rapid Healing";
				Main.buffTip[58] = "Life regeneration is greatly increased";
				Main.buffName[59] = "Shadow Dodge";
				Main.buffTip[59] = "You will dodge the next attack";
				Main.buffName[60] = "Leaf Crystal";
				Main.buffTip[60] = "Shoots crystal leaves at nearby enemies";
				Main.buffName[61] = "Baby Dinosaur";
				Main.buffTip[61] = "A baby dinosaur is following you";
				Main.buffName[62] = "Ice Barrier";
				Main.buffTip[62] = "Damage taken is reduced by 25%";
				Main.buffName[63] = "Panic!";
				Main.buffTip[63] = "Movement speed is increased";
				Main.buffName[64] = "Baby Slime";
				Main.buffTip[64] = "The baby slime will fight for you";
				Main.buffName[65] = "Eyeball Spring";
				Main.buffTip[65] = "An eyeball spring is following you";
				Main.buffName[66] = "Baby Snowman";
				Main.buffTip[66] = "A baby snowman is following you";
				Main.buffName[67] = "Burning";
				Main.buffTip[67] = "Losing life and slowed movement";
				Main.buffName[68] = "Suffocation";
				Main.buffTip[68] = "Losing life";
				Main.buffName[69] = "Ichor";
				Main.buffTip[69] = "Reduced defense";
				Main.buffName[70] = "Venom";
				Main.buffTip[70] = "Losing life";
				Main.buffName[72] = "Midas";
				Main.buffTip[72] = "Drop more money on death";
				Main.buffName[80] = "Blackout";
				Main.buffTip[80] = "Light vision severely reduced";
				Main.buffName[81] = "Pet Spider";
				Main.buffTip[81] = "A spider is following you";
				Main.buffName[82] = "Squashling";
				Main.buffTip[82] = "A squashling is following you";
				Main.buffName[83] = "Ravens";
				Main.buffTip[83] = "The ravens will attack your enemies";
				Main.buffName[84] = "Black Cat";
				Main.buffTip[84] = "A black kitty is following you";
				Main.buffName[85] = "Cursed Sapling";
				Main.buffTip[85] = "A cursed sapling is following you";
				Main.buffName[86] = "Water Candle";
				Main.buffTip[86] = "Increased monster spawn rate";
				Main.buffName[157] = "Peace Candle";
				Main.buffTip[157] = "Decreased monster spawn rate";
				Main.buffName[87] = "Cozy Fire";
				Main.buffTip[87] = "Life regen is slightly increased";
				Main.buffName[88] = "Chaos State";
				Main.buffTip[88] = "Using the Rod of Discord will take life";
				Main.buffName[89] = "Heart Lamp";
				Main.buffTip[89] = "Life regen is increased";
				Main.buffName[90] = "Rudolph";
				Main.buffTip[90] = "Riding the red nosed reindeer";
				Main.buffName[91] = "Puppy";
				Main.buffTip[91] = "A puppy is following you";
				Main.buffName[92] = "Baby Grinch";
				Main.buffTip[92] = "A baby grinch is following you";
				Main.buffName[93] = "Ammo Box";
				Main.buffTip[93] = "20% chance to not consume ammo";
				Main.buffName[94] = "Mana Sickness";
				Main.buffTip[94] = "Magic damage reduced by ";
				Main.buffName[95] = "Beetle Endurance";
				Main.buffTip[95] = "Damage taken reduced by 15%";
				Main.buffName[96] = "Beetle Endurance";
				Main.buffTip[96] = "Damage taken reduced by 30%";
				Main.buffName[97] = "Beetle Endurance";
				Main.buffTip[97] = "Damage taken reduced by 45%";
				Main.buffName[98] = "Beetle Might";
				Main.buffTip[98] = "Melee damage and speed increase by 10%";
				Main.buffName[99] = "Beetle Might";
				Main.buffTip[99] = "Melee damage and speed increase by 20%";
				Main.buffName[100] = "Beetle Might";
				Main.buffTip[100] = "Melee damage and speed increase by 30%";
				Main.buffName[101] = "Fairy";
				Main.buffTip[101] = "A fairy is following you";
				Main.buffName[102] = "Fairy";
				Main.buffTip[102] = "A fairy is following you";
				Main.buffName[103] = "Wet";
				Main.buffTip[103] = "You are dripping water";
				Main.buffName[104] = "Mining";
				Main.buffTip[104] = "25% increased mining speed";
				Main.buffName[105] = "Heartreach";
				Main.buffTip[105] = "Increased heart pickup range";
				Main.buffName[106] = "Calm";
				Main.buffTip[106] = "Reduced enemy aggression";
				Main.buffName[107] = "Builder";
				Main.buffTip[107] = "Increased placement speed and range";
				Main.buffName[108] = "Titan";
				Main.buffTip[108] = "Increased knockback";
				Main.buffName[109] = "Flipper";
				Main.buffTip[109] = "Move like normal in water";
				Main.buffName[110] = "Summoning";
				Main.buffTip[110] = "Increased max number of minions";
				Main.buffName[111] = "Dangersense";
				Main.buffTip[111] = "You can see nearby hazards";
				Main.buffName[112] = "Ammo Reservation";
				Main.buffTip[112] = "20% chance to not consume ammo";
				Main.buffName[113] = "Lifeforce";
				Main.buffTip[113] = "20% increased max life";
				Main.buffName[114] = "Endurance";
				Main.buffTip[114] = "10% reduced damage";
				Main.buffName[115] = "Rage";
				Main.buffTip[115] = "10% increased critical chance";
				Main.buffName[116] = "Inferno";
				Main.buffTip[116] = "Nearby enemies are ignited";
				Main.buffName[117] = "Wrath";
				Main.buffTip[117] = "10% increased damage";
				Main.buffName[118] = "Minecart";
				Main.buffTip[118] = "Riding in a minecart";
				Main.buffName[138] = "Minecart";
				Main.buffTip[138] = "Riding in a minecart";
				Main.buffName[119] = "Lovestruck";
				Main.buffTip[119] = "You are in love!";
				Main.buffName[120] = "Stinky";
				Main.buffTip[120] = "You smell terrible";
				Main.buffName[121] = "Fishing";
				Main.buffTip[121] = "Increased fishing level";
				Main.buffName[122] = "Sonar";
				Main.buffTip[122] = "You can see what's biting your hook";
				Main.buffName[123] = "Crate";
				Main.buffTip[123] = "Greater chance of fishing up a crate";
				Main.buffName[124] = "Warmth";
				Main.buffTip[124] = "Reduced damage from cold sources";
				Main.buffName[125] = "Hornet";
				Main.buffTip[125] = "The hornet will fight for you";
				Main.buffName[126] = "Imp";
				Main.buffTip[126] = "The imp will fight for you";
				Main.buffName[127] = "Zephyr Fish";
				Main.buffTip[127] = "It likes swimming around you";
				Main.buffName[128] = "Bunny Mount";
				Main.buffTip[128] = "You are craving carrots";
				Main.buffName[129] = "Pigron Mount";
				Main.buffTip[129] = "Now you see me....";
				Main.buffName[130] = "Slime Mount";
				Main.buffTip[130] = "BOOOIIINNNG!";
				Main.buffName[131] = "Turtle Mount";
				Main.buffTip[131] = "Slow if by land, zoom if by sea";
				Main.buffName[132] = "Bee Mount";
				Main.buffTip[132] = "BzzzBzzBZZZZBzzz";
				Main.buffName[133] = "Spider";
				Main.buffTip[133] = "The spider will fight for you";
				Main.buffName[134] = "Twins";
				Main.buffTip[134] = "The twins will fight for you";
				Main.buffName[135] = "Pirate";
				Main.buffTip[135] = "The pirate will fight for you";
				Main.buffName[136] = "Mini Minotaur";
				Main.buffTip[136] = "How do you defeat a mini Minotaur?";
				Main.buffName[137] = "Slime";
				Main.buffTip[137] = "You are slimy and sticky";
				Main.buffName[139] = "Sharknado";
				Main.buffTip[139] = "The sharknado will fight for you";
				Main.buffName[140] = "UFO";
				Main.buffTip[140] = "The UFO will fight for you";
				Main.buffName[141] = "UFO Mount";
				Main.buffTip[141] = "It's a good thing you had a MAC";
				Main.buffName[142] = "Drill Mount";
				Main.buffTip[142] = "Riding in a flying drill";
				Main.buffName[143] = "Scutlix Mount";
				Main.buffTip[143] = "Pew Pew";
				Main.buffName[144] = "Electrified";
				Main.buffTip[144] = "You cannot move";
				Main.buffName[145] = "The Line";
				Main.buffTip[145] = "You are being drained of life";
				Main.buffName[146] = "Happy!";
				Main.buffTip[146] = "Movement speed increased and monster spawns reduced";
				Main.buffName[147] = "Banner";
				Main.buffTip[147] = "Increased damage and defense from the following:";
				Main.buffName[148] = "Feral Bite";
				Main.buffTip[148] = "Increased damage, Decreased life regen, Causes status effects";
				Main.buffName[149] = "Webbed";
				Main.buffTip[149] = "You are stuck";
				Main.buffName[150] = "Bewitched";
				Main.buffTip[150] = "Increased max number of minions";
				Main.buffName[151] = "Life Drain";
				Main.buffTip[151] = "Increased life regeneration";
				Main.buffName[152] = "Magic Lantern";
				Main.buffTip[152] = "An enchanted lantern is lighting your way";
				Main.buffName[153] = "Shadowflame";
				Main.buffTip[153] = "Losing life";
				Main.buffName[155] = "Crimson Heart";
				Main.buffTip[155] = "A magical heart that provides light";
				Main.buffName[154] = "Baby Face Monster";
				Main.buffTip[154] = "A baby face monster is following you";
				Main.buffName[169] = "Penetrated";
				Main.buffTip[169] = "Bleeding Out";
				Main.buffName[182] = "Stardust Cell";
				Main.buffTip[182] = "The stardust cell will fight for you";
				Main.buffName[183] = "Celled";
				Main.buffTip[183] = "being eaten by cells";
				Main.buffName[186] = "Dryad's Bane";
				Main.buffTip[186] = "The power of nature compells you";
				Main.buffName[187] = "Stardust Guardian";
				Main.buffTip[187] = "The stardust guardian will protect you";
				Main.buffName[188] = "Stardust Dragon";
				Main.buffTip[188] = "The stardust dragon will protect you";
				Main.buffName[189] = "Daybroken";
				Main.buffTip[189] = "Incenerated by solar rays";
				Main.buffName[190] = "Suspicious Looking Eye";
				Main.buffTip[190] = "A suspicious looking eye that provides light";
				Main.buffName[156] = "Stoned";
				Main.buffTip[156] = "You are completely petrified!";
				Main.buffName[158] = "Star in a Bottle";
				Main.buffTip[158] = "Increased mana regeneration";
				Main.buffName[159] = "Sharpened";
				Main.buffTip[159] = "Melee weapons have armor penetration";
				Main.buffName[160] = "Dazed";
				Main.buffTip[160] = "Movement is greatly slowed";
				Main.buffName[161] = "Deadly Sphere";
				Main.buffTip[161] = "The Deadly Sphere will fight for you";
				Main.buffName[162] = "Unicorn Mount";
				Main.buffTip[162] = "Charge ahead... fabulously!";
				Main.buffName[163] = "Obstructed";
				Main.buffTip[163] = "You can't see!";
				Main.buffName[164] = "Distorted";
				Main.buffTip[164] = "Gravity around you is distorted";
				Main.buffName[165] = "Dryad's Blessing";
				Main.buffTip[165] = "The power of nature protects you";
				Main.buffName[166] = "Minecart";
				Main.buffTip[166] = "Riding in a minecart";
				Main.buffName[167] = "Minecart";
				Main.buffTip[167] = "Riding in a minecart";
				Main.buffName[168] = "Cute Fishron Mount";
				Main.buffTip[168] = "Just don't make it crawl.";
				Main.buffName[185] = "Minecart";
				Main.buffTip[185] = "Riding in a minecart";
				Main.buffName[184] = "Minecart";
				Main.buffTip[184] = "Riding in a minecart";
				Main.buffName[170] = "Solar Blaze";
				Main.buffTip[170] = "Damage taken reduced by 30%, repel enemies when taking damage";
				Main.buffName[171] = "Solar Blaze";
				Main.buffTip[171] = "Damage taken reduced by 30%, repel enemies when taking damage";
				Main.buffName[172] = "Solar Blaze";
				Main.buffTip[172] = "Damage taken reduced by 30%, repel enemies when taking damage";
				Main.buffName[179] = "Damage Nebula";
				Main.buffTip[179] = "15% increased damage";
				Main.buffName[180] = "Damage Nebula";
				Main.buffTip[180] = "30% increased damage";
				Main.buffName[181] = "Damage Nebula";
				Main.buffTip[181] = "45% increased damage";
				Main.buffName[173] = "Life Nebula";
				Main.buffTip[173] = "Increased life regeneration";
				Main.buffName[174] = "Life Nebula";
				Main.buffTip[174] = "Increased life regeneration";
				Main.buffName[175] = "Life Nebula";
				Main.buffTip[175] = "Increased life regeneration";
				Main.buffName[176] = "Mana Nebula";
				Main.buffTip[176] = "Increased mana regeneration";
				Main.buffName[177] = "Mana Nebula";
				Main.buffTip[177] = "Increased mana regeneration";
				Main.buffName[178] = "Mana Nebula";
				Main.buffTip[178] = "Increased mana regeneration";
				Main.buffName[71] = "Weapon Imbue: Venom";
				Main.buffTip[71] = "Melee attacks inflict venom on your targets";
				Main.buffName[73] = "Weapon Imbue: Cursed Flames";
				Main.buffTip[73] = "Melee attacks inflict enemies with cursed flames";
				Main.buffName[74] = "Weapon Imbue: Fire";
				Main.buffTip[74] = "Melee attacks set enemies on fire";
				Main.buffName[75] = "Weapon Imbue: Gold";
				Main.buffTip[75] = "Melee attacks make enemies drop more gold";
				Main.buffName[76] = "Weapon Imbue: Ichor";
				Main.buffTip[76] = "Melee attacks decrease enemies defense";
				Main.buffName[77] = "Weapon Imbue: Nanites";
				Main.buffTip[77] = "Melee attacks confuse enemies";
				Main.buffName[78] = "Weapon Imbue: Confetti";
				Main.buffTip[78] = "Melee attacks cause confetti to appear";
				Main.buffName[79] = "Weapon Imbue: Poison";
				Main.buffTip[79] = "Melee attacks poison enemies";
				Lang.chestType[0] = "Chest";
				Lang.chestType[1] = "Gold Chest";
				Lang.chestType[2] = "Locked Gold Chest";
				Lang.chestType[3] = "Shadow Chest";
				Lang.chestType[4] = "Locked Shadow Chest";
				Lang.chestType[5] = "Barrel";
				Lang.chestType[6] = "Trash Can";
				Lang.chestType[7] = "Ebonwood Chest";
				Lang.chestType[8] = "Rich Mahogany Chest";
				Lang.chestType[9] = "Pearlwood Chest";
				Lang.chestType[10] = "Ivy Chest";
				Lang.chestType[11] = "Ice Chest";
				Lang.chestType[12] = "Living Wood Chest";
				Lang.chestType[13] = "Skyware Chest";
				Lang.chestType[14] = "Shadewood Chest";
				Lang.chestType[15] = "Web Covered Chest";
				Lang.chestType[16] = "Lihzahrd Chest";
				Lang.chestType[17] = "Water Chest";
				Lang.chestType[18] = "Jungle Chest";
				Lang.chestType[19] = "Corruption Chest";
				Lang.chestType[20] = "Crimson Chest";
				Lang.chestType[21] = "Hallowed Chest";
				Lang.chestType[22] = "Frozen Chest";
				Lang.chestType[23] = "Locked Jungle Chest";
				Lang.chestType[24] = "Locked Corruption Chest";
				Lang.chestType[25] = "Locked Crimson Chest";
				Lang.chestType[26] = "Locked Hallowed Chest";
				Lang.chestType[27] = "Locked Frozen Chest";
				Lang.chestType[28] = "Dynasty Chest";
				Lang.chestType[29] = "Honey Chest";
				Lang.chestType[30] = "Steampunk Chest";
				Lang.chestType[31] = "Palm Wood Chest";
				Lang.chestType[32] = "Mushroom Chest";
				Lang.chestType[33] = "Boreal Wood Chest";
				Lang.chestType[34] = "Slime Chest";
				Lang.chestType[35] = "Green Dungeon Chest";
				Lang.chestType[36] = "Locked Green Dungeon Chest";
				Lang.chestType[37] = "Pink Dungeon Chest";
				Lang.chestType[38] = "Locked Pink Dungeon Chest";
				Lang.chestType[39] = "Blue Dungeon Chest";
				Lang.chestType[40] = "Locked Blue Dungeon Chest";
				Lang.chestType[41] = "Bone Chest";
				Lang.chestType[42] = "Cactus Chest";
				Lang.chestType[43] = "Flesh Chest";
				Lang.chestType[44] = "Obsidian Chest";
				Lang.chestType[45] = "Pumpkin Chest";
				Lang.chestType[46] = "Spooky Chest";
				Lang.chestType[47] = "Glass Chest";
				Lang.chestType[48] = "Martian Chest";
				Lang.chestType[49] = "Meteorite Chest";
				Lang.chestType[50] = "Granite Chest";
				Lang.chestType[51] = "Marble Chest";
				Lang.dresserType[0] = "Dresser";
				Lang.dresserType[1] = "Ebonwood Dresser";
				Lang.dresserType[2] = "Rich Mahogany Dresser";
				Lang.dresserType[3] = "Pearlwood Dresser";
				Lang.dresserType[4] = "Shadewood Dresser";
				Lang.dresserType[5] = "Blue Dungeon Dresser";
				Lang.dresserType[6] = "Green Dungeon Dresser";
				Lang.dresserType[7] = "Pink Dungeon Dresser";
				Lang.dresserType[8] = "Golden Dresser";
				Lang.dresserType[9] = "Obsidian Dresser";
				Lang.dresserType[10] = "Bone Dresser";
				Lang.dresserType[11] = "Cactus Dresser";
				Lang.dresserType[12] = "Spooky Dresser";
				Lang.dresserType[13] = "Skyware Dresser";
				Lang.dresserType[14] = "Honey Dresser";
				Lang.dresserType[15] = "Lihzahrd Dresser";
				Lang.dresserType[16] = "Palm Wood Dresser";
				Lang.dresserType[17] = "Mushroom Dresser";
				Lang.dresserType[18] = "Boreal Wood Dresser";
				Lang.dresserType[19] = "Slime Dresser";
				Lang.dresserType[20] = "Pumpkin Dresser";
				Lang.dresserType[21] = "Steampunk Dresser";
				Lang.dresserType[22] = "Glass Dresser";
				Lang.dresserType[23] = "Flesh Dresser";
				Lang.dresserType[24] = "Martian Dresser";
				Lang.dresserType[25] = "Meteorite Dresser";
				Lang.dresserType[26] = "Granite Dresser";
				Lang.dresserType[27] = "Marble Dresser";
				Lang.prefix[1] = "Large";
				Lang.prefix[2] = "Massive";
				Lang.prefix[3] = "Dangerous";
				Lang.prefix[4] = "Savage";
				Lang.prefix[5] = "Sharp";
				Lang.prefix[6] = "Pointy";
				Lang.prefix[7] = "Tiny";
				Lang.prefix[8] = "Terrible";
				Lang.prefix[9] = "Small";
				Lang.prefix[10] = "Dull";
				Lang.prefix[11] = "Unhappy";
				Lang.prefix[12] = "Bulky";
				Lang.prefix[13] = "Shameful";
				Lang.prefix[14] = "Heavy";
				Lang.prefix[15] = "Light";
				Lang.prefix[16] = "Sighted";
				Lang.prefix[17] = "Rapid";
				Lang.prefix[18] = "Hasty";
				Lang.prefix[19] = "Intimidating";
				Lang.prefix[20] = "Deadly";
				Lang.prefix[21] = "Staunch";
				Lang.prefix[22] = "Awful";
				Lang.prefix[23] = "Lethargic";
				Lang.prefix[24] = "Awkward";
				Lang.prefix[25] = "Powerful";
				Lang.prefix[58] = "Frenzying";
				Lang.prefix[26] = "Mystic";
				Lang.prefix[27] = "Adept";
				Lang.prefix[28] = "Masterful";
				Lang.prefix[29] = "Inept";
				Lang.prefix[30] = "Ignorant";
				Lang.prefix[31] = "Deranged";
				Lang.prefix[32] = "Intense";
				Lang.prefix[33] = "Taboo";
				Lang.prefix[34] = "Celestial";
				Lang.prefix[35] = "Furious";
				Lang.prefix[52] = "Manic";
				Lang.prefix[36] = "Keen";
				Lang.prefix[37] = "Superior";
				Lang.prefix[38] = "Forceful";
				Lang.prefix[53] = "Hurtful";
				Lang.prefix[54] = "Strong";
				Lang.prefix[55] = "Unpleasant";
				Lang.prefix[39] = "Broken";
				Lang.prefix[40] = "Damaged";
				Lang.prefix[56] = "Weak";
				Lang.prefix[41] = "Shoddy";
				Lang.prefix[57] = "Ruthless";
				Lang.prefix[42] = "Quick";
				Lang.prefix[43] = "Deadly";
				Lang.prefix[44] = "Agile";
				Lang.prefix[45] = "Nimble";
				Lang.prefix[46] = "Murderous";
				Lang.prefix[47] = "Slow";
				Lang.prefix[48] = "Sluggish";
				Lang.prefix[49] = "Lazy";
				Lang.prefix[50] = "Annoying";
				Lang.prefix[51] = "Nasty";
				Lang.prefix[59] = "Godly";
				Lang.prefix[60] = "Demonic";
				Lang.prefix[61] = "Zealous";
				Lang.prefix[62] = "Hard";
				Lang.prefix[63] = "Guarding";
				Lang.prefix[64] = "Armored";
				Lang.prefix[65] = "Warding";
				Lang.prefix[66] = "Arcane";
				Lang.prefix[67] = "Precise";
				Lang.prefix[68] = "Lucky";
				Lang.prefix[69] = "Jagged";
				Lang.prefix[70] = "Spiked";
				Lang.prefix[71] = "Angry";
				Lang.prefix[72] = "Menacing";
				Lang.prefix[73] = "Brisk";
				Lang.prefix[74] = "Fleeting";
				Lang.prefix[75] = "Hasty";
				Lang.prefix[76] = "Quick";
				Lang.prefix[77] = "Wild";
				Lang.prefix[78] = "Rash";
				Lang.prefix[79] = "Intrepid";
				Lang.prefix[80] = "Violent";
				Lang.prefix[81] = "Legendary";
				Lang.prefix[82] = "Unreal";
				Lang.prefix[83] = "Mythical";
			}
			else if (Lang.lang == 2)
			{
				Lang.misc[0] = "Die Goblin-Armee wurde besiegt!";
				Lang.misc[1] = "Eine Goblin-Armee naehert sich von Westen!";
				Lang.misc[2] = "Eine Goblin-Armee naehert sich von Osten!";
				Lang.misc[3] = "Ein Goblin-Armee ist da!";
				Lang.misc[4] = "Der Frost Legion wurde besiegt!";
				Lang.misc[5] = "Der Frost ist Legion aus dem Westen näher!";
				Lang.misc[6] = "Der Frost ist Legion aus dem Osten näher!";
				Lang.misc[7] = "Der Frost Legion ist da!";
				Lang.misc[8] = "Der Blutmond steigt auf ...";
				Lang.misc[9] = "Du fuehlst dich von einer boesen Kraft beobachtet ...";
				Lang.misc[10] = "Eine Eiseskaelte steigt in dir hoch ...";
				Lang.misc[11] = "Du hoerst das Echo von Schreien um dich herum ...";
				Lang.misc[12] = "Deine Welt wurde mit Kobalt gesegnet!";
				Lang.misc[13] = "Deine Welt wurde mit Mithril gesegnet!";
				Lang.misc[14] = "Deine Welt wurde mit Adamantit gesegnet!";
				Lang.misc[15] = "Die uralten Geister des Lichts und der Finsternis wurden frei gelassen.";
				Lang.misc[16] = "ist aufgewacht!";
				Lang.misc[17] = "wurde besiegt!";
				Lang.misc[18] = "ist eingetroffen!";
				Lang.misc[19] = " wurde durch...";
				Lang.misc[20] = "Eine Sonnenfinsternis ist passiert!";
				Lang.misc[21] = "Ihre Welt ist mit Palladium gesegnet worden!";
				Lang.misc[22] = "Ihre Welt hat mit Orichalcum gesegnet worden!";
				Lang.misc[23] = "Ihre Welt hat sich mit Titanium gesegnet worden!";
				Lang.misc[24] = "Die Piraten wurden besiegt!";
				Lang.misc[25] = "Piraten sind aus dem Westen näher!";
				Lang.misc[26] = "Piraten sind aus dem Osten näher!";
				Lang.misc[27] = "Die Piraten sind angekommen!";
				Lang.misc[28] = "Sie fühlen sich Schwingungen von tief unter ...";
				Lang.misc[29] = "Das wird eine schreckliche Nacht sein ...";
				Lang.misc[30] = "Die Luft wird kälter um dich herum ...";
				Lang.menu[0] = "Beginne eine neue Sitzung auf Terraria!";
				Lang.menu[1] = "Laeuft auf Port ";
				Lang.menu[2] = "Trennen";
				Lang.menu[3] = "Server benoetigt Passwort:";
				Lang.menu[4] = "Akzeptieren";
				Lang.menu[5] = "Zurueck";
				Lang.menu[6] = "Abbrechen";
				Lang.menu[7] = "Server-Passwort eingeben:";
				Lang.menu[8] = "Server startet...";
				Lang.menu[9] = "Laden fehlgeschlagen!";
				Lang.menu[10] = "Backup laden";
				Lang.menu[11] = "Kein Backup gefunden";
				Lang.menu[12] = "Einzelspieler";
				Lang.menu[13] = "Mehrspieler";
				Lang.menu[14] = "Einstellungen";
				Lang.menu[15] = "Beenden";
				Lang.menu[16] = "Charakter erstellen";
				Lang.menu[17] = "Loeschen";
				Lang.menu[18] = "Haar";
				Lang.menu[19] = "Augen";
				Lang.menu[20] = "Haut";
				Lang.menu[21] = "Kleidung";
				Lang.menu[22] = "Maennlich";
				Lang.menu[23] = "Weiblich";
				Lang.menu[24] = "Hardcore";
				Lang.menu[25] = "Mediumcore";
				Lang.menu[26] = "Softcore";
				Lang.menu[27] = "Zufaellig";
				Lang.menu[28] = "Erstellen";
				Lang.menu[29] = "Hardcore-Charaktere sterben fuers Gute";
				Lang.menu[30] = "Mediumcore-Charaktere lassen im Tod Items fallen";
				Lang.menu[31] = "Softcore-Charaktere lassen im Tod Geld fallen";
				Lang.menu[32] = "Schwierigkeitsgrad waehlen";
				Lang.menu[33] = "Hemd";
				Lang.menu[34] = "Unterhemd";
				Lang.menu[35] = "Hose";
				Lang.menu[36] = "Schuhe";
				Lang.menu[37] = "Haar";
				Lang.menu[38] = "Haarfarbe";
				Lang.menu[39] = "Augenfarbe";
				Lang.menu[40] = "Hautfarbe";
				Lang.menu[41] = "Hemdfarbe";
				Lang.menu[42] = "Unterhemdfarbe";
				Lang.menu[43] = "Hosenfarbe";
				Lang.menu[44] = "Schuhfarbe";
				Lang.menu[45] = "Charaktername eingeben:";
				Lang.menu[46] = "Loeschen";
				Lang.menu[47] = "Welt erschaffen";
				Lang.menu[48] = "Weltnamen eingeben:";
				Lang.menu[49] = "Zum Fenstermodus";
				Lang.menu[50] = "Zum Vollbildschirm";
				Lang.menu[51] = "Aufloesung";
				Lang.menu[52] = "Parallaxe";
				Lang.menu[53] = "Frameskip aus (nicht empfohlen)";
				Lang.menu[54] = "Frameskip an (empfohlen)";
				Lang.menu[55] = "Beleuchtung: Farbe";
				Lang.menu[56] = "Beleuchtung: Weiss";
				Lang.menu[57] = "Beleuchtung: Retro";
				Lang.menu[58] = "Beleuchtung: Flippig";
				Lang.menu[59] = "Qualitaet: Auto";
				Lang.menu[60] = "Qualitaet: Hoch";
				Lang.menu[61] = "Qualitaet: Mittel";
				Lang.menu[62] = "Qualitaet: Niedrig";
				Lang.menu[63] = "Video";
				Lang.menu[64] = "Zeigerfarbe";
				Lang.menu[65] = "Lautstaerke";
				Lang.menu[66] = "Steuerung";
				Lang.menu[67] = "Automat. sichern an";
				Lang.menu[68] = "Automat. sichern aus";
				Lang.menu[69] = "Automat. Pause an";
				Lang.menu[70] = "Automat. Pause aus";
				Lang.menu[71] = "Pickup-Text an";
				Lang.menu[72] = "Pickup-Text aus";
				Lang.menu[73] = "Vollbildschirm-Aufloesung";
				Lang.menu[74] = "Hoch                 ";
				Lang.menu[75] = "Hinunter             ";
				Lang.menu[76] = "Links                 ";
				Lang.menu[77] = "Rechts                ";
				Lang.menu[78] = "Springen             ";
				Lang.menu[79] = "Werfen               ";
				Lang.menu[80] = "Inventar              ";
				Lang.menu[81] = "Schnellheilung       ";
				Lang.menu[82] = "Schnelles Mana     ";
				Lang.menu[83] = "Schneller Buff       ";
				Lang.menu[84] = "Entern                ";
				Lang.menu[85] = "Automat. Auswahl    ";
				Lang.menu[86] = "Auf Standard zuruecksetzen";
				Lang.menu[87] = "Mitmachen";
				Lang.menu[88] = "Hosten & Spielen";
				Lang.menu[89] = "Server-IP-Adresse eingeben:";
				Lang.menu[90] = "Server-Port eingeben:";
				Lang.menu[91] = "Weltgroesse waehlen:";
				Lang.menu[92] = "Klein";
				Lang.menu[93] = "Mittel";
				Lang.menu[94] = "Gross";
				Lang.menu[95] = "Rot:";
				Lang.menu[96] = "Gruen:";
				Lang.menu[97] = "Blau:";
				Lang.menu[98] = "Sound:";
				Lang.menu[99] = "Musik:";
				Lang.menu[100] = "Hintergrund On";
				Lang.menu[101] = "Hintergrund Off";
				Lang.menu[102] = "Wählen Sie die Sprache";
				Lang.menu[103] = "Sprache";
				Lang.menu[104] = "Ja";
				Lang.menu[105] = "Nicht";
				Lang.menu[106] = "Toggle Map-Stil";
				Lang.menu[107] = "umschalten Vollbild";
				Lang.menu[108] = "vergrößern";
				Lang.menu[109] = "Verkleinern";
				Lang.menu[110] = "Verringern Transparenz";
				Lang.menu[111] = "Erhöhung der Transparenz";
				Lang.menu[112] = "Karte Aktiviert";
				Lang.menu[113] = "Karte für Behinderte";
				Lang.gen[0] = "Generieren des Weltgelaendes:";
				Lang.gen[1] = "Sand wird hinzugefuegt  ...";
				Lang.gen[2] = "Huegel werden generiert ...";
				Lang.gen[3] = "Dreck wird hinter Dreck geschoben:";
				Lang.gen[4] = "Felsen werden in den Dreck gesetzt ...";
				Lang.gen[5] = "Dreck wird in Felsen platziert ...";
				Lang.gen[6] = "Lehm wird hinzugefuegt ...";
				Lang.gen[7] = "Loecher werden zufaellig geschaffen:";
				Lang.gen[8] = "Generieren kleiner Hoehlen:";
				Lang.gen[9] = "Generieren grosser Hoehlen:";
				Lang.gen[10] = "Hoehlenoberflaechen werden generiert...";
				Lang.gen[11] = "Generieren des Dschungels:";
				Lang.gen[12] = "Schwimmende Inseln werden generiert ...";
				Lang.gen[13] = "Pilzflecken werden generiert ...";
				Lang.gen[14] = "Schlamm wird in Dreck gefuegt ...";
				Lang.gen[15] = "Schlick wird hinzugefuegt ...";
				Lang.gen[16] = "Glitzer wird hinzugefuegt ...";
				Lang.gen[17] = "Spinnweben werden hinzugefuegt ...";
				Lang.gen[18] = "Erstellen der Unterwelt:";
				Lang.gen[19] = "Gewaesser wird hinzugefuegt:";
				Lang.gen[20] = "Macht die Welt boese:";
				Lang.gen[21] = "Berghoehlen werden generiert ...";
				Lang.gen[22] = "Straende werden erstellt ...";
				Lang.gen[23] = "Edelsteine werden hinzugefuegt ...";
				Lang.gen[24] = "Gravitieren von Sand:";
				Lang.gen[25] = "Reinigung von Dreckhintergrund:";
				Lang.gen[26] = "Platzieren von Altaren:";
				Lang.gen[27] = "Gewaesser verteilen:";
				Lang.gen[28] = "Lebenskristalle platzieren:";
				Lang.gen[29] = "Platzieren von Statuen:";
				Lang.gen[30] = "Verstecken von Schaetzen:";
				Lang.gen[31] = "Verstecken von mehr Schaetzen:";
				Lang.gen[32] = "Verstecken von Dschungelschaetzen:";
				Lang.gen[33] = "Verstecken von Wasserschaetzen:";
				Lang.gen[34] = "Platzieren von Fallen:";
				Lang.gen[35] = "Platzieren von Zerbrechlichem:";
				Lang.gen[36] = "Platzieren von Hoellenschmieden:";
				Lang.gen[37] = "Gras wird verteilt ...";
				Lang.gen[38] = "Kakteen wachsen ...";
				Lang.gen[39] = "Sonnenblumen werden gepflanzt ...";
				Lang.gen[40] = "Baeume werden gepflanzt ...";
				Lang.gen[41] = "Kraeuter werden gepflanzt ...";
				Lang.gen[42] = "Unkraut wird gepflanzt ...";
				Lang.gen[43] = "Wein wird angebaut ...";
				Lang.gen[44] = "Blumen werden gepflanzt ...";
				Lang.gen[45] = "Pilze werden gesaet ...";
				Lang.gen[46] = "Ungenutzte Ressourcen werden freigesetzt:";
				Lang.gen[47] = "Spielobjekte werden zurueckgesetzt:";
				Lang.gen[48] = "Schwerer Modus wird eingestellt ...";
				Lang.gen[49] = "Weltdaten werden gesichert:";
				Lang.gen[50] = "Backup von Weltdatei wird erstellt ...";
				Lang.gen[51] = "Weltdaten werden geladen:";
				Lang.gen[52] = "Ueberpruefen der Feld-Ausrichtung:";
				Lang.gen[53] = "Laden fehlgeschlagen!";
				Lang.gen[54] = "Kein Backup gefunden.";
				Lang.gen[55] = "Suchen von Feld-Frames:";
				Lang.gen[56] = "Hinzufügen Schnee ...";
				Lang.gen[57] = "Welt";
				Lang.gen[58] = "Erstellen Verlies:";
				Lang.gen[59] = "Ein Meteorit ist gelandet!";
				Lang.gen[60] = "Glättung der Welt:";
				Lang.gen[61] = "Mossification:";
				Lang.gen[62] = "Gemification:";
				Lang.gen[63] = "Machen Höhlewänden:";
				Lang.gen[64] = "Wachsende Spinne Höhlen:";
				Lang.gen[65] = "Clearing Kartendaten:";
				Lang.gen[66] = "Speichern von Kartendaten:";
				Lang.gen[67] = "Die Karte wird geladen Daten:";
				Lang.gen[68] = "Zeichnen Karte:";
				Lang.gen[69] = "Erstellen Wasserfälle:";
				Lang.gen[70] = "Erstellen Dschungelruinen...";
				Lang.gen[71] = "Erstellen Hornisse Nester...";
				Lang.gen[72] = "Machen Sie die Welt blutige:";
				Lang.inter[0] = "Leben:";
				Lang.inter[1] = "Atem";
				Lang.inter[2] = "Mana";
				Lang.inter[3] = "Muelleimer";
				Lang.inter[4] = "Inventar";
				Lang.inter[5] = "Hotbar entriegelt";
				Lang.inter[6] = "Hotbar gesperrt";
				Lang.inter[7] = "Behausung";
				Lang.inter[8] = "Behausungsanfrage";
				Lang.inter[9] = "Zusaetze";
				Lang.inter[10] = "Abwehr";
				Lang.inter[11] = "Sozial";
				Lang.inter[12] = "Helm";
				Lang.inter[13] = "Hemd";
				Lang.inter[14] = "Hose";
				Lang.inter[15] = "platin";
				Lang.inter[16] = "gold";
				Lang.inter[17] = "silber";
				Lang.inter[18] = "kupfer";
				Lang.inter[19] = "Nachschmieden";
				Lang.inter[20] = "Zum Nachschmieden Item hier platzieren";
				Lang.inter[21] = "Anzeige von Rezepten mit Verwendung von";
				Lang.inter[22] = "Erforderliche Objekte:";
				Lang.inter[23] = "Keins";
				Lang.inter[24] = "Bitte Material hier platzieren, um Rezepte zu zeigen";
				Lang.inter[25] = "Herstellen";
				Lang.inter[26] = "Muenzen";
				Lang.inter[27] = "Munition";
				Lang.inter[28] = "Geschaeft";
				Lang.inter[29] = "Alle ausraeumen";
				Lang.inter[30] = "Alle ablegen";
				Lang.inter[31] = "Schnellstapeln";
				Lang.inter[32] = "Sparschwein";
				Lang.inter[33] = "Tresor";
				Lang.inter[34] = "Zeit:";
				Lang.inter[35] = "Speichern & Beenden";
				Lang.inter[36] = "Trennen";
				Lang.inter[37] = "Artikel";
				Lang.inter[38] = "Du wurdest getoetet ...";
				Lang.inter[39] = "Diese Behausung ist geeignet.";
				Lang.inter[40] = "Das ist keine zulaessiges Behausung";
				Lang.inter[41] = "Diese Behausung ist bereits belegt.";
				Lang.inter[42] = "Diese Behausung ist beschaedigt.";
				Lang.inter[43] = "Zeitueberschreitung bei Verbindung";
				Lang.inter[44] = "Felddaten werden empfangen";
				Lang.inter[45] = "Ausrüsten";
				Lang.inter[46] = "Kosten";
				Lang.inter[47] = "Sparen";
				Lang.inter[48] = "Bearbeiten";
				Lang.inter[49] = "Status";
				Lang.inter[50] = "Fluch";
				Lang.inter[51] = "Hilfe";
				Lang.inter[52] = "Schliessen";
				Lang.inter[53] = "Wasser";
				Lang.inter[54] = "Heilen";
				Lang.inter[55] = "Dieses Gehäuse erfüllt nicht die Anforderungen für eine";
				Lang.inter[56] = "Lava";
				Lang.inter[57] = "Färben";
				Lang.inter[58] = "Liebling";
				Lang.inter[61] = "Umbenennen";
				Lang.inter[62] = "Einstellungen";
				Lang.inter[63] = "Abbrechen";
				Lang.tip[0] = "Ausgestattet in sozialen Schlitz";
				Lang.tip[1] = "Keine Werte werden gewonnen";
				Lang.tip[2] = " Nahkampfschaden";
				Lang.tip[3] = " Fernkampfschaden";
				Lang.tip[4] = " Magischer Schaden";
				Lang.tip[5] = "% kritische Trefferchance";
				Lang.tip[6] = "Wahnsinnig schnell";
				Lang.tip[7] = "Sehr schnell";
				Lang.tip[8] = "Schnell";
				Lang.tip[9] = "Durchschnittlich ";
				Lang.tip[10] = "Langsam";
				Lang.tip[11] = "Sehr langsam";
				Lang.tip[12] = "Extrem langsam";
				Lang.tip[13] = "Schneckentempo";
				Lang.tip[14] = "Kein Rueckstoss";
				Lang.tip[15] = "Extrem schwacher Rueckstoss";
				Lang.tip[16] = "Sehr schwacher Rueckstoss";
				Lang.tip[17] = "Schwacher Rueckstoss";
				Lang.tip[18] = "Mittlerer Rueckstoss";
				Lang.tip[19] = "Starker Rueckstoss";
				Lang.tip[20] = "Sehr starker Rueckstoss";
				Lang.tip[21] = "Extrem starker Rueckstoss";
				Lang.tip[22] = "Wahnsinniger Rueckstoss";
				Lang.tip[23] = "Ausruestbar";
				Lang.tip[24] = "Mode-Items";
				Lang.tip[25] = " Abwehr";
				Lang.tip[26] = "% Spitzhackenkraft";
				Lang.tip[27] = "% Axtmachtkraft";
				Lang.tip[28] = "% Hammerkraft";
				Lang.tip[29] = "Stellt";
				Lang.tip[30] = "Leben wieder her";
				Lang.tip[31] = "Mana wieder her";
				Lang.tip[32] = "Verwendet";
				Lang.tip[33] = "Kann platziert werden";
				Lang.tip[34] = "Munition";
				Lang.tip[35] = "Verbrauchbar";
				Lang.tip[36] = "Material";
				Lang.tip[37] = " Minuten Dauer";
				Lang.tip[38] = " Sekunden Dauer";
				Lang.tip[39] = "% Schaden";
				Lang.tip[40] = "% Tempo";
				Lang.tip[41] = "% kritische Trefferchance";
				Lang.tip[42] = "% Manakosten";
				Lang.tip[43] = "% Groesse";
				Lang.tip[44] = "% Projektiltempo";
				Lang.tip[45] = "% Rueckstoss";
				Lang.tip[46] = "% Bewegungstempo";
				Lang.tip[47] = "% Nahkampftempo";
				Lang.tip[48] = "Bonus-Set:";
				Lang.tip[49] = "Verkaufspreis:";
				Lang.tip[50] = "Kaufpreis:";
				Lang.tip[51] = "Kein Wert";
				Lang.tip[52] = "verbraucht ";
				Lang.tip[53] = " beschwören Schaden";
				Lang.tip[54] = " Bereich";
				Lang.tip[55] = " Schäden";
				Lang.mp[1] = "Falsches Passwort.";
				Lang.mp[2] = "Ungueltige Operation in diesem Zustand.";
				Lang.mp[3] = "Auf diesem Server bist du gesperrt.";
				Lang.mp[4] = "Du verwendest nicht die gleiche Version wie der Server.";
				Lang.mp[5] = "ist bereits auf diesem Server.";
				Lang.mp[5] = "is already on this server.";
				Lang.mp[6] = "/spielen";
				Lang.mp[7] = "Aktuelle Spieler:";
				Lang.mp[8] = "/wuerfeln";
				Lang.mp[9] = "wuerfelt eine";
				Lang.mp[10] = "Du bist in keiner Gruppe!";
				Lang.mp[11] = "hat PvP aktiviert!";
				Lang.mp[12] = "hat PvP deaktiviert!";
				Lang.mp[13] = "ist in keiner Gruppe mehr.";
				Lang.mp[14] = "ist der roten Gruppe beigetreten.";
				Lang.mp[15] = "ist der gruenen Gruppe beigetreten.";
				Lang.mp[16] = "ist der blauen Gruppe beigetreten.";
				Lang.mp[17] = "ist der gelben Gruppe beigetreten.";
				Lang.mp[18] = "Willkommen in";
				Lang.mp[19] = "beigetreten.";
				Lang.mp[20] = "beenden.";
				Lang.the = "der ";
				Lang.dt[0] = "konnte das Antidot nicht finden";
				Lang.dt[1] = "konnte das Feuer nicht loeschen";
				Main.buffName[1] = "Obsidianhaut";
				Main.buffTip[1] = "Immun gegen Lava";
				Main.buffName[2] = "Wiederbelebung";
				Main.buffTip[2] = "Belebt wieder";
				Main.buffName[3] = "Wendigkeit";
				Main.buffTip[3] = "Erhoeht Bewegungstempo um 25%";
				Main.buffName[4] = "Kiemen";
				Main.buffTip[4] = "Wasser statt Luft atmen";
				Main.buffName[5] = "Eisenhaut";
				Main.buffTip[5] = "Erhoeht die Abwehr um 8";
				Main.buffName[6] = "Mana-Wiederherstellung";
				Main.buffTip[6] = "Erhoehte Mana-Wiederherstellung";
				Main.buffName[7] = "Magiekraft";
				Main.buffTip[7] = "Erhoeht magischen Schaden um 20%";
				Main.buffName[8] = "Federsturz";
				Main.buffTip[8] = "Zur Kontrolle der Sinkgeschwindigkeit UP oder DOWN druecken ";
				Main.buffName[9] = "Hoehlenforscher";
				Main.buffTip[9] = "Zeigt den Fundort von Schatz und Erz";
				Main.buffName[10] = "Unsichtbarkeit";
				Main.buffTip[10] = "Macht unsichtbar";
				Main.buffName[11] = "Glanz";
				Main.buffTip[11] = "Strahlt Licht aus";
				Main.buffName[12] = "Nachteule";
				Main.buffTip[12] = "Erhoehte Nachtsicht";
				Main.buffName[13] = "Kampf";
				Main.buffTip[13] = "Erhoehte Feind-Spawnrate";
				Main.buffName[14] = "Dornen";
				Main.buffTip[14] = "Auch die Angreifer erleiden Schaden";
				Main.buffName[15] = "Wasserlaufen";
				Main.buffTip[15] = "DOWN druecken, um aufs Wasser zu gehen";
				Main.buffName[16] = "Bogenschiessen";
				Main.buffTip[16] = "Um 20% erhoehter Pfeilschaden und -tempo";
				Main.buffName[17] = "Jaeger";
				Main.buffTip[17] = "Zeigt die Position von Feinden";
				Main.buffName[18] = "Gravitation";
				Main.buffTip[18] = "Zum Umkehren der Schwerkraft UP oder DOWN druecken";
				Main.buffName[19] = "Lichtkugel";
				Main.buffTip[19] = "Eine magische Kugel, die Licht verstroemt";
				Main.buffName[20] = "Vergiftet";
				Main.buffTip[20] = "Langsam entweicht das Leben";
				Main.buffName[21] = "Krankheitstrank";
				Main.buffTip[21] = "Kann keine Heil-Items mehr verbrauchen";
				Main.buffName[22] = "Dunkelheit";
				Main.buffTip[22] = "Schlechtere Sicht durch weniger Licht";
				Main.buffName[23] = "Verflucht";
				Main.buffTip[23] = "Kann keine Items verwenden";
				Main.buffName[24] = "Flammenmeer!";
				Main.buffTip[24] = "Langsam entweicht das Leben";
				Main.buffName[25] = "Beschwipst";
				Main.buffTip[25] = "Erhoehte Nahkampffaehigkeiten, verminderte Abwehr";
				Main.buffName[26] = "Kleine Staerkung";
				Main.buffTip[26] = "Geringe Anhebung aller Werte";
				Main.buffName[27] = "Fee";
				Main.buffTip[27] = "Eine Fee folgt dir";
				Main.buffName[28] = "Werwolf";
				Main.buffTip[28] = "Koerperliche Faehigkeiten sind gestiegen";
				Main.buffName[29] = "Hellsehen";
				Main.buffTip[29] = "Magiekraefte werden erhoeht";
				Main.buffName[30] = "Blutung";
				Main.buffTip[30] = "Kann nicht wiederbeleben";
				Main.buffName[31] = "Verwirrt";
				Main.buffTip[31] = "Bewegung wird umgekehrt";
				Main.buffName[32] = "Langsam";
				Main.buffTip[32] = "Bewegungen werden verlangsamt";
				Main.buffName[33] = "Schwach";
				Main.buffTip[33] = "Koerperliche Faehigkeiten sind gesunken";
				Main.buffName[34] = "Meermenschen";
				Main.buffTip[34] = "Kann atmen und  sich leicht unter Wasser bewegen";
				Main.buffName[35] = "Schweigen";
				Main.buffTip[35] = "Nicht verwenden können Gegenstände, die Mana benötigen";
				Main.buffName[36] = "Kaputte Ruestung";
				Main.buffTip[36] = "Die Abwehr ist halbiert worden";
				Main.buffName[37] = "Entsetzt";
				Main.buffTip[37] = "Du hast etwas Ekliges gesehen, es gibt kein Entrinnen.";
				Main.buffName[38] = "Die Zunge";
				Main.buffTip[38] = "Du wirst ins Maul eingesaugt";
				Main.buffName[39] = "Verfluchtes Inferno";
				Main.buffTip[39] = "Das Leben entweicht";
				Main.buffName[40] = "Haustierhäschen";
				Main.buffTip[40] = "Ich denke, sie will deine Karotte";
				Main.buffName[41] = "Baby-Pinguin";
				Main.buffTip[41] = "Ich denke, sie will Ihre Fische";
				Main.buffName[42] = "Haustier Schildkröte";
				Main.buffTip[42] = "Glückliche Schildkröte Zeit!";
				Main.buffName[43] = "Paladin Schild";
				Main.buffTip[43] = "25% der Schäden getroffen werden, um einen anderen Spieler umgeleitet werden";
				Main.buffName[44] = "Frost brennen";
				Main.buffTip[44] = "Es ist entweder sehr heiß oder sehr kalt. So oder so ist es wirklich weh tut";
				Main.buffName[45] = "Baby Esser";
				Main.buffTip[45] = "Ein Baby-Eater of Souls wird Ihnen folgen";
				Main.buffName[46] = "Gekühlt";
				Main.buffTip[46] = "Ihre Bewegungsgeschwindigkeit verringert wurde";
				Main.buffName[47] = "eingefroren";
				Main.buffTip[47] = "Sie können sich nicht bewegen!";
				Main.buffName[48] = "Liebling";
				Main.buffTip[48] = "Leben Regeneration erhöht";
				Main.buffName[49] = "Pygmäen";
				Main.buffTip[49] = "Die Pygmäen wird für euch streiten";
				Main.buffName[50] = "Baby-Skeletron Kopf";
				Main.buffTip[50] = "Noch nicht einmal fragen ...";
				Main.buffName[51] = "Baby-Hornet";
				Main.buffTip[51] = "Es denkt, du bist seine Mutter";
				Main.buffName[52] = "Tiki Geist";
				Main.buffTip[52] = "Ein freundlicher Geist verfolgt dich";
				Main.buffName[53] = "Haustier Eidechse";
				Main.buffTip[53] = "Chillin 'wie ein Reptil";
				Main.buffName[54] = "Papagei";
				Main.buffTip[54] = "Polly Mangel ist der Cracker";
				Main.buffName[55] = "Baby Trüffel";
				Main.buffTip[55] = "Ist das nicht gerade soooo süß?";
				Main.buffName[56] = "Bäumchen";
				Main.buffTip[56] = "Ein kleines Bäumchen Ihnen folgt";
				Main.buffName[57] = "Irrlicht";
				Main.buffTip[57] = "Ein Hauch Ihnen folgt";
				Main.buffName[58] = "Schnelle Heilung";
				Main.buffTip[58] = "Leben Regeneration stark erhöht";
				Main.buffName[59] = "Schatten Ausweichen";
				Main.buffTip[59] = "Sie werden den nächsten Angriff ausweichen";
				Main.buffName[60] = "Blatt Kristall";
				Main.buffTip[60] = "Shoots Kristall fährt um Feinde in der Nähe";
				Main.buffName[61] = "Baby-Dinosaurier";
				Main.buffTip[61] = "Ein Baby-Dinosaurier Ihnen folgt";
				Main.buffName[62] = "Eisbarriere";
				Main.buffTip[62] = "Verteidigung ist um 30 erhöht";
				Main.buffName[63] = "Panik!";
				Main.buffTip[63] = "Die Bewegungsgeschwindigkeit wird erhöht";
				Main.buffName[64] = "Baby Schleim";
				Main.buffTip[64] = "Das Baby Schleim wird für euch streiten";
				Main.buffName[65] = "Augapfel Frühling";
				Main.buffTip[65] = "Ein Augapfel Frühjahr Ihnen folgt";
				Main.buffName[66] = "Baby-Schneemann";
				Main.buffTip[66] = "Ein Baby-Schneemann Ihnen folgt";
				Main.buffName[67] = "Brennen";
				Main.buffTip[67] = "Losing Leben und verlangsamte Bewegung";
				Main.buffName[68] = "Erstickung";
				Main.buffTip[68] = "Losing Leben";
				Main.buffName[69] = "Ichor";
				Main.buffTip[69] = "Statt Verteidigung";
				Main.buffName[70] = "Gift 2";
				Main.buffTip[70] = "Losing Leben";
				Main.buffName[72] = "Midas";
				Main.buffTip[72] = "Lassen Sie mehr Geld auf den Tod";
				Main.buffName[80] = "Blackout";
				Main.buffTip[80] = "Licht Vision stark reduziert";
				Main.buffName[71] = "Waffe verleihen: Gift 2";
				Main.buffTip[71] = "Nahkampfangriffe verursachen Gift auf Ihre Ziele";
				Main.buffName[73] = "Waffe verleihen: verflucht Flammen";
				Main.buffTip[73] = "Nahkampfangriffe verursachen Feinde verflucht mit Flammen";
				Main.buffName[74] = "Waffe verleihen: Feuer";
				Main.buffTip[74] = "Nahkampfangriffe gesetzt Feinde";
				Main.buffName[75] = "Waffe verleihen: Gold";
				Main.buffTip[75] = "Nahkampfangriffe Feinde machen fallen mehr Gold";
				Main.buffName[76] = "Waffe verleihen: Ichor";
				Main.buffTip[76] = "Nahkampfangriffe verringern Feinde Verteidigung";
				Main.buffName[77] = "Waffe verleihen: Nanites";
				Main.buffTip[77] = "Nahkampfangriffe verwirren Feinde";
				Main.buffName[78] = "Waffe verleihen: Konfetti";
				Main.buffTip[78] = "Nahkampfangriffe verursachen Konfetti zu erscheinen";
				Main.buffName[79] = "Waffe verleihen: Gift";
				Main.buffTip[79] = "Nahkampfangriffe Gift Feinde";
				Lang.prefix[1] = "Gross";
				Lang.prefix[2] = "Massiv";
				Lang.prefix[3] = "Gefährlich";
				Lang.prefix[4] = "Barbarisch";
				Lang.prefix[5] = "Scharf";
				Lang.prefix[6] = "Spitze";
				Lang.prefix[7] = "Winzig";
				Lang.prefix[8] = "Schrecklicher";
				Lang.prefix[9] = "Klein";
				Lang.prefix[10] = "Stumpf";
				Lang.prefix[11] = "Unglücklich";
				Lang.prefix[12] = "Sperrig";
				Lang.prefix[13] = "Beschämend";
				Lang.prefix[14] = "Schwer";
				Lang.prefix[15] = "Locker";
				Lang.prefix[16] = "Gesichtet";
				Lang.prefix[17] = "Schnell";
				Lang.prefix[18] = "Hastig";
				Lang.prefix[19] = "Einschüchternd";
				Lang.prefix[20] = "Tödlich";
				Lang.prefix[21] = "Stillen";
				Lang.prefix[22] = "Schrecklich";
				Lang.prefix[23] = "Lethargisch";
				Lang.prefix[24] = "Unbeholfen";
				Lang.prefix[25] = "Mächtig";
				Lang.prefix[26] = "Mystisch";
				Lang.prefix[27] = "Geschickt";
				Lang.prefix[28] = "Meisterhaft";
				Lang.prefix[29] = "Ungeschickt";
				Lang.prefix[30] = "Unwissend";
				Lang.prefix[31] = "Gestört";
				Lang.prefix[32] = "Intensiv";
				Lang.prefix[33] = "Tabu";
				Lang.prefix[34] = "Himmlisch";
				Lang.prefix[35] = "Wütend";
				Lang.prefix[36] = "Scharf";
				Lang.prefix[37] = "Überlegen";
				Lang.prefix[38] = "Kraftvoll";
				Lang.prefix[39] = "Gebrochen";
				Lang.prefix[40] = "Beschädigt";
				Lang.prefix[41] = "Schäbig";
				Lang.prefix[42] = "Rasch";
				Lang.prefix[43] = "Tödlich";
				Lang.prefix[44] = "Agil";
				Lang.prefix[45] = "Wendig";
				Lang.prefix[46] = "Mörderisch";
				Lang.prefix[47] = "Langsam";
				Lang.prefix[48] = "Träge";
				Lang.prefix[49] = "Faul";
				Lang.prefix[50] = "Lästig";
				Lang.prefix[51] = "Böse";
				Lang.prefix[52] = "Manisch";
				Lang.prefix[53] = "Verletzend";
				Lang.prefix[54] = "Stark";
				Lang.prefix[55] = "Unangenehm";
				Lang.prefix[56] = "Schwach";
				Lang.prefix[57] = "Rücksichtslos";
				Lang.prefix[58] = "Rasend";
				Lang.prefix[59] = "Fromm";
				Lang.prefix[60] = "Dämonisch";
				Lang.prefix[61] = "Eifrig";
				Lang.prefix[62] = "Schwer";
				Lang.prefix[63] = "Schutz-";
				Lang.prefix[64] = "Gepanzert";
				Lang.prefix[65] = "Defensiv";
				Lang.prefix[66] = "Geheimnisvoll";
				Lang.prefix[67] = "Präzise";
				Lang.prefix[68] = "Glücklich";
				Lang.prefix[69] = "Gezackt";
				Lang.prefix[70] = "Spike";
				Lang.prefix[71] = "Wütend";
				Lang.prefix[72] = "Bedrohlich";
				Lang.prefix[73] = "Rege";
				Lang.prefix[74] = "Flüchtig";
				Lang.prefix[75] = "Hastig";
				Lang.prefix[76] = "Rasch";
				Lang.prefix[77] = "Wild";
				Lang.prefix[78] = "Voreilig";
				Lang.prefix[79] = "Unerschrocken";
				Lang.prefix[80] = "Gewalttätig";
				Lang.prefix[81] = "Legendär";
				Lang.prefix[82] = "Unwirklich";
				Lang.prefix[83] = "Mythisch";
			}
			else if (Lang.lang == 3)
			{
				Lang.misc[0] = "L'esercito di goblin è stato sconfitto! ";
				Lang.misc[1] = "Un esercito di goblin si sta avvicinando da ovest!";
				Lang.misc[2] = "Un esercito di goblin si sta avvicinando da est!";
				Lang.misc[3] = "Un esercito di goblin è arrivato!";
				Lang.misc[4] = "La Legione di Frost è stato sconfitto!";
				Lang.misc[5] = "La Legione gelo si sta avvicinando da ovest!";
				Lang.misc[6] = "La Legione gelo si sta avvicinando da est!";
				Lang.misc[7] = "La Legione gelo è arrivato!";
				Lang.misc[8] = "La luna di sangue sta sorgendo...";
				Lang.misc[9] = "Senti una presenza malvagia che ti sta guardando...";
				Lang.misc[10] = "Un freddo terribile ti attraversa la spina dorsale...";
				Lang.misc[11] = "Intorno a te echeggiano urla... ";
				Lang.misc[12] = "Il tuo mondo è stato benedetto con cobalto! ";
				Lang.misc[13] = "Il tuo mondo è stato benedetto con mitrilio! ";
				Lang.misc[14] = "Il tuo mondo è stato benedetto con adamantio!";
				Lang.misc[15] = "I vecchi spiriti di luce e tenebre sono stati liberati.  ";
				Lang.misc[16] = "si è svegliato!";
				Lang.misc[17] = "è stato sconfitto!";
				Lang.misc[18] = "è arrivato!";
				Lang.misc[19] = " è stato ucciso...";
				Lang.misc[20] = "Un eclissi solare sta accadendo!";
				Lang.misc[21] = "Il vostro mondo è stato benedetto con Palladium!";
				Lang.misc[22] = "Il vostro mondo è stato benedetto con oricalco!";
				Lang.misc[23] = "Your world has been blessed with titanium!";
				Lang.misc[24] = "I pirati sono stati sconfitti!";
				Lang.misc[25] = "I pirati si stanno avvicinando da ovest!";
				Lang.misc[26] = "I pirati si stanno avvicinando da est!";
				Lang.misc[27] = "I pirati sono arrivati!";
				Lang.misc[28] = "Ti senti vibrazioni profondità sotto ...";
				Lang.misc[29] = "Questa sarà una notte terribile ...";
				Lang.misc[30] = "L'aria è sempre più fredda intorno a te ...";
				Lang.menu[0] = "Inizia una nuova istanza di Terraria!";
				Lang.menu[1] = "In esecuzione sulla porta";
				Lang.menu[2] = "Disconnetti";
				Lang.menu[3] = "Il server richiede una password:";
				Lang.menu[4] = "Accetta";
				Lang.menu[5] = "Indietro";
				Lang.menu[6] = "Annulla";
				Lang.menu[7] = "Inserisci la password del server:";
				Lang.menu[8] = "Avvio del server...";
				Lang.menu[9] = "Caricamento non riuscito!";
				Lang.menu[10] = "Carica backup";
				Lang.menu[11] = "Backup non trovato";
				Lang.menu[12] = "Giocatore singolo";
				Lang.menu[13] = "Multigiocatore";
				Lang.menu[14] = "Impostazioni";
				Lang.menu[15] = "Esci";
				Lang.menu[16] = "Crea personaggio";
				Lang.menu[17] = "Elimina";
				Lang.menu[18] = "Capelli";
				Lang.menu[19] = "Occhi";
				Lang.menu[20] = "Pelle";
				Lang.menu[21] = "Abiti";
				Lang.menu[22] = "Maschio";
				Lang.menu[23] = "Femmina";
				Lang.menu[24] = "Harcore";
				Lang.menu[25] = "Mediumcore ";
				Lang.menu[26] = "Softcore ";
				Lang.menu[27] = "Casuale";
				Lang.menu[28] = "Crea";
				Lang.menu[29] = "I personaggi hardcore muoiono definitivamente";
				Lang.menu[30] = "I personaggi mediumcore perdono oggetti morendo";
				Lang.menu[31] = "I personaggi softcore perdono denaro morendo";
				Lang.menu[32] = "Livello di difficoltà";
				Lang.menu[33] = "Camicia";
				Lang.menu[34] = "Maglietta";
				Lang.menu[35] = "Pantaloni";
				Lang.menu[36] = "Scarpe";
				Lang.menu[37] = "Capelli";
				Lang.menu[38] = "Colore capelli";
				Lang.menu[39] = "Colore occhi";
				Lang.menu[40] = "Colore pelle";
				Lang.menu[41] = "Colore camicia";
				Lang.menu[42] = "Colore maglietta";
				Lang.menu[43] = "Colore pantaloni";
				Lang.menu[44] = "Colore scarpe";
				Lang.menu[45] = "Inserisci nome personaggio:";
				Lang.menu[46] = "Elimina";
				Lang.menu[47] = "Crea mondo";
				Lang.menu[48] = "Inserisci nome mondo:";
				Lang.menu[49] = "Finestra";
				Lang.menu[50] = "Schermo intero";
				Lang.menu[51] = "Risoluzione";
				Lang.menu[52] = "Parallasse";
				Lang.menu[53] = "Salta fotogrammi Off (sconsigliato)";
				Lang.menu[54] = "Salta fotogrammi On (consigliato)";
				Lang.menu[55] = "Illuminazione: a colori ";
				Lang.menu[56] = "Illuminazione: bianca";
				Lang.menu[57] = "Illuminazione: retro";
				Lang.menu[58] = "Illuminazione: speciale";
				Lang.menu[59] = "Qualità: automatica";
				Lang.menu[60] = "Qualità: alta";
				Lang.menu[61] = "Qualità: media";
				Lang.menu[62] = "Qualità: bassa";
				Lang.menu[63] = "Video";
				Lang.menu[64] = "Colore cursore";
				Lang.menu[65] = "Volume";
				Lang.menu[66] = "Comandi";
				Lang.menu[67] = "Salvataggio automatico On";
				Lang.menu[68] = "Salvataggio automatico Off";
				Lang.menu[69] = "Pausa automatica On";
				Lang.menu[70] = "Pausa automatica Off";
				Lang.menu[71] = "Testo di collegamento On";
				Lang.menu[72] = "Testo di collegamento Off";
				Lang.menu[73] = "Risoluzione a schermo intero";
				Lang.menu[74] = "Su                      ";
				Lang.menu[75] = "Giù                     ";
				Lang.menu[76] = "Sinistra                 ";
				Lang.menu[77] = "Destra                  ";
				Lang.menu[78] = "Salta                    ";
				Lang.menu[79] = "Lancia                   ";
				Lang.menu[80] = "Inventario               ";
				Lang.menu[81] = "Cura veloce             ";
				Lang.menu[82] = "Mana veloce            ";
				Lang.menu[83] = "Buff veloce             ";
				Lang.menu[84] = "Rampino                 ";
				Lang.menu[85] = "Selezione automatica   ";
				Lang.menu[86] = "Ripristina predefiniti";
				Lang.menu[87] = "Entra";
				Lang.menu[88] = "Ospita e gioca";
				Lang.menu[89] = "Inserisci indirizzo IP del server:";
				Lang.menu[90] = "Inserisci porta server:";
				Lang.menu[91] = "Scegli grandezza del mondo:";
				Lang.menu[92] = "Piccolo";
				Lang.menu[93] = "Medio";
				Lang.menu[94] = "Grande";
				Lang.menu[95] = "Rosso:";
				Lang.menu[96] = "Verde:";
				Lang.menu[97] = "Blu:";
				Lang.menu[98] = "Audio:";
				Lang.menu[99] = "Musica:";
				Lang.menu[100] = "Sfondo su";
				Lang.menu[101] = "Fondo off";
				Lang.menu[102] = "Selezionare la lingua";
				Lang.menu[103] = "Lingua";
				Lang.menu[104] = "Sì";
				Lang.menu[105] = "No";
				Lang.menu[106] = "mappa levetta stile";
				Lang.menu[107] = "Alterna a tutto schermo";
				Lang.menu[108] = "zoom in";
				Lang.menu[109] = "rimpicciolire";
				Lang.menu[110] = "diminuire Trasparenza";
				Lang.menu[111] = "aumentare la trasparenza";
				Lang.menu[112] = "mappa attivato";
				Lang.menu[113] = "mappa Disabilitato";
				Lang.gen[0] = "Crea terreno del mondo:";
				Lang.gen[1] = "Aggiunta sabbia...";
				Lang.gen[2] = "Creazione colline...";
				Lang.gen[3] = "Aggiungi terra dietro la terra:";
				Lang.gen[4] = "Aggiunta rocce nella terra...";
				Lang.gen[5] = "Aggiunta terra nelle rocce...";
				Lang.gen[6] = "Aggiunta argilla...";
				Lang.gen[7] = "Crea fori casuali:";
				Lang.gen[8] = "Crea piccole grotte: ";
				Lang.gen[9] = "Crea grandi grotte:";
				Lang.gen[10] = "Creazione di grotte superficiali...";
				Lang.gen[11] = "Crea giungla:";
				Lang.gen[12] = "Creazione di isole galleggianti...";
				Lang.gen[13] = "Aggiunta campi di funghi...";
				Lang.gen[14] = "Aggiunta fango nella terra...";
				Lang.gen[15] = "Aggiunta fango...";
				Lang.gen[16] = "Aggiunta elementi luminosi...";
				Lang.gen[17] = "Aggiunta ragnatele...";
				Lang.gen[18] = "Crea sottomondo:";
				Lang.gen[19] = "Aggiungi creature acquatiche:";
				Lang.gen[20] = "Rendi il mondo malvagio:";
				Lang.gen[21] = "Creazione grotte montuose...";
				Lang.gen[22] = "Creazione spiagge...";
				Lang.gen[23] = "Aggiunta gemme...";
				Lang.gen[24] = "Ruota sabbia:";
				Lang.gen[25] = "Pulisci sfondi terra:";
				Lang.gen[26] = "Aggiungi altari:";
				Lang.gen[27] = "Versa liquidi:";
				Lang.gen[28] = "Aggiungi cristalli di vita:";
				Lang.gen[29] = "Aggiungi statue:";
				Lang.gen[30] = "Nascondi tesori:";
				Lang.gen[31] = "Nascondi più tesori:";
				Lang.gen[32] = "Nascondi tesori nella giungla:";
				Lang.gen[33] = "Nascondi tesori in acqua:";
				Lang.gen[34] = "Disponi trappole:";
				Lang.gen[35] = "Disponi gli oggetti fragili:";
				Lang.gen[36] = "Disponi creazioni degli inferi:";
				Lang.gen[37] = "Estensione erba...";
				Lang.gen[38] = "Crescita cactus...";
				Lang.gen[39] = "Pianta girasoli...";
				Lang.gen[40] = "Pianta alberi...";
				Lang.gen[41] = "Pianta erbe...";
				Lang.gen[42] = "Pianta erbacce...";
				Lang.gen[43] = "Crescita viti...";
				Lang.gen[44] = "Pianta fiori...";
				Lang.gen[45] = "Pianta funghi...";
				Lang.gen[46] = "Libera risorse inutilizzate:";
				Lang.gen[47] = "Resetta oggetti di gioco:";
				Lang.gen[48] = "Imposta modalità difficile...";
				Lang.gen[49] = "Salva dati del mondo:";
				Lang.gen[50] = "Backup file mondo...";
				Lang.gen[51] = "Carica dati del mondo:";
				Lang.gen[52] = "Controlla l'allineamento delle mattonelle:";
				Lang.gen[53] = "Caricamento non riuscito!";
				Lang.gen[54] = "Backup non trovato";
				Lang.gen[55] = "Trova cornici delle mattonelle:";
				Lang.gen[56] = "L'aggiunta di neve ...";
				Lang.gen[57] = "Mondo";
				Lang.gen[58] = "La creazione di dungeon:";
				Lang.gen[59] = "Un meteorite è atterrato!";
				Lang.gen[60] = "Smoothing il mondo:";
				Lang.gen[61] = "Mossification:";
				Lang.gen[62] = "Gemification:";
				Lang.gen[63] = "Fare pareti delle caverne:";
				Lang.gen[64] = "Crescere grotte ragno:";
				Lang.gen[65] = "Clearing mappa dati:";
				Lang.gen[66] = "Salvataggio dei dati della mappa:";
				Lang.gen[67] = "Caricamento dati della mappa:";
				Lang.gen[68] = "disegnare la mappa:";
				Lang.gen[69] = "creazione di cascate:";
				Lang.gen[70] = "Creazione di rovine della giungla...";
				Lang.gen[71] = "Creazione di nidi di calabrone...";
				Lang.gen[72] = "Rendere il mondo insanguinato:";
				Lang.inter[0] = "Vita:";
				Lang.inter[1] = "Respiro";
				Lang.inter[2] = "Mana ";
				Lang.inter[3] = "Bidone";
				Lang.inter[4] = "Inventario";
				Lang.inter[5] = "Hotbar sbloccato";
				Lang.inter[6] = "Hotbar bloccato";
				Lang.inter[7] = "Alloggio";
				Lang.inter[8] = "Richiesta alloggio";
				Lang.inter[9] = "Accessori";
				Lang.inter[10] = "Difesa";
				Lang.inter[11] = "Sociale";
				Lang.inter[12] = "Casco";
				Lang.inter[13] = "Camicia";
				Lang.inter[14] = "Pantaloni";
				Lang.inter[15] = "platino";
				Lang.inter[16] = "oro";
				Lang.inter[17] = "argento";
				Lang.inter[18] = "rame";
				Lang.inter[19] = "Riforgiare";
				Lang.inter[20] = "Posizionare un oggetto qui per riforgiare";
				Lang.inter[21] = "Mostra ricetta da usare";
				Lang.inter[22] = "Oggetti richiesti:";
				Lang.inter[23] = "Nessuno";
				Lang.inter[24] = "Posizionare un materiale qui per mostrare ricette";
				Lang.inter[25] = "Artigianato";
				Lang.inter[26] = "Monete";
				Lang.inter[27] = "Munizioni";
				Lang.inter[28] = "Negozio";
				Lang.inter[29] = "Saccheggia tutto";
				Lang.inter[30] = "Deposita tutto";
				Lang.inter[31] = "Accumulo veloce";
				Lang.inter[32] = "Salvadanaio";
				Lang.inter[33] = "Caveau";
				Lang.inter[34] = "Tempo:";
				Lang.inter[35] = "Salva ed esci";
				Lang.inter[36] = "Disconnetti";
				Lang.inter[37] = "Oggetti";
				Lang.inter[38] = "Sei morto...";
				Lang.inter[39] = "Questo alloggio è adatto.";
				Lang.inter[40] = "Questo alloggio non è valido.";
				Lang.inter[41] = "Questo alloggio è già occupato.";
				Lang.inter[42] = "Questo alloggio è distrutto.";
				Lang.inter[43] = "Connessione scaduta";
				Lang.inter[44] = "Ricezione dati mattonella";
				Lang.inter[45] = "Equipaggiare";
				Lang.inter[46] = "Costo";
				Lang.inter[47] = "Salvare";
				Lang.inter[48] = "Edit";
				Lang.inter[49] = "Stato";
				Lang.inter[50] = "Maledizione";
				Lang.inter[51] = "Aiutare";
				Lang.inter[52] = "Fermer";
				Lang.inter[53] = "Acqua";
				Lang.inter[54] = "Guarire";
				Lang.inter[55] = "Questa custodia non soddisfa i requisiti per un";
				Lang.inter[56] = "lavica";
				Lang.inter[57] = "tingere";
				Lang.inter[58] = "dolcezza";
				Lang.inter[61] = "Rinominare";
				Lang.inter[62] = "Impostazioni";
				Lang.inter[63] = "Annulla";
				Lang.tip[0] = "Equipaggiato in slot sociale";
				Lang.tip[1] = "Nessun parametro incrementato";
				Lang.tip[2] = " Danno nel corpo a corpo";
				Lang.tip[3] = " Danno a distanza";
				Lang.tip[4] = " Danno magico";
				Lang.tip[5] = "% Possibilità colpo critico";
				Lang.tip[6] = "Velocità matta";
				Lang.tip[7] = "Extra velocità";
				Lang.tip[8] = "Alta velocità";
				Lang.tip[9] = "Media velocità";
				Lang.tip[10] = "Bassa velocità";
				Lang.tip[11] = "Velocità molto bassa";
				Lang.tip[12] = "Velocità extra bassa";
				Lang.tip[13] = "Velocità lumaca";
				Lang.tip[14] = "Nessuno spintone";
				Lang.tip[15] = "Spintone extra debole";
				Lang.tip[16] = "Spintone molto debole";
				Lang.tip[17] = "Spintone debole";
				Lang.tip[18] = "Spintone medio";
				Lang.tip[19] = "Spintone forte";
				Lang.tip[20] = "Spintone molto forte";
				Lang.tip[21] = "Spintone extra forte";
				Lang.tip[22] = "Spintone matto";
				Lang.tip[23] = "Equipaggiabili";
				Lang.tip[24] = "Oggetti estetici";
				Lang.tip[25] = " Difesa";
				Lang.tip[26] = "% Potenza piccone";
				Lang.tip[27] = "% Potenza ascia";
				Lang.tip[28] = "% Potenza martello";
				Lang.tip[29] = "Risana";
				Lang.tip[30] = "vita";
				Lang.tip[31] = "mana";
				Lang.tip[32] = "Utilizza";
				Lang.tip[33] = "Può essere posizionato";
				Lang.tip[34] = "Munizioni";
				Lang.tip[35] = "Consumabile";
				Lang.tip[36] = "Materiale";
				Lang.tip[37] = " Durata minuto";
				Lang.tip[38] = " Durata secondo";
				Lang.tip[39] = "% Danno";
				Lang.tip[40] = "% Velocità";
				Lang.tip[41] = "% Possibilità colpo critico";
				Lang.tip[42] = "% Costo mana";
				Lang.tip[43] = "% Dimensione";
				Lang.tip[44] = "% Velocità del proiettile";
				Lang.tip[45] = "% Spintone";
				Lang.tip[46] = "% Velocità movimento";
				Lang.tip[47] = "% Velocità corpo a corpo";
				Lang.tip[48] = "Imposta bonus:";
				Lang.tip[49] = "Prezzo di vendita:";
				Lang.tip[50] = "Prezzo di acquisto:";
				Lang.tip[51] = "Nessun valore";
				Lang.tip[52] = "consuma ";
				Lang.tip[53] = " convocare i danni";
				Lang.tip[54] = " gamma";
				Lang.tip[55] = " danni";
				Lang.mp[0] = "Ricevere:";
				Lang.mp[1] = "Password errata.";
				Lang.mp[2] = "Operazione non valida in questo stato.";
				Lang.mp[3] = "Sei stato bandito da questo server.";
				Lang.mp[4] = "Non stai utilizzando la stessa versione del server.";
				Lang.mp[5] = "è già su questo server.";
				Lang.mp[6] = "/in gioco";
				Lang.mp[7] = "Giocatori correnti:";
				Lang.mp[8] = "/lancia";
				Lang.mp[9] = "lancia";
				Lang.mp[10] = "Non fai parte di un gruppo!";
				Lang.mp[11] = "ha attivato il PvP!";
				Lang.mp[12] = "ha disattivato il PvP!";
				Lang.mp[13] = "non è più in un gruppo.";
				Lang.mp[14] = "si è unito al gruppo rosso.";
				Lang.mp[15] = "si è unito al gruppo verde.";
				Lang.mp[16] = "si è unito al gruppo blu.";
				Lang.mp[17] = "si è unito al gruppo giallo.";
				Lang.mp[18] = "Benevenuto a";
				Lang.mp[19] = "ha aderito.";
				Lang.mp[20] = "ha smesso di.";
				Lang.the = "la ";
				Lang.dt[0] = "non ha trovato l'antidoto";
				Lang.dt[1] = "non ha spento il fuoco";
				Main.buffName[1] = "Pelle ossidiana";
				Main.buffTip[1] = "Immune alla lava";
				Main.buffName[2] = "Rigenerazione";
				Main.buffTip[2] = "Rigenera la vita";
				Main.buffName[3] = "Velocità";
				Main.buffTip[3] = "Velocità di movimento aumentata del 25%";
				Main.buffName[4] = "Branchie";
				Main.buffTip[4] = "Respira acqua invece di aria";
				Main.buffName[5] = "Pelle di ferro";
				Main.buffTip[5] = "Aumenta la difesa di 8";
				Main.buffName[6] = "Rigenerazione mana";
				Main.buffTip[6] = "Aumenta la rigenerazione del mana";
				Main.buffName[7] = "Potere magico";
				Main.buffTip[7] = "Danno magico aumentato del 20%";
				Main.buffName[8] = "Cascata di piume";
				Main.buffTip[8] = "Premi UP o DOWN per controllare la velocità di discesa";
				Main.buffName[9] = "Speleologo";
				Main.buffTip[9] = "Mostra l'ubicazione di tesori e minerale";
				Main.buffName[10] = "Invisibilità";
				Main.buffTip[10] = "Rende invisibili";
				Main.buffName[11] = "Brillantezza";
				Main.buffTip[11] = "Emette luce";
				Main.buffName[12] = "Civetta notturna";
				Main.buffTip[12] = "Visione notturna aumentata";
				Main.buffName[13] = "Battaglia";
				Main.buffTip[13] = "Ritmo generazione nemici aumentato";
				Main.buffName[14] = "Spine";
				Main.buffTip[14] = "Anche gli aggressori subiscono danni";
				Main.buffName[15] = "Camminata nell'acqua";
				Main.buffTip[15] = "Premi DOWN per entrare nell'acqua";
				Main.buffName[16] = "Arco";
				Main.buffTip[16] = "Danno e velocià freccia aumentati del 20%";
				Main.buffName[17] = "Cacciatore";
				Main.buffTip[17] = "Mostra la posizione dei nemici";
				Main.buffName[18] = "Gravità";
				Main.buffTip[18] = "Premi UP o DOWN per invertire la gravità";
				Main.buffName[19] = "Orbita di luce";
				Main.buffTip[19] = "Sfera magica che fornisce luce";
				Main.buffName[20] = "Avvelenato";
				Main.buffTip[20] = "Perdi lentamente la vita";
				Main.buffName[21] = "Malattia pozione";
				Main.buffTip[21] = "Non si possono più consumare oggetti curativi";
				Main.buffName[22] = "Oscurità";
				Main.buffTip[22] = "Diminuita visione della luce";
				Main.buffName[23] = "Maledetto";
				Main.buffTip[23] = "Non si possono più utilizzare oggetti";
				Main.buffName[24] = "A fuoco!";
				Main.buffTip[24] = "Perdi lentamente la vita";
				Main.buffName[25] = "Brillo";
				Main.buffTip[25] = "Abilità corpo a corpo aumentata, difesa abbassata";
				Main.buffName[26] = "Ben nutrito";
				Main.buffTip[26] = "Migliorie minori a tutti i parametri";
				Main.buffName[27] = "Fata";
				Main.buffTip[27] = "Una fata ti sta seguendo";
				Main.buffName[28] = "Lupo mannaro";
				Main.buffTip[28] = "Abilità fisiche aumentate";
				Main.buffName[29] = "Chiaroveggenza";
				Main.buffTip[29] = "Poteri magici aumentati";
				Main.buffName[30] = "Emorragia";
				Main.buffTip[30] = "Impossibile rigenerare vita";
				Main.buffName[31] = "Confuso";
				Main.buffTip[31] = "Movimento invertito";
				Main.buffName[32] = "Lento";
				Main.buffTip[32] = "Ridotta velocità movimento";
				Main.buffName[33] = "Debole";
				Main.buffTip[33] = "Abilità fisiche diminuite";
				Main.buffName[34] = "Tritone";
				Main.buffTip[34] = "Può respirare e muoversi facilmente sott'acqua";
				Main.buffName[35] = "Tacere";
				Main.buffTip[35] = "Non possono utilizzare gli elementi che richiedono mana";
				Main.buffName[36] = "Armatura rotta";
				Main.buffTip[36] = "La difesa è dimezzata";
				Main.buffName[37] = "Inorridito";
				Main.buffTip[37] = "Hai visto qualcosa di orribile, non c'è via di scampo.";
				Main.buffName[38] = "La Lingua";
				Main.buffTip[38] = "Sei stato succhiato nella bocca";
				Main.buffName[39] = "Inferno maledetto";
				Main.buffTip[39] = "Perdi la vita";
				Main.buffName[40] = "Animale coniglio";
				Main.buffTip[40] = "Penso che vuole la tua carota";
				Main.buffName[41] = "baby pinguino";
				Main.buffTip[41] = "Penso che vuole il vostro pesce";
				Main.buffName[42] = "tartaruga";
				Main.buffTip[42] = "Tempo tartaruga felice!";
				Main.buffName[43] = "Scudo Paladino";
				Main.buffTip[43] = "Il 25% dei danni subiti sarà reindirizzato ad un altro giocatore";
				Main.buffName[44] = "gelo ustione";
				Main.buffTip[44] = "E 'sia davvero caldo o molto freddo. In entrambi i casi fa davvero male";
				Main.buffName[45] = "bambino Eater";
				Main.buffTip[45] = "Un bambino Eater of Souls ti sta seguendo";
				Main.buffName[46] = "refrigerate";
				Main.buffTip[46] = "La velocità di movimento è stato ridotto";
				Main.buffName[47] = "congelato";
				Main.buffTip[47] = "Non è possibile spostare!";
				Main.buffName[48] = "dolcezza";
				Main.buffTip[48] = "La vita di rigenerazione viene aumentata";
				Main.buffName[49] = "pigmei";
				Main.buffTip[49] = "I pigmei combatteranno per voi";
				Main.buffName[50] = "Bambino Skeletron Capo";
				Main.buffTip[50] = "Non hanno nemmeno chiedere ...";
				Main.buffName[51] = "bambino Hornet";
				Main.buffTip[51] = "Si pensa che tu sia sua madre";
				Main.buffName[52] = "Tiki Spirito";
				Main.buffTip[52] = "Uno spirito amichevole ti sta seguendo";
				Main.buffName[53] = "lucertola";
				Main.buffTip[53] = "Chillin 'come un rettile";
				Main.buffName[54] = "Pet Parrot";
				Main.buffTip[54] = "Polly want è il cracker";
				Main.buffName[55] = "tartufo bambino";
				Main.buffTip[55] = "Non è questo solo soooo cute?";
				Main.buffName[56] = "Pet Alberello";
				Main.buffTip[56] = "Un piccolo alberello ti sta seguendo";
				Main.buffName[57] = "Wisp";
				Main.buffTip[57] = "Un filo ti sta seguendo";
				Main.buffName[58] = "rapida guarigione";
				Main.buffTip[58] = "Vita rigenerazione è notevolmente aumentato";
				Main.buffName[59] = "ombra Dodge";
				Main.buffTip[59] = "Potrai schivare il prossimo attacco";
				Main.buffName[60] = "foglia di cristallo";
				Main.buffTip[60] = "Lascia cristallo spara a nemici nelle vicinanze";
				Main.buffName[61] = "cucciolo di dinosauro";
				Main.buffTip[61] = "Un dinosauro bambino ti sta seguendo";
				Main.buffName[62] = "Barriera di Ghiaccio";
				Main.buffTip[62] = "La difesa è aumentata del 30";
				Main.buffName[63] = "panico!";
				Main.buffTip[63] = "Velocità di movimento è aumentata";
				Main.buffName[64] = "bambino Slime";
				Main.buffTip[64] = "Il bambino melma combatterà per voi";
				Main.buffName[65] = "Eyeball Primavera";
				Main.buffTip[65] = "Una molla bulbo oculare ti sta seguendo";
				Main.buffName[66] = "bambino Snowman";
				Main.buffTip[66] = "Un pupazzo di neve bambino ti sta seguendo";
				Main.buffName[67] = "Masterizzazione";
				Main.buffTip[67] = "Perdere la vita e rallentato il movimento";
				Main.buffName[68] = "soffocamento";
				Main.buffTip[68] = "perdere la vita";
				Main.buffName[69] = "Ichor";
				Main.buffTip[69] = "difesa ridotto";
				Main.buffName[70] = "Venom";
				Main.buffTip[70] = "perdere la vita";
				Main.buffName[72] = "Midas";
				Main.buffTip[72] = "Goccia più soldi sulla morte";
				Main.buffName[80] = "Blackout";
				Main.buffTip[80] = "Vision Light notevolmente ridotta";
				Main.buffName[71] = "Arma Imbue: veleno";
				Main.buffTip[71] = "Attacchi in mischia infliggono veleno sui tuoi obiettivi";
				Main.buffName[73] = "Arma Imbue: Fiamme Cursed";
				Main.buffTip[73] = "Attacchi in mischia infliggono nemici con fiamme maledette";
				Main.buffName[74] = "Arma Imbue: Fuoco";
				Main.buffTip[74] = "Attacchi corpo a corpo impostati nemici in fiamme";
				Main.buffName[75] = "Arma Imbue: Gold";
				Main.buffTip[75] = "Attacchi corpo a corpo i nemici fanno cadere più oro";
				Main.buffName[76] = "Arma Imbue: Ichor";
				Main.buffTip[76] = "Attacchi corpo a corpo diminuiscono nemici difesa";
				Main.buffName[77] = "Arma Imbue: Nanites";
				Main.buffTip[77] = "Attacchi corpo a corpo confondono i nemici";
				Main.buffName[78] = "Arma Imbue: Confetti";
				Main.buffTip[78] = "Attacchi corpo a corpo causano a comparire coriandoli";
				Main.buffName[79] = "Arma Imbue: Poison";
				Main.buffTip[79] = "Mischia attacca nemici veleno";
				Lang.prefix[1] = "Grande";
				Lang.prefix[2] = "Massiccio";
				Lang.prefix[3] = "Pericoloso";
				Lang.prefix[4] = "Selvaggio";
				Lang.prefix[5] = "Appuntito";
				Lang.prefix[6] = "Tagliente";
				Lang.prefix[7] = "Minuto";
				Lang.prefix[8] = "Terribile";
				Lang.prefix[9] = "Piccolo";
				Lang.prefix[10] = "Opaco";
				Lang.prefix[11] = "Infelice";
				Lang.prefix[12] = "Ingombrante";
				Lang.prefix[13] = "Vergognoso";
				Lang.prefix[14] = "Pesante";
				Lang.prefix[15] = "Luce";
				Lang.prefix[16] = "Avvistato";
				Lang.prefix[17] = "Rapido";
				Lang.prefix[18] = "Frettoloso";
				Lang.prefix[19] = "Intimidatorio";
				Lang.prefix[20] = "Mortale";
				Lang.prefix[21] = "Convinto";
				Lang.prefix[22] = "Orribile";
				Lang.prefix[23] = "Letargico";
				Lang.prefix[24] = "Scomodo";
				Lang.prefix[25] = "Potente";
				Lang.prefix[26] = "Mistico";
				Lang.prefix[27] = "Esperto";
				Lang.prefix[28] = "Magistrale";
				Lang.prefix[29] = "Inetto";
				Lang.prefix[30] = "Ignorante";
				Lang.prefix[31] = "Squilibrato";
				Lang.prefix[32] = "Intenso";
				Lang.prefix[33] = "Tabù";
				Lang.prefix[34] = "Celeste";
				Lang.prefix[35] = "Furioso";
				Lang.prefix[36] = "Appassionato";
				Lang.prefix[37] = "Superiore";
				Lang.prefix[38] = "Forte";
				Lang.prefix[39] = "Rotto";
				Lang.prefix[40] = "Danneggiato";
				Lang.prefix[41] = "Scadente";
				Lang.prefix[42] = "Veloce";
				Lang.prefix[43] = "Mortale";
				Lang.prefix[44] = "Agile";
				Lang.prefix[45] = "Lesto";
				Lang.prefix[46] = "Omicida";
				Lang.prefix[47] = "Lento";
				Lang.prefix[48] = "Pigro";
				Lang.prefix[49] = "Indolente";
				Lang.prefix[50] = "Fastidioso";
				Lang.prefix[51] = "Brutto";
				Lang.prefix[52] = "Maniaco";
				Lang.prefix[53] = "Offensivo";
				Lang.prefix[54] = "Robusto";
				Lang.prefix[55] = "Sgradevole";
				Lang.prefix[56] = "Debole";
				Lang.prefix[57] = "Spietato";
				Lang.prefix[58] = "Frenetico";
				Lang.prefix[59] = "Devoto";
				Lang.prefix[60] = "Demonico";
				Lang.prefix[61] = "Zelante";
				Lang.prefix[62] = "Duro";
				Lang.prefix[63] = "Protettivo";
				Lang.prefix[64] = "Corazzato";
				Lang.prefix[65] = "Difensivo";
				Lang.prefix[66] = "Arcano";
				Lang.prefix[67] = "Preciso";
				Lang.prefix[68] = "Fortunato";
				Lang.prefix[69] = "Frastagliato";
				Lang.prefix[70] = "Spillo";
				Lang.prefix[71] = "Arrabbiato";
				Lang.prefix[72] = "Minaccioso";
				Lang.prefix[73] = "Vivace";
				Lang.prefix[74] = "Fugace";
				Lang.prefix[75] = "Frettoloso";
				Lang.prefix[76] = "Veloce";
				Lang.prefix[77] = "Selvaggio";
				Lang.prefix[78] = "Temerario";
				Lang.prefix[79] = "Intrepido";
				Lang.prefix[80] = "Violento";
				Lang.prefix[81] = "Leggendario";
				Lang.prefix[82] = "Irreale";
				Lang.prefix[83] = "Mitico";
			}
			else if (Lang.lang == 4)
			{
				Lang.misc[0] = "L'armée des gobelins a été vaincue.";
				Lang.misc[1] = "Une armée de gobelins approche par l'ouest.";
				Lang.misc[2] = "Une armée de gobelins approche par l'est.";
				Lang.misc[3] = "Une armée gobelin est arrivé!";
				Lang.misc[4] = "La Légion Frost a été vaincu!";
				Lang.misc[5] = "La Légion Frost est venant de l'ouest!";
				Lang.misc[6] = "La Légion Frost est l'approche de l'Est!";
				Lang.misc[7] = "La Légion gel est arrivé!";
				Lang.misc[8] = "La lune de sang se lève...";
				Lang.misc[9] = "Vous sentez une présence maléfique vous observer.";
				Lang.misc[10] = "Un frisson vous parcourt le dos...";
				Lang.misc[11] = "Des cris retentissent autour de vous...";
				Lang.misc[12] = "Votre monde a la chance de profiter de ressources de cobalt.";
				Lang.misc[13] = "Votre monde a la chance de profiter de ressources de mythril.";
				Lang.misc[14] = "Votre monde a la chance de profiter de ressources d'adamantine.";
				Lang.misc[15] = "Les anciens esprits de l'ombre et de la lumière ont été relâchés.";
				Lang.misc[16] = "est réveillé.";
				Lang.misc[17] = "a été vaincue.";
				Lang.misc[18] = "est arrivée.";
				Lang.misc[19] = " s'est fait éviscérer...";
				Lang.misc[20] = "Une éclipse solaire se produit!";
				Lang.misc[21] = "Votre monde a été béni avec Palladium!";
				Lang.misc[22] = "Votre monde a été béni avec orichalque!";
				Lang.misc[23] = "Votre monde a été béni avec Titanium!";
				Lang.misc[24] = "Les pirates ont été vaincus!";
				Lang.misc[25] = "Les pirates venant de l'ouest!";
				Lang.misc[26] = "Pirates se rapprochent de l'Est!";
				Lang.misc[27] = "Les pirates sont arrivés!";
				Lang.misc[28] = "Vous vous sentez des vibrations du plus profond ci-dessous ...";
				Lang.misc[29] = "Cela va être une nuit terrible ...";
				Lang.misc[30] = "L'air se refroidit autour de vous ...";
				Lang.menu[0] = "Démarrez une nouvelle instance de Terraria pour rejoindre une partie.";
				Lang.menu[1] = "Fonctionne sur le port ";
				Lang.menu[2] = "Déconnexion";
				Lang.menu[3] = "Le serveur requiert un mot de passe :";
				Lang.menu[4] = "Accepter";
				Lang.menu[5] = "Retour";
				Lang.menu[6] = "Annuler";
				Lang.menu[7] = "Entrer le mot de passe :";
				Lang.menu[8] = "Lancement du serveur...";
				Lang.menu[9] = "Le chargement a échoué.";
				Lang.menu[10] = "Charger une sauvegarde";
				Lang.menu[11] = "Aucune sauvegarde trouvée";
				Lang.menu[12] = "Un joueur";
				Lang.menu[13] = "Multijoueur";
				Lang.menu[14] = "Réglages";
				Lang.menu[15] = "Quitter";
				Lang.menu[16] = "Créer un personnage";
				Lang.menu[17] = "Supprimer";
				Lang.menu[18] = "Cheveux";
				Lang.menu[19] = "Yeux";
				Lang.menu[20] = "Peau";
				Lang.menu[21] = "Vêtements";
				Lang.menu[22] = "Homme";
				Lang.menu[23] = "Femme";
				Lang.menu[24] = "Difficile";
				Lang.menu[25] = "Normal";
				Lang.menu[26] = "Facile";
				Lang.menu[27] = "Aléatoire";
				Lang.menu[28] = "Créer";
				Lang.menu[29] = "En cas de mort dans le mode Difficile, le personnage est tout simplement supprimé";
				Lang.menu[30] = "En cas de mort dans le mode Normal, les personnages laissent échapper des objets en mourant";
				Lang.menu[31] = "Les personnages en mode facile laissent échapper de l'argent en mourant.";
				Lang.menu[32] = "Choisir la difficulté";
				Lang.menu[33] = "Chemise";
				Lang.menu[34] = "Maillot de corps";
				Lang.menu[35] = "Pantalon";
				Lang.menu[36] = "Chaussures";
				Lang.menu[37] = "Cheveux";
				Lang.menu[38] = "Couleur des cheveux";
				Lang.menu[39] = "Couleur des yeux";
				Lang.menu[40] = "Couleur de peau";
				Lang.menu[41] = "Couleur de chemise";
				Lang.menu[42] = "Couleur de maillot de corps";
				Lang.menu[43] = "Couleur de pantalon";
				Lang.menu[44] = "Couelur des chaussures";
				Lang.menu[45] = "Saisir le nom du personnage :";
				Lang.menu[46] = "Supprimer";
				Lang.menu[47] = "Créer un monde";
				Lang.menu[48] = "Saisir un nom de monde :";
				Lang.menu[49] = "Mode fenêtré";
				Lang.menu[50] = "Mode Plein écran";
				Lang.menu[51] = "Résolution";
				Lang.menu[52] = "Parallax";
				Lang.menu[53] = "Frame Skip activé (non recommandé)";
				Lang.menu[54] = "Frame Skip désactivé (recommandé)";
				Lang.menu[55] = "Lumière : couleur";
				Lang.menu[56] = "Lumière : blanche";
				Lang.menu[57] = "Lumière : rétro";
				Lang.menu[58] = "Lumière : psyché";
				Lang.menu[59] = "Qualité : auto";
				Lang.menu[60] = "Qualité : haute";
				Lang.menu[61] = "Qualité : moyenne";
				Lang.menu[62] = "Qualité : basse";
				Lang.menu[63] = "Vidéo";
				Lang.menu[64] = "Curseur chromatique";
				Lang.menu[65] = "Volume";
				Lang.menu[66] = "Contrôles";
				Lang.menu[67] = "Sauvegarde auto activée";
				Lang.menu[68] = "Sauvegarde auto désactivée";
				Lang.menu[69] = "Pause auto activée";
				Lang.menu[70] = "Pause auto désactivée";
				Lang.menu[71] = "Affichage du texte activé";
				Lang.menu[72] = "Affichage du texte désactivé";
				Lang.menu[73] = "Résolution Plein écran";
				Lang.menu[74] = "Haut              ";
				Lang.menu[75] = "Bas               ";
				Lang.menu[76] = "Gauche           ";
				Lang.menu[77] = "Droite             ";
				Lang.menu[78] = "Sauter            ";
				Lang.menu[79] = "Lancer            ";
				Lang.menu[80] = "Inventaire        ";
				Lang.menu[81] = "Soin rapide      ";
				Lang.menu[82] = "Mana rapide     ";
				Lang.menu[83] = "Buff rapide      ";
				Lang.menu[84] = "Agripper          ";
				Lang.menu[85] = "Sélection auto    ";
				Lang.menu[86] = "Réglages par défaut";
				Lang.menu[87] = "Rejoindre";
				Lang.menu[88] = "Héberger et jouer";
				Lang.menu[89] = "Entrer l'adresse IP du serveur :";
				Lang.menu[90] = "Entrer le port du serveur :";
				Lang.menu[91] = "Choisir la taille du monde :";
				Lang.menu[92] = "Petit";
				Lang.menu[93] = "Moyen";
				Lang.menu[94] = "Grand";
				Lang.menu[95] = "Rouge :";
				Lang.menu[96] = "Vert :";
				Lang.menu[97] = "Bleu :";
				Lang.menu[98] = "Son :";
				Lang.menu[99] = "Musique :";
				Lang.menu[100] = "De fond sur";
				Lang.menu[101] = "De fond au large";
				Lang.menu[102] = "Sélectionnez la langue";
				Lang.menu[103] = "Langue";
				Lang.menu[104] = "Oui";
				Lang.menu[105] = "Pas";
				Lang.menu[106] = "Basculer Carte de style";
				Lang.menu[107] = "basculer Plein écran";
				Lang.menu[108] = "Zoom";
				Lang.menu[109] = "Zoom arrière";
				Lang.menu[110] = "Diminution de la transparence";
				Lang.menu[111] = "augmenter la transparence";
				Lang.menu[112] = "carte Activé";
				Lang.menu[113] = "carte handicapés";
				Lang.gen[0] = "Création du terrain :";
				Lang.gen[1] = "Ajout de sable...";
				Lang.gen[2] = "Création des collines...";
				Lang.gen[3] = "Placement de la boue derrière la boue :";
				Lang.gen[4] = "Placement des rochers dans la boue...";
				Lang.gen[5] = "Placement de boue dans les rochers...";
				Lang.gen[6] = "Ajout d'argile...";
				Lang.gen[7] = "Création de trous aléatoires :";
				Lang.gen[8] = "Création de petites cavernes :";
				Lang.gen[9] = "Création de grandes cavernes :";
				Lang.gen[10] = "Création des cavernes en surface...";
				Lang.gen[11] = "Création de jungle :";
				Lang.gen[12] = "Création d'îles flottantes...";
				Lang.gen[13] = "Ajout des patchs de champignon...";
				Lang.gen[14] = "Placement de la terre dans la boue...";
				Lang.gen[15] = "Ajout de limon...";
				Lang.gen[16] = "Ajout des brillances...";
				Lang.gen[17] = "Ajout de toiles d'araignées...";
				Lang.gen[18] = "Création du monde inférieur :";
				Lang.gen[19] = "Ajout d'étendues d'eau :";
				Lang.gen[20] = "Corruption du monde :";
				Lang.gen[21] = "Création de cavernes montagneuses...";
				Lang.gen[22] = "Création de plages...";
				Lang.gen[23] = "Ajout de gemmes...";
				Lang.gen[24] = "Gravitation du sable :";
				Lang.gen[25] = "Nettoyage d'arrière-plans de boue :";
				Lang.gen[26] = "Placement d'autels :";
				Lang.gen[27] = "Clarification de l'eau :";
				Lang.gen[28] = "Placement de cristaux de vie :";
				Lang.gen[29] = "Placement de statues :";
				Lang.gen[30] = "Dissimulation de trésor :";
				Lang.gen[31] = "Dissimulation de trésor supplémentaire :";
				Lang.gen[32] = "Dissimulation de trésor de jungle :";
				Lang.gen[33] = "Dissimulation de trésor dans l'eau :";
				Lang.gen[34] = "Placement de pièges :";
				Lang.gen[35] = "Placement d'objets cassables :";
				Lang.gen[36] = "Placement de forges infernales :";
				Lang.gen[37] = "Placement de l'herbe :";
				Lang.gen[38] = "Faire pousser des cactus...";
				Lang.gen[39] = "Plantation de tournesols...";
				Lang.gen[40] = "Plantation d'arbres...";
				Lang.gen[41] = "Plantation d'herbe...";
				Lang.gen[42] = "Plantation de mauvaises herbes...";
				Lang.gen[43] = "Faire pousser des vignes...";
				Lang.gen[44] = "Plantation de fleurs...";
				Lang.gen[45] = "Plantation de champignons...";
				Lang.gen[46] = "Libération des ressources inutilisées :";
				Lang.gen[47] = "Réinitialisation des objets du jeu :";
				Lang.gen[48] = "Réglage du mode difficile...";
				Lang.gen[49] = "Sauvegarde des données du monde :";
				Lang.gen[50] = "Sauvegarde du fichier du monde...";
				Lang.gen[51] = "Chargement des données du monde :";
				Lang.gen[52] = "Vérification de l'alignement de blocs :";
				Lang.gen[53] = "Le chargement a échoué.";
				Lang.gen[54] = "Aucune sauvegarde trouvée.";
				Lang.gen[55] = "Trouver les images de blocs :";
				Lang.gen[56] = "Ajout de la neige ...";
				Lang.gen[57] = "Mondiale";
				Lang.gen[58] = "Créer donjon:";
				Lang.gen[59] = "Une météorite a atterri!";
				Lang.gen[60] = "Lissage du monde:";
				Lang.gen[61] = "Mossification:";
				Lang.gen[62] = "Gemification:";
				Lang.gen[63] = "Faire parois de la grotte:";
				Lang.gen[64] = "Growing grottes d'araignée:";
				Lang.gen[65] = "Clearing données cartographiques:";
				Lang.gen[66] = "Sauvegarde des données de la carte:";
				Lang.gen[67] = "Chargement des données cartographiques:";
				Lang.gen[68] = "dessin carte:";
				Lang.gen[69] = "créer des cascades:";
				Lang.gen[70] = "Création ruines dans la jungle...";
				Lang.gen[71] = "Création de nids de frelons...";
				Lang.gen[72] = "Faire la sanglante monde:";
				Lang.inter[0] = "Vie :";
				Lang.inter[1] = "Souffle ";
				Lang.inter[2] = "Mana :";
				Lang.inter[3] = "Poubelle";
				Lang.inter[4] = "Inventaire";
				Lang.inter[5] = "Barre d'inventaire déverrouillée";
				Lang.inter[6] = "Barre d'inventaire verrouillée";
				Lang.inter[7] = "Logement";
				Lang.inter[8] = "Demande de logement";
				Lang.inter[9] = "Accessoires";
				Lang.inter[10] = "Défense";
				Lang.inter[11] = "Social";
				Lang.inter[12] = "Casque";
				Lang.inter[13] = "Chemise";
				Lang.inter[14] = "Pantalon";
				Lang.inter[15] = "Platine";
				Lang.inter[16] = "Or";
				Lang.inter[17] = "Argent";
				Lang.inter[18] = "Cuivre";
				Lang.inter[19] = "Reforger";
				Lang.inter[20] = "Placer un objet ici pour le reforger";
				Lang.inter[21] = "Affichage des techniques utilisant";
				Lang.inter[22] = "Objets requis :";
				Lang.inter[23] = "Aucun";
				Lang.inter[24] = "Placer un matériau ici pour afficher les techniques";
				Lang.inter[25] = "Artisanat";
				Lang.inter[26] = "Pièces";
				Lang.inter[27] = "Munitions";
				Lang.inter[28] = "Magasin";
				Lang.inter[29] = "Tout récupérer";
				Lang.inter[30] = "Tout déposer";
				Lang.inter[31] = "Pile rapide";
				Lang.inter[32] = "Tirelire";
				Lang.inter[33] = "Coffre-fort";
				Lang.inter[34] = "Temps :";
				Lang.inter[35] = "Sauvegarder et quitter";
				Lang.inter[36] = "Déconnexion";
				Lang.inter[37] = "Objets";
				Lang.inter[38] = "Vous vous êtes fait exterminer...";
				Lang.inter[39] = "Ce logement convient.";
				Lang.inter[40] = "Ce logement ne convient pas.";
				Lang.inter[41] = "Ce logement est déjà occupé.";
				Lang.inter[42] = "Ce logement est corrompu.";
				Lang.inter[43] = "La connexion a été interrompue";
				Lang.inter[44] = "Réception de données de blocs";
				Lang.inter[45] = "équiper";
				Lang.inter[46] = "Coût";
				Lang.inter[47] = "Enregistrer";
				Lang.inter[48] = "Modifier";
				Lang.inter[49] = "État";
				Lang.inter[50] = "Malédiction";
				Lang.inter[51] = "Aide";
				Lang.inter[52] = "Proches";
				Lang.inter[53] = "De l'eau";
				Lang.inter[54] = "Guérir";
				Lang.inter[55] = "Ce logement ne répond pas aux exigences d'un";
				Lang.inter[56] = "Lave";
				Lang.inter[57] = "teindre";
				Lang.inter[58] = "chérie";
				Lang.inter[61] = "Rebaptiser";
				Lang.inter[62] = "Paramètres";
				Lang.inter[63] = "Annuler";
				Lang.tip[0] = "Équipé dans l'emplacement social";
				Lang.tip[1] = "Ne procure pas de stats";
				Lang.tip[2] = " de dégâts de mêlée";
				Lang.tip[3] = " de dégâts à distance";
				Lang.tip[4] = " de dégâts de magie";
				Lang.tip[5] = "% de chance de coup critique";
				Lang.tip[6] = "Vitesse insensée";
				Lang.tip[7] = "Vitesse très rapide";
				Lang.tip[8] = "Vitesse rapide";
				Lang.tip[9] = "Vitesse moyenne";
				Lang.tip[10] = "Vitesse lente";
				Lang.tip[11] = "Vitesse très lente";
				Lang.tip[12] = "Vitesse extrêmement lente";
				Lang.tip[13] = "Vitesse d'escargot";
				Lang.tip[14] = "Pas de recul";
				Lang.tip[15] = "Recul extrêmement faible";
				Lang.tip[16] = "Recul très faible";
				Lang.tip[17] = "Recul faible";
				Lang.tip[18] = "Recul moyen";
				Lang.tip[19] = "Fort recul";
				Lang.tip[20] = "Très fort recul";
				Lang.tip[21] = "Recul extrêmement fort";
				Lang.tip[22] = "Recul ahurissant";
				Lang.tip[23] = "Équipable";
				Lang.tip[24] = "Objets sociaux";
				Lang.tip[25] = " de défense";
				Lang.tip[26] = "% de puissance de pioche";
				Lang.tip[27] = "% de puissance de hache";
				Lang.tip[28] = "% de puissance de marteau";
				Lang.tip[29] = "Redonne";
				Lang.tip[30] = "de vie";
				Lang.tip[31] = "de mana";
				Lang.tip[32] = "Consomme";
				Lang.tip[33] = "Peut être placé";
				Lang.tip[34] = "Munitions";
				Lang.tip[35] = "Consommable";
				Lang.tip[36] = "Matériau";
				Lang.tip[37] = " Durée minute";
				Lang.tip[38] = " Durée seconde";
				Lang.tip[39] = "% de dégâts";
				Lang.tip[40] = "% de vélocité";
				Lang.tip[41] = "% de chance de coup critique";
				Lang.tip[42] = "% de coût de mana";
				Lang.tip[43] = "% de la taille";
				Lang.tip[44] = "% de vitesse de projectile";
				Lang.tip[45] = "% de recul";
				Lang.tip[46] = "% de vitesse de déplacement";
				Lang.tip[47] = "% de vitesse de mêlée";
				Lang.tip[48] = "Bonus de collection :";
				Lang.tip[49] = "Prix de vente :";
				Lang.tip[50] = "Prix d'achat :";
				Lang.tip[51] = "Aucune valeur";
				Lang.tip[52] = "consomme ";
				Lang.tip[53] = " convoquer des dommages";
				Lang.tip[54] = " gamme";
				Lang.tip[55] = " dommage";
				Lang.mp[0] = "Recevoir :";
				Lang.mp[1] = "Mot de passe incorrect.";
				Lang.mp[2] = "Opération non valable en l'état.";
				Lang.mp[3] = "Vous vous êtes fait bannir de ce serveur.";
				Lang.mp[4] = "Vous n'utilisez pas la même version que ce serveur.";
				Lang.mp[5] = "est déjà sur ce serveur.";
				Lang.mp[6] = "/en train de jouer";
				Lang.mp[7] = "Joueurs actuels :";
				Lang.mp[8] = "/jet";
				Lang.mp[9] = "lance un";
				Lang.mp[10] = "Vous n'êtes pas dans une équipe.";
				Lang.mp[11] = "a activé le PvP.";
				Lang.mp[12] = "a désactivé le PvP.";
				Lang.mp[13] = "n'est plus dans une équipe.";
				Lang.mp[14] = "a rejoint l'équipe rouge.";
				Lang.mp[15] = "a rejoint l'équipe verte.";
				Lang.mp[16] = "a rejoint l'équipe bleue.";
				Lang.mp[17] = "a rejoint l'équipe jaune.";
				Lang.mp[18] = "Bienvenue dans";
				Lang.mp[19] = "a rejoint.";
				Lang.mp[20] = "a quitté.";
				Lang.the = "le ";
				Lang.dt[0] = "n'a pas trouvé l'antidote";
				Lang.dt[1] = "n'a pas réussi à éteindre l'incendie";
				Main.buffName[1] = "Peau d'obsidienne";
				Main.buffTip[1] = "Immunise contre la lave";
				Main.buffName[2] = "Régénération";
				Main.buffTip[2] = "Régénère la vie";
				Main.buffName[3] = "Rapidité";
				Main.buffTip[3] = "Augmente la vitesse de déplacement de 25 %";
				Main.buffName[4] = "Branchies";
				Main.buffTip[4] = "Permet de respirer sous l'eau comme dans l'air";
				Main.buffName[5] = "Peau de fer";
				Main.buffTip[5] = "Augmente la défense de 8";
				Main.buffName[6] = "Régénération de mana";
				Main.buffTip[6] = "Augmente la régénération de mana";
				Main.buffName[7] = "Pouvoir magique";
				Main.buffTip[7] = "Augmente les dégâts de magie de 20 %";
				Main.buffName[8] = "Poids plume";
				Main.buffTip[8] = "Appuyer sur Bas ou Haut pour contrôler la vitesse de descente";
				Main.buffName[9] = "Spéléologue";
				Main.buffTip[9] = "Indique l'emplacement des trésors et du minerai";
				Main.buffName[10] = "Invisibilité";
				Main.buffTip[10] = "Procure l'invisibilité";
				Main.buffName[11] = "Brillance";
				Main.buffTip[11] = "Emet une aura de lumière";
				Main.buffName[12] = "Vision nocturne";
				Main.buffTip[12] = "Améliore la vision de nuit";
				Main.buffName[13] = "Bataille";
				Main.buffTip[13] = "Augmente la vitesse d'apparition des ennemis";
				Main.buffName[14] = "Épines";
				Main.buffTip[14] = "Les attaquants subissent aussi des dégâts";
				Main.buffName[15] = "Marche sur l'eau";
				Main.buffTip[15] = "Appuyer sur Bas pour entrer dans l'eau";
				Main.buffName[16] = "Tir à l'arc";
				Main.buffTip[16] = "La vitesse et les dégâts des flèches augmentent de 20 %";
				Main.buffName[17] = "Chasseur";
				Main.buffTip[17] = "Indique l'emplacement des ennemis";
				Main.buffName[18] = "Gravitation";
				Main.buffTip[18] = "Appuyer sur Haut ou Bas pour inverser la gravité";
				Main.buffName[19] = "Orbe de lumière";
				Main.buffTip[19] = "Un orbe magique qui émet de la lumière";
				Main.buffName[20] = "Empoisonnement";
				Main.buffTip[20] = "Perte lente de vie";
				Main.buffName[21] = "Nausée des potions";
				Main.buffTip[21] = "Ne peut plus consommer de potions de soin";
				Main.buffName[22] = "Obscurité";
				Main.buffTip[22] = "Diminue la vision de nuit";
				Main.buffName[23] = "Malédiction";
				Main.buffTip[23] = "Ne peut utiliser aucun objet";
				Main.buffName[24] = "En feu !";
				Main.buffTip[24] = "Perte lente de vie";
				Main.buffName[25] = "Ivresse";
				Main.buffTip[25] = "Augmente les aptitudes de mêlée, diminue la défense";
				Main.buffName[26] = "Bien nourri";
				Main.buffTip[26] = "Amélioration mineure de toutes les stats.";
				Main.buffName[27] = "Fée";
				Main.buffTip[27] = "Une fée vous suit";
				Main.buffName[28] = "Loup-garou";
				Main.buffTip[28] = "Les aptitudes physiques sont augmentées";
				Main.buffName[29] = "Clairvoyance";
				Main.buffTip[29] = "Les pouvoirs magiques sont augmentés";
				Main.buffName[30] = "Saignement";
				Main.buffTip[30] = "Ne peut régénérer la vie";
				Main.buffName[31] = "Confusion";
				Main.buffTip[31] = "Les mouvements sont inversés";
				Main.buffName[32] = "Ralentissement";
				Main.buffTip[32] = "La vitesse de déplacement est réduite";
				Main.buffName[33] = "Faiblesse";
				Main.buffTip[33] = "Les aptitudes physiques sont diminuées";
				Main.buffName[34] = "Peuple des mers";
				Main.buffTip[34] = "Peut respirer et se déplacer sous l'eau facilement";
				Main.buffName[35] = "Silencieux";
				Main.buffTip[35] = "Ne peut pas utiliser des éléments qui nécessitent de mana";
				Main.buffName[36] = "Armure brisée";
				Main.buffTip[36] = "La défense est réduite de moitié";
				Main.buffName[37] = "Peur panique";
				Main.buffTip[37] = "Vous avez vu quelque chose de terrible et vous ne pouvez vous échapper.";
				Main.buffName[38] = "La langue";
				Main.buffTip[38] = "Vous vous êtes fait aspirer dans la bouche";
				Main.buffName[39] = "Brasier maudit";
				Main.buffTip[39] = "Perte de vie";
				Main.buffName[40] = "Animal lapin";
				Main.buffTip[40] = "Je pense qu'il veut votre carotte";
				Main.buffName[41] = "bébé pingouin";
				Main.buffTip[41] = "Je pense qu'il veut votre poisson";
				Main.buffName[42] = "Animaux tortue";
				Main.buffTip[42] = "Temps de tortue heureuse!";
				Main.buffName[43] = "Bouclier de Paladin";
				Main.buffTip[43] = "25% des dégâts subis sera redirigé vers un autre joueur";
				Main.buffName[44] = "gel brûlure";
				Main.buffTip[44] = "C'est soit très chaud ou très froid. De toute façon ça fait vraiment mal";
				Main.buffName[45] = "Bébé Eater";
				Main.buffTip[45] = "Un bébé Eater of Souls vous suit";
				Main.buffName[46] = "réfrigéré";
				Main.buffTip[46] = "Votre vitesse de déplacement a été réduite";
				Main.buffName[47] = "congelé";
				Main.buffTip[47] = "Vous ne pouvez pas déplacer!";
				Main.buffName[48] = "chérie";
				Main.buffTip[48] = "Régénération de vie est augmentée";
				Main.buffName[49] = "Pygmées";
				Main.buffTip[49] = "Les pygmées se battront pour vous";
				Main.buffName[50] = "Bébé Skeletron Head";
				Main.buffTip[50] = "Ne demandent même pas ...";
				Main.buffName[51] = "Bébé Hornet";
				Main.buffTip[51] = "Il pense que vous êtes sa mère";
				Main.buffName[52] = "tiki esprit";
				Main.buffTip[52] = "Un esprit convivial vous suit";
				Main.buffName[53] = "lézard de compagnie";
				Main.buffTip[53] = "Chillin 'comme un reptile";
				Main.buffName[54] = "perroquet";
				Main.buffTip[54] = "Polly veulent du pirate";
				Main.buffName[55] = "Bébé Truffe";
				Main.buffTip[55] = "N'est-ce pas juste si mignon?";
				Main.buffName[56] = "Pet Arbrisseau";
				Main.buffTip[56] = "Un petit arbre vous suit";
				Main.buffName[57] = "Wisp";
				Main.buffTip[57] = "Un brin vous suit";
				Main.buffName[58] = "guérison rapide";
				Main.buffTip[58] = "Régénération de vie est considérablement augmentée";
				Main.buffName[59] = "Dodge Shadow";
				Main.buffTip[59] = "Vous pourrez esquiver la prochaine attaque";
				Main.buffName[60] = "cristal Feuille";
				Main.buffTip[60] = "Cristal Lance laisse les ennemis proches";
				Main.buffName[61] = "bébé dinosaure";
				Main.buffTip[61] = "Un dinosaure de bébé vous suit";
				Main.buffName[62] = "Barrière de glace";
				Main.buffTip[62] = "La défense est augmentée de 30";
				Main.buffName[63] = "Panic!";
				Main.buffTip[63] = "La vitesse de déplacement est augmentée";
				Main.buffName[64] = "Bébé Slime";
				Main.buffTip[64] = "Le bébé bave combattra pour vous";
				Main.buffName[65] = "Printemps de globe oculaire";
				Main.buffTip[65] = "Un ressort d'œil vous suit";
				Main.buffName[66] = "Bébé de bonhomme de neige";
				Main.buffTip[66] = "Un bonhomme de neige de bébé vous suit";
				Main.buffName[67] = "brûler";
				Main.buffTip[67] = "Perdre la vie et ralenti le mouvement";
				Main.buffName[68] = "étouffement";
				Main.buffTip[68] = "perdre la vie";
				Main.buffName[69] = "Ichor";
				Main.buffTip[69] = "défense réduite";
				Main.buffName[70] = "Venom";
				Main.buffTip[70] = "perdre la vie";
				Main.buffName[72] = "Midas";
				Main.buffTip[72] = "Déposer plus d'argent sur la mort";
				Main.buffName[80] = "Blackout";
				Main.buffTip[80] = "Vision lumière fortement réduite";
				Main.buffName[71] = "Weapon Imbue: Venom";
				Main.buffTip[71] = "Les attaques de mêlée infligent venin sur vos cibles";
				Main.buffName[73] = "Arme Imbue: Venom";
				Main.buffTip[73] = "Les attaques de mêlée infligent des ennemis avec des flammes maudits";
				Main.buffName[74] = "Arme Imbue: Fire";
				Main.buffTip[74] = "Les attaques de mêlée des ennemis mis le feu";
				Main.buffName[75] = "Arme Imbue: Gold";
				Main.buffTip[75] = "Les attaques de mêlée rendent ennemis laissent tomber plus d'or";
				Main.buffName[76] = "Arme Imbue: Ichor";
				Main.buffTip[76] = "Les attaques de mêlée réduire la défense des ennemis";
				Main.buffName[77] = "Arme Imbue: Nanites";
				Main.buffTip[77] = "Les attaques de mêlée confondent ennemis";
				Main.buffName[78] = "Arme Imbue: Confetti";
				Main.buffTip[78] = "Les attaques de mêlée causent des confettis à comparaître";
				Main.buffName[79] = "Arme Imbue: Poison";
				Main.buffTip[79] = "Attaques de mêlée des ennemis de poison";
				Lang.prefix[1] = "Grand";
				Lang.prefix[2] = "Massif";
				Lang.prefix[3] = "Dangereuses";
				Lang.prefix[4] = "Sauvages";
				Lang.prefix[5] = "Coupante";
				Lang.prefix[6] = "Pointues";
				Lang.prefix[7] = "Minuscules";
				Lang.prefix[8] = "Terrible";
				Lang.prefix[9] = "Petit";
				Lang.prefix[10] = "Terne";
				Lang.prefix[11] = "Malheureux";
				Lang.prefix[12] = "Volumineux";
				Lang.prefix[13] = "Honteux";
				Lang.prefix[14] = "Lourds";
				Lang.prefix[15] = "Léger";
				Lang.prefix[16] = "Voyants";
				Lang.prefix[17] = "Rapide";
				Lang.prefix[18] = "Hâtif";
				Lang.prefix[19] = "Intimidant";
				Lang.prefix[20] = "Mortelle";
				Lang.prefix[21] = "Dévoué";
				Lang.prefix[22] = "Affreux";
				Lang.prefix[23] = "Léthargique";
				Lang.prefix[24] = "Scomodo";
				Lang.prefix[25] = "Puissante";
				Lang.prefix[26] = "Mystique";
				Lang.prefix[27] = "Expert";
				Lang.prefix[28] = "Magistrale";
				Lang.prefix[29] = "Inepte";
				Lang.prefix[30] = "Ignorants";
				Lang.prefix[31] = "Dérangé";
				Lang.prefix[32] = "Intenses";
				Lang.prefix[33] = "Tabou";
				Lang.prefix[34] = "Célestes";
				Lang.prefix[35] = "Furieux";
				Lang.prefix[36] = "Vif";
				Lang.prefix[37] = "Supérieure";
				Lang.prefix[38] = "Énergique";
				Lang.prefix[39] = "Rompu";
				Lang.prefix[40] = "Endommagés";
				Lang.prefix[41] = "Mesquin";
				Lang.prefix[42] = "Prompt";
				Lang.prefix[43] = "Mortelle";
				Lang.prefix[44] = "Agile";
				Lang.prefix[45] = "Leste";
				Lang.prefix[46] = "Meurtrier";
				Lang.prefix[47] = "Lente";
				Lang.prefix[48] = "Paresseux";
				Lang.prefix[49] = "Fainéant";
				Lang.prefix[50] = "Ennuyeux";
				Lang.prefix[51] = "Méchant";
				Lang.prefix[52] = "Maniaco";
				Lang.prefix[53] = "Blessant";
				Lang.prefix[54] = "Robuste";
				Lang.prefix[55] = "Désagréables";
				Lang.prefix[56] = "Faibles";
				Lang.prefix[57] = "Impitoyable";
				Lang.prefix[58] = "Frénétique";
				Lang.prefix[59] = "Pieux";
				Lang.prefix[60] = "Démoniaque";
				Lang.prefix[61] = "Zélé";
				Lang.prefix[62] = "Durs";
				Lang.prefix[63] = "Protecteur";
				Lang.prefix[64] = "Blindés";
				Lang.prefix[65] = "Défensif";
				Lang.prefix[66] = "Ésotérique";
				Lang.prefix[67] = "Précise";
				Lang.prefix[68] = "Chanceux";
				Lang.prefix[69] = "Déchiqueté";
				Lang.prefix[70] = "Pointes";
				Lang.prefix[71] = "Fâché";
				Lang.prefix[72] = "Menaçant";
				Lang.prefix[73] = "Brusque";
				Lang.prefix[74] = "Fugace";
				Lang.prefix[75] = "Hâtif";
				Lang.prefix[76] = "Prompt";
				Lang.prefix[77] = "Sauvages";
				Lang.prefix[78] = "Téméraire";
				Lang.prefix[79] = "Intrépide";
				Lang.prefix[80] = "Violent";
				Lang.prefix[81] = "Légendaire";
				Lang.prefix[82] = "Irréel";
				Lang.prefix[83] = "Mythique";
			}
			else if (Lang.lang == 5)
			{
				Lang.misc[0] = "¡El ejército de duendes ha sido derrotado!";
				Lang.misc[1] = "¡Un ejército de duendes se aproxima por el oeste!";
				Lang.misc[2] = "¡Un ejército de duendes se aproxima por el este!";
				Lang.misc[3] = "Un ejército goblin ha llegado!";
				Lang.misc[4] = "La Legión Frost ha sido derrotado!";
				Lang.misc[5] = "La Legión de Frost se aproxima desde el oeste!";
				Lang.misc[6] = "La Legión de Frost se acercaba desde el este!";
				Lang.misc[7] = "La Legión Frost ha llegado!";
				Lang.misc[8] = "La luna sangrienta está saliendo...";
				Lang.misc[9] = "Sientes que una presencia maligna te observa...";
				Lang.misc[10] = "Sientes un horrible escalofrío por la espalda...";
				Lang.misc[11] = "El eco de los alaridos suena por todas partes...";
				Lang.misc[12] = "¡Tu mundo ha sido bendecido con Cobalto!";
				Lang.misc[13] = "¡Tu mundo ha sido bendecido con Mithril!";
				Lang.misc[14] = "¡Tu mundo ha sido bendecido con Adamantita!";
				Lang.misc[15] = "Los ancestrales espíritus de la luz y la oscuridad han sido liberados.";
				Lang.misc[16] = "ha despertado!";
				Lang.misc[17] = "ha sido derrotado!";
				Lang.misc[18] = "de duendes!";
				Lang.misc[19] = " fue asesinado...";
				Lang.misc[20] = "Un eclipse solar ocurre!";
				Lang.misc[21] = "Su mundo ha sido bendecido con el Palladium!";
				Lang.misc[22] = "Su mundo ha sido bendecido con Orichalcum!";
				Lang.misc[23] = "Su mundo ha sido bendecido con Titanium!";
				Lang.misc[24] = "Los piratas han sido derrotados!";
				Lang.misc[25] = "Piratas se están acercando desde el oeste!";
				Lang.misc[26] = "Piratas se acercan desde el este!";
				Lang.misc[27] = "Los piratas han llegado!";
				Lang.misc[28] = "Sientes las vibraciones de las profundidades de ...";
				Lang.misc[29] = "Esto va a ser una noche terrible ...";
				Lang.misc[30] = "El aire es más frío a su alrededor ...";
				Lang.menu[0] = "¡Comienza y únete a un nuevo periodo de Terraria!";
				Lang.menu[1] = "Ejecutándose en el puerto ";
				Lang.menu[2] = "Desconectar";
				Lang.menu[3] = "Contraseña del servidor obligatoria:";
				Lang.menu[4] = "Aceptar";
				Lang.menu[5] = "Atrás";
				Lang.menu[6] = "Cancelar";
				Lang.menu[7] = "Escribir contraseña del servidor:";
				Lang.menu[8] = "Iniciando servidor...";
				Lang.menu[9] = "¡Error al cargar!";
				Lang.menu[10] = "Cargar copia de seguridad";
				Lang.menu[11] = "No hay copia de seguridad";
				Lang.menu[12] = "Un jugador";
				Lang.menu[13] = "Multijugador";
				Lang.menu[14] = "Ajustes";
				Lang.menu[15] = "Salir";
				Lang.menu[16] = "Crear personaje";
				Lang.menu[17] = "Eliminar";
				Lang.menu[18] = "Pelo";
				Lang.menu[19] = "Ojos";
				Lang.menu[20] = "Piel";
				Lang.menu[21] = "Ropa";
				Lang.menu[22] = "Hombre";
				Lang.menu[23] = "Mujer";
				Lang.menu[24] = "Fanático";
				Lang.menu[25] = "Normal";
				Lang.menu[26] = "Novato";
				Lang.menu[27] = "Aleatorio";
				Lang.menu[28] = "Crear";
				Lang.menu[29] = "Los personajes fanáticos mueren para siempre.";
				Lang.menu[30] = "Los personajes normales sueltan objetos al morir";
				Lang.menu[31] = "Los personajes novatos sueltan dinero al morir";
				Lang.menu[32] = "Seleccionar dificultad";
				Lang.menu[33] = "Camisa";
				Lang.menu[34] = "Camiseta";
				Lang.menu[35] = "Pantalones";
				Lang.menu[36] = "Zapatos";
				Lang.menu[37] = "Pelo";
				Lang.menu[38] = "Color de pelo";
				Lang.menu[39] = "Color de ojos";
				Lang.menu[40] = "Color de piel";
				Lang.menu[41] = "Color de la camisa";
				Lang.menu[42] = "Color de la camiseta";
				Lang.menu[43] = "Color de los pantalones";
				Lang.menu[44] = "Color de los zapatos";
				Lang.menu[45] = "Escribir nombre del personaje:";
				Lang.menu[46] = "Eliminar";
				Lang.menu[47] = "Crear mundo";
				Lang.menu[48] = "Escribir nombre del mundo:";
				Lang.menu[49] = "Ir a Pantalla con ventanas";
				Lang.menu[50] = "Ir a Pantalla completa";
				Lang.menu[51] = "Resolución";
				Lang.menu[52] = "Paralaje";
				Lang.menu[53] = "Saltar fotograma desactivado (no recomendado)";
				Lang.menu[54] = "Saltar fotograma activado (recomendado)";
				Lang.menu[55] = "Iluminación: Color";
				Lang.menu[56] = "Iluminación: Blanco";
				Lang.menu[57] = "Iluminación: Retro";
				Lang.menu[58] = "Iluminación: Psicodélica";
				Lang.menu[59] = "Calidad: Automático";
				Lang.menu[60] = "Calidad: Alta";
				Lang.menu[61] = "Calidad: Normal";
				Lang.menu[62] = "Calidad: Baja";
				Lang.menu[63] = "Vídeo";
				Lang.menu[64] = "Color del cursor";
				Lang.menu[65] = "Volumen";
				Lang.menu[66] = "Controles";
				Lang.menu[67] = "Autoguardado activado";
				Lang.menu[68] = "Autoguardado desactivado";
				Lang.menu[69] = "Pausa automática activada";
				Lang.menu[70] = "Pausa automática desactivada";
				Lang.menu[71] = "Sugerencias activadas";
				Lang.menu[72] = "Sugerencias desactivadas";
				Lang.menu[73] = "Resolución de pantalla completa";
				Lang.menu[74] = "Arriba                 ";
				Lang.menu[75] = "Abajo                  ";
				Lang.menu[76] = "Izquierda              ";
				Lang.menu[77] = "Derecha                ";
				Lang.menu[78] = "Saltar                  ";
				Lang.menu[79] = "Lanzar                 ";
				Lang.menu[80] = "Inventario              ";
				Lang.menu[81] = "Curación rápida       ";
				Lang.menu[82] = "Maná rápido           ";
				Lang.menu[83] = "Extra rápido           ";
				Lang.menu[84] = "Apresar                 ";
				Lang.menu[85] = "Selección automática  ";
				Lang.menu[86] = "Volver a predeterminados";
				Lang.menu[87] = "Unirse";
				Lang.menu[88] = "Crear y Jugar";
				Lang.menu[89] = "Escribir dirección IP del servidor:";
				Lang.menu[90] = "Escribir puerto del servidor:";
				Lang.menu[91] = "Elegir tamaño del mundo:";
				Lang.menu[92] = "Pequeño";
				Lang.menu[93] = "Mediano";
				Lang.menu[94] = "Grande";
				Lang.menu[95] = "Rojo:";
				Lang.menu[96] = "Verde:";
				Lang.menu[97] = "Azul:";
				Lang.menu[98] = "Sonido:";
				Lang.menu[99] = "Música:";
				Lang.menu[100] = "Fondo activado";
				Lang.menu[101] = "Fondo desactivado";
				Lang.menu[102] = "Seleccione el idioma";
				Lang.menu[103] = "Idioma";
				Lang.menu[104] = "Sí";
				Lang.menu[105] = "No";
				Lang.menu[106] = "Cambiar estilo del mapa";
				Lang.menu[107] = "Alternar pantalla completa";
				Lang.menu[108] = "Acercar";
				Lang.menu[109] = "Alejar";
				Lang.menu[110] = "Disminuir Transparencia";
				Lang.menu[111] = "Aumentar la Transparencia";
				Lang.menu[112] = "Mapa Activado";
				Lang.menu[113] = "Mapa Desactivado";
				Lang.gen[0] = "Generando terreno del mundo:";
				Lang.gen[1] = "Añadiendo arena...";
				Lang.gen[2] = "Generando colinas...";
				Lang.gen[3] = "Amontonando tierra:";
				Lang.gen[4] = "Añadiendo rocas a la tierra...";
				Lang.gen[5] = "Añadiendo tierra a las rocas...";
				Lang.gen[6] = "Añadiendo arcilla...";
				Lang.gen[7] = "Generando agujeros aleatorios:";
				Lang.gen[8] = "Generando cuevas pequeñas:";
				Lang.gen[9] = "Generando cuevas grandes:";
				Lang.gen[10] = "Generando superficie de cuevas...";
				Lang.gen[11] = "Generando selva:";
				Lang.gen[12] = "Generando islas flotantes...";
				Lang.gen[13] = "Añadiendo parcelas de champiñones...";
				Lang.gen[14] = "Añadiendo lodo a la tierra...";
				Lang.gen[15] = "Añadiendo cieno...";
				Lang.gen[16] = "Añadiendo brillos...";
				Lang.gen[17] = "Añadiendo telas de araña...";
				Lang.gen[18] = "Creando Inframundo:";
				Lang.gen[19] = "Añadiendo cursos de agua:";
				Lang.gen[20] = "Corrompiendo el mundo:";
				Lang.gen[21] = "Generando cuevas en montañas...";
				Lang.gen[22] = "Creando playas...";
				Lang.gen[23] = "Añadiendo gemas...";
				Lang.gen[24] = "Gravitando arena:";
				Lang.gen[25] = "Limpiando de tierra los entornos:";
				Lang.gen[26] = "Colocando altares:";
				Lang.gen[27] = "Distribuyendo líquidos:";
				Lang.gen[28] = "Colocando cristales de vida:";
				Lang.gen[29] = "Colocando estatuas:";
				Lang.gen[30] = "Ocultando tesoro:";
				Lang.gen[31] = "Ocultando otro tesoro:";
				Lang.gen[32] = "Ocultando tesoro en la selva:";
				Lang.gen[33] = "Ocultando tesoro en el agua:";
				Lang.gen[34] = "Colocando trampas:";
				Lang.gen[35] = "Colocando objetos quebradizos:";
				Lang.gen[36] = "Colocando forjas infernales:";
				Lang.gen[37] = "Plantando césped...";
				Lang.gen[38] = "Plantando cactus...";
				Lang.gen[39] = "Plantando girasoles...";
				Lang.gen[40] = "Plantando árboles...";
				Lang.gen[41] = "Plantando hierbas...";
				Lang.gen[42] = "Plantando hierbajos...";
				Lang.gen[43] = "Plantando enredaderas...";
				Lang.gen[44] = "Plantando flores...";
				Lang.gen[45] = "Cultivando champiñones...";
				Lang.gen[46] = "Liberando recursos sin usar:";
				Lang.gen[47] = "Reiniciando objetos del juego:";
				Lang.gen[48] = "Estableciendo modo difícil...";
				Lang.gen[49] = "Guardando datos del mundo:";
				Lang.gen[50] = "Copia de seguridad del archivo del mundo...";
				Lang.gen[51] = "Cargando datos del mundo:";
				Lang.gen[52] = "Comprobando alineación en cascada:";
				Lang.gen[53] = "¡Error al cargar!";
				Lang.gen[54] = "No hay copia de seguridad.";
				Lang.gen[55] = "Encontrando estructura en cascada:";
				Lang.gen[56] = "Adición de nieve ...";
				Lang.gen[57] = "Mundo";
				Lang.gen[58] = "La creación de mazmorra:";
				Lang.gen[59] = "Un meteorito ha caído!";
				Lang.gen[60] = "Suavizar el mundo:";
				Lang.gen[61] = "Mossification:";
				Lang.gen[62] = "Gemification:";
				Lang.gen[63] = "Haciendo paredes de la cueva:";
				Lang.gen[64] = "Crecimiento cuevas araña:";
				Lang.gen[65] = "Eliminación de los datos del mapa:";
				Lang.gen[66] = "Guardar los datos del mapa:";
				Lang.gen[67] = "Carga de datos de los mapas:";
				Lang.gen[68] = "Dibujo mapa:";
				Lang.gen[69] = "La creación de cascadas:";
				Lang.gen[70] = "Crear ruinas de la selva ...";
				Lang.gen[71] = "La creación de nidos de avispa ...";
				Lang.gen[72] = "Haciendo un mundo más sangrienta:";
				Lang.inter[0] = "Vida:";
				Lang.inter[1] = "Aire";
				Lang.inter[2] = "Maná";
				Lang.inter[3] = "Cubo de basura";
				Lang.inter[4] = "Inventario";
				Lang.inter[5] = "Barra de acceso rápido desbloqueada";
				Lang.inter[6] = "Barra de acceso rápido bloqueada";
				Lang.inter[7] = "Vivienda";
				Lang.inter[8] = "Búsqueda de vivienda";
				Lang.inter[9] = "Accesorios";
				Lang.inter[10] = "Defensa";
				Lang.inter[11] = "Social";
				Lang.inter[12] = "Casco";
				Lang.inter[13] = "Camisa";
				Lang.inter[14] = "Pantalones";
				Lang.inter[15] = "platino";
				Lang.inter[16] = "oro";
				Lang.inter[17] = "plata";
				Lang.inter[18] = "cobre";
				Lang.inter[19] = "Remodelar";
				Lang.inter[20] = "Colocar un objeto aquí para remodelarlo";
				Lang.inter[21] = "Mostrando recetas en uso";
				Lang.inter[22] = "Objetos necesarios:";
				Lang.inter[23] = "Ninguno";
				Lang.inter[24] = "Colocar un material aquí para ver las recetas";
				Lang.inter[25] = "Producción";
				Lang.inter[26] = "Monedas";
				Lang.inter[27] = "Munición";
				Lang.inter[28] = "Tienda";
				Lang.inter[29] = "Saquear todo";
				Lang.inter[30] = "Ahorrar todo";
				Lang.inter[31] = "Apilar rápido";
				Lang.inter[32] = "Hucha";
				Lang.inter[33] = "Caja fuerte";
				Lang.inter[34] = "Hora:";
				Lang.inter[35] = "Guarda y Salir";
				Lang.inter[36] = "Desconectar";
				Lang.inter[37] = "Objetos";
				Lang.inter[38] = "Te han asesinado...";
				Lang.inter[39] = "Esta vivienda es habitable.";
				Lang.inter[40] = "Esta vivienda no es habitable.";
				Lang.inter[41] = "Esta vivienda ya está ocupada.";
				Lang.inter[42] = "Esta vivienda está corrompida.";
				Lang.inter[43] = "Ha finalizado el tiempo de conexión";
				Lang.inter[44] = "Recibiendo datos en cascada";
				Lang.inter[45] = "Equipar";
				Lang.inter[46] = "Costo";
				Lang.inter[47] = "Ahorrar";
				Lang.inter[48] = "Editar";
				Lang.inter[49] = "Estado";
				Lang.inter[50] = "Maldición";
				Lang.inter[51] = "Ayuda";
				Lang.inter[52] = "Cerca";
				Lang.inter[53] = "De agua";
				Lang.inter[54] = "Sanar";
				Lang.inter[55] = "Esta vivienda no cumple con los requisitos para un";
				Lang.inter[56] = "Lava";
				Lang.inter[57] = "teñir";
				Lang.inter[58] = "miel";
				Lang.inter[61] = "Rebautizar";
				Lang.inter[62] = "Configuraciones";
				Lang.inter[63] = "Cancelar";
				Lang.tip[0] = "Equipado en espacio social";
				Lang.tip[1] = "No se registrará ninguna estadística";
				Lang.tip[2] = " daño en el cuerpo a cuerpo";
				Lang.tip[3] = " daño a distancia";
				Lang.tip[4] = " daño por magia";
				Lang.tip[5] = "% probabilidad de ataque crítico";
				Lang.tip[6] = "Velocidad de vértigo";
				Lang.tip[7] = "A gran velocidad";
				Lang.tip[8] = "Deprisa";
				Lang.tip[9] = "Velocidad normal";
				Lang.tip[10] = "Despacio";
				Lang.tip[11] = "Muy despacio";
				Lang.tip[12] = "Exageradamente despacio";
				Lang.tip[13] = "Velocidad de tortuga";
				Lang.tip[14] = "Sin retroceso";
				Lang.tip[15] = "Retroceso sumamente débil";
				Lang.tip[16] = "Retroceso muy débil";
				Lang.tip[17] = "Retroceso débil";
				Lang.tip[18] = "Retroceso normal";
				Lang.tip[19] = "Retroceso fuerte";
				Lang.tip[20] = "Retroceso muy fuerte";
				Lang.tip[21] = "Retroceso tremendamente fuerte";
				Lang.tip[22] = "Retroceso descomunal";
				Lang.tip[23] = "Utilizable";
				Lang.tip[24] = "Objeto de apariencia";
				Lang.tip[25] = " defensa";
				Lang.tip[26] = "% potencia de pico";
				Lang.tip[27] = "% potencia de hacha";
				Lang.tip[28] = "% potencia de martillo";
				Lang.tip[29] = "Recupera";
				Lang.tip[30] = "vida";
				Lang.tip[31] = "maná";
				Lang.tip[32] = "Consume";
				Lang.tip[33] = "Se puede colocar";
				Lang.tip[34] = "Munición";
				Lang.tip[35] = "Consumible";
				Lang.tip[36] = "Material";
				Lang.tip[37] = " minuto/s de duración";
				Lang.tip[38] = " segundo/s de duración";
				Lang.tip[39] = "% daño";
				Lang.tip[40] = "% velocidad";
				Lang.tip[41] = "% probabilidad de ataque crítico";
				Lang.tip[42] = "% coste de maná";
				Lang.tip[43] = "% tamaño";
				Lang.tip[44] = "% velocidad de proyectil";
				Lang.tip[45] = "% retroceso";
				Lang.tip[46] = "% velocidad de movimiento";
				Lang.tip[47] = "% velocidad en el cuerpo a cuerpo";
				Lang.tip[48] = "Set completo:";
				Lang.tip[49] = "Precio de venta:";
				Lang.tip[50] = "Precio de compra:";
				Lang.tip[51] = "Sin valor";
				Lang.tip[52] = "consume ";
				Lang.tip[53] = " convocar a los daños";
				Lang.tip[54] = " alcance";
				Lang.tip[55] = " daño";
				Lang.mp[0] = "Recibe:";
				Lang.mp[1] = "Contraseña incorrecta.";
				Lang.mp[2] = "Operación no válida en este estado.";
				Lang.mp[3] = "Se te ha prohibido la entrada a este servidor.";
				Lang.mp[4] = "No tienes la misma versión que este servidor.";
				Lang.mp[5] = "ya está en este servidor.";
				Lang.mp[6] = "/jugando";
				Lang.mp[7] = "Jugadores ahora:";
				Lang.mp[8] = "/tira";
				Lang.mp[9] = "tira de";
				Lang.mp[10] = "¡No estás en ningún bando!";
				Lang.mp[11] = "ha activado 1c1!";
				Lang.mp[12] = "ha desactivado 1c1!";
				Lang.mp[13] = "ya no pertenece a ningún bando.";
				Lang.mp[14] = "se ha unido al bando rojo.";
				Lang.mp[15] = "se ha unido al bando verde.";
				Lang.mp[16] = "se ha unido al bando azul.";
				Lang.mp[17] = "se ha unido al bando amarillo.";
				Lang.mp[18] = "¡Bienvenido a";
				Lang.mp[19] = "se ha unido.";
				Lang.mp[20] = "ha dejado de.";
				Lang.the = "el ";
				Lang.dt[0] = "no logró encontrar el antídoto";
				Lang.dt[1] = "no pudo extinguir el fuego";
				Main.buffName[1] = "Piel obsidiana";
				Main.buffTip[1] = "Inmune a la lava";
				Main.buffName[2] = "Regeneración";
				Main.buffTip[2] = "Regenera la vida";
				Main.buffName[3] = "Rapidez";
				Main.buffTip[3] = "Aumenta en un 25% la velocidad de movimiento";
				Main.buffName[4] = "Agallas";
				Main.buffTip[4] = "Permite respirar agua en lugar de aire";
				Main.buffName[5] = "Piel de hierro";
				Main.buffTip[5] = "Aumenta la defensa en 8";
				Main.buffName[6] = "Regeneración de maná";
				Main.buffTip[6] = "Aumenta la regeneración de maná";
				Main.buffName[7] = "Poder mágico";
				Main.buffTip[7] = "Aumenta el daño mágico en un 20%";
				Main.buffName[8] = "Caída de pluma";
				Main.buffTip[8] = "Pulsa ARRIBA o ABAJO para controlar la velocidad de descenso";
				Main.buffName[9] = "Espeleólogo";
				Main.buffTip[9] = "Muestra la ubicación de tesoros y minerales";
				Main.buffName[10] = "Invisibilidad";
				Main.buffTip[10] = "Proporciona invisibilidad";
				Main.buffName[11] = "Brillo";
				Main.buffTip[11] = "Emite luz";
				Main.buffName[12] = "Noctámbulo";
				Main.buffTip[12] = "Aumenta la visión nocturna";
				Main.buffName[13] = "Batalla";
				Main.buffTip[13] = "Aumenta el porcentaje de regeneración del enemigo";
				Main.buffName[14] = "Espinas";
				Main.buffTip[14] = "Los atacantes también sufren daños";
				Main.buffName[15] = "Caminando sobre el agua";
				Main.buffTip[15] = "Pulsa ABAJO para sumergirte";
				Main.buffName[16] = "Tiro con arco";
				Main.buffTip[16] = "Aumenta en un 20% la velocidad y el daño de las flechas";
				Main.buffName[17] = "Cazador";
				Main.buffTip[17] = "Muestra la ubicación de los enemigos";
				Main.buffName[18] = "Gravedad";
				Main.buffTip[18] = "Pulsa ARRIBA o ABAJO para invertir la gravedad";
				Main.buffName[19] = "Orbe de Luz";
				Main.buffTip[19] = "Orbe mágico que proporciona luz";
				Main.buffName[20] = "Veneno";
				Main.buffTip[20] = "Pérdida de vida lentamente";
				Main.buffName[21] = "Poción de náuseas";
				Main.buffTip[21] = "Deja de consumir remedios curativos";
				Main.buffName[22] = "Oscuridad";
				Main.buffTip[22] = "Disminuye la claridad";
				Main.buffName[23] = "Maldición";
				Main.buffTip[23] = "No se puede usar ningún objeto";
				Main.buffName[24] = "Llamas";
				Main.buffTip[24] = "Pérdida de vida lentamente";
				Main.buffName[25] = "Beodo";
				Main.buffTip[25] = "Mejora el cuerpo a cuerpo pero ralentiza la defensa";
				Main.buffName[26] = "Bien alimentado";
				Main.buffTip[26] = "Pequeñas mejoras de todas las estadísticas";
				Main.buffName[27] = "Hada";
				Main.buffTip[27] = "Un hada te acompaña";
				Main.buffName[28] = "Hombre lobo";
				Main.buffTip[28] = "Aumenta la capacidad física";
				Main.buffName[29] = "Clarividencia";
				Main.buffTip[29] = "Aumenta los poderes mágicos";
				Main.buffName[30] = "Ensangrentado";
				Main.buffTip[30] = "No se puede recuperar vida";
				Main.buffName[31] = "Confundido";
				Main.buffTip[31] = "Se invierte el movimiento";
				Main.buffName[32] = "Lento";
				Main.buffTip[32] = "Disminuye la velocidad de movimiento";
				Main.buffName[33] = "Débil";
				Main.buffTip[33] = "Disminuye la capacidad física";
				Main.buffName[34] = "Tritón";
				Main.buffTip[34] = "Respira y se mueve bajo el agua con facilidad";
				Main.buffName[35] = "Silenciado";
				Main.buffTip[35] = "No puede utilizar los artículos que requieren maná";
				Main.buffName[36] = "Armadura rota";
				Main.buffTip[36] = "La defensa disminuye hasta la mitad";
				Main.buffName[37] = "Aterrado";
				Main.buffTip[37] = "Has visto algo horrible, no hay escapatoria";
				Main.buffName[38] = "La Lengua";
				Main.buffTip[38] = "Te succiona";
				Main.buffName[39] = "El Averno";
				Main.buffTip[39] = "Pérdida de la vida";
				Main.buffName[40] = "Mascota conejo";
				Main.buffTip[40] = "Creo que quiere su zanahoria";
				Main.buffName[41] = "pingüino del bebé";
				Main.buffTip[41] = "Creo que quiere que sus peces";
				Main.buffName[42] = "tortuga";
				Main.buffTip[42] = "Tiempo feliz tortuga!";
				Main.buffName[43] = "el escudo de paladin";
				Main.buffTip[43] = "25% de daño recibido será redirigido a otro jugador";
				Main.buffName[44] = "quemadura de Escarcha";
				Main.buffTip[44] = "Es o muy caliente o muy fría. De cualquier manera me duele mucho";
				Main.buffName[45] = "comedor de bebé";
				Main.buffTip[45] = "A Eater bebé de las almas te está siguiendo";
				Main.buffName[46] = "enfriado";
				Main.buffTip[46] = "Su velocidad de movimiento se ha reducido";
				Main.buffName[47] = "Congelado";
				Main.buffTip[47] = "No se puede mover!";
				Main.buffName[48] = "miel";
				Main.buffTip[48] = "La regeneración de la vida se incrementa";
				Main.buffName[49] = "pigmeos";
				Main.buffTip[49] = "Los pigmeos lucharán para usted";
				Main.buffName[50] = "Bebé Skeletron cabeza";
				Main.buffTip[50] = "Ni siquiera preguntar ...";
				Main.buffName[51] = "Bebé Hornet";
				Main.buffTip[51] = "Se cree que eres su madre";
				Main.buffName[52] = "tiki espíritu";
				Main.buffTip[52] = "Un espíritu amistoso que está siguiendo";
				Main.buffName[53] = "lagartija";
				Main.buffTip[53] = "Tiempo libre como un reptil";
				Main.buffName[54] = "loro";
				Main.buffTip[54] = "Polly quiere es el cracker";
				Main.buffName[55] = "Bebé Trufa";
				Main.buffTip[55] = "No es esto apenas soooo cute";
				Main.buffName[56] = "mascota retoño";
				Main.buffTip[56] = "Un arbolito que está siguiendo";
				Main.buffName[57] = "manojito";
				Main.buffTip[57] = "Un mechón te está siguiendo";
				Main.buffName[58] = "La curación rápida";
				Main.buffTip[58] = "La regeneración de la vida es mucho mayor";
				Main.buffName[59] = "Sombra de Dodge";
				Main.buffTip[59] = "Va a esquivar el próximo ataque";
				Main.buffName[60] = "cristal de la hoja";
				Main.buffTip[60] = "Cristal Shoots sale a los enemigos cercanos";
				Main.buffName[61] = "dinosaurio del bebé";
				Main.buffTip[61] = "Un dinosaurio bebé te está siguiendo";
				Main.buffName[62] = "Barrera de hielo";
				Main.buffTip[62] = "Defensa se ​​incrementa en un 30";
				Main.buffName[63] = "pánico";
				Main.buffTip[63] = "La velocidad de movimiento se incrementa";
				Main.buffName[64] = "bebé baba";
				Main.buffTip[64] = "La baba del bebé peleará por vosotros";
				Main.buffName[65] = "Eyeball primavera";
				Main.buffTip[65] = "Un muelle ojo te está siguiendo";
				Main.buffName[66] = "Muñeco de nieve del bebé";
				Main.buffTip[66] = "Un muñeco de nieve del bebé te está siguiendo";
				Main.buffName[67] = "ardor";
				Main.buffTip[67] = "La pérdida de la vida y la lentitud de movimientos";
				Main.buffName[68] = "asfixia";
				Main.buffTip[68] = "La pérdida de la vida";
				Main.buffName[69] = "hondura";
				Main.buffTip[69] = "defensa reducida";
				Main.buffName[70] = "veneno";
				Main.buffTip[70] = "La pérdida de la vida";
				Main.buffName[72] = "Midas";
				Main.buffTip[72] = "Soltar más dinero en la muerte";
				Main.buffName[80] = "apagón";
				Main.buffTip[80] = "La visión de luz muy reducida";
				Main.buffName[71] = "imbuir armas: veneno";
				Main.buffTip[71] = "Ataques cuerpo a cuerpo infligen veneno en sus objetivos";
				Main.buffName[73] = "imbuir armas: Llamas Maldito";
				Main.buffTip[73] = "Ataques cuerpo a cuerpo infligen los enemigos con llamas malditos";
				Main.buffName[74] = "imbuir armas: fuego";
				Main.buffTip[74] = "Ataques cuerpo a cuerpo establecen enemigos en llamas";
				Main.buffName[75] = "imbuir armas: oro";
				Main.buffTip[75] = "Ataques cuerpo a cuerpo hacen enemigos caen más oro";
				Main.buffName[76] = "imbuir armas: hondura";
				Main.buffTip[76] = "Ataques cuerpo a cuerpo disminuyen defensa enemigos";
				Main.buffName[77] = "imbuir armas: Nanites";
				Main.buffTip[77] = "Ataques cuerpo a cuerpo confunde enemigos";
				Main.buffName[78] = "imbuir armas: confeti";
				Main.buffTip[78] = "Ataques cuerpo a cuerpo infligen confetti que aparezca";
				Main.buffName[79] = "imbuir armas: tóxico";
				Main.buffTip[79] = "Cuerpo a cuerpo ataca a los enemigos de veneno";
				Lang.prefix[1] = "Grande";
				Lang.prefix[2] = "Masivo";
				Lang.prefix[3] = "Peligroso";
				Lang.prefix[4] = "Salvaje";
				Lang.prefix[5] = "Puntiagudo";
				Lang.prefix[6] = "Agudo";
				Lang.prefix[7] = "Diminuto";
				Lang.prefix[8] = "Mala ";
				Lang.prefix[9] = "Pequeño";
				Lang.prefix[10] = "Aburrido";
				Lang.prefix[11] = "Infeliz";
				Lang.prefix[12] = "Voluminoso";
				Lang.prefix[13] = "Vergonzoso";
				Lang.prefix[14] = "Pesado";
				Lang.prefix[15] = "Ligero";
				Lang.prefix[16] = "Ámbito";
				Lang.prefix[17] = "Rápido";
				Lang.prefix[18] = "Precipitado";
				Lang.prefix[19] = "Intimidante";
				Lang.prefix[20] = "Mortal";
				Lang.prefix[21] = "Firme";
				Lang.prefix[22] = "Atroz";
				Lang.prefix[23] = "Letárgico";
				Lang.prefix[24] = "Torpe";
				Lang.prefix[25] = "Poderoso";
				Lang.prefix[26] = "Místico";
				Lang.prefix[27] = "Experto";
				Lang.prefix[28] = "Maestro";
				Lang.prefix[29] = "Inepto";
				Lang.prefix[30] = "Ignorante";
				Lang.prefix[31] = "Trastornado";
				Lang.prefix[32] = "Intenso";
				Lang.prefix[33] = "Tabú";
				Lang.prefix[34] = "Celeste";
				Lang.prefix[35] = "Furioso";
				Lang.prefix[36] = "Afilado";
				Lang.prefix[37] = "Superior";
				Lang.prefix[38] = "Fuerte";
				Lang.prefix[39] = "Roto";
				Lang.prefix[40] = "Estropeado";
				Lang.prefix[41] = "Regenerado";
				Lang.prefix[42] = "Pronto";
				Lang.prefix[43] = "Mortal";
				Lang.prefix[44] = "Ágil";
				Lang.prefix[45] = "Listo";
				Lang.prefix[46] = "Asesino";
				Lang.prefix[47] = "Lento";
				Lang.prefix[48] = "Perezoso";
				Lang.prefix[49] = "Gandul";
				Lang.prefix[50] = "Molesto";
				Lang.prefix[51] = "Feo";
				Lang.prefix[52] = "Maníacos";
				Lang.prefix[53] = "Hiriente";
				Lang.prefix[54] = "Vigoroso";
				Lang.prefix[55] = "Desagradable";
				Lang.prefix[56] = "Débil";
				Lang.prefix[57] = "Despiadado";
				Lang.prefix[58] = "Frenético";
				Lang.prefix[59] = "Piadoso";
				Lang.prefix[60] = "Demoníaco";
				Lang.prefix[61] = "Celoso";
				Lang.prefix[62] = "Duro";
				Lang.prefix[63] = "Protector";
				Lang.prefix[64] = "Blindado";
				Lang.prefix[65] = "Defensivo";
				Lang.prefix[66] = "Arcano";
				Lang.prefix[67] = "Preciso";
				Lang.prefix[68] = "Afortunado";
				Lang.prefix[69] = "Dentado";
				Lang.prefix[70] = "Claveteado";
				Lang.prefix[71] = "Enojado";
				Lang.prefix[72] = "Amenazador";
				Lang.prefix[73] = "Enérgico";
				Lang.prefix[74] = "Fugaz";
				Lang.prefix[75] = "Precipitado";
				Lang.prefix[76] = "Pronto";
				Lang.prefix[77] = "Salvaje";
				Lang.prefix[78] = "Temerario";
				Lang.prefix[79] = "Intrépido";
				Lang.prefix[80] = "Violento";
				Lang.prefix[81] = "Legendario";
				Lang.prefix[82] = "Irreal";
				Lang.prefix[83] = "Mítico";
			}
			for (int i = 0; i < 84; i++)
			{
				if (Lang.prefix[i] == null)
				{
					Lang.prefix[i] = string.Empty;
				}
			}
			for (int j = 0; j < (int)Main.recipe.Length; j++)
			{
				if (Main.recipe[j].createItem.name != null && Main.recipe[j].createItem.name != "" && Main.recipe[j].createItem.netID != 0)
				{
					Main.recipe[j].createItem.name = Lang.itemName(Main.recipe[j].createItem.netID, false);
					Main.recipe[j].createItem.CheckTip();
					for (int k = 0; k < (int)Main.recipe[k].requiredItem.Length; k++)
					{
						Main.recipe[j].requiredItem[k].name = Lang.itemName(Main.recipe[j].requiredItem[k].netID, false);
						Main.recipe[j].requiredItem[k].CheckTip();
					}
				}
			}
		}

		public static string title()
		{
			int num = Main.rand.Next(16);
			if (Lang.lang <= 1)
			{
				num = Main.rand.Next(53);
				if (num == 0)
				{
					return "Terraria: Dig Peon, Dig!";
				}
				if (num == 1)
				{
					return "Terraria: Epic Dirt";
				}
				if (num == 2)
				{
					return "Terraria: Adaman-TIGHT!";
				}
				if (num == 3)
				{
					return "Terraria: Sand is Overpowered";
				}
				if (num == 4)
				{
					return "Terraria Part 3: The Return of the Guide";
				}
				if (num == 5)
				{
					return "Terraria: A Bunnies Tale";
				}
				if (num == 6)
				{
					return "Terraria: Dr. Bones and The Temple of Blood Moon";
				}
				if (num == 7)
				{
					return "Terraria: Slimeassic Park";
				}
				if (num == 8)
				{
					return "Terraria: The Grass is Greener on This Side";
				}
				if (num == 9)
				{
					return "Terraria: Small Blocks, Not for Children Under the Age of 5";
				}
				if (num == 10)
				{
					return "Terraria: Digger T' Blocks";
				}
				if (num == 11)
				{
					return "Terraria: There is No Cow Layer";
				}
				if (num == 12)
				{
					return "Terraria: Suspicous Looking Eyeballs";
				}
				if (num == 13)
				{
					return "Terraria: Purple Grass!";
				}
				if (num == 14)
				{
					return "Terraria: No one Dug Behind!";
				}
				if (num == 15)
				{
					return "Terraria: The Water Fall Of Content!";
				}
				if (num == 16)
				{
					return "Terraria: Earthbound";
				}
				if (num == 17)
				{
					return "Terraria: Dig Dug Ain't Got Nuthin on Me";
				}
				if (num == 18)
				{
					return "Terraria: Ore's Well That Ends Well";
				}
				if (num == 19)
				{
					return "Terraria: Judgement Clay";
				}
				if (num == 20)
				{
					return "Terraria: Terrestrial Trouble";
				}
				if (num == 21)
				{
					return "Terraria: Obsessive-Compulsive Discovery Simulator";
				}
				if (num == 22)
				{
					return "Terraria: Red Dev Redemption";
				}
				if (num == 23)
				{
					return "Terraria: Rise of the Slimes";
				}
				if (num == 24)
				{
					return "Terraria: Now with more things to kill you!";
				}
				if (num == 25)
				{
					return "Terraria: Rumors of the Guides' death were greatly exaggerated";
				}
				if (num == 26)
				{
					return "Terraria: I Pity the Tools...";
				}
				if (num == 27)
				{
					return "Terraria: A spelunker says 'What'?";
				}
				if (num == 28)
				{
					return "Terraria: So then I said 'Something about a PC update....'";
				}
				if (num == 29)
				{
					return "Terraria: May the blocks be with you";
				}
				if (num == 30)
				{
					return "Terraria: Better than life";
				}
				if (num == 31)
				{
					return "Terraria: Terraria: Terraria:";
				}
				if (num == 32)
				{
					return "Terraria: Now in 1D";
				}
				if (num == 33)
				{
					return "Terraria: Coming soon to a computer near you";
				}
				if (num == 34)
				{
					return "Terraria: Dividing by zero";
				}
				if (num == 35)
				{
					return "Terraria: Now with SOUND";
				}
				if (num == 36)
				{
					return "Terraria: Press alt-f4";
				}
				if (num == 37)
				{
					return "Terraria: I Pity the Tools";
				}
				if (num == 38)
				{
					return "Terraria: You sand bro?";
				}
				if (num == 39)
				{
					return "Terraria: A good day to dig hard";
				}
				if (num == 40)
				{
					return "Terraria: Can You Re-Dig-It?";
				}
				if (num == 41)
				{
					return "Terraria: I don't know that-- aaaaa!";
				}
				if (num == 42)
				{
					return "Terraria: What's that purple spiked thing?";
				}
				if (num == 43)
				{
					return "Terraria: I wanna be the guide";
				}
				if (num == 44)
				{
					return "Terraria: Cthulhu is mad... and is missing an eye!";
				}
				if (num == 45)
				{
					return "Terraria: NOT THE BEES!!!";
				}
				if (num == 46)
				{
					return "Terraria: Legend of Maxx";
				}
				if (num == 47)
				{
					return "Terraria: Cult of Cenx";
				}
				if (num == 48)
				{
					return "Terraria 2: Electric Boogaloo";
				}
				if (num == 49)
				{
					return "Terraria: Also try Minecraft!";
				}
				if (num == 50)
				{
					return "Terraria: Also try Edge of Space!";
				}
				if (num == 51)
				{
					return "Terraria: I just wanna know where the gold at?";
				}
				return "Terraria: Shut Up and Dig Gaiden!";
			}
			if (Lang.lang == 2)
			{
				if (num == 0)
				{
					return "Terraria: Nun grab schon, Bauer, grab!";
				}
				if (num == 1)
				{
					return "Terraria: Epischer Dreck";
				}
				if (num == 2)
				{
					return "Terraria: Huhu, Leute!";
				}
				if (num == 3)
				{
					return "Terraria: Sand is overpowered!";
				}
				if (num == 4)
				{
					return "Terraria Teil 3: Die Rueckkehr des Fremdenfuehrers";
				}
				if (num == 5)
				{
					return "Terraria: Geschichte eines verderbten Haeschens";
				}
				if (num == 6)
				{
					return "Terraria: Dr. Bones und der Tempel des Blutmondes";
				}
				if (num == 7)
				{
					return "Terraria: Schleimassic Park";
				}
				if (num == 8)
				{
					return "Terraria: Das Gras ist auf dieser Seite gruener";
				}
				if (num == 9)
				{
					return "Terraria: Kleine Bloecke, nicht fuer Kinder unter 5";
				}
				if (num == 10)
				{
					return "Terraria: Der Block des Ausgraebers";
				}
				if (num == 11)
				{
					return "Terraria: Hier gibt's auch kein Kuh-Level!";
				}
				if (num == 12)
				{
					return "Terraria: Verdaechtig ausschauende Augaepfel";
				}
				if (num == 13)
				{
					return "Terraria: Violettes Gras!";
				}
				if (num == 14)
				{
					return "Terraria: Houston, wir haben ein Problem gehabt!";
				}
				return "Terraria: Grab mit deiner Hand, nicht mit dem Mund!";
			}
			if (Lang.lang == 3)
			{
				if (num == 0)
				{
					return "Terraria: Scava contadino, scava!";
				}
				if (num == 1)
				{
					return "Terraria: Terra epica";
				}
				if (num == 2)
				{
					return "Terraria: Ehi, ragazzi!";
				}
				if (num == 3)
				{
					return "Terraria: La sabbia è strapotente";
				}
				if (num == 4)
				{
					return "Terraria: Il ritorno della guida";
				}
				if (num == 5)
				{
					return "Terraria: Coda di coniglio";
				}
				if (num == 6)
				{
					return "Terraria: Dottor Ossa e il tempio della luna di sangue";
				}
				if (num == 7)
				{
					return "Terraria: Slimeassic Park";
				}
				if (num == 8)
				{
					return "Terraria: L'erba è più verde da questo lato";
				}
				if (num == 9)
				{
					return "Terraria: Piccoli blocchi, non per bambini al di sotto di 5 anni";
				}
				if (num == 10)
				{
					return "Terraria:  Il blocco dello scavatore";
				}
				if (num == 11)
				{
					return "Terraria: No mucche, no party";
				}
				if (num == 12)
				{
					return "Terraria: Bulbi oculari diffidenti";
				}
				if (num == 13)
				{
					return "Terraria: Erba viola!";
				}
				if (num == 14)
				{
					return "Terraria: Houston, abbiamo un problema!";
				}
				return "Terraria: Zitto e scava, 'azzo!";
			}
			if (Lang.lang == 4)
			{
				if (num == 0)
				{
					return "Terraria : Creuse et fais pas cette mine !";
				}
				if (num == 1)
				{
					return "Terraria : Bain de boue";
				}
				if (num == 2)
				{
					return "Terraria : Salut la compagnie !";
				}
				if (num == 3)
				{
					return "Terraria : Le canon à sable, c'est vraiment grosbill";
				}
				if (num == 4)
				{
					return "Terraria, 3e partie : Le retour du guide";
				}
				if (num == 5)
				{
					return "Terraria : Des lapins pas si crétins";
				}
				if (num == 6)
				{
					return "Terraria : Dr Bones et le temple de la lune de sang";
				}
				if (num == 7)
				{
					return "Terraria: Slimeassic Park";
				}
				if (num == 8)
				{
					return "Terraria : L'herbe est plus verte dans le pré du voisin";
				}
				if (num == 9)
				{
					return "Terraria : Petits blocs interdits aux enfants de moins de 5 ans";
				}
				if (num == 10)
				{
					return "Terraria : Des mineurs gonflés à bloc ! ";
				}
				if (num == 11)
				{
					return "Terraria : Strates aux sphères";
				}
				if (num == 12)
				{
					return "Terraria : L'œil observateur suspicieux";
				}
				if (num == 13)
				{
					return "Terraria  : Silence, ça pousse !";
				}
				if (num == 14)
				{
					return "Terraria : Houston, nous avons un problème !";
				}
				return "Terraria : J'fais des trous, des p'tis trous...";
			}
			if (Lang.lang != 5)
			{
				return "";
			}
			if (num == 0)
			{
				return "Terraria: ¡Cava, peón, cava!";
			}
			if (num == 1)
			{
				return "Terraria: Terreno épico";
			}
			if (num == 2)
			{
				return "Terraria: ¡Hola, tíos!";
			}
			if (num == 3)
			{
				return "Terraria: El poder de la arena";
			}
			if (num == 4)
			{
				return "Terraria parte 3: El regreso del Guía";
			}
			if (num == 5)
			{
				return "Terraria: Un cuento de conejitos";
			}
			if (num == 6)
			{
				return "Terraria: El Dr. Látigo y el Templo de la Luna Sangrienta";
			}
			if (num == 7)
			{
				return "Terraria: Babosic Park";
			}
			if (num == 8)
			{
				return "Terraria: Mi césped es más verde que el del vecino";
			}
			if (num == 9)
			{
				return "Terraria: Bloques de construcción (no apto para menores de 5 años)";
			}
			if (num == 10)
			{
				return "Terraria: Buscador de bloques";
			}
			if (num == 11)
			{
				return "Terraria: Nada de niveles ocultos";
			}
			if (num == 12)
			{
				return "Terraria: Ojos de aspecto sospechoso";
			}
			if (num == 13)
			{
				return "Terraria: ¡Césped morado!";
			}
			if (num == 14)
			{
				return "Terraria: ¡No abandonamos ningún agujero!";
			}
			return "Terraria: ¡Cállate y cava un universo paralelo!";
		}

		public static string toolTip(int l, bool english = false)
		{
			if (l == 1372)
			{
				return "'W. Garner'";
			}
			if (l == 1373)
			{
				return "'W. Garner'";
			}
			if (l == 1374)
			{
				return "'W. Garner'";
			}
			if (l == 1375)
			{
				return "'W. Garner'";
			}
			if (l == 1419)
			{
				return "'W. Garner'";
			}
			if (l == 1420)
			{
				return "'W. Garner'";
			}
			if (l == 1421)
			{
				return "'W. Garner'";
			}
			if (l == 1425)
			{
				return "'W. Garner'";
			}
			if (l == 1426)
			{
				return "'W. Garner'";
			}
			if (l == 1427)
			{
				return "'W. Garner'";
			}
			if (l == 1428)
			{
				return "'W. Garner'";
			}
			if (l == 1443)
			{
				return "'W. Garner'";
			}
			if (l == 1501)
			{
				return "'W. Garner'";
			}
			if (l == 1573)
			{
				return "'W. Garner'";
			}
			if (l == 1574)
			{
				return "'W. Garner'";
			}
			if (l == 1575)
			{
				return "'W. Garner'";
			}
			if (l == 1422)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1423)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1435)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1424)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1436)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1437)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1438)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1439)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1440)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1442)
			{
				return "'V. Costa Moura'";
			}
			if (l >= 1481 && l <= 1494)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1846)
			{
				return "'V. Costa Moura'";
			}
			if (l == 2995)
			{
				return "'V. Costa Moura'";
			}
			if (l >= 1476 && l <= 1480)
			{
				return "'J. T. Myhre'";
			}
			if (l >= 1496 && l <= 1499)
			{
				return "'J. T. Myhre'";
			}
			if (l == 1538)
			{
				return "'J. T. Myhre'";
			}
			if (l >= 1539 && l <= 1542)
			{
				return "'A. Craig'";
			}
			if (l == 1433)
			{
				return "'K. Wright'";
			}
			if (l == 1441)
			{
				return "'A. G. Kolf'";
			}
			if (l == 1500)
			{
				return "'A. G. Kolf'";
			}
			if (l == 1495)
			{
				return "'A. G. Kolf'";
			}
			if (l == 1576)
			{
				return "'D. Phelps'";
			}
			if (l == 1577)
			{
				return "'M. J. Duncan'";
			}
			if (l == 1434)
			{
				return "'C. J. Ness'";
			}
			if (l == 1502)
			{
				return "'C. Burczyk'";
			}
			if (l >= 1847 && l <= 1850)
			{
				return "'J. Hayes'";
			}
			if (l >= 2865 && l <= 2867)
			{
				return "'J. Hayes'";
			}
			if (l >= 3055 && l <= 3059)
			{
				return "'J. Hayes'";
			}
			if (l == 2497)
			{
				return "'J. Hayes'";
			}
			if (l == 2995 || l == 3596)
			{
				return "'V. Costa Moura'";
			}
			if (Lang.lang <= 1 || english)
			{
				if (l >= 1874 && l <= 1905)
				{
					return "Placeable on a christmas tree";
				}
				if (l >= 2897 && l <= 2994 || l >= 1615 && l <= 1701 || l >= 3390 && l <= 3452 || l >= 3593 && l <= 3594)
				{
					int nPC = 0;
					if (l >= 2897 && l <= 2994)
					{
						nPC = Item.BannerToNPC(89 + l - 2897 - 1);
					}
					if (l >= 1615 && l <= 1701)
					{
						nPC = Item.BannerToNPC(l - 1614);
					}
					if (l >= 3390 && l <= 3452)
					{
						nPC = Item.BannerToNPC(186 + l - 3390);
					}
					if (l >= 3593 && l <= 3594)
					{
						nPC = Item.BannerToNPC(249 + l - 3593);
					}
					return string.Concat("Nearby players get a bonus against: ", Lang.npcName(nPC, false));
				}
				if (l >= 3293 && l <= 3308)
				{
					return "Increases yoyo range";
				}
				if (l >= 3309 && l <= 3314)
				{
					return "Throws a counterweight after hitting an enemy with a yoyo";
				}
				if (l >= 3318 && l <= 3332)
				{
					return "Right click to open";
				}
				int num = l;
				if (num <= 1450)
				{
					if (num <= 332)
					{
						if (num <= 168)
						{
							if (num <= 43)
							{
								if (num > 23)
								{
									if (num == 29)
									{
										return "Permanently increases maximum life by 20";
									}
									switch (num)
									{
										case 33:
										{
											return "Used for smelting ore";
										}
										case 34:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
										case 35:
										{
											return "Used to craft items from metal bars";
										}
										case 36:
										{
											return "Used for basic crafting";
										}
										default:
										{
											if (num == 43)
											{
												return "Summons the Eye of Cthulhu";
											}
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
								else
								{
									if (num == 8)
									{
										return "Provides light";
									}
									switch (num)
									{
										case 15:
										{
											return "Tells the time";
										}
										case 16:
										{
											return "Tells the time";
										}
										case 17:
										{
											return "Tells the time";
										}
										case 18:
										{
											return "Displays depth";
										}
										case 19:
										case 20:
										case 21:
										case 22:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
										case 23:
										{
											return "'Both tasty and flammable'";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
							else if (num > 75)
							{
								switch (num)
								{
									case 84:
									{
										return "'Get over here!'";
									}
									case 85:
									{
										return "Can be climbed on";
									}
									case 86:
									case 87:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 88:
									{
										return "Provides light when worn";
									}
									default:
									{
										switch (num)
										{
											case 98:
											{
												return "33% chance to not consume ammo";
											}
											case 99:
											case 104:
											case 105:
											case 106:
											case 107:
											case 108:
											case 110:
											case 116:
											case 119:
											case 122:
											case 126:
											case 127:
											{
												if (english || Lang.lang <= 1)
												{
													return "";
												}
												return Lang.toolTip(l, true);
											}
											case 100:
											{
												return "7% increased melee speed";
											}
											case 101:
											{
												return "7% increased melee speed";
											}
											case 102:
											{
												return "7% increased melee speed";
											}
											case 103:
											{
												return "Able to mine Hellstone";
											}
											case 109:
											{
												return "Permanently increases maximum mana by 20";
											}
											case 111:
											{
												return "Increases maximum mana by 20";
											}
											case 112:
											{
												return "Throws balls of fire";
											}
											case 113:
											{
												return "Casts a controllable missile";
											}
											case 114:
											{
												return "Magically moves dirt";
											}
											case 115:
											{
												return "Creates a magical shadow orb";
											}
											case 117:
											{
												return "'Warm to the touch'";
											}
											case 118:
											{
												return "Sometimes dropped by Skeletons and Piranha";
											}
											case 120:
											{
												return "Lights wooden arrows ablaze";
											}
											case 121:
											{
												return "'It's made out of fire!'";
											}
											case 123:
											{
												return "7% increased magic damage";
											}
											case 124:
											{
												return "7% increased magic damage";
											}
											case 125:
											{
												return "7% increased magic damage";
											}
											case 128:
											{
												return "Allows flight";
											}
											default:
											{
												switch (num)
												{
													case 148:
													{
														return "Holding this may attract unwanted attention";
													}
													case 149:
													{
														return "'It contains strange symbols'";
													}
													case 150:
													case 154:
													case 155:
													case 160:
													case 161:
													case 162:
													case 163:
													case 164:
													{
														if (english || Lang.lang <= 1)
														{
															return "";
														}
														return Lang.toolTip(l, true);
													}
													case 151:
													{
														break;
													}
													case 152:
													{
														return "5% increased ranged damage.";
													}
													case 153:
													{
														return "5% increased ranged damage.";
													}
													case 156:
													{
														return "Grants immunity to knockback";
													}
													case 157:
													{
														return "Sprays out a shower of water";
													}
													case 158:
													{
														return "Negates fall damage";
													}
													case 159:
													{
														return "Increases jump height";
													}
													case 165:
													{
														return "Casts a slow moving bolt of water";
													}
													case 166:
													{
														return "A small explosion that will destroy some tiles";
													}
													case 167:
													{
														return "A large explosion that will destroy most tiles";
													}
													case 168:
													{
														return "A small explosion that will not destroy tiles";
													}
													default:
													{
														if (english || Lang.lang <= 1)
														{
															return "";
														}
														return Lang.toolTip(l, true);
													}
												}
												break;
											}
										}
										break;
									}
								}
							}
							else
							{
								switch (num)
								{
									case 49:
									{
										return "Slowly regenerates life";
									}
									case 50:
									{
										return "Gaze in the mirror to return home";
									}
									case 51:
									case 52:
									case 55:
									case 58:
									case 59:
									case 60:
									case 61:
									case 62:
									case 63:
									case 69:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 53:
									{
										return "Allows the holder to double jump";
									}
									case 54:
									{
										return "The wearer can run super fast";
									}
									case 56:
									{
										return "'Pulsing with dark energy'";
									}
									case 57:
									{
										return "'Pulsing with dark energy'";
									}
									case 64:
									{
										return "Summons a vile thorn";
									}
									case 65:
									{
										return "Causes stars to rain from the sky";
									}
									case 66:
									{
										return "Cleanses the evil";
									}
									case 67:
									{
										return "Banishes the Hallow";
									}
									case 68:
									{
										return "'Looks tasty!'";
									}
									case 70:
									{
										return "Summons the Eater of Worlds";
									}
									default:
									{
										if (num == 75)
										{
											return "Disappears after the sunrise";
										}
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
								}
							}
						}
						else if (num <= 230)
						{
							if (num > 190)
							{
								if (num == 193)
								{
									return "Grants immunity to fire blocks";
								}
								if (num == 197)
								{
									return "Shoots fallen stars";
								}
								switch (num)
								{
									case 208:
									{
										return "'It's pretty, oh so pretty'";
									}
									case 209:
									case 210:
									case 214:
									case 216:
									case 217:
									case 219:
									case 220:
									case 221:
									case 224:
									case 225:
									case 226:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 211:
									{
										return "12% increased melee speed";
									}
									case 212:
									{
										return "10% increased movement speed";
									}
									case 213:
									{
										return "Creates grass and moss on dirt and stone";
									}
									case 215:
									{
										return "'May annoy others'";
									}
									case 218:
									{
										return "Summons a controllable ball of fire";
									}
									case 222:
									{
										return "Grows plants";
									}
									case 223:
									{
										return "6% reduced mana usage";
									}
									case 227:
									{
										return "Reduced potion cooldown";
									}
									case 228:
									{
										return "Increases maximum mana by 40";
									}
									case 229:
									{
										return "Increases maximum mana by 20";
									}
									case 230:
									{
										return "Increases maximum mana by 20";
									}
									default:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
								}
							}
							else
							{
								if (num == 175)
								{
									return "'Hot to the touch'";
								}
								switch (num)
								{
									case 186:
									{
										return "Increases breath time and allows breathing in water";
									}
									case 187:
									{
										return "Grants the ability to swim";
									}
									case 188:
									case 189:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 190:
									{
										return "Has a chance to poison enemies";
									}
									default:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
								}
							}
						}
						else if (num > 305)
						{
							if (num == 324)
							{
								return "'Banned in most places'";
							}
							switch (num)
							{
								case 327:
								{
									return "Opens one Gold or Dungeon Chest";
								}
								case 328:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 329:
								{
									return "Opens all Shadow Chests";
								}
								default:
								{
									if (num == 332)
									{
										return "Used for crafting cloth";
									}
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							}
						}
						else
						{
							switch (num)
							{
								case 235:
								{
									return "'Tossing may be difficult.'";
								}
								case 236:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 237:
								{
									return "'Makes you look cool!'";
								}
								case 238:
								{
									return "15% increased magic damage";
								}
								default:
								{
									switch (num)
									{
										case 256:
										{
											return "15% increased throwing velocity";
										}
										case 257:
										{
											return "15% increased throwing damage";
										}
										case 258:
										{
											return "10% increased throwing critical strike chance";
										}
										case 259:
										case 262:
										case 263:
										case 264:
										case 265:
										case 269:
										case 270:
										case 271:
										case 273:
										case 274:
										case 275:
										case 276:
										case 277:
										case 278:
										case 279:
										case 280:
										case 284:
										case 286:
										case 287:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
										case 260:
										{
											return "It smells funny...";
										}
										case 261:
										{
											return "'It's smiling, might be a good snack'";
										}
										case 266:
										{
											return "'This is a good idea!'";
										}
										case 267:
										{
											return "'You are a terrible person.'";
										}
										case 268:
										{
											return "Greatly extends underwater breathing";
										}
										case 272:
										{
											return "Casts a demon scythe";
										}
										case 281:
										{
											return "Allows the collection of seeds for ammo";
										}
										case 282:
										{
											return "Works when wet";
										}
										case 283:
										{
											return "For use with Blowpipe";
										}
										case 285:
										{
											return "5% increased movement speed";
										}
										case 288:
										{
											return "Provides immunity to lava";
										}
										case 289:
										{
											return "Provides life regeneration";
										}
										case 290:
										{
											return "25% increased movement speed";
										}
										case 291:
										{
											return "Breathe water instead of air";
										}
										case 292:
										{
											return "Increase defense by 8";
										}
										case 293:
										{
											return "Increased mana regeneration";
										}
										case 294:
										{
											return "20% increased magic damage";
										}
										case 295:
										{
											return "Slows falling speed";
										}
										case 296:
										{
											return "Shows the location of treasure and ore";
										}
										case 297:
										{
											return "Grants invisibility";
										}
										case 298:
										{
											return "Emits an aura of light";
										}
										case 299:
										{
											return "Increases night vision";
										}
										case 300:
										{
											return "Increases enemy spawn rate";
										}
										case 301:
										{
											return "Attackers also take damage";
										}
										case 302:
										{
											return "Allows the ability to walk on water";
										}
										case 303:
										{
											return "20% increased arrow speed and damage";
										}
										case 304:
										{
											return "Shows the location of enemies";
										}
										case 305:
										{
											return "Allows the control of gravity";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
						}
					}
					else if (num <= 726)
					{
						if (num <= 603)
						{
							if (num > 407)
							{
								switch (num)
								{
									case 422:
									{
										return "Spreads the Hallow to some blocks";
									}
									case 423:
									{
										return "Spreads the corruption to some blocks";
									}
									case 424:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 425:
									{
										return "Summons a magical fairy";
									}
									default:
									{
										if (num == 434)
										{
											return "Three round burst";
										}
										switch (num)
										{
											case 485:
											{
												return "Turns the holder into a werewolf at night";
											}
											case 486:
											{
												return "Creates measurement lines on screen for block placement";
											}
											case 487:
											case 488:
											case 494:
											case 498:
											case 499:
											case 500:
											case 501:
											case 502:
											case 503:
											case 504:
											case 505:
											case 507:
											case 508:
											case 511:
											case 512:
											case 513:
											case 514:
											case 530:
											case 537:
											case 538:
											case 539:
											case 540:
											case 545:
											case 546:
											case 550:
											case 562:
											case 563:
											case 564:
											case 565:
											case 566:
											case 567:
											case 568:
											case 569:
											case 570:
											case 571:
											case 572:
											case 573:
											case 574:
											case 577:
											case 578:
											case 586:
											case 587:
											case 588:
											case 589:
											case 590:
											case 591:
											case 592:
											case 593:
											case 594:
											case 595:
											case 596:
											case 597:
											case 598:
											{
												if (english || Lang.lang <= 1)
												{
													return "";
												}
												return Lang.toolTip(l, true);
											}
											case 489:
											{
												return "15% increased magic damage";
											}
											case 490:
											{
												return "15% increased melee damage";
											}
											case 491:
											{
												return "15% increased ranged damage";
											}
											case 492:
											{
												return "Allows flight and slow fall";
											}
											case 493:
											{
												return "Allows flight and slow fall";
											}
											case 495:
											{
												return "Casts a controllable rainbow";
											}
											case 496:
											{
												return "Summons a block of ice";
											}
											case 497:
											{
												return "Transforms the holder into merfolk when entering water";
											}
											case 506:
											{
												return "Uses gel for ammo";
											}
											case 509:
											{
												return "Places red wire";
											}
											case 510:
											{
												return "Removes wire";
											}
											case 515:
											{
												return "Creates several crystal shards on impact";
											}
											case 516:
											{
												return "Summons falling stars on impact";
											}
											case 517:
											{
												return "A magical returning dagger";
											}
											case 518:
											{
												return "Summons rapid fire crystal shards";
											}
											case 519:
											{
												return "Summons unholy fire balls";
											}
											case 520:
											{
												return "'The essence of light creatures'";
											}
											case 521:
											{
												return "'The essence of dark creatures'";
											}
											case 522:
											{
												return "'Not even water can put the flame out'";
											}
											case 523:
											{
												return "Can be placed in water";
											}
											case 524:
											{
												return "Used to smelt adamantite and titanium ore";
											}
											case 525:
											{
												return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
											}
											case 526:
											{
												return "'Sharp and magical!'";
											}
											case 527:
											{
												return "'Sometimes carried by creatures in corrupt deserts'";
											}
											case 528:
											{
												return "'Sometimes carried by creatures in light deserts'";
											}
											case 529:
											{
												return "Activates when stepped on";
											}
											case 531:
											{
												return "Can be enchanted";
											}
											case 532:
											{
												return "Causes stars to fall when injured";
											}
											case 533:
											{
												return "50% chance to not consume ammo";
											}
											case 534:
											{
												return "Fires a spread of bullets";
											}
											case 535:
											{
												return "Reduces the cooldown of healing potions";
											}
											case 536:
											{
												return "Increases melee knockback";
											}
											case 541:
											{
												return "Activates when stepped on";
											}
											case 542:
											{
												return "Activates when a player steps on it";
											}
											case 543:
											{
												return "Activates when a player steps on it";
											}
											case 544:
											{
												return "Summons The Twins";
											}
											case 547:
											{
												return "'The essence of pure terror'";
											}
											case 548:
											{
												return "'The essence of the destroyer'";
											}
											case 549:
											{
												return "'The essence of omniscient watchers'";
											}
											case 551:
											{
												return "7% increased critical strike chance";
											}
											case 552:
											{
												return "7% increased damage";
											}
											case 553:
											{
												return "15% increased ranged damage";
											}
											case 554:
											{
												return "Increases length of invincibility after taking damage";
											}
											case 555:
											{
												return "8% reduced mana usage";
											}
											case 556:
											{
												return "Summons Destroyer";
											}
											case 557:
											{
												return "Summons Skeletron Prime";
											}
											case 558:
											{
												return "Increases maximum mana by 100";
											}
											case 559:
											{
												return "10% increased melee damage and critical strike chance";
											}
											case 560:
											{
												return "Summons King Slime";
											}
											case 561:
											{
												return "Stacks up to 5";
											}
											case 575:
											{
												return "'The essence of powerful flying creatures'";
											}
											case 576:
											{
												return "Has a chance to record songs";
											}
											case 579:
											{
												return "'Not to be confused with a picksaw'";
											}
											case 580:
											{
												return "Explodes when activated";
											}
											case 581:
											{
												return "Sends water to outlet pumps";
											}
											case 582:
											{
												return "Receives water from inlet pumps";
											}
											case 583:
											{
												return "Activates every second";
											}
											case 584:
											{
												return "Activates every 3 seconds";
											}
											case 585:
											{
												return "Activates every 5 seconds";
											}
											case 599:
											{
												return "Right click to open";
											}
											case 600:
											{
												return "Right click to open";
											}
											case 601:
											{
												return "Right click to open";
											}
											case 602:
											{
												return "Summons the Frost Legion";
											}
											case 603:
											{
												return "Summons a pet bunny";
											}
											default:
											{
												if (english || Lang.lang <= 1)
												{
													return "";
												}
												return Lang.toolTip(l, true);
											}
										}
									}
								}
							}
							else
							{
								if (num == 352)
								{
									return "Used for brewing ale";
								}
								switch (num)
								{
									case 357:
									{
										return "Minor improvements to all stats";
									}
									case 358:
									case 359:
									case 360:
									case 362:
									case 364:
									case 365:
									case 366:
									case 368:
									case 369:
									case 370:
									case 374:
									case 375:
									case 379:
									case 380:
									case 381:
									case 382:
									case 383:
									case 384:
									case 387:
									case 388:
									case 390:
									case 391:
									case 392:
									case 406:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 361:
									{
										return "Summons a Goblin Army";
									}
									case 363:
									{
										return "Used for advanced wood crafting";
									}
									case 367:
									{
										return "Strong enough to destroy Demon Altars";
									}
									case 371:
									{
										return "Increases maximum mana by 40";
									}
									case 372:
									{
										return "7% increased movement speed";
									}
									case 373:
									{
										return "10% increased ranged damage";
									}
									case 376:
									{
										return "Increases maximum mana by 60";
									}
									case 377:
									{
										return "5% increased melee critical strike chance";
									}
									case 378:
									{
										return "12% increased ranged damage";
									}
									case 385:
									{
										return "Can mine Mythril and Orichalcum";
									}
									case 386:
									{
										return "Can mine Adamantite and Titanium";
									}
									case 389:
									{
										return "Has a chance to confuse";
									}
									case 393:
									{
										return "Displays horizontal position";
									}
									case 394:
									{
										return "Grants the ability to swim";
									}
									case 395:
									{
										return "Shows position";
									}
									case 396:
									{
										return "Negates fall damage";
									}
									case 397:
									{
										return "Grants immunity to knockback";
									}
									case 398:
									{
										return "Allows the combining of some accessories";
									}
									case 399:
									{
										return "Allows the holder to double jump";
									}
									case 400:
									{
										return "Increases maximum mana by 80";
									}
									case 401:
									{
										return "7% increased melee critical strike chance";
									}
									case 402:
									{
										return "14% increased ranged damage";
									}
									case 403:
									{
										return "6% increased damage";
									}
									case 404:
									{
										return "4% increased critical strike chance";
									}
									case 405:
									{
										return "Allows flight";
									}
									case 407:
									{
										return "Increases block placement range";
									}
									default:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
								}
							}
						}
						else if (num > 686)
						{
							switch (num)
							{
								case 707:
								{
									return "Tells the time";
								}
								case 708:
								{
									return "Tells the time";
								}
								case 709:
								{
									return "Tells the time";
								}
								default:
								{
									if (num == 716)
									{
										return "Used to craft items from metal bars";
									}
									switch (num)
									{
										case 723:
										{
											return "Shoots a beam of light";
										}
										case 724:
										{
											return "Shoots an icy bolt";
										}
										case 725:
										{
											return "Shoots frost arrows";
										}
										case 726:
										{
											return "Shoots a stream of frost";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
						}
						else
						{
							switch (num)
							{
								case 665:
								case 666:
								case 667:
								case 668:
								{
									return "'Great for impersonating devs!'";
								}
								case 669:
								{
									return "Summons a baby penguin";
								}
								default:
								{
									switch (num)
									{
										case 676:
										{
											return "Shoots an icy bolt";
										}
										case 677:
										case 679:
										case 680:
										case 681:
										case 682:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
										case 678:
										{
											return "Only for those who are worthy";
										}
										case 683:
										{
											return "Summons the Devil's trident";
										}
										case 684:
										{
											return "16% increased melee and ranged damage";
										}
										case 685:
										{
											return "11% increased melee and ranged critical strike chance";
										}
										case 686:
										{
											return "8% increased movement speed";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
						}
					}
					else if (num <= 823)
					{
						if (num > 753)
						{
							if (num == 761)
							{
								return "Allows flight and slow fall";
							}
							switch (num)
							{
								case 779:
								{
									return "Creates and destroys biomes when sprayed";
								}
								case 780:
								{
									return "Used by the Clentaminator";
								}
								case 781:
								{
									return "Used by the Clentaminator";
								}
								case 782:
								{
									return "Used by the Clentaminator";
								}
								case 783:
								{
									return "Used by the Clentaminator";
								}
								case 784:
								{
									return "Used by the Clentaminator";
								}
								case 785:
								{
									return "Allows flight and slow fall";
								}
								case 786:
								{
									return "Allows flight and slow fall";
								}
								case 787:
								{
									return "Strong enough to destroy Demon Altars";
								}
								case 788:
								{
									return "Summons a thorn spear";
								}
								case 789:
								case 790:
								case 791:
								case 795:
								case 796:
								case 797:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 792:
								{
									return "2% increased damage";
								}
								case 793:
								{
									return "2% increased damage";
								}
								case 794:
								{
									return "2% increased damage";
								}
								case 798:
								{
									return "Able to mine Hellstone";
								}
								default:
								{
									switch (num)
									{
										case 821:
										{
											return "Allows flight and slow fall";
										}
										case 822:
										{
											return "Allows flight and slow fall";
										}
										case 823:
										{
											return "Allows flight and slow fall";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
						}
						else
						{
							switch (num)
							{
								case 748:
								{
									return "Allows flight and slow fall";
								}
								case 749:
								{
									return "Allows flight and slow fall";
								}
								default:
								{
									if (num == 753)
									{
										return "Summons a pet turtle";
									}
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							}
						}
					}
					else if (num > 1072)
					{
						switch (num)
						{
							case 1100:
							{
								return "Used to remove paint";
							}
							case 1101:
							case 1102:
							case 1103:
							case 1104:
							case 1105:
							case 1106:
							case 1124:
							case 1125:
							case 1126:
							case 1127:
							case 1128:
							case 1134:
							case 1135:
							case 1136:
							case 1137:
							case 1138:
							case 1139:
							case 1140:
							case 1142:
							case 1143:
							case 1144:
							case 1146:
							case 1147:
							case 1148:
							case 1149:
							case 1150:
							case 1152:
							case 1153:
							case 1154:
							case 1155:
							case 1166:
							case 1168:
							case 1173:
							case 1174:
							case 1175:
							case 1176:
							case 1177:
							case 1184:
							case 1185:
							case 1186:
							case 1187:
							case 1190:
							case 1191:
							case 1192:
							case 1193:
							case 1194:
							case 1197:
							case 1198:
							case 1199:
							case 1200:
							case 1201:
							case 1202:
							case 1203:
							case 1204:
							case 1222:
							case 1223:
							case 1224:
							case 1225:
							case 1229:
							case 1230:
							case 1231:
							case 1232:
							case 1233:
							case 1234:
							case 1236:
							case 1237:
							case 1238:
							case 1239:
							case 1240:
							case 1241:
							case 1243:
							case 1245:
							case 1246:
							case 1257:
							case 1262:
							case 1263:
							case 1266:
							case 1267:
							case 1268:
							case 1269:
							case 1270:
							case 1271:
							case 1272:
							case 1273:
							case 1274:
							case 1275:
							case 1276:
							case 1277:
							case 1278:
							case 1279:
							case 1280:
							case 1281:
							case 1288:
							case 1289:
							case 1292:
							case 1298:
							case 1302:
							case 1304:
							case 1305:
							case 1319:
							case 1320:
							case 1324:
							case 1325:
							case 1328:
							case 1329:
							case 1330:
							case 1337:
							case 1338:
							case 1339:
							case 1340:
							case 1341:
							case 1342:
							{
								if (english || Lang.lang <= 1)
								{
									return "";
								}
								return Lang.toolTip(l, true);
							}
							case 1107:
							{
								return "Used to make Teal Dye";
							}
							case 1108:
							{
								return "Used to make Green Dye";
							}
							case 1109:
							{
								return "Used to make Sky Blue Dye";
							}
							case 1110:
							{
								return "Used to make Yellow Dye";
							}
							case 1111:
							{
								return "Used to make Blue Dye";
							}
							case 1112:
							{
								return "Used to make Lime Dye";
							}
							case 1113:
							{
								return "Used to make Pink Dye";
							}
							case 1114:
							{
								return "Used to make Orange Dye";
							}
							case 1115:
							{
								return "Used to make Red Dye";
							}
							case 1116:
							{
								return "Used to make Cyan Dye";
							}
							case 1117:
							{
								return "Used to make Violet Dye";
							}
							case 1118:
							{
								return "Used to make Purple Dye";
							}
							case 1119:
							{
								return "Used to make Black Dye";
							}
							case 1120:
							{
								return "Used to Craft Dyes";
							}
							case 1121:
							{
								return "Shoots bees that will chase your enemy";
							}
							case 1122:
							{
								return "Chases after your enemy";
							}
							case 1123:
							{
								return "Summons killer bees after striking your foe";
							}
							case 1129:
							{
								return "Places Hives";
							}
							case 1130:
							{
								return "Explodes into a swarm of bees";
							}
							case 1131:
							{
								return "Allows the holder to reverse gravity";
							}
							case 1132:
							{
								return "Releases bees when damaged";
							}
							case 1133:
							{
								return "Summons the Queen Bee";
							}
							case 1141:
							{
								return "Opens the jungle temple door";
							}
							case 1145:
							{
								return "Used for basic crafting";
							}
							case 1151:
							{
								return "Activates when a player steps on it";
							}
							case 1156:
							{
								return "Latches on to enemies for continuous damage";
							}
							case 1157:
							{
								return "Summons a Pygmy to fight for you";
							}
							case 1158:
							{
								return "Increases your max number of minions";
							}
							case 1159:
							{
								return "Increases your max number of minions";
							}
							case 1160:
							{
								return "Increases your max number of minions";
							}
							case 1161:
							{
								return "Increases your max number of minions";
							}
							case 1162:
							{
								return "Allows flight and slow fall";
							}
							case 1163:
							{
								return "Allows the holder to double jump";
							}
							case 1164:
							{
								return "Allows the holder to quadruple jump";
							}
							case 1165:
							{
								return "Allows flight and slow fall";
							}
							case 1167:
							{
								return "Increases the damage of your minions by 15%";
							}
							case 1169:
							{
								return "Summons a Baby Skeletron Head";
							}
							case 1170:
							{
								return "Summons a Baby Hornet";
							}
							case 1171:
							{
								return "Summons a Tiki Spirit";
							}
							case 1172:
							{
								return "Summons a Pet Lizard";
							}
							case 1178:
							{
								return "Rapidly shoots razor sharp leaves";
							}
							case 1179:
							{
								return "Chases after your enemy";
							}
							case 1180:
							{
								return "Summons a Pet Parrot";
							}
							case 1181:
							{
								return "Summons a Baby Truffle";
							}
							case 1182:
							{
								return "Summons a Pet Sapling";
							}
							case 1183:
							{
								return "Summons a Wisp to provide light";
							}
							case 1188:
							{
								return "Can mine Mythril and Orichalcum";
							}
							case 1189:
							{
								return "Can mine Mythril and Orichalcum";
							}
							case 1195:
							{
								return "Can mine Adamantite and Titanium";
							}
							case 1196:
							{
								return "Can mine Adamantite and Titanium";
							}
							case 1205:
							{
								return "8% increased melee damage";
							}
							case 1206:
							{
								return "9% increased ranged damage";
							}
							case 1207:
							{
								return "7% increased magic damage and critical strike chance";
							}
							case 1208:
							{
								return "3% increased damage";
							}
							case 1209:
							{
								return "2% increased damage";
							}
							case 1210:
							{
								return "7% increased melee damage";
							}
							case 1211:
							{
								return "15% increased ranged critical strike chance";
							}
							case 1212:
							{
								return "18% increased magic critical strike chance";
							}
							case 1213:
							{
								return "6% increased critical strike chance";
							}
							case 1214:
							{
								return "11% increased movement speed";
							}
							case 1215:
							{
								return "8% increased melee damage and critical strike chance";
							}
							case 1216:
							{
								return "16% increased ranged damage";
							}
							case 1217:
							{
								return "16% increased magic damage and 7% increased magic critical strike chance";
							}
							case 1218:
							{
								return "4% increased damage";
							}
							case 1219:
							{
								return "3% increased damage and critical strike chance";
							}
							case 1220:
							{
								return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
							}
							case 1221:
							{
								return "Used to smelt adamantite and titanium ore";
							}
							case 1226:
							{
								return "Shoots a powerful orb";
							}
							case 1227:
							{
								return "Shoots a spore cloud";
							}
							case 1228:
							{
								return "Shoots a spore cloud";
							}
							case 1235:
							{
								return "Bounces back after hitting a wall";
							}
							case 1242:
							{
								return "Summons a Baby Dinosaur";
							}
							case 1244:
							{
								return "Summons a cloud to rain down on your foes";
							}
							case 1247:
							{
								return "Causes stars to fall and releases bees when injured";
							}
							case 1248:
							{
								return "10% increased critical strike chance";
							}
							case 1249:
							{
								return "Increases jump height";
							}
							case 1250:
							{
								return "Allows the holder to double jump";
							}
							case 1251:
							{
								return "Allows the holder to double jump";
							}
							case 1252:
							{
								return "Allows the holder to double jump";
							}
							case 1253:
							{
								return "Puts a shell around the owner when below 50% life that reduces damage";
							}
							case 1254:
							{
								return "Shoots a powerful, high velocity bullet";
							}
							case 1255:
							{
								return "Shoots a powerful, high velocity bullet";
							}
							case 1256:
							{
								return "Summons a cloud to rain blood on your foes";
							}
							case 1258:
							{
								return "Shoots an explosive bolt";
							}
							case 1259:
							{
								return "Shoots razor sharp flower petals at nearby enemies";
							}
							case 1260:
							{
								return "Shoots a rainbow that does continuous damage";
							}
							case 1261:
							{
								return "Explodes into deadly shrapnel";
							}
							case 1264:
							{
								return "Shoots a ball of frost";
							}
							case 1265:
							{
								return "Shoots a powerful, high velocity bullet";
							}
							case 1282:
							{
								return "Increases maximum mana by 20";
							}
							case 1283:
							{
								return "Increases maximum mana by 40";
							}
							case 1284:
							{
								return "Increases maximum mana by 40";
							}
							case 1285:
							{
								return "Increases maximum mana by 60";
							}
							case 1286:
							{
								return "Increases maximum mana by 60";
							}
							case 1287:
							{
								return "Increases maximum mana by 80";
							}
							case 1290:
							{
								return "Increases movement speed after being struck";
							}
							case 1291:
							{
								return "Permanently increases maximum life by 5";
							}
							case 1293:
							{
								return "Used at the Lihzahrd Altar";
							}
							case 1294:
							{
								return "Capable of mining Lihzahrd Bricks";
							}
							case 1295:
							{
								return "Shoots a piercing ray of heat";
							}
							case 1296:
							{
								return "Summons a powerful boulder";
							}
							case 1297:
							{
								return "Punches with the force of a golem";
							}
							case 1299:
							{
								return "Increases view range when held";
							}
							case 1300:
							{
								return "Increases view range for guns";
							}
							case 1301:
							{
								return "10% increased damage";
							}
							case 1303:
							{
								return "Provides light under water";
							}
							case 1306:
							{
								return "Shoots an icy sickle";
							}
							case 1307:
							{
								return "'You are a terrible person'";
							}
							case 1308:
							{
								return "Shoots a poison fang that pierces multiple enemies";
							}
							case 1309:
							{
								return "Summons a baby slime to fight for you";
							}
							case 1310:
							{
								return "Inflicts poison on enemies";
							}
							case 1311:
							{
								return "Summons an eyeball spring";
							}
							case 1312:
							{
								return "Summons a baby snowman";
							}
							case 1313:
							{
								return "Shoots a skull";
							}
							case 1314:
							{
								return "Shoots a boxing glove";
							}
							case 1315:
							{
								return "Summons a pirate invasion";
							}
							case 1316:
							{
								return "6% increased melee damage";
							}
							case 1317:
							{
								return "8% increased melee damage and critical strike chance";
							}
							case 1318:
							{
								return "4% increased melee critical strike chance";
							}
							case 1321:
							{
								return "Increases damage by 10% and greatly increases arrow speed";
							}
							case 1322:
							{
								return "Inflicts fire damage on attack";
							}
							case 1323:
							{
								return "Reduces damage from touching lava";
							}
							case 1326:
							{
								return "Teleports you to the position of the mouse";
							}
							case 1327:
							{
								return "Shoots a deathly sickle";
							}
							case 1331:
							{
								return "Summons the Brain of Cthulhu";
							}
							case 1332:
							{
								return "'The blood of gods'";
							}
							case 1333:
							{
								return "Can be placed in water";
							}
							case 1334:
							{
								return "Decreases target's defense";
							}
							case 1335:
							{
								return "Decreases target's defense";
							}
							case 1336:
							{
								return "Sprays a shower of ichor";
							}
							case 1343:
							{
								return "Increases melee knockback and inflicts fire damage on attack";
							}
							default:
							{
								switch (num)
								{
									case 1430:
									{
										return "Used to craft weapon imbuement flasks";
									}
									case 1431:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 1432:
									{
										return "Used to craft various types of ammo";
									}
									default:
									{
										switch (num)
										{
											case 1444:
											{
												return "Creates a shadow beam that bounces off walls";
											}
											case 1445:
											{
												return "Launches a ball of fire that explodes into a raging inferno";
											}
											case 1446:
											{
												return "Summons a lost soul to chase your foes";
											}
											case 1447:
											case 1448:
											{
												if (english || Lang.lang <= 1)
												{
													return "";
												}
												return Lang.toolTip(l, true);
											}
											case 1449:
											{
												return "Blows bubbles";
											}
											case 1450:
											{
												return "Blows bubbles";
											}
											default:
											{
												if (english || Lang.lang <= 1)
												{
													return "";
												}
												return Lang.toolTip(l, true);
											}
										}
									}
								}
							}
						}
					}
					else
					{
						if (num == 832)
						{
							return "Places living wood";
						}
						switch (num)
						{
							case 849:
							{
								return "Enables solid blocks to be toggled on and off";
							}
							case 850:
							{
								return "Places blue wire";
							}
							case 851:
							{
								return "Places green wire";
							}
							case 852:
							{
								return "Activates when a player steps on it";
							}
							case 853:
							{
								return "Activates when anything but a player steps on it";
							}
							case 854:
							{
								return "Shops have lower prices";
							}
							case 855:
							{
								return "Hitting enemies will sometimes drop extra coins";
							}
							case 856:
							{
								return "'Having a wonderful time!'";
							}
							case 857:
							{
								return "Allows the holder to do an improved double jump";
							}
							case 858:
							case 859:
							case 864:
							case 865:
							case 866:
							case 867:
							case 868:
							case 869:
							case 870:
							case 871:
							case 872:
							case 873:
							case 874:
							case 875:
							case 876:
							case 877:
							case 878:
							case 879:
							case 880:
							case 881:
							case 882:
							case 883:
							case 884:
							case 894:
							case 895:
							case 896:
							case 909:
							case 910:
							case 911:
							case 912:
							case 913:
							case 914:
							case 915:
							case 916:
							case 917:
							case 918:
							case 919:
							case 920:
							case 921:
							case 922:
							case 923:
							case 924:
							case 925:
							case 926:
							case 927:
							case 928:
							case 929:
							case 930:
							case 931:
							case 939:
							case 940:
							case 941:
							case 942:
							case 943:
							case 944:
							case 945:
							case 949:
							case 952:
							case 954:
							case 955:
							case 970:
							case 971:
							case 972:
							case 973:
							case 974:
							case 978:
							case 979:
							case 980:
							case 981:
							case 988:
							case 991:
							case 992:
							case 993:
							case 999:
							{
								if (english || Lang.lang <= 1)
								{
									return "";
								}
								return Lang.toolTip(l, true);
							}
							case 860:
							{
								return "Provides life regeneration and reduces the cooldown of healing potions";
							}
							case 861:
							{
								return "Turns the holder into a werewolf at night and a merfolk when entering water";
							}
							case 862:
							{
								return "Causes stars to fall and increases length of invincibility after taking damage";
							}
							case 863:
							{
								return "Provides the ability to walk on water";
							}
							case 885:
							{
								return "Immunity to Bleeding";
							}
							case 886:
							{
								return "Immunity to Broken Armor";
							}
							case 887:
							{
								return "Immunity to Poison";
							}
							case 888:
							{
								return "Immunity to Darkness";
							}
							case 889:
							{
								return "Immunity to Slow";
							}
							case 890:
							{
								return "Immunity to Silence";
							}
							case 891:
							{
								return "Immunity to Curse";
							}
							case 892:
							{
								return "Immunity to Weakness";
							}
							case 893:
							{
								return "Immunity to Confusion";
							}
							case 897:
							{
								return "Increases melee knockback";
							}
							case 898:
							{
								return "Allows flight";
							}
							case 899:
							{
								return "Increases all stats if worn during the day";
							}
							case 900:
							{
								return "Increases all stats if worn during the night";
							}
							case 901:
							{
								return "Immunity to Weakness and Broken Armor";
							}
							case 902:
							{
								return "Immunity to Poison and Bleeding";
							}
							case 903:
							{
								return "Immunity to Slow and Confusion";
							}
							case 904:
							{
								return "Immunity to Silence and Curse";
							}
							case 905:
							{
								return "Uses coins for ammo";
							}
							case 906:
							{
								return "Provides 7 seconds of immunity to lava";
							}
							case 907:
							{
								return "Provides the ability to walk on water";
							}
							case 908:
							{
								return "Provides the ability to walk on water and lava";
							}
							case 932:
							{
								return "Places bone";
							}
							case 933:
							{
								return "Places leaves";
							}
							case 934:
							{
								return "Allows the owner to float for a few seconds";
							}
							case 935:
							{
								return "12% increased damage";
							}
							case 936:
							{
								return "Increases melee knockback";
							}
							case 937:
							{
								return "Explodes when stepped on";
							}
							case 938:
							{
								return "Absorbs 25% of damage done to players on your team";
							}
							case 946:
							{
								return "You will fall slower while holding this";
							}
							case 947:
							{
								return "'Reacts to the light'";
							}
							case 948:
							{
								return "Allows flight and slowfall";
							}
							case 950:
							{
								return "Provides extra mobility on ice";
							}
							case 951:
							{
								return "Rapidly launches snowballs";
							}
							case 953:
							{
								return "Allows the ability to slide down walls";
							}
							case 956:
							{
								return "7% increased melee speed";
							}
							case 957:
							{
								return "7% increased melee speed";
							}
							case 958:
							{
								return "7% increased melee speed";
							}
							case 959:
							{
								break;
							}
							case 960:
							{
								return "Increases maximum mana by 40";
							}
							case 961:
							{
								return "Increases maximum mana by 20";
							}
							case 962:
							{
								return "Increases maximum mana by 20";
							}
							case 963:
							{
								return "Gives a chance to dodge attacks";
							}
							case 964:
							{
								return "Fires a spread of bullets";
							}
							case 965:
							{
								return "Can be climbed on";
							}
							case 966:
							{
								return "Life regen is increased when near a campfire";
							}
							case 967:
							{
								return "Put it on a stick and roast over a campfire";
							}
							case 968:
							{
								return "Roast it over a campfire!";
							}
							case 969:
							{
								return "Minor improvements to all stats";
							}
							case 975:
							{
								return "Allows the ability to slide down walls";
							}
							case 976:
							{
								return "Allows the ability to climb walls";
							}
							case 977:
							{
								return "Allows the ability to dash";
							}
							case 982:
							{
								return "Increases maximum mana by 20";
							}
							case 983:
							{
								return "Allows the holder to double jump";
							}
							case 984:
							{
								return "Allows the ability to climb walls and dash";
							}
							case 985:
							{
								return "Throw to create a climbable line of rope";
							}
							case 986:
							{
								return "Allows the collection of seeds for ammo";
							}
							case 987:
							{
								return "Allows the holder to double jump";
							}
							case 989:
							{
								return "Shoots an enchanted sword beam";
							}
							case 990:
							{
								return "'Not to be confused with a hamdrill'";
							}
							case 994:
							{
								return "Summons a Baby Eater of Souls";
							}
							case 995:
							{
								return "Used to craft objects";
							}
							case 996:
							{
								return "Used to craft objects";
							}
							case 997:
							{
								return "Turns silt/slush/fossils into something more useful";
							}
							case 998:
							{
								return "Used to craft objects";
							}
							case 1000:
							{
								return "Shoots confetti everywhere!";
							}
							case 1001:
							{
								return "16% increased melee damage";
							}
							case 1002:
							{
								return "16% increased ranged damage";
							}
							case 1003:
							{
								return "Increases maximum mana by 80 and reduces mana usage by 17%";
							}
							case 1004:
							{
								return "5% increased damage";
							}
							case 1005:
							{
								return "8% increased critical strike chance";
							}
							case 1006:
							{
								return "Reacts to the light";
							}
							default:
							{
								switch (num)
								{
									case 1071:
									{
										return "Used with paint to color blocks";
									}
									case 1072:
									{
										return "Used with paint to color walls";
									}
									default:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
								}
							}
						}
					}
					return "5% increased ranged damage.";
				}
				else if (num > 2502)
				{
					if (num <= 3124)
					{
						if (num <= 2624)
						{
							if (num > 2551)
							{
								switch (num)
								{
									case 2584:
									{
										return "Summons pirates to fight for you";
									}
									case 2585:
									case 2588:
									case 2589:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 2586:
									{
										break;
									}
									case 2587:
									{
										return "Summons a mini minotaur";
									}
									case 2590:
									{
										return "A small explosion that puts enemies on fire";
									}
									default:
									{
										switch (num)
										{
											case 2609:
											{
												return "Allows flight and slow fall";
											}
											case 2610:
											{
												return "Squirts a harmless stream of slime";
											}
											case 2611:
											{
												return "Spews homing bubbles";
											}
											default:
											{
												switch (num)
												{
													case 2621:
													{
														return "Summons sharknados to fight for you";
													}
													case 2622:
													{
														return "Casts fast moving razorwheels";
													}
													case 2623:
													{
														return "Rapidly shoots forceful bubbles";
													}
													case 2624:
													{
														return "Shoots 5 arrows at a time";
													}
													default:
													{
														if (english || Lang.lang <= 1)
														{
															return "";
														}
														return Lang.toolTip(l, true);
													}
												}
											}
										}
									}
								}
							}
							else
							{
								if (num == 2535)
								{
									return "Summons twins to fight for you";
								}
								if (num == 2551)
								{
									return "Summons spiders to fight for you";
								}
								if (english || Lang.lang <= 1)
								{
									return "";
								}
								return Lang.toolTip(l, true);
							}
						}
						else if (num > 2771)
						{
							if (num == 2799)
							{
								return "Creates measurement lines on screen for block placement";
							}
							switch (num)
							{
								case 2886:
								{
									return "Banishes the Hallow";
								}
								case 2887:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 2888:
								{
									return "Wooden arrows turn into a column of bees";
								}
								default:
								{
									switch (num)
									{
										case 2997:
										{
											return "Teleports you to a party member";
										}
										case 2998:
										{
											return "15% increased summon damage";
										}
										case 2999:
										{
											return "Right click to have more minions";
										}
										case 3000:
										{
											return "33% chance to not consume potion crafting ingredients";
										}
										case 3001:
										{
											return "'It looks and smells terrible'";
										}
										case 3002:
										{
											return "Exposes nearby treasure";
										}
										case 3003:
										case 3007:
										case 3008:
										case 3009:
										case 3010:
										case 3011:
										case 3012:
										case 3013:
										case 3018:
										case 3020:
										case 3021:
										case 3022:
										case 3023:
										case 3025:
										case 3026:
										case 3027:
										case 3028:
										case 3038:
										case 3039:
										case 3040:
										case 3041:
										case 3042:
										case 3044:
										case 3045:
										case 3055:
										case 3056:
										case 3057:
										case 3058:
										case 3059:
										case 3063:
										case 3065:
										case 3066:
										case 3067:
										case 3070:
										case 3071:
										case 3072:
										case 3073:
										case 3074:
										case 3075:
										case 3076:
										case 3077:
										case 3078:
										case 3079:
										case 3080:
										case 3081:
										case 3082:
										case 3083:
										case 3086:
										case 3087:
										case 3088:
										case 3089:
										case 3094:
										case 3100:
										case 3101:
										case 3103:
										case 3104:
										case 3105:
										case 3107:
										case 3108:
										case 3114:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
										case 3004:
										{
											return "'Emits a deathly glow'";
										}
										case 3005:
										{
											return "Throw to create a climbable line of vine rope";
										}
										case 3006:
										{
											return "Drains life from enemies";
										}
										case 3014:
										{
											return "Summons a wall of cursed flames";
										}
										case 3015:
										{
											return "Enemies are less likely to target you";
										}
										case 3016:
										{
											return "Enemies are more likely to target you";
										}
										case 3017:
										{
											return "Flowers grow on the grass you walk on";
										}
										case 3019:
										{
											return "Wooden arrows turn into flaming bats";
										}
										case 3024:
										{
											return "'Great for impersonating devs!'";
										}
										case 3029:
										{
											return "Shoots arrows from the sky";
										}
										case 3030:
										{
											return "Throws a controllable flying knife";
										}
										case 3031:
										{
											return "Contains an endless amount of water";
										}
										case 3032:
										{
											return "Capable of soaking up any endless amount of water";
										}
										case 3033:
										{
											return "Increases coin pickup range";
										}
										case 3034:
										{
											return "Increases coin pickup range";
										}
										case 3035:
										{
											return "Increases coin pickup range and shops have lower prices";
										}
										case 3036:
										{
											return "Displays weather, moon phase, and fishing information";
										}
										case 3037:
										{
											return "Displays the weather";
										}
										case 3043:
										{
											return "Summons a magic lantern that exposes nearby treasure";
										}
										case 3046:
										{
											return "Life regen is increased when near a campfire";
										}
										case 3047:
										{
											return "Life regen is increased when near a campfire";
										}
										case 3048:
										{
											return "Life regen is increased when near a campfire";
										}
										case 3049:
										{
											return "Life regen is increased when near a campfire";
										}
										case 3050:
										{
											return "Life regen is increased when near a campfire";
										}
										case 3051:
										{
											return "Summons a massive crystal spike";
										}
										case 3052:
										{
											return "Shoots Shadowflame Arrows";
										}
										case 3053:
										{
											return "Summons Shadowflame tentacles to strike your foe";
										}
										case 3054:
										{
											return "Inflicts Shadowflame on hit";
										}
										case 3060:
										{
											return "Summons a Baby Face Monster";
										}
										case 3061:
										{
											return "Increases tile and wall placement speed and reach";
										}
										case 3062:
										{
											return "Summons a heart to provide light";
										}
										case 3064:
										{
											return "Allows time to fast forward one day per week";
										}
										case 3068:
										{
											return "Allows the collection of Vine Rope from vines";
										}
										case 3069:
										{
											return "Shoots a small spark";
										}
										case 3084:
										{
											return "Detects enemies around you";
										}
										case 3085:
										{
											return "Right click to open";
										}
										case 3090:
										{
											return "Slimes become friendly";
										}
										case 3091:
										{
											return "'Charged with the essence of many souls'";
										}
										case 3092:
										{
											return "'Charged with the essence of many souls'";
										}
										case 3093:
										{
											return "Right click to open";
										}
										case 3095:
										{
											return "Displays how many monsters have been killed";
										}
										case 3096:
										{
											return "Displays the phase of the moon";
										}
										case 3097:
										{
											return "Allows the player to dash into the enemy";
										}
										case 3098:
										{
											return "Sparks emit from struck enemies";
										}
										case 3099:
										{
											return "Displays how fast the player is moving";
										}
										case 3102:
										{
											return "Displays the most valuable ore around you";
										}
										case 3106:
										{
											return "Allows you to go into stealth mode";
										}
										case 3109:
										{
											return "Improves vision";
										}
										case 3110:
										{
											return "Turns the holder into a werewolf at night and a merfolk when entering water";
										}
										case 3111:
										{
											return "'Bouncy and sweet!'";
										}
										case 3112:
										{
											return "Works when wet";
										}
										case 3113:
										{
											return "Very bouncy";
										}
										case 3115:
										{
											return "A small explosion that will destroy some tiles";
										}
										case 3116:
										{
											return "A small explosion that will not destroy tiles";
										}
										case 3117:
										{
											return "Makes surrounding creatures less hostile";
										}
										case 3118:
										{
											return "Displays the name of rare creatures around you";
										}
										case 3119:
										{
											return "Displays your damage per second";
										}
										case 3120:
										{
											return "Displays fishing information";
										}
										case 3121:
										{
											return "Displays movement speed, damage per second, and valuable ore";
										}
										case 3122:
										{
											return "Displays number of monsters, kill count, and rare creatures";
										}
										case 3123:
										{
											return "Displays everything";
										}
										case 3124:
										{
											return "Displays everything";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
						}
						else
						{
							if (num == 2699)
							{
								return "Right click to place item on weapon rack";
							}
							switch (num)
							{
								case 2739:
								{
									return "Hammer to change direction";
								}
								case 2740:
								case 2741:
								case 2742:
								case 2743:
								case 2744:
								case 2745:
								case 2746:
								case 2747:
								case 2748:
								case 2751:
								case 2752:
								case 2753:
								case 2754:
								case 2755:
								case 2756:
								case 2766:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 2749:
								{
									return "Summons a UFO to fight for you";
								}
								case 2750:
								{
									return "Showers meteors";
								}
								case 2757:
								{
									return "16% increased ranged damage";
								}
								case 2758:
								{
									return "12% increased ranged damage and critical strike chance";
								}
								case 2759:
								{
									return "8% increased ranged damage and critical strike chance";
								}
								case 2760:
								{
									return "Increases maximum mana by 60 and reduces mana usage by 15% ";
								}
								case 2761:
								{
									return "9% increased magic damage and critical strike chance";
								}
								case 2762:
								{
									return "10% increased magic damage";
								}
								case 2763:
								{
									return "17% increased melee critical strike chance";
								}
								case 2764:
								{
									return "22% increased melee damage";
								}
								case 2765:
								{
									return "15% increased movement and melee speed";
								}
								case 2767:
								{
									return "Summons the Eclipse";
								}
								case 2768:
								{
									return "Summons a rideable Drill mount";
								}
								case 2769:
								{
									return "Summons a rideable UFO mount";
								}
								case 2770:
								{
									return "Allows flight and slow fall";
								}
								case 2771:
								{
									return "Summons a rideable Scutlix mount";
								}
								default:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							}
						}
					}
					else if (num <= 3288)
					{
						if (num > 3245)
						{
							switch (num)
							{
								case 3250:
								case 3252:
								{
									return "Allows the holder to double jump";
								}
								case 3251:
								{
									return "Releases bees when damaged";
								}
								default:
								{
									if (num == 3260)
									{
										return "Summons a rideable unicorn mount";
									}
									switch (num)
									{
										case 3287:
										case 3288:
										{
											return "'Great for impersonating devs!'";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
						}
						else
						{
							switch (num)
							{
								case 3195:
								{
									return "Minor improvements to all stats";
								}
								case 3196:
								{
									return "A small explosion that will destroy some tiles";
								}
								case 3197:
								case 3202:
								case 3214:
								case 3215:
								case 3216:
								case 3217:
								case 3218:
								case 3219:
								case 3220:
								case 3221:
								case 3222:
								case 3229:
								case 3230:
								case 3231:
								case 3232:
								case 3233:
								case 3234:
								case 3235:
								case 3236:
								case 3237:
								case 3238:
								case 3239:
								case 3240:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 3198:
								{
									return "Increases armor penetration for melee weapons";
								}
								case 3199:
								{
									return "Gaze in the mirror to return home";
								}
								case 3200:
								{
									return "The wearer can run super fast";
								}
								case 3201:
								{
									return "Allows the holder to double jump";
								}
								case 3203:
								{
									return "Right click to open";
								}
								case 3204:
								{
									return "Right click to open";
								}
								case 3205:
								{
									return "Right click to open";
								}
								case 3206:
								{
									return "Right click to open";
								}
								case 3207:
								{
									return "Right click to open";
								}
								case 3208:
								{
									return "Right click to open";
								}
								case 3209:
								{
									return "Shoots an explosive crystal charge";
								}
								case 3210:
								{
									return "Spits toxic bubbles";
								}
								case 3211:
								{
									return "Spits an Ichor stream on contact";
								}
								case 3212:
								{
									return "Increases armor penetration by 5";
								}
								case 3213:
								{
									return "Summons a flying piggy bank to store your items";
								}
								case 3223:
								{
									return "May confuse nearby enemies after being struck";
								}
								case 3224:
								{
									return "Reduces damage taken by 17%";
								}
								case 3225:
								{
									return "Increases jump height";
								}
								case 3226:
								case 3227:
								case 3228:
								{
									return "'Great for impersonating devs!'";
								}
								case 3241:
								{
									return "Increases jump height";
								}
								default:
								{
									if (num == 3245)
									{
										return "Throws empowered bones";
									}
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							}
						}
					}
					else if (num > 3388)
					{
						switch (num)
						{
							case 3456:
								{
									return "'Swirling energies emanate from this fragment'";
								}
							case 3457:
								{
									return "'The power of a galaxy resides within this fragment'";
								}
							case 3458:
								{
									return "'The fury of the universe lies within this fragment'";
								}
							case 3459:
								{
									return "'Entrancing particles revolve around this fragment'";
								}
							case 3460:
								{
									return "'A pebble of the heavens'";
								}
							case 3461:
							case 3462:
							case 3463:
							case 3464:
							case 3465:
							case 3466:
							case 3472:
							case 3480:
							case 3481:
							case 3482:
							case 3483:
							case 3484:
							case 3486:
							case 3487:
							case 3488:
							case 3489:
							case 3490:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							case 3467:
								{
									return "'It vibrates with luminous celestial energy'";
								}
							case 3468:
								{
									return "Allows flight and slow fall";
								}
							case 3469:
								{
									return "Allows flight and slow fall";
								}
							case 3470:
								{
									return "Allows flight and slow fall";
								}
							case 3471:
								{
									return "Allows flight and slow fall";
								}
							case 3473:
								{
									return "'Strike with the fury of the sun'";
								}
							case 3474:
								{
									return "Summons a stardust cell to fight for you";
								}
							case 3475:
								{
									return "66% chance to not consume ammo";
								}
							case 3476:
								{
									return "'Conjure masses of astral energy to chase down your foes'";
								}
							case 3477:
								{
									return "Spreads the crimson to some blocks";
								}
							case 3478:
								{
									return "'Wuv... twue wuv...'";
								}
							case 3479:
								{
									return "'Mawwiage...'";
								}
							case 3485:
							case 3491:
								{
									return "Can mine Meteorite";
								}
							case 3521:
								{
									return "Can mine Meteorite";
								}
							case 3522:
							case 3523:
							case 3524:
							case 3525:
							case 3526:
							case 3527:
							case 3528:
							case 3529:
							case 3530:
							case 3533:
							case 3534:
							case 3535:
							case 3544:
							case 3546:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							case 3531:
								{
									return "Summons a stardust dragon to fight for you";
								}
							case 3532:
								{
									return "Minor improvements to all stats";
								}
							case 3536:
								{
									return "'Wield a small amount of power from the Vortex Tower'";
								}
							case 3537:
								{
									return "'Wield a small amount of power from the Nebula Tower'";
								}
							case 3538:
								{
									return "'Wield a small amount of power from the Stardust Tower'";
								}
							case 3539:
								{
									return "'Wield a small amount of power from the Solar Tower'";
								}
							case 3540:
								{
									return "66% chance to not consume ammo";
								}
							case 3541:
								{
									return "'Fire a lifeform disintegration rainbow'";
								}
							case 3542:
								{
									return "'From Orion's belt to the palm of your hand'";
								}
							case 3543:
								{
									return "'Rend your foes asunder with a spear of light!'";
								}
							case 3545:
								{
									return "'Guts... and Gory!'";
								}
							case 3547:
								{
									return "'This will prove to be terrible idea'";
								}
							case 3548:
								{
									break;
								}
							case 3549:
								{
									return "Used to craft items from Lunar Fragments and Luminite";
								}
							case 3567:
								{
									return "'Line 'em up and knock 'em down...'";
								}
							case 3568:
								{
									return "'Shooting them down at the speed of sound!'";
								}
							case 3569:
								{
									return "Summons a lunar portal to shoot lasers at your enemies";
								}
							case 3570:
								{
									return "Rains down lunar flares";
								}
							case 3571:
								{
									return "Summons a radiant crystal that banishes your enemies";
								}
							case 3572:
								{
									return "'You want the moon? Just grapple it and pull it down!'";
								}
							case 3573:
							case 3574:
							case 3575:
							case 3576:
							case 3584:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							case 3577:
								{
									return "Calls upon a suspicious looking eye to provide light";
								}
							case 3578:
							case 3579:
							case 3580:
							case 3581:
							case 3582:
							case 3583:
							case 3585:
							case 3586:
							case 3587:
							case 3588:
							case 3589:
							case 3590:
							case 3591:
							case 3592:
								{
									return "'Great for impersonating devs!'";
								}
							default:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
						}
					}
					else
					{
						switch (num)
						{
							case 3333:
								{
									return "Increases the strength of friendly bees";
								}
							case 3334:
								{
									return "Allows the use of two yoyos at once";
								}
							case 3335:
								{
									return "Permanently increases the number of accessory slots";
								}
							case 3336:
								{
									return "Summons spores over time that will damage enemies";
								}
							case 3337:
								{
									return "Greatly increases life regen when not moving";
								}
							default:
								{
									switch (num)
									{
										case 3360:
											{
												return "Places living rich mahogany";
											}
										case 3361:
											{
												return "Places rich mahogany leaves";
											}
										default:
											{
												switch (num)
												{
													case 3366:
														{
															return "Gives the user master yoyo skills";
														}
													case 3367:
														{
															return "Attracts a legendary creature which flourishes in water & combat";
														}
													case 3368:
													case 3369:
													case 3370:
													case 3371:
													case 3372:
													case 3373:
													case 3377:
													case 3378:
													case 3379:
													case 3380:
													case 3384:
														{
															if (english || Lang.lang <= 1)
															{
																return "";
															}
															return Lang.toolTip(l, true);
														}
													case 3374:
														{
															return "20% increased throwing velocity";
														}
													case 3375:
														{
															return "20% increased throwing damage";
														}
													case 3376:
														{
															return "15% increased throwing critical strike chance";
														}
													case 3381:
														{
															return "Increases your max number of minions";
														}
													case 3382:
														{
															return "Increases your max number of minions";
														}
													case 3383:
														{
															return "Increases your max number of minions";
														}
													case 3385:
													case 3386:
													case 3387:
													case 3388:
														{
															return "Can be traded for rare dyes";
														}
													default:
														{
															if (english || Lang.lang <= 1)
															{
																return "";
															}
															return Lang.toolTip(l, true);
														}
												}
											}
									}
								}
						}
					}
					return "A small explosion that will not destroy tiles";
				}
				else if (num <= 1931)
				{
					if (num <= 1810)
					{
						if (num > 1724)
						{
							switch (num)
							{
								case 1767:
								{
									return "To me it look like a leprechaun to me";
								}
								case 1768:
								{
									return "I just wanna know where the gold at!";
								}
								case 1769:
								{
									return "I want the gold. I want the gold. I want the gold. Gimme the gold!";
								}
								default:
								{
									if (num == 1774)
									{
										return "Right click to open";
									}
									switch (num)
									{
										case 1782:
										{
											return "33% chance to not consume ammo";
										}
										case 1783:
										case 1784:
										case 1785:
										case 1788:
										case 1789:
										case 1790:
										case 1791:
										case 1792:
										case 1793:
										case 1794:
										case 1795:
										case 1796:
										case 1800:
										case 1808:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
										case 1786:
										{
											return "Allows the collection of hay from grass";
										}
										case 1787:
										{
											return "Minor improvements to all stats";
										}
										case 1797:
										{
											return "Allows flight and slow fall";
										}
										case 1798:
										{
											return "Summons a pet spider";
										}
										case 1799:
										{
											return "Summons a pet squashling";
										}
										case 1801:
										{
											return "Summons bats to attack your enemies";
										}
										case 1802:
										{
											return "Summons a raven to fight for you";
										}
										case 1803:
										{
											return "Used for crafting a Jungle Key";
										}
										case 1804:
										{
											return "Used for crafting a Corruption Key";
										}
										case 1805:
										{
											return "Used for crafting a Crimson Key";
										}
										case 1806:
										{
											return "Used for crafting a Hallowed Key";
										}
										case 1807:
										{
											return "Used for crafting a Frozen Key";
										}
										case 1809:
										{
											return "Best used for pranking townsfolk";
										}
										case 1810:
										{
											return "Summons a black kitty";
										}
										default:
										{
											if (english || Lang.lang <= 1)
											{
												return "";
											}
											return Lang.toolTip(l, true);
										}
									}
								}
							}
						}
						else
						{
							switch (num)
							{
								case 1503:
								{
									return "40% decreased magic damage";
								}
								case 1504:
								{
									return "7% increased magic damage and critical strike chance";
								}
								case 1505:
								{
									return "8% increased magic damage";
								}
								case 1506:
								case 1507:
								case 1508:
								case 1509:
								case 1510:
								case 1511:
								case 1512:
								case 1514:
								case 1516:
								case 1517:
								case 1518:
								case 1519:
								case 1520:
								case 1521:
								case 1528:
								case 1529:
								case 1530:
								case 1531:
								case 1532:
								case 1538:
								case 1539:
								case 1540:
								case 1541:
								case 1542:
								case 1552:
								case 1570:
								case 1573:
								case 1574:
								case 1575:
								case 1576:
								case 1577:
								case 1589:
								case 1590:
								case 1591:
								case 1592:
								case 1593:
								case 1594:
								case 1596:
								case 1597:
								case 1598:
								case 1599:
								case 1600:
								case 1601:
								case 1602:
								case 1603:
								case 1604:
								case 1605:
								case 1606:
								case 1607:
								case 1608:
								case 1609:
								case 1610:
								case 1611:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 1513:
								{
									return "A powerful returning hammer";
								}
								case 1515:
								{
									return "Allows flight and slow fall";
								}
								case 1522:
								{
									return "For Capture the Gem. It drops when you die";
								}
								case 1523:
								{
									return "For Capture the Gem. It drops when you die";
								}
								case 1524:
								{
									return "For Capture the Gem. It drops when you die";
								}
								case 1525:
								{
									return "For Capture the Gem. It drops when you die";
								}
								case 1526:
								{
									return "For Capture the Gem. It drops when you die";
								}
								case 1527:
								{
									return "For Capture the Gem. It drops when you die";
								}
								case 1533:
								{
									return "Unlocks a Jungle Chest in the dungeon";
								}
								case 1534:
								{
									return "Unlocks a Corruption Chest in the dungeon";
								}
								case 1535:
								{
									return "Unlocks a Crimson Chest in the dungeon";
								}
								case 1536:
								{
									return "Unlocks a Hallowed Chest in the dungeon";
								}
								case 1537:
								{
									return "Unlocks a Frozen Chest in the dungeon";
								}
								case 1543:
								{
									return "Used with paint to color blocks";
								}
								case 1544:
								{
									return "Used with paint to color walls";
								}
								case 1545:
								{
									return "Used to remove paint";
								}
								case 1546:
								{
									return "15% increased arrow damage";
								}
								case 1547:
								{
									return "15% increased bullet damage";
								}
								case 1548:
								{
									return "15% increased rocket damage";
								}
								case 1549:
								{
									return "13% increased ranged critical strike chance";
								}
								case 1550:
								{
									return "7% increased ranged critical strike chance";
								}
								case 1551:
								{
									return "Converts Chlorophyte Bars into Shroomite Bars";
								}
								case 1553:
								{
									return "50% chance to not consume ammo";
								}
								case 1554:
								case 1555:
								case 1556:
								case 1557:
								case 1558:
								case 1559:
								case 1560:
								case 1561:
								case 1562:
								case 1563:
								case 1564:
								case 1565:
								case 1566:
								case 1567:
								case 1568:
								case 1580:
								case 1581:
								case 1582:
								case 1583:
								case 1584:
								case 1585:
								case 1586:
								case 1587:
								case 1588:
								{
									break;
								}
								case 1569:
								{
									return "Rapidly throw life stealing daggers";
								}
								case 1571:
								{
									return "A powerful javelin that unleashes tiny eaters";
								}
								case 1572:
								{
									return "Summons a powerful frost hydra to spit ice at your enemies";
								}
								case 1578:
								{
									return "Releases bees and increases movement speed when damaged";
								}
								case 1579:
								{
									return "The wearer can run super fast";
								}
								case 1595:
								{
									return "Increases maximum mana by 20";
								}
								case 1612:
								{
									return "Grants immunity to most debuffs";
								}
								case 1613:
								{
									return "Grants immunity to knockback and fire blocks";
								}
								default:
								{
									if (num == 1724)
									{
										return "Allows the holder to double jump";
									}
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							}
						}
					}
					else if (num > 1837)
					{
						switch (num)
						{
							case 1844:
							{
								return "Summons the Pumpkin Moon";
							}
							case 1845:
							{
								return "Increases your max number of minions";
							}
							default:
							{
								switch (num)
								{
									case 1858:
									{
										return "Increases view range for guns (right click to zoom out)";
									}
									case 1859:
									case 1867:
									case 1868:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 1860:
									{
										return "Grants the ability to swim and greatly extends underwater breathing";
									}
									case 1861:
									{
										return "Grants the ability to swim and greatly extends underwater breathing";
									}
									case 1862:
									{
										return "Allows flight, super fast running, and extra mobility on ice";
									}
									case 1863:
									{
										return "Allows the holder to double jump";
									}
									case 1864:
									{
										return "Increases your max number of minions";
									}
									case 1865:
									{
										return "Minor increase to damage, melee speed, critical strike chance,";
									}
									case 1866:
									{
										return "Allows flight and slow fall";
									}
									case 1869:
									{
										return "Right click to open";
									}
									case 1870:
									{
										return "'Don't shoot your eye out!'";
									}
									case 1871:
									{
										return "Allows flight and slow fall";
									}
									default:
									{
										switch (num)
										{
											case 1910:
											{
												return "Uses gel for ammo";
											}
											case 1911:
											{
												return "Minor improvements to all stats";
											}
											case 1912:
											case 1913:
											case 1915:
											case 1916:
											case 1918:
											case 1924:
											case 1925:
											case 1926:
											{
												if (english || Lang.lang <= 1)
												{
													return "";
												}
												return Lang.toolTip(l, true);
											}
											case 1914:
											{
												return "Summons a rideable reindeer";
											}
											case 1917:
											{
												return "Can mine Meteorite";
											}
											case 1919:
											{
												return "Minor improvements to all stats";
											}
											case 1920:
											{
												return "Minor improvements to all stats";
											}
											case 1921:
											{
												return "Provides immunity to chill and freezing effects";
											}
											case 1922:
											{
												return "'You've been naughty this year'";
											}
											case 1923:
											{
												return "Increases item placement and tool range by 1";
											}
											case 1927:
											{
												return "Summons a Puppy";
											}
											case 1928:
											{
												return "Shoots Christmas ornaments";
											}
											case 1929:
											{
												return "50% chance to not consume ammo";
											}
											case 1930:
											{
												return "Shoots razor sharp pine needles";
											}
											case 1931:
											{
												return "Showers an area with icicles";
											}
											default:
											{
												if (english || Lang.lang <= 1)
												{
													return "";
												}
												return Lang.toolTip(l, true);
											}
										}
									}
								}
							}
						}
					}
					else
					{
						switch (num)
						{
							case 1826:
							{
								return "Summons Pumpkin heads to attack your enemies";
							}
							case 1827:
							case 1828:
							case 1829:
							case 1831:
							{
								if (english || Lang.lang <= 1)
								{
									return "";
								}
								return Lang.toolTip(l, true);
							}
							case 1830:
							{
								return "Allows flight and slow fall";
							}
							case 1832:
							{
								return "Increases your max number of minions";
							}
							case 1833:
							{
								return "Increases your max number of minions";
							}
							case 1834:
							{
								return "Increases your max number of minions";
							}
							default:
							{
								if (num == 1837)
								{
									return "Summons a cursed sapling to follow you";
								}
								if (english || Lang.lang <= 1)
								{
									return "";
								}
								return Lang.toolTip(l, true);
							}
						}
					}
				}
				else if (num <= 2223)
				{
					if (num > 1959)
					{
						if (num == 1988)
						{
							return "'Fezzes are cool'";
						}
						switch (num)
						{
							case 2172:
							{
								return "Used for advanced crafting";
							}
							case 2173:
							case 2174:
							case 2175:
							case 2176:
							case 2178:
							case 2179:
							case 2180:
							case 2181:
							case 2182:
							case 2183:
							case 2184:
							case 2185:
							case 2186:
							case 2187:
							case 2190:
							case 2191:
							{
								if (english || Lang.lang <= 1)
								{
									return "";
								}
								return Lang.toolTip(l, true);
							}
							case 2177:
							{
								return "Reduces ammo usage by 20%";
							}
							case 2188:
							{
								return "Shoots a venom fang that pierces multiple enemies";
							}
							case 2189:
							{
								return "Increases maximum mana by 60 and reduces mana usage by 13%";
							}
							case 2192:
							{
								return "Used for special crafting";
							}
							case 2193:
							{
								return "Used for special crafting";
							}
							case 2194:
							{
								return "Used for special crafting";
							}
							case 2195:
							{
								return "Used for special crafting";
							}
							case 2196:
							{
								return "Used for special crafting";
							}
							case 2197:
							{
								return "Used for special crafting";
							}
							case 2198:
							{
								return "Used for special crafting";
							}
							case 2199:
							{
								return "6% increased melee damage";
							}
							case 2200:
							{
								return "8% increased melee damage and critical strike chance";
							}
							case 2201:
							{
								return "5% increased melee damage and critical strike chance";
							}
							case 2202:
							{
								return "6% increased movement and melee speed";
							}
							case 2203:
							{
								return "Used for special crafting";
							}
							case 2204:
							{
								return "Used for special crafting";
							}
							default:
							{
								switch (num)
								{
									case 2214:
									{
										return "Increases tile placement speed";
									}
									case 2215:
									{
										return "Increases tile reach";
									}
									case 2216:
									{
										return "Automatically paints placed objects";
									}
									case 2217:
									{
										return "Increases wall placement speed";
									}
									case 2218:
									case 2222:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
									case 2219:
									{
										return "Increases pickup range for mana stars";
									}
									case 2220:
									{
										return "Increases pickup range for mana stars";
									}
									case 2221:
									{
										return "Increases pickup range for mana stars";
									}
									case 2223:
									{
										return "Shoots a charged arrow";
									}
									default:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
								}
							}
						}
					}
					else
					{
						switch (num)
						{
							case 1946:
							{
								return "Launches homing missiles";
							}
							case 1947:
							{
								return "Shoots an icy spear that rains snowflakes";
							}
							default:
							{
								switch (num)
								{
									case 1958:
									{
										return "Summons the Frost Moon";
									}
									case 1959:
									{
										return "Summons a Baby Grinch";
									}
									default:
									{
										if (english || Lang.lang <= 1)
										{
											return "";
										}
										return Lang.toolTip(l, true);
									}
								}
							}
						}
					}
				}
				else if (num > 2375)
				{
					switch (num)
					{
						case 2420:
						{
							return "Summons a pet Zephyr Fish";
						}
						case 2421:
						case 2422:
						case 2424:
						{
							if (english || Lang.lang <= 1)
							{
								return "";
							}
							return Lang.toolTip(l, true);
						}
						case 2423:
						{
							return "Increases jump speed and allows auto-jump";
						}
						case 2425:
						{
							return "Minor improvements to all stats";
						}
						case 2426:
						{
							return "Minor improvements to all stats";
						}
						case 2427:
						{
							return "Minor improvements to all stats";
						}
						case 2428:
						{
							return "Summons a rideable Bunny mount";
						}
						case 2429:
						{
							return "Summons a rideable Pigron mount";
						}
						case 2430:
						{
							return "Summons a rideable Slime mount";
						}
						default:
						{
							switch (num)
							{
								case 2491:
								{
									return "Summons a rideable Turtle mount";
								}
								case 2492:
								{
									return "Not for use on slopes";
								}
								case 2493:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 2494:
								{
									return "Allows flight and slow fall";
								}
								default:
								{
									if (num == 2502)
									{
										return "Summons a rideable Bee mount";
									}
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							}
						}
					}
				}
				else
				{
					switch (num)
					{
						case 2267:
						{
							return "Minor improvements to all stats";
						}
						case 2268:
						{
							return "Minor improvements to all stats";
						}
						case 2269:
						case 2271:
						case 2273:
						case 2274:
						case 2276:
						case 2278:
						{
							if (english || Lang.lang <= 1)
							{
								return "";
							}
							return Lang.toolTip(l, true);
						}
						case 2270:
						{
							return "50% chance to not consume ammo";
						}
						case 2272:
						{
							return "Squirts a harmless stream of water";
						}
						case 2275:
						{
							return "7% increased magic damage and critical strike chance";
						}
						case 2277:
						{
							return "5% increased damage and critical strike chance";
						}
						case 2279:
						{
							return "6% increased magic damage and critical strike chance";
						}
						case 2280:
						{
							return "Allows flight and slow fall";
						}
						default:
						{
							switch (num)
							{
								case 2302:
								{
									return "'It's colorful scales could sell well.'";
								}
								case 2303:
								case 2304:
								case 2305:
								case 2306:
								case 2307:
								case 2309:
								case 2310:
								case 2311:
								case 2312:
								case 2313:
								case 2314:
								case 2315:
								case 2316:
								case 2317:
								case 2318:
								case 2319:
								case 2320:
								case 2321:
								case 2330:
								case 2331:
								case 2332:
								case 2333:
								case 2337:
								case 2338:
								case 2339:
								case 2341:
								case 2342:
								case 2357:
								case 2358:
								case 2360:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
								case 2308:
								{
									return "Quite shiny.  This will probably sell well.";
								}
								case 2322:
								{
									return "Increases mining speed by 25%";
								}
								case 2323:
								{
									return "Increases pickup range for life hearts";
								}
								case 2324:
								{
									return "Reduces enemy aggression";
								}
								case 2325:
								{
									return "Increases placement speed and range";
								}
								case 2326:
								{
									return "Increases knockback";
								}
								case 2327:
								{
									return "Lets you move swiftly in liquids";
								}
								case 2328:
								{
									return "Increases your max number of minions";
								}
								case 2329:
								{
									return "Allows you to see nearby danger sources";
								}
								case 2334:
								{
									return "Right click to open";
								}
								case 2335:
								{
									return "Right click to open";
								}
								case 2336:
								{
									return "Right click to open";
								}
								case 2340:
								{
									return "Hammer end piece to change bumper style";
								}
								case 2343:
								{
									return "Let's ride the rails";
								}
								case 2344:
								{
									return "20% chance to not consume ammo";
								}
								case 2345:
								{
									return "Increases max life by 20%";
								}
								case 2346:
								{
									return "Reduces damage taken by 10%";
								}
								case 2347:
								{
									return "Increases critical chance by 10%";
								}
								case 2348:
								{
									return "Ignites nearby enemies";
								}
								case 2349:
								{
									return "Increases damage by 10%";
								}
								case 2350:
								{
									return "Teleports you home";
								}
								case 2351:
								{
									return "Teleports you to a random location";
								}
								case 2352:
								{
									return "Throw this to make someone fall in love";
								}
								case 2353:
								{
									return "Throw this to make someone smell terrible";
								}
								case 2354:
								{
									return "Increases fishing skill";
								}
								case 2355:
								{
									return "Detects hooked fish";
								}
								case 2356:
								{
									return "Increases chance to get a crate";
								}
								case 2359:
								{
									return "Reduces damage from cold sources";
								}
								case 2361:
								{
									return "Increases minion damage by 4%";
								}
								case 2362:
								{
									return "Increases minion damage by 4%";
								}
								case 2363:
								{
									return "Increases minion damage by 5%";
								}
								case 2364:
								{
									return "Summons a hornet to fight for you";
								}
								case 2365:
								{
									return "Summons an imp to fight for you";
								}
								case 2366:
								{
									return "Summons a spider queen to spit eggs at your enemies";
								}
								case 2367:
								{
									return "Increases fishing level";
								}
								case 2368:
								{
									return "Increases fishing level";
								}
								case 2369:
								{
									return "Increases fishing level";
								}
								case 2370:
								{
									return "Increases your max number of minions";
								}
								case 2371:
								{
									return "Increases your max number of minions";
								}
								case 2372:
								{
									return "Increases your max number of minions";
								}
								case 2373:
								{
									return "Fishing line will never break";
								}
								case 2374:
								{
									return "Increases fishing skill";
								}
								case 2375:
								{
									return "Decreases chance of bait consumption";
								}
								default:
								{
									if (english || Lang.lang <= 1)
									{
										return "";
									}
									return Lang.toolTip(l, true);
								}
							}
						}
					}
				}
				return "'Great for impersonating devs!'";
			}
			else if (Lang.lang == 2)
			{
				int num1 = l;
				if (num1 <= 407)
				{
					if (num1 <= 175)
					{
						if (num1 <= 70)
						{
							if (num1 > 29)
							{
								switch (num1)
								{
									case 33:
									{
										return "Wird fuer die Verhuettung von Erz verwendet";
									}
									case 34:
									{
										break;
									}
									case 35:
									{
										return "Wird verwendet, um Items aus Metallbarren herzustellen";
									}
									case 36:
									{
										return "Wird zur einfachen Herstellung verwendet";
									}
									default:
									{
										if (num1 == 43)
										{
											return "Ruft das Auge von Cthulhu herbei";
										}
										switch (num1)
										{
											case 49:
											{
												return "Belebt langsam wieder";
											}
											case 50:
											{
												return "Ein Blick in den Spiegel bringt einen nach Hause zurueck";
											}
											case 53:
											{
												return "Berechtigt den Inhaber zum Doppelsprung";
											}
											case 54:
											{
												return "Der Traeger kann superschnell rennen";
											}
											case 56:
											{
												return "'Durchpulst von dunkler Energie'";
											}
											case 57:
											{
												return "'Durchpulst von dunkler Energie'";
											}
											case 64:
											{
												return "Ruft einen Ekeldorn herbei";
											}
											case 65:
											{
												return "Laesst Sterne vom Himmel regen";
											}
											case 66:
											{
												return "Reinigt das Verderben";
											}
											case 67:
											{
												return "Entfernt den Segen";
											}
											case 68:
											{
												return "'Sieht lecker aus!'";
											}
											case 70:
											{
												return "Ruft den Weltenfresser herbei";
											}
										}
										break;
									}
								}
							}
							else
							{
								if (num1 == 8)
								{
									return "Verstroemt Licht";
								}
								switch (num1)
								{
									case 15:
									{
										return "Zeigt die Zeit an";
									}
									case 16:
									{
										return "Zeigt die Zeit an";
									}
									case 17:
									{
										return "Zeigt die Zeit an";
									}
									case 18:
									{
										return "Zeigt die Tiefe an";
									}
									case 19:
									case 20:
									case 21:
									case 22:
									{
										break;
									}
									case 23:
									{
										return "'Lecker und brennbar'";
									}
									default:
									{
										if (num1 == 29)
										{
											return "Erhoeht dauerhaft die maximale Lebensspanne um 20";
										}
										break;
									}
								}
							}
						}
						else if (num1 > 88)
						{
							switch (num1)
							{
								case 98:
								{
									return "33%ige Chance, Munition nicht zu verbrauchen";
								}
								case 99:
								case 104:
								case 105:
								case 106:
								case 107:
								case 108:
								case 110:
								case 116:
								case 119:
								case 122:
								case 126:
								case 127:
								{
									break;
								}
								case 100:
								{
									return "Um 7% erhoehtes Nahkampftempo";
								}
								case 101:
								{
									return "Um 7% erhoehtes Nahkampftempo";
								}
								case 102:
								{
									return "Um 7% erhoehtes Nahkampftempo";
								}
								case 103:
								{
									return "Kann Hoellenstein abbauen";
								}
								case 109:
								{
									return "Erhoeht maximales Mana um 20";
								}
								case 111:
								{
									return "Erhoeht die maximale Mana um 20";
								}
								case 112:
								{
									return "Schiesst Feuerbaelle ab";
								}
								case 113:
								{
									return "Wirft eine steuerbare Rakete aus";
								}
								case 114:
								{
									return "Bewegt magisch Dreck";
								}
								case 115:
								{
									return "Erschafft eine magische Lichtkugel";
								}
								case 117:
								{
									return "'Fuehlt sich warm an'";
								}
								case 118:
								{
									return "Faellt mitunter von Skeletten und Piranhas herab";
								}
								case 120:
								{
									return "Entfacht lodernde Holzpfeile";
								}
								case 121:
								{
									return "'Ist ganz aus Feuer!'";
								}
								case 123:
								{
									return "Um 5% erhoehter magischer Schaden";
								}
								case 124:
								{
									return "Um 5% erhoehter magischer Schaden";
								}
								case 125:
								{
									return "Um 5% erhoehter magischer Schaden";
								}
								case 128:
								{
									return "Laesst fliegen";
								}
								default:
								{
									switch (num1)
									{
										case 148:
										{
											return "Kann unerwuenschte Aufmerksamkeit erwecken";
										}
										case 149:
										{
											return "'Es enthaelt seltsame Symbole'";
										}
										case 150:
										case 154:
										case 155:
										case 160:
										case 161:
										case 162:
										case 163:
										case 164:
										{
											break;
										}
										case 151:
										{
											return "Um 5% erhoehter Fernkampf-Schaden";
										}
										case 152:
										{
											return "Um 5% erhoehter Fernkampf-Schaden";
										}
										case 153:
										{
											return "Um 5% erhoehter Fernkampf-Schaden";
										}
										case 156:
										{
											return "Macht immun gegen Rueckstoss";
										}
										case 157:
										{
											return "Versprueht eine Wasserdusche";
										}
										case 158:
										{
											return "Hebt Sturzschaden auf";
										}
										case 159:
										{
											return "Vergroessert die Sprunghoehe";
										}
										case 165:
										{
											return "Wirft einen sich langsam bewegenden Wasserbolzen aus";
										}
										case 166:
										{
											return "Eine kleine Explosion, die einige Felder zerstoeren wird";
										}
										case 167:
										{
											return "Eine grosse Explosion, die die meisten Felder zerstoert";
										}
										case 168:
										{
											return "Eine kleine Explosion, die keine Felder zerstoert";
										}
										default:
										{
											if (num1 == 175)
											{
												return "'Heiss, heiss, heiss!'";
											}
											break;
										}
									}
									break;
								}
							}
						}
						else
						{
							if (num1 == 75)
							{
								return "Verschwindet nach Sonnenaufgang";
							}
							if (num1 == 84)
							{
								return "'Komm hier rueber!'";
							}
							if (num1 == 88)
							{
								return "Verstroemt beim Tragen Licht";
							}
						}
					}
					else if (num1 <= 238)
					{
						if (num1 > 197)
						{
							switch (num1)
							{
								case 208:
								{
									return "'Oh, ist die huebsch!'";
								}
								case 209:
								case 210:
								case 214:
								case 216:
								case 217:
								{
									break;
								}
								case 211:
								{
									return "Um 12% erhoehtes Nahkampftempo";
								}
								case 212:
								{
									return "Um 10% erhoehtes Bewegungstempo";
								}
								case 213:
								{
									return "Laesst Gras auf Schmutz wachsen";
								}
								case 215:
								{
									return "'Kann Aerger erregen'";
								}
								case 218:
								{
									return "Ruft einen steuerbaren Feuerball herbei";
								}
								default:
								{
									switch (num1)
									{
										case 222:
										{
											return "Laesst Pflanzen wachsen";
										}
										case 223:
										{
											return "Um 6% reduzierte Mana-Nutzung";
										}
										case 224:
										case 225:
										case 226:
										case 227:
										{
											break;
										}
										case 228:
										{
											return "Erhoeht die maximale Mana um 40";
										}
										case 229:
										{
											return "Erhoeht die maximale Mana um 20";
										}
										case 230:
										{
											return "Erhoeht die maximale Mana um 20";
										}
										default:
										{
											switch (num1)
											{
												case 235:
												{
													return "'Werfen koennte schwierig werden.'";
												}
												case 237:
												{
													return "'Damit siehst du cool aus!'";
												}
												case 238:
												{
													return "Um 15% erhoehter magischer Schaden";
												}
											}
											break;
										}
									}
									break;
								}
							}
						}
						else
						{
							switch (num1)
							{
								case 186:
								{
									return "'Ganz nett, nicht ertrinken zu muessen'";
								}
								case 187:
								{
									return "Befaehigt zum Schwimmen";
								}
								default:
								{
									if (num1 == 193)
									{
										return "Macht immun gegen Feuer-Bloecke";
									}
									if (num1 == 197)
									{
										return "Schiesst Sternschnuppen herunter";
									}
									break;
								}
							}
						}
					}
					else if (num1 > 329)
					{
						if (num1 == 332)
						{
							return "Verwendet fuer die Tuchherstellung ";
						}
						if (num1 == 352)
						{
							return "Zum Bierbrauen";
						}
						switch (num1)
						{
							case 357:
							{
								return "Geringe Anhebung aller Werte";
							}
							case 361:
							{
								return "Ruft eine Goblin-Armee herbei";
							}
							case 363:
							{
								return "Fuer fortgeschrittene Holzherstellung";
							}
							case 367:
							{
								return "Stark genug, um Daemonenaltaere zu zerstoeren";
							}
							case 371:
							{
								return "Erhoeht die maximale Mana um 40";
							}
							case 372:
							{
								return "Um 7% erhoehtes Bewegungstempo";
							}
							case 373:
							{
								return "Um 10% erhoehter Fernkampfschaden";
							}
							case 376:
							{
								return "Erhoeht die maximale Mana um 60";
							}
							case 377:
							{
								return "Um 5% erhoehte kritische Nahkampf-Trefferchance";
							}
							case 378:
							{
								return "Um 12% erhoehter Fernkampf-Schaden";
							}
							case 385:
							{
								return "Kann Mithril abbauen";
							}
							case 386:
							{
								return "Kann Adamantit abbauen";
							}
							case 389:
							{
								return "Kann Verwirrung stiften";
							}
							case 393:
							{
								return "Zeigt horizontale Position";
							}
							case 394:
							{
								return "Befaehigt zum Schwimmen";
							}
							case 395:
							{
								return "Zeigt Position an";
							}
							case 396:
							{
								return "Hebt Sturzschaden auf";
							}
							case 397:
							{
								return "Macht immun gegen Rueckstoss";
							}
							case 398:
							{
								return "Ermoeglicht die Kombination von Zubehoer";
							}
							case 399:
							{
								return "Berechtigt den Inhaber zum Doppelsprung";
							}
							case 400:
							{
								return "Erhoeht die maximale Mana um 80";
							}
							case 401:
							{
								return "Um 7% erhoehte kritische Nahkampf-Trefferchance";
							}
							case 402:
							{
								return "Um 14% erhoehter Fernkampfschaden";
							}
							case 403:
							{
								return "Um 6% erhoehter Schaden";
							}
							case 404:
							{
								return "Um 4% erhoehte kritische Trefferchance";
							}
							case 405:
							{
								return "Laesst fliegen";
							}
							case 407:
							{
								return "Erweitert den Platzierbereich von Bloecken";
							}
						}
					}
					else
					{
						switch (num1)
						{
							case 261:
							{
								return "'Er laechelt - vielleicht schmeckt er auch gut...'";
							}
							case 262:
							case 263:
							case 264:
							case 265:
							case 269:
							case 270:
							case 271:
							case 273:
							case 274:
							case 275:
							case 276:
							case 277:
							case 278:
							case 279:
							case 280:
							case 284:
							case 286:
							case 287:
							{
								break;
							}
							case 266:
							{
								return "'Das ist eine gute Idee!'";
							}
							case 267:
							{
								return "'Du bist ein schrecklicher Mensch.'";
							}
							case 268:
							{
								return "Verlaengert das Atmen unter Wasser deutlich";
							}
							case 272:
							{
								return "Wirft eine Daemonensense aus";
							}
							case 281:
							{
								return "Zum Erstellen einer Saatsammlung als Munition";
							}
							case 282:
							{
								return "Funktioniert bei Naesse";
							}
							case 283:
							{
								return "Zur Verwendung im Blasrohr";
							}
							case 285:
							{
								return "Um 5% erhoehtes Bewegungstempo";
							}
							case 288:
							{
								return "Macht immun gegen Lava";
							}
							case 289:
							{
								return "Belebt wieder";
							}
							case 290:
							{
								return "Erhoeht Bewegungstempo um 25%";
							}
							case 291:
							{
								return "Wasser statt Luft atmen";
							}
							case 292:
							{
								return "Erhoeht die Abwehr um 8";
							}
							case 293:
							{
								return "Erhoehte Mana-Wiederherstellung";
							}
							case 294:
							{
								return "Erhoeht magischen Schaden um 20%";
							}
							case 295:
							{
								return "Verlangsamt das Sturztempo";
							}
							case 296:
							{
								return "Zeigt den Fundort von Schatz und Erz";
							}
							case 297:
							{
								return "Macht unsichtbar";
							}
							case 298:
							{
								return "Verstroemt eine Aura aus Licht";
							}
							case 299:
							{
								return "Erhoeht die Nachtsicht";
							}
							case 300:
							{
								return "Erhoeht Feind-Spawnquote";
							}
							case 301:
							{
								return "Auch die Angreifer erleiden Schaden";
							}
							case 302:
							{
								return "Befaehigt, auf dem Wasser zu gehen";
							}
							case 303:
							{
								return "Erhoeht Pfeiltempo und Schaden um 20%";
							}
							case 304:
							{
								return "Zeigt die Position von Feinden";
							}
							case 305:
							{
								return "Zur Steuerung der Schwerkraft";
							}
							default:
							{
								if (num1 == 324)
								{
									return "'An den meisten Orten verboten'";
								}
								switch (num1)
								{
									case 327:
									{
										return "Oeffnet eine Goldtruhe";
									}
									case 329:
									{
										return "Oeffnet alle Schattentruhen";
									}
								}
								break;
							}
						}
					}
				}
				else if (num1 <= 761)
				{
					if (num1 <= 686)
					{
						if (num1 > 603)
						{
							switch (num1)
							{
								case 665:
								{
									return "Sie sollten nicht diese";
								}
								case 666:
								{
									return "Sie sollten nicht diese";
								}
								case 667:
								{
									return "Sie sollten nicht diese";
								}
								case 668:
								{
									return "Sie sollten nicht diese";
								}
								case 669:
								{
									return "Beschwört einen Baby-Pinguin";
								}
								default:
								{
									if (num1 == 676)
									{
										return "Schießt ein eisiger Bolzen";
									}
									switch (num1)
									{
										case 683:
										{
											return "Summons des Teufels Dreizack";
										}
										case 684:
										{
											return "16% erhöht Nahkampf-und Fernkampf Schaden";
										}
										case 685:
										{
											return "11% erhöht Nahkampf-und Fernkampf kritische Trefferchance";
										}
										case 686:
										{
											return "8% erhöht Bewegungsgeschwindigkeit";
										}
									}
									break;
								}
							}
						}
						else
						{
							switch (num1)
							{
								case 422:
								{
									return "Verspritzt Segen auf einige Bloecke";
								}
								case 423:
								{
									return "Verteilt Verderben auf einige Bloecke";
								}
								case 424:
								{
									break;
								}
								case 425:
								{
									return "Ruft eine magische Fee herbei";
								}
								default:
								{
									if (num1 == 434)
									{
										return "Dreifachschuss";
									}
									switch (num1)
									{
										case 485:
										{
											return "Verwandelt den Inhaber bei Vollmond in einen Werwolf";
										}
										case 486:
										{
											return "Erstellt ein Raster auf dem Bildschirm zum Platzieren der Bloecke";
										}
										case 489:
										{
											return "Um 15% erhoehter magischer Schaden";
										}
										case 490:
										{
											return "Um 15% erhoehter Nahkampfschaden";
										}
			}