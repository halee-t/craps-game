using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ‘LAB #4 
‘FALL SEMESTER
‘HALEE, TISLER
‘I fully understand the following statement.
‘OU PLAGIARISM POLICY
‘All members of the academic community at Oakland are expected to practice and uphold ‘standards 
of academic integrity and honesty. An instructor is expected to inform and instruct ‘students about 
the procedures and standards of research and documentation required of students ‘in fulfilling 
course work. A student is expected to follow such instructions and be sure the rules ‘and procedures 
are understood in order to avoid inadvertent misrepresentation of his work. ‘Students must assume 
that individual (unaided) work on exams and lab reports and documentation ‘of sources is expected 
unless the instructor specifically says that is not necessary.
‘The following definitions are some examples of academic dishonesty:
 ‘Plagiarizing from work of others. Plagiarism is using someone else's work or ideas without 
‘giving the other person credit; by doing this, a student is, in effect, claiming credit for 
‘someone else's thinking. Whether the student has read or heard the information he/she uses, 
‘the student must document the source of information. When dealing with written sources, 
‘a clear distinction would be made between quotations (which reproduce information from 
‘the source word-for-word within quotation marks) and paraphrases (which digest the 
‘source information and produce it in the student's own words). Both direct quotations and 
‘paraphrases must be documented. Just because a student rephrases, condenses or selects 
‘from another person's work, the ideas are still the other person's, and failure to give ‘credit 
constitutes misrepresentation of the student's actual work and plagiarism of ‘another's ideas. 
Naturally, buying a paper and handing it in as one's own work is ‘plagiarism.
 ‘Cheating on lab reports falsifying data or submitting data not based on student's own work.
*/

namespace Craps_Game
{
    public partial class Craps : Form
    {
        int p = 0; //set a form level variable for the point
        int s = 1; //set a form level variable for the state of the game
        int v; //set a form level variable for the score
        public Craps()
        {
            InitializeComponent();
        }

        private void lblOff_Click(object sender, EventArgs e)
        {
            //accidental click
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //make all of the dice invisible at the start
            picBox1Die1.Visible = false;
            picBox1Die2.Visible = false;
            picBox1Die3.Visible = false;
            picBox1Die4.Visible = false;
            picBox1Die5.Visible = false;
            picBox1Die6.Visible = false;

            picBox2Die1.Visible = false;
            picBox2Die2.Visible = false;
            picBox2Die3.Visible = false;
            picBox2Die4.Visible = false;
            picBox2Die5.Visible = false;
            picBox2Die6.Visible = false;

            Random myGenerator = new Random(); //generate a random number for the dice roll
            int D1 = 0;
            int D2 = 0;
            D1 = myGenerator.Next(1, 7);
            D2 = myGenerator.Next(1, 7);

            //Display whatever die needs to be shown to correspond with the number
            //that was generated
            if (D1 == 1) 
            {
                picBox1Die1.Visible = true;
                lblDie1.Text = "DIE 1: 1"; 
            }
            
            if (D1 == 2)
            {
                picBox1Die2.Visible = true;
                lblDie1.Text = "DIE 1: 2";
            }

            if (D1 == 3)
            {
                picBox1Die3.Visible = true;
                lblDie1.Text = "DIE 1: 3";
            }

            if (D1 == 4)
            {
                picBox1Die4.Visible = true;
                lblDie1.Text = "DIE 1: 4";
            }

            if (D1 == 5)
            {
                picBox1Die5.Visible = true;
                lblDie1.Text = "DIE 1: 5";
            }

            if (D1 == 6)
            {
                picBox1Die6.Visible = true;
                lblDie1.Text = "DIE 1: 6";
            }

            if (D2 == 1)
            {
                picBox2Die1.Visible = true;
                lblDie2.Text = "DIE 2: 1";
            }

            if (D2 == 2)
            {
                picBox2Die2.Visible = true;
                lblDie2.Text = "DIE 2: 2";
            }

            if (D2 == 3)
            {
                picBox2Die3.Visible = true;
                lblDie2.Text = "DIE 2: 3";
            }

            if (D2 == 4)
            {
                picBox2Die4.Visible = true;
                lblDie2.Text = "DIE 2: 4";
            }

            if (D2 == 5)
            {
                picBox2Die5.Visible = true;
                lblDie2.Text = "DIE 2: 5";
            }

            if (D2 == 6)
            {
                picBox2Die6.Visible = true;
                lblDie2.Text = "DIE 2: 6";
            }

            //Caclulate and display the total of the boxes 
            int T = 0;
            T = D1 + D2;
            lblTotal.Text = "TOTAL: " + T.ToString();

            //either set the point, display that they won, or display that they lost
            //based on the first roll
            if (s == 1)
            {
                lblON4.Visible = false;
                lblON5.Visible = false;
                lblON6.Visible = false;
                lblON8.Visible = false;
                lblON9.Visible = false;
                lblON10.Visible = false;
                lblPoint.Text = "POINT: ";

                if (T == 7 || T ==11) //win on first roll, add a point to the score
                {
                    lblWinnerLoser.Text = "WINNER!";
                    v = v + 1;
                    lblScore.Text = "SCORE: " + v.ToString();
                    s = 1;
                    lblDirections.Text = "You won! Roll dice to start a new game.";
                    lblON4.Visible = false;
                    lblON5.Visible = false;
                    lblON6.Visible = false;
                    lblON8.Visible = false;
                    lblON9.Visible = false;
                    lblON10.Visible = false;
                    lblOFF.Visible = true;
                }

                else if (T == 2 || T == 3 || T == 12) //lose on first roll, deduct a point
                                                      //from the score
                {
                    lblWinnerLoser.Text = "LOSER!";
                    v = v - 1;
                    lblScore.Text = "SCORE: " + v.ToString();
                    s = 1;
                    lblDirections.Text = "You lose :( Roll dice to start a new game.";
                    lblON4.Visible = false;
                    lblON5.Visible = false;
                    lblON6.Visible = false;
                    lblON8.Visible = false;
                    lblON9.Visible = false;
                    lblON10.Visible = false;
                    lblOFF.Visible = true;
                }

                else //total sets the point, move to Roll Again state
                {
                    lblWinnerLoser.Text = " ";
                    s = 2;
                    p = T;
                    lblPoint.Text = "POINT: " + p.ToString();
                    lblDirections.Text = "The point is " + p.ToString() + ". Roll again.";
                    lblOFF.Visible = false;
                }

            }

            else //Roll Again state
            {
                if (T == p) //total of dice roll equals the point, win and add a point 
                {
                    lblWinnerLoser.Text = "WINNER";
                    s = 1;
                    //v += 1;
                    v = v + 1;
                    lblScore.Text = "SCORE: " + v.ToString();
                    lblDirections.Text = "You won! Roll dice to start a new game.";
                    lblOFF.Visible = true;
                    p = 0;

                    lblON4.Visible = false;
                    lblON5.Visible = false;
                    lblON6.Visible = false;
                    lblON8.Visible = false;
                    lblON9.Visible = false;
                    lblON10.Visible = false;
                }

                else if (T == 7) //total of dice roll equals 7, lose and deduct a point
                {
                    lblWinnerLoser.Text = "LOSER";
                    s = 1;
                    //v += -1;
                    v = v - 1;
                    lblScore.Text = "SCORE: " + v.ToString();
                    lblDirections.Text = "You lose :( Roll dice to start a new game.";
                    lblOFF.Visible = true;
                    p = 0;

                    lblON4.Visible = false;
                    lblON5.Visible = false;
                    lblON6.Visible = false;
                    lblON8.Visible = false;
                    lblON9.Visible = false;
                    lblON10.Visible = false;
                }

                else //dice total was neither, keep rolling
                {
                    s = 2;
                    lblOFF.Visible = false;
                }
            }

            //makking the ON pucks visible based on the point
            if (p == 4)
            {
                lblON4.Visible = true;
            }

            if (p == 5)
            {
                lblON5.Visible = true;
            }

            if (p == 6)
            {
                lblON6.Visible = true;
            }

            if (p == 8)
            {
                lblON8.Visible = true;
            }

            if (p == 9)
            {
                lblON9.Visible = true;
            }

            if (p == 10)
            {
                lblON10.Visible = true;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            this.Close();
        }
    }
}
