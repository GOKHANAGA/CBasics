using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGameLibr
{
    public enum PieceTypes
    {
        None=0,
        Knight,
        Bishop,
        Rook
    };
    public class PieceFactory
    {
        private static PieceFactory _pieceFactory;
        private PieceFactory()
        {

        }

        public static PieceFactory CreatePieceFactory()
        {
            if (_pieceFactory == null)
            {
                _pieceFactory = new PieceFactory();
            }

            return _pieceFactory;
        }

        public Piece CreatePiece(PieceTypes typeOfPiece)
        {
            if (typeOfPiece == PieceTypes.Knight)
            {
                return new Knight();
            }
            else if (typeOfPiece == PieceTypes.Bishop)
            {
                return new Bishop();
            }
            else if (typeOfPiece == PieceTypes.Rook)
            {
                return new Rook();
            }

            /*----İstenilen veri tiplerinden birinden başka istek olursa null geri dönüşü olacak----*/
            return null;
        }
    }
}
