using System.Collections.Concurrent;

namespace Text_Adventure_Game
{
    internal class Program
    {
        public static class GameState
        {
            public static bool gameOver { get; set; }
            static void intro()
            {
                string? username = null;
                while (true)
                {
                    username = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(username))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Please enter a Username");
                    }
                }
                Console.WriteLine($"You are {username}");
                Console.WriteLine($"{username}, you've been chosen to defeat the Evil Wizard Bugger.");
                Console.WriteLine("He's been terrorizing our Kingdom for many years with his evil spells.");
                Console.WriteLine("And this time, he's planning to release his worst spell that humanity ever seen.");
                Console.WriteLine("The Caffeine Destroyer.");
                Console.WriteLine("Well, if it wasn't clear by the name, it's going destroy every coffee that exists.");
                Console.WriteLine("Which means all the programmers are in danger. Think about it, they have only one enjoyment in his cruel world.");
                Console.WriteLine("Many tried to defeat him, but to no avail");
                Console.WriteLine("And the reason for this is that he's hiding in his tower");
                Console.WriteLine("Rumors say that his tower has seven floors");
                Console.WriteLine("On the seventh floor is where the Wizard resides.");
                Console.WriteLine("But in order to reach him, you must pass through the six other floors.");
                Console.WriteLine("Each floor has three doors and a riddle");
                Console.WriteLine("Each door showcases an answer. You have to choose the door with the correct answer and enter");
                Console.WriteLine("If you choose the correct door, you pass to the next floor, but if you choose the wrong...");
                Console.WriteLine("...");
                Console.WriteLine("To tell you the truth, I don't know, nobody ever returned to tell me what happened so I'm guessing something bad");
                Console.WriteLine("Anyway because this introduction is very long and probably gotten bored, it's time to start your quest");
                Console.WriteLine($"Good luck, {username}!");

            }
            static void firstFloor()
            {
                Console.WriteLine("You've arrived at the tower.");
                Console.WriteLine("As you enter,  you come across 3 doors in front of you.");
                Console.WriteLine("Above them you see a huge sign with a riddle written on it:");
                Console.WriteLine("I speak without a mouth and hear without ears. I have no body, but I come alive with the wind. What am I?\r\n\r\n");
                Console.WriteLine("You see that each door has a small sign with a different answer.");
                Console.WriteLine("Door 1: A shadow.");
                Console.WriteLine("Door 2: An echo.");
                Console.WriteLine("Door 3: A dream.");
                Console.WriteLine("Which door is the correct one?");
                Console.WriteLine("One advice form the dev: Just type the door you choose. Example: \"door 1\" or \"1\" no need to right the whole answer.");
                string? riddle1 = null;
                while (true)
                {
                    riddle1 = Console.ReadLine()?.ToLower();
                    if (!string.IsNullOrWhiteSpace(riddle1))
                    {
                        switch (riddle1)
                        {
                            case "door 1":
                            case "1":
                                Console.WriteLine("You choose the first door.");
                                Console.WriteLine("As you enter, you find a room with unlimited uncentered <divs>.");
                                Console.WriteLine("You try to center as many as you can, but there is no end.");
                                Console.WriteLine("You spend the rest of your life trying to center all the <divs> with no avail.");
                                Console.WriteLine("Game Over: The <div> Ending!");
                                gameOver = true;
                                return;

                            case "door 2":
                            case "2":
                                Console.WriteLine("You choose the second door.");
                                Console.WriteLine("As you enter, you find a staircase.");
                                Console.WriteLine("It leads you to the next floor.");
                                Console.WriteLine("You chose the correct door! Congratulations!");
                                return;

                            case "door 3":
                            case "3":
                                Console.WriteLine("You choose the third door.");
                                Console.WriteLine("As you enter, you find a mirror.");
                                Console.WriteLine("Suddenly, the mirror starts to project spoilers from all your favorite series, anime, games.");
                                Console.WriteLine("That makes you so underwhelmed and demotivated that you leave the tower without caring about the quest anymore.");
                                Console.WriteLine("Game Over: The Spoiler Ending!");
                                gameOver = true;
                                return;

                            default:
                                Console.WriteLine("Invalid Choice! Either choose (door 1, door 2 or door 3) or just type (1, 2, 3)");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose a door!");
                    }

                }
                
            }
            static void secondFloor()
            {
                Console.WriteLine("You are now on the second floor of the tower.");
                Console.WriteLine("Once again you have 3 doors and the riddle written above them: ");
                Console.WriteLine("I am taken from a mine and shut up in a wooden case, from which I am never released, and yet I am used by many. What am I?");
                Console.WriteLine("Door 1: Gold.");
                Console.WriteLine("Door 2: Pencil lead.");
                Console.WriteLine("Door 3: Ink.");
                string? riddle2 = null;
                while (true)
                {
                    riddle2 = Console.ReadLine()?.ToLower();
                    if (!string.IsNullOrWhiteSpace(riddle2))
                    {
                        switch (riddle2)
                        {
                            case "door 1":
                            case "1":
                                Console.WriteLine("You choose the first door.");
                                Console.WriteLine("You enter and tumble into a dark pit. A ghostly voice cackles, You tried to access an object that doesn't exist! NullPointerException!" +
                                    " You’re trapped forever in a void of undefined references.");
                                Console.WriteLine("Game Over: The NullPointerException Ending!");
                                gameOver = true;
                                return;

                            case "door 2":
                            case "2":
                                Console.WriteLine("You choose the second door.");
                                Console.WriteLine("As you enter, you find a staircase.");
                                Console.WriteLine("It leads you to the next floor.");
                                Console.WriteLine("You chose the correct door! Congratulations!");
                                return;

                            case "door 3":
                            case "3":
                                Console.WriteLine("You choose the third door");
                                Console.WriteLine("You enter inside and you end up in a maze that loops endlessly. A sign reads, while(true) { suffer(); }. " +
                                    "You wander in circles, unable to break free.");
                                Console.WriteLine("Game Over: The Infinite Loop Ending!");
                                gameOver = true;
                                return;

                            default:
                                Console.WriteLine("Invalid Choice! Either choose (door 1, door 2 or door 3) or just type (1, 2, 3)");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose a door!");
                    }
                }
            }
            static void thirdFloor() 
            {
                Console.WriteLine("You managed to reach the third floor.");
                Console.WriteLine("3 more to face the Evil Wizard.");
                Console.WriteLine("Once again 3 doors are in your way. Only one is correct.");
                Console.WriteLine("You read the riddle above the doors: ");
                Console.WriteLine("The more you take, the more you leave behind. What am I?");
                Console.WriteLine("Door 1: Footprints.");
                Console.WriteLine("Door 2: Gold coins.");
                Console.WriteLine("Door 3: Memories.");
                string? riddle3 = null;
                while (true)
                {
                    riddle3 = Console.ReadLine()?.ToLower();
                    if (!string.IsNullOrWhiteSpace(riddle3))
                    {
                        switch (riddle3)
                        {
                            case "door 1":
                            case "1":
                                Console.WriteLine("You choose the first door.");
                                Console.WriteLine("As you enter, you find a staircase.");
                                Console.WriteLine("It leads you to the next floor.");
                                Console.WriteLine("You chose the correct door! Congratulations!");
                                return;

                            case "door 2":
                            case "2":
                                Console.WriteLine("You choose the second door.");
                                Console.WriteLine("As you enter, a spectral scribe shrieks, “Missing semicolon! Unclosed bracket!” " +
                                    "Your mind unravels as you’re forced to parse garbled code for eternity, never finding the error.");
                                Console.WriteLine("Game Over: The Syntax Error Specter Ending!");
                                gameOver = true;
                                return;

                            case "door 3":
                            case "3":
                                Console.WriteLine("You choose the third door.");
                                Console.WriteLine("As you enter a dragon appears in front of you and roars, “This method is deprecated!” It breathes obsolete code, turning you into a pile of outdated floppy disks." +
                                    " No one supports your version anymore.");
                                Console.WriteLine("Game Over: The Deprecated Dragon Ending!!");
                                gameOver = true;
                                return;

                            default:
                                Console.WriteLine("Invalid Choice! Either choose (door 1, door 2 or door 3) or just type (1, 2, 3)");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose a door!");
                    }
                }
            }
            static void fourthFloor()
            {
                Console.WriteLine("You reached the fourth floor you're almost there.");
                Console.WriteLine("Without taking any break you read the next riddle:");
                Console.WriteLine("I can fly without wings, I can cry without eyes. Whenever I go, darkness follows. What am I?");
                Console.WriteLine("Door 1: A bat.");
                Console.WriteLine("Door 2: A ghost.");
                Console.WriteLine("Door 3: A cloud.");
                string? riddle4 = null;
                while (true)
                {
                    riddle4 = Console.ReadLine()?.ToLower();
                    if (!string.IsNullOrWhiteSpace(riddle4))
                    {
                        switch (riddle4)
                        {
                            case "door 1":
                            case "1":
                                Console.WriteLine("You choose the first door.");
                                Console.WriteLine("As you enter inside you come face to face with a snarling minotaur wielding a Git repository. It bellows, " +
                                    "“Resolve this merge conflict!” You’re trampled under conflicting commits, lost in a version control nightmare.");
                                Console.WriteLine("Game over: The Merge Conflict Minotaur Ending!");
                                gameOver = true;
                                return;

                            case "door 2":
                            case "2":
                                Console.WriteLine("You choose the second door.");
                                Console.WriteLine("As you enter inside you meet a troll, demanding you answer StackOverflow questions without searching. Your incorrect replies enrage it," +
                                    " buries under a flood of downvotes.");
                                Console.WriteLine("Game Over: The Stack Overflow Troll Ending!");
                                gameOver = true;
                                return;

                            case "door 3":
                            case "3":
                                Console.WriteLine("You choose the third door.");
                                Console.WriteLine("As you enter, you find a staircase.");
                                Console.WriteLine("It leads you to the next floor.");
                                Console.WriteLine("You chose the correct door! Congratulations!");
                                return;

                            default:
                                Console.WriteLine("Invalid Choice! Either choose (door 1, door 2 or door 3) or just type (1, 2, 3)");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose a door!");
                    }
                }
            }
            static void fifthFloor()
            {
                Console.WriteLine("You manage to reach the fifth floor, way to go! You can do it.");
                Console.WriteLine("But let's not waste any time. The fate of coffee enjoyers relies on you.");
                Console.WriteLine("You raise you head and read the next riddle: ");
                Console.WriteLine("I am always hungry, I must always feed. The more I eat, the less I weigh. What am I?");
                Console.WriteLine("Door 1: A black hole.");
                Console.WriteLine("Door 2: A worm.");
                Console.WriteLine("Door 3: A fire.");
                string? riddle5 = null;
                while (true)
                {
                    riddle5 = Console.ReadLine()?.ToLower();
                    if (!string.IsNullOrWhiteSpace(riddle5))
                    {
                        switch (riddle5)
                        {
                            case "door 1":
                            case "1":
                                Console.WriteLine("You choose the first door.");
                                Console.WriteLine("You enter inside and then opens a swirling vortex that devours your resources. A voice whispers, “Memory leak detected!” Your strength" +
                                    " fades as the tower’s RAM overflows, crashing your quest.");
                                Console.WriteLine("Game Over: The Memory Leak Vortex Ending!");
                                gameOver = true;
                                return;

                            case "door 2":
                            case "2":
                                Console.WriteLine("You choose the second door.");
                                Console.WriteLine("As you enter inside a massive ogre who roars, “Index out of bounds!” You get crushed from the Array Ogre.");
                                Console.WriteLine("Game Over: The Array Ogre Ending!");
                                gameOver = true;
                                return;

                            case "door 3":
                            case "3":
                                Console.WriteLine("You choose the third door.");
                                Console.WriteLine("As you enter, you find a staircase.");
                                Console.WriteLine("It leads you to the next floor.");
                                Console.WriteLine("You chose the correct door! Congratulations!");
                                return;

                            default:
                                Console.WriteLine("Invalid Choice! Either choose (door 1, door 2 or door 3) or just type (1, 2, 3)");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose a door!");
                    }
                }
            }
            static void sixthFloor()
            {
                Console.WriteLine("This is it! the sixth and final floor.");
                Console.WriteLine("The last riddle.");
                Console.WriteLine("After you solve this one you'll manage to face the Wizard Bugger.");
                Console.WriteLine("You take a minute to catch yor breath and clear your mind, and then you starting reading the last riddle: ");
                Console.WriteLine("I am where the earth and sky appear to meet, always out of reach. I flee as you approach, yet I am always there. What am I?");
                Console.WriteLine("Door 1: The horizon.");
                Console.WriteLine("Door 2: A mirage.");
                Console.WriteLine("Door 3: A rainbow.");
                string? riddle6 = null;
                while (true)
                {
                    riddle6 = Console.ReadLine()?.ToLower();
                    if (!string.IsNullOrWhiteSpace(riddle6))
                    {
                        switch (riddle6)
                        {
                            case "door 1":
                            case "1":
                                Console.WriteLine("You choose the first door.");
                                Console.WriteLine("As you enter, you find a staircase.");
                                Console.WriteLine("It leads you to the next floor.");
                                Console.WriteLine("You chose the correct door! Congratulations!");
                                Console.WriteLine("You manage to solve all of the Wizard Riddles. Now it's time to put an end to his reign.");
                                return;

                            case "door 2":
                            case "2":
                                Console.WriteLine("You choose the second door.");
                                Console.WriteLine("As you enter, you find yourself in a chilling chamber where a revenant wails, “Runtime Error: ClassNotFound!” It binds you in chains " +
                                    "of broken dependencies, dooming you to haunt a corrupted class forever.");
                                Console.WriteLine("Game Over: The Runtime Error Ending!");
                                gameOver = true;
                                return;

                            case "door 3":
                            case "3":
                                Console.WriteLine("You choose the third door.");
                                Console.WriteLine("As you enter, a wraith summoned and demands from you to solve a cryptic regex puzzle. Your pattern fails to match, and the wraith " +
                                    "screeches, “Invalid escape sequence!” You’re shredded by a storm of backslashes.");
                                Console.WriteLine("Game Over: The Regex Riddle Wraith Ending!");
                                gameOver = true;
                                return;

                            default:
                                Console.WriteLine("Invalid Choice! Either choose (door 1, door 2 or door 3) or just type (1, 2, 3)");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose a door!");
                    }
                }
            }
            static void epilogue()
            {
                Console.WriteLine("You passed all the floors, answered all the riddles and now it's time to challenge the wizard.");
                Console.WriteLine("You enter his chamber and he was standing before you.");
                Console.WriteLine("Wizard: So manage to solve all of my riddles, good job. But unfortunately your journey ends here.");
                Console.WriteLine("He strikes lighting at you but you manage to dodge it.");
                Console.WriteLine("He prepares to strike you again.");
                Console.WriteLine("But you run to him and seconds before he releases his spells you cut him with your debugger sword");
                Console.WriteLine("Wizard: NOOOO...IMPOSSIBLE!");
                Console.WriteLine("The Evil Wizard Bugger was defeated and with him all of his plans to eliminate the caffeine.");
                Console.WriteLine("As you return back to the kingdom the king welcomes you as the hero and savior of caffeine and the programmers");
                Console.WriteLine("He gifts you the golden mug and throw a big celebration.");
                Console.WriteLine("Of course after that you'll have to return to your usual routine of debugging projects but at least you will have your coffee.");
                Console.WriteLine("Thank you for playing my Text Adventure Game.");
                Console.WriteLine("This game was written in Visual Studio in C# (.Net).");
                gameOver = true;
            }
            static void Main(string[] args)
            {
                gameOver = false;
                Console.WriteLine("My Text Adventure Game.");
                Console.WriteLine("A fun adventure-puzzle game");
                Console.WriteLine("Game Title: The Tower Of Riddles.");
                Console.WriteLine("Please enter your username:");
                intro();
                firstFloor();
                if (gameOver)
                {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }
                secondFloor();
                if (gameOver)
                {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }
                thirdFloor();
                if (gameOver)
                {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }
                fourthFloor();
                if (gameOver)
                {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }
                fifthFloor();
                if (gameOver)
                {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }
                sixthFloor();
                if (gameOver)
                {
                    Console.WriteLine("Thank you for playing!");
                    return;
                }
                epilogue();      
                if (gameOver)
                {
                    Console.WriteLine("Thank you for playing!");
                }
            }
        }
    }
}



