using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameLibr
{
    class Rook:Piece
    {
        private int _moveY;

        internal Rook()
        {

        }
        public override int MoveX
        {
            /*----Random değere göre sağ solu da yap----*/
            get { return 0; }
        }

        public override int MoveY
        {
            get
            {
                GetRnd(ref _moveY);
                if (_moveY < 2000)
                {
                    return 1;
                }
                else if (_moveY < 4000)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }

            }
        }

        public override string PieceImage()
        {
            return "Rook.ico";
        }

        public override void GetRnd(ref int movement)
        {
            movement = rndMovement.Next(0, 10000);
        }
    }
}
