﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PureMVC.Core;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using PureMVC.Patterns.Command;
using PureMVC.Patterns.Facade;
using PureMVC.Patterns.Mediator;
using PureMVC.Patterns.Observer;
using PureMVC.Patterns.Proxy;

namespace PureMVC.Tutorial
{
    public static class Notification
    {
        //*********************【Framework】*********************
        public const string StartUp = "StartUp";
        public const string GameStart = "GameStart";

        //*********************【Global】*********************
         public const string CostCupCommond = "ConstCupCommond";

        //*********************【SettingPanel】*********************
        public const string SettingToHomeCommond = "SettingToHomeCommond";

        //*********************【HomePanel】*********************
        public const string OpenHomePanel = "OpenHomePanel";
        public const string CloseHomePanel = "CloseHomePanel";
        public const string HomeToStoreCommond = "HomeToStoreCommond";
        public const string HomeToSettingCommond = "HomeToSettingCommond";

        //*********************【CurrencyPanel】*********************
        public const string ChangeGlodCup = "ChangeGlodCup";
        public const string ChangeSilverCup = "ChangeSilverCup";
        public const string ChangeBronzeCup = "ChangeBronzeCup";
        public const string ChangeCurrencyData = "ChangeCurrencyData";
        public const string CloseCurrencyPanel = "CloseCurrencyPanel";

        //*********************【VirtualNetServer】*********************
        public const string GetGlobalData = "GetGlobalData";

        //*********************【StorePanel】*********************
        public const string ColdTheme = "ColdTheme";
        public const string WarmTheme = "WarmTheme";
        public const string StoreToHomeCommond = "StoreToHomeCommond";

    }
}
