using System;

namespace ProjeOdev1
{
    class Program
    {
        static void Main(string[] args)
        {

            //FORMAT DEFINITIONS
            bool menu = true;
            Random randomX = new Random();
            int xS = 0;
            Random randomY = new Random();
            int yS = 0;
            int xA = 0; int xB = 0; int xC = 0; int yA = 0; int yB = 0; int yC = 0;
            double angleAR = 0; double angleA = 0; double angleBR = 0; double angleB = 0; double angleCR = 0; double angleC = 0;
            double area = 0; double areaR = 0; double medianxaR = 0; double medianxbR = 0; double medianxcR = 0; double medianyaR = 0; double medianybR = 0; double medianycR = 0;
            double perimeterR = 0; double sideA = 0; double sideB = 0; double sideC = 0; double sideAR = 0; double sideBR = 0; double sideCR = 0;
            double u = 0; double xcentroidR = 0; double ycentroidR = 0; double bisectorA = 0;
            bool BoundsCheck = false; bool TriangleCheck = false; bool hitcheck = false;
            string AngleType = ("0");
            string TriangleType = ("0");
            double AreaOfCircumscribedCircleR = (0);
            double AreaOfInscribedCircleR = (0);
            int choice = 0; double score = 0; string name = ("0");
            bool name_exists = false;
            //

            while (menu == true)
            {
                //MENU
                Console.Clear();
                Console.WriteLine("             - MENU -                 ");
                Console.WriteLine(" PLEASE SELECT FROM THE OPTIONS BELOW: ");
                Console.WriteLine("1 – Create new ship "); ;
                Console.WriteLine("2 – Ship info ");
                Console.WriteLine("3 - Shoot");
                Console.WriteLine("4 – Show high score table");
                Console.WriteLine("5 – Exit");
                Console.WriteLine(" ");


                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //BOARD
                        Console.Clear();
                        Console.WriteLine("12|                              ");
                        Console.WriteLine("11|                              ");
                        Console.WriteLine("10|                              ");
                        Console.WriteLine(" 9|                              ");
                        Console.WriteLine(" 8|                              ");
                        Console.WriteLine(" 7|                              ");
                        Console.WriteLine(" 6|                              ");
                        Console.WriteLine(" 5|                              ");
                        Console.WriteLine(" 4|                              ");
                        Console.WriteLine(" 3|                              ");
                        Console.WriteLine(" 2|                              ");
                        Console.WriteLine(" 1|                              ");
                        Console.WriteLine("  +------------------------------");
                        Console.WriteLine("   123456789012345678901234567890");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");

                        //INPUTS
                        Console.Write("Enter xA = ");
                        xA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter yA = ");
                        yA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter xB = ");
                        xB = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter yB = ");
                        yB = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter xC = ");
                        xC = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter yC = ");
                        yC = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //BASIC PROPERTIES
                        sideA = Math.Sqrt(((xB - xC) * (xB - xC)) + ((yB - yC) * (yB - yC)));
                        sideB = Math.Sqrt(((xC - xA) * (xC - xA)) + ((yC - yA) * (yC - yA)));
                        sideC = Math.Sqrt(((xA - xB) * (xA - xB)) + ((yA - yB) * (yA - yB)));

                        double perimeter = (sideA + sideB + sideC);

                        u = (perimeter) / 2;

                        area = Math.Sqrt(u * (u - sideA) * (u - sideB) * (u - sideC));

                        double medianxa = Math.Abs((xB + xC) / 2);
                        double medianya = Math.Abs((yB + yC) / 2);
                        double medianxb = Math.Abs((xA + xC) / 2);
                        double medianyb = Math.Abs((yA + yC) / 2);
                        double medianxc = Math.Abs((xB + xA) / 2);
                        double medianyc = Math.Abs((yB + yA) / 2);

                        double xcentroid = ((double)(xA + xB + xC) / 3);
                        double ycentroid = ((double)(yA + yB + yC) / 3);

                        angleA = Math.Acos(d: ((((sideB) * (sideB)) + ((sideC) * (sideC)) - ((sideA) * (sideA))) / (2 * (sideB) * (sideC))));
                        angleB = Math.Acos(d: ((((sideA) * (sideA)) + ((sideC) * (sideC)) - ((sideB) * (sideB))) / (2 * (sideA) * (sideC))));
                        angleC = Math.Acos(d: ((((sideA) * (sideA)) + ((sideB) * (sideB)) - ((sideC) * (sideC))) / (2 * (sideB) * (sideA))));

                        angleA = (float)(angleA * 180 / Math.PI);
                        angleB = (float)(angleB * 180 / Math.PI);
                        angleC = (float)(angleC * 180 / Math.PI);

                        sideAR = Math.Round(sideA, 2);
                        sideBR = Math.Round(sideB, 2);
                        sideCR = Math.Round(sideC, 2);

                        //ROUNDING BASIC PROPERTIES
                        areaR = Math.Round(area, 2);

                        perimeterR = Math.Round(perimeter, 2);

                        angleAR = Math.Round(angleA, 2);
                        angleBR = Math.Round(angleB, 2);
                        angleCR = Math.Round(angleC, 2);

                        xcentroidR = Math.Round(xcentroid, 2);
                        ycentroidR = Math.Round(ycentroid, 2);

                        medianxaR = Math.Round(medianxa, 2);
                        medianyaR = Math.Round(medianya, 2);
                        medianxbR = Math.Round(medianxb, 2);
                        medianybR = Math.Round(medianyb, 2);
                        medianxcR = Math.Round(medianxc, 2);
                        medianycR = Math.Round(medianyc, 2);

                        //Boundry and shape checks
                        if ((xA < 0) | (xB < 0) | (xC < 0) | (yA < 0) | (yB < 0) | (yC < 0) | (xA > 30) | (xB > 30) | (xC > 30) | (yA > 12) | (yB > 12) | (yC > 12))
                        {
                            BoundsCheck = false;
                            Console.WriteLine("Out of bounds.");
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                            menu = true;
                        }
                        else
                        {
                            BoundsCheck = true;
                        }

                        if (sideA + sideB > sideC & sideB + sideC > sideA & sideA + sideC > sideB)
                        {
                            TriangleCheck = true;
                        }
                        else
                        {
                            TriangleCheck = false;
                            Console.WriteLine("Not a triangle.");
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                            menu = true;
                        }

                        if (BoundsCheck == true & TriangleCheck == true)
                        {
                            //ADVANCED PROPERTIES
                            //Triangle type
                            if ((sideA == sideB) & (sideB == sideC) & (sideA == sideC))
                            {
                                TriangleType = ("Equilateral");
                            }
                            else if ((sideA == sideB) | (sideB == sideC) | (sideA == sideC))
                            {
                                TriangleType = ("Isosceles");
                            }
                            else
                            {
                                TriangleType = ("Scalene");
                            }

                            //Angle type
                            if ((angleAR == 90) | angleBR == 90 | angleCR == 90)
                            {
                                AngleType = ("Right angled");
                            }
                            else if ((angleAR >= 90) | angleBR >= 90 | angleCR >= 90)
                            {
                                AngleType = ("Obtuse angled");
                            }
                            else
                            {
                                AngleType = ("Acute angled");
                            }

                            //Circle areas
                            double R = (sideA * sideB * sideC) / (4 * Math.Sqrt(u * (u - sideA) * (u - sideB) * (u - sideC)));
                            double AreaOfCircumscribedCircle = (Math.PI * R * R);

                            double r = Math.Sqrt(((u - sideA) * (u - sideB) * (u - sideC)) / u);
                            double AreaOfInscribedCircle = (Math.PI * r * r);

                            //length of bisector 
                            double x = (sideA * sideB) / (sideB + sideC);


                            bisectorA = Math.Sqrt((sideB * sideC) - ((sideA - x) * x));
                            bisectorA = Math.Round(bisectorA, 2);

                            //Rounding circle areas
                            AreaOfInscribedCircleR = Math.Round(AreaOfInscribedCircle, 2);
                            AreaOfCircumscribedCircleR = Math.Round(AreaOfCircumscribedCircle, 2);

                            //Point render
                            Console.SetCursorPosition(xA + 2, 12 - yA);
                            Console.Write("A");

                            Console.SetCursorPosition(xB + 2, 12 - yB);
                            Console.Write("B");

                            Console.SetCursorPosition(xC + 2, 12 - yC);
                            Console.Write("C");

                            Console.SetCursorPosition(0, 23);

                            //return to menu
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                            menu = true;
                        }
                        break;
                    case 2:
                        //Ship properties
                        //Valid ship check
                        if (BoundsCheck == true & TriangleCheck == true)
                        {
                            Console.Clear();
                            Console.WriteLine("12|                              ");
                            Console.WriteLine("11|                              ");
                            Console.WriteLine("10|                              ");
                            Console.WriteLine(" 9|                              ");
                            Console.WriteLine(" 8|                              ");
                            Console.WriteLine(" 7|                              ");
                            Console.WriteLine(" 6|                              ");
                            Console.WriteLine(" 5|                              ");
                            Console.WriteLine(" 4|                              ");
                            Console.WriteLine(" 3|                              ");
                            Console.WriteLine(" 2|                              ");
                            Console.WriteLine(" 1|                              ");
                            Console.WriteLine("  +------------------------------");
                            Console.WriteLine("   123456789012345678901234567890");
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");

                            //Point render
                            Console.SetCursorPosition(xA + 2, 12 - yA);
                            Console.Write("A");

                            Console.SetCursorPosition(xB + 2, 12 - yB);
                            Console.Write("B");

                            Console.SetCursorPosition(xC + 2, 12 - yC);
                            Console.Write("C");

                            Console.SetCursorPosition(0, 15);

                            //Basic Properties
                            Console.WriteLine("-----BASIC SHIP PROPERTIES-----");
                            Console.WriteLine(" ");
                            Console.WriteLine("Edge a: " + sideAR);
                            Console.WriteLine("Edge b: " + sideBR);
                            Console.WriteLine("Edge c: " + sideCR);
                            Console.WriteLine(" ");
                            Console.WriteLine("Area: " + areaR);
                            Console.WriteLine(" ");
                            Console.WriteLine("Perimeter: " + perimeterR);
                            Console.WriteLine(" ");
                            Console.WriteLine($"Median points: ({medianxaR}, {medianyaR}), ({medianxbR}, {medianybR}), ({medianxcR}, {medianycR})");
                            Console.WriteLine(" ");
                            Console.WriteLine($"Centroid coordinates: ({xcentroidR}, {ycentroidR})");
                            Console.WriteLine(" ");
                            Console.WriteLine("Angle A: " + angleAR);
                            Console.WriteLine("Angle B: " + angleBR);
                            Console.WriteLine("Angle C: " + angleCR);
                            Console.WriteLine(" ");

                            //Advanced Properties
                            Console.WriteLine("-----ADVANCED SHIP PROPERTIES-----");
                            Console.WriteLine(" ");
                            Console.WriteLine("Length of bisector A: " + bisectorA);
                            Console.WriteLine(" ");
                            Console.WriteLine("Area of the inscribed circle: " + AreaOfInscribedCircleR);
                            Console.WriteLine("Area of the circumscribed circle: " + AreaOfCircumscribedCircleR);
                            Console.WriteLine(" ");
                            Console.WriteLine("Ship Type: " + AngleType + " " + TriangleType);
                            Console.WriteLine(" ");

                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            //return to menu
                            Console.WriteLine("Please create a valid ship first.");
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                        }
                        break;
                    case 3:
                        //Valid ship check
                        if (BoundsCheck == true & TriangleCheck == true)
                        {
                            //Shooting
                            xS = randomX.Next(0, 31);
                            yS = randomY.Next(0, 13);

                            double vectorA = Math.Sqrt(((xS - xA) * (xS - xA)) + ((yS - yA) * (yS - yA)));
                            double vectorB = Math.Sqrt(((xS - xB) * (xS - xB)) + ((yS - yB) * (yS - yB)));
                            double vectorC = Math.Sqrt(((xS - xC) * (xS - xC)) + ((yS - yC) * (yS - yC)));

                            double semiperimeter1 = (vectorA + vectorB + sideC) / 2;
                            double semiperimeter2 = (vectorB + vectorC + sideA) / 2;
                            double semiperimeter3 = (vectorC + vectorA + sideB) / 2;

                            double area1 = Math.Sqrt(semiperimeter1 * (semiperimeter1 - vectorA) * (semiperimeter1 - vectorB) * (semiperimeter1 - sideC));
                            double area2 = Math.Sqrt(semiperimeter2 * (semiperimeter2 - vectorB) * (semiperimeter2 - vectorC) * (semiperimeter2 - sideA));
                            double area3 = Math.Sqrt(semiperimeter3 * (semiperimeter3 - vectorC) * (semiperimeter3 - vectorA) * (semiperimeter3 - sideB));

                            Console.WriteLine("Shot (" + xS + ", " + yS + ")");

                            int hitarea = Convert.ToInt16(area1 + area2 + area3);

                            //hit check
                            if (hitarea == area)
                            {
                                Console.WriteLine("HIT! YOUR SHIP SANK!");
                                if (area1 == 0 | area2 == 0 | area3 == 0)
                                {
                                    Console.WriteLine("ON THE EDGE!");
                                }
                                hitcheck = true;
                                score = 0;
                            }
                            else
                            {
                                Console.WriteLine("MISS! YOUR SHIP SURVIVED!");
                                hitcheck = false;
                                score = areaR;
                            }

                            if (hitcheck == false)
                            {
                                Console.WriteLine(" ");
                                Console.Write("Please enter your name to save your score: ");
                                name = Console.ReadLine();
                                Console.WriteLine("Congratulations " + name + "! Your score is " + score + ".");
                                name_exists = true;
                            }
                            //return to menu
                            Console.WriteLine("");
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            //return to menu
                            Console.WriteLine("Please create a valid ship first.");
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                        }
                        break;
                    case 4:

                        //scoreboard
                        int Melisa, Ahmet, Ziya;

                        Ahmet = 10;
                        Ziya = 30;
                        Melisa = 60;


                        if (name_exists == true)
                        {
                            Console.Clear();
                            if (area < Ahmet)
                            {
                                Console.WriteLine("ScoreTable");
                                Console.WriteLine("1. 60 Nazan Kaya");
                                Console.WriteLine("2. 30 Ali Kurt");
                                Console.WriteLine("3. 10 Sibel Arslan");
                            }

                            else if (area > Ahmet && area < Ziya)
                            {
                                Console.WriteLine("ScoreTable");
                                Console.WriteLine("1. 60 Nazan Kaya");
                                Console.WriteLine("2. 30 Ali Kurt");
                                Console.WriteLine("3. " + areaR + " - " + name);
                            }

                            else if (area > Ziya && area < Melisa)
                            {
                                Console.WriteLine("ScoreTable");
                                Console.WriteLine("1. 60 - Nazan Kaya");
                                Console.WriteLine("2. " + areaR + " - " + name); //biliyorum
                                Console.WriteLine("3. 30 - Ali Kurt");
                            }

                            else if (area >= Melisa)
                            {
                                Console.WriteLine("ScoreTable");
                                Console.WriteLine("1. " + areaR + " - " + name);
                                Console.WriteLine("2. 60 - Nazan Kaya");
                                Console.WriteLine("3. 30 - Ali Kurt");
                            }

                            else if (area == Ahmet)
                            {
                                Console.WriteLine("ScoreTable");
                                Console.WriteLine("1. 60 - Nazan Kaya");
                                Console.WriteLine("2. 30 - Ali Kurt");
                                Console.WriteLine("3. " + areaR + " - " + name);
                            }

                            else if (area == Ziya)
                            {
                                Console.WriteLine("ScoreTable");
                                Console.WriteLine("1. 60 - Nazan Kaya");
                                Console.WriteLine("2. " + areaR + " - " + name);
                                Console.WriteLine("3. 30 - Ali Kurt");
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            Console.WriteLine("ScoreTable");
                            Console.WriteLine("1. 60 - Nazan Kaya");
                            Console.WriteLine("2. 30 - Ali Kurt");
                            Console.WriteLine("3. 10 - Sibel Arslan");
                            Console.WriteLine(" ");
                            Console.WriteLine("PRESS ANY KEY TO RETURN TO THE MAIN MENU");
                            Console.ReadKey(true);
                        }

                        break;
                    case 5:
                        //exit
                        Console.Clear();
                        Console.WriteLine("Bye!");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("you cant read me. im an easter egg");
            }
        }
    }
}

