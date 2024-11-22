class Solution:
    def countUnguarded(self, m: int, n: int, guards: List[List[int]], walls: List[List[int]]) -> int:
        mapGrid = [[0] * n for _ in range(m)]
        
        #1 = guard
        for coord in guards:
            mapGrid[coord[0]][coord[1]] = 1

        #2 = wall
        for coord in walls:
            mapGrid[coord[0]][coord[1]] = 2
        '''
        print("initializing map")
        for row in mapGrid:
            print(row)
        '''
        #3 = guarded

        def markGuarded(row, col):
            #down
            for r in range(row+1, m):
                #if cell is occupied by another guard or has wall
                if mapGrid[r][col] == 1 or mapGrid[r][col] == 2:
                    break
                mapGrid[r][col] = 3
            #up
            for r in reversed(range(0, row)):
                if mapGrid[r][col] == 1 or mapGrid[r][col] == 2:
                    break
                mapGrid[r][col] = 3
            #right
            for c in range(col+1, n):
                if mapGrid[row][c] == 1 or mapGrid[row][c] == 2:
                    break
                mapGrid[row][c] = 3
            #left
            for c in reversed(range(0, col)):
                if mapGrid[row][c] == 1 or mapGrid[row][c] == 2:
                    break
                mapGrid[row][c] = 3
        
        for row, col in guards:
            markGuarded(row, col)

        count = 0
        #print("res")
        for row in mapGrid:
            #print(row)
            for cell in row:
                if cell == 0:
                    count += 1
        
        return count
