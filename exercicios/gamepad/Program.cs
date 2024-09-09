using System;

public enum TerrainEnum{
    Grass,
    Sand,
    Water,
    Wall
}

public static class TerrainEnumExtensions{
    public static ConsoleColor GetColor(this TerrainEnum terrain) {
        switch (terrain) {
            case TerrainEnum.Grass: return ConsoleColor.Green;
            case TerrainEnum.Sand: return ConsoleColor.Yellow;
            case TerrainEnum.Water: return ConsoleColor.Blue;
            default: return ConsoleColor.DarkGray;
        }
    }

    public static char GetChar(this TerrainEnum terrain) {
        switch(terrain){
            case TerrainEnum.Grass: return '\u201c';
            case TerrainEnum.Sand: return '\u25cb';
            case TerrainEnum.Water: return '\u2248';
            default: return '\u25cf';
        }
    }
}


class Program{
    static void Main(){
        TerrainEnum[,] map = {
            { TerrainEnum.Sand, TerrainEnum.Sand, TerrainEnum.Sand,
            TerrainEnum.Sand, TerrainEnum.Grass, TerrainEnum.Grass,
            TerrainEnum.Grass, TerrainEnum.Grass, TerrainEnum.Grass,
            TerrainEnum.Grass }, 
            { TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
            TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
            TerrainEnum.Water, TerrainEnum.Wall, TerrainEnum.Water, TerrainEnum.Water}

        };

        Console.OutputEncoding =  System.Text.Encoding.UTF8;
        for(int i = 0; i < map.GetLength(0); i++) {
            for(int j = 0; j < map.GetLength(1); j++) {

                Console.ForegroundColor = map[i,j].GetColor();
                Console.Write(map[i,j].GetChar()+ " ");
            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.Gray;

    }
}
