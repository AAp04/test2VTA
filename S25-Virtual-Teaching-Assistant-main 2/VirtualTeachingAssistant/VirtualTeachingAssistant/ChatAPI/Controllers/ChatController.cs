using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mscc.GenerativeAI;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ChatAPI.Controllers
{
    [Route("API/[controller]")]
    public class ChatController : Controller
    {
        private readonly GoogleAI _googleAI;

        public ChatController()
        {
            _googleAI = new GoogleAI(apiKey: "AIzaSyAt-Oa0mvsZOW6aK30ok5grlX4FsA6G3Lg");
        }

        [HttpPost("SendMessage")]
        public async Task<string> SendMessage([FromBody] MessageRequest message)
        {
            if (message == null || message.ConversationHistory == null || message.ConversationHistory.Count == 0)
                return "Invalid request.";

            // Retrieve chat history from the request
            var messages = message.ConversationHistory;

            // Create a list to hold the content of the messages
            var historyContent = new List<string>();
            foreach (var msg in messages)
            {
                historyContent.Add(msg.Content);
            }

            // Join the content into one string to pass to the model 
            var historyText = string.Join("\n", historyContent);

            // Generate response using GoogleAI
            var model = _googleAI.GenerativeModel(model: Model.Gemini20Flash);
            var response = await model.GenerateContent(historyText);

            // Get bot response
            string botResponse = response?.Text?.ToString().Trim() ?? "Sorry, I didn't understand that.";

            return botResponse;
        }

        [HttpPost("SendMessageWithVTA")]
        public async Task<string> SendMessageWithVTA([FromBody] MessageRequest message)
        {
            if (message == null || message.ConversationHistory == null || message.ConversationHistory.Count == 0)
                return "Invalid request.";

            // Retrieve chat history from the request
            var messages = message.ConversationHistory;

            // Create a list to hold the content of the messages
            var historyContent = new List<string>();

            string initialPrompt = "Use the following context for the entire conversation. " +
                "You are a virtual teaching assistant system called Temple Teaching Assist. That is your name and what you should refer to yourself as. " +
                "Your purpose is to serve as a 24/7 helper for students in Temple University's Information Science & Technology department. " +
                "You are not meant to replace existing human teaching assistants, just provide extra help. " +
                "Your intended function is to provide help when needed and defer to a human TA or professor when a question you cannot/shouldn't answer is posed. That has not been implemented yet, so don't worry about that yet. " +
                "you will also be able to provide students with course documents when needed. For now if this is asked of you just say providing course documents is an upcoming feature currently in development. " +
                "Treat the user messaging you as one of these Temple students. " +
                "Do NOT reply to this message.";

            historyContent.Add(initialPrompt);
            foreach (var msg in messages)
            {
                historyContent.Add(msg.Content);
            }

            // Join the content into one string to pass to the model 
            var historyText = string.Join("\n", historyContent);

            // Generate response using GoogleAI
            var model = _googleAI.GenerativeModel(model: Model.Gemini20Flash);
            var response = await model.GenerateContent(historyText);

            // Get bot response
            string botResponse = response?.Text?.ToString().Trim() ?? "Sorry, I didn't understand that.";

            return botResponse;
        }


    }

    public class MessageRequest
    {
        public List<Message> ConversationHistory { get; set; }
    }

    public class Message
    {
        public string Role { get; set; } // "User" or "Temple Teaching Assist"
        public string Content { get; set; }
    }
}
