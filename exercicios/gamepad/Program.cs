public enum TerrainEnum{
    Grass,
    Sand,
    Water,
    Wall
}


public static class TerrainEnumExtensions{
    publicstatic ConsoleColor GetColor(this TerrainEnum terrain) {
        switch (terrain) {
            case TerrainEnum.Grass: return ConsoleColor.Green;
            case TerrainEnum.Sand: return ConsoleColor.Yellow;
            case TerrainEnum.Water: return ConsoleColor.Blue;
            default: return ConsoleColor.DarkGray;
        }
    }

    public static char GetChar(this TerrainEnum terrain) {
        case TerrainEnum.Grass: return '\u201c';
        case TerrainEnum.Sand: return '\u25cb';
        case TerrainEnum.Water: return '\u2248';
        default: return '\u25cf';
    }
}


TerrainEnum[,] map = {
    { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
    TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
    TerrainEnum.GRASS }, (...)
    { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
    TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WATER,    TerrainEnum.WATER}

};

Console.OutputEncoding =  UTF8Encoding.UTF8;
for(int i = 0; i < map.GetLenght(0); i++) {
    for(int j = 0; j < map.GetLenght(1); j++) {

        Console.ForegroundColor = map[i,j].GetColor();
        Console.write(map[i,j].GetChar()+ " ");
    }
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Gray;
