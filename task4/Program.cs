Console.Clear();
//Console.SetCursorPosition(10,15);
//Console.WriteLine("+");


int xa = 40, ya = 1,
    xb = 1, yb = 80,
    xc = 80, yc = 80;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while(count < 100000)
{
    int What = new Random().Next(0,3); // [0;3] 0 1 2
    if (What == 0)
    x = (x + xa) / 2;
    y = (y + ya) / 2;


    if(What == 1)
    {   
      x = (x + xb) / 2;
      y = (y + yb) / 2;
    
    }

    if(What == 2)
    {
     x = (x + xc) / 2;
     y = (y + yc) / 2;
     Console.SetCursorPosition(x, y);
     Console.WriteLine("+");
     count++;
    }
}  