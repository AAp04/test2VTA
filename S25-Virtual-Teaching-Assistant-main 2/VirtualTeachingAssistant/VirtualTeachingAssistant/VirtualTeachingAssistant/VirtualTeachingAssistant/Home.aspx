<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VirtualTeachingAssistant.Home" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Temple Teaching Assist</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.10.5/font/bootstrap-icons.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;600;700&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: 'Inter', sans-serif;
            background-color: #f8f9fa;
            color: #212529;
            display: flex;
            flex-direction: column;
            min-height: 100vh;
        }

        .navbar {
            background-color: #f8d7da;
            border-bottom: 1px solid #ddd;
        }

        .navbar-brand img {
            width: 24px;
        }

        .welcome-message {
            margin: 2rem 0;
            text-align: center;
            font-weight: 600;
            color: #495057;
        }

        .course-card {
            background-color: #ffffff;
            border: 1px solid #ddd;
            border-radius: 12px;
            padding: 1.5rem;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }

            .course-card:hover {
                transform: translateY(-5px);
                box-shadow: 0 4px 20px rgba(0, 0, 0, 0.1);
            }

            .course-card h5 {
                font-weight: 700;
                color: #212529;
            }

            .course-card p {
                color: #495057;
                font-size: 0.9rem;
            }

        .btn-outline-secondary {
            color: #495057;
            border-color: #495057;
        }

            .btn-outline-secondary:hover {
                background-color: #495057;
                color: #ffffff;
            }

        footer {
            background-color: #f1f1f1;
            text-align: center;
            padding: 1rem;
            border-top: 1px solid #ddd;
            font-size: 0.9rem;
            color: #6c757d;
            position: fixed;
            bottom: 0;
            width: 100%;
        }

        .content {
            flex: 1;
        }
    </style>
</head>
<body>
    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg">
        <div class="container">
            <a class="navbar-brand" href="Home.aspx">
                <i class="bi bi-house-door-fill"></i>
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
                        <li><a class="dropdown-item" href="Settings.aspx"><i class="bi bi-gear"></i> Settings</a></li>
                        <li><hr class="dropdown-divider"></li>
                        <li><a class="dropdown-item" href="LogIn.aspx"><i class="bi bi-box-arrow-right"></i> Logout</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </nav>

    <!-- Welcome Message -->
    <div class="welcome-message container">
        <p class="alert alert-light">Welcome User! Today is Thursday, November 14, Fall 2024</p>
    </div>

    <!-- Course Cards -->
    <div class="container content">
        <div class="row row-cols-1 row-cols-md-2 row-cols-lg-2 g-4">
            <!-- Course Card 1 -->
            <div class="col">
                <div class="course-card">
                    <h5>Course 1</h5>
                    <p>
                        Course Name, Description, Section, Semester<br>
                        Professor Information, Office Hours<br>
                        TA Information, Office Hours
                    </p>
                    <a href="Chat.aspx">
                        <button class="btn btn-outline-secondary btn-sm">
                            <i class="bi bi-chat-dots"></i> Chat
                        </button>
                    </a>
                </div>
            </div>
            <!-- Course Card 2 -->
            <div class="col">
                <div class="course-card">
                    <h5>Course 2</h5>
                    <p>
                        Course Name, Description, Section, Semester<br>
                        Professor Information, Office Hours<br>
                        TA Information, Office Hours
                    </p>
                    <a href="Chat.aspx">
                        <button class="btn btn-outline-secondary btn-sm">
                            <i class="bi bi-chat-dots"></i> Chat
                        </button>
                    </a>
                </div>
            </div>
            <!-- Course Card 3 -->
            <div class="col">
                <div class="course-card">
                    <h5>Course 3</h5>
                    <p>
                        Course Name, Description, Section, Semester<br>
                        Professor Information, Office Hours<br>
                        TA Information, Office Hours
                    </p>
                    <a href="Chat.aspx">
                        <button class="btn btn-outline-secondary btn-sm">
                            <i class="bi bi-chat-dots"></i> Chat
                        </button>
                    </a>
                </div>
            </div>
            <!-- Course Card 4 -->
            <div class="col">
                <div class="course-card">
                    <h5>Course 4</h5>
                    <p>
                        Course Name, Description, Section, Semester<br>
                        Professor Information, Office Hours<br>
                        TA Information, Office Hours
                    </p>
                    <a href="Chat.aspx">
                        <button class="btn btn-outline-secondary btn-sm">
                            <i class="bi bi-chat-dots"></i> Chat
                        </button>
                    </a>
                </div>
            </div>
        </div>
    </div>

    <!-- Footer -->
    <footer>
        Temple Teaching Assist &copy; 2024
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>

