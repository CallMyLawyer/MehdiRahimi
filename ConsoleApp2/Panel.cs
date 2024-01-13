using NetTelegramBotApi;
using NetTelegramBotApi.Requests;
using NetTelegramBotApi.Types;

namespace ConsoleApp2;

class Panel
{
    private static string Token = "6753556356:AAEMxHu0kxIEf-9q2MJe9y4GMZrM9ymPRnc";
    private static ReplyKeyboardMarkup _menu = new();

    static void Menu()
    {
        _menu.ResizeKeyboard = true;
        _menu.Keyboard =
            new KeyboardButton[][]
            {
                new KeyboardButton[]
                {
                    new KeyboardButton("Add New User"),
                    new KeyboardButton("Show User Detail"),
                    new KeyboardButton("ShowDaraiiNezami"),
                },
                new KeyboardButton[] { new KeyboardButton("back") }

            };
    }
    Task.Run(() => RunBot());
    Console.ReadLine();
    public static async Task RunBot()
    {
        var bot = new TelegramBot(Token);
        var me = await bot.MakeRequestAsync(new GetMe());
        Console.WriteLine();
        var updates = await bot.MakeRequestAsync(new GetUpdates());
        await bot.MakeRequestAsync(req);
        var text = item.Message.Chat.Id;
        req = new SendMessage(item.Message.Chat.Id,"mio"{ReplyMarkup = _menu});
    }
}