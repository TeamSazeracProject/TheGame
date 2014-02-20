using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public class VisualElement : IMove
    {
        VisualBrick[,] ElementMatrix;
        bool isSolid; /// player can not pass through solid elements;
        object content;

        public Position position;

        public VisualElement(int width, int height, VisualBrick[,] ElementMatrix, object content, bool isSolid, Position position)
        {
            if (width < 1 || height < 1)
            {
                throw new ArgumentException("Both Width and height must be positive.");
            }
            this.ElementMatrix = ElementMatrix;
            this.content = content;
            this.isSolid = isSolid;
            this.position = position;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
                    position.row--;
                    break;
                case Direction.down:
                    position.row++;
                    break;
                case Direction.left:
                    position.col--;
                    break;
                case Direction.right:
                    position.col++;
                    break;
                default:
                    break;
            }
        }
    }
}
