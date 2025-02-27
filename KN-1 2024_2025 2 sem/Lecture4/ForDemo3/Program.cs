for (int i = 0; i < 10; ++i)
{
    if (i % 3 == 0)
        continue;

    Console.Write(i + " ");

    if (i % 7 == 0)
        break;
}

// Output: 1 2 4 5 7