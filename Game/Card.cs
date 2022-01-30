using System;


namespace Team.Game
{
    class Card{
        public int cardOne = 0;
        public int cardTwo = 0;

        public Card()
        {
        }
        public void GetCard1(){
             Random r1 = new Random();
            int card1 = r1.Next(1,13);
            cardOne = card1;
        }
        public void GetCard2(){
            Random r2 = new Random();
            int card2 = r2.Next(1,13);
            cardTwo = card2;
        }

        public void displayCard1()
        {
            Console.WriteLine($"The card is: {cardOne}");
        }

        public void displayCard2()
        {
            Console.WriteLine($"The next card was: {cardTwo}");
        }

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