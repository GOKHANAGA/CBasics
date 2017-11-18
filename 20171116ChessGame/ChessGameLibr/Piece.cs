using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameLibr
{
    public abstract class Piece
    {
        protected Random rndMovement = new Random();

        public abstract void GetRnd(ref int movement);

        public abstract int MoveX
        {
            get;
        }
        public abstract int MoveY
        {
            get;
        }
        public virtual string PieceImage()
        {
            return "";
        }

    }
}
