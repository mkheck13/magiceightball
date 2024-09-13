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
        Console.WriteLine("Ask my Magic 8 ball a yes or no question and we shall see what it says.");
        quest = Console.ReadLine();

        if(userInput(quest)){
            Console.Clear();
            break;
        }else{
            Console.WriteLine("Really, just mash the keyboard so we can continue.");
        }

    }


    




    
    Random rnd = new Random();

    int randNum = rnd.Next(21);

    switch(randNum){
        case 0:
        Console.WriteLine("It is certain");
        break;

        case 1:
        Console.WriteLine("It is decidedly so");
        break;

        case 2:
        Console.WriteLine("Without a doubt");
        break;

        case 3:
        Console.WriteLine("Yes definitely");
        break;

        case 4:
        Console.WriteLine("You may rely on it");
        break;

        case 5:
        Console.WriteLine("As I see it, yes");
        break;

        case 6:
        Console.WriteLine("Most likely");
        break;

        case 7:
        Console.WriteLine("Outlook good");
        break;

        case 8:
        Console.WriteLine("Yes");
        break;

        case 9:
        Console.WriteLine("Signs point to yes");
        break;

        case 10:
        Console.WriteLine("Reply hazy, try again");
        break;

        case 11:
        Console.WriteLine("Ask again later");
        break;

        case 12:
        Console.WriteLine("Better not tell you now");
        break;

        case 13:
        Console.WriteLine("Cannot predict now");
        break;

        case 14:
        Console.WriteLine("Concentrate and ask again");
        break;

        case 15:
        Console.WriteLine("Don't count on it");
        break;

        case 16:
        Console.WriteLine("My reply is no");
        break;

        case 17:
        Console.WriteLine("My sources say no");
        break;

        case 18:
        Console.WriteLine("Outlook not so good");
        break;

        case 19:
        Console.WriteLine("Very doubtful");
        break;

        default:
        Console.WriteLine("ERROR 404");
        Console.WriteLine("PAGE NOT FOUND");
        break;
    }
    Console.WriteLine("Play again. 'yes' or 'no'.");
    bool yesNo = true;

    while(yesNo == true){
        string? userPlay = Console.ReadLine();
        if(userPlay?.ToLower() == "yes"){
            Console.WriteLine("Shake that 8 ball!!!");
            yesNo = false;
        }else if(userPlay?.ToLower() == "no"){
            Console.WriteLine("So sad to see you go.");
            yesNo = false;
            playAgain = false;
        }else{
            Console.WriteLine("That was not a yes or no. Do it again.");
        }
    }




















}