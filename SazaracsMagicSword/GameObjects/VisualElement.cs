using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public class VisualElement
    {
        public VisualBrick[,] ElementMatrix;
        bool isSolid; /// player can not pass through solid elements;
        public object content;
        public bool heroIsThere;

        public Position position;

        public VisualElement(VisualBrick[,] ElementMatrix, object content, bool isSolid, Position position)
        {
            this.ElementMatrix = ElementMatrix;
            this.content = content;
            this.isSolid = isSolid;
            this.position = position;
        }
    }
}
