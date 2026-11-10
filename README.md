# Tic-Tac-Toe-game
# 🎮 TIC TAC TOE GAME
### A Two-Player Desktop Game Using C# Windows Forms

---

## 📌 1. Project Overview

Tic Tac Toe is a two-player strategy game developed using the C# programming language and Windows Forms in Visual Studio 2022.

The main purpose of this project is to provide an interactive gaming experience where two players compete against each other using two symbols: X and O.

The game consists of a 3×3 grid containing nine buttons. Players take turns selecting empty buttons to place their respective symbols. The first player who successfully places three matching symbols in a horizontal, vertical, or diagonal direction wins the game.

The application also includes a scoreboard to maintain the scores of both players, along with New Game, Restart, and Exit options.

This project demonstrates the practical implementation of C# programming concepts and Windows Forms application development.

---

## 🎯 2. Project Objectives

The main objectives of developing this project are:

- To understand the fundamentals of C# programming.
- To practice Windows Forms application development.
- To create an interactive graphical user interface.
- To understand event handling in C#.
- To implement conditional statements for game logic.
- To practice using variables and methods.
- To implement winner detection conditions.
- To understand how to update scores dynamically.
- To develop a functional desktop-based game.
- To improve logical thinking and problem-solving skills.

---

## 🛠️ 3. Technologies and Tools Used

The following technologies and development tools are used in this project:

### Programming Language
**C# (C-Sharp)**

C# is used to implement the complete game functionality, including player turns, winner detection, score calculation, and button events.

### Framework
**Windows Forms (.NET Framework)**

Windows Forms is used to develop the graphical user interface of the application.

### IDE
**Microsoft Visual Studio 2022**

Visual Studio 2022 is used to design, develop, debug, and execute the application.

### Other Technologies
- .NET Framework
- Visual Studio Windows Forms Designer
- C# Event Handling

---

## ✨ 4. Main Features

The Tic Tac Toe game provides the following features:

### 4.1 Two-Player Gameplay
The game supports two players. One player uses X, while the other player uses O.

### 4.2 Interactive Game Board
The application contains a 3×3 grid with nine clickable buttons. Players select empty buttons to make their moves.

### 4.3 Automatic Player Turns
The game automatically changes the player's turn after each move.

### 4.4 Winner Detection
The application checks the possible winning combinations after every move.

A player wins when three identical symbols appear in:
- Horizontal direction.
- Vertical direction.
- Diagonal direction.

### 4.5 Scoreboard
The application maintains separate scores for Player X and Player O.

Whenever a player wins, their score increases by one point.

### 4.6 New Game Option
The New Game button starts a completely new game and resets both players' scores to zero.

### 4.7 Restart Option
The Restart button clears the current game board while keeping the previous scores.

### 4.8 Exit Option
The Exit button allows users to close the application.

### 4.9 Winning Combination Highlighting
The buttons that form a winning combination are highlighted to make the winning result easier to identify.

### 4.10 Draw Detection
If all nine buttons are filled and neither player wins, the game declares a draw.

---

## 🎮 5. Game Rules and Instructions

The game follows these rules:

1. The game is played between two players.
2. Player X starts the game.
3. Player O takes the second turn.
4. Players must select an empty box on the game board.
5. Each player gets one turn at a time.
6. Players cannot select an already occupied box.
7. The player who completes three identical symbols in a row, column, or diagonal wins.
8. The winner receives one point.
9. If all nine boxes are filled without a winner, the game ends in a draw.
10. Players can restart the game or start a completely new game.

---

## 🏆 6. Winning Combinations

There are eight possible winning combinations in Tic Tac Toe.

### Horizontal Combinations
- First Row: 1, 2, 3
- Second Row: 4, 5, 6
- Third Row: 7, 8, 9

### Vertical Combinations
- First Column: 1, 4, 7
- Second Column: 2, 5, 8
- Third Column: 3, 6, 9

### Diagonal Combinations
- First Diagonal: 1, 5, 9
- Second Diagonal: 3, 5, 7

The application checks these combinations to determine the winner.

---

## 🖥️ 7. Graphical User Interface (GUI)

The application provides a user-friendly graphical interface.

The main interface contains the following components:

### Game Board
A 3×3 grid containing nine buttons where players place X and O symbols.

### Player Score Section
Displays the current scores of:
- Player X
- Player O

### New Game Button
Starts a completely new game and resets the scores.

### Restart Button
Restarts the current round without resetting the scores.

### Exit Button
Closes the application.

The interface uses different background colors for the game board and control buttons to make the application visually interactive.

---

## ⚙️ 8. Working Procedure of the Game

The game follows a simple execution process.

### Step 1: Application Start
When the application starts, the main game window appears with the 3×3 grid and scoreboard.

### Step 2: First Player Move
Player X selects an empty button. The selected button displays X.

### Step 3: Second Player Move
Player O selects another empty button. The selected button displays O.

### Step 4: Change of Turns
The game automatically switches between Player X and Player O after each move.

### Step 5: Check Winning Conditions
After every move, the application checks all eight winning combinations.

### Step 6: Display Winner
If any player completes a winning combination, a message box displays the winner's name.

### Step 7: Update Score
The winner's score increases by one point.

### Step 8: End of Game
After a winner is identified, the remaining game buttons become disabled.

If all nine positions are filled without a winner, the game declares a draw.

### Step 9: Restart or New Game
Players can use the Restart or New Game button to play another round.

---

## 📂 9. Project Structure

The project contains the following important files:

```text
Tic-Tac-Toe-Game/
│
├── Program.cs
│
├── Form1.cs
│
├── Form1.Designer.cs
│
├── Form1.resx
│
├── App.config
│
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   └── Settings.settings
│
├── README.md
│
└── .gitignore
```

### Description of Important Files

**Program.cs**
Contains the entry point of the application and starts the main Windows Form.

**Form1.cs**
Contains the main C# programming logic, including player turns, winner detection, score updates, and button click events.

**Form1.Designer.cs**
Contains the automatically generated code for the graphical user interface and its controls.

**Form1.resx**
Stores resources associated with the Windows Form.

**App.config**
Contains application configuration settings.

**Properties Folder**
Contains project properties, resources, and application settings.

**README.md**
Provides project documentation, features, instructions, and other important information.

---

## 🧠 10. C# Programming Concepts Used

This project demonstrates several fundamental programming concepts.

### Variables
Variables are used to store player turns and scores.

### Boolean Data Type
Boolean variables are used to manage player turns and game conditions.

### Conditional Statements
If and else statements are used to identify players and check winning conditions.

### Methods
Methods are used to organize different game operations, such as checking scores and disabling buttons.

### Arrays
Arrays can be used to organize and manage the nine game buttons and check winning combinations.

### Loops
Loops can be used to check multiple winning combinations efficiently.

### Event Handling
Button click events are used to detect player interactions with the graphical interface.

### Message Boxes
Message boxes are used to display winner announcements and other game messages.

---

## 🚀 11. How to Install and Run the Project

Follow these instructions to run the Tic Tac Toe game on your computer.

### Requirements
- Windows Operating System.
- Visual Studio 2022.
- .NET Framework compatible with the project.
- C# Windows Forms development support.

### Installation Steps

1. Download or clone this repository from GitHub.
2. Extract the downloaded project if it is in ZIP format.
3. Open the project folder.
4. Locate the `.sln` solution file.
5. Double-click the solution file to open it in Visual Studio 2022.
6. Wait for the project to load.
7. Build the project using the Build option.
8. Press F5 or click Start to execute the application.
9. The Tic Tac Toe game window will appear.

---

## 🔮 12. Future Improvements

The following features can be added in future versions:

- Single-player mode against the computer.
- Difficulty levels such as Easy, Medium, and Hard.
- Improved graphical interface.
- Sound effects during gameplay.
- Player name customization.
- Game history.
- Match statistics.
- Improved animations.
- Database integration for saving player scores.

---

## 📚 13. Learning Outcomes

Developing this project helped in understanding:

- Basic C# programming.
- Windows Forms application development.
- Designing graphical user interfaces.
- Handling button click events.
- Implementing game logic.
- Using conditional statements.
- Working with variables and methods.
- Checking multiple winning conditions.
- Updating scores dynamically.
- Debugging and testing a desktop application.

---

## 👨‍💻 14. Developer Information

**Developer Name:** Muhammad Ilyas

**Project Name:** Tic Tac Toe Game

**Programming Language:** C#

**Development Environment:** Visual Studio 2022

**Project Type:** Desktop Application

**Framework:** Windows Forms (.NET Framework)

---

## 📄 15. License

This project is created for educational and learning purposes.

You are welcome to explore the source code and learn from its implementation.
