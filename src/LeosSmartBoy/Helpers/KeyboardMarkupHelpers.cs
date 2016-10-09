﻿using System.Collections.Generic;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace LeosSmartBoy.Helpers
{
    public class KeyboardMarkupHelpers
    {
        public static InlineKeyboardMarkup CreateDigitInlineKeyboardMarkup(string callbackId)
        {
            var buttons = new List<InlineKeyboardButton[]>();
            for (var row = 0; row < 3; row++)
            {
                var rowButtons = new List<InlineKeyboardButton>();
                for (var col = 0; col < 3; col++)
                {
                    rowButtons.Add(new InlineKeyboardButton((row * 3 + col + 1).ToString(), callbackId));
                }
                buttons.Add(rowButtons.ToArray());
            }
            buttons.Add(new []
            {
                new InlineKeyboardButton("0", callbackId), 
                new InlineKeyboardButton(".", callbackId), 
                new InlineKeyboardButton("OK", callbackId), 
            });
            return new InlineKeyboardMarkup(buttons.ToArray());
        }
    }
}