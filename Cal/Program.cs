int choice = 3;
while (choice == 3) {
    Console.Clear();
    Console.WriteLine("Cal");
    Console.WriteLine();

    Console.WriteLine("Options:\n1.Learn\n2.Test");
    Console.WriteLine("");

    Console.Write("Enter your choice 1 or 2: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        while (choice == 1)
        {
            Console.Clear();
            Console.WriteLine("Learn");
            Console.WriteLine();
            Console.WriteLine("What do you want to learn (Select Number)\n1.+\n2.-\n3./\n4.*\n5.Exit");
            string Symbole = Console.ReadLine();
           
            if (Symbole == "1")
            {
                Console.WriteLine("Select 1st number");
                int Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Select 2nd number : ");
                int Num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int Ans = Num1 + Num2;
                Console.WriteLine($"{Num1} + {Num2} = {Ans}");
                Console.WriteLine();
                Console.ReadLine();
                Console.Write($"Try Again? Y/N:");
                string Again = Console.ReadLine();

                if (Again == "Y" || Again == "y")
                {
                    choice = 1;
                }
                else if (Again == "n" || Again == "n")
                {
                    choice = 3;
                }
            }
            else if (Symbole == "2")
            {
                Console.WriteLine("Select 1st number");
                int Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Select 2nd number : ");
                int Num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int Ans = Num1 - Num2;
                Console.WriteLine($"{Num1} - {Num2} = {Ans}");
                Console.WriteLine();
                Console.ReadLine();
                Console.Write($"Try Again? Y/N:");
                string Again = Console.ReadLine();

                if (Again == "Y" || Again == "y")
                {
                    choice = 1;
                }
                else if (Again == "n" || Again == "n")
                {
                    choice = 3;
                }
            }
            else if (Symbole == "3")
            {
                Console.WriteLine("Select 1st number");
                int Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Select 2nd number : ");
                int Num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int Ans = Num1 / Num2;
                Console.WriteLine($"{Num1} / {Num2} = {Ans}");
                Console.WriteLine();
                Console.ReadLine();
                Console.Write($"Try Again? Y/N:");
                string Again = Console.ReadLine();

                if (Again == "Y" || Again == "y")
                {
                    choice = 1;
                }
                else if (Again == "n" || Again == "n")
                {
                    choice = 3;
                }

            }
            else if (Symbole == "4")
            {
                Console.WriteLine("Select 1st number");
                int Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Select 2nd number : ");
                int Num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int Ans = Num1 * Num2;
                Console.WriteLine($"{Num1} * {Num2} = {Ans}");
                Console.WriteLine();
                Console.ReadLine();
                Console.Write($"Try Again? Y/N:");
                string Again = Console.ReadLine();
           
                if (Again == "Y" || Again == "y") 
                {
                    choice = 1;
                }
                else if (Again == "n" || Again == "n")
                {
                    choice = 3;
                }
              
            }
            else if (Symbole == "5")
            {
                choice = 3;
            }

        }
    }
    else if (choice == 2)
    {
        while (choice == 2)
        {
            Console.Clear();
            Console.WriteLine("Test");
            Console.WriteLine();
            Console.WriteLine("What level do you want to be tested on.(Select Number ): \n1.Easy\n2.Medium\n3.Hard\n4.Exit");
            string Lv = Console.ReadLine();

            Console.WriteLine();

            if (Lv == "1")
            {
                int score = 0;
                Random rand = new Random();

                // 4 addition questions
                for (int i = 0; i < 4; i++)
                {
                    int num1 = rand.Next(1, 10);
                    int num2 = rand.Next(1, 10);
                    Console.WriteLine($"Question {i + 1}: What is {num1} + {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 + num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 + num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 subtraction questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(5, 15);
                    int num2 = rand.Next(1, 10);
                    Console.WriteLine($"Question {i + 5}: What is {num1} - {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 - num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 - num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 multiplication questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(1, 10);
                    int num2 = rand.Next(1, 10);
                    Console.WriteLine($"Question {i + 7}: What is {num1} * {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 * num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 * num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 division questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(10, 20);
                    int num2 = rand.Next(1, 10);
                    // Ensure division by non-zero number
                    if (num1 % num2 != 0) num1 = num1 + num2; // Adjust num1 to be divisible by num2

                    Console.WriteLine($"Question {i + 9}: What is {num1} / {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 / num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 / num2}.");
                    }
                    Console.WriteLine();
                }

                // Display final score
                Console.WriteLine($"You answered {score} out of 10 questions correctly!");
                Console.ReadLine();

                Console.Write($"Try Again? Y/N:");
                string Again = Console.ReadLine();

                if (Again == "Y" || Again == "y")
                {
                    choice = 2;
                }
                else if (Again == "n" || Again == "n")
                {
                    choice = 3;
                }
            }

            else if (Lv == "2")
            {
                int score = 0;
                Random rand = new Random();

                // 4 addition questions
                for (int i = 0; i < 4; i++)
                {
                    int num1 = rand.Next(1, 100);
                    int num2 = rand.Next(1, 100);
                    Console.WriteLine($"Question {i + 1}: What is {num1} + {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 + num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 + num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 subtraction questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(5, 150);
                    int num2 = rand.Next(1, 100);
                    Console.WriteLine($"Question {i + 5}: What is {num1} - {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 - num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 - num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 multiplication questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(1, 100);
                    int num2 = rand.Next(1, 100);
                    Console.WriteLine($"Question {i + 7}: What is {num1} * {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 * num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 * num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 division questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(10, 200);
                    int num2 = rand.Next(1, 100);
                    // Ensure division by non-zero number
                    if (num1 % num2 != 0) num1 = num1 + num2; // Adjust num1 to be divisible by num2

                    Console.WriteLine($"Question {i + 9}: What is {num1} / {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 / num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 / num2}.");
                    }
                    Console.WriteLine();
                }

                // Display final score
                Console.WriteLine($"You answered {score} out of 10 questions correctly!");
                Console.ReadLine();

                Console.Write($"Try Again? Y/N:");
                string Again = Console.ReadLine();

                if (Again == "Y" || Again == "y")
                {
                    choice = 2;
                }
                else if (Again == "n" || Again == "n")
                {
                    choice = 3;
                }

            }
            else if (Lv == "3")
            {
                int score = 0;
                Random rand = new Random();

                // 4 addition questions
                for (int i = 0; i < 4; i++)
                {
                    int num1 = rand.Next(1, 1000);
                    int num2 = rand.Next(1, 1000);
                    Console.WriteLine($"Question {i + 1}: What is {num1} + {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 + num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 + num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 subtraction questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(5, 1500);
                    int num2 = rand.Next(1, 1000);
                    Console.WriteLine($"Question {i + 5}: What is {num1} - {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 - num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 - num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 multiplication questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(1, 1000);
                    int num2 = rand.Next(1, 1000);
                    Console.WriteLine($"Question {i + 7}: What is {num1} * {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 * num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 * num2}.");
                    }
                    Console.WriteLine();
                }

                // 2 division questions
                for (int i = 0; i < 2; i++)
                {
                    int num1 = rand.Next(10, 2000);
                    int num2 = rand.Next(1, 1000);
                    // Ensure division by non-zero number
                    if (num1 % num2 != 0) num1 = num1 + num2; // Adjust num1 to be divisible by num2

                    Console.WriteLine($"Question {i + 9}: What is {num1} / {num2}?");
                    if (int.TryParse(Console.ReadLine(), out int userAnswer) && userAnswer == (num1 / num2))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {num1 / num2}.");
                    }
                    Console.WriteLine();
                }

                // Display final score
                Console.WriteLine($"You answered {score} out of 10 questions correctly!");
                Console.ReadLine();

                Console.Write($"Try Again? Y/N:");
                string Again = Console.ReadLine();

                if (Again == "Y" || Again == "y")
                {
                    choice = 2;
                }
                else if (Again == "n" || Again == "n")
                {
                    choice = 3;
                }
            }
            else if (Lv == "4")
            {
                choice = 3;
            }
        }
       
    }
    else
    {
        Console.WriteLine("Pick correct option 1 or 2");
        Console.ReadLine();
        choice = 3;
    }
}