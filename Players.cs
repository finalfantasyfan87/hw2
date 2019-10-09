using System;
using System.Collections.Generic;

namespace HW2
{
    public class Players
    {
        public int numPlayers;
        private SeLinkList head;
      public struct PlayerData
       {
            public int a;
            public int b;
            public int c;

 public PlayerData(int dataA, int dataB, int dataC)
            {
                a = dataA;
                b = dataB;
                c = dataC;

            }
        }

      public Players()
      {
          numPlayers = 0;
          head = null;
      }
      //similar to the push method of a double linked list
      SeLinkList addPlayer(int a, int b, int c)
      {
          SeLinkList newPlayer = new SeLinkList(a, b, c);

          newPlayer.prev = null;
          newPlayer.next = head;

          if (head != null)
          {
              head.prev = newPlayer;
              head = newPlayer;

          }
          return head;

      }
      

      public double findMaxWeight(SeLinkList head)
      {
          SeLinkList heaviest, current;
          current = heaviest =head;
          while (current != null)
          {
              if (current.getWeight() > heaviest.getWeight())
              {
                  heaviest = current;
                  current = current.next;
              }

             
          }

          return heaviest.getWeight();
      }

      public  List<PlayerData> initializeList()
      {
          List<PlayerData> players = new List<PlayerData>();
          foreach (PlayerData player in myData)
          {
              addPlayer(player.a, player.b, player.c);
              players.Add();
          }
          return new PlayerData();
      }

      public void PrintList()
      {
          Console.WriteLine(initializeList());
      }
        public PlayerData[] myData = new PlayerData[]
        {
         new PlayerData( 22, 9, 9 ),
         new PlayerData( 3, 26, 9 ),
         new PlayerData( 23, 24, 1 ),
         new PlayerData( 20, 13, 6 ),
         new PlayerData( 15, 19, 2 ),
         new PlayerData( 14, 4, 24 ),
         new PlayerData( 3, 6, 14 ),
         new PlayerData( 10, 10, 11 ),
         new PlayerData( 5, 7, 22 ),
         new PlayerData( 1, 11, 0 ),
         new PlayerData( 26, 19, 24 ),
         new PlayerData( 5, 28, 9 ),
         new PlayerData( 6, 24, 17 ),
         new PlayerData( 29, 22, 24 ),
         new PlayerData( 24, 10, 22 ),
         new PlayerData( 22, 11, 13 ),
         new PlayerData( 7, 12, 27 ),
         new PlayerData( 3, 11, 22 ),
         new PlayerData( 16, 12, 28 ),
         new PlayerData( 28, 28, 19 ),
         new PlayerData( 17, 21, 13 ),
         new PlayerData( 1, 24, 23 ),
         new PlayerData( 12, 10, 20 ),
         new PlayerData( 22, 8, 10 ),
         new PlayerData( 6, 3, 13 ),
         new PlayerData( 19, 15, 0 ),
         new PlayerData( 19, 13, 25 ),
         new PlayerData( 8, 24, 28 ),
         new PlayerData( 2, 23, 8 ),
         new PlayerData( 2, 18, 16 ),
         new PlayerData( 11, 8, 26 ),
         new PlayerData( 27, 11, 1 ),
         new PlayerData( 11, 23, 16 ),
         new PlayerData( 28, 9, 1 ),
         new PlayerData( 22, 14, 4 ),
         new PlayerData( 17, 26, 7 ),
         new PlayerData( 8, 27, 27 ),
         new PlayerData( 27, 9, 15 ),
         new PlayerData( 23, 9, 27 ),
         new PlayerData( 14, 28, 1 ),
         new PlayerData( 14, 9, 21 ),
         new PlayerData( 4, 11, 0 ),
         new PlayerData( 14, 9, 22 ),
         new PlayerData( 12, 8, 22 ),
         new PlayerData( 14, 20, 3 ),
         new PlayerData( 23, 15, 10 ),
         new PlayerData( 24, 15, 26 ),
        };
    }
}

