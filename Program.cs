using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetP4
{
    internal class Program
    {
        static string KeyInput = "";

        static bool gameover = true;
        static bool P1ORP2 = true;

        static string[] L1 = new string[7];
        static string[] L2 = new string[7];
        static string[] L3 = new string[7];
        static string[] L4 = new string[7];
        static string[] L5 = new string[7];
        static string[] L6 = new string[7];
        

        static void DisplayArray(string[] arr, bool Player)
        {
            Console.Write("| ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "0")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (arr[i] == "O")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(arr[i]);

                Console.ResetColor();

                if (i < arr.Length - 1)
                {
                    Console.Write(" | ");
                }
            }
            Console.WriteLine(" |");
        }
        static bool ChekW()
        {
            bool WL1 = ChekWL(L1);
            bool WL2 = ChekWL(L2);
            bool WL3 = ChekWL(L3);
            bool WL4 = ChekWL(L4);
            bool WL5 = ChekWL(L5);
            bool WL6 = ChekWL(L6);
            if (WL1 || WL2 || WL3 || WL4 || WL5 || WL6 || ChekWC(L1, L2, L3, L4, L5, L6) || ChekWD(L1, L2, L3, L4, L5, L6))
            {
                gameover = true;
                return true;
            }
            else 
            {
                return false;
            }
        }
        static bool ChekWL(string[] arr)
        {
            for (int i = 0; i < arr.Length - 4; i++)
            {
                if (arr[i] == arr[i + 1] && arr[i] == arr[i + 2] && arr[i] == arr[i + 3] && arr[i] != " ")
                {
                    return true;
                }
                Console.WriteLine(i);
            }
            return false;
        }
        static bool ChekWC(string[] L1, string[] L2, string[] L3, string[] L4, string[] L5, string[] L6) 
        {
            for (int i = 0; i < L1.Length; i++)
            {
                if (L1[i] == L2[i] && L1[i] == L3[i] && L1[i] == L4[i] && L1[i] != " ")
                {
                    return true;
                }
                if (L2[i] == L3[i] && L2[i] == L4[i] && L2[i] == L5[i] && L2[i] != " ")
                {
                    return true;
                }
                if (L3[i] == L4[i] && L3[i] == L5[i] && L3[i] == L6[i] && L3[i] != " ")
                {
                    return true;
                }
            }
            return false;
        }
        static bool ChekWD(string[] L1, string[] L2, string[] L3, string[] L4, string[] L5, string[] L6) 
        {
            for (int i = 0; i < L1.Length - 3; i++)
            {
                if (L6[i] == L5[i + 1] && L6[i] == L4[i + 2] && L6[i] == L3[i + 3] && L6[i] != " ")
                {
                    return true;
                }
                if (L5[i] == L4[i + 1] && L5[i] == L3[i + 2] && L5[i] == L2[i + 3] && L5[i] != " ")
                {
                    return true;
                }
                if (L4[i] == L3[i + 1] && L4[i] == L2[i + 2] && L4[i] == L1[i + 3] && L4[i] != " ")
                {
                    return true;
                }
            }
            for (int i = 0; i < L1.Length - 3; i++)
            {
                if (L3[i] == L4[i + 1] && L3[i] == L5[i + 2] && L3[i] == L6[i + 3] && L3[i] != " ")
                {
                    return true;
                }
                if (L2[i] == L3[i + 1] && L2[i] == L4[i + 2] && L2[i] == L5[i + 3] && L2[i] != " ")
                {
                    return true;
                }
                if (L1[i] == L2[i + 1] && L1[i] == L3[i + 2] && L1[i] == L4[i + 3] && L1[i] != " ")
                {
                    return true;
                }
            }

            return false;
        }
        static bool PlacPon(ref string[] L1, ref string[] L2, ref string[] L3, ref string[] L4, ref string[] L5, ref string[] L6, int index, bool Player)
        {
            index--;
            if (L1[index] == " ")
            {
                if (L2[index] == " ")
                {
                    if (L3[index] == " ")
                    {
                        if (L4[index] == " ")
                        {
                            if (L5[index] == " ")
                            {
                                if (L6[index] == " ")
                                {
                                    if (Player)
                                    {
                                        L6[index] = "0";
                                        return true;
                                    }
                                    else
                                    {
                                        L6[index] = "O";
                                        return true;
                                    }
                                }
                                else
                                {
                                    if (Player)
                                    {
                                        L5[index] = "0";
                                        return true;
                                    }
                                    else
                                    {
                                        L5[index] = "O";
                                        return true;
                                    }
                                }
                            }
                            else
                            {
                                if (Player)
                                {
                                    L4[index] = "0";
                                    return true;
                                }
                                else
                                {
                                    L4[index] = "O";
                                    return true;
                                }
                            }
                        }
                        else
                        {
                            if (Player)
                            {
                                L3[index] = "0";
                                return true;
                            }
                            else
                            {
                                L3[index] = "O";
                                return true;
                            }
                        }
                    }
                    else
                    {
                        if (Player)
                        {
                            L2[index] = "0";
                            return true;
                        }
                        else
                        {
                            L2[index] = "O";
                            return true;
                        }
                    }
                }
                else
                {
                    if (Player) 
                    {
                        L1[index] = "0";
                        return true;
                    }
                    else
                    {
                        L1[index] = "O";
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        static void DisplayTab(string[] L1, string[] L2, string[] L3, string[] L4, string[] L5, string[] L6, bool P1ORP2)
        {
            Console.WriteLine("+---+---+---+---+---+---+---+");
            DisplayArray(L1, P1ORP2);
            Console.WriteLine("+---+---+---+---+---+---+---+");
            DisplayArray(L2, P1ORP2);
            Console.WriteLine("+---+---+---+---+---+---+---+");
            DisplayArray(L3, P1ORP2);
            Console.WriteLine("+---+---+---+---+---+---+---+");
            DisplayArray(L4, P1ORP2);
            Console.WriteLine("+---+---+---+---+---+---+---+");
            DisplayArray(L5, P1ORP2);
            Console.WriteLine("+---+---+---+---+---+---+---+");
            DisplayArray(L6, P1ORP2);
            Console.WriteLine("+---+---+---+---+---+---+---+");
            Console.WriteLine("  1   2   3   4   5   6   7  ");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void Players() 
        {
            Console.Clear();
            DisplayTab(L1, L2, L3, L4, L5, L6, P1ORP2);
            Console.Write("Joueur ");
            if (Convert.ToInt32(P1ORP2) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(2);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(1);
            }
            Console.ResetColor();
            Console.WriteLine(" à toi !!");
            Console.WriteLine("Choisis la colonne dans laquelle tu veux mettre la pièce");
            int inputP = Convert.ToInt32(Console.ReadLine());
            if (P1ORP2 && PlacPon(ref L1, ref L2, ref L3, ref L4, ref L5, ref L6, inputP, P1ORP2))
            {
                P1ORP2 = false;
            }
            else if (!P1ORP2 && PlacPon(ref L1, ref L2, ref L3, ref L4, ref L5, ref L6, inputP, P1ORP2))
            {
                P1ORP2 = true;
            }
        }
        static void InitGame()
        {            
            for (int i = 0; i < L1.Length; i++)
            {
                L1[i] = " ";
                L2[i] = " ";
                L3[i] = " ";
                L4[i] = " ";
                L5[i] = " ";
                L6[i] = " ";
            }
            Console.WriteLine("Bienvenue dans le puissance 4");
            Console.Write("Le joueur 1 est représenté par les pions: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("0 Jaune");
            Console.ResetColor();
            Console.Write("Le joueur 2 est représenté par les pions: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("O Rouge");
            Console.ResetColor();
            Console.WriteLine("Pour démarrer appuyer sur Entrer");
            Console.WriteLine("");
            Console.WriteLine("Pour quitter appuyer sur la touche Q");
            Console.WriteLine("");
        }
        static void StartOrQuitGame()
        {
            while (gameover)
            {
                KeyInput = Convert.ToString(Console.ReadKey().Key);
                if (KeyInput == Convert.ToString(ConsoleKey.Enter))
                {
                    gameover = false;
                    PlayGame();
                    EndGame();
                    break;
                }
                else if (KeyInput == Convert.ToString(ConsoleKey.Q))
                {
                    Console.Clear();
                    Console.WriteLine("Êtes-vous sure de vouloir quitter ?");
                    Console.WriteLine("Oui: O    Non: N");
                    if (Console.ReadKey().Key == ConsoleKey.O)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        InitGame();
                    }
                }
            }
        }
        static void PlayGame()
        {
            while (!gameover)
            {
                Players();
                 if (ChekW() == true)
                 {
                     break;
                 }

            }
        }
        static void EndGame()
        {
            int PWIN = 1 + Convert.ToInt32(P1ORP2);
            Console.Clear();
            Console.Write("Le joueur ");
            if (PWIN == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(PWIN);
            Console.ResetColor();
            Console.WriteLine(" à gagner !!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Si vous souhaitez redémarrer une partie appuyer sur Entrer");
            Console.WriteLine("");
            Console.WriteLine("Pour quitter appuyer sur n'importe quel touche.");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                P1ORP2 = true;
                Main();
            }
        }
        static void Main()
        {
            InitGame();
            StartOrQuitGame();
        }
    }
}