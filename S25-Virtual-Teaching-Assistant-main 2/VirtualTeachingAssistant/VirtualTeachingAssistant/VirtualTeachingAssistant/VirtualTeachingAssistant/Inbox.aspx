<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inbox.aspx.cs" Inherits="VirtualTeachingAssistant.Inbox" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Temple Teaching Assist</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.10.5/font/bootstrap-icons.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;600;700&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f8f9fa;
        }

        .navbar {
            background-color: #f8d7da;
        }

        main {
            flex: 1;
        }

        .welcome-message {
            margin: 1rem 0;
            text-align: center;
        }

        .chat-history-card {
            background-color: #fff;
            border: 1px solid #ddd;
            border-radius: 8px;
            padding: 1.5rem;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            margin-bottom: 1.5rem;
        }

        .chat-header {
            font-size: 1.25rem;
            font-weight: bold;
        }

        .chat-message {
            font-size: 1rem;
            margin-top: 1rem;
        }

        footer {
            position: fixed;
            bottom: 0;
            left: 0;
            width: 100%;
            background-color: #dbc8c8;
            text-align: center;
            padding: 1rem;
            box-shadow: 0 -2px 5px rgba(0, 0, 0, 0.1);
        }
    </style>
</head>
<body>
    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg">
        <div class="container">
            <a class="navbar-brand" href="Home.aspx">
                <i class="bi bi-house-door-fill"></i>
            </a>
            <a class="navbar-brand" href="Inbox.aspx">
                <i class="bi bi-envelope-fill"></i>
            </a>
            <div class="ms-auto">
                <div class="dropdown">
                    <button class="btn btn-light dropdown-toggle d-flex align-items-center" type="button" id="profileDropdown" data-bs-toggle="dropdown" aria-expanded="false">
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

    <!-- Welcome Message -->
    <div class="welcome-message container">
        <p class="alert alert-light">Welcome User! Today is Thursday, November 14, Fall 2024</p>
    </div>

    <!-- Chat History Cards -->
    <div class="container">
        <div class="row">
            <!-- Chat History Card 1 -->
            <div class="col-12">
                <div class="chat-history-card">
                    <i class="bi bi-chat"></i>
                    <div class="chat-header">Chat with Professor Smith</div>
                    <div class="chat-message">
                        <strong>Prof. Smith:</strong> "Please review the course material and come prepared for the next exam."
                    </div>
                    <div class="chat-message">
                        <strong>You:</strong> "Got it! I'll make sure to review the material."
                    </div>
                </div>
            </div>

            <!-- Chat History Card 2 -->
            <div class="col-12">
                <div class="chat-history-card">
                    <i class="bi bi-chat"></i>
                    <div class="chat-header">Chat with TA Jane</div>
                    <div class="chat-message">
                        <strong>TA Jane:</strong> "The office hours have been rescheduled for tomorrow at 3 PM."
                    </div>
                    <div class="chat-message">
                        <strong>You:</strong> "Thanks for the update!"
                    </div>
                </div>
            </div>

            <!-- Chat History Card 3 -->
            <div class="col-12">
                <div class="chat-history-card">
                    <i class="bi bi-chat"></i>
                    <div class="chat-header">Chat with Professor Lee</div>
                    <div class="chat-message">
                        <strong>Prof. Lee:</strong> "Don't forget to submit your project by next week."
                    </div>
                    <div class="chat-message">
                        <strong>You:</strong> "I'll make sure to meet the deadline."
                    </div>
                </div>
            </div>

        </div>
    </div>

    <!-- Footer -->
    <footer>
        Temple Teaching Assist
    </footer>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
