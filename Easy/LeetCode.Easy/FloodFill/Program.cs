using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFill
{
    // 733 - Flood Fill
    // https://leetcode.com/problems/flood-fill/
    internal class Program
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {

            int rows = image.Length;
            int cols = image[0].Length;

            int oldcolor = image[sr][sc];

            if (oldcolor == color)
                return image;

            void Dfs(int r, int c)
            {
                if (r < 0 || r >= rows || c < 0 || c >= cols)
                    return;

                if (image[r][c] != oldcolor)
                    return;

                image[r][c] = color;

                Dfs(r + 1, c);
                Dfs(r - 1, c);
                Dfs(r, c + 1);
                Dfs(r, c - 1);

            }

            Dfs(sr, sc);
            return image;
        }
    }
}
