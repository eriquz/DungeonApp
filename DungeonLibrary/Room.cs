using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Room
    {
        public static string GetRoom()
        {
            string[] rooms =
            {
                "Neither light nor darkvision can penetrate the gloom in this chamber. An unnatural shade fills it, and the room's farthest reaches are barely visible. Near the room's center, you can just barely perceive a lump about the size of a human lying on the floor. (It might be a dead body, a pile of rags, or a sleeping monster that can take advantage of the room's darkness.)",

                "This room smells strange, no doubt due to the weird sheets of black slime that drip from cracks in the ceiling and spread across the floor. The slime seeps from the shattered stone of the ceiling at a snails crawl, forming a mess of dangling walls of gook. As you watch, a bit of the stuff separates from a sheet and drops to the ground with a wet plop.",

                "A pungent, earthy odor greets you as you pull open the door and peer into this room. Mushrooms grow in clusters of hundreds all over the floor. Looking into the room is like looking down on a forest. Tall tangles of fungus resemble forested hills, the barren floor looks like a plain between the woods, and even a trickle of water and a puddle of water that pools in a low spot bears a resemblance to a river and lake, respectively.",

                "This small chamber is a bloody mess. The corpse of a minotaur lies on the floor, its belly carved out. The creature's innards are largely missing, and yet you detect no other wounds. Bloody, froglike footprints track away from the corpse and out an open door.",

                "Stinking smoke wafts up from braziers made of skulls set around the edges of this room. The walls bear scratch marks and lines of soot that form crude pictures and what looks like words in some language [Goblin]. To the left lies a pile of rubbish and rubble heaped into a crude dais. The dais has upon it an ironbound chest that has been painted with a goblinlike face. Furs and skins of unknown origin are strewn haphazardly about the floor before the dais.",

                "A skeleton dressed in moth-eaten garb lies before a large open chest in the rear of this chamber. The chest is empty, but you note two needles projecting from the now-open lock. Dust coats something sticky on the needles' points.",

                " A flurry of bats suddenly flaps through the doorway, their screeching barely audible as they careen past your heads. They flap past you into the rooms and halls beyond. The room from which they came seems barren at first glance.",

                "The scent of earthy decay assaults your nose upon peering through the open door to this room. Smashed bookcases and their sundered contents litter the floor. Paper rots in mold-spotted heaps, and shattered wood grows white fungus.",

                "Burning torches in iron sconces line the walls of this room, lighting it brilliantly. At the room's center lies a squat stone altar, its top covered in recently spilled blood. A channel in the altar funnels the blood down its side to the floor where it fills grooves in the floor that trace some kind of pattern or symbol around the altar. Unfortunately, you can't tell what it is from your vantage point.",

                "This room looks like it was designed by drow. Rusted metal tiles create a huge mosaic of a spider in the floor, and someone set up rusted gratings like draperies of webs. At the far end of the chamber, the carving of a spider squats on the floor. It's about 3 feet tall and seems molded into the floor. Beyond it stands tall double doors of stone, their surface covered in a glittering web of gold.",

                "You open the door to reveal a 10-foot-by-10-foot room with a floor studded with spikes. The bones of some creature lie among the spikes and some insects scuttle away from the desiccated remains. No other doors are in the room, and it appears the door you opened was created to blend in with the walls. Additionally, you see no ceiling. You must be at the bottom of a very deep spiked pit.",

                "A chill wind blows against you as you open the door. Beyond it, you see that the floor and ceiling are nothing but iron grates. Above and below the grates the walls extend up and down with no true ceiling or floor within your range of vision. It's as though the chamber is a bridge through the shaft of a great well. Standing on the edge of this shaft, you feel a chill wind pass down it and over your shoulder into the hall beyond.",

                "You catch a whiff of the unmistakable metallic tang of blood as you open the door. The floor is covered with it, and splashes of blood spatter the walls. Some drops even reach the ceiling. It looks fresh, but you don't see any bodies or footprints leaving the chamber.",

                "This chamber is clearly a prison. Small barred cells line the walls, leaving a 15-foot-wide pathway for a guard to walk. Channels run down either side of the path next to the cages, probably to allow the prisoners' waste to flow through the grates on the other side of the room. The cells appear empty but your vantage point doesn't allow you to see the full extent of them all.",

                "This hall is choked with corpses. The bodies of orcs and ogres lie in tangled heaps where they died, and the floor is sticky with dried blood. It looks like the orcs and ogres were fighting. Some side was the victor but you're not sure which one. The bodies are largely stripped of valuables, but a few broken weapons jut from the slain or lie discarded on the floor."
            };

            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }
    }//end class
}//end namespace
