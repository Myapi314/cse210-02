using System;


namespace Team.Game
{
    class Card{
        /*Variables to Store Card #s*/
        public int cardOne = 0;
        public int cardTwo = 0;

        public Card()
        {

        }
         /*Get First Card*/
        public void GetCard1(){
             Random r1 = new Random();
            int card1 = r1.Next(1,13);
            cardOne = card1;
        }
         /*Get Second Card and compare to make sure both cards are not equal. 
         If the values are equal repeat GetCard2()*/
        public void GetCard2(){
            Random r2 = new Random();
            int card2 = r2.Next(1,13);
            while(cardOne == card2){
                GetCard2();
            }
            cardTwo = card2;
        }

        /*Display First Card Value*/

        public void DisplayCard1()
        {
            Console.WriteLine($"The card is: {cardOne}");
        }
        //Display Second Card Value//
        public void DisplayCard2()
        {
            Console.WriteLine($"The next card was: {cardTwo}");
        }
        //Compare both card values and determine which card is higher//
        public bool isHigher(){
          int n1 = cardOne;
          int n2 = cardTwo;
          bool v = false;
          if(n1 < n2){
              v = true;
          }
          else v = false;
          return v;  
        }

    }
}