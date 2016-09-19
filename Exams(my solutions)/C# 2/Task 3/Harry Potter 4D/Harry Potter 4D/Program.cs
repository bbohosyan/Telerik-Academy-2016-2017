using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string[] firstLineToArray = firstLine.Split(' ');
            int aCube = int.Parse(firstLineToArray[0]);
            int bCube = int.Parse(firstLineToArray[1]);
            int cCube = int.Parse(firstLineToArray[2]);
            int dCube = int.Parse(firstLineToArray[3]);



            string secondLine = Console.ReadLine();
            string[] secondLineToArray = secondLine.Split(' ');
            int aHP = int.Parse(secondLineToArray[0]);
            int bHP = int.Parse(secondLineToArray[1]);
            int cHP = int.Parse(secondLineToArray[2]);
            int dHP = int.Parse(secondLineToArray[3]);

            int numDragons = int.Parse(Console.ReadLine());

            char[] nameDragons = new char[numDragons];
            int[] aDragons = new int[numDragons];
            int[] bDragons = new int[numDragons];
            int[] cDragons = new int[numDragons];
            int[] dDragons = new int[numDragons];

            for (int i = 0; i < numDragons; i++)
            {
                string readLine = Console.ReadLine();
                string[] readLineToArray = readLine.Split(' ');

                nameDragons[i] = char.Parse(readLineToArray[0]);
                aDragons[i] = int.Parse(readLineToArray[1]);
                bDragons[i] = int.Parse(readLineToArray[2]);
                cDragons[i] = int.Parse(readLineToArray[3]);
                dDragons[i] = int.Parse(readLineToArray[4]);

            }

            List<string> moves = new List<string>();
            while (true)
            {
                string readMove = Console.ReadLine();
                if (readMove == "END")
                {
                    break;
                }
                moves.Add(readMove);
            }

            int numHPMoves = 0;
            bool isCatched = false;
            for (int i = 0; i < moves.Count; i++)
            {
                string[] movesToArray = moves[i].Split(' ');
                char nameCurrendDragon = char.Parse(movesToArray[0]);
                char moveDimension = char.Parse(movesToArray[1]);
                int movementValue = int.Parse(movesToArray[2]);
                if (nameCurrendDragon != '@')
                {
                    int index = Array.IndexOf(nameDragons, nameCurrendDragon);

                    if (moveDimension == 'A')
                    {
                        aDragons[index] += movementValue;
                        if (aDragons[index] < 0)
                        {
                            aDragons[index] = 0;
                        }
                        else if (aDragons[index] > aCube - 1)
                        {
                            aDragons[index] = aCube - 1;
                        }
                        if (aHP == aDragons[index] && bHP == bDragons[index] && cHP == cDragons[index] && dHP == dDragons[index])
                        {
                            Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}", nameDragons[index], numHPMoves);
                            isCatched = true;
                            break;
                        }
                    }
                    else if (moveDimension == 'B')
                    {
                        bDragons[index] += movementValue;
                        if (bDragons[index] < 0)
                        {
                            bDragons[index] = 0;
                        }
                        else if (bDragons[index] > bCube - 1)
                        {
                            bDragons[index] = bCube - 1;
                        }
                        if (aHP == aDragons[index] && bHP == bDragons[index] && cHP == cDragons[index] && dHP == dDragons[index])
                        {
                            Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}", nameDragons[index], numHPMoves);
                            isCatched = true;
                            break;
                        }
                    }
                    else if (moveDimension == 'C')
                    {
                        cDragons[index] += movementValue;
                        if (cDragons[index] < 0)
                        {
                            cDragons[index] = 0;
                        }
                        else if (cDragons[index] > cCube - 1)
                        {
                            cDragons[index] = cCube - 1;
                        }
                        if (aHP == aDragons[index] && bHP == bDragons[index] && cHP == cDragons[index] && dHP == dDragons[index])
                        {
                            Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}", nameDragons[index], numHPMoves);
                            isCatched = true;
                            break;
                        }
                    }
                    else if (moveDimension == 'D')
                    {
                        dDragons[index] += movementValue;
                        if (dDragons[index] < 0)
                        {
                            dDragons[index] = 0;
                        }
                        else if (dDragons[index] > dCube)
                        {
                            dDragons[index] = dCube - 1;
                        }
                        if (aHP == aDragons[index] && bHP == bDragons[index] && cHP == cDragons[index] && dHP == dDragons[index])
                        {
                            Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}", nameDragons[index], numHPMoves);
                            isCatched = true;
                            break;
                        }
                    }
                }
                else
                {
                    numHPMoves++;
                    if (moveDimension == 'A')
                    {
                        aHP += movementValue;
                        if (aHP < 0)
                        {
                            aHP = 0;
                        }
                        else if (aHP > aCube - 1)
                        {
                            aHP = aCube - 1;
                        }
                        List<char> drakesCompare = new List<char>();
                        for (int z = 0; z < nameDragons.Length; z++)
                        {
                            if (aDragons[z] == aHP && bDragons[z] == bHP && cDragons[z] == cHP && dDragons[z] == dHP)
                            {

                                drakesCompare.Add(nameDragons[z]);
                                isCatched = true;
                            }
                        }
                        if (isCatched == true)
                        {
                            drakesCompare.Sort();
                            Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\"", drakesCompare[0], numHPMoves);
                            Console.WriteLine("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", drakesCompare[0]);
                            break;
                        }

                    }
                    else if (moveDimension == 'B')
                    {
                        bHP += movementValue;
                        if (bHP < 0)
                        {
                            bHP = 0;
                        }
                        else if (bHP > bCube - 1)
                        {
                            bHP = bCube - 1;
                        }
                        List<char> drakesCompare = new List<char>();
                        for (int z = 0; z < nameDragons.Length; z++)
                        {
                            if (aDragons[z] == aHP && bDragons[z] == bHP && cDragons[z] == cHP && dDragons[z] == dHP)
                            {

                                drakesCompare.Add(nameDragons[z]);
                                isCatched = true;
                            }
                        }
                        if (isCatched == true)
                        {
                            drakesCompare.Sort();
                            Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\"", drakesCompare[0], numHPMoves);
                            Console.WriteLine("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", drakesCompare[0]);
                            break;
                        }
                    }
                    else if (moveDimension == 'C')
                    {
                        cHP += movementValue;
                        if (cHP < 0)
                        {
                            cHP = 0;
                        }
                        else if (cHP > cCube - 1)
                        {
                            cHP = cCube - 1;
                        }
                        List<char> drakesCompare = new List<char>();
                        for (int z = 0; z < nameDragons.Length; z++)
                        {
                            if (aDragons[z] == aHP && bDragons[z] == bHP && cDragons[z] == cHP && dDragons[z] == dHP)
                            {

                                drakesCompare.Add(nameDragons[z]);
                                isCatched = true;
                            }
                        }
                        if (isCatched == true)
                        {
                            drakesCompare.Sort();
                            Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\"", drakesCompare[0], numHPMoves);
                            Console.WriteLine("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", drakesCompare[0]);
                            break;
                        }
                    }
                    else if (moveDimension == 'D')
                    {
                        dHP += movementValue;
                        if (dHP < 0)
                        {
                            dHP = 0;
                        }
                        else if (dHP > dCube - 1)
                        {
                            dHP = dCube - 1;
                        }
                        List<char> drakesCompare = new List<char>();
                        for (int z = 0; z < nameDragons.Length; z++)
                        {
                            if (aDragons[z] == aHP && bDragons[z] == bHP && cDragons[z] == cHP && dDragons[z] == dHP)
                            {

                                drakesCompare.Add(nameDragons[z]);
                                isCatched = true;
                            }
                        }
                        if (isCatched == true)
                        {
                            drakesCompare.Sort();
                            Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\"", drakesCompare[0], numHPMoves);
                            Console.WriteLine("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", drakesCompare[0]);
                            break;
                        }
                    }
                }
            }
            if (!isCatched)
            {
                Console.WriteLine("{0}: \"I am the chosen one!\" - {1}", '@', numHPMoves);
            }
        }
    }
}