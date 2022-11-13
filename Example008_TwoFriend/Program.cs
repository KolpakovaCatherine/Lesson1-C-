Console.WriteLine("Введите скорость первого друга");
int FirstFriedSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите скорость второго друга");
int SecondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите скорость собаки");
int DogSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите расстояние между друзьями");
int Distance = Convert.ToInt32(Console.ReadLine());

int friend = 2;
int count = 0;
int time = 0;

while (Distance < 10)
{
    if (friend == 1)
    {
        time = Distance / (FirstFriedSpeed + DogSpeed);
        friend = 2;
    }

    if (friend == 2)
    {
        time = Distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    Distance = Distance - (FirstFriedSpeed + SecondFriendSpeed) * time;
    count++;
}
Console.WriteLine(count);