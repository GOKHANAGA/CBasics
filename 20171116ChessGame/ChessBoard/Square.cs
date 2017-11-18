using ChessGameLibr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public enum SquareColor
    {
        Black,
        White
    };
    public class Square
    {
        private Piece _piecesOnBoard = null;
        private int _horizontalPoint;
        private int _verticalPoint;
        private SquareColor _squareColor;
        private string _squareName;

        public Piece PiecesOnBoard
        {
            get { return _piecesOnBoard; }
            set { _piecesOnBoard = value; }
        }

        public int HorizontalPoint
        {
            get { return _horizontalPoint; }
            set { _horizontalPoint = value; }
        }

        public int VerticalPoint
        {
            get { return _verticalPoint; }
            set { _verticalPoint = value; }
        }

        public SquareColor SquareColor
        {
            get { return _squareColor; }
            set { _squareColor = value; }
        }

        public string SquareName
        {
            get { return _squareName; }
            set { _squareName = value; }
        }

        public bool IsSquareEmpty { get { return PiecesOnBoard == null; } }
    }

}
