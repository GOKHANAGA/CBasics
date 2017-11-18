using ChessGameLibr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public class Board
    {
        public int _squareEdge = 70;
        Dictionary<string, Square> _dicSquare;

        public Board()
        {
            /*----Create a new instance for dictionary----*/
            _dicSquare = new Dictionary<string, Square>();
            /*----Fill the board on creation of instance so control will be on Class----*/
            FillTheBoard();
        }

        private void FillTheBoard()
        {
            /*----This method will fill the board with squares like a chess board with 8X8 square amount----*/
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Square square = new Square();
                    square.HorizontalPoint = x * _squareEdge;
                    square.VerticalPoint = y * _squareEdge;
                    if ((x + y) % 2 == 0)
                    {
                        square.SquareColor = SquareColor.White;
                    }
                    else
                    {
                        square.SquareColor = SquareColor.Black;
                    }
                    square.SquareName = x.ToString() + y.ToString();
                    _dicSquare.Add(square.SquareName, square);
                }
            }
        }

        public Dictionary<string, Square> DicSquare
        {
            get { return _dicSquare; }
        }

        public Square GetSquare(string squareName)
        {
            return DicSquare[squareName];
        }

        public Square AddPiece(PieceTypes pieceToAdd)
        {
            /*----Get a new instance of our piecetype for the given type of parameter----*/
            /*----Then Add this instance to our Pieces list----*/
            /*---Then get an empty square for adding our piece and return that square at last----*/
            Piece myPiece = PieceFactory.CreatePieceFactory().CreatePiece(pieceToAdd);
            Pieces.GetPieces().AddPiece(myPiece);
            Square mySquare = GetEmptySquare();
            mySquare.PiecesOnBoard = myPiece;
            return mySquare;
        }

        public bool IsHaveEmptySquare
        {
            /*----return the square if there is no piece on it----*/
            get
            {
                foreach (Square item in DicSquare.Values)
                {
                    if (item.PiecesOnBoard == null)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private Square GetEmptySquare()
        {
            /*----If  IsHaveEmptySquare returns true, try to find an empty square inside dictionary---- */
            /*----If it can find an empty square return that square,else it will throw exception----*/
            if (IsHaveEmptySquare)
            {
                Random rnd = new Random();
                int x = rnd.Next(0, 8);
                int y = rnd.Next(0, 8);
                while (!DicSquare[x.ToString() + y.ToString()].IsSquareEmpty)
                {
                    x = rnd.Next(0, 8);
                    y = rnd.Next(0, 8);
                }
                return DicSquare[x.ToString() + y.ToString()];
            }
            else
            {
                throw new Exception("Boş Kare Kalmadi");
            }
        }

        public void Beep()
        {
            Console.Beep();
        }

        private List<Square> GetFullSquares()
        {
            /*----Create a list which will hold Square types inside----*/
            List<Square> fullSquares = new List<Square>();


            foreach (Square item in DicSquare.Values)
            {
                /*----look at all Square values inside dictionary----*/
                /*----if Square is not empty then add that square to the list----*/
                if (!item.IsSquareEmpty)
                {
                    fullSquares.Add(item);
                }
            }

            /*----return filled Squares with help of List----*/
            return fullSquares;
        }

        public void MovePieces()
        {
            /*----Get filled squares*/
            List<Square> filledSquares = GetFullSquares();

            foreach (Square item in filledSquares)
            {
                /*----look at all filled squares inside list----*/
                /*----get an instance from Pieces on board for moving to a new Square----*/
                Piece pieceToMove = item.PiecesOnBoard;
                Random rnd = new Random();
                
                /*????????????????????????????????????????*/
                int xDirection = (rnd.Next(0, 2000) / 1000) == 1 ? -1 : 1;
                int MoveInX = pieceToMove.MoveX * xDirection;

                int yDirection = (rnd.Next(0,2000) / 1000) == 1 ? -1 : 1;
                int MoveInY = pieceToMove.MoveY * yDirection;

                /*----Get the x and y axis of square from its name (Square names are like"00" or "01"etc.)----*/
                int xAxisOfArray = int.Parse(item.SquareName.Substring(0, 1));
                int yAxisOfArray = int.Parse(item.SquareName.Substring(1,1));

                /*----add old axis points with movement amount and get the new axis values for x and y axises of square----*/
                int newXAxisOfArray = xAxisOfArray + MoveInX;
                int newYAxisOfArray = yAxisOfArray + MoveInY;

                /*If conditions are provided for the square to move in given axises, perform movement for piece----*/
                MoveIfConditionsProvided(newXAxisOfArray, newYAxisOfArray, item);
            }
        }

        private void MoveIfConditionsProvided(int xAxis, int yAxis, Square square)
        {
            /*----Axis values must be equal or bigger than 0 and equal or less than 7----*/
            if (xAxis >= 0 && xAxis <= 7 && yAxis >= 0 && yAxis <= 7)
            {
                /*----Get an instance for our target square----*/
                Square targetSquare = GetSquare(xAxis.ToString() + yAxis.ToString());

                if (targetSquare.IsSquareEmpty)
                {
                    /*----Check if target square is empty----*/
                    /*----if it is an empty square then move our piece to target square----*/
                    /*----After movement process make old square empty by giving its PiecesOnBoard value null----*/
                    targetSquare.PiecesOnBoard = square.PiecesOnBoard;
                    square.PiecesOnBoard = null;
                }
                else
                {
                    /*----If target square is not empty then make a Beep sound----*/
                    Beep();
                }

            }
            else
            {
                /*----If given axises are out of range for our purpose, then create a Beep sound----*/
                Beep();
            }
        }


    }
}
