# Tic Tac Toe Game in C#

This project is a simple implementation of the classic Tic Tac Toe game using C#. The game is played in the console, and it supports two players: a human player and a computer player.

## How to Play

1. Run the program.
2. You will be prompted to choose whether you want to play as 'X' or 'O'.
3. Enter your choice and press Enter.
4. The game board will be displayed, and you can start making your moves.

   The board is a 3x3 grid, and you need to input your move in the format `x,y` where `x` is the row number and `y` is the column number. For example, `1,1` will place your piece in the top-left corner of the board.

5. The computer player will make its move after you.
6. The game continues until there is a winner or the board is full, resulting in a draw.

## Features

- **Player vs Computer Mode**: Play against a computer opponent.
- **Input Validation**: The program validates the player's input to ensure it's in the correct format and within the valid range.
- **Winning Condition Check**: After each move, the program checks if there is a winner.
- **Draw Condition Check**: The game ends in a draw if the board is full and there is no winner.
