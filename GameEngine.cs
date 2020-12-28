using System;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class GameEngine
    {
        private bool[,] field;
        private readonly int rows;
        private readonly int cols;
        private HashSet<byte> bornRule;
        private HashSet<byte> surviveRule;

        public uint CurrentGeneration { get; private set; } = 0;

        public GameEngine(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            field = new bool[cols, rows];
        }

        public void SetRules(string bornRule, string surviveRule)
        {
            this.bornRule = new HashSet<byte>(bornRule.Select(c => (byte)char.GetNumericValue(c)));
            this.surviveRule = new HashSet<byte>(surviveRule.Select(c => (byte)char.GetNumericValue(c)));
        }

        public void GenerateRandom(int density)
        {
            Random random = new Random();

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 0;
                }
            }
        }

        public void NextGeneration()
        {
            bool[,] newField = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    bool hasLife = field[x, y];
                    byte neighboursCount = NeighbourCounts(x, y);
                    newField[x, y] = (!hasLife && bornRule.Contains(neighboursCount)) || (hasLife && surviveRule.Contains(neighboursCount));
                }
            }

            field = newField;
            CurrentGeneration++;
        }

        private byte NeighbourCounts(int x, int y)
        {
            byte count = 0;

            foreach ((int, int) tuple in new (int, int)[] { (-1, -1), (-1, 0), (-1, 1), (0, -1), (0, 1), (1, -1), (1, 0), (1, 1) })
            {
                int col = (x + tuple.Item1 + cols) % cols;
                int row = (y + tuple.Item2 + rows) % rows;
                bool hasLife = field[col, row];

                if (hasLife)
                {
                    count++;
                }
            }

            return count;
        }

        public bool[,] GetCurrentGeneration()
        {
            return (bool[,])field.Clone();
        }

        public void AddCell(int x, int y)
        {
            UpdateCell(x, y, true);
        }

        public void RemoveCell(int x, int y)
        {
            UpdateCell(x, y, false);
        }

        private bool ValidateCellPosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < cols && y < rows;
        }

        private void UpdateCell(int x, int y, bool state)
        {
            if (ValidateCellPosition(x, y))
            {
                field[x, y] = state;
            }
        }
    }
}
