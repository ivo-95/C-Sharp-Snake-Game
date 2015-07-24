﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    class input
    {
        //available keyboard buttons
        private static Hashtable keyTable = new Hashtable();

        //check whether a particular key is pressed:
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool) keyTable[key];
        }

        //check if a button is pressed:
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
