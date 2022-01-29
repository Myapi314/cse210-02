using System;


namespace Team.Game
{
    class Program{
        static int GetCard1(){
             Random r1 = new Random();
            int card1 = r1.Next(1,13);
            return card1;
        }
        static int GetCard2(){
            Random r2 = new Random();
            int card2 = r2.Next(1,13);
            return card2;
        }
        static bool hilo(){
          int n1 = GetCard1();
          int n2 = GetCard2();
          bool v = false;
          if(n1 < n2){
              v = true;
          }
          else v = false;
          return v;  
        }

    }
}