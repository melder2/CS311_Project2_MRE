/**
 * Michael Elder
 * Project 2
 * This class creates a simulation of the game craps applied with all the rules. It contains two labels that return
 * the dice values, a bank balance label, a bet text box, and a label with the result of the game
 */
namespace CS311_Project2_MRE
{
    public partial class Craps : Form
    {
        int point = 0;
        double bank = 100.00;
        double bet = 0;
        public Craps()
        {
            InitializeComponent();
        }//end constructor

        /*
         * button1_Click method makes sure you have enough money in your bank balance to make the bet
         */
        private void button1_Click(object sender, EventArgs e)
        {
            lblBankBalance.Text = bank.ToString("C");
            
            if (bank >= bet)
            {
                calculate_score();
            }//end if statement
            else if (bank == 0)
            {
                MessageBox.Show("You have $0 in your bank account.");
            }//end else if statement
            else if (bank < bet)
            {
                MessageBox.Show("You have insufficient funds.");
            }//end else if statement
        }//end button1_Click method
        /*
         * calculate_score method generates two random numbers for each dice, calculates the sum, determines the outcome
         * through the switch and if else statements according to the rules given, displays the value of the dice, displays
         * a message about winning(if the player wins, adds the bet to their bank) or losing(if the player loses, subtracts the bet
         * from the bank), and displays correct balance in the bank balance label
         * 
         */
        private void calculate_score()
        {
            
            lblFirstDice.Text = "";
            lblSecondDice.Text = "";
            lblResult.Text = "";
            //resets the labels to blank strings after each roll

            Random die1 = new Random();
            Random die2 = new Random();
            //creating two random objects
            
            int dice1 = die1.Next(1, 7);
            int dice2 = die2.Next(1, 7);
            int sum = dice1 + dice2;
            //assigning the two random objects to dice1 and dice2

            lblFirstDice.Text = dice1.ToString();
            lblSecondDice.Text = dice2.ToString();
            //assigning the dice1 and dice2 to the labels where they are supposed to go
            
            Console.WriteLine(lblFirstDice);
            Console.WriteLine(lblSecondDice);
            //print out the first and second dice value 
            txtBet.Text = bet.ToString("C");

            if (point == 0)
            {
                switch (sum)
                {
                    case 2:
                        lblResult.Text = ("You lose!");
                        Console.WriteLine(lblResult.Text);
                        bank = bank - bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance);
                        break;
                        //if sum is 2, it will print the result "You lose!", subtract the bet from the bank, and write the updated bank balance
                    case 3:
                        lblResult.Text = ("You lose!");
                        Console.WriteLine(lblResult.Text);
                        bank = bank - bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance);
                        break;
                        //if sum is 3, it will print the result "You lose!", subtract the bet from the bank, and write the updated bank balance

                    case 12:
                        lblResult.Text = ("You lose!");
                        Console.WriteLine(lblResult.Text);
                        bank = bank - bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance);
                        break;
                        //if sum is 12, it will print the result "You lose!", subtract the bet from the bank, and write the updated bank balance

                    case 7:
                        lblResult.Text = ("You win!");
                        Console.WriteLine(lblResult.Text);
                        bank = bank + bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance);
                        break;
                        //if sum is 7, it will print the result "You win!", add the bet to the bank, and write the updated bank balance
                    
                    case 11:
                        Console.WriteLine("You win!");
                        bank = bank + bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance);
                        break;
                        //if sum is 11, it will print the result "You win!", add the bet to the bank, and write the updated bank balance


                    default:
                        point = sum;
                        lblResult.Text = ("Point is " + point);
                        Console.WriteLine(lblResult.Text);
                        break;
                        //if sum isn't 2, 3, 7, 11, or 12 it will print "Point is " + point and carry the bet over

                }//end switch statement
            }//end if statement
            else if ((point != 0) && (point == sum))
            {
                Console.WriteLine("You win!");
                bank = bank + bet;
                lblBankBalance.Text = bank.ToString("C");

            }//end else if statement
            else if (point != 0)
            {
                switch (sum)
                {
                    case 7:
                        lblResult.Text = ("You lose!");
                        Console.WriteLine(lblResult.Text);
                        bank = bank - bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance);
                        break;
                        //if sum is 7, it will print the result "You lose!", subtract the bet from the bank, and write the updated bank balance
                    
                    default:
                        lblResult.Text = ("You win!");
                        Console.WriteLine(lblResult);
                        bank = bank + bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance);
                        break;
                        //if sum isn't 7, it will print the result "You win!", add the bet to the bank, and write the updated bank balance

                }//end switch statement
            }//end else if statement
            else if (point != 0)
            {
                switch (sum)
                {
                    case 7:
                        lblResult.Text = ("You lose!");
                        Console.WriteLine(lblResult.Text);
                        bank = bank - bet;
                        lblBankBalance.Text = bank.ToString("C");
                        Console.WriteLine(lblBankBalance.Text);
                        break;
                        //if sum is 7, it will print the result "You lose!", subtract the bet from the bank, and write the updated bank balance
                    default:
                        lblResult.Text = "Point is " + point;
                        Console.WriteLine(lblResult.Text);
                        break;
                        //if sum isn't 7, it will print "Point is " + point
                }//end switch statement
            }//end else if statement
        
        }//end caclulate_score

        private void lblFirstDice_Click(object sender, EventArgs e)
        {
          
        }//end lblFirstDice_Click

        private void lblSecondDice_Click(object sender, EventArgs e)
        {
            
        }//end lblSecondDice_Click

        private void txtBet_TextChanged(object sender, EventArgs e)
        {
            
        }//end txtBet_TextChanged

        private void lblResult_Click(object sender, EventArgs e)
        {

        }//end lblResult_Click

        private void Craps_Load(object sender, EventArgs e)
        {

        }//end Craps_Load
    }//end class
}//end namespace