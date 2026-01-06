using System.Collections.Generic;

namespace _0542_01_Matrix
{
    // LeetCode: https://leetcode.com/problems/01-matrix/
    // Difficulty: Medium
    // Approach: BFS
    // Time: O(m * n), Space: O(m * n)
    public class Solution
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;

            int[][] dist = new int[rows][];
            for (int i = 0; i < rows; i++)
                dist[i] = new int[cols];

            Queue<(int r, int c)> queue = new Queue<(int, int)>();

            int[][] directions = new int[][]
            {
                new int[] { 1, 0 },   // down
                new int[] { -1, 0 },  // up
                new int[] { 0, 1 },   // right
                new int[] { 0, -1 }   // left
            };

            // Initialize distances and queue with all 0s
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (mat[r][c] == 0)
                    {
                        dist[r][c] = 0;
                        queue.Enqueue((r, c));
                    }
                    else
                    {
                        dist[r][c] = int.MaxValue;
                    }
                }
            }

            // Multi-source BFS
            while (queue.Count > 0)
            {
                var (r, c) = queue.Dequeue();

                foreach (var d in directions)
                {
                    int nr = r + d[0];
                    int nc = c + d[1];

                    if (nr < 0 || nr >= rows || nc < 0 || nc >= cols)
                        continue;

                    if (dist[nr][nc] > dist[r][c] + 1)
                    {
                        dist[nr][nc] = dist[r][c] + 1;
                        queue.Enqueue((nr, nc));
                    }
                }
            }

            return dist;
        }
    }
}