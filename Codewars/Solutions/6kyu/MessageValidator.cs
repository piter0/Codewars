using System;
using System.Linq;

namespace Codewars.Solutions._6kyu
{
    public class MessageValidator
    {
        public bool IsAValidMessage(string message)
        {

            if (message.Length > 0)
            {
                if (!char.IsDigit(message[0]) || char.IsDigit(message[^1]))
                {
                    return false;
                }

                for (var i = 0; i < message.Length; i++)
                {
                    var num = message.TakeWhile(d => char.IsDigit(d));
                    var msg = message[num.Count()..].TakeWhile(c => char.IsLetter(c));

                    if (msg.Count() != Convert.ToInt32(message[..num.Count()]))
                    {
                        return false;
                    }

                    message = message[(msg.Count() + num.Count())..];
                }
            }

            return true;
        }
    }
}
