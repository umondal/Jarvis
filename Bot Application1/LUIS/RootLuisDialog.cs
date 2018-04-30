using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Threading.Tasks;

namespace Bot_Application1.LUIS
{
    [LuisModel("5394d889-b0b2-45b6-bb0a-be56df3be465", "fec276fd527b430bab0e20f8316baa46", domain: "https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/5394d889-b0b2-45b6-bb0a-be56df3be465?subscription-key=fec276fd527b430bab0e20f8316baa46&timezoneOffset=0&verbose=true&q=")]
    [Serializable]
    public class RootLuisDialog : LuisDialog<object>
    {
        [LuisIntent("greetings")]
        public async Task GreetingIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Welcome back!");
            context.Wait(MessageReceived);
        }
    }
}