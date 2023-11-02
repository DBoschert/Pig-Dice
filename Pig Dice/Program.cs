var random = new Random();

for(int j = 0; j < 100000000; j++)
{


var score = 0;
var i = true;

while (i == true)
{
    var rnd = random.Next(1, 7);
    if(rnd != 1) { 
        score += rnd;
    }
    
    else
    {
        i = false;
       // Console.WriteLine("GAME OVER");

            if(score > 350)
            {
                Console.WriteLine("THIS ONE RIGHT HERE");
                Console.WriteLine($"score: {score}");
            }
    }
}
    
}
