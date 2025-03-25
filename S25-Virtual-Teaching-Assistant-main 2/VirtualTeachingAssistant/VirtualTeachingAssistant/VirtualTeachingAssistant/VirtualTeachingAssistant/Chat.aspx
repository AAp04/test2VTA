<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="VirtualTeachingAssistant.Chat" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Chat Box with Navigation</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.10.5/font/bootstrap-icons.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;600;700&display=swap" rel="stylesheet">
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }

        /* Navigation Bar */
        .navbar {
            background-color: #dbc8c8;
        }

            .navbar .nav-left {
                display: flex;
                gap: 20px;
            }

                .navbar .nav-left a {
                    color: white;
                    text-decoration: none;
                    font-weight: bold;
                }

            .navbar .nav-center select {
                padding: 8px;
                font-size: 14px;
                border-radius: 5px;
                border: none;
                outline: none;
            }

            .navbar .nav-right button {
                padding: 8px 15px;
                font-size: 14px;
                border-radius: 5px;
                border: none;
                background-color: #dbc8c8;
                color: white;
                cursor: pointer;
            }

                .navbar .nav-right button:hover {
                    background-color: #dbc8c8;
                }

        .navbar {
            background-color: #f8d7da;
            border-bottom: 1px solid #ddd;
        }

        .navbar-brand img {
            width: 24px;
        }
        /* Layout */
        .container {
            display: flex;
            height: calc(100vh - 60px);
        }

        /* Sidebar for chat history */
        .chat-history {
            width: 250px;
            background-color: #a6a3a6;
            padding: 20px;
            overflow-y: auto;
            border-right: 1px solid #ddd;
        }

            .chat-history h3 {
                font-size: 18px;
                margin-bottom: 10px;
            }

            .chat-history ul {
                list-style-type: none;
            }

            .chat-history li {
                padding: 10px;
                margin-bottom: 5px;
                border-radius: 5px;
                cursor: pointer;
                transition: background-color 0.3s;
            }

                .chat-history li:hover {
                    background-color: #e9ecef;
                }

        /* Main Chat Area */
        .main-chat {
            flex: 1;
            display: flex;
            flex-direction: column;
            height: 100%;
            background-color: white;
        }

        .chat-box {
            flex: 1;
            padding: 20px;
            overflow-y: auto;
            border-bottom: 2px solid #f0f0f0;
        }

        .message {
            margin-bottom: 15px;
            display: flex;
            justify-content: flex-start;
            align-items: center;
        }

            .message.bot {
                justify-content: flex-start;
            }

            .message.user {
                justify-content: flex-end;
            }

            .message .text {
                max-width: 80%;
                padding: 10px;
                border-radius: 10px;
                background-color: #dbc8c8;
                box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
            }

            .message.user .text {
                background-color: #dbc8c8;
                color: white;
            }

        .input-container {
            display: flex;
            padding: 10px;
            background-color: #dbc8c8;
            border-top: 2px solid #f0f0f0;
        }

            .input-container input {
                flex: 1;
                padding: 10px;
                border: 2px solid #ddd;
                border-radius: 20px;
                outline: none;
            }

                .input-container input:focus {
                    border-color: #007bff;
                }

            .input-container button {
                background-color: #007bff;
                color: white;
                border: none;
                padding: 10px 15px;
                border-radius: 20px;
                margin-left: 10px;
                cursor: pointer;
            }

                .input-container button:hover {
                    background-color: #0056b3;
                }
    </style>
</head>
<body>

    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg">
    <div class="container-fluid d-flex justify-content-between align-items-center">
        <a class="navbar-brand" href="Home.aspx">
            <i class="bi bi-house-door-fill"></i>
        </a>
        <a class="navbar-brand" href="Inbox.aspx">
            <i class="bi bi-envelope-fill"></i>
        </a>
        <div class="ms-auto">
            <div class="dropdown">
                <button runat="server" class="btn btn-light dropdown-toggle d-flex align-items-center" type="button" id="profileDropdown" data-bs-toggle="dropdown" aria-expanded="false">
                    <i class="bi bi-person-circle me-2" style="font-size: 1.5rem;"></i>
                    John Doe
                </button>

                <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="profileDropdown">
                    <li><a class="dropdown-item" href="Profile.aspx"><i class="bi bi-person"></i> View Profile</a></li>
                    <li><a class="dropdown-item" href="Settings.aspx"><i class="bi bi-gear"></i> Settings</a></li>
                    <li><hr class="dropdown-divider"></li>
                    <li><a class="dropdown-item" href="Logout.aspx"><i class="bi bi-box-arrow-right"></i> Logout</a></li>
                </ul>
            </div>
        </div>
    </div>
</nav>


    <!-- Main Layout -->
    <div class="container">
        <!-- Chat History Sidebar -->
        <div class="chat-history">
            <h3>Chat History</h3>
            <div>
                <i class="pull-right bi bi-question"></i>
                <h4>FAQs</h4>
            </div>
            <ul>
                <li>How to use this platform?</li>
                <li>Account Settings FAQ</li>
                <li>Common Problems</li>
            </ul>
            <h4>Today</h4>
            <ul>
                <li>Today's conversation 1</li>
                <li>Today's conversation 2</li>
            </ul>
            <h4>Yesterday</h4>
            <ul>
                <li>Yesterday's conversation 1</li>
                <li>Yesterday's conversation 2</li>
            </ul>
        </div>

        <!-- Main Chat Area -->
        <div class="main-chat">
            <div class="chat-box" id="chat-box">
                </div>

            <!-- Input area -->
            <div class="input-container">
                <input type="text" id="user-input" placeholder="Type a message..." />
                <button onclick="sendMessage()">Send Message</button>
            </div>
        </div>
    </div>

    <script>
        let chatHistory = []; // Stores conversation history

        function sendMessage() {
            var inputField = document.getElementById('user-input');
            var userMessage = inputField.value.trim();
            if (userMessage === '') return;

            // Add user's message to chat history 
            chatHistory.push({ content: userMessage });

            // Display user message with prefix
            displayMessage(userMessage, 'user');
            inputField.value = '';

            // Send conversation history to the API
            fetch('https://chatapi.templeteachingassist.com/API/Chat/SendMessageWithVTA', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ conversationHistory: chatHistory }) // Send as array of messages
            })
                .then(response => response.text()) // Expecting a string response
                .then(botReply => {
                    // Trim response to remove any unwanted characters or spaces
                    botReply = botReply.trim();
                    console.log('Bot reply:', botReply); // Debug log

                    // Add bot response to chat history
                    chatHistory.push({ content: botReply });

                    // Display bot response with prefix
                    displayMessage(botReply, 'bot');
                })
                .catch(error => {
                    console.error('Error:', error);
                    displayMessage('Error connecting to the chatbot.', 'bot');
                });
        }

        function displayMessage(message, sender) {
            var chatBox = document.getElementById('chat-box');
            var messageDiv = document.createElement('div');
            messageDiv.classList.add('message', sender);

            // Add prefix based on sender
            let prefix = sender === 'user' ? 'User: ' : 'Temple Teaching Assist: ';
            messageDiv.innerHTML = `<div class="text">${prefix}${message}</div>`;

            chatBox.appendChild(messageDiv);

            // Scroll to the bottom of the chat box
            chatBox.scrollTop = chatBox.scrollHeight;
        }

        // Focus the input field on load
        document.getElementById('user-input').focus();
    </script>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>

</body>
</html>
