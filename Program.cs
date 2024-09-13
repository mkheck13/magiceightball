// Magic 8 Ball

bool playAgain = true;
string breakLine = "----------------------------------------------------------------";
string quest;



Console.Clear();

// Word check block
while(playAgain){
    

    static bool userInput(string? input){
        if(string.IsNullOrEmpty(input)){
            return false;
        }
        foreach(char c in input){
            if(!char.IsLetter(c) && c != ' '){
                return false;
            }
        }
        return true;
    }

    // Question input
    while(true){
        Console.WriteLine(breakLine);
        Console.WriteLine("Ask my Magic 8 ball a yes or no question and we shall see what it says.");
        Console.WriteLine(breakLine);
        quest = Console.ReadLine();

        if(userInput(quest)){
            Console.Clear();
            break;
        }else{
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Really, just mash the keyboard with some letters so we can continue.");
            Console.WriteLine(breakLine);
        }

    }


    



    Console.WriteLine(breakLine);
    Console.WriteLine(quest);
    Random rnd = new Random();

    int randNum = rnd.Next(21);

    switch(randNum){
        case 0:
        Console.WriteLine("It is certain");
        Console.WriteLine(breakLine);
        break;

        case 1:
        Console.WriteLine("It is decidedly so");
        Console.WriteLine(breakLine);
        break;

        case 2:
        Console.WriteLine("Without a doubt");
        Console.WriteLine(breakLine);
        break;

        case 3:
        Console.WriteLine("Yes definitely");
        Console.WriteLine(breakLine);
        break;

        case 4:
        Console.WriteLine("You may rely on it");
        Console.WriteLine(breakLine);
        break;

        case 5:
        Console.WriteLine("As I see it, yes");
        Console.WriteLine(breakLine);
        break;

        case 6:
        Console.WriteLine("Most likely");
        Console.WriteLine(breakLine);
        break;

        case 7:
        Console.WriteLine("Outlook good");
        Console.WriteLine(breakLine);
        break;

        case 8:
        Console.WriteLine("Yes");
        Console.WriteLine(breakLine);
        break;

        case 9:
        Console.WriteLine("Signs point to yes");
        Console.WriteLine(breakLine);
        break;

        case 10:
        Console.WriteLine("Reply hazy, try again");
        Console.WriteLine(breakLine);
        break;

        case 11:
        Console.WriteLine("Ask again later");
        Console.WriteLine(breakLine);
        break;

        case 12:
        Console.WriteLine("Better not tell you now");
        Console.WriteLine(breakLine);
        break;

        case 13:
        Console.WriteLine("Cannot predict now");
        Console.WriteLine(breakLine);
        break;

        case 14:
        Console.WriteLine("Concentrate and ask again");
        Console.WriteLine(breakLine);
        break;

        case 15:
        Console.WriteLine("Don't count on it");
        Console.WriteLine(breakLine);
        break;

        case 16:
        Console.WriteLine("My reply is no");
        Console.WriteLine(breakLine);
        break;

        case 17:
        Console.WriteLine("My sources say no");
        Console.WriteLine(breakLine);
        break;

        case 18:
        Console.WriteLine("Outlook not so good");
        Console.WriteLine(breakLine);
        break;

        case 19:
        Console.WriteLine("Very doubtful");
        Console.WriteLine(breakLine);
        break;

        default:
        Console.WriteLine("ERROR 404");
        Console.WriteLine("PAGE NOT FOUND");
        Console.WriteLine(breakLine);
        break;
    }
    Console.WriteLine("Play again. 'yes' or 'no'.");
    Console.WriteLine(breakLine);
    bool yesNo = true;

    while(yesNo == true){
        string? userPlay = Console.ReadLine();
        if(userPlay?.ToLower() == "yes"){
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("Shake that 8 ball!!!");
            yesNo = false;
        }else if(userPlay?.ToLower() == "no"){
            Console.Clear();
            Console.WriteLine("So sad to see you go.");
            Console.WriteLine(breakLine);
            yesNo = false;
            playAgain = false;
        }else{
            Console.Clear();
            Console.WriteLine(breakLine);
            Console.WriteLine("That was not a yes or no. Do it again.");
            Console.WriteLine(breakLine);
        }
    }

}