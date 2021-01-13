using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections; // The Hashtable is in the collections class
using System.Windows.Forms; // The keys are in the Forms Class

namespace SnakeGame
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();
        // we are creating a new instance of Hashtable class
        // this class is used to optimize the keys inserted in it

        public static bool KeyPress(Keys key)
        {
            // this function will return a key back to the class

            if (keyTable[key] == null)
            {
                // if the hashtable is empty then we return flase
                return false;
            }
            // if the hastable is not empty then we return true
            return (bool)keyTable[key];
        }

        public static void changeState(Keys key, bool state)
        {
            // this function will change state of the keys and the player with it
            // this function has two arguments Key and state
            keyTable[key] = state;
        }

    }
}
