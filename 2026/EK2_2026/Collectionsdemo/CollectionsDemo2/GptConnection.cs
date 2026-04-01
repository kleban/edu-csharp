using System;
using System.Collections.Generic;
using System.Text;
using OpenAI.Chat;

namespace CollectionsDemo2
{    
    public class OpenAIChatClient
    {
        private readonly ChatClient _client;
        private readonly List<ChatMessage> _history = new();

        public OpenAIChatClient(string apiKey, string model = "gpt-5.4")
        {
            _client = new ChatClient(model, apiKey);
        }

        public async Task<string> SendMessageAsync(string userMessage)
        {
            _history.Add(new UserChatMessage(userMessage));

            ChatCompletion response = await _client.CompleteChatAsync(_history);
            string reply = response.Content[0].Text;

            _history.Add(new AssistantChatMessage(reply));

            return reply;
        }

        public void ClearHistory() => _history.Clear();
    }
}
