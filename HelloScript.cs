using System;
using UnityEngine;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Chat;
using System.Collections.Generic;

namespace Sample
{
    public class CommandHello : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "hello";

        public string Help => "A sample command";
        
        public string Syntax => "<player>";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "myplugin.permission" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedChat.Say("Hello!");
        }
    }
}
