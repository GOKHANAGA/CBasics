using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameLibr
{
    public class Pieces
    {
        private List<Piece> _pieceList;
        private static Pieces pieceInstance;

        private Pieces()
        {
            _pieceList = new List<Piece>();
        }

        public static Pieces GetPieces()
        {
            if (pieceInstance == null)
            {
                pieceInstance = new Pieces();
            }

            return pieceInstance;
        }

        public void AddPiece(Piece piece)
        {
            _pieceList.Add(piece);
        }

        public List<Piece> GetList()
        {
            return _pieceList;
        }

    }
}
