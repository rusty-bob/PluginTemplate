﻿using ExileCore2.Shared.Interfaces;
using ExileCore2.Shared.Nodes;

namespace Plugin_Name;

public class Plugin_NameSettings : ISettings
{
    //Mandatory setting to allow enabling/disabling your plugin
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    //Put all your settings here if you can.
    //There's a bunch of ready-made setting nodes,
    //nested menu support and even custom callbacks are supported.
    //If you want to override DrawSettings instead, you better have a very good reason.
}