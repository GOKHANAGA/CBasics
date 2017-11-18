using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameLibr
{
    public class Knight:Piece
    {
        private int _moveX;

        internal Knight()
        {

        }
        public override int MoveX
        {
            get
            {
                GetRnd(ref _moveX);
                if (_moveX < 5000)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public override int MoveY
        {
            get
            {
                if (_moveX < 5000)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        public override string PieceImage()
        {
            return "Knight.ico";
        }

        public override void GetRnd(ref int movement)
        {
            movement = rndMovement.Next(0, 10000);
        }
    }
}
