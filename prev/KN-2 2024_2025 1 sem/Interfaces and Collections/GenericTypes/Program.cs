using GenericTypes;

Queue<Message> messages = new Queue<Message>();
messages.Enqueue(new Message { From = "U1", To = "U2", Text = "Hello!"});
messages.Enqueue(new MessageWithPicture { From = "U2", To = "U1", Text = "Hello, U1!" });

