using System;
using System.Media;
using System.Threading.Tasks;
using System.Windows;
using TetrisClient.Managers;

namespace TetrisClient
{
    public class BoardManager
    {
        public MainWindow MainWindow { get; set; }
        public MultiplayerWindow MultiplayerWindow { get; set; }

        public static Random randStatus { get; set; }

        public string[,] TetrisWell { get; set; }
        public Block CurrentBlock { get; set; }
        public Block NextBlock { get; set; }
        public Block GhostBlock { get; set; }

        public bool Running { get; set; }
        private int Level { get; set; }
        private int PreviousLevel { get; set; }
        public int Time { get; set; }
        public Timer Timer { get; set; }
        public int LinesCleared { get; set; }
        public long Score { get; set; }

        public bool BlockRepeat { get; set; }

        public SoundManager SoundManager { get; set; }

        public BoardManager(MultiplayerWindow multiplayerWindow)
        {
            MultiplayerWindow = multiplayerWindow;
            TetrisWell = new string[MultiplayerWindow.MainTetrisGrid.RowDefinitions.Count, MultiplayerWindow.MainTetrisGrid.ColumnDefinitions.Count];
            randStatus = multiplayerWindow.RandomSeeded;
            InitBoardManager();
        }

        public BoardManager(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            TetrisWell = new string[MainWindow.TetrisGrid.RowDefinitions.Count, MainWindow.TetrisGrid.ColumnDefinitions.Count];
            randStatus = new();
            InitBoardManager();
        }

        /// <summary>
        /// Initialize the board by creating blocks, starting a timer and preparing the first turn.
        /// </summary>
        public void InitBoardManager()
        {
            // Create all needed blocks and move them to the correct positions.
            CurrentBlock = new Block(this);
            NextBlock = new Block(this);
            NextBlock.X = NextBlock.Shape.Value.GetLength(1) <= 2 ? 1 : 0;
            NextBlock.Y = NextBlock.Shape.Value.GetLength(0) <= 2 ? 1 : 0;
            GhostBlock = CurrentBlock.CalculateGhost();

            // Initialize needed variables.
            Time = 0;
            LinesCleared = 0;
            Score = 0;

            NextTurn();

            // Start the timer.
            Timer = new(this);
            Timer.StartTimer();
            Running = true;

            if (SettingManager.MusicOn)
            {
                InitSound();
            }
        }

        /// <summary>
        /// Calculates the level based on the amount of lines cleared.
        /// </summary>
        /// <returns>An integer with the current level.</returns>
        public int CalculateLevel()
        {
            Level = LinesCleared / 10;
            return Level;
        }

        /// <summary>
        /// Increases the music speed when you level up.
        /// </summary>
        public void IncreaseSpeedWithLevel()
        {
            if (PreviousLevel != Level)
            {
                PreviousLevel = Level;
                if (SettingManager.MusicOn)
                {
                    SoundManager.IncreaseSpeed();
                }
            }
        }

        /// <summary>
        /// Calculates the score using the amount of filled lines and the current level.
        /// </summary>
        /// <param name="linesfilled">The amount of lines to calculate the score for.</param>
        /// <param name="level">The current level.</param>
        /// <returns>The calculated score.</returns>
        public static int CalculateScore(int linesFilled, int level)
        {
            int s = 0;
            s += linesFilled switch
            {
                1 => 40 * (level + 1),
                2 => 100 * (level + 1),
                3 => 300 * (level + 1),
                4 => 1200 * (level + 1),
                _ => 420 * linesFilled * (level + 1),
            };
            return s;
        }

        /// <summary>
        /// Prepares the game for the next turn.
        /// Checks if any rows need to be cleared, increases score and selects the next block.
        /// </summary>
        public void NextTurn()
        {
            BlockRepeat = true;

            int rowsFilled = 0;
            for (int row = 0; row < TetrisWell.GetLength(0); row++)
            {
                bool rowFilled = true;
                for (int cell = 0; cell < TetrisWell.GetLength(1); cell++)
                {
                    if (TetrisWell[row, cell] == null)
                    {
                        rowFilled = false;
                    }
                }
                if (rowFilled)
                {
                    string[,] newTetrisWell = new string[TetrisWell.GetLength(0), TetrisWell.GetLength(1)];
                    for (int i = TetrisWell.GetUpperBound(0), k = TetrisWell.GetUpperBound(0); i >= 0; i--)
                    {
                        if (i == row)
                        {
                            continue;
                        }

                        for (int j = 0; j < TetrisWell.GetLength(1); j++)
                        {
                            newTetrisWell[k, j] = TetrisWell[i, j];
                        }
                        k--;
                    }
                    TetrisWell = newTetrisWell;
                    rowsFilled++;
                }
            }

            if (rowsFilled > 0 && SettingManager.GameSoundsOn)
            {
                new SoundPlayer(new Uri(Environment.CurrentDirectory + "/Resources/RemoveLines.wav", UriKind.Relative).ToString()).Play();
            }

            Score += CalculateScore(rowsFilled, CalculateLevel());

            IncreaseSpeedWithLevel();

            LinesCleared += rowsFilled;
            SelectNextBlock();
        }

        /// <summary>
        /// Select the next block and update the current block.
        /// </summary>
        public void SelectNextBlock()
        {
            CurrentBlock = NextBlock.Clone();
            CurrentBlock.X = ((TetrisWell.GetUpperBound(1) - TetrisWell.GetLowerBound(1)) / 2) - ((CurrentBlock.Shape.Value.GetLength(1) - 1) / 2);
            GhostBlock = CurrentBlock.CalculateGhost();
            CurrentBlock.Bm.TetrisWell = TetrisWell;
            NextBlock = new Block(this);
            NextBlock.X = NextBlock.Shape.Value.GetLength(1) < 3 ? 1 : 0;
            NextBlock.Y = NextBlock.Shape.Value.GetLength(0) < 4 ? 1 : 0;
        }

        /// <summary>
        /// Initialize the background music.
        /// </summary>
        public async void InitSound()
        {
            await Task.Run(() =>
            {
                _ = Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                  {
                      SoundManager = new SoundManager();
                      SoundManager.PlayMusic();
                  }));
            });
        }

        /// <summary>
        /// Ends the game.
        /// </summary>
        public void EndGame()
        {
            if (MainWindow != null)
            {
                MainWindow.EndGame();
            }
            else if (MultiplayerWindow != null)
            {
                MultiplayerWindow.EndGame();
            }
        }
    }
}
