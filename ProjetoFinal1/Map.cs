﻿using System;


namespace ProjetoFinal1
{
	public class Map
	{
        Random random = new Random();
        public IElement[,] Positions;
		public int Width { get; set; }
		public int Height { get; set; }
		public int Lvl { get; set; }
		
		public Map(int width, int height)
		{
			Width = width;
			Height = height;
			Positions = new IElement[Width, Height];
		}

		public void PopulateMap()
		{
			for (int x = 0; x < Height; x++)
			{
				for (int y = 0; y < Width; y++)
				{
					if (y == 0 && x == 0)
					{
						Positions[x, y] = new Robot(x, y, "ME");
					}
					else if ((y == 1 && x == 9) || (y == 8 && x == 8))
					{
						Positions[x, y] = new Jewel(x, y, "JR");
					}
					else if ((y == 9 && x == 1) || (y == 7 && x == 6))
					{
						Positions[x, y] = new Jewel(x, y, "JG");
					}
					else if ((y == 3 && x == 4) || (y == 2 && x == 1))
					{
						Positions[x, y] = new Jewel(x, y, "JB");
					}
					else if ((y == 5 && x <= 6))
					{
						Positions[x, y] = new Obstacle(x, y, "##");
					}
					else if (((y == 5 || y == 3) && x == 9) || (y == 2 && x == 5) || (y == 1 && x == 4))
					{
						Positions[x, y] = new Obstacle(x, y, "$$");
					}
					else
					{
						Positions[x, y] = new EmptySpace(x, y, "--");
					}

				}
			}
		}

		public void RandomMap()
		{
			int x,y;
            
            for (x = 1; x < Height; x++)
			{
				for (y = 1; y < Width; y++)
				{
					Positions[x, y] = new EmptySpace(x, y, "--");

                }
            }

            for (int z = 0; z < 2; z++)
			{
                x = random.Next(1, Height);
                y = random.Next(1, Width);
                Positions[x, y] = new Jewel(x, y, "JR");
			}
			for (int c = 0; c < 2; c++)
			{
                x = random.Next(1, Height);
                y = random.Next(1, Width);
				
				//while (Positions[x, y] == new EmptySpace(x, y, "--"))
    //            {
    //                x = random.Next(1, Height);
    //                y = random.Next(1, Width);
    //            }
                Positions[x, y] = new Jewel(x, y, "JG");           
			}
			for (int v = 0; v < 2; v++)
			{
                x = random.Next(1, Height);
                y = random.Next(1, Width);
                //while (Positions[x, y] != new EmptySpace(x, y, "--"))
                //{
                //    x = random.Next(1, Height);
                //    y = random.Next(1, Width);
                //}
                Positions[x, y] = new Jewel(x, y, "JB");
			}
			for (int b = 0; b < 7; b++)
			{
                x = random.Next(1, Height);
                y = random.Next(1, Width);
                //while (Positions[x, y] != new EmptySpace(x, y, "--"))
                //{
                //    x = random.Next(1, Height);
                //    y = random.Next(1, Width);
                //}
                Positions[x, y] = new Obstacle(x, y, "##");
			}
			for (int m = 0; m < 4; m++)
			{
                x = random.Next(1, Height);
                y = random.Next(1, Width);
                //while (Positions[x, y] == new EmptySpace(x, y, "--"))
                //{
                //    x = random.Next(1, Height);
                //    y = random.Next(1, Width);
                //}
                Positions[x, y] = new Obstacle(x, y, "$$");
			}
            for (int l = 0; l < 1; l++)
            {
                x = random.Next(1, Height);
                y = random.Next(1, Width);
                //while (Positions[x, y] == new EmptySpace(x, y, "--"))
                //{
                //    x = random.Next(1, Height);
                //    y = random.Next(1, Width);
                //}
                Positions[x, y] = new EmptySpace(x, y, "!!");
            }
            
        }


		public void PrintMap()
		{
                 
            for (int y = 0; y < Height; y++)
			{
				for (int x = 0; x < Width; x++)
				{
					Console.Write(Positions[x, y]);
					Console.ResetColor();
					Console.Write(" ");
				}
				Console.Write("\n");
			}
			
            
		}
	}
}
