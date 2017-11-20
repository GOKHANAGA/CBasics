using ChessBoard;
using ChessGameLibr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Board gameBoard = new Board();
        PieceFactory pieceFactory;
        Dictionary<string, Label> labelsInForm = new Dictionary<string, Label>();
        int timeCount = 0;
        /*----Pieces will move around for givin time to limit(10 seconds for default)----*/
        const int timeLimit = 10;


        private void Form1_Load(object sender, EventArgs e)
        {
            /*----Square square in gameBoard.DicSquare.GetValues()----*/
            foreach (KeyValuePair<string, Square> kvItem in gameBoard.DicSquare)
            {
                Label lbl = new Label();
                lbl.Size = new Size(gameBoard._squareEdge, gameBoard._squareEdge);
                int x = kvItem.Value.HorizontalPoint;
                int y = kvItem.Value.VerticalPoint;
                lbl.Location = new Point(x, y);
                lbl.Name = kvItem.Value.SquareName;
                if (kvItem.Value.SquareColor == SquareColor.White)
                {
                    lbl.BackColor = Color.White;
                }
                else
                {
                    lbl.BackColor = Color.Black;
                }

                labelsInForm.Add(lbl.Name, lbl);
                this.Controls.Add(lbl);
                pieceFactory = PieceFactory.CreatePieceFactory();
            }
            cmbPieces.DataSource = Enum.GetValues(typeof(PieceTypes));
        }

        private void cmbPieces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPieces.SelectedIndex != 0)
            {
                PieceTypes pieceType =
                    (PieceTypes)Enum.Parse(typeof(PieceTypes), cmbPieces.Text);

                Square squareToHoldPiece = gameBoard.AddPiece(pieceType);
                
                foreach (KeyValuePair<string, Label> kvItem in labelsInForm)
                {
                    if (squareToHoldPiece.SquareName == kvItem.Key)
                    {
                        kvItem.Value.Image = 
                            Image.FromFile(squareToHoldPiece.PiecesOnBoard.PieceImage());
                    }
                }

            }
        }

        private void btnMovePieces_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeCount >= timeLimit)
            {
                timeCount = 0;
                timer1.Stop();
            }

            gameBoard.MovePieces();

            foreach (KeyValuePair<string,Label> kvItem in labelsInForm)
            {
                kvItem.Value.Image = null;
            }

            foreach (KeyValuePair<string,Square> kvItem in gameBoard.DicSquare)
            {
                if (kvItem.Value.PiecesOnBoard != null)
                {
                    labelsInForm[kvItem.Value.SquareName].Image = 
                        Image.FromFile(kvItem.Value.PiecesOnBoard.PieceImage());
                }
            }

            timeCount++;
        }



    }
}
