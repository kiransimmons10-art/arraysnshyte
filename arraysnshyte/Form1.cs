using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace arraysnshyte
{
    public partial class Form1 : Form
    {//global randoms
        Random randgen = new Random();
      //making the groups of numbers
        int[] numbers = new int[7];
        int[] numbers2 = new int[7];

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void runbutton_Click(object sender, EventArgs e)
        {//emptying text boxes 
            array1label.Text = "";
            array2label.Text = "";
            reversearray1.Text = "";


            //both arrays generating 
            //same formula used across the code, 
            for (int i = 0; i < numbers.Length; i++) { 
                //randomly generating each number in the arrays
            numbers[i] = randgen.Next(0,10);
         
                numbers2[i] = randgen.Next(0, 10);
          //displaying the numbers side by side 
                array1label.Text += numbers[i]+" ";
                
                array2label.Text += numbers2[i]+" ";

            }
            //inverted array 1
            for (int i = numbers.Length - 1; i >= 0; i--) {
                //displaying the arrays but i counting down
            reversearray1.Text += numbers[i]+" ";
            }
           
            //som of evens calculating
            int total = 0;
          
            for (int i = 0; i < numbers.Length; i++) {
                //try catch just so it doesnt crash if empty or with letters 
                try
                {
                    if (numbers[i] % 2 == 0)
                        //if i is divisible by 2 then add to total
                        total = total + numbers[i];

                }
                catch
                { //no catch command because of the command belod} 
                }
                sumofevenlabel.Text = total + "";
                
            }
            //average of all
            double truetotal = 0;
            for (int i = 0; i < numbers.Length ; i++)
            {//adding each conecutive number to the previous total 
                truetotal = truetotal + numbers[i];
            }
            //dividing the total by the amount of numbers for the average 
            double average = truetotal/ numbers.Length;
            //capping the result at two decimals 
            avglabel.Text = average.ToString("f2");

            //intergers in the same place 
            int sameplacenum = 0;
            for (int i = 0; i < numbers.Length; i++) { 
                //if digits in the same place are equal then the total goes up 
             if ( numbers[i] == numbers2[i] ) 
                    sameplacenum++;
            
            }
            matchingvalueslabel.Text = sameplacenum + "";


            //number of threes 

            int numof3s = 0;
            for (int i = 0; i < numbers.Length; i++)
            {//simply if a number is 3 then total goes up 
                if (numbers[i] == 3)
                    numof3s++;
            }
            totalnumof3label.Text = numof3s + "";

            //largest number 
            int bigone = 0;
            for (int i = 0; i < numbers.Length; i++) { 
                //couldnt figure out sorting non lists or converting this set of numbers to a list
                //so just if a number is bigger than the prior int then the number becomes the new int
            if (bigone < numbers[i]) {  bigone=numbers[i]; }
            }
            maxlabel.Text = bigone + "";

            first0label.Text = "";
            //finding the fist 0
            for (int i = 0; i < numbers.Length; i++) {
                //if number is zero then set label to i and end the for program
                if (numbers[i] == 0)
                {
                    first0label.Text = i + 1 + "";
                    i = numbers.Length;
                }
                else
                    first0label.Text = "Null";
            }

            //got bored on a flight doing more coding for funsies
            //all evens minus all odds
            int evens = 0;
            int odds = 0;
            int oddsevenstotal = 0;
            for (int i =0; i< numbers.Length; i++)
            {
                if (numbers[i] %2 ==0) { evens = evens + numbers[i]; }
                else { odds = odds + numbers[i]; }

            }
            oddsevenstotal = evens - odds;
            oddstotallabel.Text = odds + "";
            extralabel.Text = oddsevenstotal + "";

            //still bored doing array 1 - array 2 
            int totalarray1 = 0;
            int totalarray2 = 0;
            for (int i =0; i <numbers.Length; i++)
            {
                totalarray1 += numbers[i];
                totalarray2 += numbers2[i];
            }
            arraysublabel.Text = totalarray1 - totalarray2 + "";

            //more bored, gonna try for if numbers are in an ascending order
            int prenum = 0;
            int ifneeded = 0;
            int ascendingcount = 0;
            for (int i = 0; i <numbers.Length; i++)
            {
                if (numbers[i]== prenum + 1 && numbers[i]>0) { ascendingcount++;
                }
                prenum = numbers[i];

            }
            ascendinglabel.Text = ascendingcount + "";

            //this flight is never going to end 




            //swapping lists for eachother
            int swap1 = 0;
            int swap2 = 0;

            for (int i = 0; i < numbers.Length; i++) {
                //saving the value 
                swap1= numbers[i];
                swap2= numbers2[i];
                //replacing with the opposites value 
                numbers[i] = swap2;
                numbers2[i] = swap1;
            
            }
            array1swap.Text = "";
            array2swap.Text =  "";
            //displaying all variables
            for (int i = 0; i < numbers.Length; i++) {
                array1swap.Text += numbers[i] + " ";
                array2swap.Text += numbers2[i] + " ";
            }


        }

        private void matchingvalueslabel_Click(object sender, EventArgs e)
        {

        }

        private void clickme_Click(object sender, EventArgs e)
        {
          // Label.ControlCollection.
        }
    }
}
