using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTAModelLibrary
{
    public class MessageRequest
    {
        public string UserInput;

        public MessageRequest()
        {
            UserInput = string.Empty;
        }
        public MessageRequest(string userInput)
        {
            UserInput = userInput;
        }
    }
}
