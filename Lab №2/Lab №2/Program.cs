using System;

namespace Lab__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n__________________________________________part 1______________________________\n");

            Console.WriteLine("Введiть довжину радiуса: ");
            double radius = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Введiть x-ву координату точки: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть y-ву координату точки: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double radiusToPoint = x * x + y * y;
            if (((x >= 0 && y >= 0) || (x < 0 && y < 0)) && (radiusToPoint <= radius * radius))
            {
                if (Math.Abs(y) >= Math.Abs(x))
                {
                    if (radiusToPoint < radius * radius)
                    {
                        Console.WriteLine("Так");
                    }

                    if ((x == y) || (x == 0) || (radiusToPoint == radius * radius))
                    {
                        Console.WriteLine("На межi");
                    }
                }
                else
                {
                    Console.WriteLine("Нi");
                }
            }
            else
            {
                Console.WriteLine("Нi");
            }

            Console.WriteLine("\n__________________________________________part 2______________________________\n"); ;
            Console.WriteLine("Скiльки купити лотерейних бiлетiв: ");
            int numberOfTickets = Convert.ToInt32(Console.ReadLine());
            if (numberOfTickets >= 100)
            {
                Console.WriteLine("Ви вийграли водокачку");
            }
            else
            {
                if (numberOfTickets == 0)
                {
                    Console.WriteLine("Вiдключити газ");
                }
                else
                {
                    Console.WriteLine("Ви нiчого не вийграли");
                }
            }

            Console.WriteLine("\n__________________________________________part 3______________________________\n");
            
            int month;
            do
            {
                Console.WriteLine("Введiть номер мiсяця: ");
                month = Convert.ToInt32(Console.ReadLine());
            } while (month < 1 || month > 12);
            switch (month)
            {
                case 1:
                    Console.WriteLine("Початок року");
                    break;
                case 12:
                    Console.WriteLine("Кiнець року");
                    break;
                default:
                    Console.WriteLine("Залишилось " + (12 - month).ToString() + " мiсяцi/-iв");
                    break;

            }

            Console.WriteLine("\n__________________________________________part 4______________________________\n");
            //Білого ферзя, чорного короля, чорного пішака.
            Console.WriteLine("X королеви ");
            int queen_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y королеви ");
            int queen_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X короля ");
            int king_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y короля ");
            int king_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X пiшака ");
            int pawn_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y пiшака ");
            int pawn_y = Convert.ToInt32(Console.ReadLine());

            bool queenStatus = true;
            bool kingStatus = true;
            bool pawnStatus = true;
            bool attackOnKing = false;
            bool attackOnPawn = false;
            bool kingDefendPawn = false;
            bool pawnDefendKing = false;

            // Перевірка положень фігур
            if (queen_x == king_x && queen_y == king_y)
            {
                queenStatus = false;
                kingStatus = false;
                Console.WriteLine("Координати Короля та Королеви збiгаються");
            }
            if (queen_x == pawn_x && queen_y == pawn_y)
            {
                pawnStatus = false;
                queenStatus = false;
                Console.WriteLine("Координати Пiшака та Королеви збiгаються");
            }
            if (pawn_x == king_x && pawn_y == king_y)
            {
                kingStatus = false;
                pawnStatus = false;
                Console.WriteLine("Координати Короля та Пiшака збiгаються");
            }

            if (queen_x > 8 || queen_x< 1 || queen_y > 8 || queen_y< 1)
            {
                Console.WriteLine("Королева не на дощцi");
                queenStatus = false;
            }
            if (king_x > 8 || king_x< 1 || king_y > 8 || king_y< 1)
            {
                Console.WriteLine("Король не на дощцi");
                kingStatus = false;
            }
            if (pawn_x > 8 || pawn_x< 1 || pawn_y > 8 || pawn_y< 1)
            {
                Console.WriteLine("Пішак не на дошцi");
                pawnStatus = false;
            }

            // Умова удару по дігоналі
            float queen_VS_king = 0;
            float queen_VS_pawn = 0;
            if (king_y!=queen_y && queenStatus && kingStatus)
            {
                queen_VS_king = Math.Abs(queen_x - king_x) / Math.Abs(queen_y - king_y);
            }
            if (pawn_y!=queen_y && queenStatus && pawnStatus)
            {
                queen_VS_pawn = Math.Abs(queen_x - pawn_x) / Math.Abs(queen_y - pawn_y);
            }

            if (kingStatus)
            {
                if (pawnStatus)
                {
                    if ((king_x + 1 == pawn_x && king_y == pawn_y) || (king_x - 1 == pawn_x && king_y == pawn_y))
                    {
                        kingDefendPawn = true;
                    } 
                    else if ((king_x == pawn_x && king_y + 1 == pawn_y) || (king_x == pawn_x && king_y - 1 == pawn_y))
                    {
                        kingDefendPawn = true;
                    }
                        
                    else if ((king_x + 1 == pawn_x && king_y - 1 == pawn_y) || (king_x - 1 == pawn_x && king_y - 1 == pawn_y))
                    {
                        kingDefendPawn = true;
                    }
                        
                    else if ((king_x + 1 == pawn_x && king_y + 1 == pawn_y) || (king_x - 1 == pawn_x && king_y + 1 == pawn_y))
                    {
                        kingDefendPawn = true;
                    }
                        
                }
                    
            }    
                
            if (pawnStatus)
            {
                if (kingStatus)
                {
                    if ((pawn_x - 1 == king_x && pawn_y - 1 == king_y) || (pawn_x + 1 == king_x && pawn_y - 1 == king_y))
                    {
                        pawnDefendKing = true;
                    }
                }  
            }
                

            Console.WriteLine("\nМожливi дiї Королеви:");
            if (queenStatus)
            {
                if (kingStatus)
                {
                    if ((queen_x == king_x) || (queen_y == king_y) || (queen_VS_king == 1))
                    {
                        Console.WriteLine("\tНапад на Короля");
                        attackOnKing = true;
                        if (pawnDefendKing)
                        {
                            Console.WriteLine("\tКороль пiд захистом Пiшака");
                        }
                    }
                        
                }
                if (pawnStatus)
                {
                    if ((queen_x == pawn_x) || (queen_y == pawn_y) || (queen_VS_pawn == 1))
                    {
                        Console.WriteLine("\tНапад на Пiшака");
                        attackOnPawn = true;
                        if (kingDefendPawn)
                        {
                            Console.WriteLine("\tПiшак пiд захистом Короля");
                        }
                    }
                }
            }
            else 
            {
                Console.WriteLine("\tКоролева поза грою");
            }

            Console.WriteLine("\nМожливi дiї Пішака");
            if (pawnStatus)
            {
                if (queenStatus)
                    if ((pawn_x - 1 == queen_x && pawn_y - 1 == queen_y) || (pawn_x + 1 == queen_x && pawn_y - 1 == queen_y))
                    {
                        Console.WriteLine("\tНапад на Королеву");
                        if (attackOnKing)
                        {
                            Console.WriteLine("\tЗахист Короля шляхом побиття Королеви");
                        }

                    }
                    else
                    {
                        Console.WriteLine("\tДiй немає");
                    }    
            } 
            else
            {
                Console.WriteLine("\tПiшак поза грою");
            }

            Console.WriteLine("\nМожливi дiї Короля");
            if (kingStatus)
            {
                if (queenStatus)
                {
                    if ((king_x + 1 == queen_x && king_y == queen_y) || (king_x - 1 == queen_x && king_y == queen_y))
                    {
                        Console.WriteLine("\tНапад на Королеву");
                        if (attackOnPawn)
                        {
                            Console.WriteLine("\tЗахист Пiшака шляхом побиття Королеви");
                        }
                            
                    }
                    else if ((king_x == queen_x && king_y + 1 == queen_y) || (king_x == queen_x &&  king_y - 1 == queen_y))
                    {
                        Console.WriteLine("\tНапад на Королеву");
                        if (attackOnPawn)
                        {
                            Console.WriteLine("\tЗахист Пiшака шляхом побиття Королеви");
                        }

                    }    
                    else if ((king_x + 1 == queen_x && king_y - 1 == queen_y) || (king_x - 1 == queen_x && king_y - 1 == queen_y))
                    {
                        Console.WriteLine("\tНапад на Королеву");
                        if (attackOnPawn)
                        {
                            Console.WriteLine("\tЗахист Пiшака шляхом побиття Королеви");
                        }
                    }
                        
                    else if ((king_x + 1 == queen_x && king_y + 1 == queen_y) || (king_x - 1 == queen_x && king_y + 1 == queen_y))
                    {
                        Console.WriteLine("\tНапад на Королеву");
                        if (attackOnPawn)
                        {
                            Console.WriteLine("\tЗахист Пiшака шляхом побиття Королеви");
                        }

                    }
                        
                    else
                    {
                        Console.WriteLine("\tДiй немає");
                    }
                        
                }
                    
            }
                
        }
    }
}
