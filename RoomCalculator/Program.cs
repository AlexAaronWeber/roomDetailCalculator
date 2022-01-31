

//intro
Console.WriteLine("Welcome to the Room Detail Calculator, where we calculate the perimeter and area of your room! Let's get started.");

//asking for length, width and height and storing in variables
Console.WriteLine("Please enter the length of your room in feet!");
double roomLength = double.Parse(Console.ReadLine());

Console.WriteLine("Thank you! Now, what is the width of your room in feet?");
double roomWidth = double.Parse(Console.ReadLine());

Console.WriteLine("Thank you! Now, what is the height of your room in feet?");
double roomHeight = double.Parse(Console.ReadLine());


//calculation variables
double perimeter = 2 * roomLength + 2* roomWidth;
double area = roomLength * roomWidth;
double volume = roomLength * roomWidth * roomHeight;
double surfaceArea = 2 * (roomWidth * roomLength + roomHeight * roomLength + roomHeight * roomWidth);

//calculations given to user
Console.WriteLine("Excellent! Calculation complete!");
Console.WriteLine("Perimiter: " + perimeter + " feet");
Console.WriteLine("Area: " + area + " square feet");
Console.WriteLine("Volume: " + volume + " cubic feet");
Console.WriteLine("Surface Area: " + surfaceArea + " feet");

//'if' loop to determine the size of the room based on the area
if (area <= 250) {
    Console.WriteLine("This is a small room");
} else if (250 < area && area <= 650)
{
    Console.WriteLine("This is a medium-sized room");
} else
{
    Console.WriteLine("This is a large room");
}

if (roomHeight > 15)
{
    Console.WriteLine("This is a tall room");
}

Console.WriteLine("Thank you for using the Room Detail Calculator!");

