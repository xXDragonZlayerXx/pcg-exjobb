﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaveGeneration.Models
{
    public enum Action
    {
        MoveLeft,
        MoveRight,
        MoveUp
    }

    public class Input
    {
        public static List<Action> GetInput()
        {
            List<Action> Actions = new List<Action>();
            KeyboardState kbState = Keyboard.GetState();

            GamePadState gpState = GamePad.GetState(PlayerIndex.One);

            if (kbState.IsKeyDown(Keys.Left) || gpState.IsButtonDown(Buttons.DPadLeft)) { Actions.Add(Action.MoveLeft); }
            if (kbState.IsKeyDown(Keys.Right) || gpState.IsButtonDown(Buttons.DPadRight)) { Actions.Add(Action.MoveRight); }
            if ((kbState.IsKeyDown(Keys.Space) || kbState.IsKeyDown(Keys.Up) || gpState.IsButtonDown(Buttons.DPadUp) || gpState.IsButtonDown(Buttons.A))) { Actions.Add(Action.MoveUp); }

            return Actions;
        }
       
    }
}
