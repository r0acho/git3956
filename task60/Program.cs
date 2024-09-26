int[,,] cube = new int[2,2,2] 
{
    {
        {12,34},
        {45,53}
    },
    {
        {64,85},
        {68,95}
    }
};

void ShowArraysOfCube(int[,,] cube)
{
    for(int i = 0; i < cube.GetLength(0); i++)
    {
        for(int j = 0; j < cube.GetLength(1); j++)
        {
            for(int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
ShowArraysOfCube(cube);