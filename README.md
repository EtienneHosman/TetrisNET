# Practicum - 5 - .NET
![alt text](https://github.com/huict/practicum-5-net-2020-ex-gamechane-engineers/blob/main/Tetris/TetrisClient/resources/SplashScreen.png)

# Tetris
## Controls
### Arrow keys

 - Left arrow key 	- Move block left
 - Right arrow key 	- Move block right
 - Up arrow key		- Rotate Block 90 degrees
 - Down arrow key - Move block down

### Other
- Spacebar - Drop block
- Esc - Restart/End game

## Menu Screen
When presented the menu screen you have the selection of what mode you would like to play. Simply click the your mode of choice and get started!
In the bottom-right corner is a button to enable sounds, in case you would prefer to play with sounds and a button to toggle on the background music.

## Singleplayer
Select Singleplayer from the Main menu and the game starts. Use the arrow keys to move the block and spacebar to place a block earlier. 

## Multiplayer
Select Multiplayer from the Main menu and you will be moved into the Multiplayer lobby. In the sidebar you will find two input fields for entering your name and server-IP.
The formatting for entering the IP is as follows; **0.0.0.0:5000**. Be sure to add the port to the IP.
You can leave the connection field empty to connect to a local server.
Leave the name field empty to use an autogenerated username.

After you have connected, you will see your name in a lobby. When other clients connect you can see their names and ready-status. When all players have clicked 'Ready Up', the game will start and you will see their Tetris Wells as well as your own. Simply try to get the highest score!
If a locks their well, their grid will turn red. After dying however you can still spectate the other players.

## Results
When all players have locked their well, the result page menu will show up.
Here you can see a simple recap of the game you just played, including your score, level and time.
In multiplayer you can also see your final placing compared to the others, which is decided using score, lines cleared and time. So optimize your gameplay!

## Launching a server
Run TetrisServer.exe to start the server. If you would like to play over the internet, be sure you have port forwarded the port 5000, UDP & TCP.
