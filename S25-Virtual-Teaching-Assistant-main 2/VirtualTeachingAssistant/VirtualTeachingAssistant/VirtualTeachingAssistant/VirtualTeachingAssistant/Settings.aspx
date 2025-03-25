<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="VirtualTeachingAssistant.Settings" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Profile Settings</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.10.5/font/bootstrap-icons.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;600;700&display=swap" rel="stylesheet">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            display: flex;
            flex-direction: column;
            height: 100vh;
            background-color: #fdfdfd;
        }

        /* Header styling */
        .navbar {
            display: flex;
            justify-content: space-between;
            align-items: center;
            background-color: #d1bcbc;
            padding: 15px 20px;
            color: #fff;
            font-size: 18px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

            .header .user-info {
                display: flex;
                align-items: center;
            }

                .header .user-info span {
                    margin-right: 10px;
                }

            .header .user-circle {
                width: 35px;
                height: 35px;
                border-radius: 50%;
                background-color: #fff;
                display: flex;
                align-items: center;
                justify-content: center;
                font-size: 18px;
                color: #d1bcbc;
            }

        /* Footer styling */
        footer {
            text-align: center;
            background-color: #d1bcbc;
            color: #fff;
            padding: 15px;
            font-size: 16px;
            margin-top: auto;
            box-shadow: 0 -2px 5px rgba(0, 0, 0, 0.1);
        }

        /* Sidebar styling */
        .sidebar {
            width: 250px;
            background-color: #e5d6d3;
            padding: 20px;
            box-sizing: border-box;
            height: calc(100vh - 120px); /* Adjusted for header and footer height */
            overflow-y: auto;
            box-shadow: 2px 0 5px rgba(0, 0, 0, 0.1);
        }

            .sidebar ul {
                list-style: none;
                padding: 0;
                margin: 0;
            }

                .sidebar ul li {
                    margin: 15px 0;
                    font-size: 16px;
                    padding: 10px;
                    border-radius: 5px;
                    cursor: pointer;
                    transition: background-color 0.3s;
                }

                    .sidebar ul li.active {
                        font-weight: bold;
                        background-color: #d1bcbc;
                        color: #fff;
                    }

                    .sidebar ul li:hover {
                        background-color: #d1bcbc;
                        color: #fff;
                    }

        /* Main content styling */
        .main {
            flex: 1;
            padding: 30px;
            overflow-y: auto;
        }

        .profile-section,
        .message-section {
            margin-bottom: 30px;
            background: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

            .profile-section h2,
            .message-section h2 {
                font-size: 22px;
                margin-bottom: 15px;
                color: #333;
            }

            .profile-section .profile-pic {
                display: flex;
                align-items: center;
                margin-bottom: 15px;
            }

        .profile-pic img {
            width: 100px;
            height: 100px;
            border-radius: 50%;
            background-color: #ccc;
            margin-right: 20px;
        }

        .profile-pic button {
            padding: 10px 15px;
            border: none;
            background-color: #4CAF50;
            color: white;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

            .profile-pic button:hover {
                background-color: #45a049;
            }

        .toggle-container {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-bottom: 15px;
        }

            .toggle-container label {
                font-size: 16px;
                color: #333;
            }

            .toggle-container input {
                width: 20px;
                height: 20px;
                cursor: pointer;
            }

        /* Layout adjustment */
        .content {
            display: flex;
        }
    </style>
</head>
<body>
    <!-- Header -->

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


    <!-- Content -->
    <div class="content">
        <div class="sidebar">
            <ul>
                <li class="active">Appearance</li>
                <li>Messages</li>
                <li>Course Settings</li>
                <li>Display Settings</li>
                <li>Personal Info</li>
                <li>Notifications</li>
                <li>Accessibility</li>
            </ul>
        </div>

        <div class="main">
            <div class="profile-section">
                <h2>Appearance</h2>
                <div class="profile-pic">
                    <img src="#" alt="Profile Picture Placeholder">
                    <button>Upload Photo</button>
                </div>
                <p>John Doe | email@domain.com</p>
            </div>

            <div class="message-section">
                <h2>Messages</h2>
                <div class="toggle-container">
                    <label for="delete-logs">Automatically delete logs after 30 days</label>
                    <input type="checkbox" id="delete-logs">
                </div>
                <div class="toggle-container">
                    <label for="log-requests">Automatically log every time a request to a professor is sent</label>
                    <input type="checkbox" id="log-requests">
                </div>
            </div>
        </div>
    </div>

    <!-- Footer -->
    <footer>
        Temple Teaching Assist &copy; 2024
    </footer>
</body>
</html>
