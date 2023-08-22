using Telegram.Bot;
using Telegram.Bot.Types;

namespace BotTelegram.Controllers
{
    public class DefaultMessageController
    {
        private readonly ITelegramBotClient _telegramBot;
        public DefaultMessageController(ITelegramBotClient telegramBot)
        {
            _telegramBot = telegramBot;
        }
        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            await _telegramBot.SendTextMessageAsync(message.Chat.Id, $"Получено сообщение не поддерживаемого формата", cancellationToken: ct);
        }
    }
}
