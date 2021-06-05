using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace Progra1Bot.Clases
{
    public class clsmensajes
    {
        public static string smile = "\uD83D\uDE01";
        public static string mano = "\u270B";
        public static string saludo = "\uD83D\uDC4B";
        public static string correo = "\uD83D\uDCE8";
        public static string telefono = "\uD83D\uDCDE";
        public static string carapensante = "\uD83E\uDD14";
        public static string caralentesoscuros = "\uD83D\uDE0E";
        public static string nerd1 = "\u0001F913";
        public static string nerd = "\uFE0F";
        public static string pulgarAbajo = "\ud83d\udc4e";   //D83D DC4E
        public static string sorprendido = "\ud83d\ude31";
        private static TelegramBotClient Bot;

        public async Task IniciarTelegram()
        {
            Bot = new TelegramBotClient("1751470325:AAHZrPaFukVv5gnCHYUPPCEZFF1wiVDyWRs");

            var me = await Bot.GetMeAsync();
            Console.Title = me.Username;

            Bot.OnMessage += BotCuandoRecibeMensajes;
            Bot.OnMessageEdited += BotCuandoRecibeMensajes;
            Bot.OnReceiveError += BotOnReceiveError;

            Bot.StartReceiving(Array.Empty<UpdateType>());

            Console.WriteLine($"escuchando solicitudes del BOT @{me.Username}");

            Console.ReadLine();
            Bot.StopReceiving();
        }

        // cuando recibe mensajes
        

        private static async void BotCuandoRecibeMensajes(object sender, MessageEventArgs messageEventArgumentos)
        {

           

            var ObjetoMensajeTelegram = messageEventArgumentos;
            var mensajes = ObjetoMensajeTelegram.Message;

           /* var ObjetoMensajeTelegra = messageEventArgumentos;
            var men = ObjetoMensajeTelegram.Message;
            string mensajeEntrante = mensajes.Text;*/

           

            string respuesta = $"seguí los pasos correctamente para ayudarte{smile}";
            if (mensajes == null || mensajes.Type != MessageType.Text)
                return;

            Console.WriteLine($"Recibiendo Mensaje del chat {ObjetoMensajeTelegram.Message.Chat.Id}.");
            Console.WriteLine($"Dice {ObjetoMensajeTelegram.Message.Text}.");

            string cliente = ObjetoMensajeTelegram.Message.Text;
            string tarjeta = ObjetoMensajeTelegram.Message.Text;
            //tolower
            if (mensajes.Text.ToLower().Contains("/start"))
            {
                respuesta = $"que onda{saludo} mucho gusto, mandame tu tarjeta de credito o debito y tu nombre porfa para hacer la compra";


            }
          

            if (mensajes.Text.ToLower().Contains("consulta") )
            {
               
                 respuesta = $"{smile} es un gusto saludarte\n opción  que desea ver:\n\n1.planes de internet\n\n2.planes de saldo";
                clscliente propietario = new clscliente();
                propietario.consultas = mensajes.Text;


                int resultado = clsprodal.agregar(propietario);
            }
            

            if (mensajes.Text.Contains("1"))
            {
                respuesta = "3. 200MB por 2 días a Q5.00\n\n4. 350MB por 3 días a Q10.00";
                
            }
                   if (mensajes.Text.Contains("3"))
                {
                    respuesta = "tu recarga se está procesando con exito...";
                clscliente propietario = new clscliente();
                propietario.recargas = mensajes.Text;


                int resultado = clsprodal.agregar(propietario);
            }
                   else if (mensajes.Text.Contains("4"))
                {
                    respuesta = "tu recarga se está procesando con exito...";
                clscliente propietario = new clscliente();
                propietario.recargas = mensajes.Text;


                int resultado = clsprodal.agregar(propietario);

            }
            
           


                //en poner no es igual


                if (mensajes.Text.Contains("2"))
                {
                    respuesta = "3. 60 minutos de llamada por Q5.00\n\n4. 2 días de llamadas a toda guate y U.S.A por Q 20.00";

                    if (mensajes.Text.Contains("3"))
                    {
                        respuesta = "tu recarga se está procesando con exito...";
                    clscliente propietario = new clscliente();
                    propietario.recargas = mensajes.Text;


                    int resultado = clsprodal.agregar(propietario);
                }
                    if (mensajes.Text.Contains("4"))
                    {
                        respuesta = "tu recarga se está procesando con exito...";
                    clscliente propietario = new clscliente();
                    propietario.recargas = mensajes.Text;


                    int resultado = clsprodal.agregar(propietario);

                }
                }

           




            if (!String.IsNullOrEmpty(respuesta))
            {
                await Bot.SendTextMessageAsync(
                    chatId: ObjetoMensajeTelegram.Message.Chat,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown,
                    text: respuesta);
            }
        }



        // fin del metodo de recepcion de mensajes



        // Process Inline Keyboard callback data
        private static async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            var callbackQuery = callbackQueryEventArgs.CallbackQuery;

            await Bot.SendTextMessageAsync(
                chatId: callbackQuery.Message.Chat.Id,
                text: $"Received {callbackQuery.Data}"
               
            ) ;
        }





        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
            {
                Console.WriteLine("UPS!!! Recibo un error!!!: {0} — {1}",
                    receiveErrorEventArgs.ApiRequestException.ErrorCode,
                    receiveErrorEventArgs.ApiRequestException.Message
                );
            }

       
        }

    }
    
