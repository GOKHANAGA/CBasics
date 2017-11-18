using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameLibr
{
    class Bishop:Piece
    {
        private int _moveX;

        internal Bishop()
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
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public override string PieceImage()
        {
            return "Bishop.ico";
        }

        public override void GetRnd(ref int movement)
        {
            movement = rndMovement.Next(0, 10000);
        }
    }
}
