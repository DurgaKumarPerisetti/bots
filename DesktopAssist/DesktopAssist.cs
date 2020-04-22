using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Tasks;


namespace DesktopAssist
{
    public class DesktopAssist : IBot
    {
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {

            await turnContext.SendActivityAsync("Hello Team i am your bot waiting for our orders to follow. Please can you try to invoke me with cortana");
            await turnContext.SendActivityAsync("Type info to know more about me");
            await turnContext.SendActivityAsync("Type help to learn abot me");

            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                string userInput = turnContext.Activity.Text;
                switch (userInput)
                {
                    case "help":
                        await turnContext.SendActivityAsync("I wont tell anything..!");
                        break;
                    case "info" :
                     await turnContext.SendActivityAsync("Google it dude!  ");
                        break;
                    default:
                        await turnContext.SendActivityAsync($"You wrote {userInput}");
                        break;
                }
               
            }

        }

          
    }
}
